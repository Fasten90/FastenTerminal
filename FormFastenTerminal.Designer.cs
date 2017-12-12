namespace FastenTerminal
{
    partial class FormFastenTerminal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFastenTerminal));
            this.serialPortDevice = new System.IO.Ports.SerialPort(this.components);
            this.notifyIconApplication = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonClearSerialTexts = new System.Windows.Forms.Button();
            this.textBoxSerialTextFind = new System.Windows.Forms.TextBox();
            this.tabControlSerialFunctions = new System.Windows.Forms.TabControl();
            this.tabPageCommunication = new System.Windows.Forms.TabPage();
            this.groupBoxCommTelnet = new System.Windows.Forms.GroupBox();
            this.textBoxTelnetPort = new System.Windows.Forms.TextBox();
            this.textBoxTelnetIP = new System.Windows.Forms.TextBox();
            this.buttonTelnetOpenClose = new System.Windows.Forms.Button();
            this.groupBoxCommSerial = new System.Windows.Forms.GroupBox();
            this.comboBoxSerialPortCOM = new System.Windows.Forms.ComboBox();
            this.buttonSerialPortRefresh = new System.Windows.Forms.Button();
            this.buttonSerialPortOpenClose = new System.Windows.Forms.Button();
            this.comboBoxSerialPortBaudrate = new System.Windows.Forms.ComboBox();
            this.tabPageMessage = new System.Windows.Forms.TabPage();
            this.groupBoxPeriodicalSending = new System.Windows.Forms.GroupBox();
            this.buttonPeriodicalSendingStart = new System.Windows.Forms.Button();
            this.numericUpDownSerialPeriodSendingTime = new System.Windows.Forms.NumericUpDown();
            this.labelSerialPeriodSendingConstText = new System.Windows.Forms.Label();
            this.textBoxPeriodSendingMessage = new System.Windows.Forms.TextBox();
            this.groupBoxMessageSearch = new System.Windows.Forms.GroupBox();
            this.buttonSerialOpenLogFile = new System.Windows.Forms.Button();
            this.tabPageSerialCommands = new System.Windows.Forms.TabPage();
            this.buttonSerialFavouriteCommandsAdd = new System.Windows.Forms.Button();
            this.buttonSerialFavouriteCommandsSave = new System.Windows.Forms.Button();
            this.dataGridViewFavCommands = new System.Windows.Forms.DataGridView();
            this.buttonSerialFavouriteCommandSending = new System.Windows.Forms.Button();
            this.tabPageConfiguration = new System.Windows.Forms.TabPage();
            this.checkBoxNewLineEnabled = new System.Windows.Forms.CheckBox();
            this.buttonForeGroundColorChange = new System.Windows.Forms.Button();
            this.buttonBackGroundColorChange = new System.Windows.Forms.Button();
            this.comboBoxNewLineType = new System.Windows.Forms.ComboBox();
            this.checkBoxPrintSend = new System.Windows.Forms.CheckBox();
            this.checkBoxWordWrap = new System.Windows.Forms.CheckBox();
            this.checkBoxMute = new System.Windows.Forms.CheckBox();
            this.buttonSerialSaveConfig = new System.Windows.Forms.Button();
            this.checkBoxReceiveBinaryMode = new System.Windows.Forms.CheckBox();
            this.checkBoxConfigClearSendMessageTextAfterSend = new System.Windows.Forms.CheckBox();
            this.checkBoxLogWithDateTime = new System.Windows.Forms.CheckBox();
            this.checkBoxLogEnable = new System.Windows.Forms.CheckBox();
            this.checkBoxEscapeSequenceEnable = new System.Windows.Forms.CheckBox();
            this.checkBoxSerialCopySelected = new System.Windows.Forms.CheckBox();
            this.buttonSerialPortSend = new System.Windows.Forms.Button();
            this.comboBoxSendMessage = new System.Windows.Forms.ComboBox();
            this.pictureBoxSerialReceiving = new System.Windows.Forms.PictureBox();
            this.timerReceiveIcon = new System.Windows.Forms.Timer(this.components);
            this.timerCheckSerialPorts = new System.Windows.Forms.Timer(this.components);
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.richTextBoxTextLog = new System.Windows.Forms.RichTextBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.pictureBoxScrollingEnabled = new System.Windows.Forms.PictureBox();
            this.panelLog = new System.Windows.Forms.Panel();
            this.tabControlSerialFunctions.SuspendLayout();
            this.tabPageCommunication.SuspendLayout();
            this.groupBoxCommTelnet.SuspendLayout();
            this.groupBoxCommSerial.SuspendLayout();
            this.tabPageMessage.SuspendLayout();
            this.groupBoxPeriodicalSending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSerialPeriodSendingTime)).BeginInit();
            this.groupBoxMessageSearch.SuspendLayout();
            this.tabPageSerialCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavCommands)).BeginInit();
            this.tabPageConfiguration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSerialReceiving)).BeginInit();
            this.panelSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScrollingEnabled)).BeginInit();
            this.panelLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPortDevice
            // 
            this.serialPortDevice.BaudRate = 115200;
            this.serialPortDevice.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPortDevice_ErrorReceived);
            this.serialPortDevice.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortDevice_DataReceived);
            // 
            // notifyIconApplication
            // 
            this.notifyIconApplication.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconApplication.Icon")));
            this.notifyIconApplication.Text = "FastenTerminal";
            this.notifyIconApplication.Visible = true;
            // 
            // buttonClearSerialTexts
            // 
            this.buttonClearSerialTexts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearSerialTexts.Image = ((System.Drawing.Image)(resources.GetObject("buttonClearSerialTexts.Image")));
            this.buttonClearSerialTexts.Location = new System.Drawing.Point(56, 3);
            this.buttonClearSerialTexts.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClearSerialTexts.Name = "buttonClearSerialTexts";
            this.buttonClearSerialTexts.Size = new System.Drawing.Size(22, 22);
            this.buttonClearSerialTexts.TabIndex = 36;
            this.buttonClearSerialTexts.UseVisualStyleBackColor = true;
            this.buttonClearSerialTexts.Click += new System.EventHandler(this.buttonClearSerialTexts_Click);
            // 
            // textBoxSerialTextFind
            // 
            this.textBoxSerialTextFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSerialTextFind.Location = new System.Drawing.Point(3, 19);
            this.textBoxSerialTextFind.Name = "textBoxSerialTextFind";
            this.textBoxSerialTextFind.Size = new System.Drawing.Size(219, 20);
            this.textBoxSerialTextFind.TabIndex = 32;
            this.textBoxSerialTextFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSerialTextFind_KeyPress);
            // 
            // tabControlSerialFunctions
            // 
            this.tabControlSerialFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSerialFunctions.Controls.Add(this.tabPageCommunication);
            this.tabControlSerialFunctions.Controls.Add(this.tabPageMessage);
            this.tabControlSerialFunctions.Controls.Add(this.tabPageSerialCommands);
            this.tabControlSerialFunctions.Controls.Add(this.tabPageConfiguration);
            this.tabControlSerialFunctions.Location = new System.Drawing.Point(0, 29);
            this.tabControlSerialFunctions.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlSerialFunctions.Multiline = true;
            this.tabControlSerialFunctions.Name = "tabControlSerialFunctions";
            this.tabControlSerialFunctions.Padding = new System.Drawing.Point(0, 0);
            this.tabControlSerialFunctions.SelectedIndex = 0;
            this.tabControlSerialFunctions.Size = new System.Drawing.Size(245, 429);
            this.tabControlSerialFunctions.TabIndex = 41;
            // 
            // tabPageCommunication
            // 
            this.tabPageCommunication.Controls.Add(this.groupBoxCommTelnet);
            this.tabPageCommunication.Controls.Add(this.groupBoxCommSerial);
            this.tabPageCommunication.Location = new System.Drawing.Point(4, 22);
            this.tabPageCommunication.Name = "tabPageCommunication";
            this.tabPageCommunication.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCommunication.Size = new System.Drawing.Size(237, 403);
            this.tabPageCommunication.TabIndex = 4;
            this.tabPageCommunication.Text = "Comm";
            this.tabPageCommunication.UseVisualStyleBackColor = true;
            // 
            // groupBoxCommTelnet
            // 
            this.groupBoxCommTelnet.Controls.Add(this.textBoxTelnetPort);
            this.groupBoxCommTelnet.Controls.Add(this.textBoxTelnetIP);
            this.groupBoxCommTelnet.Controls.Add(this.buttonTelnetOpenClose);
            this.groupBoxCommTelnet.Location = new System.Drawing.Point(7, 93);
            this.groupBoxCommTelnet.Name = "groupBoxCommTelnet";
            this.groupBoxCommTelnet.Size = new System.Drawing.Size(219, 77);
            this.groupBoxCommTelnet.TabIndex = 10;
            this.groupBoxCommTelnet.TabStop = false;
            this.groupBoxCommTelnet.Text = "Telnet";
            // 
            // textBoxTelnetPort
            // 
            this.textBoxTelnetPort.Location = new System.Drawing.Point(7, 45);
            this.textBoxTelnetPort.Name = "textBoxTelnetPort";
            this.textBoxTelnetPort.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelnetPort.TabIndex = 3;
            this.textBoxTelnetPort.Text = "23";
            // 
            // textBoxTelnetIP
            // 
            this.textBoxTelnetIP.Location = new System.Drawing.Point(7, 18);
            this.textBoxTelnetIP.Name = "textBoxTelnetIP";
            this.textBoxTelnetIP.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelnetIP.TabIndex = 2;
            this.textBoxTelnetIP.Text = "192.168.1.62";
            // 
            // buttonTelnetOpenClose
            // 
            this.buttonTelnetOpenClose.Location = new System.Drawing.Point(113, 18);
            this.buttonTelnetOpenClose.Name = "buttonTelnetOpenClose";
            this.buttonTelnetOpenClose.Size = new System.Drawing.Size(99, 23);
            this.buttonTelnetOpenClose.TabIndex = 1;
            this.buttonTelnetOpenClose.Text = "Open";
            this.buttonTelnetOpenClose.UseVisualStyleBackColor = true;
            this.buttonTelnetOpenClose.Click += new System.EventHandler(this.buttonTelnetOpenClose_Click);
            // 
            // groupBoxCommSerial
            // 
            this.groupBoxCommSerial.Controls.Add(this.comboBoxSerialPortCOM);
            this.groupBoxCommSerial.Controls.Add(this.buttonSerialPortRefresh);
            this.groupBoxCommSerial.Controls.Add(this.buttonSerialPortOpenClose);
            this.groupBoxCommSerial.Controls.Add(this.comboBoxSerialPortBaudrate);
            this.groupBoxCommSerial.Location = new System.Drawing.Point(6, 6);
            this.groupBoxCommSerial.Name = "groupBoxCommSerial";
            this.groupBoxCommSerial.Size = new System.Drawing.Size(220, 80);
            this.groupBoxCommSerial.TabIndex = 9;
            this.groupBoxCommSerial.TabStop = false;
            this.groupBoxCommSerial.Text = "Serial";
            // 
            // comboBoxSerialPortCOM
            // 
            this.comboBoxSerialPortCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerialPortCOM.FormattingEnabled = true;
            this.comboBoxSerialPortCOM.Location = new System.Drawing.Point(6, 19);
            this.comboBoxSerialPortCOM.Name = "comboBoxSerialPortCOM";
            this.comboBoxSerialPortCOM.Size = new System.Drawing.Size(102, 21);
            this.comboBoxSerialPortCOM.TabIndex = 3;
            this.comboBoxSerialPortCOM.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPortCOM_SelectedIndexChanged);
            // 
            // buttonSerialPortRefresh
            // 
            this.buttonSerialPortRefresh.Location = new System.Drawing.Point(114, 17);
            this.buttonSerialPortRefresh.Name = "buttonSerialPortRefresh";
            this.buttonSerialPortRefresh.Size = new System.Drawing.Size(100, 23);
            this.buttonSerialPortRefresh.TabIndex = 8;
            this.buttonSerialPortRefresh.Text = "Port Refresh";
            this.buttonSerialPortRefresh.UseVisualStyleBackColor = true;
            this.buttonSerialPortRefresh.Click += new System.EventHandler(this.buttonSerialPortRefresh_Click);
            // 
            // buttonSerialPortOpenClose
            // 
            this.buttonSerialPortOpenClose.Location = new System.Drawing.Point(114, 46);
            this.buttonSerialPortOpenClose.Name = "buttonSerialPortOpenClose";
            this.buttonSerialPortOpenClose.Size = new System.Drawing.Size(100, 23);
            this.buttonSerialPortOpenClose.TabIndex = 1;
            this.buttonSerialPortOpenClose.Text = "Port open";
            this.buttonSerialPortOpenClose.UseVisualStyleBackColor = true;
            this.buttonSerialPortOpenClose.Click += new System.EventHandler(this.buttonSerialPortOpenClose_Click);
            // 
            // comboBoxSerialPortBaudrate
            // 
            this.comboBoxSerialPortBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerialPortBaudrate.FormattingEnabled = true;
            this.comboBoxSerialPortBaudrate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.comboBoxSerialPortBaudrate.Location = new System.Drawing.Point(6, 46);
            this.comboBoxSerialPortBaudrate.Name = "comboBoxSerialPortBaudrate";
            this.comboBoxSerialPortBaudrate.Size = new System.Drawing.Size(102, 21);
            this.comboBoxSerialPortBaudrate.TabIndex = 4;
            this.comboBoxSerialPortBaudrate.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPortBaudrate_SelectedIndexChanged);
            // 
            // tabPageMessage
            // 
            this.tabPageMessage.Controls.Add(this.groupBoxPeriodicalSending);
            this.tabPageMessage.Controls.Add(this.groupBoxMessageSearch);
            this.tabPageMessage.Controls.Add(this.buttonSerialOpenLogFile);
            this.tabPageMessage.Location = new System.Drawing.Point(4, 22);
            this.tabPageMessage.Name = "tabPageMessage";
            this.tabPageMessage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessage.Size = new System.Drawing.Size(237, 403);
            this.tabPageMessage.TabIndex = 2;
            this.tabPageMessage.Text = "Message";
            this.tabPageMessage.UseVisualStyleBackColor = true;
            // 
            // groupBoxPeriodicalSending
            // 
            this.groupBoxPeriodicalSending.Controls.Add(this.buttonPeriodicalSendingStart);
            this.groupBoxPeriodicalSending.Controls.Add(this.numericUpDownSerialPeriodSendingTime);
            this.groupBoxPeriodicalSending.Controls.Add(this.labelSerialPeriodSendingConstText);
            this.groupBoxPeriodicalSending.Controls.Add(this.textBoxPeriodSendingMessage);
            this.groupBoxPeriodicalSending.Location = new System.Drawing.Point(3, 60);
            this.groupBoxPeriodicalSending.Name = "groupBoxPeriodicalSending";
            this.groupBoxPeriodicalSending.Size = new System.Drawing.Size(228, 75);
            this.groupBoxPeriodicalSending.TabIndex = 46;
            this.groupBoxPeriodicalSending.TabStop = false;
            this.groupBoxPeriodicalSending.Text = "Periodical sending";
            // 
            // buttonPeriodicalSendingStart
            // 
            this.buttonPeriodicalSendingStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPeriodicalSendingStart.Location = new System.Drawing.Point(172, 19);
            this.buttonPeriodicalSendingStart.Name = "buttonPeriodicalSendingStart";
            this.buttonPeriodicalSendingStart.Size = new System.Drawing.Size(50, 23);
            this.buttonPeriodicalSendingStart.TabIndex = 2;
            this.buttonPeriodicalSendingStart.Text = "Start";
            this.buttonPeriodicalSendingStart.UseVisualStyleBackColor = true;
            this.buttonPeriodicalSendingStart.Click += new System.EventHandler(this.buttonSerialPeriodSendingStart_Click);
            // 
            // numericUpDownSerialPeriodSendingTime
            // 
            this.numericUpDownSerialPeriodSendingTime.Location = new System.Drawing.Point(66, 45);
            this.numericUpDownSerialPeriodSendingTime.Name = "numericUpDownSerialPeriodSendingTime";
            this.numericUpDownSerialPeriodSendingTime.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownSerialPeriodSendingTime.TabIndex = 0;
            this.numericUpDownSerialPeriodSendingTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelSerialPeriodSendingConstText
            // 
            this.labelSerialPeriodSendingConstText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSerialPeriodSendingConstText.AutoSize = true;
            this.labelSerialPeriodSendingConstText.Location = new System.Drawing.Point(13, 47);
            this.labelSerialPeriodSendingConstText.Name = "labelSerialPeriodSendingConstText";
            this.labelSerialPeriodSendingConstText.Size = new System.Drawing.Size(47, 13);
            this.labelSerialPeriodSendingConstText.TabIndex = 1;
            this.labelSerialPeriodSendingConstText.Text = "Second:";
            // 
            // textBoxPeriodSendingMessage
            // 
            this.textBoxPeriodSendingMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPeriodSendingMessage.Location = new System.Drawing.Point(12, 19);
            this.textBoxPeriodSendingMessage.Name = "textBoxPeriodSendingMessage";
            this.textBoxPeriodSendingMessage.Size = new System.Drawing.Size(154, 20);
            this.textBoxPeriodSendingMessage.TabIndex = 3;
            this.textBoxPeriodSendingMessage.Text = "<Periodical sending message>";
            this.textBoxPeriodSendingMessage.Enter += new System.EventHandler(this.textBoxPeriodSendingMessage_Enter);
            this.textBoxPeriodSendingMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPeriodSendingMessage_KeyPress);
            // 
            // groupBoxMessageSearch
            // 
            this.groupBoxMessageSearch.Controls.Add(this.textBoxSerialTextFind);
            this.groupBoxMessageSearch.Location = new System.Drawing.Point(3, 6);
            this.groupBoxMessageSearch.Name = "groupBoxMessageSearch";
            this.groupBoxMessageSearch.Size = new System.Drawing.Size(228, 48);
            this.groupBoxMessageSearch.TabIndex = 45;
            this.groupBoxMessageSearch.TabStop = false;
            this.groupBoxMessageSearch.Text = "Search Text in LOG";
            // 
            // buttonSerialOpenLogFile
            // 
            this.buttonSerialOpenLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSerialOpenLogFile.Location = new System.Drawing.Point(6, 152);
            this.buttonSerialOpenLogFile.Name = "buttonSerialOpenLogFile";
            this.buttonSerialOpenLogFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSerialOpenLogFile.TabIndex = 44;
            this.buttonSerialOpenLogFile.Text = "Open log";
            this.buttonSerialOpenLogFile.UseVisualStyleBackColor = true;
            this.buttonSerialOpenLogFile.Click += new System.EventHandler(this.buttonSerialOpenLogFile_Click);
            // 
            // tabPageSerialCommands
            // 
            this.tabPageSerialCommands.Controls.Add(this.buttonSerialFavouriteCommandsAdd);
            this.tabPageSerialCommands.Controls.Add(this.buttonSerialFavouriteCommandsSave);
            this.tabPageSerialCommands.Controls.Add(this.dataGridViewFavCommands);
            this.tabPageSerialCommands.Controls.Add(this.buttonSerialFavouriteCommandSending);
            this.tabPageSerialCommands.Location = new System.Drawing.Point(4, 22);
            this.tabPageSerialCommands.Name = "tabPageSerialCommands";
            this.tabPageSerialCommands.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSerialCommands.Size = new System.Drawing.Size(237, 403);
            this.tabPageSerialCommands.TabIndex = 0;
            this.tabPageSerialCommands.Text = "Command";
            this.tabPageSerialCommands.UseVisualStyleBackColor = true;
            // 
            // buttonSerialFavouriteCommandsAdd
            // 
            this.buttonSerialFavouriteCommandsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSerialFavouriteCommandsAdd.Location = new System.Drawing.Point(130, 362);
            this.buttonSerialFavouriteCommandsAdd.Name = "buttonSerialFavouriteCommandsAdd";
            this.buttonSerialFavouriteCommandsAdd.Size = new System.Drawing.Size(62, 23);
            this.buttonSerialFavouriteCommandsAdd.TabIndex = 24;
            this.buttonSerialFavouriteCommandsAdd.Text = "Add";
            this.buttonSerialFavouriteCommandsAdd.UseVisualStyleBackColor = true;
            this.buttonSerialFavouriteCommandsAdd.Click += new System.EventHandler(this.buttonSerialFavouriteCommandsAdd_Click);
            // 
            // buttonSerialFavouriteCommandsSave
            // 
            this.buttonSerialFavouriteCommandsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSerialFavouriteCommandsSave.Location = new System.Drawing.Point(73, 362);
            this.buttonSerialFavouriteCommandsSave.Name = "buttonSerialFavouriteCommandsSave";
            this.buttonSerialFavouriteCommandsSave.Size = new System.Drawing.Size(51, 23);
            this.buttonSerialFavouriteCommandsSave.TabIndex = 23;
            this.buttonSerialFavouriteCommandsSave.Text = "Save";
            this.buttonSerialFavouriteCommandsSave.UseVisualStyleBackColor = true;
            this.buttonSerialFavouriteCommandsSave.Click += new System.EventHandler(this.buttonSerialFavouriteCommandsSave_Click);
            // 
            // dataGridViewFavCommands
            // 
            this.dataGridViewFavCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFavCommands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFavCommands.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewFavCommands.MultiSelect = false;
            this.dataGridViewFavCommands.Name = "dataGridViewFavCommands";
            this.dataGridViewFavCommands.RowHeadersVisible = false;
            this.dataGridViewFavCommands.Size = new System.Drawing.Size(234, 353);
            this.dataGridViewFavCommands.TabIndex = 22;
            // 
            // buttonSerialFavouriteCommandSending
            // 
            this.buttonSerialFavouriteCommandSending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSerialFavouriteCommandSending.Location = new System.Drawing.Point(6, 362);
            this.buttonSerialFavouriteCommandSending.Name = "buttonSerialFavouriteCommandSending";
            this.buttonSerialFavouriteCommandSending.Size = new System.Drawing.Size(61, 23);
            this.buttonSerialFavouriteCommandSending.TabIndex = 14;
            this.buttonSerialFavouriteCommandSending.Text = "Send";
            this.buttonSerialFavouriteCommandSending.UseVisualStyleBackColor = true;
            this.buttonSerialFavouriteCommandSending.Click += new System.EventHandler(this.buttonSerialFavouriteCommandSending_Click);
            // 
            // tabPageConfiguration
            // 
            this.tabPageConfiguration.Controls.Add(this.checkBoxNewLineEnabled);
            this.tabPageConfiguration.Controls.Add(this.buttonForeGroundColorChange);
            this.tabPageConfiguration.Controls.Add(this.buttonBackGroundColorChange);
            this.tabPageConfiguration.Controls.Add(this.comboBoxNewLineType);
            this.tabPageConfiguration.Controls.Add(this.checkBoxPrintSend);
            this.tabPageConfiguration.Controls.Add(this.checkBoxWordWrap);
            this.tabPageConfiguration.Controls.Add(this.checkBoxMute);
            this.tabPageConfiguration.Controls.Add(this.buttonSerialSaveConfig);
            this.tabPageConfiguration.Controls.Add(this.checkBoxReceiveBinaryMode);
            this.tabPageConfiguration.Controls.Add(this.checkBoxConfigClearSendMessageTextAfterSend);
            this.tabPageConfiguration.Controls.Add(this.checkBoxLogWithDateTime);
            this.tabPageConfiguration.Controls.Add(this.checkBoxLogEnable);
            this.tabPageConfiguration.Controls.Add(this.checkBoxEscapeSequenceEnable);
            this.tabPageConfiguration.Controls.Add(this.checkBoxSerialCopySelected);
            this.tabPageConfiguration.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfiguration.Name = "tabPageConfiguration";
            this.tabPageConfiguration.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConfiguration.Size = new System.Drawing.Size(237, 403);
            this.tabPageConfiguration.TabIndex = 3;
            this.tabPageConfiguration.Text = "Config";
            this.tabPageConfiguration.UseVisualStyleBackColor = true;
            // 
            // checkBoxNewLineEnabled
            // 
            this.checkBoxNewLineEnabled.AutoSize = true;
            this.checkBoxNewLineEnabled.Checked = true;
            this.checkBoxNewLineEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxNewLineEnabled.Location = new System.Drawing.Point(6, 296);
            this.checkBoxNewLineEnabled.Name = "checkBoxNewLineEnabled";
            this.checkBoxNewLineEnabled.Size = new System.Drawing.Size(67, 17);
            this.checkBoxNewLineEnabled.TabIndex = 50;
            this.checkBoxNewLineEnabled.Text = "New line";
            this.checkBoxNewLineEnabled.UseVisualStyleBackColor = true;
            this.checkBoxNewLineEnabled.CheckedChanged += new System.EventHandler(this.checkBoxNewLineEnabled_CheckedChanged);
            // 
            // buttonForeGroundColorChange
            // 
            this.buttonForeGroundColorChange.Location = new System.Drawing.Point(9, 36);
            this.buttonForeGroundColorChange.Name = "buttonForeGroundColorChange";
            this.buttonForeGroundColorChange.Size = new System.Drawing.Size(75, 23);
            this.buttonForeGroundColorChange.TabIndex = 49;
            this.buttonForeGroundColorChange.Text = "Foreground";
            this.buttonForeGroundColorChange.UseVisualStyleBackColor = true;
            this.buttonForeGroundColorChange.Click += new System.EventHandler(this.buttonForeGroundColor_Click);
            // 
            // buttonBackGroundColorChange
            // 
            this.buttonBackGroundColorChange.Location = new System.Drawing.Point(9, 6);
            this.buttonBackGroundColorChange.Name = "buttonBackGroundColorChange";
            this.buttonBackGroundColorChange.Size = new System.Drawing.Size(75, 23);
            this.buttonBackGroundColorChange.TabIndex = 48;
            this.buttonBackGroundColorChange.Text = "Background";
            this.buttonBackGroundColorChange.UseVisualStyleBackColor = true;
            this.buttonBackGroundColorChange.Click += new System.EventHandler(this.buttonBackGroundColor_Click);
            // 
            // comboBoxNewLineType
            // 
            this.comboBoxNewLineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNewLineType.FormattingEnabled = true;
            this.comboBoxNewLineType.Items.AddRange(new object[] {
            "\\r\\n",
            "\\r",
            "\\n",
            "\\0",
            "-"});
            this.comboBoxNewLineType.Location = new System.Drawing.Point(86, 294);
            this.comboBoxNewLineType.Name = "comboBoxNewLineType";
            this.comboBoxNewLineType.Size = new System.Drawing.Size(57, 21);
            this.comboBoxNewLineType.TabIndex = 46;
            this.comboBoxNewLineType.SelectedIndexChanged += new System.EventHandler(this.comboBoxNewLineType_SelectedIndexChanged);
            // 
            // checkBoxPrintSend
            // 
            this.checkBoxPrintSend.AutoSize = true;
            this.checkBoxPrintSend.Location = new System.Drawing.Point(6, 271);
            this.checkBoxPrintSend.Name = "checkBoxPrintSend";
            this.checkBoxPrintSend.Size = new System.Drawing.Size(100, 17);
            this.checkBoxPrintSend.TabIndex = 45;
            this.checkBoxPrintSend.Text = "Log send event";
            this.checkBoxPrintSend.UseVisualStyleBackColor = true;
            this.checkBoxPrintSend.CheckedChanged += new System.EventHandler(this.checkBoxPrintSend_CheckedChanged);
            // 
            // checkBoxWordWrap
            // 
            this.checkBoxWordWrap.AutoSize = true;
            this.checkBoxWordWrap.Location = new System.Drawing.Point(6, 248);
            this.checkBoxWordWrap.Name = "checkBoxWordWrap";
            this.checkBoxWordWrap.Size = new System.Drawing.Size(78, 17);
            this.checkBoxWordWrap.TabIndex = 44;
            this.checkBoxWordWrap.Text = "Word wrap";
            this.checkBoxWordWrap.UseVisualStyleBackColor = true;
            this.checkBoxWordWrap.CheckedChanged += new System.EventHandler(this.checkBoxWordWrap_CheckedChanged);
            // 
            // checkBoxMute
            // 
            this.checkBoxMute.AutoSize = true;
            this.checkBoxMute.Location = new System.Drawing.Point(6, 224);
            this.checkBoxMute.Name = "checkBoxMute";
            this.checkBoxMute.Size = new System.Drawing.Size(50, 17);
            this.checkBoxMute.TabIndex = 43;
            this.checkBoxMute.Text = "Mute";
            this.checkBoxMute.UseVisualStyleBackColor = true;
            this.checkBoxMute.CheckedChanged += new System.EventHandler(this.checkBoxMute_CheckedChanged);
            // 
            // buttonSerialSaveConfig
            // 
            this.buttonSerialSaveConfig.Location = new System.Drawing.Point(3, 319);
            this.buttonSerialSaveConfig.Name = "buttonSerialSaveConfig";
            this.buttonSerialSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonSerialSaveConfig.TabIndex = 42;
            this.buttonSerialSaveConfig.Text = "Save config";
            this.buttonSerialSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSerialSaveConfig.Click += new System.EventHandler(this.buttonSerialSaveConfig_Click);
            // 
            // checkBoxReceiveBinaryMode
            // 
            this.checkBoxReceiveBinaryMode.AutoSize = true;
            this.checkBoxReceiveBinaryMode.Location = new System.Drawing.Point(6, 177);
            this.checkBoxReceiveBinaryMode.Name = "checkBoxReceiveBinaryMode";
            this.checkBoxReceiveBinaryMode.Size = new System.Drawing.Size(98, 17);
            this.checkBoxReceiveBinaryMode.TabIndex = 41;
            this.checkBoxReceiveBinaryMode.Text = "Receive Binary";
            this.checkBoxReceiveBinaryMode.UseVisualStyleBackColor = true;
            this.checkBoxReceiveBinaryMode.CheckedChanged += new System.EventHandler(this.checkBoxReceiveBinaryMode_CheckedChanged);
            // 
            // checkBoxConfigClearSendMessageTextAfterSend
            // 
            this.checkBoxConfigClearSendMessageTextAfterSend.AutoSize = true;
            this.checkBoxConfigClearSendMessageTextAfterSend.Location = new System.Drawing.Point(6, 200);
            this.checkBoxConfigClearSendMessageTextAfterSend.Name = "checkBoxConfigClearSendMessageTextAfterSend";
            this.checkBoxConfigClearSendMessageTextAfterSend.Size = new System.Drawing.Size(100, 17);
            this.checkBoxConfigClearSendMessageTextAfterSend.TabIndex = 40;
            this.checkBoxConfigClearSendMessageTextAfterSend.Text = "Clear after send";
            this.checkBoxConfigClearSendMessageTextAfterSend.UseVisualStyleBackColor = true;
            this.checkBoxConfigClearSendMessageTextAfterSend.CheckedChanged += new System.EventHandler(this.checkBoxConfigClearSendMessageTextAfterSend_CheckedChanged);
            // 
            // checkBoxLogWithDateTime
            // 
            this.checkBoxLogWithDateTime.AutoSize = true;
            this.checkBoxLogWithDateTime.Checked = true;
            this.checkBoxLogWithDateTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLogWithDateTime.Location = new System.Drawing.Point(6, 107);
            this.checkBoxLogWithDateTime.Name = "checkBoxLogWithDateTime";
            this.checkBoxLogWithDateTime.Size = new System.Drawing.Size(90, 17);
            this.checkBoxLogWithDateTime.TabIndex = 38;
            this.checkBoxLogWithDateTime.Text = "Log with date";
            this.checkBoxLogWithDateTime.UseVisualStyleBackColor = true;
            this.checkBoxLogWithDateTime.CheckedChanged += new System.EventHandler(this.checkBoxLogWithDateTime_CheckedChanged);
            // 
            // checkBoxLogEnable
            // 
            this.checkBoxLogEnable.AutoSize = true;
            this.checkBoxLogEnable.Checked = true;
            this.checkBoxLogEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLogEnable.Location = new System.Drawing.Point(6, 84);
            this.checkBoxLogEnable.Name = "checkBoxLogEnable";
            this.checkBoxLogEnable.Size = new System.Drawing.Size(72, 17);
            this.checkBoxLogEnable.TabIndex = 2;
            this.checkBoxLogEnable.Text = "Log to file";
            this.checkBoxLogEnable.UseVisualStyleBackColor = true;
            this.checkBoxLogEnable.CheckedChanged += new System.EventHandler(this.checkBoxNeedLog_CheckedChanged);
            // 
            // checkBoxEscapeSequenceEnable
            // 
            this.checkBoxEscapeSequenceEnable.AutoSize = true;
            this.checkBoxEscapeSequenceEnable.Checked = true;
            this.checkBoxEscapeSequenceEnable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEscapeSequenceEnable.Location = new System.Drawing.Point(6, 154);
            this.checkBoxEscapeSequenceEnable.Name = "checkBoxEscapeSequenceEnable";
            this.checkBoxEscapeSequenceEnable.Size = new System.Drawing.Size(117, 17);
            this.checkBoxEscapeSequenceEnable.TabIndex = 31;
            this.checkBoxEscapeSequenceEnable.Text = "Escape sequences";
            this.checkBoxEscapeSequenceEnable.UseVisualStyleBackColor = true;
            this.checkBoxEscapeSequenceEnable.CheckedChanged += new System.EventHandler(this.checkBoxSerialTextEscapeSequenceCheckingCheckedChanged);
            // 
            // checkBoxSerialCopySelected
            // 
            this.checkBoxSerialCopySelected.AutoSize = true;
            this.checkBoxSerialCopySelected.Checked = true;
            this.checkBoxSerialCopySelected.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSerialCopySelected.Location = new System.Drawing.Point(6, 130);
            this.checkBoxSerialCopySelected.Name = "checkBoxSerialCopySelected";
            this.checkBoxSerialCopySelected.Size = new System.Drawing.Size(137, 17);
            this.checkBoxSerialCopySelected.TabIndex = 13;
            this.checkBoxSerialCopySelected.Text = "Copy text with selecting";
            this.checkBoxSerialCopySelected.UseVisualStyleBackColor = true;
            // 
            // buttonSerialPortSend
            // 
            this.buttonSerialPortSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSerialPortSend.Location = new System.Drawing.Point(490, 426);
            this.buttonSerialPortSend.Name = "buttonSerialPortSend";
            this.buttonSerialPortSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSerialPortSend.TabIndex = 39;
            this.buttonSerialPortSend.Text = "Send";
            this.buttonSerialPortSend.UseVisualStyleBackColor = true;
            this.buttonSerialPortSend.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // comboBoxSendMessage
            // 
            this.comboBoxSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSendMessage.FormattingEnabled = true;
            this.comboBoxSendMessage.Location = new System.Drawing.Point(3, 428);
            this.comboBoxSendMessage.Name = "comboBoxSendMessage";
            this.comboBoxSendMessage.Size = new System.Drawing.Size(481, 21);
            this.comboBoxSendMessage.TabIndex = 42;
            this.comboBoxSendMessage.Text = "<Sending message with \\r\\n>";
            this.comboBoxSendMessage.Enter += new System.EventHandler(this.comboBoxSendMessage_Enter);
            this.comboBoxSendMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxSerialSendMessage_KeyPress);
            this.comboBoxSendMessage.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.comboBoxSendMessage_PreviewKeyDown);
            // 
            // pictureBoxSerialReceiving
            // 
            this.pictureBoxSerialReceiving.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSerialReceiving.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSerialReceiving.Image")));
            this.pictureBoxSerialReceiving.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSerialReceiving.InitialImage")));
            this.pictureBoxSerialReceiving.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxSerialReceiving.Name = "pictureBoxSerialReceiving";
            this.pictureBoxSerialReceiving.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxSerialReceiving.TabIndex = 43;
            this.pictureBoxSerialReceiving.TabStop = false;
            // 
            // timerReceiveIcon
            // 
            this.timerReceiveIcon.Tick += new System.EventHandler(this.timerReceiveIcon_Tick);
            // 
            // timerCheckSerialPorts
            // 
            this.timerCheckSerialPorts.Interval = 500;
            this.timerCheckSerialPorts.Tick += new System.EventHandler(this.timerCheckSerialPorts_Tick);
            // 
            // richTextBoxTextLog
            // 
            this.richTextBoxTextLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxTextLog.AutoWordSelection = true;
            this.richTextBoxTextLog.DetectUrls = false;
            this.richTextBoxTextLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxTextLog.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxTextLog.Name = "richTextBoxTextLog";
            this.richTextBoxTextLog.ReadOnly = true;
            this.richTextBoxTextLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxTextLog.Size = new System.Drawing.Size(562, 419);
            this.richTextBoxTextLog.TabIndex = 37;
            this.richTextBoxTextLog.Text = "";
            this.richTextBoxTextLog.WordWrap = false;
            this.richTextBoxTextLog.SelectionChanged += new System.EventHandler(this.richTextBoxTextLog_SelectionChanged);
            // 
            // panelSettings
            // 
            this.panelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSettings.Controls.Add(this.pictureBoxScrollingEnabled);
            this.panelSettings.Controls.Add(this.buttonClearSerialTexts);
            this.panelSettings.Controls.Add(this.pictureBoxSerialReceiving);
            this.panelSettings.Controls.Add(this.tabControlSerialFunctions);
            this.panelSettings.Location = new System.Drawing.Point(574, 3);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(245, 458);
            this.panelSettings.TabIndex = 45;
            // 
            // pictureBoxScrollingEnabled
            // 
            this.pictureBoxScrollingEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxScrollingEnabled.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxScrollingEnabled.Image")));
            this.pictureBoxScrollingEnabled.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxScrollingEnabled.InitialImage")));
            this.pictureBoxScrollingEnabled.Location = new System.Drawing.Point(30, 4);
            this.pictureBoxScrollingEnabled.Name = "pictureBoxScrollingEnabled";
            this.pictureBoxScrollingEnabled.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxScrollingEnabled.TabIndex = 44;
            this.pictureBoxScrollingEnabled.TabStop = false;
            this.pictureBoxScrollingEnabled.Click += new System.EventHandler(this.pictureBoxScrollingEnabled_Click);
            // 
            // panelLog
            // 
            this.panelLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLog.Controls.Add(this.comboBoxSendMessage);
            this.panelLog.Controls.Add(this.buttonSerialPortSend);
            this.panelLog.Controls.Add(this.richTextBoxTextLog);
            this.panelLog.Location = new System.Drawing.Point(3, 3);
            this.panelLog.Margin = new System.Windows.Forms.Padding(0);
            this.panelLog.Name = "panelLog";
            this.panelLog.Size = new System.Drawing.Size(568, 458);
            this.panelLog.TabIndex = 46;
            // 
            // FormFastenTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 462);
            this.Controls.Add(this.panelLog);
            this.Controls.Add(this.panelSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "FormFastenTerminal";
            this.Text = "FastenTerminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FastenTerminal_FormClosing);
            this.Load += new System.EventHandler(this.FormFastenTerminalMain_Load);
            this.tabControlSerialFunctions.ResumeLayout(false);
            this.tabPageCommunication.ResumeLayout(false);
            this.groupBoxCommTelnet.ResumeLayout(false);
            this.groupBoxCommTelnet.PerformLayout();
            this.groupBoxCommSerial.ResumeLayout(false);
            this.tabPageMessage.ResumeLayout(false);
            this.groupBoxPeriodicalSending.ResumeLayout(false);
            this.groupBoxPeriodicalSending.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSerialPeriodSendingTime)).EndInit();
            this.groupBoxMessageSearch.ResumeLayout(false);
            this.groupBoxMessageSearch.PerformLayout();
            this.tabPageSerialCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavCommands)).EndInit();
            this.tabPageConfiguration.ResumeLayout(false);
            this.tabPageConfiguration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSerialReceiving)).EndInit();
            this.panelSettings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScrollingEnabled)).EndInit();
            this.panelLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

		private System.IO.Ports.SerialPort serialPortDevice;
		public System.Windows.Forms.NotifyIcon notifyIconApplication;
		private System.Windows.Forms.Button buttonClearSerialTexts;
		private System.Windows.Forms.TextBox textBoxSerialTextFind;
		private System.Windows.Forms.TabControl tabControlSerialFunctions;
		private System.Windows.Forms.TabPage tabPageSerialCommands;
		private System.Windows.Forms.Button buttonSerialFavouriteCommandSending;
		private System.Windows.Forms.TabPage tabPageMessage;
		private System.Windows.Forms.TabPage tabPageConfiguration;
		private System.Windows.Forms.ComboBox comboBoxSerialPortCOM;
		private System.Windows.Forms.Button buttonSerialPortOpenClose;
		private System.Windows.Forms.CheckBox checkBoxLogEnable;
		private System.Windows.Forms.ComboBox comboBoxSerialPortBaudrate;
		private System.Windows.Forms.Button buttonSerialPortRefresh;
		private System.Windows.Forms.CheckBox checkBoxEscapeSequenceEnable;
		private System.Windows.Forms.CheckBox checkBoxSerialCopySelected;
		private System.Windows.Forms.Button buttonSerialPortSend;
		private System.Windows.Forms.Button buttonPeriodicalSendingStart;
		private System.Windows.Forms.Label labelSerialPeriodSendingConstText;
		private System.Windows.Forms.NumericUpDown numericUpDownSerialPeriodSendingTime;
		private System.Windows.Forms.TextBox textBoxPeriodSendingMessage;
		private System.Windows.Forms.CheckBox checkBoxLogWithDateTime;
		private System.Windows.Forms.ComboBox comboBoxSendMessage;
		private System.Windows.Forms.CheckBox checkBoxConfigClearSendMessageTextAfterSend;
		private System.Windows.Forms.DataGridView dataGridViewFavCommands;
		private System.Windows.Forms.Button buttonSerialFavouriteCommandsSave;
		private System.Windows.Forms.Button buttonSerialFavouriteCommandsAdd;
		private System.Windows.Forms.PictureBox pictureBoxSerialReceiving;
		private System.Windows.Forms.Timer timerReceiveIcon;
		private System.Windows.Forms.CheckBox checkBoxReceiveBinaryMode;
		private System.Windows.Forms.Button buttonSerialOpenLogFile;
		private System.Windows.Forms.Button buttonSerialSaveConfig;
        private System.Windows.Forms.CheckBox checkBoxMute;
        private System.Windows.Forms.CheckBox checkBoxWordWrap;
        private System.Windows.Forms.CheckBox checkBoxPrintSend;
        private System.Windows.Forms.Timer timerCheckSerialPorts;
        private System.Windows.Forms.ComboBox comboBoxNewLineType;
        private System.Windows.Forms.Button buttonForeGroundColorChange;
        private System.Windows.Forms.Button buttonBackGroundColorChange;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.RichTextBox richTextBoxTextLog;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelLog;
        private System.Windows.Forms.TabPage tabPageCommunication;
        private System.Windows.Forms.CheckBox checkBoxNewLineEnabled;
        private System.Windows.Forms.GroupBox groupBoxCommSerial;
        private System.Windows.Forms.GroupBox groupBoxCommTelnet;
        private System.Windows.Forms.Button buttonTelnetOpenClose;
        private System.Windows.Forms.TextBox textBoxTelnetIP;
        private System.Windows.Forms.PictureBox pictureBoxScrollingEnabled;
        private System.Windows.Forms.GroupBox groupBoxMessageSearch;
        private System.Windows.Forms.GroupBox groupBoxPeriodicalSending;
        private System.Windows.Forms.TextBox textBoxTelnetPort;
    }
}

