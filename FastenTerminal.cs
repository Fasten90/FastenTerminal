using FastenTerminal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FastenTerminal
{
    public partial class FastenTerminal : Form
    {
		// Configs:
		public const bool NotifyIsEnabled = false;


		// Others

		public Serial serial;

		public CommandHandler command;

		List<Button> commandListOnButtons;

		//public BindingSource commandList;
		public List<Command> commandList;

		FwUpdate fwUpdate;

		public bool FwUpdateWaitMessage;

		bool SerialMessageTextBoxEntered = false;

		int SerialMessageActualCaret = 0;
		int SerialMessageActualSelectionLength = 0;


		const String SerialHeader = "!";	// TODO: delete


        public FastenTerminal()
        {
            InitializeComponent();
        }


        private void FormFastenTerminalMain_Load(object sender, EventArgs e)
        {


			// Load Serial
			serial = new Serial(serialPortDevice, this);

			serial.NeedLog = checkBoxSerialPortLog.Checked;
			serial.needAppendPerRPerN = checkBoxSerialAppendPerRPerN.Checked;
			comboBoxSerialPortBaudrate.SelectedIndex = 0;


			SerialRefresh();

			// Load commands
			command = new CommandHandler(this);
			LoadCommandsToButtons();

			LoadCommandsToSetting();


			// Message Header type
			LoadMessageHeaders();

			// Notify
			if (NotifyIsEnabled)
			{ 
				notifyIconApplication.Visible = true;  
			}
        }


		////////////////////////////////////////////////
		//			 SERIAL
		////////////////////////////////////////////////


		private void buttonSerialPortRefresh_Click(object sender, EventArgs e)
		{
			// Clicked "Serial Refresh" button
			SerialRefresh();
		}


		private void SerialRefresh()
		{
			// Refresh Serial COM ports
			serial.SerialPortComRefresh();

			if (serial.ComAvailableList != null && serial.ComAvailableList.Length != 0) 
			{
				// Clear
				comboBoxSerialPortCOM.Items.Clear();

				// Load new values
				foreach (string s in serial.ComAvailableList)
				{
					comboBoxSerialPortCOM.Items.Add(s);
				}

				comboBoxSerialPortCOM.SelectedIndex = 0;

			}


			// Wrong
			//comboBoxSerialPortCOM.DataSource = serial.ComAvailableList;
		}

		private void buttonSerialPortOpen_Click(object sender, EventArgs e)
		{
			SerialOpenClose();
		}

		private void SerialOpenClose()
		{
			if (serial.isOpenedPort == false)
			{
				// If not opened
				if (serial.SerialPortComOpen())
				{
					buttonSerialPortOpen.Text = "Port bezárása";
				}

			}
			else
			{
				// If opened
				serial.SerialPortComClose();
				buttonSerialPortOpen.Text = "Port nyitás";
			}
			

		}


		private void comboBoxSerialPortCOM_SelectedIndexChanged(object sender, EventArgs e)
		{
			serial.SetComSelected((string)comboBoxSerialPortCOM.SelectedItem);
		}

		private void comboBoxSerialPortBaudrate_SelectedIndexChanged(object sender, EventArgs e)
		{
			serial.SetBaudrateSelected((string)comboBoxSerialPortBaudrate.SelectedItem);
		}

		private void serialPortDevice_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			serial.DataReceived();
		}



		public void AppendTextSerialData( string value)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<string>(AppendTextSerialData), new object[] { value });
				return;
			}

			// Original text appending, It Work!!
			//richTextBoxSerialPortTexts.Text += value;

			if (checkBoxSerialTextColouring.Checked)
			{

				// Coloring:
				// ESC[39mESC[31m
				//0x1B
				//const char ESC = '\x1B';
				//(char)27).ToString());

				// Contain escape
				if (value.StartsWith(((char)27).ToString()))
				{

					Color textColor = Color.Black;
				
					// Checked coloring
					textColor = GetColor(value);
			
					// Substring after ESC
					String textWithoutEscape = value.Substring(10);			// TODO: Elegánsabban kéne kivenni az ESC[... részt
					value = textWithoutEscape;
				
					//richTextBoxSerialPortTexts.SelectionColor = textColor;
					//richTextBoxSerialPortTexts.AppendText(value); // If you use it, it automatic scroll bottom
				
					/*
					int startCount = richTextBoxSerialPortTexts.TextLength;
					richTextBoxSerialPortTexts.Text += value;
					richTextBoxSerialPortTexts.Select(startCount, value.Length);
					richTextBoxSerialPortTexts.SelectionColor = textColor;
					*/
				}
				else
				{
					// If not started with Escape

					//richTextBoxSerialPortTexts.SelectionColor = Color.Black;
					//richTextBoxSerialPortTexts.AppendText(value);

					/*
					int startCount = richTextBoxSerialPortTexts.TextLength;
					richTextBoxSerialPortTexts.Text += value;
					richTextBoxSerialPortTexts.Select(startCount, value.Length);
					richTextBoxSerialPortTexts.SelectionColor = Color.Black;
					*/
				}
			}

			// Append texts
			richTextBoxSerialPortTexts.Text += value;

			/*
			richTextBoxSerialPortTexts.SelectionColor = textColor;
			richTextBoxSerialPortTexts.AppendText(value); // If you use it, it automatic scroll bottom
			*/
		}



		private void buttonClearSerialTexts_Click(object sender, EventArgs e)
		{
			DeleteSerialTexts();
		}

		private void DeleteSerialTexts()
		{
			richTextBoxSerialPortTexts.Clear();
		}


		private void textBoxSerialSendMessage_Enter(object sender, EventArgs e)
		{
			// Enter on SerialMessage TextBox
			if (SerialMessageTextBoxEntered == false)
			{
				// Clear textbox at first time
				textBoxSerialSendMessage.Clear();
				SerialMessageTextBoxEntered = true;
			}
		}



		public void AppendFwUpdateState( string value)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<string>(AppendFwUpdateState), new object[] { value });
				return;
			}

			labelActualFwUpdateState.Text = value;

		}

		
		public void AppendFwUpdateEndTime( string value)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<string>(AppendFwUpdateEndTime), new object[] { value });
				return;
			}

			labelFwUpdateNeedTime.Text = value;

		}
		


		private void richTextBoxSerialPortTexts_TextChanged(object sender, EventArgs e)
		{

			if (checkBoxSerialPortScrollBottom.Checked)
			{
				// set the current caret position to the end
				richTextBoxSerialPortTexts.SelectionStart = richTextBoxSerialPortTexts.Text.Length;
				// scroll it automatically
				richTextBoxSerialPortTexts.ScrollToCaret();
			}
			else
			{
				/*
				// Selection start is equal then last cliked position
				richTextBoxSerialPortTexts.SelectionStart = SerialMessageActualCaret;
				// scroll it automatically
				richTextBoxSerialPortTexts.ScrollToCaret();	// scroll top/bot without selection start setting
				*/
				richTextBoxSerialPortTexts.Select(SerialMessageActualCaret, SerialMessageActualSelectionLength);
				
			}

		}



		private void richTextBoxSerialPortTexts_SelectionChanged(object sender, EventArgs e)
		{
			// Selected a text
			if (richTextBoxSerialPortTexts.SelectionStart != 0)
			{
				SerialMessageActualCaret = richTextBoxSerialPortTexts.SelectionStart;
			}
			if (richTextBoxSerialPortTexts.SelectionLength != 0)
			{
				SerialMessageActualSelectionLength = richTextBoxSerialPortTexts.SelectionLength;
			}

			// Copy is enabled
			if (checkBoxSerialCopySelected.Checked)
			{
				// Copy the selected text to the Clipboard.

				if (richTextBoxSerialPortTexts.SelectionLength > 0)
				{
					richTextBoxSerialPortTexts.Copy();

					// TODO: Copy to textbox?
					if (richTextBoxSerialPortTexts.SelectedText.Length < 1000)
					{
						Console.WriteLine("Copied texts: " + richTextBoxSerialPortTexts.SelectedText);
					}
					else
					{
						Console.WriteLine("Copied long text to clipboard.");
					}

					// TODO: show message? (notify, notification)
				}

			}

		}






		public void LoadCommandsToButtons()
		{
			List<Command> commandList = command.GetCommands();

			commandListOnButtons = new List<Button>();

			// Add buttons to Command buttons list
			commandListOnButtons.Add(buttonCommand1);
			commandListOnButtons.Add(buttonCommand2);
			commandListOnButtons.Add(buttonCommand3);
			commandListOnButtons.Add(buttonCommand4);
			commandListOnButtons.Add(buttonCommand5);

			int i = 0;
			foreach (var item in commandList)
			{
				// Step on buttons
				commandListOnButtons[i].Text = item.CommandName;
				i++;
				if (i >= commandListOnButtons.Count)
				{
					break;
				}
			}
			
		}


		private void LoadMessageHeaders()
		{
			// Add message headers
			comboBoxSerialHeaderType.Items.Add("!");
			comboBoxSerialHeaderType.Items.Add("BxPgHeader");
		}


		public void LoadCommandsToSetting()
		{
			// Load favourite commands to Settings -> FavCommands dataGridView

			// Mode 1
			dataGridViewSettingsFavCommands.AutoGenerateColumns = true;
			commandList = command.GetCommands();
			dataGridViewSettingsFavCommands.DataSource = commandList;
			dataGridViewSettingsFavCommands.Refresh();
		}


		//////////////////////////////////
		//		Favourite commands
		//////////////////////////////////

		private void buttonCommand1_Click(object sender, EventArgs e)
		{
			command.SendCommand(((Button)sender).Text, CommandSourceType.Serial);
		}

		private void buttonCommand2_Click(object sender, EventArgs e)
		{
			command.SendCommand(((Button)sender).Text, CommandSourceType.Serial);
		}

		private void buttonCommand3_Click(object sender, EventArgs e)
		{
			command.SendCommand(((Button)sender).Text, CommandSourceType.Serial);
		}

		private void buttonCommand4_Click(object sender, EventArgs e)
		{
			command.SendCommand(((Button)sender).Text, CommandSourceType.Serial);
		}

		private void buttonCommand5_Click(object sender, EventArgs e)
		{
			command.SendCommand(((Button)sender).Text, CommandSourceType.Serial);
		}




		private void buttonFwUpdate_Click(object sender, EventArgs e)
		{
			if ( fwUpdate == null)
			{
				// There is no fwUpdate
				int waitResponseTime = Int32.Parse(textBoxTimeWaitResponse.Text);				// TODO: EXCEPTION
				int waitBetweenSendignTime = Int32.Parse(textBoxTimeWaitBetweenSending.Text);	// TODO: EXCEPTION
				int maximumPageErrorNum = Int32.Parse(textBoxFwUpdateMaxPageErrorNum.Text);		// TODO: EXCEPTION
				fwUpdate = new FwUpdate("LidlOS.hex", textBoxFWupdateVersionName.Text,
					serial, this, waitBetweenSendignTime, waitResponseTime, maximumPageErrorNum);

				//timerFwUpdateActualSec = new System.Windows.Forms.Timer();
				timerFwUpdateActualSec.Enabled = true;
				timerFwUpdateActualSec.Start();
				

				buttonFwUpdateStart.Text = "FW Stop";
				Log.SendEventLog("FwUpdate started");
			}
			else
			{
				//if (fwUpdate != null)
				fwUpdate.FwUpdateStop();
				fwUpdate = null;

				timerFwUpdateActualSec.Stop();

				buttonFwUpdateStart.Text = "FW Update ";
				Log.SendEventLog("FwUpdate stopped");
			}

		}



		private void buttonSerialPortSend_Click(object sender, EventArgs e)
		{
			SerialMessageSending();
		}



		private void textBoxSerialSendMessage_KeyPress(object sender, KeyPressEventArgs e)
		{
			// If pressed in "SendMessage textbox" enter --> Send the message
			if (e.KeyChar == (char)Keys.Return)
			{
				// If pressed enter
				SerialMessageSending();
			}
				
		}



		private void SerialMessageSending()
		{
			if (textBoxSerialSendMessage.Text != null)
			{
				String message = "";
				if (checkBoxSerialHeaderSending.Checked)
				{
					// Add header, if need
					message += (String)comboBoxSerialHeaderType.SelectedItem;
				}

				// Append command text
				message += textBoxSerialSendMessage.Text;

				// Successful or not successful
				String messageResult = serial.SendMessage(message, true);
				Log.SendEventLog(messageResult);
				//AppendTextSerialData(messageResult);

				// The message
				//Log.SendEventLog(message);
				//AppendTextSerialData(message + "\r\n");		// Send on Serial with endline (\r\n)

				SerialAddLastCommand(message);
			}
		}



		private void SerialAddLastCommand(String message)
		{
			String command = "";
			

			if (message.StartsWith(SerialHeader))
			{
				// Copied after '!', if it is serial command
				command = message.Substring(1);	// TODO: after serial '!'
			}
			else
			{
				// Copy
				command = message;
			}

			if (comboBoxSerialPortLastCommands.FindString(command) >= 0)
			{
				// We have this command in the list
				// TODO: put to top?
			}
			else
			{
				comboBoxSerialPortLastCommands.Items.Add(command);
			}
			
		}



		internal void CheckFwUpateMessageAndSend(string value)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<string>(CheckFwUpateMessageAndSend), new object[] { value });
				return;
			}

			if ( FwUpdateWaitMessage == true && fwUpdate != null)
			{
				if ( value.Contains("FWUP"))
				{
					fwUpdate.ReceivedAnMessage(value);
				}
			}
		}



		private void FastenTerminal_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Close event

			// Close serial
			serial.SerialPortComClose();

			// Log closed
			Log.SendEventLog("Application closed");
			Log.SendErrorLog("Application closed");


			if (NotifyIsEnabled)
			{
				// Notify close
				notifyIconApplication.Visible = false;
			}
		}



		private void timerFwUpdateActualSec_Tick(object sender, EventArgs e)
		{
			if (fwUpdate != null)
			{
				fwUpdate.ActualSecIncrease();

				var span = new TimeSpan(0, 0, fwUpdate.ActualFwUpdateTimeSeconds); //Or TimeSpan.FromSeconds(seconds); (see Jakob C´s answer)
				var actualTime = string.Format("{0}:{1:00}",
								(int)span.TotalMinutes,
								span.Seconds);

				span = new TimeSpan(0, 0, fwUpdate.NeedFwUpdateTimeSeconds); //Or TimeSpan.FromSeconds(seconds); (see Jakob C´s answer)
				var needlTime = string.Format("{0}:{1:00}",
								(int)span.TotalMinutes,
								span.Seconds);

				AppendFwUpdateEndTime(actualTime + " / " + needlTime);
			}
		}

		private void checkBoxSerialPortLog_CheckedChanged(object sender, EventArgs e)
		{
			serial.NeedLog = checkBoxSerialPortLog.Checked;
		}


		/// <summary>
		/// Get color from string (within escape sequences ... ESC[31m...
		/// </summary>
		/// <param name="escapeMessage"></param>
		/// <returns></returns>
		private Color GetColor(String escapeMessage)
		{
			Color textColor = Color.Black;
			if (escapeMessage.Contains("[3"))
			{
				char colorChar = escapeMessage[8];
				switch (colorChar)
				{
						case '0':
						textColor = Color.Black;
						break;
					case '1':
						textColor = Color.Red;
						break;
					case '2':
						textColor = Color.Green;
						break;
					case '3':
						textColor = Color.Yellow;
						break;
					case '4':
						textColor = Color.Blue;
						break;
					case '5':
						textColor = Color.Magenta;
						break;
					case '6':
						textColor = Color.Cyan;
						break;
					case '7':
						textColor = Color.White;
						break;
					default:
						break;
						
				}
			}

			return textColor;

		}

		private void comboBoxSerialPortLastCommands_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Copy clicked text to sending message text
			textBoxSerialSendMessage.Text = (String)comboBoxSerialPortLastCommands.SelectedItem;
		}



		private void textBoxSerialTextFind_KeyPress(object sender, KeyPressEventArgs e)
		{

			// Find, if pressed enter
			if (e.KeyChar == (char)Keys.Return)
			{
				// Pressed enter
				String searchText = textBoxSerialTextFind.Text;
				int searchTextLength = textBoxSerialTextFind.Text.Length;
				int startIndex = 0;

				// Search in log, if not null text
				if (searchTextLength > 0)
				{
					// Not null search string

					// Find
					// TODO: This is the First searched item...
					//int result = richTextBoxSerialPortTexts.Find(searchText);

					// Find
					int result = 1;
					while (( result = richTextBoxSerialPortTexts.Text.IndexOf(searchText, startIndex)) != -1)
					{
						// Founded a string

						// Select founded string

						richTextBoxSerialPortTexts.Select(result, searchTextLength);
						richTextBoxSerialPortTexts.SelectionBackColor = Color.Yellow;

						startIndex = result + searchTextLength;
					}
				}
			}
				
		}


		/// <summary>
		/// Notify on taskbar
		/// </summary>
		/// <param name="message"></param>
		private void MessageForUser(String message)
		{
			if (NotifyIsEnabled)
			{
				notifyIconApplication.BalloonTipText = message;
				//notifyIconForParent.Text = message;   // Ikon neve
				notifyIconApplication.BalloonTipTitle = "FastenTerminal";
				notifyIconApplication.ShowBalloonTip(1000);
			}
		}


		private void checkBoxSerialHex_CheckStateChanged(object sender, EventArgs e)
		{
			// Serial print in hex (look at serial class)
			serial.needToConvertHex = checkBoxSerialHex.Checked;
		}



		////////////////////////////////
		// Calculator
		////////////////////////////////

		public enum CalculateType
		{
			Decimal,
			Hexadecimal,
			Binary
		}


		private void textBoxCalculatorDec_KeyPress(object sender, KeyPressEventArgs e)
		{
			// If pressed in enter
			if (e.KeyChar == (char)Keys.Return)
			{
				// If pressed enter
				Calculate(CalculateType.Decimal);
			}
		}

		private void Calculate(CalculateType calculateType)
		{
			// Calculate

			switch(calculateType)
			{
				case CalculateType.Decimal:

					Int32 value = Int32.Parse(textBoxCalculatorDec.Text);
					textBoxCalculatorHex.Text = value.ToString("X2");	// "x" is good
					textBoxCalculatorBin.Text = DecimalToBinary(value);
					break;

				case CalculateType.Binary:

					break;

				case CalculateType.Hexadecimal:

					break;

				default:

					break;
					
			}
		}


		public string DecimalToBinary(int value)
		{
			string binaryValue = "";
			int i = 0;

			while(value >= 0)
			{
				i++;
				// Put digit
				if((value % 2) == 1)
				{
					binaryValue = "1" + binaryValue;
				}
				else
				{
					binaryValue = "0" + binaryValue;
				}

				// Put space
				if ((i % 4) == 0)
				{
					binaryValue = " " + binaryValue;
				}

				// Shift value
				value >>= 1;

				if(value == 0)
				{
					break;
				}

			}

			return binaryValue;
		}

		////////////////////////////////////////////////////////////////////////////


		private void serialPortDevice_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
		{

			Log.SendErrorLog("Serial: Error received");

		}

		private void buttonSerialPeriodSendingStart_Click(object sender, EventArgs e)
		{
			// Clicked Serial - Period sending start-stop button

			if(serial.PeriodSendingEnable)
			{
				// Now, enabled, so need to stop
				serial.PeriodSendingStop();

				buttonSerialPeriodSendingStart.Text = "Start";
			}
			else
			{
				// Now disabled, need to be enabling & starting

				// Has opened port?
				if(serial.isOpenedPort)
				{
					// Has opened port
				serial.PeriodSendingStart(numericUpDownSerialPeriodSendingTime.Value,
					textBoxPeriodSendingMessage.Text);

				buttonSerialPeriodSendingStart.Text = "Stop";
				}
				else
				{
					string logMessage = "[Application] There is no opened port, you can't start periodical message sending\n";
					AppendTextSerialData(logMessage);
					Log.SendEventLog(logMessage);
				}
			}
		}

		private void checkBoxLogWithDateTime_CheckedChanged(object sender, EventArgs e)
		{
			// Need to log with DateTime?
			serial.LogWithDateTime = checkBoxLogWithDateTime.Checked;
		}

		private void checkSerialAppendPerRPerN_CheckedChanged(object sender, EventArgs e)
		{
			serial.needAppendPerRPerN = checkBoxSerialAppendPerRPerN.Checked;
		}


	}	// End of class
}	// End of namespace
