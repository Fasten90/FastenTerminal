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
using System.Threading.Tasks;
using System.Windows.Forms;



namespace JarKonLogApplication
{
    public partial class JarKonProgrammer : Form
    {

        // Config
        Config config;
        String configFilePath = @"JarKon\Config.xml";


        public JarKonProgrammer()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {


            // Load config
            if ( ConfigHandler.LoadConfigFromXml(configFilePath, ref config) == true)
			{
				// Successful loaded configs

				textBoxAtmelProgrammerPath.Text = config.AtmelProgrammer;
			}
			else
			{
				// Failed to load configs, create news and save
				config = new Config();
				ConfigHandler.SaveConfigToXml(configFilePath, config);
			}

        }


        private void buttonV2programming_Click(object sender, EventArgs e)
        {
            //v2Programming();
			progressBarProgramming.Value = 0;
			String command = "";
			String output = "";
			textBoxProgramCommandText.Text = "";
			textBoxProgramOutput.Text = "";
			config.v2Program.Programming(this, ref command, ref output, ref config);
			textBoxProgramCommandText.Text += command;
			textBoxProgramOutput.Text += output;

        }


        private void buttonObuProgramming_Click(object sender, EventArgs e)
        {
            //obuProgramming();
			progressBarProgramming.Value = 0;
			String command = "";
			String output = "";
			textBoxProgramCommandText.Text = "";
			textBoxProgramOutput.Text = "";
			config.obuProgram.Programming(this, ref command, ref output, ref config);
			textBoxProgramCommandText.Text += command;
			textBoxProgramOutput.Text += output;
        }


		private void buttonTastaProgramming_Click(object sender, EventArgs e)
		{
			progressBarProgramming.Value = 0;
			String command = "";
			String output = "";
			textBoxProgramCommandText.Text = "";
			textBoxProgramOutput.Text = "";
			config.tasztaProgram.Programming(this, ref command, ref output, ref config);
			textBoxProgramCommandText.Text += command;
			textBoxProgramOutput.Text += output;
		}


		private void buttonAccelerometerProgramming_Click(object sender, EventArgs e)
		{
			progressBarProgramming.Value = 0;
			String command = "";
			String output = "";
			textBoxProgramCommandText.Text = "";
			textBoxProgramOutput.Text = "";
			config.gyorulasProgram.Programming(this, ref command, ref output, ref config);
			textBoxProgramCommandText.Text += command;
			textBoxProgramOutput.Text += output;
		}


		private void buttonAtmelProgrammerSetting_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();


			openFileDialog1.InitialDirectory = @"C:\Program Files\Atmel\Studio\7.0\atbackend\atprogram";
			openFileDialog1.Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*";
			openFileDialog1.FilterIndex = 2;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					String fileName = Path.GetFileNameWithoutExtension(openFileDialog1.SafeFileName);
					String filePath = Path.GetDirectoryName(openFileDialog1.FileName);

					if (fileName != null && filePath != null)
					{
						
						String atmelProgrammerPath = filePath + "\\" + fileName;
						
						config.AtmelProgrammer = atmelProgrammerPath;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Hiba a fájl útvonalának beállítása során\n" + ex.Message);
				}
			}

			textBoxAtmelProgrammerPath.Text = config.AtmelProgrammer;

			// Save config to file
			ConfigHandler.SaveConfigToXml(configFilePath, config);
			
		}

		private void készítetteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Patkánycsúcs, csúcspatkány!", "JarKonProgrammer - Súgó");
		}


		public void AppendTextBox(string value)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
				return;
			}
			//textBox1.Text += value;
		}


		/// <summary>
		/// For change progress bar
		/// </summary>
		/// <param name="value"></param>
		public void ProgressBarChange(int value)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<string>(AppendTextBox), new object[] { value });
				return;
			}
			progressBarProgramming.Value = value*33;
		}

		


		private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}



		/*
        void obuProgramming()
        {
            String command = config.atmelProgramLink;

            String command1 = config.obuProgram.
                + config.obuFuses
                + config.obuProgramFile;

            Programmer program = new Programmer()
            {
                command = command,
                command1 = command1
            };

            textBoxProgramCommandText.Text = command + " " + command1;

            program.Programming(this);

        }
		*/


    }
}
