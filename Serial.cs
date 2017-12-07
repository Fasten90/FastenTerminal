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
						actualReceivedSerialMessage = Common.ByteArrayToString(data);
						receivedSerialMessage += actualReceivedSerialMessage;

						// Append to GUI
						AppendReceivedTextToGui(actualReceivedSerialMessage);
					}
					else
					{
                        // String mode

						// Append to buffer
						actualReceivedSerialMessage = serial.ReadExisting();
                        // TODO: If we have a large message, this operation is slow (~5ms)
                        receivedSerialMessage += actualReceivedSerialMessage;


						// Append to GUI
						AppendReceivedTextToGui(actualReceivedSerialMessage);
					}
				}


				// Need to process?
				if (receivedSerialMessage.Contains(ProcessStartCharacter))
				{
					// Received "process character"
					ThreadPool.QueueUserWorkItem(DataReceived);
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
			if (needToConvertHex && !receiverModeBinary)
			{
				// If need convert to hex and not binary mode
				// Convert hex
				message = Common.ToHexString(message);
			}
			else if (receiverModeBinary)
			{
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
            else
            {
                // Not need to convert hex
            }


            //////////////////////////////////
            //  Append received text on serial log
            //////////////////////////////////
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
                    if (PeriodSendingEnable)
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

				if (PeriodSendingEnable)
				{
					PeriodSendingStop();
				}
			}

			if (NeedLog)
			{
				SerialLog.SendLog(logMessage, true);
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
			PeriodSendingEnable = true;
			PeriodSendingTime = sec;
			PeriodSendingMessage = message;

			// Start timer
			PeriodSendingTimer = new System.Windows.Forms.Timer();
			PeriodSendingTimer.Interval = (int)(PeriodSendingTime * 1000);    // =millisec
			PeriodSendingTimer.Enabled = true;
			PeriodSendingTimer.Start();
			PeriodSendingTimer.Tick += new System.EventHandler(this.timerPeriodTimerSending_Tick);

			// Log
			string logMessage = "[Application] Periodical message sending started...\n" +
				"  Time: " + PeriodSendingTime.ToString() + "  Message: " + PeriodSendingMessage + "\n";

			form.AppendTextSerialLogEvent(logMessage);
			Log.SendEventLog(logMessage);
		}



		public void PeriodSendingStop()
		{
			// Stop periodical sending
			PeriodSendingEnable = false;

			// Stop timer
			PeriodSendingTimer.Stop();
			PeriodSendingTimer.Enabled = false;

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
			SendMessage(PeriodSendingMessage, true);

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
