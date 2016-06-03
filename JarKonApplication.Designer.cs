namespace JarKonDevApplication
{
    partial class JarKonDevApplication
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JarKonDevApplication));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabSerialPort = new System.Windows.Forms.TabPage();
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
			this.checkBoxSerialTextColouring = new System.Windows.Forms.CheckBox();
			this.checkBoxSerialHeaderSending = new System.Windows.Forms.CheckBox();
			this.checkBoxSerialCopySelected = new System.Windows.Forms.CheckBox();
			this.checkBoxSerialPortScrollBottom = new System.Windows.Forms.CheckBox();
			this.buttonSerialPortRefresh = new System.Windows.Forms.Button();
			this.buttonSerialPortSend = new System.Windows.Forms.Button();
			this.textBoxSerialSendMessage = new System.Windows.Forms.TextBox();
			this.comboBoxSerialPortBaudrate = new System.Windows.Forms.ComboBox();
			this.comboBoxSerialPortCOM = new System.Windows.Forms.ComboBox();
			this.checkBoxSerialPortLog = new System.Windows.Forms.CheckBox();
			this.buttonSerialPortOpen = new System.Windows.Forms.Button();
			this.richTextBoxSerialPortTexts = new System.Windows.Forms.RichTextBox();
			this.tabPageV2programming = new System.Windows.Forms.TabPage();
			this.labelProgrammerGroupST = new System.Windows.Forms.Label();
			this.labelProgrammerGroupCortex = new System.Windows.Forms.Label();
			this.labelProgrammerGroupv2ObuMk2 = new System.Windows.Forms.Label();
			this.progressBarProgramming = new System.Windows.Forms.ProgressBar();
			this.buttonFuelTransformerProgramming = new System.Windows.Forms.Button();
			this.buttonAccelerometerProgramming = new System.Windows.Forms.Button();
			this.buttonTastaProgramming = new System.Windows.Forms.Button();
			this.textBoxProgramOutput = new System.Windows.Forms.TextBox();
			this.labelOutput = new System.Windows.Forms.Label();
			this.textBoxProgramCommand = new System.Windows.Forms.TextBox();
			this.labelV2Program = new System.Windows.Forms.Label();
			this.buttonObuProgramming = new System.Windows.Forms.Button();
			this.buttonV2programming = new System.Windows.Forms.Button();
			this.tabPageSettings = new System.Windows.Forms.TabPage();
			this.textBoxAtmelProgrammerPath = new System.Windows.Forms.TextBox();
			this.textBoxAtmelProgrammerStandardInformation = new System.Windows.Forms.TextBox();
			this.buttonAtmelProgrammerSetting = new System.Windows.Forms.Button();
			this.labelPickAtmelProgrammer = new System.Windows.Forms.Label();
			this.tabPageCalculator = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labelConstCalculatorDec = new System.Windows.Forms.Label();
			this.labelConstCalculatorHex = new System.Windows.Forms.Label();
			this.labelConstCalculatorBinary = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.v2ProgramFájlBeállításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.készítetteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.segítségToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.serialPortDevice = new System.IO.Ports.SerialPort(this.components);
			this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
			this.timerFwUpdateActualSec = new System.Windows.Forms.Timer(this.components);
			this.notifyIconApplication = new System.Windows.Forms.NotifyIcon(this.components);
			this.tabControl.SuspendLayout();
			this.tabSerialPort.SuspendLayout();
			this.tabControlSerialFunctions.SuspendLayout();
			this.tabPageSerialCommands.SuspendLayout();
			this.tabPageSerialFwUpdate.SuspendLayout();
			this.tabPageV2programming.SuspendLayout();
			this.tabPageSettings.SuspendLayout();
			this.tabPageCalculator.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabSerialPort);
			this.tabControl.Controls.Add(this.tabPageV2programming);
			this.tabControl.Controls.Add(this.tabPageSettings);
			this.tabControl.Controls.Add(this.tabPageCalculator);
			this.tabControl.Location = new System.Drawing.Point(0, 27);
			this.tabControl.MinimumSize = new System.Drawing.Size(300, 200);
			this.tabControl.Multiline = true;
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(758, 395);
			this.tabControl.TabIndex = 17;
			// 
			// tabSerialPort
			// 
			this.tabSerialPort.Controls.Add(this.tabControlSerialFunctions);
			this.tabSerialPort.Controls.Add(this.labelConstTextSearching);
			this.tabSerialPort.Controls.Add(this.textBoxSerialTextFind);
			this.tabSerialPort.Controls.Add(this.checkBoxSerialTextColouring);
			this.tabSerialPort.Controls.Add(this.checkBoxSerialHeaderSending);
			this.tabSerialPort.Controls.Add(this.checkBoxSerialCopySelected);
			this.tabSerialPort.Controls.Add(this.checkBoxSerialPortScrollBottom);
			this.tabSerialPort.Controls.Add(this.buttonSerialPortRefresh);
			this.tabSerialPort.Controls.Add(this.buttonSerialPortSend);
			this.tabSerialPort.Controls.Add(this.textBoxSerialSendMessage);
			this.tabSerialPort.Controls.Add(this.comboBoxSerialPortBaudrate);
			this.tabSerialPort.Controls.Add(this.comboBoxSerialPortCOM);
			this.tabSerialPort.Controls.Add(this.checkBoxSerialPortLog);
			this.tabSerialPort.Controls.Add(this.buttonSerialPortOpen);
			this.tabSerialPort.Controls.Add(this.richTextBoxSerialPortTexts);
			this.tabSerialPort.Location = new System.Drawing.Point(4, 22);
			this.tabSerialPort.Name = "tabSerialPort";
			this.tabSerialPort.Padding = new System.Windows.Forms.Padding(3);
			this.tabSerialPort.Size = new System.Drawing.Size(750, 369);
			this.tabSerialPort.TabIndex = 3;
			this.tabSerialPort.Text = "Soros port";
			this.tabSerialPort.UseVisualStyleBackColor = true;
			// 
			// tabControlSerialFunctions
			// 
			this.tabControlSerialFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlSerialFunctions.Controls.Add(this.tabPageSerialCommands);
			this.tabControlSerialFunctions.Controls.Add(this.tabPageSerialFwUpdate);
			this.tabControlSerialFunctions.Location = new System.Drawing.Point(544, 130);
			this.tabControlSerialFunctions.Name = "tabControlSerialFunctions";
			this.tabControlSerialFunctions.SelectedIndex = 0;
			this.tabControlSerialFunctions.Size = new System.Drawing.Size(206, 236);
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
			this.tabPageSerialCommands.Size = new System.Drawing.Size(198, 210);
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
			this.tabPageSerialFwUpdate.Size = new System.Drawing.Size(198, 210);
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
			this.labelConstTextMs1.Location = new System.Drawing.Point(162, 66);
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
			this.labelConstTextMs2.Location = new System.Drawing.Point(162, 89);
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
			this.labelConstTextSearching.Location = new System.Drawing.Point(578, 107);
			this.labelConstTextSearching.Name = "labelConstTextSearching";
			this.labelConstTextSearching.Size = new System.Drawing.Size(48, 13);
			this.labelConstTextSearching.TabIndex = 33;
			this.labelConstTextSearching.Text = "Keresés:";
			// 
			// textBoxSerialTextFind
			// 
			this.textBoxSerialTextFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSerialTextFind.Location = new System.Drawing.Point(631, 104);
			this.textBoxSerialTextFind.Name = "textBoxSerialTextFind";
			this.textBoxSerialTextFind.Size = new System.Drawing.Size(100, 20);
			this.textBoxSerialTextFind.TabIndex = 32;
			this.textBoxSerialTextFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSerialTextFind_KeyPress);
			// 
			// checkBoxSerialTextColouring
			// 
			this.checkBoxSerialTextColouring.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxSerialTextColouring.AutoSize = true;
			this.checkBoxSerialTextColouring.Checked = true;
			this.checkBoxSerialTextColouring.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSerialTextColouring.Location = new System.Drawing.Point(631, 86);
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
			this.checkBoxSerialHeaderSending.Checked = true;
			this.checkBoxSerialHeaderSending.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSerialHeaderSending.Location = new System.Drawing.Point(12, 346);
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
			this.checkBoxSerialCopySelected.Location = new System.Drawing.Point(631, 63);
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
			this.checkBoxSerialPortScrollBottom.Location = new System.Drawing.Point(544, 87);
			this.checkBoxSerialPortScrollBottom.Name = "checkBoxSerialPortScrollBottom";
			this.checkBoxSerialPortScrollBottom.Size = new System.Drawing.Size(78, 17);
			this.checkBoxSerialPortScrollBottom.TabIndex = 12;
			this.checkBoxSerialPortScrollBottom.Text = "Legördülés";
			this.checkBoxSerialPortScrollBottom.UseVisualStyleBackColor = true;
			// 
			// buttonSerialPortRefresh
			// 
			this.buttonSerialPortRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSerialPortRefresh.Location = new System.Drawing.Point(650, 7);
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
			this.buttonSerialPortSend.Location = new System.Drawing.Point(463, 341);
			this.buttonSerialPortSend.Name = "buttonSerialPortSend";
			this.buttonSerialPortSend.Size = new System.Drawing.Size(75, 23);
			this.buttonSerialPortSend.TabIndex = 6;
			this.buttonSerialPortSend.Text = "Küldés";
			this.buttonSerialPortSend.UseVisualStyleBackColor = true;
			this.buttonSerialPortSend.Click += new System.EventHandler(this.buttonSerialPortSend_Click);
			// 
			// textBoxSerialSendMessage
			// 
			this.textBoxSerialSendMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxSerialSendMessage.Location = new System.Drawing.Point(33, 343);
			this.textBoxSerialSendMessage.Name = "textBoxSerialSendMessage";
			this.textBoxSerialSendMessage.Size = new System.Drawing.Size(424, 20);
			this.textBoxSerialSendMessage.TabIndex = 5;
			this.textBoxSerialSendMessage.Text = "<Küldendő üzenet>";
			this.textBoxSerialSendMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSerialSendMessage_KeyPress);
			// 
			// comboBoxSerialPortBaudrate
			// 
			this.comboBoxSerialPortBaudrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxSerialPortBaudrate.FormattingEnabled = true;
			this.comboBoxSerialPortBaudrate.Items.AddRange(new object[] {
            "115200",
            "9600"});
			this.comboBoxSerialPortBaudrate.Location = new System.Drawing.Point(544, 36);
			this.comboBoxSerialPortBaudrate.Name = "comboBoxSerialPortBaudrate";
			this.comboBoxSerialPortBaudrate.Size = new System.Drawing.Size(82, 21);
			this.comboBoxSerialPortBaudrate.TabIndex = 4;
			this.comboBoxSerialPortBaudrate.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPortBaudrate_SelectedIndexChanged);
			// 
			// comboBoxSerialPortCOM
			// 
			this.comboBoxSerialPortCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxSerialPortCOM.FormattingEnabled = true;
			this.comboBoxSerialPortCOM.Location = new System.Drawing.Point(544, 7);
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
			this.checkBoxSerialPortLog.Location = new System.Drawing.Point(544, 63);
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
			this.buttonSerialPortOpen.Location = new System.Drawing.Point(650, 36);
			this.buttonSerialPortOpen.Name = "buttonSerialPortOpen";
			this.buttonSerialPortOpen.Size = new System.Drawing.Size(90, 23);
			this.buttonSerialPortOpen.TabIndex = 1;
			this.buttonSerialPortOpen.Text = "Port nyitás";
			this.buttonSerialPortOpen.UseVisualStyleBackColor = true;
			this.buttonSerialPortOpen.Click += new System.EventHandler(this.buttonSerialPortOpen_Click);
			// 
			// richTextBoxSerialPortTexts
			// 
			this.richTextBoxSerialPortTexts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.richTextBoxSerialPortTexts.Location = new System.Drawing.Point(9, 7);
			this.richTextBoxSerialPortTexts.Name = "richTextBoxSerialPortTexts";
			this.richTextBoxSerialPortTexts.ReadOnly = true;
			this.richTextBoxSerialPortTexts.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.richTextBoxSerialPortTexts.Size = new System.Drawing.Size(529, 329);
			this.richTextBoxSerialPortTexts.TabIndex = 0;
			this.richTextBoxSerialPortTexts.Text = "";
			this.richTextBoxSerialPortTexts.SelectionChanged += new System.EventHandler(this.richTextBoxSerialPortTexts_SelectionChanged);
			this.richTextBoxSerialPortTexts.TextChanged += new System.EventHandler(this.richTextBoxSerialPortTexts_TextChanged);
			// 
			// tabPageV2programming
			// 
			this.tabPageV2programming.Controls.Add(this.labelProgrammerGroupST);
			this.tabPageV2programming.Controls.Add(this.labelProgrammerGroupCortex);
			this.tabPageV2programming.Controls.Add(this.labelProgrammerGroupv2ObuMk2);
			this.tabPageV2programming.Controls.Add(this.progressBarProgramming);
			this.tabPageV2programming.Controls.Add(this.buttonFuelTransformerProgramming);
			this.tabPageV2programming.Controls.Add(this.buttonAccelerometerProgramming);
			this.tabPageV2programming.Controls.Add(this.buttonTastaProgramming);
			this.tabPageV2programming.Controls.Add(this.textBoxProgramOutput);
			this.tabPageV2programming.Controls.Add(this.labelOutput);
			this.tabPageV2programming.Controls.Add(this.textBoxProgramCommand);
			this.tabPageV2programming.Controls.Add(this.labelV2Program);
			this.tabPageV2programming.Controls.Add(this.buttonObuProgramming);
			this.tabPageV2programming.Controls.Add(this.buttonV2programming);
			this.tabPageV2programming.Location = new System.Drawing.Point(4, 22);
			this.tabPageV2programming.Name = "tabPageV2programming";
			this.tabPageV2programming.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageV2programming.Size = new System.Drawing.Size(750, 369);
			this.tabPageV2programming.TabIndex = 2;
			this.tabPageV2programming.Text = "Programozás";
			this.tabPageV2programming.UseVisualStyleBackColor = true;
			// 
			// labelProgrammerGroupST
			// 
			this.labelProgrammerGroupST.AutoSize = true;
			this.labelProgrammerGroupST.Location = new System.Drawing.Point(8, 201);
			this.labelProgrammerGroupST.Name = "labelProgrammerGroupST";
			this.labelProgrammerGroupST.Size = new System.Drawing.Size(105, 13);
			this.labelProgrammerGroupST.TabIndex = 14;
			this.labelProgrammerGroupST.Text = "Cortex - ST - ST link:";
			// 
			// labelProgrammerGroupCortex
			// 
			this.labelProgrammerGroupCortex.AutoSize = true;
			this.labelProgrammerGroupCortex.Location = new System.Drawing.Point(8, 107);
			this.labelProgrammerGroupCortex.Name = "labelProgrammerGroupCortex";
			this.labelProgrammerGroupCortex.Size = new System.Drawing.Size(75, 13);
			this.labelProgrammerGroupCortex.TabIndex = 13;
			this.labelProgrammerGroupCortex.Text = "Cortex - Atmel:";
			// 
			// labelProgrammerGroupv2ObuMk2
			// 
			this.labelProgrammerGroupv2ObuMk2.AutoSize = true;
			this.labelProgrammerGroupv2ObuMk2.Location = new System.Drawing.Point(8, 3);
			this.labelProgrammerGroupv2ObuMk2.Name = "labelProgrammerGroupv2ObuMk2";
			this.labelProgrammerGroupv2ObuMk2.Size = new System.Drawing.Size(118, 13);
			this.labelProgrammerGroupv2ObuMk2.TabIndex = 12;
			this.labelProgrammerGroupv2ObuMk2.Text = "AVR MK-II programozó:";
			// 
			// progressBarProgramming
			// 
			this.progressBarProgramming.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.progressBarProgramming.Enabled = false;
			this.progressBarProgramming.Location = new System.Drawing.Point(8, 259);
			this.progressBarProgramming.Name = "progressBarProgramming";
			this.progressBarProgramming.Size = new System.Drawing.Size(181, 23);
			this.progressBarProgramming.TabIndex = 11;
			// 
			// buttonFuelTransformerProgramming
			// 
			this.buttonFuelTransformerProgramming.Enabled = false;
			this.buttonFuelTransformerProgramming.Location = new System.Drawing.Point(8, 217);
			this.buttonFuelTransformerProgramming.Name = "buttonFuelTransformerProgramming";
			this.buttonFuelTransformerProgramming.Size = new System.Drawing.Size(181, 23);
			this.buttonFuelTransformerProgramming.TabIndex = 9;
			this.buttonFuelTransformerProgramming.Text = "FuelTransformer Programozás";
			this.buttonFuelTransformerProgramming.UseVisualStyleBackColor = true;
			// 
			// buttonAccelerometerProgramming
			// 
			this.buttonAccelerometerProgramming.Location = new System.Drawing.Point(8, 152);
			this.buttonAccelerometerProgramming.Name = "buttonAccelerometerProgramming";
			this.buttonAccelerometerProgramming.Size = new System.Drawing.Size(181, 23);
			this.buttonAccelerometerProgramming.TabIndex = 8;
			this.buttonAccelerometerProgramming.Text = "Gyorsulásérzékelő Programozás";
			this.buttonAccelerometerProgramming.UseVisualStyleBackColor = true;
			this.buttonAccelerometerProgramming.Click += new System.EventHandler(this.buttonAccelerometerProgramming_Click);
			// 
			// buttonTastaProgramming
			// 
			this.buttonTastaProgramming.Location = new System.Drawing.Point(8, 123);
			this.buttonTastaProgramming.Name = "buttonTastaProgramming";
			this.buttonTastaProgramming.Size = new System.Drawing.Size(131, 23);
			this.buttonTastaProgramming.TabIndex = 7;
			this.buttonTastaProgramming.Text = "Taszta Programozás";
			this.buttonTastaProgramming.UseVisualStyleBackColor = true;
			this.buttonTastaProgramming.Click += new System.EventHandler(this.buttonTastaProgramming_Click);
			// 
			// textBoxProgramOutput
			// 
			this.textBoxProgramOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxProgramOutput.Location = new System.Drawing.Point(195, 152);
			this.textBoxProgramOutput.MinimumSize = new System.Drawing.Size(100, 20);
			this.textBoxProgramOutput.Multiline = true;
			this.textBoxProgramOutput.Name = "textBoxProgramOutput";
			this.textBoxProgramOutput.ReadOnly = true;
			this.textBoxProgramOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxProgramOutput.Size = new System.Drawing.Size(518, 130);
			this.textBoxProgramOutput.TabIndex = 6;
			this.textBoxProgramOutput.TextChanged += new System.EventHandler(this.textBoxProgramOutput_TextChanged);
			// 
			// labelOutput
			// 
			this.labelOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.labelOutput.AutoSize = true;
			this.labelOutput.Location = new System.Drawing.Point(196, 136);
			this.labelOutput.Name = "labelOutput";
			this.labelOutput.Size = new System.Drawing.Size(89, 13);
			this.labelOutput.TabIndex = 5;
			this.labelOutput.Text = "Parancs kimenet:";
			// 
			// textBoxProgramCommand
			// 
			this.textBoxProgramCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxProgramCommand.Location = new System.Drawing.Point(195, 19);
			this.textBoxProgramCommand.MinimumSize = new System.Drawing.Size(100, 20);
			this.textBoxProgramCommand.Multiline = true;
			this.textBoxProgramCommand.Name = "textBoxProgramCommand";
			this.textBoxProgramCommand.ReadOnly = true;
			this.textBoxProgramCommand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxProgramCommand.Size = new System.Drawing.Size(518, 112);
			this.textBoxProgramCommand.TabIndex = 4;
			this.textBoxProgramCommand.TextChanged += new System.EventHandler(this.textBoxProgramCommand_TextChanged);
			// 
			// labelV2Program
			// 
			this.labelV2Program.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.labelV2Program.AutoSize = true;
			this.labelV2Program.Location = new System.Drawing.Point(192, 3);
			this.labelV2Program.Name = "labelV2Program";
			this.labelV2Program.Size = new System.Drawing.Size(93, 13);
			this.labelV2Program.TabIndex = 2;
			this.labelV2Program.Text = "A kiadott parancs:";
			// 
			// buttonObuProgramming
			// 
			this.buttonObuProgramming.Location = new System.Drawing.Point(8, 48);
			this.buttonObuProgramming.Name = "buttonObuProgramming";
			this.buttonObuProgramming.Size = new System.Drawing.Size(131, 23);
			this.buttonObuProgramming.TabIndex = 1;
			this.buttonObuProgramming.Text = "OBU Programozás";
			this.buttonObuProgramming.UseVisualStyleBackColor = true;
			this.buttonObuProgramming.Click += new System.EventHandler(this.buttonObuProgramming_Click);
			// 
			// buttonV2programming
			// 
			this.buttonV2programming.Location = new System.Drawing.Point(8, 19);
			this.buttonV2programming.Name = "buttonV2programming";
			this.buttonV2programming.Size = new System.Drawing.Size(131, 23);
			this.buttonV2programming.TabIndex = 0;
			this.buttonV2programming.Text = "V2 Programozás";
			this.buttonV2programming.UseVisualStyleBackColor = true;
			this.buttonV2programming.Click += new System.EventHandler(this.buttonV2programming_Click);
			// 
			// tabPageSettings
			// 
			this.tabPageSettings.Controls.Add(this.textBoxAtmelProgrammerPath);
			this.tabPageSettings.Controls.Add(this.textBoxAtmelProgrammerStandardInformation);
			this.tabPageSettings.Controls.Add(this.buttonAtmelProgrammerSetting);
			this.tabPageSettings.Controls.Add(this.labelPickAtmelProgrammer);
			this.tabPageSettings.Location = new System.Drawing.Point(4, 22);
			this.tabPageSettings.Name = "tabPageSettings";
			this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSettings.Size = new System.Drawing.Size(750, 369);
			this.tabPageSettings.TabIndex = 1;
			this.tabPageSettings.Text = "Beállítások";
			this.tabPageSettings.UseVisualStyleBackColor = true;
			// 
			// textBoxAtmelProgrammerPath
			// 
			this.textBoxAtmelProgrammerPath.Location = new System.Drawing.Point(122, 25);
			this.textBoxAtmelProgrammerPath.Multiline = true;
			this.textBoxAtmelProgrammerPath.Name = "textBoxAtmelProgrammerPath";
			this.textBoxAtmelProgrammerPath.Size = new System.Drawing.Size(502, 54);
			this.textBoxAtmelProgrammerPath.TabIndex = 5;
			this.textBoxAtmelProgrammerPath.Text = "--AtmelProgrammerPath--";
			// 
			// textBoxAtmelProgrammerStandardInformation
			// 
			this.textBoxAtmelProgrammerStandardInformation.Enabled = false;
			this.textBoxAtmelProgrammerStandardInformation.Location = new System.Drawing.Point(28, 94);
			this.textBoxAtmelProgrammerStandardInformation.Multiline = true;
			this.textBoxAtmelProgrammerStandardInformation.Name = "textBoxAtmelProgrammerStandardInformation";
			this.textBoxAtmelProgrammerStandardInformation.Size = new System.Drawing.Size(596, 60);
			this.textBoxAtmelProgrammerStandardInformation.TabIndex = 4;
			this.textBoxAtmelProgrammerStandardInformation.Text = resources.GetString("textBoxAtmelProgrammerStandardInformation.Text");
			// 
			// buttonAtmelProgrammerSetting
			// 
			this.buttonAtmelProgrammerSetting.Location = new System.Drawing.Point(28, 56);
			this.buttonAtmelProgrammerSetting.Name = "buttonAtmelProgrammerSetting";
			this.buttonAtmelProgrammerSetting.Size = new System.Drawing.Size(75, 23);
			this.buttonAtmelProgrammerSetting.TabIndex = 2;
			this.buttonAtmelProgrammerSetting.Text = "Módosítás";
			this.buttonAtmelProgrammerSetting.UseVisualStyleBackColor = true;
			this.buttonAtmelProgrammerSetting.Click += new System.EventHandler(this.buttonAtmelProgrammerSetting_Click);
			// 
			// labelPickAtmelProgrammer
			// 
			this.labelPickAtmelProgrammer.AutoSize = true;
			this.labelPickAtmelProgrammer.Location = new System.Drawing.Point(25, 28);
			this.labelPickAtmelProgrammer.Name = "labelPickAtmelProgrammer";
			this.labelPickAtmelProgrammer.Size = new System.Drawing.Size(91, 13);
			this.labelPickAtmelProgrammer.TabIndex = 0;
			this.labelPickAtmelProgrammer.Text = "Atmel programozó";
			// 
			// tabPageCalculator
			// 
			this.tabPageCalculator.Controls.Add(this.tableLayoutPanel1);
			this.tabPageCalculator.Location = new System.Drawing.Point(4, 22);
			this.tabPageCalculator.Name = "tabPageCalculator";
			this.tabPageCalculator.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageCalculator.Size = new System.Drawing.Size(750, 369);
			this.tabPageCalculator.TabIndex = 4;
			this.tabPageCalculator.Text = "Számológép";
			this.tabPageCalculator.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.labelConstCalculatorDec, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.labelConstCalculatorHex, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.labelConstCalculatorBinary, 0, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(117, 71);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
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
			// labelConstCalculatorHex
			// 
			this.labelConstCalculatorHex.AutoSize = true;
			this.labelConstCalculatorHex.Location = new System.Drawing.Point(3, 34);
			this.labelConstCalculatorHex.Name = "labelConstCalculatorHex";
			this.labelConstCalculatorHex.Size = new System.Drawing.Size(75, 13);
			this.labelConstCalculatorHex.TabIndex = 1;
			this.labelConstCalculatorHex.Text = "Hexadecimális";
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
			this.készítetteToolStripMenuItem.Text = "Névjegy";
			this.készítetteToolStripMenuItem.Click += new System.EventHandler(this.készítetteToolStripMenuItem_Click);
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
			this.serialPortDevice.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortDevice_DataReceived);
			// 
			// timerProgressBar
			// 
			this.timerProgressBar.Interval = 1000;
			this.timerProgressBar.Tick += new System.EventHandler(this.timerProgressBar_Tick);
			// 
			// timerFwUpdateActualSec
			// 
			this.timerFwUpdateActualSec.Interval = 1000;
			this.timerFwUpdateActualSec.Tick += new System.EventHandler(this.timerFwUpdateActualSec_Tick);
			// 
			// notifyIconApplication
			// 
			this.notifyIconApplication.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconApplication.Icon")));
			this.notifyIconApplication.Text = "JarKonDevApplication";
			this.notifyIconApplication.Visible = true;
			// 
			// JarKonDevApplication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 421);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(400, 350);
			this.Name = "JarKonDevApplication";
			this.Text = "JarKonDevApplication";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JarKonDevApplication_FormClosing);
			this.Load += new System.EventHandler(this.FormJarKonApplicationMain_Load);
			this.tabControl.ResumeLayout(false);
			this.tabSerialPort.ResumeLayout(false);
			this.tabSerialPort.PerformLayout();
			this.tabControlSerialFunctions.ResumeLayout(false);
			this.tabPageSerialCommands.ResumeLayout(false);
			this.tabPageSerialCommands.PerformLayout();
			this.tabPageSerialFwUpdate.ResumeLayout(false);
			this.tabPageSerialFwUpdate.PerformLayout();
			this.tabPageV2programming.ResumeLayout(false);
			this.tabPageV2programming.PerformLayout();
			this.tabPageSettings.ResumeLayout(false);
			this.tabPageSettings.PerformLayout();
			this.tabPageCalculator.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.TabPage tabPageV2programming;
        private System.Windows.Forms.Button buttonV2programming;
        private System.Windows.Forms.Button buttonObuProgramming;
        private System.Windows.Forms.Label labelV2Program;
        private System.Windows.Forms.TextBox textBoxProgramCommand;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem v2ProgramFájlBeállításaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxProgramOutput;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Button buttonTastaProgramming;
        private System.Windows.Forms.Button buttonAccelerometerProgramming;
		private System.Windows.Forms.Button buttonFuelTransformerProgramming;
		private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem névjegyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem készítetteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem segítségToolStripMenuItem;
		private System.Windows.Forms.ProgressBar progressBarProgramming;
		private System.Windows.Forms.Label labelProgrammerGroupST;
		private System.Windows.Forms.Label labelProgrammerGroupCortex;
		private System.Windows.Forms.Label labelProgrammerGroupv2ObuMk2;
		private System.Windows.Forms.Label labelPickAtmelProgrammer;
		private System.Windows.Forms.Button buttonAtmelProgrammerSetting;
		private System.Windows.Forms.TextBox textBoxAtmelProgrammerStandardInformation;
		private System.Windows.Forms.TextBox textBoxAtmelProgrammerPath;
		private System.Windows.Forms.TabPage tabSerialPort;
		private System.Windows.Forms.RichTextBox richTextBoxSerialPortTexts;
		private System.Windows.Forms.Button buttonSerialPortOpen;
		private System.Windows.Forms.ComboBox comboBoxSerialPortCOM;
		private System.Windows.Forms.CheckBox checkBoxSerialPortLog;
		private System.IO.Ports.SerialPort serialPortDevice;
		private System.Windows.Forms.ComboBox comboBoxSerialPortBaudrate;
		private System.Windows.Forms.Button buttonSerialPortSend;
		private System.Windows.Forms.TextBox textBoxSerialSendMessage;
		private System.Windows.Forms.ComboBox comboBoxSerialPortLastCommands;
		private System.Windows.Forms.Button buttonSerialPortRefresh;
		private System.Windows.Forms.Label labelLastCommands;
		private System.Windows.Forms.Label labelFavouriteCommands;
		private System.Windows.Forms.CheckBox checkBoxSerialPortScrollBottom;
		private System.Windows.Forms.CheckBox checkBoxSerialCopySelected;
		private System.Windows.Forms.Button buttonCommand2;
		private System.Windows.Forms.Button buttonCommand1;
		private System.Windows.Forms.Timer timerProgressBar;
		private System.Windows.Forms.Button buttonFwUpdateStart;
		private System.Windows.Forms.TextBox textBoxFWupdateVersionName;
		private System.Windows.Forms.Label labelActualFwUpdateState;
		private System.Windows.Forms.Label labelFwUpdateNeedTime;
		private System.Windows.Forms.TextBox textBoxTimeWaitBetweenSending;
		private System.Windows.Forms.TextBox textBoxTimeWaitResponse;
		private System.Windows.Forms.Label labelTimeWaitBetweenSending;
		private System.Windows.Forms.Label labelTimeWaitResponse;
		private System.Windows.Forms.Label labelConstTextCompleteTime;
		private System.Windows.Forms.Label labelConstTextActualPage;
		private System.Windows.Forms.Label labelConstTextFwUpdateMaxPageError;
		private System.Windows.Forms.TextBox textBoxFwUpdateMaxPageErrorNum;
		private System.Windows.Forms.Timer timerFwUpdateActualSec;
		private System.Windows.Forms.Label labelConstTextMs1;
		private System.Windows.Forms.Label labelConstTextMs2;
		private System.Windows.Forms.CheckBox checkBoxSerialHeaderSending;
		private System.Windows.Forms.CheckBox checkBoxSerialTextColouring;
		private System.Windows.Forms.TextBox textBoxSerialTextFind;
		private System.Windows.Forms.Label labelConstTextSearching;
		private System.Windows.Forms.TabControl tabControlSerialFunctions;
		private System.Windows.Forms.TabPage tabPageSerialCommands;
		private System.Windows.Forms.TabPage tabPageSerialFwUpdate;
		private System.Windows.Forms.Label labelConstTextFwUpdateVersion;
		private System.Windows.Forms.Button buttonCommand5;
		private System.Windows.Forms.Button buttonCommand4;
		private System.Windows.Forms.Button buttonCommand3;
		private System.Windows.Forms.TabPage tabPageCalculator;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labelConstCalculatorDec;
		private System.Windows.Forms.Label labelConstCalculatorHex;
		private System.Windows.Forms.Label labelConstCalculatorBinary;
		public System.Windows.Forms.NotifyIcon notifyIconApplication;
    }
}

