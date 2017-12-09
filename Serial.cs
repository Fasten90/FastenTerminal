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
	public class Serial : Communication
	{
		public string[] ComAvailableList;
		public string ComSelected = "";
		public System.IO.Ports.SerialPort serial;
		public string Baudrate = "115200";
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
				form.AppendTextLogEvent(errorMessage);
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
					form.AppendTextLogEvent(message);
					isOpened = true;
					return true;
				}
				catch (Exception e)
				{
					String errorMessage = "[Application] Error with port opening.\n";
					Log.SendErrorLog(errorMessage + e.Message);
					form.AppendTextLogEvent(errorMessage);
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
				form.AppendTextLogEvent(message);
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

		public override String SendMessage(String message)
		{
			String logMessage;

			if (newLineString != null)
			{
				message += newLineString;
			}

			if (isOpened)
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

			if (printSentEvent)
			{
				form.AppendTextLogEvent(logMessage);
			}

			return logMessage;
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
            isOpened = false;
            form.SerialSetStateOpenedOrClosed(false);
        }
    }
}
