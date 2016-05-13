using JarKonApplication;
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



namespace JarKonApplication
{
    public partial class JarKonDevApplication : Form
    {

        // ProgrammerConfigs
        ProgrammerConfigs config;
        String configFilePath = @"JarKon\ProgrammerConfigs.xml";

		public JarKonSerial serial;

		CommandHandler command;

		List<Button> commandListOnButtons;

		FwUpdate fwUpdate;

		public bool FwUpdateWaitMessage;


        public JarKonDevApplication()
        {
            InitializeComponent();
        }


        private void FormJarKonApplicationMain_Load(object sender, EventArgs e)
        {


            // Load config
            if ( ProgrammerConfigHandler.LoadProgrammerConfigFromXml(configFilePath, ref config) == true)
			{
				// Successful loaded configs

				textBoxAtmelProgrammerPath.Text = config.AtmelProgrammer;
			}
			else
			{
				// Failed to load configs, create news and save
				config = new ProgrammerConfigs();
				ProgrammerConfigHandler.SaveProgrammerConfigToXml(configFilePath, config);
			}

			// Load Serial
			serial = new JarKonSerial(serialPortDevice, this);
			serial.NeedLog = checkBoxSerialPortLog.Checked;
			comboBoxSerialPortBaudrate.SelectedIndex = 0;

			// Load commands
			command = new CommandHandler(this);
			LoadCommandsToButtons();

        }


        private void buttonV2programming_Click(object sender, EventArgs e)
        {

			progressBarProgramming.Value = 0;

			Thread t = new Thread(() => config.v2Program.ProgrammingProcess(this, ref config));
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
			config.obuProgram.ProgrammingProcess(this, ref command, ref output, ref config);
			textBoxProgramCommand.Text += command;
			textBoxProgramOutput.Text += output;
			*/

			progressBarProgramming.Value = 0;

			//Thread t = new Thread(new ParameterizedThreadStart(config.obuProgram.ProgrammingProcess));		
			//t.Start(this, ref command, ref output, ref config);

			// Lambda
			Thread t = new Thread(() => config.obuProgram.ProgrammingProcess(this, ref config));
			t.Start();

			// Wait for this thread
			//t.Join();

        }


		private void buttonTastaProgramming_Click(object sender, EventArgs e)
		{

			progressBarProgramming.Value = 0;

			Thread t = new Thread(() => config.tasztaProgram.ProgrammingProcess(this, ref config));
			t.Start();
		}


		private void buttonAccelerometerProgramming_Click(object sender, EventArgs e)
		{

			progressBarProgramming.Value = 0;

			Thread t = new Thread(() => config.gyorulasProgram.ProgrammingProcess(this, ref config));
			t.Start();
		}


		private void buttonAtmelProgrammerSetting_Click(object sender, EventArgs e)
		{
			
			AtmelProgrammerSetting();
	
		}

		private void AtmelProgrammerSetting()
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
			ProgrammerConfigHandler.SaveProgrammerConfigToXml(configFilePath, config);
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

			// Nem elegáns megoldás, de ideiglenesen egész jó
			if (value == 20)
			{
				timerProgressBar.Enabled = true;
				timerProgressBar.Start();
			}
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

		private void buttonSerialPortRefresh_Click(object sender, EventArgs e)
		{
			SerialRefresh();
		}


		private void SerialRefresh()
		{
			serial.SerialPortComRefresh();

			if (serial.ComAvailableList != null && serial.ComAvailableList.Length != 0) 
			{
				foreach (string s in serial.ComAvailableList)
				{
					comboBoxSerialPortCOM.Items.Add(s);
				}

				comboBoxSerialPortCOM.SelectedIndex = 0;

			}


			// Wrong
			//comboBoxSerialPortCOM.DataSource = serial.ComAvailableList;
		}

		private void buttonSerialPortOpen_Click(object sender, EventArgs e)
		{
			SerialOpenClose();
		}

		private void SerialOpenClose()
		{
			if (serial.isOpenedPort == false)
			{
				// If not opened
				if (serial.SerialPortComOpen())
				{
					buttonSerialPortOpen.Text = "Port bezárása";
				}

			}
			else
			{
				// If opened
				serial.SerialPortComClose();
				buttonSerialPortOpen.Text = "Port nyitás";
			}
			

		}


		private void comboBoxSerialPortCOM_SelectedIndexChanged(object sender, EventArgs e)
		{
			serial.SetComSelected((string)comboBoxSerialPortCOM.SelectedItem);
		}

		private void comboBoxSerialPortBaudrate_SelectedIndexChanged(object sender, EventArgs e)
		{
			serial.SetBaudrateSelected((string)comboBoxSerialPortBaudrate.SelectedItem);
		}

		private void serialPortDevice_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		{
			SerialDataReceived();
		}



		private void SerialDataReceived()
		{
			serial.DataReceived();
		}



