namespace JarKonLogApplication
{
    partial class JarKonProgrammer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JarKonProgrammer));
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
			this.textBoxProgramCommandText = new System.Windows.Forms.TextBox();
			this.labelV2Program = new System.Windows.Forms.Label();
			this.buttonObuProgramming = new System.Windows.Forms.Button();
			this.buttonV2programming = new System.Windows.Forms.Button();
			this.tabPageFirmware = new System.Windows.Forms.TabPage();
			this.textBoxAtmelProgrammerPath = new System.Windows.Forms.TextBox();
			this.textBoxAtmelProgrammerStandardInformation = new System.Windows.Forms.TextBox();
			this.buttonAtmelProgrammerSetting = new System.Windows.Forms.Button();
			this.labelPickAtmelProgrammer = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.v2ProgramFájlBeállításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.névjegyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.készítetteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.segítségToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.process1 = new System.Diagnostics.Process();
			this.tabControl.SuspendLayout();
			this.tabPageV2programming.SuspendLayout();
			this.tabPageFirmware.SuspendLayout();
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
			this.tabControl.Location = new System.Drawing.Point(0, 27);
			this.tabControl.MinimumSize = new System.Drawing.Size(300, 200);
			this.tabControl.Multiline = true;
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(650, 317);
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
			this.tabPageV2programming.Controls.Add(this.textBoxProgramCommandText);
			this.tabPageV2programming.Controls.Add(this.labelV2Program);
			this.tabPageV2programming.Controls.Add(this.buttonObuProgramming);
			this.tabPageV2programming.Controls.Add(this.buttonV2programming);
			this.tabPageV2programming.Location = new System.Drawing.Point(4, 22);
			this.tabPageV2programming.Name = "tabPageV2programming";
			this.tabPageV2programming.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageV2programming.Size = new System.Drawing.Size(642, 291);
			this.tabPageV2programming.TabIndex = 2;
			this.tabPageV2programming.Text = "Programozás";
			this.tabPageV2programming.UseVisualStyleBackColor = true;
			// 
			// labelProgrammerGroupST
			// 
			this.labelProgrammerGroupST.AutoSize = true;
			this.labelProgrammerGroupST.Location = new System.Drawing.Point(8, 201);
			this.labelProgrammerGroupST.Name = "labelProgrammerGroupST";
			this.labelProgrammerGroupST.Size = new System.Drawing.Size(99, 13);
			this.labelProgrammerGroupST.TabIndex = 14;
			this.labelProgrammerGroupST.Text = "ST Cortex - ST link:";
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
			// textBoxProgramCommandText
			// 
			this.textBoxProgramCommandText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxProgramCommandText.Location = new System.Drawing.Point(195, 19);
			this.textBoxProgramCommandText.MinimumSize = new System.Drawing.Size(100, 20);
			this.textBoxProgramCommandText.Multiline = true;
			this.textBoxProgramCommandText.Name = "textBoxProgramCommandText";
			this.textBoxProgramCommandText.ReadOnly = true;
			this.textBoxProgramCommandText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxProgramCommandText.Size = new System.Drawing.Size(437, 112);
			this.textBoxProgramCommandText.TabIndex = 4;
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
			this.tabPageFirmware.Size = new System.Drawing.Size(642, 291);
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
			this.készítetteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.készítetteToolStripMenuItem.Text = "Névjegy";
			this.készítetteToolStripMenuItem.Click += new System.EventHandler(this.készítetteToolStripMenuItem_Click);
			// 
			// segítségToolStripMenuItem
			// 
			this.segítségToolStripMenuItem.Name = "segítségToolStripMenuItem";
			this.segítségToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.segítségToolStripMenuItem.Text = "Segítség";
			// 
			// process1
			// 
			this.process1.StartInfo.Domain = "";
			this.process1.StartInfo.LoadUserProfile = false;
			this.process1.StartInfo.Password = null;
			this.process1.StartInfo.StandardErrorEncoding = null;
			this.process1.StartInfo.StandardOutputEncoding = null;
			this.process1.StartInfo.UserName = "";
			this.process1.SynchronizingObject = this;
			// 
			// JarKonProgrammer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 343);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(400, 350);
			this.Name = "JarKonProgrammer";
			this.Text = "JarKonProgrammer";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tabControl.ResumeLayout(false);
			this.tabPageV2programming.ResumeLayout(false);
			this.tabPageV2programming.PerformLayout();
			this.tabPageFirmware.ResumeLayout(false);
			this.tabPageFirmware.PerformLayout();
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
        private System.Windows.Forms.TextBox textBoxProgramCommandText;
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
		private System.Diagnostics.Process process1;
		private System.Windows.Forms.ProgressBar progressBarProgramming;
		private System.Windows.Forms.Label labelProgrammerGroupST;
		private System.Windows.Forms.Label labelProgrammerGroupCortex;
		private System.Windows.Forms.Label labelProgrammerGroupv2ObuMk2;
		private System.Windows.Forms.Label labelPickAtmelProgrammer;
		private System.Windows.Forms.Button buttonAtmelProgrammerSetting;
		private System.Windows.Forms.TextBox textBoxAtmelProgrammerStandardInformation;
		private System.Windows.Forms.TextBox textBoxAtmelProgrammerPath;
    }
}

