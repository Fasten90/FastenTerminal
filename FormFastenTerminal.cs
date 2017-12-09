using FastenTerminal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FastenTerminal
{
    public partial class FormFastenTerminal : Form
    {
		// Const application configs:
		private bool NotifyIsEnabled = true;
		private const String ApplicationName = "FastenTerminal";
        private const String ApplicationMessage = "[Application] ";

        // Const images
        private const String imgLocReceiveGreen = @"Images\img_receive_green.png";
        private const String imgLocReceiveEmpty = @"Images\img_receive_empty.png";
        private const String imgLocScrollingActive = @"Images\img_scrolling_active.png";
        private const String imgLocScrollingInctive = @"Images\img_scrolling_inactive.png";

        // Const sounds
        private const String soundBellPath = @"Sounds\sound_bell.wav";


        // Configs
        private Color GlobalTextColor = Color.Black;
        private Color GlobalBackgroundColor = Form.DefaultBackColor;
        private bool GlobalEscapeEnabled = true;

        // TODO: Add to config
        private Color EventLogTextColor = Color.Blue;
        private Color EventLogBackgroundColor = Color.Yellow;

        private bool soundIsDisabled = false;


        // Communications
        public Communication comm;
        private CommType commType = CommType.NotInitialized;

        public FavouriteCommandHandler favouriteCommands;

		//public BindingSource commandList;
		public List<Command> commandList;
		public BindingList<Command> commandBindingList;

        private FastenTerminalConfigs Config;

        // LOG - text variables
        private bool SendMessageTextBox_Entered = false;
        private bool PeriodMessageTextBox_Entered = false;
        private bool SendMessageTextBox_ClearAfterSend = false;

        // LOG - strings
        private String tempStringBuffer = "";
		private String tempStringEscapeBuffer = ""; // For not ended escape string

        // Events / Variable configs
        private bool textLogScrollisEnabled = true;
        private bool IsreceivedIconIsGreen = false;


        /*
         *                  Methods
         */ 

        public FormFastenTerminal()
        {
            InitializeComponent();
        }

        private void FormFastenTerminalMain_Load(object sender, EventArgs e)
        {
			Config = new FastenTerminalConfigs();

			// Load Serial
			comm = new Serial(ref serialPortDevice, this);

			// Serial config
			comm.NeedLog = checkBoxLogEnable.Checked;
			comm.LogWithDateTime = checkBoxLogWithDateTime.Checked;
			
			comboBoxSerialPortBaudrate.SelectedIndex = 0;

			SerialRefresh();

			// Load config
			LoadConfigToForm();

			// Load commands
			favouriteCommands = new FavouriteCommandHandler(this);
			LoadFavouriteCommands();

			// Notify
			if (NotifyIsEnabled)
			{ 
				notifyIconApplication.Visible = true;  
			}

			// Form configs
			GlobalEscapeEnabled = checkBoxEscapeSequenceEnable.Checked;

            checkBoxPrintSend.Checked = comm.printSentEvent;

            comboBoxNewLineType.Text = "\\r\\n";

            // Serial list refresh
            SerialPeriodicalRefreshStart();
        }



		private void LoadConfigToForm()
		{
            // Application configs
            // TODO: Add background - foregroundcolor

            // TODO:        private Color EventLogTextColor = Color.Blue;
            // private Color EventLogBackgroundColor = Color.Yellow;

            // Serial configs
            // TODO: Delete com port
            comboBoxSerialPortCOM.Text = Config.config.portName;
			comboBoxSerialPortBaudrate.Text = Config.config.baudrate;

            // Logs configs
			checkBoxLogEnable.Checked = Config.config.needLog;
			checkBoxLogWithDateTime.Checked = Config.config.dateLog;

            // Message configs
			checkBoxReceiveBinaryMode.Checked = Config.config.isBinaryMode;

            // TODO: Add newLineString

            // TODO: Add mute

            // TODO: Add word wrap

            // TODO: Add Print sending msg
        }



        private void SaveConfig()
		{
            // TODO: Sync with LoadConfigToForm
			Config.config.portName = comboBoxSerialPortCOM.Text;
			Config.config.baudrate = comboBoxSerialPortBaudrate.Text;

			Config.config.needLog = checkBoxLogEnable.Checked;
			Config.config.dateLog = checkBoxLogWithDateTime.Checked;

			Config.config.isBinaryMode = checkBoxReceiveBinaryMode.Checked;

			Config.SaveConfigToXml();
		}



		private void FastenTerminal_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Close event

			// Close serial
			comm.needPrint = false;
			comm.Close();

            // Close Telnet
            // TODO: Close telnet

			// Log closed
			Log.SendEventLog("Application closed");
			Log.SendErrorLog("Application closed");


			if (NotifyIsEnabled)
			{
				// Notify close
				notifyIconApplication.Visible = false;
                notifyIconApplication.Dispose();
            }
		}

		private void RefreshTitle()
		{
			// For example: "FastenTerminal - COM9 - 9600"
			this.Text = ApplicationName + " - " + comm.stateInfo;
		}

		private void notifyMessageForUser(String message)
		{
			if (NotifyIsEnabled)
			{
				notifyIconApplication.BalloonTipText = message;
				//notifyIconForParent.Text = message;   // Ikon neve
				notifyIconApplication.BalloonTipTitle = "FastenTerminal";
				notifyIconApplication.ShowBalloonTip(1000);
			}
            else
            {
                Console.WriteLine("Notify: " + message);
            }
		}


		/*
		 *			 SERIAL
		 */


		private void buttonSerialPortRefresh_Click(object sender, EventArgs e)
		{
			// Clicked "Serial Refresh" button
			SerialRefresh();
		}

        private void SerialPeriodicalRefreshStart()
        {
            // Received
            timerCheckSerialPorts.Interval = 500;   // 0.5 sec
            timerCheckSerialPorts.Stop();
            timerCheckSerialPorts.Start();           // Restart
        }

		private void SerialRefresh()
		{
            // Refresh Serial COM ports
            try
            {
			    ((Serial)comm).SerialPortComRefresh();
            }
            catch (Exception ex)
            {
                // Load Serial
                comm = new Serial(ref serialPortDevice, this);
                ((Serial)comm).SerialPortComRefresh();
            }

			if (((Serial)comm).ComAvailableList != null && ((Serial)comm).ComAvailableList.Length != 0) 
			{
				// Clear
				comboBoxSerialPortCOM.Items.Clear();

				// Load new values
				foreach (string s in ((Serial)comm).ComAvailableList)
				{
					comboBoxSerialPortCOM.Items.Add(s);
				}

				comboBoxSerialPortCOM.SelectedIndex = 0;
			}
            else
            {
                // Empty list

                // Clear
                comboBoxSerialPortCOM.Items.Clear();
            }

			// Wrong
			//comboBoxSerialPortCOM.DataSource = serial.ComAvailableList;
		}

		private void buttonSerialPortOpenClose_Click(object sender, EventArgs e)
		{
			SerialOpenClose();
		}

        public void SerialSetStateOpenedOrClosed(bool isOpened)
        {
            try
            {
                if (isOpened)
                {
                    buttonSerialPortOpenClose.Text = "Port close";
                    CommStateChanged(CommType.Serial);
                }
                else
                {
                    buttonSerialPortOpenClose.Text = "Port open";
                    CommStateChanged(CommType.NotInitialized);
                }
            }
            catch (Exception e)
            {
                // TODO: Error, if this function called from other thread
                Log.SendErrorLog("Serial set state error: " + e.Message);
            }
        }

		private void SerialOpenClose()
		{
			// Is opened?
			if (comm.isOpened == false)
			{
				// If there is not opened port, open
                try
                {
				    if (((Serial)comm).SerialPortComOpen())
				    {
                        // Successful port opening
                        SerialSetStateOpenedOrClosed(true);
                    }
                    else
                    {
                        // Failed open
                        // "Notify" message is printed from SerialPortComOpen() 
                    }
                }
                catch (Exception ex)
                {
                    comm = new Serial(ref serialPortDevice, this);

                    // TODO: To a new function?
                    ((Serial)comm).ComSelected = (string)comboBoxSerialPortCOM.SelectedItem;
                    ((Serial)comm).Baudrate = (string)comboBoxSerialPortBaudrate.SelectedItem;

                    if (((Serial)comm).SerialPortComOpen())
                    {
                        // Successful port opening
                        SerialSetStateOpenedOrClosed(true);
                    }
                    else
                    {
                        // Failed open
                        // "Notify" message is printed from SerialPortComOpen() 
                    }
                }
            }
			else
			{
				// If opened, close
				comm.Close();
                SerialSetStateOpenedOrClosed(false);
            }

			// Refresh application name
			RefreshTitle();
        }

		private void comboBoxSerialPortCOM_SelectedIndexChanged(object sender, EventArgs e)
		{
            ((Serial)comm).ComSelected = (string)comboBoxSerialPortCOM.SelectedItem;
		}
			
		private void comboBoxSerialPortBaudrate_SelectedIndexChanged(object sender, EventArgs e)
		{
            ((Serial)comm).Baudrate = (string)comboBoxSerialPortBaudrate.SelectedItem;
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

            ((Serial)comm).Receive();

			ReceivedACharacterEvent();
		}

        public void ReceivedACharacterEvent()
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action(ReceivedACharacterEvent), new object[] { });
                return;
            }

            SerialReceiveEvent(true);
        }

        private void serialPortDevice_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            Log.SendErrorLog("Serial: Error received:" + e.ToString());
        }

        /*
         *      Text log
         */

        public void AppendTextLogEvent(string message)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<string>(AppendTextLogEvent), new object[] { message });
				return;
			}

            // Note log (not received log!)
            if (richTextBoxTextLog.TextLength > 0)
            {
                char lastReceivedCharacter = richTextBoxTextLog.Text[richTextBoxTextLog.TextLength - 1];
                if (lastReceivedCharacter != '\r' && lastReceivedCharacter != '\n' && lastReceivedCharacter != '\0')
                {
                    message = Environment.NewLine + ApplicationMessage + message + Environment.NewLine;
                }
            }
            else
            {
                message = ApplicationMessage + message + Environment.NewLine;
            }

			AppendTextLog(message, Color.Blue, Color.Yellow);
		}

		public void AppendTextLogData(string message)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<string>(AppendTextLogData), new object[] { message });
				return;
			}

			// Original text appending, It is Work!!
			//richTextBoxSerialPortTexts.Text += value;
			if (message == "")
			{
				return;
			}

			if (GlobalEscapeEnabled)
			{
				// Enabled escape sequences, Check that

				if (tempStringEscapeBuffer.Length > 0)
				{
					message = tempStringEscapeBuffer + message;
					tempStringEscapeBuffer = "";
				}

				Color color = Color.Black;
				EscapeType actualEscapeType = EscapeType.Escape_Nothing;
				int startIndex = 0;


				// Check Bell character
				if (!soundIsDisabled && message.Contains("\a"))
				{
					// Contain Bell, remove it
					message = message.Replace("\a", "");
					Common.PlaySound(soundBellPath);
				}


				// Check, has Escape sequence?
				while (message.Length > 0)
				{
					actualEscapeType = EscapeSequence.ProcessEscapeMessage(message, out color, out startIndex);

					switch (actualEscapeType)
					{
						case EscapeType.Escape_Nothing:
							// Append entire string
							AppendTextLog(message, GlobalTextColor, GlobalBackgroundColor);
							message = "";
							break;

						case EscapeType.Escape_StringWithoutEscape:
							// Append first some character (string), which is not contain the Escape sequence!
							AppendTextLog(message.Substring(0, startIndex), GlobalTextColor, GlobalBackgroundColor);
							break;

						case EscapeType.Escape_CLS:
							DeleteTextLog();
                            // TODO: It is not very good...
							break;

						case EscapeType.Escape_TextColor:
							GlobalTextColor = color;
							break;

						case EscapeType.Escape_BackgroundColor:
							if (color == Color.White)
							{
								GlobalBackgroundColor = Form.DefaultBackColor;
							}
							else
							{
								GlobalBackgroundColor = color;
							}
							break;

						case EscapeType.Escape_CursorMoving:
							// TODO: Not implemented
							break;

						case EscapeType.Escape_Short_NeedAppend:
							// Save to buffer and wait for continue
							tempStringEscapeBuffer = message;
                            if (message.Length > 50)
                            {
                                Log.SendErrorLog("ERROR: Escape_Short_NeedAppend error (too large message): " + message + "\"");
                                notifyMessageForUser("Fatal error! Tell this problem the developer!");
                                startIndex = 1;
                            }
							break;

						case EscapeType.Escape_Skip_NotImplemented:
							AppendTextLog(message.Substring(startIndex), GlobalTextColor, GlobalBackgroundColor);
							break;

                        case EscapeType.Escape_Wrong:
						default:
                            // TODO: Drop this char
                            Log.SendErrorLog("ERROR: Wrong escape sequence: " + message + "\", start index: "+ startIndex.ToString());
                            notifyMessageForUser("Fatal error! Tell this problem the developer!");
                            break;
					}

                    // Cut escape message string
                    if (startIndex != 0)    // && startIndex != message.Length
                    {
                        try
                        {
                            // Save message after processed Escape characters
                            message = message.Substring(startIndex);
                        }
                        catch (Exception e)
                        {
                            Log.SendErrorLog("ERROR: Out of range in array: " + message + startIndex.ToString() + e.Message);
                            notifyMessageForUser("Fatal error! Tell this problem the developer!");
                        }
                    }
				}
				// End of check escape
			}
			else
			{
                // Escape sequence disabled

                // Escape (Replace 'ESC' character with "[ESC]"
                message = message.Replace("\x1B", "[ESC]");

                // Not enabled escape sequences
                AppendTextLog(message, GlobalTextColor, GlobalBackgroundColor);
			}

			// Append received log
			//AppendTextLog(message, GlobalTextColor, GlobalBackgroundColor);
		}



		/// <summary>
		/// DO NOT USE FROM OTHER THREAD
		/// </summary>
		/// <param name="message"></param>
		/// <param name="textColor"></param>
		/// <param name="backgroundColor"></param>
		private void AppendTextLog(String message, Color textColor, Color backgroundColor)
		{
			richTextBoxTextLog.SelectionColor = textColor;
			richTextBoxTextLog.SelectionBackColor = backgroundColor;

			if (textLogScrollisEnabled)
			{
				// Append text to box
				richTextBoxTextLog.AppendText(message);     // If you use it, it automatic scroll bottom
                
                // TODO: This operation is very slow! 49ms
                richTextBoxTextLog.ScrollToCaret();			// scroll top/bot without selection start setting
               
                // set the current caret position to the end
                //richTextBoxSerialPortTexts.SelectionStart = richTextBoxSerialPortTexts.Text.Length;
                // scroll it automatically
                //richTextBoxSerialPortTexts.ScrollToCaret();
            }
			else
			{
				// Append text to buffer
				tempStringBuffer += message;
			}
		}

		private void buttonClearSerialTexts_Click(object sender, EventArgs e)
		{
			ClearScreen();
		}

		private void ClearScreen()
		{
            tempStringBuffer = "";
            DeleteTextLog();
            SetScrollStateFinal(true);
			GlobalBackgroundColor = Form.DefaultBackColor;
			GlobalTextColor = Color.Black;
			// checkBoxSerialPortScrollBottom Checked event call the 'ScrollBottomAndAppendBuffer();'
		}

		private void DeleteTextLog()
		{
			richTextBoxTextLog.Clear();
		}

        private void pictureBoxScrollingEnabled_Click(object sender, EventArgs e)
        {
            // Change by user
            // Change actual state (negate)
            SetScrollStateFinal(!textLogScrollisEnabled);
        }

        private void SetScrollStateFinal(bool newState)
        {
            if (textLogScrollisEnabled != newState)
            {
                textLogScrollisEnabled = newState;

                if (textLogScrollisEnabled)
                {
                    pictureBoxScrollingEnabled.ImageLocation = imgLocScrollingActive;
                    // Added buffered string, and scroll bottom
                    ScrollBottomAndAppendBuffer();
                }
                else
                {
                    pictureBoxScrollingEnabled.ImageLocation = imgLocScrollingInctive;
                }
            }
        }

        private void setScrollStateByApplication(bool isEnabled)
        {
            if (textLogScrollisEnabled != isEnabled)
            {
                SetScrollStateFinal(isEnabled);
                notifyMessageForUser("Scrolling is turned " + ((isEnabled) ? "on" : "off") + " by Application");
            }
        }

        private void ScrollBottomAndAppendBuffer()
		{
			//richTextBoxSerialPortTexts.Text += tempStringBuffer;
			AppendTextLog(tempStringBuffer, GlobalTextColor, GlobalBackgroundColor);

			tempStringBuffer = "";
			//richTextBoxSerialPortTexts.SelectionStart = richTextBoxSerialPortTexts.TextLength;		// WRONG: Make stack overflow
			//richTextBoxSerialPortTexts.ScrollToCaret();	// windows is jumping
		}

        private void richTextBoxTextLog_SelectionChanged(object sender, EventArgs e)
		{
			// Selected a text, do not scroll!
			if (richTextBoxTextLog.SelectionStart != richTextBoxTextLog.TextLength)
			{
                setScrollStateByApplication(false);
			}

			if (!textLogScrollisEnabled
				&& (richTextBoxTextLog.SelectionStart == richTextBoxTextLog.TextLength) )
			{
                // Not scrolling, but click at end
                setScrollStateByApplication(true);
				ScrollBottomAndAppendBuffer();
				return;
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
				if (richTextBoxTextLog.SelectionLength > 0)
				{
                    // Copy text to clipboard
					richTextBoxTextLog.Copy();

					// TODO: Copy to textbox?
					if (richTextBoxTextLog.SelectedText.Length < 1000)
					{
						Console.WriteLine("Copied texts: " + richTextBoxTextLog.SelectedText);
					}
					else
					{
						Console.WriteLine("Copied long text to clipboard.");
					}

					// TODO: show message? (notify, notification)
				}
			}
		}

		private void buttonSendMessage_Click(object sender, EventArgs e)
		{
            // Pressed Send button
			SendMessage();
		}

		private void comboBoxSerialSendMessage_KeyPress(object sender, KeyPressEventArgs e)
		{
			// If pressed in "SendMessage textbox" enter --> Send the message
			if (e.KeyChar == (char)Keys.Return)
			{
				// If pressed enter
				SendMessage();
			}
		}

		private void SerialMessageText_Clear()
		{
			// Need clear text?
			if (SendMessageTextBox_ClearAfterSend)
			{
				// Clear text
				comboBoxSendingText.Text = "";
			}
		}

		private void comboBoxSendMessage_Enter(object sender, EventArgs e)
		{
			// Enter on SerialMessage TextBox
			if (SendMessageTextBox_Entered == false)
			{
				// Clear textbox at first time
				comboBoxSendingText.Text = "";
				SendMessageTextBox_Entered = true;
			}
		}

		private void SendMessage()
		{
			if (comboBoxSendingText.Text != null)
			{
                // Message text
				String message = comboBoxSendingText.Text;

                // Successful or not successful
                String messageResult = "";
                if (comm.isOpened)
                    comm.SendMessage(message);
                else
                {
                    // There is no connection
                    AppendTextLogEvent("There is no connection, cannot send!");
                    return;
                }

				Log.SendEventLog(messageResult);	            // TODO: Biztos kell ez?
				//AppendTextSerialData(messageResult);

				// The message
				//Log.SendEventLog(message);
				//AppendTextSerialData(message + "\r\n");		// Send on Serial with endline (\r\n)

				SendMessageAddLastCommand(message);

				SerialMessageText_Clear();

                // Set scroll to enable
                setScrollStateByApplication(true);
            }
		}

		private void checkBoxNeedLog_CheckedChanged(object sender, EventArgs e)
		{
            // TODO: Do better?
			comm.NeedLog = checkBoxLogEnable.Checked;

            if (!comm.NeedLog)
			{
				// If not log
				checkBoxLogWithDateTime.Checked = false;
			}

			SaveConfig();
		}

        /*
         *              Periodical sending
         */

        public void PeriodicalSend_SetState(bool state)
        {
            // Enable, now it is running --> Write "Stop"
            // Disabled, not it is not running --> Write "Start"
            if  (state)
            {
                buttonPeriodicalSendingStart.Text = "Stop";
            }
            else
            {
                buttonPeriodicalSendingStart.Text = "Start";
            }
        }

        private void SerialPeriodSending_Start()
        {
            // TODO: Has we opened serial port? Checked in below, but if isOpenedPort state is wrong?

            if (comm.PeriodSending_Enable)
            {
                // Now, enabled, so need to stop
                comm.PeriodSendingStop();

                PeriodicalSend_SetState(false);
            }
            else
            {
                // Now disabled, need to be enabling & starting

                // Has opened port?
                if (comm.isOpened)
                {
                    // Has opened port
                    comm.PeriodSendingStart((float)numericUpDownSerialPeriodSendingTime.Value,
                        textBoxPeriodSendingMessage.Text);

                    PeriodicalSend_SetState(true);
                }
                else
                {
                    string logMessage = "There is no opened port, you can't start periodical message sending";
                    AppendTextLogEvent(logMessage);
                    Log.SendEventLog(logMessage);
                }
            }
        }

		private void buttonSerialPeriodSendingStart_Click(object sender, EventArgs e)
		{
            // Clicked Serial - Period sending start-stop button
            SerialPeriodSending_Start();
        }

        private void textBoxPeriodSendingMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If pressed in "PeriodMessage textbox" enter --> Send the message
            if (e.KeyChar == (char)Keys.Return)
            {
                // If pressed enter
                SerialPeriodSending_Start();
            }
        }

        private void textBoxPeriodSendingMessage_Enter(object sender, EventArgs e)
        {
            // Entered to PeriodMessageText textbox
            if (PeriodMessageTextBox_Entered == false)
            {
                // Clear textbox at first time
                textBoxPeriodSendingMessage.Text = "";
                PeriodMessageTextBox_Entered = true;
            }
        }

		/*
		 *		Favourite commands
		 */

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
            // TODO: Not serial
			comm.SendMessage(message);
		}

		private void SendMessageAddLastCommand(String message)
		{
			String command = "";
			
			// Copy
			command = message;

			if (comboBoxSendingText.FindString(command) >= 0)
			{
				// We have this command in the list
				// TODO: put to top?
			}
			else
			{
				comboBoxSendingText.Items.Add(command);
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

		void SerialReceiveEvent(bool isReceived)
		{
			if (isReceived)
			{
				// Received
				timerReceiveIcon.Interval = 1000;   // 1 sec
				timerReceiveIcon.Stop();
				timerReceiveIcon.Start();			// Restart
				SerialReceivePictureChange(true);
			}
			else
			{
				// Not received
				timerReceiveIcon.Stop();
				SerialReceivePictureChange(false);
			}
		}

        /*
         *                  Settings
         */

        void SerialReceivePictureChange(bool isReceived)
        {
            // Show "Receive picture", if changed
            if (isReceived)
            {
                if (IsreceivedIconIsGreen != isReceived)
                {
                    pictureBoxSerialReceiving.ImageLocation = imgLocReceiveGreen;
                }
            }
            else
            {
                if (IsreceivedIconIsGreen != isReceived)
                {
                    pictureBoxSerialReceiving.ImageLocation = imgLocReceiveEmpty;
                }
            }

            IsreceivedIconIsGreen = isReceived;
        }

        private void timerReceiveIcon_Tick(object sender, EventArgs e)
        {
            SerialReceiveEvent(false);
        }

        private void checkBoxReceiveBinaryMode_CheckedChanged(object sender, EventArgs e)
        {
            comm.receiverModeBinary = checkBoxReceiveBinaryMode.Checked;

            if (comm.receiverModeBinary)
            {
                // Turn off Escape
                checkBoxEscapeSequenceEnable.Checked = false;
            }

            SaveConfig();
        }

        private void buttonSerialOpenLogFile_Click(object sender, EventArgs e)
        {
            // Open log file
            OpenLogFile();
        }

        private void OpenLogFile()
        {
            // Open log file
            Common.OpenTextFile(MessageLog.logFilePath);
        }

        private void buttonSerialSaveConfig_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void checkBoxSerialTextEscapeSequenceCheckingCheckedChanged(object sender, EventArgs e)
        {
            GlobalEscapeEnabled = checkBoxEscapeSequenceEnable.Checked;

            if (GlobalEscapeEnabled)
            {
                checkBoxReceiveBinaryMode.Checked = false;
            }
        }

        private void checkBoxLogWithDateTime_CheckedChanged(object sender, EventArgs e)
        {
            // Need to log with DateTime?
            comm.LogWithDateTime = checkBoxLogWithDateTime.Checked;

            //SaveConfig();
        }

        private void comboBoxSerialPortLastCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Copy clicked text to sending message text
            comboBoxSendingText.Text = (String)comboBoxSendingText.SelectedItem;
        }

        private void checkBoxMute_CheckedChanged(object sender, EventArgs e)
        {
            soundIsDisabled = checkBoxMute.Checked;
        }

        private void checkBoxWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxTextLog.WordWrap = checkBoxWordWrap.Checked;
        }

        private void checkBoxPrintSend_CheckedChanged(object sender, EventArgs e)
        {
            comm.printSentEvent = checkBoxPrintSend.Checked;
        }

        private void timerCheckSerialPorts_Tick(object sender, EventArgs e)
        {
            // Check serial ports
            SerialRefresh();

            // If has COM port, stop
            if (comboBoxSerialPortCOM.Items.Count > 0)
            {
                timerCheckSerialPorts.Stop();
            }
        }

        private void comboBoxNewLineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comm.newLineString = Common.ConvertNewLineToReal(comboBoxNewLineType.Text);
        }

        private void buttonBackGroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBoxTextLog.BackColor = colorDialog.Color;
            }
        }

        private void buttonForeGroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBoxTextLog.ForeColor = colorDialog.Color;
            }
        }

        private void checkBoxConfigClearSendMessageTextAfterSend_CheckedChanged(object sender, EventArgs e)
        {
            // Do nothing
            SendMessageTextBox_ClearAfterSend = checkBoxConfigClearSendMessageTextAfterSend.Checked;
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
                this.richTextBoxTextLog.SelectionChanged -= new System.EventHandler(this.richTextBoxTextLog_SelectionChanged);

                // Find
                // TODO: This is the First searched item...
                //int result = richTextBoxSerialPortTexts.Find(searchText);

                // Find
                int result = 1;
                while ((result = richTextBoxTextLog.Text.IndexOf(searchText, startIndex)) != -1)
                {
                    // Founded a string

                    // Select founded string

                    richTextBoxTextLog.Select(result, searchTextLength);
                    richTextBoxTextLog.SelectionBackColor = Color.Yellow;

                    startIndex = result + searchTextLength;
                }

                // End of finding

                // Search started flag: for TextChange event skipping
                //isSearching = false;
                this.richTextBoxTextLog.SelectionChanged += new System.EventHandler(this.richTextBoxTextLog_SelectionChanged);
            }
        }

        /*
         *          Telnet
         */

        private void setTelnetState(bool isOpened)
        {
            if (comm.isOpened)
            {
                // Print: "Close"
                buttonTelnetOpenClose.Text = "Close";
                CommStateChanged(CommType.Telnet);
            }
            else
            {
                // Closed, print "open"
                buttonTelnetOpenClose.Text = "Open";
                CommStateChanged(CommType.NotInitialized);
            }

            comm.isOpened = isOpened;
        }

        private void buttonTelnetOpenClose_Click(object sender, EventArgs e)
        {
            if (comm.isOpened == false)
            {
                if (Common.CheckIpAddressIsValid(textBoxTelnetIP.Text))
                {
                    // Valid ip
                    // Connect
                    comm = new Telnet(this);
                    ((Telnet)comm).Telnet_Connect(textBoxTelnetIP.Text, "", "");
                    // TODO: It is slow function !
                    setTelnetState(comm.isOpened);
                }
                else
                {
                    // Is not valid ip
                    notifyMessageForUser("Wrong IP!");
                }
            }
            else
            {
                // Close...
                // TODO:
                comm.Close();
                setTelnetState(false);
            }
        }

        /*
         *          Communication
         */

        void CommStateChanged(CommType newCommState)
        {
            commType = newCommState;

            switch(newCommState)
            {
                case CommType.Serial:
                    buttonTelnetOpenClose.Enabled = false;
                    break;

                case CommType.Telnet:
                    buttonSerialPortOpenClose.Enabled = false;
                    buttonSerialPortRefresh.Enabled = false;
                    break;

                case CommType.NotInitialized:
                default:
                    buttonTelnetOpenClose.Enabled = true;
                    buttonSerialPortOpenClose.Enabled = true;
                    buttonSerialPortRefresh.Enabled = true;
                    break;
            }
        }

    }   // End of class
}	// End of namespace
