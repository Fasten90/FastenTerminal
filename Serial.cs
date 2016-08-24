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

	}


	public class Serial
	{

		public string[] ComAvailableList;
		public string ComSelected = "";
		public System.IO.Ports.SerialPort serial;
		public string Baudrate = "115200";
		public bool isOpenedPort = false;
		private const Int32 preferredBaudrate = 115200;
		public string stateInfo = "";

		public bool receiverModeBinary = false; // TODO:
		public bool needToConvertHex = false;   // TODO: 
		public bool needAppendPerRPerN { get; set; }

		public bool PeriodSendingEnable = false;
		public decimal PeriodSendingTime = 5;
		private System.Windows.Forms.Timer PeriodSendingTimer;
		private string PeriodSendingMessage = "";

		// LOG - settings
		public bool NeedLog = true;
		public bool LogWithDateTime = true;

		// LOG - aux variables
		private String logMessage = "";

		public char ProcessStartCharacter = '\r';


		private Object SerialReceiveLocker = new Object();
		string receivedSerialMessage = "";
		string actualReceivedSerialMessage = "";

		private Object serialMessageLock = new Object();



		private FastenTerminal form;



		public Serial(System.IO.Ports.SerialPort serial, FastenTerminal form)
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
				form.AppendTextSerialLogData(errorMessage);
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
					form.AppendTextSerialLogData(message);
					isOpenedPort = true;
					return true;
				}
				catch (Exception e)
				{
					String errorMessage = "[Application] Error with port opening.\n";
					Log.SendErrorLog(errorMessage + e.Message);
					form.AppendTextSerialLogData(errorMessage);
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

			String message = "[Application] Closed Serial port";
			form.AppendTextSerialLogData(message);
			Log.SendEventLog(message);

			stateInfo = "Closed";
			isOpenedPort = false;
		}



		public void Receive()
		{
			// Help: http://stackoverflow.com/questions/8843301/c-sharp-winform-freezing-on-serialport-close
			// For not dead-lock

			// TODO: https://blogs.msdn.microsoft.com/bclteam/2006/10/10/top-5-serialport-tips-kim-hamilton/

			try
			{


				lock (SerialReceiveLocker)
				{
					if (receiverModeBinary)
					{
						// TODO:
						//BytesToRead
						//receivedSerialMessage + serial.Read
					}
					else
					{
						// Append to buffer
						actualReceivedSerialMessage = serial.ReadExisting();
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
				//put other, more interesting error handling here.
			}

		}



		private void AppendReceivedTextToGui(string message)
		{

			if (needToConvertHex)
			{
				// Convert hex
				message = Common.ToHexString(message);
			}
			else
			{
				// Not need to convert hex
			}


			// Print on output text
			// For richText, where \r\n is two new line, we need only one newline
			// Drop '\n', and hold '\r'
			String dropCharacter = "\n";
			String printString = "";
			if (message.Contains(dropCharacter))
			{
				printString = message.Replace(dropCharacter, String.Empty);
			}
			else
			{
				printString = message;
			}

			//////////////////////////////////
			//  Append text on serial log
			//////////////////////////////////
			form.AppendTextSerialLogData(printString);

		}



		public void DataReceived(object state)
		{
			String receivedMessage = "";


			// Event function - received serial message

			// For secure: drop "" (null) string
			if (receivedSerialMessage == "")
			{
				// Do not Log this null message
				return;
			}


			// Get string from serial buffer
			lock (SerialReceiveLocker)
			{
				receivedMessage = receivedSerialMessage;
				receivedSerialMessage = "";
			}


			// OLD version: PROBLEM: once character is printed one line
			// Example: received "Fasten", printed in log sometimes, "F", "a", "st", "en" "\r\n"


			// Save received message

			lock (serialMessageLock)
			{

				if (logMessage == "")
				{
					// Drop first newline characters
					logMessage = DropStartNewlineCharacters(receivedMessage);
				}
				else
				{
					// We have a string, it is endline characters
					// Append
					logMessage += receivedMessage;
				}



				// Has end character?
				int length = IsHasEndCharacter(logMessage);
				if ((length > -1) && (logMessage != "") && (length <= logMessage.Length))
				{
					// Has end character, and not start with it
					// First "line"
					String processMessage = logMessage.Substring(0, (length + 1));
					processMessage = DropEndNewlineCharacters(processMessage);

					// After line
					logMessage = logMessage.Substring((length + 1));
					// Drop newline characters from begin
					logMessage = DropStartNewlineCharacters(logMessage);

					// This is a line, which can be processing
					// Process message (Log and process)
					ProcessLine(processMessage);
				}

			}
		}



		private void ProcessLine(string processMessage)
		{
			// Send to protocol Checker
			// TODO: do with "event" or delegate

			// Process
			if (processMessage != "")
			{

				// Need log?
				if (NeedLog)
				{
					if (LogWithDateTime)
					{
						// Put DateTime
						SerialLog.SendLog(processMessage, true);
					}
					else
					{
						// Do not put DateTime
						SerialLog.SendLog(processMessage);
					}
				}

			}

			return;
		}



		private int IsHasEndCharacter(string message)
		{
			int length = -1;
			int result = -1;

			if (message != "")
			{
				// newline characters
				List<char> newlineCharacters = new List<char>();
				newlineCharacters.Add('\r');
				newlineCharacters.Add('\n');
				newlineCharacters.Add('\0');

				foreach (char endCharacter in newlineCharacters)
				{
					result = message.IndexOf(endCharacter);

					// The first endLine character index:
					if (result > -1)
					{
						// Found end character
						if (length == -1)
						{
							// This is the first endline character
							length = result;
						}
						else
						{
							if (length > result)
							{
								// We found before endline character
								// But this is the first endline character
								length = result;
							}
							else
							{
								// We found before endline character
								// But this is after that
								// length = length;
							}
						}
					}
				}
			}

			return length;
		}



		private bool IsHasStartEndCharacter(string receivedMessage)
		{
			// Is start with end character?
			if (receivedMessage.StartsWith("\r") ||
				receivedMessage.StartsWith("\n") ||
				receivedMessage.StartsWith("\0")
				)
			{
				return true;
			}
			else
			{
				return false;
			}
		}



		private string DropStartNewlineCharacters(string receivedMessage)
		{
			String goodMessage = "";

			for (int i = 0; i < receivedMessage.Length; i++)
			{
				if (IsHasStartEndCharacter(receivedMessage))
				{
					// Started with "\n", do not put it	
					receivedMessage = receivedMessage.Substring(1);
				}
				else
				{
					// Normal message, not start with "\n"
					break;
				}
			}

			// Finish
			goodMessage = receivedMessage;

			return goodMessage;

		}



		private string DropEndNewlineCharacters(string processMessage)
		{
			String goodMessage = processMessage;

			int length = 0;

			while (length != -1)
			{
				length = IsHasEndCharacter(goodMessage);

				if (length > -1)
				{
					// Drop end character
					goodMessage = processMessage.Substring(0, length);
				}
			}

			return goodMessage;
		}



		public String SendMessage(String message, bool printOutput = false)
		{
			String logMessage;

			if (needAppendPerRPerN)
			{
				message += "\r\n";
			}

			if (isOpenedPort)
			{
				try
				{
					// Send
					//serial.WriteLine(message);	// Be careful, sending with newline '\n' character
					serial.Write(message);          // Send without newline
													// Successful
					logMessage = "[Application] Successful sent message\t" + message + "\n";
				}
				catch (Exception e)
				{
					Log.SendErrorLog(e.Message);
					logMessage = "[Application] Port error\n";
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

			if (printOutput)
			{
				form.AppendTextSerialLogData(logMessage);
			}

			return logMessage;
		}


		public void PeriodSendingStart(decimal sec, string message)
		{
			// Start periodical sending
			PeriodSendingEnable = true;
			PeriodSendingTime = sec;
			PeriodSendingMessage = message;

			// Start timer
			PeriodSendingTimer = new System.Windows.Forms.Timer();
			PeriodSendingTimer.Interval = (int)PeriodSendingTime * 1000;    // =millisec
			PeriodSendingTimer.Enabled = true;
			PeriodSendingTimer.Start();
			PeriodSendingTimer.Tick += new System.EventHandler(this.timerPeriodTimerSending_Tick);

			// Log
			string logMessage = "[Application] Periodical message sending started...\n" +
				"  Time: " + PeriodSendingTime.ToString() + "  Message: " + PeriodSendingMessage + "\n";

			form.AppendTextSerialLogData(logMessage);
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

			form.AppendTextSerialLogData(logMessage);
			Log.SendEventLog(logMessage);

		}


		private void timerPeriodTimerSending_Tick(object sender, EventArgs e)
		{
			// Period Sending time actual

			// Send message
			SendMessage(PeriodSendingMessage, true);

			// Log
			//form.AppendTextSerialLogData("[Application] Periodical sending message:\n\t" + PeriodSendingMessage +"\n");
		}


	}
}


