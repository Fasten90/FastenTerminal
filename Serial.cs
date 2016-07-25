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
		

		private FastenTerminal form;



		public Serial(System.IO.Ports.SerialPort serial, FastenTerminal form)
		{
			this.serial = serial;

			this.form = form;

			SerialPortComRefresh();
		}


		public void SerialPortComRefresh()
		{

			ComAvailableList = SerialPort.GetPortNames();

		}


		public bool SerialPortComOpen()
		{
			if (ComSelected == null || ComSelected == "")
			{
				// Wrong COM
				String errorMessage = "Error: Empty portname\n";
				Log.SendErrorLog(errorMessage);
				form.AppendTextSerialData("[Application] " + errorMessage);
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
					Log.SendEventLog("Opened serial port");
					isOpenedPort = true;
					return true;
				}
				catch (Exception e)
				{
					String errorMessage = "Error with port opening.\n";
					Log.SendErrorLog(errorMessage + e.Message);
					form.AppendTextSerialData("[Programmer] " + errorMessage);
					return false;
				}
				
				
			}
			

		}


		public void SetComSelected(string com)
		{
			ComSelected = com;
		}

		public void SetBaudrateSelected(string baudrate)
		{
			Baudrate = baudrate;
		}



		public void SerialPortComClose()
		{
			try
			{
				serial.Close();
			}
			catch (Exception e)
			{
				Log.SendErrorLog(e.Message);
			}

			Log.SendEventLog("Closed Serial port");
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

			form.CheckFwUpateMessageAndSend(receivedMessage);

			// Log
			if (NeedLog)
			{
				// OLD version: PROBLEM: once character is printed one line
				//SerialLog.SendLog(receivedMessage);

				// Log with line

				// Append texts
				logMessageToFile += receivedMessage;
		
				// Is contain line breakingM
				if ( receivedMessage.Contains('\r')
					|| receivedMessage.Contains('\n')
					|| receivedMessage.Contains('\0')
					)
				{
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
					serial.WriteLine(message);
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
