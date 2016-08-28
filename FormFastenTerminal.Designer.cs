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
			this.comboBoxSerialHeaderType = new System.Windows.Forms.ComboBox();
			this.tabControlSerialFunctions = new System.Windows.Forms.TabControl();
			this.tabPageSerialCommunicationSettings = new System.Windows.Forms.TabPage();
			this.checkBoxSerialAppendPerRPerN = new System.Windows.Forms.CheckBox();
			this.checkBoxLogWithDateTime = new System.Windows.Forms.CheckBox();
			this.checkBoxSerialHex = new System.Windows.Forms.CheckBox();
			this.comboBoxSerialPortCOM = new System.Windows.Forms.ComboBox();
			this.buttonSerialPortOpen = new System.Windows.Forms.Button();
			this.checkBoxSerialPortLog = new System.Windows.Forms.CheckBox();
			this.comboBoxSerialPortBaudrate = new System.Windows.Forms.ComboBox();
			this.buttonSerialPortRefresh = new System.Windows.Forms.Button();
			this.checkBoxSerialTextColouring = new System.Windows.Forms.CheckBox();
			this.checkBoxSerialPortScrollBottom = new System.Windows.Forms.CheckBox();
			this.checkBoxSerialCopySelected = new System.Windows.Forms.CheckBox();
			this.tabPageSerialCommands = new System.Windows.Forms.TabPage();
			this.buttonCommand5 = new System.Windows.Forms.Button();
			this.buttonCommand4 = new System.Windows.Forms.Button();
			this.buttonCommand3 = new System.Windows.Forms.Button();
			this.labelFavouriteCommands = new System.Windows.Forms.Label();
			this.comboBoxSerialPortLastCommands = new System.Windows.Forms.ComboBox();
			this.labelLastCommands = new System.Windows.Forms.Label();
			this.buttonCommand1 = new System.Windows.Forms.Button();
			this.buttonCommand2 = new System.Windows.Forms.Button();
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
			this.tabPageSerialCommandSettings = new System.Windows.Forms.TabPage();
			this.labelConstSettingsFavCommandsText = new System.Windows.Forms.Label();
			this.dataGridViewSettingsFavCommands = new System.Windows.Forms.DataGridView();
			this.textBoxSerialSendMessage = new System.Windows.Forms.TextBox();
			this.richTextBoxSerialPortTexts = new System.Windows.Forms.RichTextBox();
			this.checkBoxSerialHeaderSending = new System.Windows.Forms.CheckBox();
			this.buttonSerialPortSend = new System.Windows.Forms.Button();
			this.tabControlSerialFunctions.SuspendLayout();
			this.tabPageSerialCommunicationSettings.SuspendLayout();
			this.tabPageSerialCommands.SuspendLayout();
			this.tabPageSerialPeriodSending.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSerialPeriodSendingTime)).BeginInit();
			this.tabPageCalculator.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabPageSerialCommandSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSettingsFavCommands)).BeginInit();
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
			this.buttonClearSerialTexts.Text = "Képernyő törlés";
			this.buttonClearSerialTexts.UseVisualStyleBackColor = true;
			this.buttonClearSerialTexts.Click += new System.EventHandler(this.buttonClearSerialTexts_Click);
			// 
			// labelConstTextSearching
			// 
			this.labelConstTextSearching.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelConstTextSearching.AutoSize = true;
			this.labelConstTextSearching.Location = new System.Drawing.Point(540, 7);
			this.labelConstTextSearching.Name = "labelConstTextSearching";
			this.labelConstTextSearching.Size = new System.Drawing.Size(48, 13);
			this.labelConstTextSearching.TabIndex = 33;
			this.labelConstTextSearching.Text = "Keresés:";
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
			// comboBoxSerialHeaderType
			// 
			this.comboBoxSerialHeaderType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.comboBoxSerialHeaderType.FormattingEnabled = true;
			this.comboBoxSerialHeaderType.Location = new System.Drawing.Point(3, 418);
			this.comboBoxSerialHeaderType.Name = "comboBoxSerialHeaderType";
			this.comboBoxSerialHeaderType.Size = new System.Drawing.Size(79, 21);
			this.comboBoxSerialHeaderType.TabIndex = 42;
			// 
			// tabControlSerialFunctions
			// 
			this.tabControlSerialFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlSerialFunctions.Controls.Add(this.tabPageSerialCommunicationSettings);
			this.tabControlSerialFunctions.Controls.Add(this.tabPageSerialCommands);
			this.tabControlSerialFunctions.Controls.Add(this.tabPageSerialPeriodSending);
			this.tabControlSerialFunctions.Controls.Add(this.tabPageCalculator);
			this.tabControlSerialFunctions.Controls.Add(this.tabPageSerialCommandSettings);
			this.tabControlSerialFunctions.Location = new System.Drawing.Point(540, 59);
			this.tabControlSerialFunctions.Multiline = true;
			this.tabControlSerialFunctions.Name = "tabControlSerialFunctions";
			this.tabControlSerialFunctions.SelectedIndex = 0;
			this.tabControlSerialFunctions.Size = new System.Drawing.Size(206, 380);
			this.tabControlSerialFunctions.TabIndex = 41;
			// 
			// tabPageSerialCommunicationSettings
			// 
			this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxSerialAppendPerRPerN);
			this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxLogWithDateTime);
			this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxSerialHex);
			this.tabPageSerialCommunicationSettings.Controls.Add(this.comboBoxSerialPortCOM);
			this.tabPageSerialCommunicationSettings.Controls.Add(this.buttonSerialPortOpen);
			this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxSerialPortLog);
			this.tabPageSerialCommunicationSettings.Controls.Add(this.comboBoxSerialPortBaudrate);
			this.tabPageSerialCommunicationSettings.Controls.Add(this.buttonSerialPortRefresh);
			this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxSerialTextColouring);
			this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxSerialPortScrollBottom);
			this.tabPageSerialCommunicationSettings.Controls.Add(this.checkBoxSerialCopySelected);
			this.tabPageSerialCommunicationSettings.Location = new System.Drawing.Point(4, 58);
			this.tabPageSerialCommunicationSettings.Name = "tabPageSerialCommunicationSettings";
			this.tabPageSerialCommunicationSettings.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSerialCommunicationSettings.Size = new System.Drawing.Size(198, 318);
			this.tabPageSerialCommunicationSettings.TabIndex = 3;
			this.tabPageSerialCommunicationSettings.Text = "Konfiguráció";
			this.tabPageSerialCommunicationSettings.UseVisualStyleBackColor = true;
			// 
			// checkBoxSerialAppendPerRPerN
			// 
			this.checkBoxSerialAppendPerRPerN.AutoSize = true;
			this.checkBoxSerialAppendPerRPerN.Checked = true;
			this.checkBoxSerialAppendPerRPerN.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSerialAppendPerRPerN.Location = new System.Drawing.Point(6, 201);
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
			this.checkBoxLogWithDateTime.Location = new System.Drawing.Point(6, 85);
			this.checkBoxLogWithDateTime.Name = "checkBoxLogWithDateTime";
			this.checkBoxLogWithDateTime.Size = new System.Drawing.Size(111, 17);
			this.checkBoxLogWithDateTime.TabIndex = 38;
			this.checkBoxLogWithDateTime.Text = "Logolás dátummal";
			this.checkBoxLogWithDateTime.UseVisualStyleBackColor = true;
			this.checkBoxLogWithDateTime.CheckedChanged += new System.EventHandler(this.checkBoxLogWithDateTime_CheckedChanged);
			// 
			// checkBoxSerialHex
			// 
			this.checkBoxSerialHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxSerialHex.AutoSize = true;
			this.checkBoxSerialHex.Location = new System.Drawing.Point(6, 177);
			this.checkBoxSerialHex.Name = "checkBoxSerialHex";
			this.checkBoxSerialHex.Size = new System.Drawing.Size(45, 17);
			this.checkBoxSerialHex.TabIndex = 37;
			this.checkBoxSerialHex.Text = "Hex";
			this.checkBoxSerialHex.UseVisualStyleBackColor = true;
			this.checkBoxSerialHex.CheckStateChanged += new System.EventHandler(this.checkBoxSerialHex_CheckStateChanged);
			// 
			// comboBoxSerialPortCOM
			// 
			this.comboBoxSerialPortCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
			this.buttonSerialPortOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSerialPortOpen.Location = new System.Drawing.Point(102, 35);
			this.buttonSerialPortOpen.Name = "buttonSerialPortOpen";
			this.buttonSerialPortOpen.Size = new System.Drawing.Size(90, 23);
			this.buttonSerialPortOpen.TabIndex = 1;
			this.buttonSerialPortOpen.Text = "Port nyitás";
			this.buttonSerialPortOpen.UseVisualStyleBackColor = true;
			this.buttonSerialPortOpen.Click += new System.EventHandler(this.buttonSerialPortOpen_Click);
			// 
			// checkBoxSerialPortLog
			// 
			this.checkBoxSerialPortLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxSerialPortLog.AutoSize = true;
			this.checkBoxSerialPortLog.Checked = true;
			this.checkBoxSerialPortLog.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSerialPortLog.Location = new System.Drawing.Point(6, 62);
			this.checkBoxSerialPortLog.Name = "checkBoxSerialPortLog";
			this.checkBoxSerialPortLog.Size = new System.Drawing.Size(91, 17);
			this.checkBoxSerialPortLog.TabIndex = 2;
			this.checkBoxSerialPortLog.Text = "Logolás fájlba";
			this.checkBoxSerialPortLog.UseVisualStyleBackColor = true;
			this.checkBoxSerialPortLog.CheckedChanged += new System.EventHandler(this.checkBoxSerialPortLog_CheckedChanged);
			// 
			// comboBoxSerialPortBaudrate
			// 
			this.comboBoxSerialPortBaudrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxSerialPortBaudrate.FormattingEnabled = true;
			this.comboBoxSerialPortBaudrate.Items.AddRange(new object[] {
            "115200",
            "9600"});
			this.comboBoxSerialPortBaudrate.Location = new System.Drawing.Point(6, 35);
			this.comboBoxSerialPortBaudrate.Name = "comboBoxSerialPortBaudrate";
			this.comboBoxSerialPortBaudrate.Size = new System.Drawing.Size(82, 21);
			this.comboBoxSerialPortBaudrate.TabIndex = 4;
			this.comboBoxSerialPortBaudrate.Text = "<baudrate>";
			this.comboBoxSerialPortBaudrate.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPortBaudrate_SelectedIndexChanged);
			// 
			// buttonSerialPortRefresh
			// 
			this.buttonSerialPortRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSerialPortRefresh.Location = new System.Drawing.Point(102, 6);
			this.buttonSerialPortRefresh.Name = "buttonSerialPortRefresh";
			this.buttonSerialPortRefresh.Size = new System.Drawing.Size(90, 23);
			this.buttonSerialPortRefresh.TabIndex = 8;
			this.buttonSerialPortRefresh.Text = "Port Frissítés";
			this.buttonSerialPortRefresh.UseVisualStyleBackColor = true;
			this.buttonSerialPortRefresh.Click += new System.EventHandler(this.buttonSerialPortRefresh_Click);
			// 
			// checkBoxSerialTextColouring
			// 
			this.checkBoxSerialTextColouring.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxSerialTextColouring.AutoSize = true;
			this.checkBoxSerialTextColouring.Location = new System.Drawing.Point(6, 154);
			this.checkBoxSerialTextColouring.Name = "checkBoxSerialTextColouring";
			this.checkBoxSerialTextColouring.Size = new System.Drawing.Size(107, 17);
			this.checkBoxSerialTextColouring.TabIndex = 31;
			this.checkBoxSerialTextColouring.Text = "Szöveg színezés";
			this.checkBoxSerialTextColouring.UseVisualStyleBackColor = true;
			// 
			// checkBoxSerialPortScrollBottom
			// 
			this.checkBoxSerialPortScrollBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxSerialPortScrollBottom.AutoSize = true;
			this.checkBoxSerialPortScrollBottom.Checked = true;
			this.checkBoxSerialPortScrollBottom.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSerialPortScrollBottom.Location = new System.Drawing.Point(6, 108);
			this.checkBoxSerialPortScrollBottom.Name = "checkBoxSerialPortScrollBottom";
			this.checkBoxSerialPortScrollBottom.Size = new System.Drawing.Size(78, 17);
			this.checkBoxSerialPortScrollBottom.TabIndex = 12;
			this.checkBoxSerialPortScrollBottom.Text = "Legördülés";
			this.checkBoxSerialPortScrollBottom.UseVisualStyleBackColor = true;
			// 
			// checkBoxSerialCopySelected
			// 
			this.checkBoxSerialCopySelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxSerialCopySelected.AutoSize = true;
			this.checkBoxSerialCopySelected.Checked = true;
			this.checkBoxSerialCopySelected.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSerialCopySelected.Location = new System.Drawing.Point(6, 131);
			this.checkBoxSerialCopySelected.Name = "checkBoxSerialCopySelected";
			this.checkBoxSerialCopySelected.Size = new System.Drawing.Size(109, 17);
			this.checkBoxSerialCopySelected.TabIndex = 13;
			this.checkBoxSerialCopySelected.Text = "Szöveg másolása";
			this.checkBoxSerialCopySelected.UseVisualStyleBackColor = true;
			// 
			// tabPageSerialCommands
			// 
			this.tabPageSerialCommands.Controls.Add(this.buttonCommand5);
			this.tabPageSerialCommands.Controls.Add(this.buttonCommand4);
			this.tabPageSerialCommands.Controls.Add(this.buttonCommand3);
			this.tabPageSerialCommands.Controls.Add(this.labelFavouriteCommands);
			this.tabPageSerialCommands.Controls.Add(this.comboBoxSerialPortLastCommands);
			this.tabPageSerialCommands.Controls.Add(this.labelLastCommands);
			this.tabPageSerialCommands.Controls.Add(this.buttonCommand1);
			this.tabPageSerialCommands.Controls.Add(this.buttonCommand2);
			this.tabPageSerialCommands.Location = new System.Drawing.Point(4, 58);
			this.tabPageSerialCommands.Name = "tabPageSerialCommands";
			this.tabPageSerialCommands.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSerialCommands.Size = new System.Drawing.Size(198, 318);
			this.tabPageSerialCommands.TabIndex = 0;
			this.tabPageSerialCommands.Text = "Parancs";
			this.tabPageSerialCommands.UseVisualStyleBackColor = true;
			// 
			// buttonCommand5
			// 
			this.buttonCommand5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCommand5.Location = new System.Drawing.Point(6, 135);
			this.buttonCommand5.Name = "buttonCommand5";
			this.buttonCommand5.Size = new System.Drawing.Size(103, 23);
			this.buttonCommand5.TabIndex = 18;
			this.buttonCommand5.Text = "Command5";
			this.buttonCommand5.UseVisualStyleBackColor = true;
			this.buttonCommand5.Click += new System.EventHandler(this.buttonCommand5_Click);
			// 
			// buttonCommand4
			// 
			this.buttonCommand4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCommand4.Location = new System.Drawing.Point(6, 106);
			this.buttonCommand4.Name = "buttonCommand4";
			this.buttonCommand4.Size = new System.Drawing.Size(103, 23);
			this.buttonCommand4.TabIndex = 17;
			this.buttonCommand4.Text = "Command4";
			this.buttonCommand4.UseVisualStyleBackColor = true;
			this.buttonCommand4.Click += new System.EventHandler(this.buttonCommand4_Click);
			// 
			// buttonCommand3
			// 
			this.buttonCommand3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCommand3.Location = new System.Drawing.Point(6, 77);
			this.buttonCommand3.Name = "buttonCommand3";
			this.buttonCommand3.Size = new System.Drawing.Size(103, 23);
			this.buttonCommand3.TabIndex = 16;
			this.buttonCommand3.Text = "Command3";
			this.buttonCommand3.UseVisualStyleBackColor = true;
			this.buttonCommand3.Click += new System.EventHandler(this.buttonCommand3_Click);
			// 
			// labelFavouriteCommands
			// 
			this.labelFavouriteCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelFavouriteCommands.AutoSize = true;
			this.labelFavouriteCommands.Location = new System.Drawing.Point(3, 3);
			this.labelFavouriteCommands.Name = "labelFavouriteCommands";
			this.labelFavouriteCommands.Size = new System.Drawing.Size(106, 13);
			this.labelFavouriteCommands.TabIndex = 10;
			this.labelFavouriteCommands.Text = "Kedvenc parancsok:";
			// 
			// comboBoxSerialPortLastCommands
			// 
			this.comboBoxSerialPortLastCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxSerialPortLastCommands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSerialPortLastCommands.FormattingEnabled = true;
			this.comboBoxSerialPortLastCommands.Location = new System.Drawing.Point(6, 183);
			this.comboBoxSerialPortLastCommands.Name = "comboBoxSerialPortLastCommands";
			this.comboBoxSerialPortLastCommands.Size = new System.Drawing.Size(103, 21);
			this.comboBoxSerialPortLastCommands.TabIndex = 7;
			this.comboBoxSerialPortLastCommands.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPortLastCommands_SelectedIndexChanged);
			// 
			// labelLastCommands
			// 
			this.labelLastCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelLastCommands.AutoSize = true;
			this.labelLastCommands.Location = new System.Drawing.Point(3, 167);
			this.labelLastCommands.Name = "labelLastCommands";
			this.labelLastCommands.Size = new System.Drawing.Size(134, 13);
			this.labelLastCommands.TabIndex = 9;
			this.labelLastCommands.Text = "Utoljára kiadott parancsok:";
			// 
			// buttonCommand1
			// 
			this.buttonCommand1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCommand1.Location = new System.Drawing.Point(6, 19);
			this.buttonCommand1.Name = "buttonCommand1";
			this.buttonCommand1.Size = new System.Drawing.Size(103, 23);
			this.buttonCommand1.TabIndex = 14;
			this.buttonCommand1.Text = "Command1";
			this.buttonCommand1.UseVisualStyleBackColor = true;
			this.buttonCommand1.Click += new System.EventHandler(this.buttonCommand1_Click);
			// 
			// buttonCommand2
			// 
			this.buttonCommand2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCommand2.Location = new System.Drawing.Point(6, 48);
			this.buttonCommand2.Name = "buttonCommand2";
			this.buttonCommand2.Size = new System.Drawing.Size(103, 23);
			this.buttonCommand2.TabIndex = 15;
			this.buttonCommand2.Text = "Command2";
			this.buttonCommand2.UseVisualStyleBackColor = true;
			this.buttonCommand2.Click += new System.EventHandler(this.buttonCommand2_Click);
			// 
			// tabPageSerialPeriodSending
			// 
			this.tabPageSerialPeriodSending.Controls.Add(this.labelSerialPeriodSendingConstTextMessage);
			this.tabPageSerialPeriodSending.Controls.Add(this.textBoxPeriodSendingMessage);
			this.tabPageSerialPeriodSending.Controls.Add(this.buttonSerialPeriodSendingStart);
			this.tabPageSerialPeriodSending.Controls.Add(this.labelSerialPeriodSendingConstText);
			this.tabPageSerialPeriodSending.Controls.Add(this.numericUpDownSerialPeriodSendingTime);
			this.tabPageSerialPeriodSending.Location = new System.Drawing.Point(4, 58);
			this.tabPageSerialPeriodSending.Name = "tabPageSerialPeriodSending";
			this.tabPageSerialPeriodSending.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSerialPeriodSending.Size = new System.Drawing.Size(198, 318);
			this.tabPageSerialPeriodSending.TabIndex = 2;
			this.tabPageSerialPeriodSending.Text = "Periodikus küldés";
			this.tabPageSerialPeriodSending.UseVisualStyleBackColor = true;
			// 
			// labelSerialPeriodSendingConstTextMessage
			// 
			this.labelSerialPeriodSendingConstTextMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelSerialPeriodSendingConstTextMessage.AutoSize = true;
			this.labelSerialPeriodSendingConstTextMessage.Location = new System.Drawing.Point(4, 47);
			this.labelSerialPeriodSendingConstTextMessage.Name = "labelSerialPeriodSendingConstTextMessage";
			this.labelSerialPeriodSendingConstTextMessage.Size = new System.Drawing.Size(98, 13);
			this.labelSerialPeriodSendingConstTextMessage.TabIndex = 4;
			this.labelSerialPeriodSendingConstTextMessage.Text = "Kiküldendő üzenet:";
			// 
			// textBoxPeriodSendingMessage
			// 
			this.textBoxPeriodSendingMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxPeriodSendingMessage.Location = new System.Drawing.Point(6, 63);
			this.textBoxPeriodSendingMessage.Name = "textBoxPeriodSendingMessage";
			this.textBoxPeriodSendingMessage.Size = new System.Drawing.Size(186, 20);
			this.textBoxPeriodSendingMessage.TabIndex = 3;
			this.textBoxPeriodSendingMessage.Text = "<Periodikusan kiküldendő üzenet>";
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
			this.labelSerialPeriodSendingConstText.Size = new System.Drawing.Size(63, 13);
			this.labelSerialPeriodSendingConstText.TabIndex = 1;
			this.labelSerialPeriodSendingConstText.Text = "Másodperc:";
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
			this.tabPageCalculator.Location = new System.Drawing.Point(4, 58);
			this.tabPageCalculator.Name = "tabPageCalculator";
			this.tabPageCalculator.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCalculator.Size = new System.Drawing.Size(198, 318);
			this.tabPageCalculator.TabIndex = 4;
			this.tabPageCalculator.Text = "Számológép";
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
			this.labelConstCalculatorDec.Size = new System.Drawing.Size(52, 13);
			this.labelConstCalculatorDec.TabIndex = 0;
			this.labelConstCalculatorDec.Text = "Decimális";
			this.labelConstCalculatorDec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labelConstCalculatorBinary
			// 
			this.labelConstCalculatorBinary.AutoSize = true;
			this.labelConstCalculatorBinary.Location = new System.Drawing.Point(3, 56);
			this.labelConstCalculatorBinary.Name = "labelConstCalculatorBinary";
			this.labelConstCalculatorBinary.Size = new System.Drawing.Size(38, 13);
			this.labelConstCalculatorBinary.TabIndex = 2;
			this.labelConstCalculatorBinary.Text = "Bináris";
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
			this.labelConstCalculatorHex.Size = new System.Drawing.Size(75, 13);
			this.labelConstCalculatorHex.TabIndex = 1;
			this.labelConstCalculatorHex.Text = "Hexadecimális";
			// 
			// tabPageSerialCommandSettings
			// 
			this.tabPageSerialCommandSettings.Controls.Add(this.labelConstSettingsFavCommandsText);
			this.tabPageSerialCommandSettings.Controls.Add(this.dataGridViewSettingsFavCommands);
			this.tabPageSerialCommandSettings.Location = new System.Drawing.Point(4, 58);
			this.tabPageSerialCommandSettings.Name = "tabPageSerialCommandSettings";
			this.tabPageSerialCommandSettings.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSerialCommandSettings.Size = new System.Drawing.Size(198, 318);
			this.tabPageSerialCommandSettings.TabIndex = 5;
			this.tabPageSerialCommandSettings.Text = "Parancsok szerkesztése";
			this.tabPageSerialCommandSettings.UseVisualStyleBackColor = true;
			// 
			// labelConstSettingsFavCommandsText
			// 
			this.labelConstSettingsFavCommandsText.AutoSize = true;
			this.labelConstSettingsFavCommandsText.Location = new System.Drawing.Point(8, 7);
			this.labelConstSettingsFavCommandsText.Name = "labelConstSettingsFavCommandsText";
			this.labelConstSettingsFavCommandsText.Size = new System.Drawing.Size(106, 13);
			this.labelConstSettingsFavCommandsText.TabIndex = 22;
			this.labelConstSettingsFavCommandsText.Text = "Kedvenc parancsok:";
			// 
			// dataGridViewSettingsFavCommands
			// 
			this.dataGridViewSettingsFavCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridViewSettingsFavCommands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSettingsFavCommands.Location = new System.Drawing.Point(3, 23);
			this.dataGridViewSettingsFavCommands.Name = "dataGridViewSettingsFavCommands";
			this.dataGridViewSettingsFavCommands.Size = new System.Drawing.Size(192, 292);
			this.dataGridViewSettingsFavCommands.TabIndex = 21;
			// 
			// textBoxSerialSendMessage
			// 
			this.textBoxSerialSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSerialSendMessage.Location = new System.Drawing.Point(109, 418);
			this.textBoxSerialSendMessage.MaxLength = 256;
			this.textBoxSerialSendMessage.Name = "textBoxSerialSendMessage";
			this.textBoxSerialSendMessage.Size = new System.Drawing.Size(344, 20);
			this.textBoxSerialSendMessage.TabIndex = 38;
			this.textBoxSerialSendMessage.Text = "<Sending message with \\r\\n>";
			this.textBoxSerialSendMessage.Enter += new System.EventHandler(this.textBoxSerialSendMessage_Enter);
			this.textBoxSerialSendMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSerialSendMessage_KeyPress);
			// 
			// richTextBoxSerialPortTexts
			// 
			this.richTextBoxSerialPortTexts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxSerialPortTexts.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.richTextBoxSerialPortTexts.Location = new System.Drawing.Point(3, 4);
			this.richTextBoxSerialPortTexts.Name = "richTextBoxSerialPortTexts";
			this.richTextBoxSerialPortTexts.ReadOnly = true;
			this.richTextBoxSerialPortTexts.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.richTextBoxSerialPortTexts.Size = new System.Drawing.Size(531, 406);
			this.richTextBoxSerialPortTexts.TabIndex = 37;
			this.richTextBoxSerialPortTexts.Text = "";
			this.richTextBoxSerialPortTexts.SelectionChanged += new System.EventHandler(this.richTextBoxSerialPortTexts_SelectionChanged);
			this.richTextBoxSerialPortTexts.TextChanged += new System.EventHandler(this.richTextBoxSerialPortTexts_TextChanged);
			// 
			// checkBoxSerialHeaderSending
			// 
			this.checkBoxSerialHeaderSending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxSerialHeaderSending.AutoSize = true;
			this.checkBoxSerialHeaderSending.Location = new System.Drawing.Point(88, 421);
			this.checkBoxSerialHeaderSending.Name = "checkBoxSerialHeaderSending";
			this.checkBoxSerialHeaderSending.Size = new System.Drawing.Size(15, 14);
			this.checkBoxSerialHeaderSending.TabIndex = 40;
			this.checkBoxSerialHeaderSending.UseVisualStyleBackColor = true;
			// 
			// buttonSerialPortSend
			// 
			this.buttonSerialPortSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSerialPortSend.Location = new System.Drawing.Point(459, 416);
			this.buttonSerialPortSend.Name = "buttonSerialPortSend";
			this.buttonSerialPortSend.Size = new System.Drawing.Size(75, 23);
			this.buttonSerialPortSend.TabIndex = 39;
			this.buttonSerialPortSend.Text = "Küldés";
			this.buttonSerialPortSend.UseVisualStyleBackColor = true;
			this.buttonSerialPortSend.Click += new System.EventHandler(this.buttonSerialPortSend_Click);
			// 
			// FormFastenTerminal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 447);
			this.Controls.Add(this.comboBoxSerialHeaderType);
			this.Controls.Add(this.tabControlSerialFunctions);
			this.Controls.Add(this.textBoxSerialSendMessage);
			this.Controls.Add(this.richTextBoxSerialPortTexts);
			this.Controls.Add(this.checkBoxSerialHeaderSending);
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
			this.tabPageSerialCommands.PerformLayout();
			this.tabPageSerialPeriodSending.ResumeLayout(false);
			this.tabPageSerialPeriodSending.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownSerialPeriodSendingTime)).EndInit();
			this.tabPageCalculator.ResumeLayout(false);
			this.tabPageCalculator.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tabPageSerialCommandSettings.ResumeLayout(false);
			this.tabPageSerialCommandSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSettingsFavCommands)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.IO.Ports.SerialPort serialPortDevice;
		public System.Windows.Forms.NotifyIcon notifyIconApplication;
		private System.Windows.Forms.Button buttonClearSerialTexts;
		private System.Windows.Forms.Label labelConstTextSearching;
		private System.Windows.Forms.TextBox textBoxSerialTextFind;
		private System.Windows.Forms.ComboBox comboBoxSerialHeaderType;
		private System.Windows.Forms.TabControl tabControlSerialFunctions;
		private System.Windows.Forms.TabPage tabPageSerialCommands;
		private System.Windows.Forms.Button buttonCommand5;
		private System.Windows.Forms.Button buttonCommand4;
		private System.Windows.Forms.Button buttonCommand3;
		private System.Windows.Forms.Label labelFavouriteCommands;
		private System.Windows.Forms.ComboBox comboBoxSerialPortLastCommands;
		private System.Windows.Forms.Label labelLastCommands;
		private System.Windows.Forms.Button buttonCommand1;
		private System.Windows.Forms.Button buttonCommand2;
		private System.Windows.Forms.TabPage tabPageSerialPeriodSending;
		private System.Windows.Forms.TabPage tabPageSerialCommunicationSettings;
		private System.Windows.Forms.CheckBox checkBoxSerialHex;
		private System.Windows.Forms.ComboBox comboBoxSerialPortCOM;
		private System.Windows.Forms.Button buttonSerialPortOpen;
		private System.Windows.Forms.CheckBox checkBoxSerialPortLog;
		private System.Windows.Forms.ComboBox comboBoxSerialPortBaudrate;
		private System.Windows.Forms.Button buttonSerialPortRefresh;
		private System.Windows.Forms.CheckBox checkBoxSerialTextColouring;
		private System.Windows.Forms.CheckBox checkBoxSerialPortScrollBottom;
		private System.Windows.Forms.CheckBox checkBoxSerialCopySelected;
		private System.Windows.Forms.TabPage tabPageCalculator;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelConstCalculatorDec;
		private System.Windows.Forms.Label labelConstCalculatorBinary;
		private System.Windows.Forms.TextBox textBoxCalculatorDec;
		private System.Windows.Forms.TextBox textBoxCalculatorHex;
		private System.Windows.Forms.TextBox textBoxCalculatorBin;
		private System.Windows.Forms.Label labelConstCalculatorHex;
		private System.Windows.Forms.TabPage tabPageSerialCommandSettings;
		private System.Windows.Forms.Label labelConstSettingsFavCommandsText;
		private System.Windows.Forms.DataGridView dataGridViewSettingsFavCommands;
		private System.Windows.Forms.TextBox textBoxSerialSendMessage;
		private System.Windows.Forms.RichTextBox richTextBoxSerialPortTexts;
		private System.Windows.Forms.CheckBox checkBoxSerialHeaderSending;
		private System.Windows.Forms.Button buttonSerialPortSend;
		private System.Windows.Forms.Button buttonSerialPeriodSendingStart;
		private System.Windows.Forms.Label labelSerialPeriodSendingConstText;
		private System.Windows.Forms.NumericUpDown numericUpDownSerialPeriodSendingTime;
		private System.Windows.Forms.TextBox textBoxPeriodSendingMessage;
		private System.Windows.Forms.Label labelSerialPeriodSendingConstTextMessage;
		private System.Windows.Forms.CheckBox checkBoxLogWithDateTime;
		private System.Windows.Forms.CheckBox checkBoxSerialAppendPerRPerN;
    }
}

