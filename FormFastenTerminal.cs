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
        private const String imgWarning = @"Images\img_warning.png";
        private const String imgTopActive = @"Images\img_top_active.png";
        private const String imgTopInactive = @"Images\img_top_inactive.png";
        private const String imgSaveActive = @"Images\img_save_active.png";
        private const String imgSaveInactive = @"Images\img_save_inactive.png";

        // Const sounds
        private const String soundBellPath = @"Sounds\sound_bell.wav";


        // Configs
        // Application color
        private Color ApplicationDefaultBackgroundColor = Color.Gainsboro;
        private Color ApplicationDefaultTextColor = Color.Black;

        // Log colors
        private Color GlobalBackgroundColor = Form.DefaultBackColor; /* loaded from Config */
        private Color GlobalTextColor = Color.Black; /* loaded from Config */

        private bool GlobalEscapeEnabled = true;

        private Color EventLogBackgroundColor = Color.Yellow;
        private Color EventLogTextColor = Color.Blue;

        private Color SearchTextBackgroundColor = Color.Green;
        private Color SearchTextTextColor = Color.Black;

        private bool soundIsDisabled = false;

        private bool ApplicationIsTop = false;


        // Communications
        public Communication comm;
        private CommType commType = CommType.NotInitialized;

        public FavouriteCommandHandler favouriteCommands;

        //public BindingSource commandList;
        public List<Command> commandList;
        public BindingList<Command> commandBindingList;

        // FavCommand - DragDrop
        int rowIndexFromMouseDown;
        DataGridViewRow rw;

        private FastenTerminalConfigs Config;

        // LOG - text variables
        private bool SendMessageInput_Entered = false;
        private bool PeriodMessageTextBox_Entered = false;
        private bool SendMessageTextBox_ClearAfterSend = false;

        // LOG - strings
        private String tempStringBuffer = "";
        private String tempStringEscapeBuffer = ""; // For not ended escape string

        // Events / Variable configs
        private bool textLogScrollisEnabled = true;
        private bool IsreceivedIconIsGreen = false;


        /*
         *          Methods
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

            comboBoxSerialPortBaudrate.SelectedIndex = 0;

            SerialRefresh();

            // Load config
            LoadConfig();

            // Load commands
            favouriteCommands = new FavouriteCommandHandler(this);
            LoadFavouriteCommands();

            // Notify
            if (NotifyIsEnabled)
            {
                notifyIconApplication.Visible = true;
            }

            // Serial list refresh
            SerialPortRefreshTimerStart();
        }

        private void LoadConfigToComm()
        {
            // Communication configs
            comm.NeedLog = checkBoxLogEnable.Checked;
            comm.LogWithDateTime = checkBoxLogWithDateTime.Checked;

            comm.newLineString = Common.ConvertNewLineToReal(Config.config.newLineString);

            comm.printSentEvent = Config.config.printSendingMsg;
        }

        private void LoadConfigToForm()
        {
            // Call before this function the LoadConfig()
            SetBackGroundColor(ApplicationDefaultBackgroundColor);
            SetForeGroundColor(ApplicationDefaultTextColor);

            pictureBoxEventBackgrondColor.BackColor = EventLogBackgroundColor;
            pictureBoxEventTextColor.BackColor = EventLogTextColor;

            checkBoxLogEnable.Checked = Config.config.needLog;
            checkBoxLogWithDateTime.Checked = Config.config.dateLog;
            checkBoxReceiveBinaryMode.Checked = Config.config.isBinaryMode;
            checkBoxEscapeSequenceEnable.Checked = Config.config.escapeSequenceIsEnabled;

            checkBoxWordWrap.Checked = Config.config.wordWrap;
            richTextBoxTextLog.WordWrap = checkBoxWordWrap.Checked;

            checkBoxPrintSend.Checked = Config.config.printSendingMsg;

            comboBoxNewLineType.Text = Config.config.newLineString;

            // Telnet configs
            // IP
            textBoxTelnetIP.Text = Config.config.TelnetIPaddress;
            // Port
            textBoxTelnetPort.Text = Config.config.TelnetPort;

            // Serial configs
            comboBoxSerialPortBaudrate.Text = Config.config.SerialBaudrate;
        }

        private void LoadConfig()
        {
            // Application configs
            // TODO: These colors sets are duplicated
            SetBackGroundColor(ColorTranslator.FromHtml(Config.config.BackgroundColor));
            SetForeGroundColor(ColorTranslator.FromHtml(Config.config.TextColor));
            EventLogBackgroundColor = ColorTranslator.FromHtml(Config.config.EventBackgroundColor);
            EventLogTextColor = ColorTranslator.FromHtml(Config.config.EventTextColor);


            // Message configs
            //public bool needLog
            //public bool dateLog
            //public bool isBinaryMode
            //public string newLineString
            soundIsDisabled = Config.config.mute;
            //public bool wordWrap;
            //public bool printSendingMsg 
            GlobalEscapeEnabled = Config.config.escapeSequenceIsEnabled;

            LoadConfigToForm();
            LoadConfigToComm();

            // There is no change
            pictureBoxConfigIsChanged.ImageLocation = "";
            pictureBoxSave.ImageLocation = imgSaveInactive;
        }

        private void SaveConfig()
        {
            // Aplication configs
            Config.config.BackgroundColor = ColorTranslator.ToHtml(ApplicationDefaultBackgroundColor);
            Config.config.TextColor = ColorTranslator.ToHtml(ApplicationDefaultTextColor);
            Config.config.EventBackgroundColor = ColorTranslator.ToHtml(EventLogBackgroundColor);
            Config.config.EventTextColor = ColorTranslator.ToHtml(EventLogTextColor);

            // Not best solutions
            //Config.config.TextColor = ApplicationDefaultTextColor.Name;
            //Config.config.EventBackgroundColor = EventLogBackgroundColor.ToString();
            //Config.config.EventTextColor = EventLogTextColor.ToArgb().ToString();

            // Message configs
            Config.config.needLog = checkBoxLogEnable.Checked;
            Config.config.dateLog = checkBoxLogWithDateTime.Checked;
            Config.config.isBinaryMode = checkBoxReceiveBinaryMode.Checked;
            Config.config.newLineString = comboBoxNewLineType.Text;
            Config.config.mute = checkBoxMute.Checked;
            Config.config.wordWrap = checkBoxWordWrap.Checked;
            Config.config.printSendingMsg = checkBoxPrintSend.Checked;
            Config.config.escapeSequenceIsEnabled = checkBoxEscapeSequenceEnable.Checked;

            // Telnet
            Config.config.TelnetIPaddress = textBoxTelnetIP.Text;
            Config.config.TelnetPort = textBoxTelnetPort.Text;

            // Serial
            Config.config.SerialBaudrate = comboBoxSerialPortBaudrate.Text;

            Config.SaveConfigToXml();

            pictureBoxConfigIsChanged.ImageLocation = "";
            pictureBoxSave.ImageLocation = imgSaveInactive;
        }

        private void FastenTerminal_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Close event

            // Close Serial / Telnet / ...
            comm.needPrint = false;
            comm.Close();

            // Log closed
            Log.SendEventLog("Application closed");
            Log.SendErrorLog("Application closed");

            if (NotifyIsEnabled)
            {
                // Notify close
                notifyIconApplication.Visible = false;
                notifyIconApplication.Icon = null;
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

        private void pictureBoxHelp_Click(object sender, EventArgs e)
        {
            string message =
                "FastenTerminal\n" +
                "Version: " + Application.ProductVersion + "\n" +
                "\n" +
                "Author: Vizi Gábor\n" +
                "Webpage: http://www.fasten.e5tv.hu/";
            // "Webpage: <a href=\"http://www.fasten.e5tv.hu/\">www.fasten.e5tv.hu</a>"; - dosn't work

            string caption = "FastenTerminal - Help";

            MessageBox.Show(message, caption);
        }

        /*
         *      Text log
         */

        private void timerReceiveIcon_Tick(object sender, EventArgs e)
        {
            ReceiveEvent(false);
        }

        void ReceiveEvent(bool isReceived)
        {
            if (isReceived)
            {
                // Received
                timerReceiveIcon.Interval = 1000;   // 1 sec
                timerReceiveIcon.Stop();
                timerReceiveIcon.Start();           // Restart
                ReceivePictureChange(true);
            }
            else
            {
                // Not received
                timerReceiveIcon.Stop();
                ReceivePictureChange(false);
            }
        }

        public void AppendTextLogEvent(string message)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextLogEvent), new object[] { message });
                return;
            }

            // Note log (not received log!)
            if (richTextBoxTextLog != null && richTextBoxTextLog.TextLength > 0)
            {
                char lastReceivedCharacter = richTextBoxTextLog.Text[richTextBoxTextLog.TextLength - 1];
                if (lastReceivedCharacter != '\r' && lastReceivedCharacter != '\n' && lastReceivedCharacter != '\0')
                {
                    // Last char is not newline (start with newline)
                    message = Environment.NewLine + ApplicationMessage + message + Environment.NewLine;
                }
                else
                {
                    // Last char is new line
                    message = ApplicationMessage + message + Environment.NewLine;
                }
            }
            else
            {
                // Not received char
                message = ApplicationMessage + message + Environment.NewLine;
            }

            AppendTextLog(message, EventLogTextColor, EventLogBackgroundColor);
        }

        public void AppendTextLogData(string message)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(AppendTextLogData), new object[] { message });
                return;
            }

            // Original text appending, It is Work!!
            //richTextBoxTextLog.Text += value;
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
                    List<FormatType> formatList = new List<FormatType>() { FormatType.FormatType_Nothing }; ;
                    List<Color> colorList = new List<Color>() { Color.Black }; ;

                    actualEscapeType = EscapeSequence.ProcessEscapeMessage(message, out startIndex, out formatList, out colorList);

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

                        case EscapeType.Escape_TextFormat:
                            // Step on the format and color list

                            for (int i = 0; i < formatList.Count; i++)
                            {
                                FormatType format = formatList[i];
                                Color color = colorList[i];

                                switch (format)
                                {
                                    case FormatType.FormatType_TextColor:
                                        GlobalTextColor = color;
                                        break;

                                    case FormatType.FormatType_BackgroundColor:
                                        GlobalBackgroundColor = color;
                                        break;

                                    case FormatType.FormatType_Bold:
                                        // TODO: Handle bold
                                        break;

                                    case FormatType.FormatType_Underscore:
                                        // TODO: Handle underscore
                                        break;

                                    case FormatType.FormatType_Reset:
                                        GlobalTextColor = ApplicationDefaultTextColor;
                                        GlobalBackgroundColor = ApplicationDefaultBackgroundColor;
                                        break;

                                    case FormatType.FormatType_Nothing:
                                        // Do nothing
                                        break;

                                    default:
                                        // Wrong or do nothing
                                        break;
                                }
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
                            Log.SendErrorLog("ERROR: Wrong escape sequence: " + message + "\", start index: " + startIndex.ToString());
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
                richTextBoxTextLog.ScrollToCaret();         // scroll top/bot without selection start setting

                // set the current caret position to the end
                //richTextBoxTextLog.SelectionStart = richTextBoxTextLog.Text.Length;
                // scroll it automatically
                //richTextBoxTextLog.ScrollToCaret();
            }
            else
            {
                // Append text to buffer
                tempStringBuffer += message;
            }
        }

        /*
         *          Clear text log
         */

        private void pictureBoxClearScreen_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        private void ClearScreen()
        {
            tempStringBuffer = "";
            DeleteTextLog();
            SetScrollStateFinal(true);
            GlobalBackgroundColor = ApplicationDefaultBackgroundColor;
            GlobalTextColor = ApplicationDefaultTextColor;
            // checkBoxSerialPortScrollBottom Checked event call the 'ScrollBottomAndAppendBuffer();'
        }

        private void DeleteTextLog()
        {
            richTextBoxTextLog.Clear();
        }

        /*
         *          Scrolling
         */

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
            //richTextBoxTextLog.Text += tempStringBuffer;
            AppendTextLog(tempStringBuffer, GlobalTextColor, GlobalBackgroundColor);

            tempStringBuffer = "";
            //richTextBoxTextLog.SelectionStart = richTextBoxTextLog.TextLength;		// WRONG: Make stack overflow
            //richTextBoxTextLog.ScrollToCaret();	// windows is jumping
        }

        private void richTextBoxTextLog_SelectionChanged(object sender, EventArgs e)
        {
            // Selected a text, do not scroll!
            if (richTextBoxTextLog.SelectionStart != richTextBoxTextLog.TextLength)
            {
                setScrollStateByApplication(false);
            }

            if (!textLogScrollisEnabled
                && (richTextBoxTextLog.SelectionStart == richTextBoxTextLog.TextLength))
            {
                // Not scrolling, but click at end
                setScrollStateByApplication(true);
                ScrollBottomAndAppendBuffer();
                return;
            }

            // Copy is enabled
            if (checkBoxTextLogCopySelected.Checked)
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

        /*
         *              Send message
         */

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
            else if (e.KeyChar == (char)Keys.Tab)
            {
                // Extend command
                // 1. Search
                int findIndex = comboBoxSendMessage.FindString(comboBoxSendMessage.Text);
                if (findIndex >= 0)
                {
                    // Found
                    comboBoxSendMessage.SelectedIndex = findIndex;
                    // comboBoxSendingText.Items[findIndex];
                    //comboBoxSendingText.GetItemText();
                }
                // else : not found
            }
        }

        private void SendMessageText_Clear()
        {
            // Need clear text?
            if (SendMessageTextBox_ClearAfterSend)
            {
                // Clear text
                comboBoxSendMessage.Text = "";
            }
        }

        private void comboBoxSendMessage_Enter(object sender, EventArgs e)
        {
            // Enter on SendMessageTextBox TextBox
            if (SendMessageInput_Entered == false)
            {
                // Clear textbox at first time
                comboBoxSendMessage.Text = "";
                SendMessageInput_Entered = true;
            }

            // TODO: Delete these
            //Forms("Suppliers").Controls("City").TabStop = False
            //OwnedForms.Controls("").T
        }

        private void comboBoxSendMessage_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
                e.IsInputKey = true;
        }

        private void SendMessage()
        {
            if (comboBoxSendMessage.Text != null)
            {
                // Message text
                String message = comboBoxSendMessage.Text;

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

                Log.SendEventLog(messageResult);                // TODO: It is good solution?
                //AppendTextLogEvent(messageResult);

                // The message
                //Log.SendEventLog(message);
                //AppendTextLogEvent(message + "\r\n");		// Send on Serial with endline (\r\n)

                SendMessageAddLastCommand(message);

                SendMessageText_Clear();

                // Set scroll to enable
                setScrollStateByApplication(true);
            }
        }


        /*
         *              Periodical sending
         */

        public void PeriodicalSend_SetState(bool state)
        {
            // Enable, now it is running --> Write "Stop"
            // Disabled, not it is not running --> Write "Start"
            if (state)
            {
                buttonPeriodicalSendingStart.Text = "Stop";
            }
            else
            {
                buttonPeriodicalSendingStart.Text = "Start";
            }
        }

        private void PeriodSending_Start()
        {
            // TODO: Has we opened serial/telnet connection? Checked in below, but if isOpenedPort state is wrong?

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
                    comm.PeriodSendingStart((float)numericUpDownPeriodSendingTime.Value,
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

        private void buttonPeriodSendingStart_Click(object sender, EventArgs e)
        {
            // Clicked Period sending start-stop button
            PeriodSending_Start();
        }

        private void textBoxPeriodSendingMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If pressed in "PeriodMessage textbox" enter --> Send the message
            if (e.KeyChar == (char)Keys.Return)
            {
                // If pressed enter
                PeriodSending_Start();
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
         *      Search text in log
         */

        private void textBoxTextLogSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Find, if pressed enter
            if (e.KeyChar == (char)Keys.Return)
            {
                // Pressed enter
                SearchTextInTextLog();
            }
        }

        private void SearchTextInTextLog()
        {
            String searchText = textBoxTextLogSearch.Text;
            int searchTextLength = textBoxTextLogSearch.Text.Length;
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
                //int result = richTextBoxTextLog.Find(searchText);

                // Find
                int result = 1;
                while ((result = richTextBoxTextLog.Text.IndexOf(searchText, startIndex)) != -1)
                {
                    // Founded a string

                    // Select founded string

                    richTextBoxTextLog.Select(result, searchTextLength);
                    richTextBoxTextLog.SelectionBackColor = SearchTextBackgroundColor;
                    richTextBoxTextLog.SelectionColor = SearchTextTextColor;

                    startIndex = result + searchTextLength;
                }

                // End of finding

                // Search started flag: for TextChange event skipping
                //isSearching = false;
                this.richTextBoxTextLog.SelectionChanged += new System.EventHandler(this.richTextBoxTextLog_SelectionChanged);
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

            RefreshFavouriteCommands();
        }

        private void RefreshFavouriteCommands()
        {
            commandBindingList = new BindingList<Command>(commandList);
            var source = new BindingSource(commandBindingList, null);
            dataGridViewFavCommands.DataSource = source;
            dataGridViewFavCommands.Refresh();
        }

        private void FavouriteCommands_SendActualSelectedCommand()
        {
            if (dataGridViewFavCommands.CurrentRow.Index < dataGridViewFavCommands.RowCount - 1)
            {
                String message = ((Command)dataGridViewFavCommands.CurrentRow.DataBoundItem).CommandSendingString;
                comm.SendMessage(message);
            }
        }

        private void buttonFavouriteCommandSending_Click(object sender, EventArgs e)
        {
            FavouriteCommands_SendActualSelectedCommand();
        }

        private void SendMessageAddLastCommand(String message)
        {
            String command = "";

            // Copy
            command = message;

            if (comboBoxSendMessage.FindString(command) >= 0)
            {
                // We have this command in the list
                // TODO: put to top?
            }
            else
            {
                comboBoxSendMessage.Items.Add(command);
            }
        }

        private void FavCommands_AddNew(int index)
        {
            if (index >= 0)
                favouriteCommands.AddNewCommand("", "", index);
            else
                favouriteCommands.AddNewCommand("", "");

            commandList = favouriteCommands.GetCommands();

            commandBindingList = new BindingList<Command>(commandList);
            var source = new BindingSource(commandBindingList, null);
            dataGridViewFavCommands.DataSource = source;
            dataGridViewFavCommands.Refresh();
        }

        private void buttonFavouriteCommandsSave_Click(object sender, EventArgs e)
        {
            // Save favourite commands
            favouriteCommands.SaveCommandConfig();
        }

        private void buttonFavouriteCommandsAdd_Click(object sender, EventArgs e)
        {
            FavCommands_AddNew(-1);
        }

        private void dataGridViewFavCommands_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FavouriteCommands_SendActualSelectedCommand();
        }

        private void MoveFavouriteCommandToSendTextBox(String msg)
        {
            comboBoxSendMessage.Text = msg;
        }

        private void dataGridViewFavCommands_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                //m.MenuItems.Add(new MenuItem("Move to send textbox"));

                int currentMouseOverRow = dataGridViewFavCommands.HitTest(e.X, e.Y).RowIndex;

                if (currentMouseOverRow >= 0)
                {
                    // Set select
                    dataGridViewFavCommands.CurrentRow.Selected = false;

                    dataGridViewFavCommands.Rows[currentMouseOverRow].Selected = true;
                    //dataGridViewFavCommands.Rows[currentMouseOverRow].Selected = true;
                    dataGridViewFavCommands.CurrentCell = dataGridViewFavCommands.Rows[currentMouseOverRow].Cells[0];

                    String cmd = ((Command)dataGridViewFavCommands.CurrentRow.DataBoundItem).CommandSendingString;
                    m.MenuItems.Add(string.Format("Copy to send textbox \"{0}\"", cmd), EventHandler_MoveFavCommandToSendTextBox);
                    m.MenuItems.Add(string.Format("Move {0}", cmd), FavCommands_Move);
                    m.MenuItems.Add(string.Format("Paste {0}", cmd), FavCommands_Paste);
                    if (rw == null)
                        m.MenuItems[2].Enabled = false;
                    m.MenuItems.Add("Insert new command", FavCommands_InsertNew);
                }
                else
                {
                    // TODO: ...
                }

                m.Show(dataGridViewFavCommands, new Point(e.X, e.Y));
            }
        }

        private void EventHandler_MoveFavCommandToSendTextBox(object sender, System.EventArgs e)
        {
            String cmd = ((Command)dataGridViewFavCommands.CurrentRow.DataBoundItem).CommandSendingString;
            MoveFavouriteCommandToSendTextBox(cmd);
        }

        private void FavCommands_Move(object sender, System.EventArgs e)
        {
            if (dataGridViewFavCommands.SelectedRows.Count == 1)
            {
                rw = dataGridViewFavCommands.SelectedRows[0];
                rowIndexFromMouseDown = dataGridViewFavCommands.SelectedRows[0].Index;
                //dataGridViewFavCommands.DoDragDrop(rw, DragDropEffects.Move);
            }
        }

        private void FavCommands_Paste(object sender, System.EventArgs e)
        {
            if (rw != null)
            {
                int rowIndexOfItemUnderMouseToDrop;
                rowIndexOfItemUnderMouseToDrop = dataGridViewFavCommands.CurrentRow.Index;

                /* Row moving */
                FavouriteCommand_DragDrop_FromTo(rowIndexFromMouseDown, rowIndexOfItemUnderMouseToDrop);

                rw = null;
            }
        }

        private void FavCommands_InsertNew(object sender, System.EventArgs e)
        {
            int index = dataGridViewFavCommands.CurrentRow.Index;
            FavCommands_AddNew(index);
        }

        private void FavouriteCommand_DragDrop_FromTo(int rowIndexFromMouseDown, int rowIndexOfItemUnderMouseToDrop)
        {
            favouriteCommands.DragDrop_FromTo(rowIndexFromMouseDown, rowIndexOfItemUnderMouseToDrop);

            RefreshFavouriteCommands();
        }

        /*
         *                  Settings
         */

        private void checkBoxNeedLog_CheckedChanged(object sender, EventArgs e)
        {
            // TODO: Do better?
            comm.NeedLog = checkBoxLogEnable.Checked;

            if (!comm.NeedLog)
            {
                // If not log
                checkBoxLogWithDateTime.Checked = false;
            }

            ConfigIsChanged();
        }

        void ReceivePictureChange(bool isReceived)
        {
            // Show "Receive picture", if changed
            if (isReceived)
            {
                if (IsreceivedIconIsGreen != isReceived)
                {
                    pictureBoxIsReceivedText.ImageLocation = imgLocReceiveGreen;
                }
            }
            else
            {
                if (IsreceivedIconIsGreen != isReceived)
                {
                    pictureBoxIsReceivedText.ImageLocation = imgLocReceiveEmpty;
                }
            }

            IsreceivedIconIsGreen = isReceived;
        }

        private void checkBoxReceiveBinaryMode_CheckedChanged(object sender, EventArgs e)
        {
            comm.receiverModeBinary = checkBoxReceiveBinaryMode.Checked;

            if (comm.receiverModeBinary)
            {
                // Turn off Escape
                checkBoxEscapeSequenceEnable.Checked = false;
            }

            ConfigIsChanged();
        }

        private void buttonOpenLogFile_Click(object sender, EventArgs e)
        {
            // Open log file
            OpenLogFile();
        }

        private void OpenLogFile()
        {
            // Open log file
            Common.OpenTextFile(MessageLog.logFilePath);
        }

        private void checkBoxTextEscapeSequenceEnable_CheckedChanged(object sender, EventArgs e)
        {
            GlobalEscapeEnabled = checkBoxEscapeSequenceEnable.Checked;

            if (GlobalEscapeEnabled)
            {
                checkBoxReceiveBinaryMode.Checked = false;
            }
            ConfigIsChanged();
        }

        private void checkBoxLogWithDateTime_CheckedChanged(object sender, EventArgs e)
        {
            // Need to log with DateTime?
            comm.LogWithDateTime = checkBoxLogWithDateTime.Checked;
            ConfigIsChanged();
        }

        private void comboBoxSendMessageLastCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Copy clicked text to sending message text
            comboBoxSendMessage.Text = (String)comboBoxSendMessage.SelectedItem;
        }

        private void checkBoxMute_CheckedChanged(object sender, EventArgs e)
        {
            soundIsDisabled = checkBoxMute.Checked;
            ConfigIsChanged();
        }

        private void checkBoxWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            richTextBoxTextLog.WordWrap = checkBoxWordWrap.Checked;
            ConfigIsChanged();
        }

        private void checkBoxPrintSend_CheckedChanged(object sender, EventArgs e)
        {
            comm.printSentEvent = checkBoxPrintSend.Checked;
            ConfigIsChanged();
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

        private void checkBoxConfigClearSendMessageTextAfterSend_CheckedChanged(object sender, EventArgs e)
        {
            // Do nothing
            SendMessageTextBox_ClearAfterSend = checkBoxConfigClearSendMessageTextAfterSend.Checked;
        }

        void ConfigIsChanged()
        {
            pictureBoxConfigIsChanged.ImageLocation = imgWarning;
            pictureBoxSave.ImageLocation = imgSaveActive;
        }

        private void pictureBoxSave_Click(object sender, EventArgs e)
        {
            SaveConfig();
        }

        private void pictureBoxTop_Click(object sender, EventArgs e)
        {
            ApplicationTopChange();
        }

        private void ApplicationTopChange()
        {
            ApplicationIsTop = !ApplicationIsTop;
            if (ApplicationIsTop)
                pictureBoxTop.ImageLocation = imgTopActive;
            else
                pictureBoxTop.ImageLocation = imgTopInactive;

            this.TopMost = ApplicationIsTop;
        }

        /*
         *      Colors
         */

        private void pictureBoxBackGroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                SetBackGroundColor(colorDialog.Color);
                ConfigIsChanged();
            }
        }

        private void SetBackGroundColor(Color color)
        {
            ApplicationDefaultBackgroundColor = color;
            richTextBoxTextLog.BackColor = color;
            pictureBoxBackGroundColor.BackColor = color;
            this.BackColor = color;
            panelSettings.BackColor = color;
            panelLog.BackColor = color;

            // It is "delete" actual Escape sequence...
            GlobalBackgroundColor = ApplicationDefaultBackgroundColor;
        }

        private void SetForeGroundColor(Color color)
        {
            ApplicationDefaultTextColor = color;
            richTextBoxTextLog.ForeColor = color;
            pictureBoxForeGroundColor.BackColor = color;

            // It is "delete" actual Escape sequence...
            GlobalTextColor = ApplicationDefaultTextColor;
        }

        private void pictureBoxForeGroundColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                SetForeGroundColor(colorDialog.Color);
                ConfigIsChanged();
            }
        }

        private void pictureBoxEventBackgrondColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                EventLogBackgroundColor = colorDialog.Color;
                pictureBoxEventBackgrondColor.BackColor = colorDialog.Color; ;
                ConfigIsChanged();
            }
        }

        private void pictureBoxEventTextColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                EventLogTextColor = colorDialog.Color;
                pictureBoxEventTextColor.BackColor = colorDialog.Color; ;
                ConfigIsChanged();
            }
        }

        /*
         *          Communication
         */

        void CommStateChanged(CommType newCommState)
        {
            commType = newCommState;

            switch (newCommState)
            {
                case CommType.Serial:
                    // Disable other buttons
                    buttonTelnetOpenClose.Enabled = false;
                    buttonCommandPromtOpenClose.Enabled = false;
                    break;

                case CommType.Telnet:
                    // Disable other buttons
                    buttonSerialPortOpenClose.Enabled = false;
                    buttonSerialPortRefresh.Enabled = false;
                    buttonCommandPromtOpenClose.Enabled = false;
                    // Disable Serial refresh!
                    timerCheckSerialPorts.Stop();
                    break;

                case CommType.CommandPromt:
                    // Disable other buttons
                    buttonSerialPortOpenClose.Enabled = false;
                    buttonSerialPortRefresh.Enabled = false;
                    buttonTelnetOpenClose.Enabled = false;
                    // Disable Serial refresh!
                    timerCheckSerialPorts.Stop();
                    break;

                case CommType.NotInitialized:
                default:
                    // Enable all buttons
                    buttonTelnetOpenClose.Enabled = true;
                    buttonSerialPortOpenClose.Enabled = true;
                    buttonSerialPortRefresh.Enabled = true;
                    buttonCommandPromtOpenClose.Enabled = true;
                    // Enable serial port refreshing
                    SerialPortRefreshTimerStart();
                    break;
            }

            LoadConfigToComm();
        }

        private void checkBoxNewLineEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxNewLineEnabled.Checked)
                comm.newLineString = "";
            else
                comm.newLineString = Common.ConvertNewLineToReal(comboBoxNewLineType.Text);
        }

        private void comboBoxNewLineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: Refresh the communication newLineString, if communication is changed !!
            comm.newLineString = Common.ConvertNewLineToReal(comboBoxNewLineType.Text);
        }

        public void CommReceivedCharacterEvent()
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new Action(CommReceivedCharacterEvent), new object[] { });
                return;
            }

            ReceiveEvent(true);
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

            // Refresh application name
            RefreshTitle();

            //comm.isOpened = isOpened;
        }

        private void telnetOpenClose()
        {
            if (comm.isOpened == false)
            {
                int port = 0;
                if (Common.CheckIpAddressIsValid(textBoxTelnetIP.Text) && (Common.CheckPortisValid(textBoxTelnetPort.Text, out port)))
                {
                    // Valid ip & port
                    // Connect
                    comm = new Telnet(this);
                    ((Telnet)comm).Telnet_Connect(textBoxTelnetIP.Text, port, "", "");
                    // TODO: It is slow function !
                    setTelnetState(comm.isOpened);
                }
                else
                {
                    // Is not valid ip
                    notifyMessageForUser("Wrong IP or port!");
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

        private void buttonTelnetOpenClose_Click(object sender, EventArgs e)
        {
            telnetOpenClose();
        }

        /*
		 *			 Serial port
		 */

        private void buttonSerialPortRefresh_Click(object sender, EventArgs e)
        {
            // Clicked "Serial Refresh" button
            SerialRefresh();
        }

        private void SerialPortRefreshTimerStart()
        {
            // Refresh serial port list timer
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
                Log.SendErrorLog("Serial refresh error (known bug - reinitialize Serial):\n" + ex.Message);
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

                    Log.SendErrorLog("Serial OpenClose error (known bug - reinitialize Serial):\n" + ex.Message);
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

            CommReceivedCharacterEvent();
        }

        private void serialPortDevice_ErrorReceived(object sender, System.IO.Ports.SerialErrorReceivedEventArgs e)
        {
            Log.SendErrorLog("Serial: Error received:" + e.ToString());
        }

        /*
         * Command promt
         */

        private void CommandPromt_Start()
        {
            if (comm.isOpened == false)
            {
                // Open / initialize
                if (!(comm is CommandPromt))
                {
                    comm = new CommandPromt(this);
                }

                setCmdPromtState(true);
                
                // Do not call _Start(), because now we cannot use cmd "forever", only call with command
                //((CommandPromt)comm).CommandPromt_Start();
            }
            else
            {
                // Close
                comm.Close();

                setCmdPromtState(false);
            }
        }

        private void setCmdPromtState(bool newState)
        {
            if (comm.isOpened)
            {
                // Print: "Close"
                buttonCommandPromtOpenClose.Text = "Close";
                CommStateChanged(CommType.CommandPromt);
            }
            else
            {
                // Closed, print "Open"
                buttonCommandPromtOpenClose.Text = "Open";
                CommStateChanged(CommType.NotInitialized);
            }

            // Refresh application name
            RefreshTitle();
        }

        private void buttonCommandPromtOpenClose_Click(object sender, EventArgs e)
        {
            CommandPromt_Start();
        }
    }   // End of class
}	// End of namespace
