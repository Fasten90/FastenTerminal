using FastenTerminal;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
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

		public bool needToConvertHex { get; set; }
		public bool needAppendPerRPerN { get; set; }

		public bool PeriodSendingEnable = false;
		public decimal PeriodSendingTime = 5;
		private Timer PeriodSendingTimer;
		private string PeriodSendingMessage = "";

		// LOG
		public bool NeedLog { get; set; }
		public bool LogWithDateTime { get; set; }
		String logMessageToFile = "";

		// For "\r\n" break detect. if "\r" received last character, it is true
		bool LastCharIsPerR = false;

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
				form.AppendTextSerialData(errorMessage);
				return false;
			}
			else
			{
				// Good COM
				serial.PortName = ComSelected;
				if ( Baudrate != "")
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
					form.AppendTextSerialData(message);
					isOpenedPort = true;
					return true;
				}
				catch (Exception e)
				{
					String errorMessage = "[Application] Error with port opening.\n";
					Log.SendErrorLog(errorMessage + e.Message);
					form.AppendTextSerialData(errorMessage);
					return false;
				}
				
				
			}
			

		}



		public void SerialPortComClose()
		{
			try
			{
				serial.Close();
				stateInfo = "Closed";
			}
			catch (Exception e)
			{
				Log.SendErrorLog(e.Message);
			}

			String message = "[Application] Closed Serial port";
			form.AppendTextSerialData(message);
			Log.SendEventLog(message);
			isOpenedPort = false;
		}


		public void DataReceived()
		{
			// Event function - received serial message

			string receivedMessage = "";

			//receivedMessage += serial.ReadLine();		// Old version: Has problem, if not received a string with newline
			//receivedMessage += serial.ReadExisting();	// Good, but now we converted to hex if need

			if (needToConvertHex)
			{
				// Convert hex
				receivedMessage += Common.ToHexString(serial.ReadExisting());
			}
			else
			{
				// Not need to convert hex
				receivedMessage += serial.ReadExisting();
			}

			// Print on output text
			form.AppendTextSerialData(receivedMessage);


			// Log
			if (NeedLog)
			{
				// OLD version: PROBLEM: once character is printed one line
				// Example: received "Fasten", printed in log sometimes, "F", "a", "st", "en" "\r\n"
				//SerialLog.SendLog(receivedMessage);

				// Log with line

				// Append texts
				if (LastCharIsPerR)
				{
					// Last char is \r, now if start character \n, do not put newline
					if (receivedMessage.StartsWith("\n"))
					{
						// Started with "\n", do not put it	
						logMessageToFile += receivedMessage.Substring(1);
					}
					else
					{
						// Normal message, not start with "\n"
						logMessageToFile += receivedMessage;
					}
				}
				else
				{
					// Last char is not \r, it is ok
					logMessageToFile += receivedMessage;
				}
		
				// Is contain line breaking
				if ( receivedMessage.Contains('\r')
					|| receivedMessage.Contains('\n')
					|| receivedMessage.Contains('\0')
					)
				{
					if (receivedMessage.EndsWith("\r"))
					{
						// End with "\r"
						LastCharIsPerR = true;
					}
					else
					{
						// Not end with "\r"
						LastCharIsPerR = false;
					}

					// Contain line breaking, print to LOG
					if (LogWithDateTime)
					{
						// Put DateTime
						SerialLog.SendLog(logMessageToFile,true);
					}
					else
					{
						// Do not put DateTime
						SerialLog.SendLog(logMessageToFile);
					}
					logMessageToFile = "";
				}
				else
				{
					// Need to be containing and appending received message
				}
				
			}
			
		}


		public String SendMessage(String message, bool printOutput=false)
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
					serial.Write(message);			// Send without newline

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

				if(PeriodSendingEnable)
				{
					PeriodSendingStop();
				}
			}

			if (NeedLog)
			{
				SerialLog.SendLog(logMessage,true);
			}

			if(printOutput)
			{
				form.AppendTextSerialData(logMessage);
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
			PeriodSendingTimer = new Timer();
			PeriodSendingTimer.Interval = (int)PeriodSendingTime * 1000;	// =millisec
			PeriodSendingTimer.Enabled = true;
			PeriodSendingTimer.Start();
			PeriodSendingTimer.Tick += new System.EventHandler(this.timerPeriodTimerSending_Tick);

			// Log
			string logMessage = "[Application] Periodical message sending started...\n" +
				"  Time: " + PeriodSendingTime.ToString() + "  Message: " + PeriodSendingMessage + "\n";

			form.AppendTextSerialData(logMessage);
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

			form.AppendTextSerialData(logMessage);
			Log.SendEventLog(logMessage);

		}


		private void timerPeriodTimerSending_Tick(object sender, EventArgs e)
		{
			// Period Sending time actual

			// Send message
			SendMessage(PeriodSendingMessage, true);

			// Log
			//form.AppendTextSerialData("[Application] Periodical sending message:\n\t" + PeriodSendingMessage +"\n");
		}

	}
}
