namespace JarKonApplication
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
			this.tabPageFirmware = new System.Windows.Forms.TabPage();
			this.textBoxAtmelProgrammerPath = new System.Windows.Forms.TextBox();
			this.textBoxAtmelProgrammerStandardInformation = new System.Windows.Forms.TextBox();
			this.buttonAtmelProgrammerSetting = new System.Windows.Forms.Button();
			this.labelPickAtmelProgrammer = new System.Windows.Forms.Label();
			this.tabSerialPort = new System.Windows.Forms.TabPage();
			this.buttonCommand2 = new System.Windows.Forms.Button();
			this.buttonCommand1 = new System.Windows.Forms.Button();
			this.checkBoxSerialCopySelected = new System.Windows.Forms.CheckBox();
			this.checkBoxSerialPortScrollBottom = new System.Windows.Forms.CheckBox();
			this.labelFavouriteCommands = new System.Windows.Forms.Label();
			this.labelLastCommands = new System.Windows.Forms.Label();
			this.buttonSerialPortRefresh = new System.Windows.Forms.Button();
			this.comboBoxSerialPortLastCommands = new System.Windows.Forms.ComboBox();
			this.buttonSerialPortSend = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.comboBoxSerialPortBaudrate = new System.Windows.Forms.ComboBox();
			this.comboBoxSerialPortCOM = new System.Windows.Forms.ComboBox();
			this.checkBoxSerialPortLog = new System.Windows.Forms.CheckBox();
			this.buttonSerialPortOpen = new System.Windows.Forms.Button();
			this.richTextBoxSerialPortTexts = new System.Windows.Forms.RichTextBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.v2ProgramFájlBeállításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.készítetteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.segítségToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.serialPortDevice = new System.IO.Ports.SerialPort(this.components);
			this.timerProgressBar = new System.Windows.Forms.Timer(this.components);
			this.tabControl.SuspendLayout();
			this.tabPageV2programming.SuspendLayout();
			this.tabPageFirmware.SuspendLayout();
			this.tabSerialPort.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabPageV2programming);
			this.tabControl.Controls.Add(this.tabPageFirmware);
			this.tabControl.Controls.Add(this.tabSerialPort);
			this.tabControl.Location = new System.Drawing.Point(0, 27);
			this.tabControl.MinimumSize = new System.Drawing.Size(300, 200);
			this.tabControl.Multiline = true;
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(665, 317);
			this.tabControl.TabIndex = 17;
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
			this.tabPageV2programming.Size = new System.Drawing.Size(657, 291);
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
			this.textBoxProgramOutput.Size = new System.Drawing.Size(441, 130);
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
			this.textBoxProgramCommand.Size = new System.Drawing.Size(437, 112);
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
			// tabPageFirmware
			// 
			this.tabPageFirmware.Controls.Add(this.textBoxAtmelProgrammerPath);
			this.tabPageFirmware.Controls.Add(this.textBoxAtmelProgrammerStandardInformation);
			this.tabPageFirmware.Controls.Add(this.buttonAtmelProgrammerSetting);
			this.tabPageFirmware.Controls.Add(this.labelPickAtmelProgrammer);
			this.tabPageFirmware.Location = new System.Drawing.Point(4, 22);
			this.tabPageFirmware.Name = "tabPageFirmware";
			this.tabPageFirmware.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFirmware.Size = new System.Drawing.Size(657, 291);
			this.tabPageFirmware.TabIndex = 1;
			this.tabPageFirmware.Text = "Beállítások";
			this.tabPageFirmware.UseVisualStyleBackColor = true;
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
			// tabSerialPort
			// 
			this.tabSerialPort.Controls.Add(this.buttonCommand2);
			this.tabSerialPort.Controls.Add(this.buttonCommand1);
			this.tabSerialPort.Controls.Add(this.checkBoxSerialCopySelected);
			this.tabSerialPort.Controls.Add(this.checkBoxSerialPortScrollBottom);
			this.tabSerialPort.Controls.Add(this.labelFavouriteCommands);
			this.tabSerialPort.Controls.Add(this.labelLastCommands);
			this.tabSerialPort.Controls.Add(this.buttonSerialPortRefresh);
			this.tabSerialPort.Controls.Add(this.comboBoxSerialPortLastCommands);
			this.tabSerialPort.Controls.Add(this.buttonSerialPortSend);
			this.tabSerialPort.Controls.Add(this.textBox1);
			this.tabSerialPort.Controls.Add(this.comboBoxSerialPortBaudrate);
			this.tabSerialPort.Controls.Add(this.comboBoxSerialPortCOM);
			this.tabSerialPort.Controls.Add(this.checkBoxSerialPortLog);
			this.tabSerialPort.Controls.Add(this.buttonSerialPortOpen);
			this.tabSerialPort.Controls.Add(this.richTextBoxSerialPortTexts);
			this.tabSerialPort.Location = new System.Drawing.Point(4, 22);
			this.tabSerialPort.Name = "tabSerialPort";
			this.tabSerialPort.Padding = new System.Windows.Forms.Padding(3);
			this.tabSerialPort.Size = new System.Drawing.Size(657, 291);
			this.tabSerialPort.TabIndex = 3;
			this.tabSerialPort.Text = "Soros port";
			this.tabSerialPort.UseVisualStyleBackColor = true;
			// 
			// buttonCommand2
			// 
			this.buttonCommand2.Location = new System.Drawing.Point(472, 179);
			this.buttonCommand2.Name = "buttonCommand2";
			this.buttonCommand2.Size = new System.Drawing.Size(103, 23);
			this.buttonCommand2.TabIndex = 15;
			this.buttonCommand2.Text = "Command2";
			this.buttonCommand2.UseVisualStyleBackColor = true;
			this.buttonCommand2.Click += new System.EventHandler(this.buttonCommand2_Click);
			// 
			// buttonCommand1
			// 
			this.buttonCommand1.Location = new System.Drawing.Point(472, 149);
			this.buttonCommand1.Name = "buttonCommand1";
			this.buttonCommand1.Size = new System.Drawing.Size(103, 23);
			this.buttonCommand1.TabIndex = 14;
			this.buttonCommand1.Text = "Command1";
			this.buttonCommand1.UseVisualStyleBackColor = true;
			this.buttonCommand1.Click += new System.EventHandler(this.buttonCommand1_Click);
			// 
			// checkBoxSerialCopySelected
			// 
			this.checkBoxSerialCopySelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxSerialCopySelected.AutoSize = true;
			this.checkBoxSerialCopySelected.Checked = true;
			this.checkBoxSerialCopySelected.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSerialCopySelected.Location = new System.Drawing.Point(469, 112);
			this.checkBoxSerialCopySelected.Name = "checkBoxSerialCopySelected";
			this.checkBoxSerialCopySelected.Size = new System.Drawing.Size(140, 17);
			this.checkBoxSerialCopySelected.TabIndex = 13;
			this.checkBoxSerialCopySelected.Text = "Kijelölt szöveg másolása";
			this.checkBoxSerialCopySelected.UseVisualStyleBackColor = true;
			// 
			// checkBoxSerialPortScrollBottom
			// 
			this.checkBoxSerialPortScrollBottom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxSerialPortScrollBottom.AutoSize = true;
			this.checkBoxSerialPortScrollBottom.Checked = true;
			this.checkBoxSerialPortScrollBottom.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxSerialPortScrollBottom.Location = new System.Drawing.Point(469, 88);
			this.checkBoxSerialPortScrollBottom.Name = "checkBoxSerialPortScrollBottom";
			this.checkBoxSerialPortScrollBottom.Size = new System.Drawing.Size(78, 17);
			this.checkBoxSerialPortScrollBottom.TabIndex = 12;
			this.checkBoxSerialPortScrollBottom.Text = "Legördülés";
			this.checkBoxSerialPortScrollBottom.UseVisualStyleBackColor = true;
			// 
			// labelFavouriteCommands
			// 
			this.labelFavouriteCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelFavouriteCommands.AutoSize = true;
			this.labelFavouriteCommands.Location = new System.Drawing.Point(469, 132);
			this.labelFavouriteCommands.Name = "labelFavouriteCommands";
			this.labelFavouriteCommands.Size = new System.Drawing.Size(106, 13);
			this.labelFavouriteCommands.TabIndex = 10;
			this.labelFavouriteCommands.Text = "Kedvenc parancsok:";
			// 
			// labelLastCommands
			// 
			this.labelLastCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.labelLastCommands.AutoSize = true;
			this.labelLastCommands.Location = new System.Drawing.Point(489, 245);
			this.labelLastCommands.Name = "labelLastCommands";
			this.labelLastCommands.Size = new System.Drawing.Size(134, 13);
			this.labelLastCommands.TabIndex = 9;
			this.labelLastCommands.Text = "Utoljára kiadott parancsok:";
			// 
			// buttonSerialPortRefresh
			// 
			this.buttonSerialPortRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSerialPortRefresh.Location = new System.Drawing.Point(557, 7);
			this.buttonSerialPortRefresh.Name = "buttonSerialPortRefresh";
			this.buttonSerialPortRefresh.Size = new System.Drawing.Size(90, 23);
			this.buttonSerialPortRefresh.TabIndex = 8;
			this.buttonSerialPortRefresh.Text = "Port Frissítés";
			this.buttonSerialPortRefresh.UseVisualStyleBackColor = true;
			this.buttonSerialPortRefresh.Click += new System.EventHandler(this.buttonSerialPortRefresh_Click);
			// 
			// comboBoxSerialPortLastCommands
			// 
			this.comboBoxSerialPortLastCommands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxSerialPortLastCommands.Enabled = false;
			this.comboBoxSerialPortLastCommands.FormattingEnabled = true;
			this.comboBoxSerialPortLastCommands.Location = new System.Drawing.Point(492, 263);
			this.comboBoxSerialPortLastCommands.Name = "comboBoxSerialPortLastCommands";
			this.comboBoxSerialPortLastCommands.Size = new System.Drawing.Size(155, 21);
			this.comboBoxSerialPortLastCommands.TabIndex = 7;
			// 
			// buttonSerialPortSend
			// 
			this.buttonSerialPortSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSerialPortSend.Location = new System.Drawing.Point(410, 265);
			this.buttonSerialPortSend.Name = "buttonSerialPortSend";
			this.buttonSerialPortSend.Size = new System.Drawing.Size(75, 23);
			this.buttonSerialPortSend.TabIndex = 6;
			this.buttonSerialPortSend.Text = "Küldés";
			this.buttonSerialPortSend.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox1.Location = new System.Drawing.Point(9, 265);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(395, 20);
			this.textBox1.TabIndex = 5;
			// 
			// comboBoxSerialPortBaudrate
			// 
			this.comboBoxSerialPortBaudrate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxSerialPortBaudrate.FormattingEnabled = true;
			this.comboBoxSerialPortBaudrate.Items.AddRange(new object[] {
            "115200",
            "9600"});
			this.comboBoxSerialPortBaudrate.Location = new System.Drawing.Point(469, 37);
			this.comboBoxSerialPortBaudrate.Name = "comboBoxSerialPortBaudrate";
			this.comboBoxSerialPortBaudrate.Size = new System.Drawing.Size(82, 21);
			this.comboBoxSerialPortBaudrate.TabIndex = 4;
			this.comboBoxSerialPortBaudrate.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPortBaudrate_SelectedIndexChanged);
			// 
			// comboBoxSerialPortCOM
			// 
			this.comboBoxSerialPortCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBoxSerialPortCOM.FormattingEnabled = true;
			this.comboBoxSerialPortCOM.Location = new System.Drawing.Point(469, 7);
			this.comboBoxSerialPortCOM.Name = "comboBoxSerialPortCOM";
			this.comboBoxSerialPortCOM.Size = new System.Drawing.Size(82, 21);
			this.comboBoxSerialPortCOM.TabIndex = 3;
			this.comboBoxSerialPortCOM.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPortCOM_SelectedIndexChanged);
			// 
			// checkBoxSerialPortLog
			// 
			this.checkBoxSerialPortLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.checkBoxSerialPortLog.AutoSize = true;
			this.checkBoxSerialPortLog.Enabled = false;
			this.checkBoxSerialPortLog.Location = new System.Drawing.Point(469, 64);
			this.checkBoxSerialPortLog.Name = "checkBoxSerialPortLog";
			this.checkBoxSerialPortLog.Size = new System.Drawing.Size(44, 17);
			this.checkBoxSerialPortLog.TabIndex = 2;
			this.checkBoxSerialPortLog.Text = "Log";
			this.checkBoxSerialPortLog.UseVisualStyleBackColor = true;
			// 
			// buttonSerialPortOpen
			// 
			this.buttonSerialPortOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSerialPortOpen.Location = new System.Drawing.Point(557, 36);
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
			this.richTextBoxSerialPortTexts.Size = new System.Drawing.Size(454, 251);
			this.richTextBoxSerialPortTexts.TabIndex = 0;
			this.richTextBoxSerialPortTexts.Text = "";
			this.richTextBoxSerialPortTexts.SelectionChanged += new System.EventHandler(this.richTextBoxSerialPortTexts_SelectionChanged);
			this.richTextBoxSerialPortTexts.TextChanged += new System.EventHandler(this.richTextBoxSerialPortTexts_TextChanged);
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
			// JarKonDevApplication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(663, 343);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(400, 350);
			this.Name = "JarKonDevApplication";
			this.Text = "JarKonDevApplication";
			this.Load += new System.EventHandler(this.FormJarKonApplicationMain_Load);
			this.tabControl.ResumeLayout(false);
			this.tabPageV2programming.ResumeLayout(false);
			this.tabPageV2programming.PerformLayout();
			this.tabPageFirmware.ResumeLayout(false);
			this.tabPageFirmware.PerformLayout();
			this.tabSerialPort.ResumeLayout(false);
			this.tabSerialPort.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageFirmware;
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
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBoxSerialPortLastCommands;
		private System.Windows.Forms.Button buttonSerialPortRefresh;
		private System.Windows.Forms.Label labelLastCommands;
		private System.Windows.Forms.Label labelFavouriteCommands;
		private System.Windows.Forms.CheckBox checkBoxSerialPortScrollBottom;
		private System.Windows.Forms.CheckBox checkBoxSerialCopySelected;
		private System.Windows.Forms.Button buttonCommand2;
		private System.Windows.Forms.Button buttonCommand1;
		private System.Windows.Forms.Timer timerProgressBar;
    }
}

