using FastenTerminal;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// For timer
using System.Windows.Forms;


namespace FastenTerminal
{

	public class SerialConfig
	{
		// TODO: implement this
	}


	public class Serial : Communication
	{
		public string[] ComAvailableList;
		public string ComSelected = "";
		public System.IO.Ports.SerialPort serial;
		public string Baudrate = "115200";
		public bool isOpenedPort = false;
		private const Int32 preferredBaudrate = 115200;


		public Serial(System.IO.Ports.SerialPort serial, FormFastenTerminal form)
		{
			this.serial = serial;

			this.form = form;

			SerialPortComRefresh();
		}


		public void SerialPortComRefresh()
		{
			// Get active ports
			ComAvailableList = SerialPort.GetPortNames();
		}


		public bool SerialPortComOpen()
		{
			if (ComSelected == null || ComSelected == "")
			{
				// Wrong COM
				String errorMessage = "[Application] Error: Empty portname\n";
				Log.SendErrorLog(errorMessage);
				form.AppendTextSerialLogEvent(errorMessage);
				return false;
			}
			else
			{
				// Good COM
				serial.PortName = ComSelected;
				if (Baudrate != "")
				{
					serial.BaudRate = Int32.Parse(Baudrate);
				}
				else
				{
					serial.BaudRate = preferredBaudrate;
				}

				try
				{
					serial.Open();
					stateInfo = serial.PortName + " - " + serial.BaudRate;
					String message = "[Application] Successful open serial port. " +
									serial.PortName + " " + serial.BaudRate + "\n";
					Log.SendEventLog(message);
					form.AppendTextSerialLogEvent(message);
					isOpenedPort = true;
					return true;
				}
				catch (Exception e)
				{
					String errorMessage = "[Application] Error with port opening.\n";
					Log.SendErrorLog(errorMessage + e.Message);
					form.AppendTextSerialLogEvent(errorMessage);
					return false;
				}
			}
		}



		public void SerialPortComClose()
		{
			// Create new thread
			Thread closeThread = new Thread(SerialPortCloseInOtherThread);
			closeThread.Start();
		}



		private void SerialPortCloseInOtherThread()
		{
			try
			{
				serial.Close();
			}
			catch (Exception e)
			{
				Log.SendErrorLog(e.Message);
			}

			String message = "[Application] Closed Serial port\n";
			if (needPrint)
			{
				form.AppendTextSerialLogEvent(message);
			}
			Log.SendEventLog(message);

            SerialRegistrateClose();
        }



		public void Receive()
		{
			// Help: http://stackoverflow.com/questions/8843301/c-sharp-winform-freezing-on-serialport-close
			// For not dead-lock

			// TODO: https://blogs.msdn.microsoft.com/bclteam/2006/10/10/top-5-serialport-tips-kim-hamilton/

			try
			{
				lock (receiveLocker)
				{
					if (receiverModeBinary)
					{
						// Binary mode

						int dataLength = serial.BytesToRead;
						byte[] data = new byte[dataLength];
						int nbrDataRead = serial.Read(data, 0, dataLength);

						// Append to buffer
						actualReceivedMessage = Common.ByteArrayToString(data);
						receivedMessage += actualReceivedMessage;

						// Append to GUI
						AppendReceivedTextToGui(actualReceivedMessage);

                        // Save, if has long msg
                        if (receivedMessage.Length > 50)
                        {
                            // Received "process character"
                            ThreadPool.QueueUserWorkItem(SaveLineLog);
                        }
                    }
					else
					{
                        // String mode

						// Append to buffer
						actualReceivedMessage = serial.ReadExisting();
                        // TODO: If we have a large message, this operation is slow (~5ms)
                        receivedMessage += actualReceivedMessage;


						// Append to GUI
						AppendReceivedTextToGui(actualReceivedMessage);


                        // Need to save? (have we a line?)
                        if (receivedMessage.IndexOfAny(LogSaveStartCharacters.ToCharArray()) != -1)
                        {
                            // Received "process character"
                            ThreadPool.QueueUserWorkItem(SaveLineLog);
                        }
                    }
				}
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine(ex.ToString());
				Log.SendErrorLog(ex.Message);
				// TODO: Put other, more interesting error handling here.
			}
		}



