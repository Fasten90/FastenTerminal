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
using System.Threading;
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

			progressBarProgramming.Value = 0;

			Thread t = new Thread(() => config.v2Program.Programming(this, ref config));
			t.Start();

        }


        private void buttonObuProgramming_Click(object sender, EventArgs e)
        {
			/*
			// Original, work !!
            //obuProgramming();
			progressBarProgramming.Value = 0;
			String command = "";
			String output = "";
			textBoxProgramCommand.Text = "";
			textBoxProgramOutput.Text = "";
			config.obuProgram.Programming(this, ref command, ref output, ref config);
			textBoxProgramCommand.Text += command;
			textBoxProgramOutput.Text += output;
			*/

			progressBarProgramming.Value = 0;

			//Thread t = new Thread(new ParameterizedThreadStart(config.obuProgram.Programming));		
			//t.Start(this, ref command, ref output, ref config);

			// Lambda
			Thread t = new Thread(() => config.obuProgram.Programming(this, ref config));
			t.Start();

			// Wait for this thread
			//t.Join();

        }


		private void buttonTastaProgramming_Click(object sender, EventArgs e)
		{

			progressBarProgramming.Value = 0;

			Thread t = new Thread(() => config.tasztaProgram.Programming(this, ref config));
			t.Start();
		}


		private void buttonAccelerometerProgramming_Click(object sender, EventArgs e)
		{

			progressBarProgramming.Value = 0;

			Thread t = new Thread(() => config.gyorulasProgram.Programming(this, ref config));
			t.Start();
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


		/// <summary>
		/// For output text ++
		/// </summary>
		/// <param name="value"></param>
		public void AppendOutputTextBox(string value)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<string>(AppendOutputTextBox), new object[] { value });
				return;
			}

			textBoxProgramOutput.Text += value;
			//textBoxProgramCommand.Text += command;
			//textBoxProgramOutput.Text += output;
		}


		/// <summary>
		/// For output text ++
		/// </summary>
		/// <param name="value"></param>
		public void AppendCommandTextBox(string value)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<string>(AppendCommandTextBox), new object[] { value });
				return;
			}

			textBoxProgramCommand.Text += value;
			//textBoxProgramCommand.Text += command;
			//textBoxProgramOutput.Text += output;
		}



		/// <summary>
		/// For change progress bar - invoked, thread safe
		/// </summary>
		/// <param name="value"></param>
		public void ProgressBarChange(int value)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<int>(ProgressBarChange), new object[] { value });
				return;
			}
			progressBarProgramming.Value = value;
		}

		


		private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void textBoxProgramCommand_TextChanged(object sender, EventArgs e)
		{
			textBoxProgramCommand.SelectionStart = textBoxProgramCommand.Text.Length;
			textBoxProgramCommand.ScrollToCaret();
		}

		private void textBoxProgramOutput_TextChanged(object sender, EventArgs e)
		{
			textBoxProgramOutput.SelectionStart = textBoxProgramOutput.Text.Length;
			textBoxProgramOutput.ScrollToCaret();
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

            textBoxProgramCommand.Text = command + " " + command1;

            program.Programming(this);

        }
		*/


    }
}
