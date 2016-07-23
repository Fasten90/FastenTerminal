namespace FastenTerminal
{
    partial class FastenTerminal
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.v2ProgramFájlBeállításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.készítetteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.segítségToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.serialPortDevice = new System.IO.Ports.SerialPort(this.components);
			this.timerFwUpdateActualSec = new System.Windows.Forms.Timer(this.components);
			this.notifyIconApplication = new System.Windows.Forms.NotifyIcon(this.components);
			this.tabPageCalculator = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labelConstCalculatorDec = new System.Windows.Forms.Label();
			this.labelConstCalculatorBinary = new System.Windows.Forms.Label();
			this.textBoxCalculatorDec = new System.Windows.Forms.TextBox();
			this.textBoxCalculatorHex = new System.Windows.Forms.TextBox();
			this.textBoxCalculatorBin = new System.Windows.Forms.TextBox();
			this.labelConstCalculatorHex = new System.Windows.Forms.Label();
			this.tabSerialPort = new System.Windows.Forms.TabPage();
			this.checkBoxSerialHex = new System.Windows.Forms.CheckBox();
			this.buttonClearSerialTexts = new System.Windows.Forms.Button();
			this.comboBoxSerialHeaderType = new System.Windows.Forms.ComboBox();
			this.tabControlSerialFunctions = new System.Windows.Forms.TabControl();
			this.tabPageSerialCommands = new System.Windows.Forms.TabPage();
			this.buttonCommand5 = new System.Windows.Forms.Button();
			this.buttonCommand4 = new System.Windows.Forms.Button();
			this.buttonCommand3 = new System.Windows.Forms.Button();
			this.labelFavouriteCommands = new System.Windows.Forms.Label();
			this.comboBoxSerialPortLastCommands = new System.Windows.Forms.ComboBox();
			this.labelLastCommands = new System.Windows.Forms.Label();
			this.buttonCommand1 = new System.Windows.Forms.Button();
			this.buttonCommand2 = new System.Windows.Forms.Button();
			this.tabPageSerialFwUpdate = new System.Windows.Forms.TabPage();
			this.labelConstTextFwUpdateVersion = new System.Windows.Forms.Label();
			this.textBoxFWupdateVersionName = new System.Windows.Forms.TextBox();
			this.labelActualFwUpdateState = new System.Windows.Forms.Label();
			this.labelFwUpdateNeedTime = new System.Windows.Forms.Label();
			this.textBoxTimeWaitResponse = new System.Windows.Forms.TextBox();
			this.textBoxTimeWaitBetweenSending = new System.Windows.Forms.TextBox();
			this.buttonFwUpdateStart = new System.Windows.Forms.Button();
			this.labelConstTextMs1 = new System.Windows.Forms.Label();
			this.labelTimeWaitResponse = new System.Windows.Forms.Label();
			this.labelConstTextMs2 = new System.Windows.Forms.Label();
			this.labelTimeWaitBetweenSending = new System.Windows.Forms.Label();
			this.textBoxFwUpdateMaxPageErrorNum = new System.Windows.Forms.TextBox();
			this.labelConstTextActualPage = new System.Windows.Forms.Label();
			this.labelConstTextFwUpdateMaxPageError = new System.Windows.Forms.Label();
			this.labelConstTextCompleteTime = new System.Windows.Forms.Label();
			this.labelConstTextSearching = new System.Windows.Forms.Label();
			this.textBoxSerialTextFind = new System.Windows.Forms.TextBox();
			this.textBoxSerialSendMessage = new System.Windows.Forms.TextBox();
			this.richTextBoxSerialPortTexts = new System.Windows.Forms.RichTextBox();
			this.checkBoxSerialTextColouring = new System.Windows.Forms.CheckBox();
			this.checkBoxSerialHeaderSending = new System.Windows.Forms.CheckBox();
			this.checkBoxSerialCopySelected = new System.Windows.Forms.CheckBox();
			this.checkBoxSerialPortScrollBottom = new System.Windows.Forms.CheckBox();
			this.buttonSerialPortRefresh = new System.Windows.Forms.Button();
			this.buttonSerialPortSend = new System.Windows.Forms.Button();
			this.comboBoxSerialPortBaudrate = new System.Windows.Forms.ComboBox();
			this.comboBoxSerialPortCOM = new System.Windows.Forms.ComboBox();
			this.checkBoxSerialPortLog = new System.Windows.Forms.CheckBox();
			this.buttonSerialPortOpen = new System.Windows.Forms.Button();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageSettings = new System.Windows.Forms.TabPage();
			this.labelConstSettingsFavCommandsText = new System.Windows.Forms.Label();
			this.dataGridViewSettingsFavCommands = new System.Windows.Forms.DataGridView();
			this.menuStrip1.SuspendLayout();
			this.tabPageCalculator.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.tabSerialPort.SuspendLayout();
			this.tabControlSerialFunctions.SuspendLayout();
			this.tabPageSerialCommands.SuspendLayout();
			this.tabPageSerialFwUpdate.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSettingsFavCommands)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.névjegyToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(4, -1);
			this.menuStrip1.MinimumSize = new System.Drawing.Size(100, 20);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(100, 24);
			this.menuStrip1.TabIndex = 18;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fájlToolStripMenuItem
			// 
			this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.v2ProgramFájlBeállításaToolStripMenuItem,
            this.kilépésToolStripMenuItem});
			this.fájlToolStripMenuItem.Enabled = false;
			this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
			this.fájlToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fájlToolStripMenuItem.Text = "Fájl";
			// 
			// v2ProgramFájlBeállításaToolStripMenuItem
			// 
			this.v2ProgramFájlBeállításaToolStripMenuItem.Name = "v2ProgramFájlBeállításaToolStripMenuItem";
			this.v2ProgramFájlBeállításaToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
			this.v2ProgramFájlBeállításaToolStripMenuItem.Text = "V2 program fájl beállítása";
			// 
			// kilépésToolStripMenuItem
			// 
			this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
			this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
			this.kilépésToolStripMenuItem.Text = "Kilépés";
			this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
			// 
			// névjegyToolStripMenuItem
			// 
			this.névjegyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.készítetteToolStripMenuItem,
            this.segítségToolStripMenuItem});
			this.névjegyToolStripMenuItem.Enabled = false;
			this.névjegyToolStripMenuItem.Name = "névjegyToolStripMenuItem";
			this.névjegyToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
			this.névjegyToolStripMenuItem.Text = "Súgó";
			// 
			// készítetteToolStripMenuItem
			// 
			this.készítetteToolStripMenuItem.Name = "készítetteToolStripMenuItem";
			this.készítetteToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			// 
			// segítségToolStripMenuItem
			// 
			this.segítségToolStripMenuItem.Name = "segítségToolStripMenuItem";
			this.segítségToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.segítségToolStripMenuItem.Text = "Segítség";
			// 
			// serialPortDevice
			// 
			this.serialPortDevice.BaudRate = 115200;
			this.serialPortDevice.ErrorReceived += new System.IO.Ports.SerialErrorReceivedEventHandler(this.serialPortDevice_ErrorReceived);
			this.serialPortDevice.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortDevice_DataReceived);
			// 
			// timerFwUpdateActualSec
			// 
			this.timerFwUpdateActualSec.Interval = 1000;
			this.timerFwUpdateActualSec.Tick += new System.EventHandler(this.timerFwUpdateActualSec_Tick);
			// 
			// notifyIconApplication
			// 
			this.notifyIconApplication.Text = "FastenTerminal";
			// 
			// tabPageCalculator
			// 
			this.tabPageCalculator.Controls.Add(this.tableLayoutPanel1);
			this.tabPageCalculator.Location = new System.Drawing.Point(4, 22);
			this.tabPageCalculator.Name = "tabPageCalculator";
			this.tabPageCalculator.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCalculator.Size = new System.Drawing.Size(752, 395);
			this.tabPageCalculator.TabIndex = 4;
			this.tabPageCalculator.Text = "Számológép";
			this.tabPageCalculator.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.labelConstCalculatorDec, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelConstCalculatorBinary, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCalculatorDec, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCalculatorHex, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBoxCalculatorBin, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.labelConstCalculatorHex, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(117, 71);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(212, 100);
			this.tableLayoutPanel1.TabIndex = 0;
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
			this.labelConstCalculatorBinary.Location = new System.Drawing.Point(3, 68);
			this.labelConstCalculatorBinary.Name = "labelConstCalculatorBinary";
			this.labelConstCalculatorBinary.Size = new System.Drawing.Size(38, 13);
			this.labelConstCalculatorBinary.TabIndex = 2;
			this.labelConstCalculatorBinary.Text = "Bináris";
			// 
			// textBoxCalculatorDec
			// 
			this.textBoxCalculatorDec.Location = new System.Drawing.Point(109, 3);
			this.textBoxCalculatorDec.Name = "textBoxCalculatorDec";
			this.textBoxCalculatorDec.Size = new System.Drawing.Size(100, 20);
			this.textBoxCalculatorDec.TabIndex = 3;
			this.textBoxCalculatorDec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCalculatorDec_KeyPress);
			// 
			// textBoxCalculatorHex
			// 
			this.textBoxCalculatorHex.Location = new System.Drawing.Point(109, 37);
			this.textBoxCalculatorHex.Name = "textBoxCalculatorHex";
			this.textBoxCalculatorHex.Size = new System.Drawing.Size(100, 20);
			this.textBoxCalculatorHex.TabIndex = 4;
			// 
			// textBoxCalculatorBin
			// 
			this.textBoxCalculatorBin.Location = new System.Drawing.Point(109, 71);
			this.textBoxCalculatorBin.Name = "textBoxCalculatorBin";
			this.textBoxCalculatorBin.Size = new System.Drawing.Size(100, 20);
			this.textBoxCalculatorBin.TabIndex = 5;
			// 
			// labelConstCalculatorHex
			// 
			this.labelConstCalculatorHex.AutoSize = true;
			this.labelConstCalculatorHex.Location = new System.Drawing.Point(3, 34);
			this.labelConstCalculatorHex.Name = "labelConstCalculatorHex";
			this.labelConstCalculatorHex.Size = new System.Drawing.Size(75, 13);
			this.labelConstCalculatorHex.TabIndex = 1;
			this.labelConstCalculatorHex.Text = "Hexadecimális";
			// 
			// tabSerialPort
			// 
			this.tabSerialPort.Controls.Add(this.checkBoxSerialHex);
			this.tabSerialPort.Controls.Add(this.buttonClearSerialTexts);
			this.tabSerialPort.Controls.Add(this.comboBoxSerialHeaderType);
			this.tabSerialPort.Controls.Add(this.tabControlSerialFunctions);
			this.tabSerialPort.Controls.Add(this.labelConstTextSearching);
			this.tabSerialPort.Controls.Add(this.textBoxSerialTextFind);
			this.tabSerialPort.Controls.Add(this.textBoxSerialSendMessage);
			this.tabSerialPort.Controls.Add(this.richTextBoxSerialPortTexts);
			this.tabSerialPort.Controls.Add(this.checkBoxSerialTextColouring);
			this.tabSerialPort.Controls.Add(this.checkBoxSerialHeaderSending);
			this.tabSerialPort.Controls.Add(this.checkBoxSerialCopySelected);
			this.tabSerialPort.Controls.Add(this.checkBoxSerialPortScrollBottom);
			this.tabSerialPort.Controls.Add(this.buttonSerialPortRefresh);
			this.tabSerialPort.Controls.Add(this.buttonSerialPortSend);
			this.tabSerialPort.Controls.Add(this.comboBoxSerialPortBaudrate);
			this.tabSerialPort.Controls.Add(this.comboBoxSerialPortCOM);
			this.tabSerialPort.Controls.Add(this.checkBoxSerialPortLog);
			this.tabSerialPort.Controls.Add(this.buttonSerialPortOpen);
			this.tabSerialPort.Location = new System.Drawing.Point(4, 22);
			this.tabSerialPort.Name = "tabSerialPort";
			this.tabSerialPort.Padding = new System.Windows.Forms.Padding(3);
			this.tabSerialPort.Size = new System.Drawing.Size(752, 395);
			this.tabSerialPort.TabIndex = 3;
			this.tabSerialPort.Text = "Soros port";
			this.tabSerialPort.UseVisualStyleBackColor = true;
			// 
			// checkBoxSerialHex
			// 
			this.checkBoxSerialHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxSerialHex.AutoSize = true;
			this.checkBoxSerialHex.Location = new System.Drawing.Point(596, 63);
			this.checkBoxSerialHex.Name = "checkBoxSerialHex";
			this.checkBoxSerialHex.Size = new System.Drawing.Size(45, 17);
			this.checkBoxSerialHex.TabIndex = 37;
			this.checkBoxSerialHex.Text = "Hex";
			this.checkBoxSerialHex.UseVisualStyleBackColor = true;
			this.checkBoxSerialHex.CheckStateChanged += new System.EventHandler(this.checkBoxSerialHex_CheckStateChanged);
			// 
			// buttonClearSerialTexts
			// 
			this.buttonClearSerialTexts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClearSerialTexts.Location = new System.Drawing.Point(652, 65);
			this.buttonClearSerialTexts.Name = "buttonClearSerialTexts";
			this.buttonClearSerialTexts.Size = new System.Drawing.Size(90, 23);
			this.buttonClearSerialTexts.TabIndex = 36;
			this.buttonClearSerialTexts.Text = "Képernyő törlés";
			this.buttonClearSerialTexts.UseVisualStyleBackColor = true;
			this.buttonClearSerialTexts.Click += new System.EventHandler(this.buttonClearSerialTexts_Click);
			// 
			// comboBoxSerialHeaderType
			// 
			this.comboBoxSerialHeaderType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.comboBoxSerialHeaderType.FormattingEnabled = true;
			this.comboBoxSerialHeaderType.Location = new System.Drawing.Point(6, 369);
			this.comboBoxSerialHeaderType.Name = "comboBoxSerialHeaderType";
			this.comboBoxSerialHeaderType.Size = new System.Drawing.Size(82, 21);
			this.comboBoxSerialHeaderType.TabIndex = 35;
			// 
			// tabControlSerialFunctions
			// 
			this.tabControlSerialFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlSerialFunctions.Controls.Add(this.tabPageSerialCommands);
			this.tabControlSerialFunctions.Controls.Add(this.tabPageSerialFwUpdate);
			this.tabControlSerialFunctions.Location = new System.Drawing.Point(546, 155);
			this.tabControlSerialFunctions.Name = "tabControlSerialFunctions";
			this.tabControlSerialFunctions.SelectedIndex = 0;
			this.tabControlSerialFunctions.Size = new System.Drawing.Size(206, 237);
			this.tabControlSerialFunctions.TabIndex = 34;
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
			this.tabPageSerialCommands.Location = new System.Drawing.Point(4, 22);
			this.tabPageSerialCommands.Name = "tabPageSerialCommands";
			this.tabPageSerialCommands.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSerialCommands.Size = new System.Drawing.Size(198, 211);
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
			// tabPageSerialFwUpdate
			// 
			this.tabPageSerialFwUpdate.Controls.Add(this.labelConstTextFwUpdateVersion);
			this.tabPageSerialFwUpdate.Controls.Add(this.textBoxFWupdateVersionName);
			this.tabPageSerialFwUpdate.Controls.Add(this.labelActualFwUpdateState);
			this.tabPageSerialFwUpdate.Controls.Add(this.labelFwUpdateNeedTime);
			this.tabPageSerialFwUpdate.Controls.Add(this.textBoxTimeWaitResponse);
			this.tabPageSerialFwUpdate.Controls.Add(this.textBoxTimeWaitBetweenSending);
			this.tabPageSerialFwUpdate.Controls.Add(this.buttonFwUpdateStart);
			this.tabPageSerialFwUpdate.Controls.Add(this.labelConstTextMs1);
			this.tabPageSerialFwUpdate.Controls.Add(this.labelTimeWaitResponse);
			this.tabPageSerialFwUpdate.Controls.Add(this.labelConstTextMs2);
			this.tabPageSerialFwUpdate.Controls.Add(this.labelTimeWaitBetweenSending);
			this.tabPageSerialFwUpdate.Controls.Add(this.textBoxFwUpdateMaxPageErrorNum);
			this.tabPageSerialFwUpdate.Controls.Add(this.labelConstTextActualPage);
			this.tabPageSerialFwUpdate.Controls.Add(this.labelConstTextFwUpdateMaxPageError);
			this.tabPageSerialFwUpdate.Controls.Add(this.labelConstTextCompleteTime);
			this.tabPageSerialFwUpdate.Location = new System.Drawing.Point(4, 22);
			this.tabPageSerialFwUpdate.Name = "tabPageSerialFwUpdate";
			this.tabPageSerialFwUpdate.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSerialFwUpdate.Size = new System.Drawing.Size(198, 211);
			this.tabPageSerialFwUpdate.TabIndex = 1;
			this.tabPageSerialFwUpdate.Text = "FW Update";
			this.tabPageSerialFwUpdate.UseVisualStyleBackColor = true;
			// 
			// labelConstTextFwUpdateVersion
			// 
			this.labelConstTextFwUpdateVersion.AutoSize = true;
			this.labelConstTextFwUpdateVersion.Location = new System.Drawing.Point(9, 37);
			this.labelConstTextFwUpdateVersion.Name = "labelConstTextFwUpdateVersion";
			this.labelConstTextFwUpdateVersion.Size = new System.Drawing.Size(39, 13);
			this.labelConstTextFwUpdateVersion.TabIndex = 30;
			this.labelConstTextFwUpdateVersion.Text = "Verzió:";
			// 
			// textBoxFWupdateVersionName
			// 
			this.textBoxFWupdateVersionName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxFWupdateVersionName.Location = new System.Drawing.Point(57, 34);
			this.textBoxFWupdateVersionName.Name = "textBoxFWupdateVersionName";
			this.textBoxFWupdateVersionName.Size = new System.Drawing.Size(99, 20);
			this.textBoxFWupdateVersionName.TabIndex = 17;
			this.textBoxFWupdateVersionName.Text = "<verzió>";
			// 
			// labelActualFwUpdateState
			// 
			this.labelActualFwUpdateState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelActualFwUpdateState.AutoSize = true;
			this.labelActualFwUpdateState.Location = new System.Drawing.Point(64, 145);
			this.labelActualFwUpdateState.MinimumSize = new System.Drawing.Size(40, 0);
			this.labelActualFwUpdateState.Name = "labelActualFwUpdateState";
			this.labelActualFwUpdateState.Size = new System.Drawing.Size(40, 13);
			this.labelActualFwUpdateState.TabIndex = 18;
			this.labelActualFwUpdateState.Text = "-";
			// 
			// labelFwUpdateNeedTime
			// 
			this.labelFwUpdateNeedTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelFwUpdateNeedTime.AutoSize = true;
			this.labelFwUpdateNeedTime.Location = new System.Drawing.Point(88, 171);
			this.labelFwUpdateNeedTime.MinimumSize = new System.Drawing.Size(90, 0);
			this.labelFwUpdateNeedTime.Name = "labelFwUpdateNeedTime";
			this.labelFwUpdateNeedTime.Size = new System.Drawing.Size(90, 13);
			this.labelFwUpdateNeedTime.TabIndex = 19;
			this.labelFwUpdateNeedTime.Text = "-";
			// 
			// textBoxTimeWaitResponse
			// 
			this.textBoxTimeWaitResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTimeWaitResponse.Location = new System.Drawing.Point(115, 63);
			this.textBoxTimeWaitResponse.Name = "textBoxTimeWaitResponse";
			this.textBoxTimeWaitResponse.Size = new System.Drawing.Size(41, 20);
			this.textBoxTimeWaitResponse.TabIndex = 20;
			this.textBoxTimeWaitResponse.Text = "10000";
			// 
			// textBoxTimeWaitBetweenSending
			// 
			this.textBoxTimeWaitBetweenSending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTimeWaitBetweenSending.Location = new System.Drawing.Point(115, 89);
			this.textBoxTimeWaitBetweenSending.Name = "textBoxTimeWaitBetweenSending";
			this.textBoxTimeWaitBetweenSending.Size = new System.Drawing.Size(41, 20);
			this.textBoxTimeWaitBetweenSending.TabIndex = 21;
			this.textBoxTimeWaitBetweenSending.Text = "3000";
			// 
			// buttonFwUpdateStart
			// 
			this.buttonFwUpdateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFwUpdateStart.Location = new System.Drawing.Point(12, 5);
			this.buttonFwUpdateStart.Name = "buttonFwUpdateStart";
			this.buttonFwUpdateStart.Size = new System.Drawing.Size(125, 23);
			this.buttonFwUpdateStart.TabIndex = 16;
			this.buttonFwUpdateStart.Text = "FW Update start";
			this.buttonFwUpdateStart.UseVisualStyleBackColor = true;
			this.buttonFwUpdateStart.Click += new System.EventHandler(this.buttonFwUpdate_Click);
			// 
			// labelConstTextMs1
			// 
			this.labelConstTextMs1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelConstTextMs1.AutoSize = true;
			this.labelConstTextMs1.Location = new System.Drawing.Point(158, 66);
			this.labelConstTextMs1.Name = "labelConstTextMs1";
			this.labelConstTextMs1.Size = new System.Drawing.Size(20, 13);
			this.labelConstTextMs1.TabIndex = 29;
			this.labelConstTextMs1.Text = "ms";
			// 
			// labelTimeWaitResponse
			// 
			this.labelTimeWaitResponse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTimeWaitResponse.AutoSize = true;
			this.labelTimeWaitResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelTimeWaitResponse.Location = new System.Drawing.Point(9, 66);
			this.labelTimeWaitResponse.Name = "labelTimeWaitResponse";
			this.labelTimeWaitResponse.Size = new System.Drawing.Size(89, 13);
			this.labelTimeWaitResponse.TabIndex = 22;
			this.labelTimeWaitResponse.Text = "Válasz várási idő:";
			// 
			// labelConstTextMs2
			// 
			this.labelConstTextMs2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelConstTextMs2.AutoSize = true;
			this.labelConstTextMs2.Location = new System.Drawing.Point(158, 89);
			this.labelConstTextMs2.Name = "labelConstTextMs2";
			this.labelConstTextMs2.Size = new System.Drawing.Size(20, 13);
			this.labelConstTextMs2.TabIndex = 28;
			this.labelConstTextMs2.Text = "ms";
			// 
			// labelTimeWaitBetweenSending
			// 
			this.labelTimeWaitBetweenSending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelTimeWaitBetweenSending.AutoSize = true;
			this.labelTimeWaitBetweenSending.Location = new System.Drawing.Point(9, 92);
			this.labelTimeWaitBetweenSending.Name = "labelTimeWaitBetweenSending";
			this.labelTimeWaitBetweenSending.Size = new System.Drawing.Size(96, 13);
			this.labelTimeWaitBetweenSending.TabIndex = 23;
			this.labelTimeWaitBetweenSending.Text = "Küldések közti idő:";
			// 
			// textBoxFwUpdateMaxPageErrorNum
			// 
			this.textBoxFwUpdateMaxPageErrorNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxFwUpdateMaxPageErrorNum.Location = new System.Drawing.Point(115, 116);
			this.textBoxFwUpdateMaxPageErrorNum.Name = "textBoxFwUpdateMaxPageErrorNum";
			this.textBoxFwUpdateMaxPageErrorNum.Size = new System.Drawing.Size(41, 20);
			this.textBoxFwUpdateMaxPageErrorNum.TabIndex = 27;
			this.textBoxFwUpdateMaxPageErrorNum.Text = "5";
			// 
			// labelConstTextActualPage
			// 
			this.labelConstTextActualPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelConstTextActualPage.AutoSize = true;
			this.labelConstTextActualPage.Location = new System.Drawing.Point(9, 145);
			this.labelConstTextActualPage.Name = "labelConstTextActualPage";
			this.labelConstTextActualPage.Size = new System.Drawing.Size(49, 13);
			this.labelConstTextActualPage.TabIndex = 24;
			this.labelConstTextActualPage.Text = "Jelenleg:";
			// 
			// labelConstTextFwUpdateMaxPageError
			// 
			this.labelConstTextFwUpdateMaxPageError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelConstTextFwUpdateMaxPageError.AutoSize = true;
			this.labelConstTextFwUpdateMaxPageError.Location = new System.Drawing.Point(9, 119);
			this.labelConstTextFwUpdateMaxPageError.Name = "labelConstTextFwUpdateMaxPageError";
			this.labelConstTextFwUpdateMaxPageError.Size = new System.Drawing.Size(83, 13);
			this.labelConstTextFwUpdateMaxPageError.TabIndex = 26;
			this.labelConstTextFwUpdateMaxPageError.Text = "Max. page hiba:";
			// 
			// labelConstTextCompleteTime
			// 
			this.labelConstTextCompleteTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelConstTextCompleteTime.AutoSize = true;
			this.labelConstTextCompleteTime.Location = new System.Drawing.Point(9, 171);
			this.labelConstTextCompleteTime.Name = "labelConstTextCompleteTime";
			this.labelConstTextCompleteTime.Size = new System.Drawing.Size(73, 13);
			this.labelConstTextCompleteTime.TabIndex = 25;
			this.labelConstTextCompleteTime.Text = "Hátralevő idő:";
			// 
			// labelConstTextSearching
			// 
			this.labelConstTextSearching.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelConstTextSearching.AutoSize = true;
			this.labelConstTextSearching.Location = new System.Drawing.Point(674, 109);
			this.labelConstTextSearching.Name = "labelConstTextSearching";
			this.labelConstTextSearching.Size = new System.Drawing.Size(48, 13);
			this.labelConstTextSearching.TabIndex = 33;
			this.labelConstTextSearching.Text = "Keresés:";
			// 
			// textBoxSerialTextFind
			// 
			this.textBoxSerialTextFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSerialTextFind.Location = new System.Drawing.Point(652, 129);
			this.textBoxSerialTextFind.Name = "textBoxSerialTextFind";
			this.textBoxSerialTextFind.Size = new System.Drawing.Size(90, 20);
			this.textBoxSerialTextFind.TabIndex = 32;
			this.textBoxSerialTextFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSerialTextFind_KeyPress);
			// 
			// textBoxSerialSendMessage
			// 
			this.textBoxSerialSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSerialSendMessage.Location = new System.Drawing.Point(115, 369);
			this.textBoxSerialSendMessage.MaxLength = 256;
			this.textBoxSerialSendMessage.Name = "textBoxSerialSendMessage";
			this.textBoxSerialSendMessage.Size = new System.Drawing.Size(344, 20);
			this.textBoxSerialSendMessage.TabIndex = 5;
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
			this.richTextBoxSerialPortTexts.Location = new System.Drawing.Point(9, 7);
			this.richTextBoxSerialPortTexts.Name = "richTextBoxSerialPortTexts";
			this.richTextBoxSerialPortTexts.ReadOnly = true;
			this.richTextBoxSerialPortTexts.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.richTextBoxSerialPortTexts.Size = new System.Drawing.Size(531, 355);
			this.richTextBoxSerialPortTexts.TabIndex = 0;
			this.richTextBoxSerialPortTexts.Text = "";
			this.richTextBoxSerialPortTexts.SelectionChanged += new System.EventHandler(this.richTextBoxSerialPortTexts_SelectionChanged);
			this.richTextBoxSerialPortTexts.TextChanged += new System.EventHandler(this.richTextBoxSerialPortTexts_TextChanged);
			// 
			// checkBoxSerialTextColouring
			// 
			this.checkBoxSerialTextColouring.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxSerialTextColouring.AutoSize = true;
			this.checkBoxSerialTextColouring.Checked = true;
			this.checkBoxSerialTextColouring.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSerialTextColouring.Location = new System.Drawing.Point(546, 132);
			this.checkBoxSerialTextColouring.Name = "checkBoxSerialTextColouring";
			this.checkBoxSerialTextColouring.Size = new System.Drawing.Size(107, 17);
			this.checkBoxSerialTextColouring.TabIndex = 31;
			this.checkBoxSerialTextColouring.Text = "Szöveg színezés";
			this.checkBoxSerialTextColouring.UseVisualStyleBackColor = true;
			// 
			// checkBoxSerialHeaderSending
			// 
			this.checkBoxSerialHeaderSending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxSerialHeaderSending.AutoSize = true;
			this.checkBoxSerialHeaderSending.Location = new System.Drawing.Point(94, 372);
			this.checkBoxSerialHeaderSending.Name = "checkBoxSerialHeaderSending";
			this.checkBoxSerialHeaderSending.Size = new System.Drawing.Size(15, 14);
			this.checkBoxSerialHeaderSending.TabIndex = 30;
			this.checkBoxSerialHeaderSending.UseVisualStyleBackColor = true;
			// 
			// checkBoxSerialCopySelected
			// 
			this.checkBoxSerialCopySelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxSerialCopySelected.AutoSize = true;
			this.checkBoxSerialCopySelected.Checked = true;
			this.checkBoxSerialCopySelected.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSerialCopySelected.Location = new System.Drawing.Point(546, 109);
			this.checkBoxSerialCopySelected.Name = "checkBoxSerialCopySelected";
			this.checkBoxSerialCopySelected.Size = new System.Drawing.Size(109, 17);
			this.checkBoxSerialCopySelected.TabIndex = 13;
			this.checkBoxSerialCopySelected.Text = "Szöveg másolása";
			this.checkBoxSerialCopySelected.UseVisualStyleBackColor = true;
			// 
			// checkBoxSerialPortScrollBottom
			// 
			this.checkBoxSerialPortScrollBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxSerialPortScrollBottom.AutoSize = true;
			this.checkBoxSerialPortScrollBottom.Checked = true;
			this.checkBoxSerialPortScrollBottom.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSerialPortScrollBottom.Location = new System.Drawing.Point(546, 87);
			this.checkBoxSerialPortScrollBottom.Name = "checkBoxSerialPortScrollBottom";
			this.checkBoxSerialPortScrollBottom.Size = new System.Drawing.Size(78, 17);
			this.checkBoxSerialPortScrollBottom.TabIndex = 12;
			this.checkBoxSerialPortScrollBottom.Text = "Legördülés";
			this.checkBoxSerialPortScrollBottom.UseVisualStyleBackColor = true;
			// 
			// buttonSerialPortRefresh
			// 
			this.buttonSerialPortRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSerialPortRefresh.Location = new System.Drawing.Point(652, 7);
			this.buttonSerialPortRefresh.Name = "buttonSerialPortRefresh";
			this.buttonSerialPortRefresh.Size = new System.Drawing.Size(90, 23);
			this.buttonSerialPortRefresh.TabIndex = 8;
			this.buttonSerialPortRefresh.Text = "Port Frissítés";
			this.buttonSerialPortRefresh.UseVisualStyleBackColor = true;
			this.buttonSerialPortRefresh.Click += new System.EventHandler(this.buttonSerialPortRefresh_Click);
			// 
			// buttonSerialPortSend
			// 
			this.buttonSerialPortSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSerialPortSend.Location = new System.Drawing.Point(465, 367);
			this.buttonSerialPortSend.Name = "buttonSerialPortSend";
			this.buttonSerialPortSend.Size = new System.Drawing.Size(75, 23);
			this.buttonSerialPortSend.TabIndex = 6;
			this.buttonSerialPortSend.Text = "Küldés";
			this.buttonSerialPortSend.UseVisualStyleBackColor = true;
			this.buttonSerialPortSend.Click += new System.EventHandler(this.buttonSerialPortSend_Click);
			// 
			// comboBoxSerialPortBaudrate
			// 
			this.comboBoxSerialPortBaudrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxSerialPortBaudrate.FormattingEnabled = true;
			this.comboBoxSerialPortBaudrate.Items.AddRange(new object[] {
            "115200",
            "9600"});
			this.comboBoxSerialPortBaudrate.Location = new System.Drawing.Point(546, 36);
			this.comboBoxSerialPortBaudrate.Name = "comboBoxSerialPortBaudrate";
			this.comboBoxSerialPortBaudrate.Size = new System.Drawing.Size(82, 21);
			this.comboBoxSerialPortBaudrate.TabIndex = 4;
			this.comboBoxSerialPortBaudrate.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPortBaudrate_SelectedIndexChanged);
			// 
			// comboBoxSerialPortCOM
			// 
			this.comboBoxSerialPortCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxSerialPortCOM.FormattingEnabled = true;
			this.comboBoxSerialPortCOM.Location = new System.Drawing.Point(546, 7);
			this.comboBoxSerialPortCOM.Name = "comboBoxSerialPortCOM";
			this.comboBoxSerialPortCOM.Size = new System.Drawing.Size(82, 21);
			this.comboBoxSerialPortCOM.TabIndex = 3;
			this.comboBoxSerialPortCOM.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPortCOM_SelectedIndexChanged);
			// 
			// checkBoxSerialPortLog
			// 
			this.checkBoxSerialPortLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxSerialPortLog.AutoSize = true;
			this.checkBoxSerialPortLog.Checked = true;
			this.checkBoxSerialPortLog.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSerialPortLog.Location = new System.Drawing.Point(546, 63);
			this.checkBoxSerialPortLog.Name = "checkBoxSerialPortLog";
			this.checkBoxSerialPortLog.Size = new System.Drawing.Size(44, 17);
			this.checkBoxSerialPortLog.TabIndex = 2;
			this.checkBoxSerialPortLog.Text = "Log";
			this.checkBoxSerialPortLog.UseVisualStyleBackColor = true;
			this.checkBoxSerialPortLog.CheckedChanged += new System.EventHandler(this.checkBoxSerialPortLog_CheckedChanged);
			// 
			// buttonSerialPortOpen
			// 
			this.buttonSerialPortOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSerialPortOpen.Location = new System.Drawing.Point(652, 36);
			this.buttonSerialPortOpen.Name = "buttonSerialPortOpen";
			this.buttonSerialPortOpen.Size = new System.Drawing.Size(90, 23);
			this.buttonSerialPortOpen.TabIndex = 1;
			this.buttonSerialPortOpen.Text = "Port nyitás";
			this.buttonSerialPortOpen.UseVisualStyleBackColor = true;
			this.buttonSerialPortOpen.Click += new System.EventHandler(this.buttonSerialPortOpen_Click);
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabSerialPort);
			this.tabControl.Controls.Add(this.tabPageCalculator);
			this.tabControl.Controls.Add(this.tabPageSettings);
			this.tabControl.Location = new System.Drawing.Point(0, 27);
			this.tabControl.MinimumSize = new System.Drawing.Size(300, 200);
			this.tabControl.Multiline = true;
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(760, 421);
			this.tabControl.TabIndex = 17;
			// 
			// tabPageSettings
			// 
			this.tabPageSettings.Controls.Add(this.labelConstSettingsFavCommandsText);
			this.tabPageSettings.Controls.Add(this.dataGridViewSettingsFavCommands);
			this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
			this.tabPageSettings.Name = "tabPageSettings";
			this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSettings.Size = new System.Drawing.Size(752, 395);
			this.tabPageSettings.TabIndex = 5;
			this.tabPageSettings.Text = "Beállítások";
			this.tabPageSettings.UseVisualStyleBackColor = true;
			// 
			// labelConstSettingsFavCommandsText
			// 
			this.labelConstSettingsFavCommandsText.AutoSize = true;
			this.labelConstSettingsFavCommandsText.Location = new System.Drawing.Point(5, 7);
			this.labelConstSettingsFavCommandsText.Name = "labelConstSettingsFavCommandsText";
			this.labelConstSettingsFavCommandsText.Size = new System.Drawing.Size(106, 13);
			this.labelConstSettingsFavCommandsText.TabIndex = 1;
			this.labelConstSettingsFavCommandsText.Text = "Kedvenc parancsok:";
			// 
			// dataGridViewSettingsFavCommands
			// 
			this.dataGridViewSettingsFavCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridViewSettingsFavCommands.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewSettingsFavCommands.Location = new System.Drawing.Point(3, 23);
			this.dataGridViewSettingsFavCommands.Name = "dataGridViewSettingsFavCommands";
			this.dataGridViewSettingsFavCommands.Size = new System.Drawing.Size(339, 369);
			this.dataGridViewSettingsFavCommands.TabIndex = 0;
			// 
			// FastenTerminal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(758, 447);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(600, 485);
			this.Name = "FastenTerminal";
			this.Text = "FastenTerminal";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JarKonDevApplication_FormClosing);
			this.Load += new System.EventHandler(this.FormFastenTerminalMain_Load);
			this.Leave += new System.EventHandler(this.FastenTerminal_Leave);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabPageCalculator.ResumeLayout(false);
			this.tabPageCalculator.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tabSerialPort.ResumeLayout(false);
			this.tabSerialPort.PerformLayout();
			this.tabControlSerialFunctions.ResumeLayout(false);
			this.tabPageSerialCommands.ResumeLayout(false);
			this.tabPageSerialCommands.PerformLayout();
			this.tabPageSerialFwUpdate.ResumeLayout(false);
			this.tabPageSerialFwUpdate.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPageSettings.ResumeLayout(false);
			this.tabPageSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewSettingsFavCommands)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem v2ProgramFájlBeállításaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem készítetteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem segítségToolStripMenuItem;
		private System.IO.Ports.SerialPort serialPortDevice;
		private System.Windows.Forms.Timer timerFwUpdateActualSec;
		public System.Windows.Forms.NotifyIcon notifyIconApplication;
		private System.Windows.Forms.TabPage tabPageCalculator;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelConstCalculatorDec;
		private System.Windows.Forms.Label labelConstCalculatorBinary;
		private System.Windows.Forms.TextBox textBoxCalculatorDec;
		private System.Windows.Forms.TextBox textBoxCalculatorHex;
		private System.Windows.Forms.TextBox textBoxCalculatorBin;
		private System.Windows.Forms.Label labelConstCalculatorHex;
		private System.Windows.Forms.TabPage tabSerialPort;
		private System.Windows.Forms.Button buttonClearSerialTexts;
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
		private System.Windows.Forms.TabPage tabPageSerialFwUpdate;
		private System.Windows.Forms.Label labelConstTextFwUpdateVersion;
		private System.Windows.Forms.TextBox textBoxFWupdateVersionName;
		private System.Windows.Forms.Label labelActualFwUpdateState;
		private System.Windows.Forms.Label labelFwUpdateNeedTime;
		private System.Windows.Forms.TextBox textBoxTimeWaitResponse;
		private System.Windows.Forms.TextBox textBoxTimeWaitBetweenSending;
		private System.Windows.Forms.Button buttonFwUpdateStart;
		private System.Windows.Forms.Label labelConstTextMs1;
		private System.Windows.Forms.Label labelTimeWaitResponse;
		private System.Windows.Forms.Label labelConstTextMs2;
		private System.Windows.Forms.Label labelTimeWaitBetweenSending;
		private System.Windows.Forms.TextBox textBoxFwUpdateMaxPageErrorNum;
		private System.Windows.Forms.Label labelConstTextActualPage;
		private System.Windows.Forms.Label labelConstTextFwUpdateMaxPageError;
		private System.Windows.Forms.Label labelConstTextCompleteTime;
		private System.Windows.Forms.Label labelConstTextSearching;
		private System.Windows.Forms.TextBox textBoxSerialTextFind;
		private System.Windows.Forms.TextBox textBoxSerialSendMessage;
		private System.Windows.Forms.RichTextBox richTextBoxSerialPortTexts;
		private System.Windows.Forms.CheckBox checkBoxSerialTextColouring;
		private System.Windows.Forms.CheckBox checkBoxSerialHeaderSending;
		private System.Windows.Forms.CheckBox checkBoxSerialCopySelected;
		private System.Windows.Forms.CheckBox checkBoxSerialPortScrollBottom;
		private System.Windows.Forms.Button buttonSerialPortRefresh;
		private System.Windows.Forms.Button buttonSerialPortSend;
		private System.Windows.Forms.ComboBox comboBoxSerialPortBaudrate;
		private System.Windows.Forms.ComboBox comboBoxSerialPortCOM;
		private System.Windows.Forms.CheckBox checkBoxSerialPortLog;
		private System.Windows.Forms.Button buttonSerialPortOpen;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageSettings;
		private System.Windows.Forms.DataGridView dataGridViewSettingsFavCommands;
		private System.Windows.Forms.Label labelConstSettingsFavCommandsText;
		private System.Windows.Forms.CheckBox checkBoxSerialHex;
    }
}

