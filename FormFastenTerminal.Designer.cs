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
            this.labelConstTextSearching = new System.Windows.Forms.Label();
            this.textBoxSerialTextFind = new System.Windows.Forms.TextBox();
            this.tabControlSerialFunctions = new System.Windows.Forms.TabControl();
            this.tabPageSerialCommunicationSettings = new System.Windows.Forms.TabPage();
            this.checkBoxMute = new System.Windows.Forms.CheckBox();
            this.buttonSerialSaveConfig = new System.Windows.Forms.Button();
            this.checkBoxSerialReceiveBinaryMode = new System.Windows.Forms.CheckBox();
            this.checkBoxSerialConfigClearSendMessageTextAfterSend = new System.Windows.Forms.CheckBox();
            this.checkBoxSerialAppendPerRPerN = new System.Windows.Forms.CheckBox();
            this.checkBoxLogWithDateTime = new System.Windows.Forms.CheckBox();
            this.checkBoxSerialHex = new System.Windows.Forms.CheckBox();
            this.comboBoxSerialPortCOM = new System.Windows.Forms.ComboBox();
            this.buttonSerialPortOpen = new System.Windows.Forms.Button();
            this.checkBoxSerialPortLog = new System.Windows.Forms.CheckBox();
            this.comboBoxSerialPortBaudrate = new System.Windows.Forms.ComboBox();
            this.buttonSerialPortRefresh = new System.Windows.Forms.Button();
            this.checkBoxSerialTextColouring = new System.Windows.Forms.CheckBox();
            this.checkBoxSerialLogScrollBottom = new System.Windows.Forms.CheckBox();
            this.checkBoxSerialCopySelected = new System.Windows.Forms.CheckBox();
            this.tabPageSerialCommands = new System.Windows.Forms.TabPage();
            this.buttonSerialFavouriteCommandsAdd = new System.Windows.Forms.Button();
            this.buttonSerialFavouriteCommandsSave = new System.Windows.Forms.Button();
            this.dataGridViewFavCommands = new System.Windows.Forms.DataGridView();
            this.buttonSerialFavouriteCommandSending = new System.Windows.Forms.Button();
            this.tabPageSerialPeriodSending = new System.Windows.Forms.TabPage();
            this.labelSerialPeriodSendingConstTextMessage = new System.Windows.Forms.Label();
            this.textBoxPeriodSendingMessage = new System.Windows.Forms.TextBox();
            this.buttonSerialPeriodSendingStart = new System.Windows.Forms.Button();
            this.labelSerialPeriodSendingConstText = new System.Windows.Forms.Label();
            this.numericUpDownSerialPeriodSendingTime = new System.Windows.Forms.NumericUpDown();
            this.tabPageCalculator = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelConstCalculatorDec = new System.Windows.Forms.Label();
            this.labelConstCalculatorBinary = new System.Windows.Forms.Label();
            this.textBoxCalculatorDec = new System.Windows.Forms.TextBox();
            this.textBoxCalculatorHex = new System.Windows.Forms.TextBox();
            this.textBoxCalculatorBin = new System.Windows.Forms.TextBox();
            this.labelConstCalculatorHex = new System.Windows.Forms.Label();
            this.richTextBoxSerialPortTexts = new System.Windows.Forms.RichTextBox();
            this.buttonSerialPortSend = new System.Windows.Forms.Button();
            this.comboBoxSerialSendingText = new System.Windows.Forms.ComboBox();
            this.pictureBoxSerialReceiving = new System.Windows.Forms.PictureBox();
            this.timerReceiveIcon = new System.Windows.Forms.Timer(this.components);
            this.buttonSerialOpenLogFile = new System.Windows.Forms.Button();
            this.checkBoxWordWrap = new System.Windows.Forms.CheckBox();
            this.checkBoxPrintSend = new System.Windows.Forms.CheckBox();
            this.tabControlSerialFunctions.SuspendLayout();
            this.tabPageSerialCommunicationSettings.SuspendLayout();
            this.tabPageSerialCommands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavCommands)).BeginInit();
            this.tabPageSerialPeriodSending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSerialPeriodSendingTime)).BeginInit();
            this.tabPageCalculator.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSerialReceiving)).BeginInit();
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
            this.notifyIconApplication.Text = "FastenTerminal";
            // 
            // buttonClearSerialTexts
            // 
            this.buttonClearSerialTexts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearSerialTexts.Location = new System.Drawing.Point(656, 30);
            this.buttonClearSerialTexts.Name = "buttonClearSerialTexts";
            this.buttonClearSerialTexts.Size = new System.Drawing.Size(90, 23);
            this.buttonClearSerialTexts.TabIndex = 36;
            this.buttonClearSerialTexts.Text = "Clear screen";
            this.buttonClearSerialTexts.UseVisualStyleBackColor = true;
            this.buttonClearSerialTexts.Click += new System.EventHandler(this.buttonClearSerialTexts_Click);
            // 
            // labelConstTextSearching
            // 
            this.labelConstTextSearching.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelConstTextSearching.AutoSize = true;
            this.labelConstTextSearching.Location = new System.Drawing.Point(540, 7);
            this.labelConstTextSearching.Name = "labelConstTextSearching";
            this.labelConstTextSearching.Size = new System.Drawing.Size(44, 13);
            this.labelConstTextSearching.TabIndex = 33;
            this.labelConstTextSearching.Text = "Search:";
            // 
            // textBoxSerialTextFind
            // 
            this.textBoxSerialTextFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSerialTextFind.Location = new System.Drawing.Point(594, 4);
            this.textBoxSerialTextFind.Name = "textBoxSerialTextFind";
            this.textBoxSerialTextFind.Size = new System.Drawing.Size(152, 20);
            this.textBoxSerialTextFind.TabIndex = 32;
            this.textBoxSerialTextFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSerialTextFind_KeyPress);
            // 
            // tabControlSerialFunctions
            // 
            this.tabControlSerialFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlSerialFunctions.Controls.Add(this.tabPageSerialCommunicationSettings);
            this.tabControlSerialFunctions.Controls.Add(this.tabPageSerialCommands);
            this.tabControlSerialFunctions.Controls.Add(this.tabPageSerialPeriodSending);
            this.tabControlSerialFunctions.Controls.Add(this.tabPageCalculator);
            this.tabControlSerialFunctions.Location = new System.Drawing.Point(540, 59);
            this.tabControlSerialFunctions.Multiline = true;
            this.tabControlSerialFunctions.Name = "tabControlSerialFunctions";
            this.tabControlSerialFunctions.SelectedIndex = 0;
            this.tabControlSerialFunctions.Size = new System.Drawing.Size(219, 392);
            this.tabControlSerialFunctions.TabIndex = 41;
            // 
            // tabPageSerialCommunicationSettings
            // 
            this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxPrintSend);
            this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxWordWrap);
            this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxMute);
            this.tabPageSerialCommunicationSettings.Controls.Add(this.buttonSerialSaveConfig);
            this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxSerialReceiveBinaryMode);
            this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxSerialConfigClearSendMessageTextAfterSend);
            this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxSerialAppendPerRPerN);
            this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxLogWithDateTime);
            this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxSerialHex);
            this.tabPageSerialCommunicationSettings.Controls.Add(this.comboBoxSerialPortCOM);
            this.tabPageSerialCommunicationSettings.Controls.Add(this.buttonSerialPortOpen);
            this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxSerialPortLog);
            this.tabPageSerialCommunicationSettings.Controls.Add(this.comboBoxSerialPortBaudrate);
            this.tabPageSerialCommunicationSettings.Controls.Add(this.buttonSerialPortRefresh);
            this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxSerialTextColouring);
            this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxSerialLogScrollBottom);
            this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxSerialCopySelected);
            this.tabPageSerialCommunicationSettings.Location = new System.Drawing.Point(4, 40);
            this.tabPageSerialCommunicationSettings.Name = "tabPageSerialCommunicationSettings";
            this.tabPageSerialCommunicationSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSerialCommunicationSettings.Size = new System.Drawing.Size(211, 348);
            this.tabPageSerialCommunicationSettings.TabIndex = 3;
            this.tabPageSerialCommunicationSettings.Text = "Configuration";
            this.tabPageSerialCommunicationSettings.UseVisualStyleBackColor = true;
            // 
            // checkBoxMute
            // 
            this.checkBoxMute.AutoSize = true;
            this.checkBoxMute.Location = new System.Drawing.Point(4, 272);
            this.checkBoxMute.Name = "checkBoxMute";
            this.checkBoxMute.Size = new System.Drawing.Size(50, 17);
            this.checkBoxMute.TabIndex = 43;
            this.checkBoxMute.Text = "Mute";
            this.checkBoxMute.UseVisualStyleBackColor = true;
            this.checkBoxMute.CheckedChanged += new System.EventHandler(this.checkBoxMute_CheckedChanged);
            // 
            // buttonSerialSaveConfig
            // 
            this.buttonSerialSaveConfig.Location = new System.Drawing.Point(127, 313);
            this.buttonSerialSaveConfig.Name = "buttonSerialSaveConfig";
            this.buttonSerialSaveConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonSerialSaveConfig.TabIndex = 42;
            this.buttonSerialSaveConfig.Text = "Save config";
            this.buttonSerialSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSerialSaveConfig.Click += new System.EventHandler(this.buttonSerialSaveConfig_Click);
            // 
            // checkBoxSerialReceiveBinaryMode
            // 
            this.checkBoxSerialReceiveBinaryMode.AutoSize = true;
            this.checkBoxSerialReceiveBinaryMode.Location = new System.Drawing.Point(6, 177);
            this.checkBoxSerialReceiveBinaryMode.Name = "checkBoxSerialReceiveBinaryMode";
            this.checkBoxSerialReceiveBinaryMode.Size = new System.Drawing.Size(98, 17);
            this.checkBoxSerialReceiveBinaryMode.TabIndex = 41;
            this.checkBoxSerialReceiveBinaryMode.Text = "Receive Binary";
            this.checkBoxSerialReceiveBinaryMode.UseVisualStyleBackColor = true;
            this.checkBoxSerialReceiveBinaryMode.CheckedChanged += new System.EventHandler(this.checkBoxSerialReceiveBinaryMode_CheckedChanged);
            // 
            // checkBoxSerialConfigClearSendMessageTextAfterSend
            // 
            this.checkBoxSerialConfigClearSendMessageTextAfterSend.AutoSize = true;
            this.checkBoxSerialConfigClearSendMessageTextAfterSend.Location = new System.Drawing.Point(4, 248);
            this.checkBoxSerialConfigClearSendMessageTextAfterSend.Name = "checkBoxSerialConfigClearSendMessageTextAfterSend";
            this.checkBoxSerialConfigClearSendMessageTextAfterSend.Size = new System.Drawing.Size(100, 17);
            this.checkBoxSerialConfigClearSendMessageTextAfterSend.TabIndex = 40;
            this.checkBoxSerialConfigClearSendMessageTextAfterSend.Text = "Clear after send";
            this.checkBoxSerialConfigClearSendMessageTextAfterSend.UseVisualStyleBackColor = true;
            this.checkBoxSerialConfigClearSendMessageTextAfterSend.CheckedChanged += new System.EventHandler(this.checkBoxSerialConfigClearSendMessageTextAfterSend_CheckedChanged);
            // 
            // checkBoxSerialAppendPerRPerN
            // 
            this.checkBoxSerialAppendPerRPerN.AutoSize = true;
            this.checkBoxSerialAppendPerRPerN.Checked = true;
            this.checkBoxSerialAppendPerRPerN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSerialAppendPerRPerN.Location = new System.Drawing.Point(6, 224);
            this.checkBoxSerialAppendPerRPerN.Name = "checkBoxSerialAppendPerRPerN";
            this.checkBoxSerialAppendPerRPerN.Size = new System.Drawing.Size(45, 17);
            this.checkBoxSerialAppendPerRPerN.TabIndex = 39;
            this.checkBoxSerialAppendPerRPerN.Text = "\\r\\n";
            this.checkBoxSerialAppendPerRPerN.UseVisualStyleBackColor = true;
            this.checkBoxSerialAppendPerRPerN.CheckedChanged += new System.EventHandler(this.checkSerialAppendPerRPerN_CheckedChanged);
            // 
            // checkBoxLogWithDateTime
            // 
            this.checkBoxLogWithDateTime.AutoSize = true;
            this.checkBoxLogWithDateTime.Checked = true;
            this.checkBoxLogWithDateTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLogWithDateTime.Location = new System.Drawing.Point(6, 85);
            this.checkBoxLogWithDateTime.Name = "checkBoxLogWithDateTime";
            this.checkBoxLogWithDateTime.Size = new System.Drawing.Size(90, 17);
            this.checkBoxLogWithDateTime.TabIndex = 38;
            this.checkBoxLogWithDateTime.Text = "Log with date";
            this.checkBoxLogWithDateTime.UseVisualStyleBackColor = true;
            this.checkBoxLogWithDateTime.CheckedChanged += new System.EventHandler(this.checkBoxLogWithDateTime_CheckedChanged);
            // 
            // checkBoxSerialHex
            // 
            this.checkBoxSerialHex.AutoSize = true;
            this.checkBoxSerialHex.Location = new System.Drawing.Point(6, 200);
            this.checkBoxSerialHex.Name = "checkBoxSerialHex";
            this.checkBoxSerialHex.Size = new System.Drawing.Size(45, 17);
            this.checkBoxSerialHex.TabIndex = 37;
            this.checkBoxSerialHex.Text = "Hex";
            this.checkBoxSerialHex.UseVisualStyleBackColor = true;
            this.checkBoxSerialHex.CheckedChanged += new System.EventHandler(this.checkBoxSerialHex_CheckedChanged);
            // 
            // comboBoxSerialPortCOM
            // 
            this.comboBoxSerialPortCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerialPortCOM.FormattingEnabled = true;
            this.comboBoxSerialPortCOM.Location = new System.Drawing.Point(6, 6);
            this.comboBoxSerialPortCOM.Name = "comboBoxSerialPortCOM";
            this.comboBoxSerialPortCOM.Size = new System.Drawing.Size(82, 21);
            this.comboBoxSerialPortCOM.TabIndex = 3;
            this.comboBoxSerialPortCOM.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPortCOM_SelectedIndexChanged);
            // 
            // buttonSerialPortOpen
            // 
            this.buttonSerialPortOpen.Location = new System.Drawing.Point(102, 35);
            this.buttonSerialPortOpen.Name = "buttonSerialPortOpen";
            this.buttonSerialPortOpen.Size = new System.Drawing.Size(90, 23);
            this.buttonSerialPortOpen.TabIndex = 1;
            this.buttonSerialPortOpen.Text = "Port open";
            this.buttonSerialPortOpen.UseVisualStyleBackColor = true;
            this.buttonSerialPortOpen.Click += new System.EventHandler(this.buttonSerialPortOpen_Click);
            // 
            // checkBoxSerialPortLog
            // 
            this.checkBoxSerialPortLog.AutoSize = true;
            this.checkBoxSerialPortLog.Checked = true;
            this.checkBoxSerialPortLog.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSerialPortLog.Location = new System.Drawing.Point(6, 62);
            this.checkBoxSerialPortLog.Name = "checkBoxSerialPortLog";
            this.checkBoxSerialPortLog.Size = new System.Drawing.Size(72, 17);
            this.checkBoxSerialPortLog.TabIndex = 2;
            this.checkBoxSerialPortLog.Text = "Log to file";
            this.checkBoxSerialPortLog.UseVisualStyleBackColor = true;
            this.checkBoxSerialPortLog.CheckedChanged += new System.EventHandler(this.checkBoxSerialPortLog_CheckedChanged);
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
            this.comboBoxSerialPortBaudrate.Location = new System.Drawing.Point(6, 35);
            this.comboBoxSerialPortBaudrate.Name = "comboBoxSerialPortBaudrate";
            this.comboBoxSerialPortBaudrate.Size = new System.Drawing.Size(82, 21);
            this.comboBoxSerialPortBaudrate.TabIndex = 4;
            this.comboBoxSerialPortBaudrate.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPortBaudrate_SelectedIndexChanged);
            // 
            // buttonSerialPortRefresh
            // 
            this.buttonSerialPortRefresh.Location = new System.Drawing.Point(102, 6);
            this.buttonSerialPortRefresh.Name = "buttonSerialPortRefresh";
            this.buttonSerialPortRefresh.Size = new System.Drawing.Size(90, 23);
            this.buttonSerialPortRefresh.TabIndex = 8;
            this.buttonSerialPortRefresh.Text = "Port Refresh";
            this.buttonSerialPortRefresh.UseVisualStyleBackColor = true;
            this.buttonSerialPortRefresh.Click += new System.EventHandler(this.buttonSerialPortRefresh_Click);
            // 
            // checkBoxSerialTextColouring
            // 
            this.checkBoxSerialTextColouring.AutoSize = true;
            this.checkBoxSerialTextColouring.Checked = true;
            this.checkBoxSerialTextColouring.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSerialTextColouring.Location = new System.Drawing.Point(6, 154);
            this.checkBoxSerialTextColouring.Name = "checkBoxSerialTextColouring";
            this.checkBoxSerialTextColouring.Size = new System.Drawing.Size(117, 17);
            this.checkBoxSerialTextColouring.TabIndex = 31;
            this.checkBoxSerialTextColouring.Text = "Escape sequences";
            this.checkBoxSerialTextColouring.UseVisualStyleBackColor = true;
            this.checkBoxSerialTextColouring.CheckedChanged += new System.EventHandler(this.checkBoxSerialTextEscapeSequenceCheckingCheckedChanged);
            // 
            // checkBoxSerialLogScrollBottom
            // 
            this.checkBoxSerialLogScrollBottom.AutoSize = true;
            this.checkBoxSerialLogScrollBottom.Checked = true;
            this.checkBoxSerialLogScrollBottom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSerialLogScrollBottom.Location = new System.Drawing.Point(6, 108);
            this.checkBoxSerialLogScrollBottom.Name = "checkBoxSerialLogScrollBottom";
            this.checkBoxSerialLogScrollBottom.Size = new System.Drawing.Size(66, 17);
            this.checkBoxSerialLogScrollBottom.TabIndex = 12;
            this.checkBoxSerialLogScrollBottom.Text = "Scrolling";
            this.checkBoxSerialLogScrollBottom.UseVisualStyleBackColor = true;
            this.checkBoxSerialLogScrollBottom.CheckedChanged += new System.EventHandler(this.checkBoxSerialLogScrollBottom_CheckedChanged);
            // 
            // checkBoxSerialCopySelected
            // 
            this.checkBoxSerialCopySelected.AutoSize = true;
            this.checkBoxSerialCopySelected.Checked = true;
            this.checkBoxSerialCopySelected.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSerialCopySelected.Location = new System.Drawing.Point(6, 131);
            this.checkBoxSerialCopySelected.Name = "checkBoxSerialCopySelected";
            this.checkBoxSerialCopySelected.Size = new System.Drawing.Size(137, 17);
            this.checkBoxSerialCopySelected.TabIndex = 13;
            this.checkBoxSerialCopySelected.Text = "Copy text with selecting";
            this.checkBoxSerialCopySelected.UseVisualStyleBackColor = true;
            // 
            // tabPageSerialCommands
            // 
            this.tabPageSerialCommands.Controls.Add(this.buttonSerialFavouriteCommandsAdd);
            this.tabPageSerialCommands.Controls.Add(this.buttonSerialFavouriteCommandsSave);
            this.tabPageSerialCommands.Controls.Add(this.dataGridViewFavCommands);
            this.tabPageSerialCommands.Controls.Add(this.buttonSerialFavouriteCommandSending);
            this.tabPageSerialCommands.Location = new System.Drawing.Point(4, 40);
            this.tabPageSerialCommands.Name = "tabPageSerialCommands";
            this.tabPageSerialCommands.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSerialCommands.Size = new System.Drawing.Size(211, 348);
            this.tabPageSerialCommands.TabIndex = 0;
            this.tabPageSerialCommands.Text = "Commands";
            this.tabPageSerialCommands.UseVisualStyleBackColor = true;
            // 
            // buttonSerialFavouriteCommandsAdd
            // 
            this.buttonSerialFavouriteCommandsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSerialFavouriteCommandsAdd.Location = new System.Drawing.Point(130, 307);
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
            this.buttonSerialFavouriteCommandsSave.Location = new System.Drawing.Point(73, 307);
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
            this.dataGridViewFavCommands.Size = new System.Drawing.Size(192, 298);
            this.dataGridViewFavCommands.TabIndex = 22;
            // 
            // buttonSerialFavouriteCommandSending
            // 
            this.buttonSerialFavouriteCommandSending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSerialFavouriteCommandSending.Location = new System.Drawing.Point(6, 307);
            this.buttonSerialFavouriteCommandSending.Name = "buttonSerialFavouriteCommandSending";
            this.buttonSerialFavouriteCommandSending.Size = new System.Drawing.Size(61, 23);
            this.buttonSerialFavouriteCommandSending.TabIndex = 14;
            this.buttonSerialFavouriteCommandSending.Text = "Send";
            this.buttonSerialFavouriteCommandSending.UseVisualStyleBackColor = true;
            this.buttonSerialFavouriteCommandSending.Click += new System.EventHandler(this.buttonSerialFavouriteCommandSending_Click);
            // 
            // tabPageSerialPeriodSending
            // 
            this.tabPageSerialPeriodSending.Controls.Add(this.labelSerialPeriodSendingConstTextMessage);
            this.tabPageSerialPeriodSending.Controls.Add(this.textBoxPeriodSendingMessage);
            this.tabPageSerialPeriodSending.Controls.Add(this.buttonSerialPeriodSendingStart);
            this.tabPageSerialPeriodSending.Controls.Add(this.labelSerialPeriodSendingConstText);
            this.tabPageSerialPeriodSending.Controls.Add(this.numericUpDownSerialPeriodSendingTime);
            this.tabPageSerialPeriodSending.Location = new System.Drawing.Point(4, 40);
            this.tabPageSerialPeriodSending.Name = "tabPageSerialPeriodSending";
            this.tabPageSerialPeriodSending.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSerialPeriodSending.Size = new System.Drawing.Size(211, 348);
            this.tabPageSerialPeriodSending.TabIndex = 2;
            this.tabPageSerialPeriodSending.Text = "Periodical sending";
            this.tabPageSerialPeriodSending.UseVisualStyleBackColor = true;
            // 
            // labelSerialPeriodSendingConstTextMessage
            // 
            this.labelSerialPeriodSendingConstTextMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSerialPeriodSendingConstTextMessage.AutoSize = true;
            this.labelSerialPeriodSendingConstTextMessage.Location = new System.Drawing.Point(4, 47);
            this.labelSerialPeriodSendingConstTextMessage.Name = "labelSerialPeriodSendingConstTextMessage";
            this.labelSerialPeriodSendingConstTextMessage.Size = new System.Drawing.Size(94, 13);
            this.labelSerialPeriodSendingConstTextMessage.TabIndex = 4;
            this.labelSerialPeriodSendingConstTextMessage.Text = "Sending message:";
            // 
            // textBoxPeriodSendingMessage
            // 
            this.textBoxPeriodSendingMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPeriodSendingMessage.Location = new System.Drawing.Point(6, 63);
            this.textBoxPeriodSendingMessage.Name = "textBoxPeriodSendingMessage";
            this.textBoxPeriodSendingMessage.Size = new System.Drawing.Size(186, 20);
            this.textBoxPeriodSendingMessage.TabIndex = 3;
            this.textBoxPeriodSendingMessage.Text = "<Periodical sending message>";
            this.textBoxPeriodSendingMessage.Enter += new System.EventHandler(this.textBoxPeriodSendingMessage_Enter);
            this.textBoxPeriodSendingMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPeriodSendingMessage_KeyPress);
            // 
            // buttonSerialPeriodSendingStart
            // 
            this.buttonSerialPeriodSendingStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSerialPeriodSendingStart.Location = new System.Drawing.Point(142, 8);
            this.buttonSerialPeriodSendingStart.Name = "buttonSerialPeriodSendingStart";
            this.buttonSerialPeriodSendingStart.Size = new System.Drawing.Size(50, 23);
            this.buttonSerialPeriodSendingStart.TabIndex = 2;
            this.buttonSerialPeriodSendingStart.Text = "Start";
            this.buttonSerialPeriodSendingStart.UseVisualStyleBackColor = true;
            this.buttonSerialPeriodSendingStart.Click += new System.EventHandler(this.buttonSerialPeriodSendingStart_Click);
            // 
            // labelSerialPeriodSendingConstText
            // 
            this.labelSerialPeriodSendingConstText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSerialPeriodSendingConstText.AutoSize = true;
            this.labelSerialPeriodSendingConstText.Location = new System.Drawing.Point(3, 13);
            this.labelSerialPeriodSendingConstText.Name = "labelSerialPeriodSendingConstText";
            this.labelSerialPeriodSendingConstText.Size = new System.Drawing.Size(47, 13);
            this.labelSerialPeriodSendingConstText.TabIndex = 1;
            this.labelSerialPeriodSendingConstText.Text = "Second:";
            // 
            // numericUpDownSerialPeriodSendingTime
            // 
            this.numericUpDownSerialPeriodSendingTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSerialPeriodSendingTime.Location = new System.Drawing.Point(72, 11);
            this.numericUpDownSerialPeriodSendingTime.Name = "numericUpDownSerialPeriodSendingTime";
            this.numericUpDownSerialPeriodSendingTime.Size = new System.Drawing.Size(64, 20);
            this.numericUpDownSerialPeriodSendingTime.TabIndex = 0;
            this.numericUpDownSerialPeriodSendingTime.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // tabPageCalculator
            // 
            this.tabPageCalculator.Controls.Add(this.tableLayoutPanel1);
            this.tabPageCalculator.Location = new System.Drawing.Point(4, 40);
            this.tabPageCalculator.Name = "tabPageCalculator";
            this.tabPageCalculator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalculator.Size = new System.Drawing.Size(211, 348);
            this.tabPageCalculator.TabIndex = 4;
            this.tabPageCalculator.Text = "Calculator";
            this.tabPageCalculator.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.36123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.63876F));
            this.tableLayoutPanel1.Controls.Add(this.labelConstCalculatorDec, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelConstCalculatorBinary, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCalculatorDec, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCalculatorHex, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCalculatorBin, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelConstCalculatorHex, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(236, 88);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelConstCalculatorDec
            // 
            this.labelConstCalculatorDec.AutoSize = true;
            this.labelConstCalculatorDec.Location = new System.Drawing.Point(3, 0);
            this.labelConstCalculatorDec.Name = "labelConstCalculatorDec";
            this.labelConstCalculatorDec.Size = new System.Drawing.Size(45, 13);
            this.labelConstCalculatorDec.TabIndex = 0;
            this.labelConstCalculatorDec.Text = "Decimal";
            this.labelConstCalculatorDec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelConstCalculatorBinary
            // 
            this.labelConstCalculatorBinary.AutoSize = true;
            this.labelConstCalculatorBinary.Location = new System.Drawing.Point(3, 56);
            this.labelConstCalculatorBinary.Name = "labelConstCalculatorBinary";
            this.labelConstCalculatorBinary.Size = new System.Drawing.Size(36, 13);
            this.labelConstCalculatorBinary.TabIndex = 2;
            this.labelConstCalculatorBinary.Text = "Binary";
            // 
            // textBoxCalculatorDec
            // 
            this.textBoxCalculatorDec.Location = new System.Drawing.Point(84, 3);
            this.textBoxCalculatorDec.Name = "textBoxCalculatorDec";
            this.textBoxCalculatorDec.Size = new System.Drawing.Size(100, 20);
            this.textBoxCalculatorDec.TabIndex = 3;
            this.textBoxCalculatorDec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCalculatorDec_KeyPress);
            // 
            // textBoxCalculatorHex
            // 
            this.textBoxCalculatorHex.Location = new System.Drawing.Point(84, 31);
            this.textBoxCalculatorHex.Name = "textBoxCalculatorHex";
            this.textBoxCalculatorHex.Size = new System.Drawing.Size(100, 20);
            this.textBoxCalculatorHex.TabIndex = 4;
            this.textBoxCalculatorHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCalculatorHex_KeyPress);
            // 
            // textBoxCalculatorBin
            // 
            this.textBoxCalculatorBin.Location = new System.Drawing.Point(84, 59);
            this.textBoxCalculatorBin.Name = "textBoxCalculatorBin";
            this.textBoxCalculatorBin.Size = new System.Drawing.Size(100, 20);
            this.textBoxCalculatorBin.TabIndex = 5;
            this.textBoxCalculatorBin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCalculatorBin_KeyPress);
            // 
            // labelConstCalculatorHex
            // 
            this.labelConstCalculatorHex.AutoSize = true;
            this.labelConstCalculatorHex.Location = new System.Drawing.Point(3, 28);
            this.labelConstCalculatorHex.Name = "labelConstCalculatorHex";
            this.labelConstCalculatorHex.Size = new System.Drawing.Size(68, 13);
            this.labelConstCalculatorHex.TabIndex = 1;
            this.labelConstCalculatorHex.Text = "Hexadecimal";
            // 
            // richTextBoxSerialPortTexts
            // 
            this.richTextBoxSerialPortTexts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxSerialPortTexts.AutoWordSelection = true;
            this.richTextBoxSerialPortTexts.DetectUrls = false;
            this.richTextBoxSerialPortTexts.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.richTextBoxSerialPortTexts.Location = new System.Drawing.Point(3, 4);
            this.richTextBoxSerialPortTexts.Name = "richTextBoxSerialPortTexts";
            this.richTextBoxSerialPortTexts.ReadOnly = true;
            this.richTextBoxSerialPortTexts.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxSerialPortTexts.Size = new System.Drawing.Size(531, 406);
            this.richTextBoxSerialPortTexts.TabIndex = 37;
            this.richTextBoxSerialPortTexts.Text = "";
            this.richTextBoxSerialPortTexts.WordWrap = false;
            this.richTextBoxSerialPortTexts.SelectionChanged += new System.EventHandler(this.richTextBoxSerialPortTexts_SelectionChanged);
            // 
            // buttonSerialPortSend
            // 
            this.buttonSerialPortSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSerialPortSend.Location = new System.Drawing.Point(459, 416);
            this.buttonSerialPortSend.Name = "buttonSerialPortSend";
            this.buttonSerialPortSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSerialPortSend.TabIndex = 39;
            this.buttonSerialPortSend.Text = "Send";
            this.buttonSerialPortSend.UseVisualStyleBackColor = true;
            this.buttonSerialPortSend.Click += new System.EventHandler(this.buttonSerialPortSend_Click);
            // 
            // comboBoxSerialSendingText
            // 
            this.comboBoxSerialSendingText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSerialSendingText.FormattingEnabled = true;
            this.comboBoxSerialSendingText.Location = new System.Drawing.Point(3, 418);
            this.comboBoxSerialSendingText.Name = "comboBoxSerialSendingText";
            this.comboBoxSerialSendingText.Size = new System.Drawing.Size(450, 21);
            this.comboBoxSerialSendingText.TabIndex = 42;
            this.comboBoxSerialSendingText.Text = "<Sending message with \\r\\n>";
            this.comboBoxSerialSendingText.Enter += new System.EventHandler(this.comboBoxSerialSendMessage_Enter);
            this.comboBoxSerialSendingText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxSerialSendMessage_KeyPress);
            // 
            // pictureBoxSerialReceiving
            // 
            this.pictureBoxSerialReceiving.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSerialReceiving.Location = new System.Drawing.Point(543, 30);
            this.pictureBoxSerialReceiving.Name = "pictureBoxSerialReceiving";
            this.pictureBoxSerialReceiving.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxSerialReceiving.TabIndex = 43;
            this.pictureBoxSerialReceiving.TabStop = false;
            // 
            // timerReceiveIcon
            // 
            this.timerReceiveIcon.Tick += new System.EventHandler(this.timerReceiveIcon_Tick);
            // 
            // buttonSerialOpenLogFile
            // 
            this.buttonSerialOpenLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSerialOpenLogFile.Location = new System.Drawing.Point(575, 30);
            this.buttonSerialOpenLogFile.Name = "buttonSerialOpenLogFile";
            this.buttonSerialOpenLogFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSerialOpenLogFile.TabIndex = 44;
            this.buttonSerialOpenLogFile.Text = "Open log";
            this.buttonSerialOpenLogFile.UseVisualStyleBackColor = true;
            this.buttonSerialOpenLogFile.Click += new System.EventHandler(this.buttonSerialOpenLogFile_Click);
            // 
            // checkBoxWordWrap
            // 
            this.checkBoxWordWrap.AutoSize = true;
            this.checkBoxWordWrap.Location = new System.Drawing.Point(4, 296);
            this.checkBoxWordWrap.Name = "checkBoxWordWrap";
            this.checkBoxWordWrap.Size = new System.Drawing.Size(78, 17);
            this.checkBoxWordWrap.TabIndex = 44;
            this.checkBoxWordWrap.Text = "Word wrap";
            this.checkBoxWordWrap.UseVisualStyleBackColor = true;
            this.checkBoxWordWrap.CheckedChanged += new System.EventHandler(this.checkBoxWordWrap_CheckedChanged);
            // 
            // checkBoxPrintSend
            // 
            this.checkBoxPrintSend.AutoSize = true;
            this.checkBoxPrintSend.Location = new System.Drawing.Point(4, 319);
            this.checkBoxPrintSend.Name = "checkBoxPrintSend";
            this.checkBoxPrintSend.Size = new System.Drawing.Size(103, 17);
            this.checkBoxPrintSend.TabIndex = 45;
            this.checkBoxPrintSend.Text = "Print send event";
            this.checkBoxPrintSend.UseVisualStyleBackColor = true;
            this.checkBoxPrintSend.CheckedChanged += new System.EventHandler(this.checkBoxPrintSend_CheckedChanged);
            // 
            // FormFastenTerminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 447);
            this.Controls.Add(this.buttonSerialOpenLogFile);
            this.Controls.Add(this.pictureBoxSerialReceiving);
            this.Controls.Add(this.comboBoxSerialSendingText);
            this.Controls.Add(this.tabControlSerialFunctions);
            this.Controls.Add(this.richTextBoxSerialPortTexts);
            this.Controls.Add(this.buttonSerialPortSend);
            this.Controls.Add(this.buttonClearSerialTexts);
            this.Controls.Add(this.labelConstTextSearching);
            this.Controls.Add(this.textBoxSerialTextFind);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 485);
            this.Name = "FormFastenTerminal";
            this.Text = "FastenTerminal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FastenTerminal_FormClosing);
            this.Load += new System.EventHandler(this.FormFastenTerminalMain_Load);
            this.tabControlSerialFunctions.ResumeLayout(false);
            this.tabPageSerialCommunicationSettings.ResumeLayout(false);
            this.tabPageSerialCommunicationSettings.PerformLayout();
            this.tabPageSerialCommands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavCommands)).EndInit();
            this.tabPageSerialPeriodSending.ResumeLayout(false);
            this.tabPageSerialPeriodSending.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSerialPeriodSendingTime)).EndInit();
            this.tabPageCalculator.ResumeLayout(false);
            this.tabPageCalculator.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSerialReceiving)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private System.IO.Ports.SerialPort serialPortDevice;
		public System.Windows.Forms.NotifyIcon notifyIconApplication;
		private System.Windows.Forms.Button buttonClearSerialTexts;
		private System.Windows.Forms.Label labelConstTextSearching;
		private System.Windows.Forms.TextBox textBoxSerialTextFind;
		private System.Windows.Forms.TabControl tabControlSerialFunctions;
		private System.Windows.Forms.TabPage tabPageSerialCommands;
		private System.Windows.Forms.Button buttonSerialFavouriteCommandSending;
		private System.Windows.Forms.TabPage tabPageSerialPeriodSending;
		private System.Windows.Forms.TabPage tabPageSerialCommunicationSettings;
		private System.Windows.Forms.CheckBox checkBoxSerialHex;
		private System.Windows.Forms.ComboBox comboBoxSerialPortCOM;
		private System.Windows.Forms.Button buttonSerialPortOpen;
		private System.Windows.Forms.CheckBox checkBoxSerialPortLog;
		private System.Windows.Forms.ComboBox comboBoxSerialPortBaudrate;
		private System.Windows.Forms.Button buttonSerialPortRefresh;
		private System.Windows.Forms.CheckBox checkBoxSerialTextColouring;
		private System.Windows.Forms.CheckBox checkBoxSerialLogScrollBottom;
		private System.Windows.Forms.CheckBox checkBoxSerialCopySelected;
		private System.Windows.Forms.TabPage tabPageCalculator;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelConstCalculatorDec;
		private System.Windows.Forms.Label labelConstCalculatorBinary;
		private System.Windows.Forms.TextBox textBoxCalculatorDec;
		private System.Windows.Forms.TextBox textBoxCalculatorHex;
		private System.Windows.Forms.TextBox textBoxCalculatorBin;
		private System.Windows.Forms.Label labelConstCalculatorHex;
		private System.Windows.Forms.RichTextBox richTextBoxSerialPortTexts;
		private System.Windows.Forms.Button buttonSerialPortSend;
		private System.Windows.Forms.Button buttonSerialPeriodSendingStart;
		private System.Windows.Forms.Label labelSerialPeriodSendingConstText;
		private System.Windows.Forms.NumericUpDown numericUpDownSerialPeriodSendingTime;
		private System.Windows.Forms.TextBox textBoxPeriodSendingMessage;
		private System.Windows.Forms.Label labelSerialPeriodSendingConstTextMessage;
		private System.Windows.Forms.CheckBox checkBoxLogWithDateTime;
		private System.Windows.Forms.CheckBox checkBoxSerialAppendPerRPerN;
		private System.Windows.Forms.ComboBox comboBoxSerialSendingText;
		private System.Windows.Forms.CheckBox checkBoxSerialConfigClearSendMessageTextAfterSend;
		private System.Windows.Forms.DataGridView dataGridViewFavCommands;
		private System.Windows.Forms.Button buttonSerialFavouriteCommandsSave;
		private System.Windows.Forms.Button buttonSerialFavouriteCommandsAdd;
		private System.Windows.Forms.PictureBox pictureBoxSerialReceiving;
		private System.Windows.Forms.Timer timerReceiveIcon;
		private System.Windows.Forms.CheckBox checkBoxSerialReceiveBinaryMode;
		private System.Windows.Forms.Button buttonSerialOpenLogFile;
		private System.Windows.Forms.Button buttonSerialSaveConfig;
        private System.Windows.Forms.CheckBox checkBoxMute;
        private System.Windows.Forms.CheckBox checkBoxWordWrap;
        private System.Windows.Forms.CheckBox checkBoxPrintSend;
    }
}