		private void AppendReceivedTextToGui(string message)
		{
            if (!receiverModeBinary)
            {
                // String mode

                // New line
                // Print on output text
                // For richText, where \r\n is two new line, we need only one newline
                // Drop '\n', and hold '\r'
                String dropCharacter = "\n";
                if (message.Contains(dropCharacter))
                {
                    message = message.Replace(dropCharacter, String.Empty);
                }

                // Replace '\r' to '\r\n'
                String needReplaceCharacter = "\r";
                message = message.Replace(needReplaceCharacter, Environment.NewLine);
            }

            /*
             *      Append received text on serial log
             */
            form.AppendTextSerialLogData(message);
		}



		public String SendMessage(String message, bool printOutput = false)
		{
			String logMessage;

			if (newLineString != null)
			{
				message += newLineString;
			}

			if (isOpenedPort)
			{
				try
				{
					// Send
					//serial.WriteLine(message);	// Be careful, sending with newline '\n' character
					serial.Write(message);          // Send without newline
													// Successful
					logMessage = "\n[Application] Successful sent message:\t" + message + "\n";
				}
				catch (Exception e)
				{
					Log.SendErrorLog(e.Message);
					logMessage = "[Application] Port error\n";

                    // Stop periodical sending
                    if (PeriodSending_Enable)
                    {
                        PeriodSendingStop();
                    }

                    // Serial error, close the port
                    SerialError();
                }
			}
			else
			{
				logMessage = "[Application] Cannot send message, because there is not opened port\n";

				if (PeriodSending_Enable)
				{
					PeriodSendingStop();
				}
			}

			if (NeedLog)
			{
				MessageLog.SendLog(logMessage, true);
			}

			if (printOutput && printSentEvent)
			{
				form.AppendTextSerialLogEvent(logMessage);
			}

			return logMessage;
		}



		public void PeriodSendingStart(float sec, string message)
		{
			// Start periodical sending
			PeriodSending_Enable = true;
			PeriodSending_Time = sec;
			PeriodSending_Message = message;

			// Start timer
			PeriodSending_Timer = new System.Windows.Forms.Timer();
			PeriodSending_Timer.Interval = (int)(PeriodSending_Time * 1000);    // =millisec
			PeriodSending_Timer.Enabled = true;
			PeriodSending_Timer.Start();
			PeriodSending_Timer.Tick += new System.EventHandler(this.timerPeriodTimerSending_Tick);

			// Log
			string logMessage = "[Application] Periodical message sending started...\n" +
				"  Time: " + PeriodSending_Time.ToString() + "  Message: " + PeriodSending_Message + "\n";

			form.AppendTextSerialLogEvent(logMessage);
			Log.SendEventLog(logMessage);
		}



		public void PeriodSendingStop()
		{
			// Stop periodical sending
			PeriodSending_Enable = false;

			// Stop timer
			PeriodSending_Timer.Stop();
			PeriodSending_Timer.Enabled = false;

			// Log
			string logMessage = "[Application] Periodical message sending stopped\n";

			form.AppendTextSerialLogEvent(logMessage);
			Log.SendEventLog(logMessage);

            // Not running state
            form.SerialPeriodSend_SetState(false);
        }



		private void timerPeriodTimerSending_Tick(object sender, EventArgs e)
		{
			// Period Sending time actual

			// Send message
			SendMessage(PeriodSending_Message, true);

			// Log
			//form.AppendTextSerialLogEvent("[Application] Periodical sending message:\n\t" + PeriodSendingMessage +"\n");
		}



        public void SerialError()
        {
            // Close serial port, because has error
            if (serial.IsOpen)
            {
                SerialPortCloseInOtherThread();
            }
            else
            {
                SerialRegistrateClose();
            }
        }


   
        private void SerialRegistrateClose()
        {
            stateInfo = "Closed";
            isOpenedPort = false;
            form.SerialSetStateOpenedOrClosed(false);
        }
    }
}
