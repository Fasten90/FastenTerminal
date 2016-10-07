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
    public partial class FormFastenTerminal : Form
    {
		// Configs:
		public bool NotifyIsEnabled = false;

		private const String ApplicationName = "FastenTerminal";

		// Others

		public Serial serial;

		public FavouriteCommandHandler favouriteCommands;

		//public BindingSource commandList;
		public List<Command> commandList;
		public BindingList<Command> commandBindingList;

		public bool FwUpdateWaitMessage;

		bool SerialMessageTextBoxEntered = false;

		int SerialMessageActualCaret = 0;
		int SerialMessageActualSelectionLength = 0;

		String tempStringBuffer = "";


		// For Calculator
		String decimalString;
		String hexadecimalString;
		String binaryString;


		public FormFastenTerminal()
        {
            InitializeComponent();
        }


        private void FormFastenTerminalMain_Load(object sender, EventArgs e)
        {


			// Load Serial
			serial = new Serial(serialPortDevice, this);

			// Serial config
			serial.NeedLog = checkBoxSerialPortLog.Checked;
			serial.LogWithDateTime = checkBoxLogWithDateTime.Checked;
			serial.needAppendPerRPerN = checkBoxSerialAppendPerRPerN.Checked;
			
			comboBoxSerialPortBaudrate.SelectedIndex = 0;


			SerialRefresh();

			// Load commands
			favouriteCommands = new FavouriteCommandHandler(this);

			LoadFavouriteCommands();


			// Notify
			if (NotifyIsEnabled)
			{ 
				notifyIconApplication.Visible = true;  
			}
        }



		private void FastenTerminal_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Close event

			// Close serial
			serial.needPrint = false;
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



		private void RefreshTitle()
		{
			// For example: "FastenTerminal - COM9 - 9600"
			this.Text = ApplicationName + " - " + serial.stateInfo;
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
			// Is opened?
			if (serial.isOpenedPort == false)
			{
				// If not opened, open
				if (serial.SerialPortComOpen())
				{
					// Successful port opening
					buttonSerialPortOpen.Text = "Port close";
				}

			}
			else
			{
				// If opened, close
				serial.SerialPortComClose();
				buttonSerialPortOpen.Text = "Port open";
			}

			// Refresh application name
			RefreshTitle();		
		}



		private void comboBoxSerialPortCOM_SelectedIndexChanged(object sender, EventArgs e)
		{
			serial.ComSelected = (string)comboBoxSerialPortCOM.SelectedItem;
		}


			
		private void comboBoxSerialPortBaudrate_SelectedIndexChanged(object sender, EventArgs e)
		{
			serial.Baudrate = (string)comboBoxSerialPortBaudrate.SelectedItem;
		}



		private void serialPortDevice_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			SerialReceive();
		}



		private void SerialReceive()
		{
			if (InvokeRequired)
			{
				this.BeginInvoke(new Action(SerialReceive), new object[] { });
				return;
			}

			serial.Receive();
		}



		public void AppendTextSerialLogData(string value)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<string>(AppendTextSerialLogData), new object[] { value });
				return;
			}

			// Original text appending, It Work!!
			//richTextBoxSerialPortTexts.Text += value;

			Color textColor = Color.Black;

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


					// Checked coloring
					textColor = GetColor(value);

					// Substring after ESC
					String textWithoutEscape = value.Substring(10);         // TODO: Elegánsabban kéne kivenni az ESC[... részt
					value = textWithoutEscape;

					richTextBoxSerialPortTexts.SelectionColor = textColor;
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
			//richTextBoxSerialPortTexts.Text += value;
			//richTextBoxSerialPortTexts.AppendText(value); // If you use it, it automatic scroll bottom

			/*
			richTextBoxSerialPortTexts.SelectionColor = textColor;
			richTextBoxSerialPortTexts.AppendText(value); // If you use it, it automatic scroll bottom
			*/

			if (checkBoxSerialPortScrollBottom.Checked)
			{
				// Append text to box
				richTextBoxSerialPortTexts.AppendText(value); // If you use it, it automatic scroll bottom
				richTextBoxSerialPortTexts.ScrollToCaret();	// scroll top/bot without selection start setting
			}
			else
			{
				// Append text to buffer
				tempStringBuffer += value;
			}
		}


		private void buttonClearSerialTexts_Click(object sender, EventArgs e)
		{
			DeleteSerialTexts();
		}



		private void DeleteSerialTexts()
		{
			richTextBoxSerialPortTexts.Clear();
		}



		private void richTextBoxSerialPortTexts_TextChanged(object sender, EventArgs e)
		{
			/*
			if (checkBoxSerialPortScrollBottom.Checked)
			{
				// set the current caret position to the end
				richTextBoxSerialPortTexts.SelectionStart = richTextBoxSerialPortTexts.Text.Length;
				// scroll it automatically
				richTextBoxSerialPortTexts.ScrollToCaret();
			}
			else
			{

				// Selection start is equal then last cliked position
				//richTextBoxSerialPortTexts.SelectionStart = SerialMessageActualCaret;
				// scroll it automatically
				//richTextBoxSerialPortTexts.ScrollToCaret();	// scroll top/bot without selection start setting

				richTextBoxSerialPortTexts.Select(SerialMessageActualCaret, SerialMessageActualSelectionLength);			
			}
			*/

		}



		private void checkBoxSerialPortScrollBottom_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxSerialPortScrollBottom.Checked)
			{
				richTextBoxSerialPortTexts.Text += tempStringBuffer;
				tempStringBuffer = "";

				richTextBoxSerialPortTexts.ScrollToCaret();
			}

		}



		private void richTextBoxSerialPortTexts_SelectionChanged(object sender, EventArgs e)
		{

			// Selected a text, do not scroll!
			if (richTextBoxSerialPortTexts.SelectionStart != richTextBoxSerialPortTexts.TextLength)
			{
				checkBoxSerialPortScrollBottom.Checked = false;
			}

			/*
			// Not good enough
			if (richTextBoxSerialPortTexts.SelectionStart != 0)
			{
				SerialMessageActualCaret = richTextBoxSerialPortTexts.SelectionStart;
			}
			if (richTextBoxSerialPortTexts.SelectionLength != 0)
			{
				SerialMessageActualSelectionLength = richTextBoxSerialPortTexts.SelectionLength;
			}
			*/

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



		private void buttonSerialPortSend_Click(object sender, EventArgs e)
		{
			SerialMessageSending();
		}



		private void comboBoxSerialSendMessage_KeyPress(object sender, KeyPressEventArgs e)
		{
			// If pressed in "SendMessage textbox" enter --> Send the message
			if (e.KeyChar == (char)Keys.Return)
			{
				// If pressed enter
				SerialMessageSending();
			}
		}



		private void SerialMessageTextClearAndSave()
		{
			// Need clear text?
			if (checkBoxSerialConfigClearSendMessageTextAfterSend.Checked)
			{
				// Clear text
				comboBoxSerialSendingText.Text = "";
			}
		}



		private void comboBoxSerialSendMessage_Enter(object sender, EventArgs e)
		{
			// Enter on SerialMessage TextBox
			if (SerialMessageTextBoxEntered == false)
			{
				// Clear textbox at first time
				comboBoxSerialSendingText.Text = "";
				SerialMessageTextBoxEntered = true;
			}
		}



		private void SerialMessageSending()
		{
			if (comboBoxSerialSendingText.Text != null)
			{
				String message = "";

				// Append command text
				message += comboBoxSerialSendingText.Text;

				// Successful or not successful
				String messageResult = serial.SendMessage(message, true);
				Log.SendEventLog(messageResult);	// TODO: Biztos kell ez?
				//AppendTextSerialData(messageResult);

				// The message
				//Log.SendEventLog(message);
				//AppendTextSerialData(message + "\r\n");		// Send on Serial with endline (\r\n)

				SerialAddLastCommand(message);

				SerialMessageTextClearAndSave();
			}
		}



		private void checkBoxSerialPortLog_CheckedChanged(object sender, EventArgs e)
		{
			serial.NeedLog = checkBoxSerialPortLog.Checked;
		}



		private void checkBoxSerialConfigClearSendMessageTextAfterSend_CheckedChanged(object sender, EventArgs e)
		{
			// Do nothing
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



		private void textBoxSerialTextFind_KeyPress(object sender, KeyPressEventArgs e)
		{

			// Find, if pressed enter
			if (e.KeyChar == (char)Keys.Return)
			{
				// Pressed enter
				FindText();
			}
		}



		private void FindText()
		{
			String searchText = textBoxSerialTextFind.Text;
			int searchTextLength = textBoxSerialTextFind.Text.Length;
			int startIndex = 0;

			// Search in log, if not null text
			if (searchTextLength > 0)
			{
				// Not null search string

				// Search started flag: for TextChange event skipping
				//isSearching = true;
				this.richTextBoxSerialPortTexts.SelectionChanged -= new System.EventHandler(this.richTextBoxSerialPortTexts_SelectionChanged);
				this.richTextBoxSerialPortTexts.TextChanged -= new System.EventHandler(this.richTextBoxSerialPortTexts_TextChanged);

				// Find
				// TODO: This is the First searched item...
				//int result = richTextBoxSerialPortTexts.Find(searchText);

				// Find
				int result = 1;
				while ((result = richTextBoxSerialPortTexts.Text.IndexOf(searchText, startIndex)) != -1)
				{
					// Founded a string

					// Select founded string

					richTextBoxSerialPortTexts.Select(result, searchTextLength);
					richTextBoxSerialPortTexts.SelectionBackColor = Color.Yellow;

					startIndex = result + searchTextLength;
				}

				// End of finding

				// Search started flag: for TextChange event skipping
				//isSearching = false;
				this.richTextBoxSerialPortTexts.SelectionChanged += new System.EventHandler(this.richTextBoxSerialPortTexts_SelectionChanged);
				this.richTextBoxSerialPortTexts.TextChanged += new System.EventHandler(this.richTextBoxSerialPortTexts_TextChanged);
			}
		}



		private void checkBoxSerialHex_CheckStateChanged(object sender, EventArgs e)
		{
			// Serial print in hex (look at serial class)
			serial.needToConvertHex = checkBoxSerialHex.Checked;
		}



		private void serialPortDevice_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
		{

			Log.SendErrorLog("Serial: Error received");

		}



		private void buttonSerialPeriodSendingStart_Click(object sender, EventArgs e)
		{
			// Clicked Serial - Period sending start-stop button

			if (serial.PeriodSendingEnable)
			{
				// Now, enabled, so need to stop
				serial.PeriodSendingStop();

				buttonSerialPeriodSendingStart.Text = "Start";
			}
			else
			{
				// Now disabled, need to be enabling & starting

				// Has opened port?
				if (serial.isOpenedPort)
				{
					// Has opened port
					serial.PeriodSendingStart(numericUpDownSerialPeriodSendingTime.Value,
						textBoxPeriodSendingMessage.Text);

					buttonSerialPeriodSendingStart.Text = "Stop";
				}
				else
				{
					string logMessage = "[Application] There is no opened port, you can't start periodical message sending\n";
					AppendTextSerialLogData(logMessage);
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



		private void comboBoxSerialPortLastCommands_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Copy clicked text to sending message text
			comboBoxSerialSendingText.Text = (String)comboBoxSerialSendingText.SelectedItem;
		}



		//////////////////////////////
		//		Favourite commands
		//////////////////////////////


		public void LoadFavouriteCommands()
		{
			// Load favourite commands to Settings -> FavCommands dataGridView

			// Mode 1
			dataGridViewFavCommands.AutoGenerateColumns = true;
			commandList = favouriteCommands.GetCommands();

			commandBindingList = new BindingList<Command>(commandList);
			var source = new BindingSource(commandBindingList, null);
			dataGridViewFavCommands.DataSource = source;
			dataGridViewFavCommands.Refresh();
		}



		private void buttonSerialFavouriteCommandSending_Click(object sender, EventArgs e)
		{
			String message = ((Command)dataGridViewFavCommands.CurrentRow.DataBoundItem).CommandSendingString;
			serial.SendMessage(message, true);
		}



		private void SerialAddLastCommand(String message)
		{
			String command = "";
			
			// Copy
			command = message;

			if (comboBoxSerialSendingText.FindString(command) >= 0)
			{
				// We have this command in the list
				// TODO: put to top?
			}
			else
			{
				comboBoxSerialSendingText.Items.Add(command);
			}
			
		}


		private void buttonSerialFavouriteCommandsSave_Click(object sender, EventArgs e)
		{
			// Save favourite commands
			favouriteCommands.SaveCommandConfig();
		}

		private void buttonSerialFavouriteCommandsAdd_Click(object sender, EventArgs e)
		{
			favouriteCommands.AddNewCommand("", "");

			commandList = favouriteCommands.GetCommands();

			commandBindingList = new BindingList<Command>(commandList);
			var source = new BindingSource(commandBindingList, null);
			dataGridViewFavCommands.DataSource = source;
			dataGridViewFavCommands.Refresh();
		}



		////////////////////////////////
		//		Calculator
		////////////////////////////////



		private void textBoxCalculatorDec_KeyPress(object sender, KeyPressEventArgs e)
		{
			// If pressed in enter
			if (e.KeyChar == (char)Keys.Return)
			{
				// If pressed enter
				Calculator.Calculate(CalculateType.Decimal, textBoxCalculatorDec.Text,
							ref decimalString, ref hexadecimalString, ref binaryString);

				textBoxCalculatorDec.Text = decimalString;
				textBoxCalculatorHex.Text = hexadecimalString;
				textBoxCalculatorBin.Text = binaryString;
			}
		}



		private void textBoxCalculatorHex_KeyPress(object sender, KeyPressEventArgs e)
		{
			// If pressed in enter
			if (e.KeyChar == (char)Keys.Return)
			{
				// If pressed enter
				Calculator.Calculate(CalculateType.Hexadecimal, textBoxCalculatorHex.Text,
							ref decimalString, ref hexadecimalString, ref binaryString);

				textBoxCalculatorDec.Text = decimalString;
				textBoxCalculatorHex.Text = hexadecimalString;
				textBoxCalculatorBin.Text = binaryString;
			}
		}



		private void textBoxCalculatorBin_KeyPress(object sender, KeyPressEventArgs e)
		{
			// If pressed in enter
			if (e.KeyChar == (char)Keys.Return)
			{
				// If pressed enter
				Calculator.Calculate(CalculateType.Binary, textBoxCalculatorBin.Text,
							ref decimalString, ref hexadecimalString, ref binaryString);

				textBoxCalculatorDec.Text = decimalString;
				textBoxCalculatorHex.Text = hexadecimalString;
				textBoxCalculatorBin.Text = binaryString;
			}
		}

		////////////////////////////////////////////////////////////////////////////





	}   // End of class
}	// End of namespace