		public void AppendTextSerialData( string value)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<string>(AppendTextSerialData), new object[] { value });
				return;
			}

			richTextBoxSerialPortTexts.Text += value;

		}


		public void AppendFwUpdateState( string value)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<string>(AppendFwUpdateState), new object[] { value });
				return;
			}

			labelActualFwUpdateState.Text = value;

		}
		
		public void AppendFwUpdateEndTime( string value)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<string>(AppendFwUpdateEndTime), new object[] { value });
				return;
			}

			labelFwUpdateNeedTime.Text = value;

		}
		


		private void richTextBoxSerialPortTexts_TextChanged(object sender, EventArgs e)
		{

			if ( checkBoxSerialPortScrollBottom.Checked)
			{
				// set the current caret position to the end
				richTextBoxSerialPortTexts.SelectionStart = richTextBoxSerialPortTexts.Text.Length;
				// scroll it automatically
				richTextBoxSerialPortTexts.ScrollToCaret();
			}

		}



		public void LoadCommandsToButtons()
		{
			List<Command> commandList = command.GetCommands();

			commandListOnButtons = new List<Button>();

			// Add buttons
			commandListOnButtons.Add(buttonCommand1);
			commandListOnButtons.Add(buttonCommand2);

			int i = 0;
			foreach (var item in commandList)
			{
				// Lépegetés a gombokon
				commandListOnButtons[i].Text = item.CommandName;
				i++;
				if (i >= commandListOnButtons.Count)
				{
					break;
				}
			}
			
		}



		private void buttonCommand1_Click(object sender, EventArgs e)
		{
			command.SendCommand(((Button)sender).Text, CommandSourceType.Serial);
		}



		private void buttonCommand2_Click(object sender, EventArgs e)
		{
			command.SendCommand(((Button)sender).Text, CommandSourceType.Serial);
		}



		private void timerProgressBar_Tick(object sender, EventArgs e)
		{
			// Progress bar
			// 30 sec all time
			// ( 100-20 ) / 30 = 80/30 =~ 80/40 = 2
			
			if ( progressBarProgramming.Value >= 100 )
			{
				progressBarProgramming.Enabled = false;
			}
			else
			{
				progressBarProgramming.Value += 2;
			}
		}



		private void richTextBoxSerialPortTexts_SelectionChanged(object sender, EventArgs e)
		{
			// Copy is enabled
			if ( checkBoxSerialCopySelected.Checked)
			{
				// Copy the selected text to the Clipboard.

				if(richTextBoxSerialPortTexts.SelectionLength > 0)
				{			
					richTextBoxSerialPortTexts.Copy();

					// TODO: Copy to textbox?
					if (richTextBoxSerialPortTexts.SelectedText.Length < 1000 )
					{
						Console.WriteLine("Copied texts: " + richTextBoxSerialPortTexts.SelectedText);
					}
					else
					{
						Console.WriteLine("Copied long text to clipboard.");
					}
					
					// TODO: show message? (notify, notification)
				}
				
			}
			
		}

		private void buttonFwUpdate_Click(object sender, EventArgs e)
		{
			if ( fwUpdate == null)
			{
				// There is no fwUpdate
				int waitResponseTime = Int32.Parse(textBoxTimeWaitResponse.Text);				// TODO: EXCEPTION
				int waitBetweenSendignTime = Int32.Parse(textBoxTimeWaitBetweenSending.Text);	// TODO: EXCEPTION
				int maximumPageErrorNum = Int32.Parse(textBoxFwUpdateMaxPageErrorNum.Text);		// TODO: EXCEPTION
				fwUpdate = new FwUpdate("LidlOS.hex", textBoxFWupdateVersionName.Text,
					serial, this, waitBetweenSendignTime, waitResponseTime, maximumPageErrorNum);

				//timerFwUpdateActualSec = new System.Windows.Forms.Timer();
				timerFwUpdateActualSec.Enabled = true;
				timerFwUpdateActualSec.Start();
				

				buttonFwUpdateStart.Text = "FW Stop";
				Log.SendEventLog("FwUpdate started");
			}
			else
			{
				//if (fwUpdate != null)
				fwUpdate.FwUpdateStop();
				fwUpdate = null;

				timerFwUpdateActualSec.Stop();

				buttonFwUpdateStart.Text = "FW Update ";
				Log.SendEventLog("FwUpdate stopped");
			}

		}



		private void buttonSerialPortSend_Click(object sender, EventArgs e)
		{
			if ( textBoxSerialSendMessage.Text != null)
			{
				serial.SendMessage(textBoxSerialSendMessage.Text);
			}
			
		}



		internal void CheckFwUpateMessageAndSend(string value)
		{
			if (InvokeRequired)
			{
				this.Invoke(new Action<string>(CheckFwUpateMessageAndSend), new object[] { value });
				return;
			}

			if ( FwUpdateWaitMessage == true && fwUpdate != null)
			{
				if ( value.Contains("FWUP"))
				{
					fwUpdate.ReceivedAnMessage(value);
				}
			}
		}



		private void JarKonDevApplication_FormClosing(object sender, FormClosingEventArgs e)
		{
			// Close serial
			serial.SerialPortComClose();

		}



		private void timerFwUpdateActualSec_Tick(object sender, EventArgs e)
		{
			if (fwUpdate != null)
			{
				fwUpdate.ActualSecIncrease();

				var span = new TimeSpan(0, 0, fwUpdate.ActualFwUpdateTimeSeconds); //Or TimeSpan.FromSeconds(seconds); (see Jakob C´s answer)
				var actualTime = string.Format("{0}:{1:00}",
								(int)span.TotalMinutes,
								span.Seconds);

				span = new TimeSpan(0, 0, fwUpdate.NeedFwUpdateTimeSeconds); //Or TimeSpan.FromSeconds(seconds); (see Jakob C´s answer)
				var needlTime = string.Format("{0}:{1:00}",
								(int)span.TotalMinutes,
								span.Seconds);

				AppendFwUpdateEndTime(actualTime + " / " + needlTime);
			}
		}

		private void checkBoxSerialPortLog_CheckedChanged(object sender, EventArgs e)
		{
			serial.NeedLog = checkBoxSerialPortLog.Checked;
		}


	}
}
