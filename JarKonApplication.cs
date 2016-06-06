using JarKonDevApplication;
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



namespace JarKonDevApplication
{
    public partial class JarKonDevApplication : Form
    {

        // ProgrammerConfigs
        ProgrammerConfigs config;
        String configFilePath = @"JarKon\ProgrammerConfigs.xml";
		// TODO: átrakni a configFile-t

		public Serial serial;

		public CommandHandler command;

		List<Button> commandListOnButtons;

		//public BindingSource commandList;
		public List<Command> commandList;

		FwUpdate fwUpdate;

		public bool FwUpdateWaitMessage;



		const String SerialHeader = "!";	// TODO: delete


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
			serial = new Serial(serialPortDevice, this);
			serial.NeedLog = checkBoxSerialPortLog.Checked;
			comboBoxSerialPortBaudrate.SelectedIndex = 0;

			SerialRefresh();

			// Load commands
			command = new CommandHandler(this);
			LoadCommandsToButtons();

			LoadCommandsToSetting();


			// Message Header type
			LoadMessageHeaders();

			// Notify
			notifyIconApplication.Visible = true;  
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
			// Clicked "Atmel program setting" button
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

			// Nem elegáns megoldás, de ideiglenesen egész jó
			if (value == 20)
			{
				timerProgressBar.Enabled = true;
				timerProgressBar.Start();
			}
			else if (value == 100)
			{
				// Sikeres programozás
				MessageForUser("Sikeres programozás!");
			}
			else if (value == -1)
			{
				MessageForUser("Hiba! Sikertelen programozás!");
				value = 0;
				timerProgressBar.Enabled = false;
				timerProgressBar.Stop();
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


		private void timerProgressBar_Tick(object sender, EventArgs e)
		{
			// Progress bar
			// 30 sec all time
			// ( 100-20 ) / 30 = 80/30 =~ 80/40 = 2

			if (progressBarProgramming.Value >= 100)
			{
				progressBarProgramming.Enabled = false;
			}
			else
			{
				progressBarProgramming.Value += 2;
			}
		}


		////////////////////////////////////////////////
		//			 SERIAL
		////////////////////////////////////////////////


		private void buttonSerialPortRefresh_Click(object sender, EventArgs e)
		{
			// Clicked "Serial Refresh" button
			SerialRefresh();
		}


		private void SerialRefresh()
		{
			// Refresh Serial COM ports
			serial.SerialPortComRefresh();

			if (serial.ComAvailableList != null && serial.ComAvailableList.Length != 0) 
			{
				// Clear
				comboBoxSerialPortCOM.Items.Clear();

				// Load new values
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

			// Original text appending, It Work!!
			//richTextBoxSerialPortTexts.Text += value;

			// Coloring:
			// ESC[39mESC[31m
			//0x1B
			//const char ESC = '\x1B';
			//(char)27).ToString());

			Color textColor = Color.Black;

			// Contain escape
			if (value.StartsWith(((char)27).ToString()))
			{
				if (checkBoxSerialTextColouring.Checked)
				{
					// Checked coloring
					textColor = GetColor(value);
				}
				else
				{
					// Standard color
				}

				// Substring after ESC
				String textWithoutEscape = value.Substring(10);			// TODO: Elegánsabban kéne kivenni az ESC[... részt
				value = textWithoutEscape;
				
				//richTextBoxSerialPortTexts.SelectionColor = textColor;
				//richTextBoxSerialPortTexts.AppendText(value); // If you use it, it automatic scroll bottom
				
				/*
				int startCount = richTextBoxSerialPortTexts.TextLength;
				richTextBoxSerialPortTexts.Text += value;
				richTextBoxSerialPortTexts.Select(startCount, value.Length);
				richTextBoxSerialPortTexts.SelectionColor = textColor;
				*/
			}
			else
			{

				//richTextBoxSerialPortTexts.SelectionColor = Color.Black;
				//richTextBoxSerialPortTexts.AppendText(value);

				/*
				int startCount = richTextBoxSerialPortTexts.TextLength;
				richTextBoxSerialPortTexts.Text += value;
				richTextBoxSerialPortTexts.Select(startCount, value.Length);
				richTextBoxSerialPortTexts.SelectionColor = Color.Black;
				*/
			}

			richTextBoxSerialPortTexts.SelectionColor = textColor;
			richTextBoxSerialPortTexts.AppendText(value); // If you use it, it automatic scroll bottom
			
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

			// Add buttons to Command buttons list
			commandListOnButtons.Add(buttonCommand1);
			commandListOnButtons.Add(buttonCommand2);
			commandListOnButtons.Add(buttonCommand3);
			commandListOnButtons.Add(buttonCommand4);
			commandListOnButtons.Add(buttonCommand5);

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


		private void LoadMessageHeaders()
		{
			// Add message headers
			comboBoxSerialHeaderType.Items.Add("!");
			comboBoxSerialHeaderType.Items.Add("BxPgHeader");
		}


		public void LoadCommandsToSetting()
		{
			dataGridViewSettingsFavouriteCommands.AutoGenerateColumns = true;

			// TODO: Not worked...

			//commandList = new List<Command>();

			//commandList = new BindingSource();
			//commandList.DataSource = command.GetCommands();
			//dataGridViewSettingsFavouriteCommands.DataSource =

			commandList = command.GetCommands();
			dataGridViewSettingsFavouriteCommands.DataSource = commandList;

			//dataGridViewSettingsFavouriteCommands.DataSource = command.GetCommands();

			//dataGridViewSettingsFavouriteCommands.DataSource = command.CommandConfig.CommandList;
		}


		// Favourite commands
		private void buttonCommand1_Click(object sender, EventArgs e)
		{
			command.SendCommand(((Button)sender).Text, CommandSourceType.Serial);
		}

		private void buttonCommand2_Click(object sender, EventArgs e)
		{
			command.SendCommand(((Button)sender).Text, CommandSourceType.Serial);
		}

		private void buttonCommand3_Click(object sender, EventArgs e)
		{
			command.SendCommand(((Button)sender).Text, CommandSourceType.Serial);
		}

		private void buttonCommand4_Click(object sender, EventArgs e)
		{
			command.SendCommand(((Button)sender).Text, CommandSourceType.Serial);
		}

		private void buttonCommand5_Click(object sender, EventArgs e)
		{
			command.SendCommand(((Button)sender).Text, CommandSourceType.Serial);
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
			SerialMessageSending();
		}



		private void textBoxSerialSendMessage_KeyPress(object sender, KeyPressEventArgs e)
		{
			// If pressed in "SendMessage textbox" enter --> Send the message
			if (e.KeyChar == (char)Keys.Return)
			{
				// If pressed enter
				SerialMessageSending();
			}
				
		}



		private void SerialMessageSending()
		{
			if (textBoxSerialSendMessage.Text != null)
			{
				String message = "";
				if (checkBoxSerialHeaderSending.Checked)
				{
					// Add header, if need
					message += (String)comboBoxSerialHeaderType.SelectedItem;
				}

				// Append command text
				message += textBoxSerialSendMessage.Text;

				String messageResult = serial.SendMessage(message);

				Log.SendEventLog(messageResult);
				AppendTextSerialData(messageResult);

				Log.SendEventLog(message);
				AppendTextSerialData(message + "\n");

				SerialAddLastCommand(message);
			}
		}



		private void SerialAddLastCommand(String message)
		{
			String command = "";
			

			if (message.StartsWith(SerialHeader))
			{
				// Copied after '!', if it is serial command
				command = message.Substring(1);	// TODO: after serial '!'
			}
			else
			{
				// Copy
				command = message;
			}

			if (comboBoxSerialPortLastCommands.FindString(command) >= 0)
			{
				// We have this command in the list
				// TODO: put to top?
			}
			else
			{
				comboBoxSerialPortLastCommands.Items.Add(command);
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

			// Notify close
			notifyIconApplication.Visible = false;  
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


		/// <summary>
		/// Get color from string (within escape sequences ... ESC[31m...
		/// </summary>
		/// <param name="escapeMessage"></param>
		/// <returns></returns>
		private Color GetColor(String escapeMessage)
		{
			Color textColor = Color.Black;
			if (escapeMessage.Contains("[3"))
			{
				char colorChar = escapeMessage[8];
				switch (colorChar)
				{
						case '0':
						textColor = Color.Black;
						break;
					case '1':
						textColor = Color.Red;
						break;
					case '2':
						textColor = Color.Green;
						break;
					case '3':
						textColor = Color.Yellow;
						break;
					case '4':
						textColor = Color.Blue;
						break;
					case '5':
						textColor = Color.Magenta;
						break;
					case '6':
						textColor = Color.Cyan;
						break;
					case '7':
						textColor = Color.White;
						break;
					default:
						break;
						
				}
			}

			return textColor;

		}

		private void comboBoxSerialPortLastCommands_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Copy clicked text to sending message text
			textBoxSerialSendMessage.Text = (String)comboBoxSerialPortLastCommands.SelectedItem;
		}



		private void textBoxSerialTextFind_KeyPress(object sender, KeyPressEventArgs e)
		{

			// Find, if pressed enter
			if (e.KeyChar == (char)Keys.Return)
			{
				// Pressed enter
				String searchText = textBoxSerialTextFind.Text;
				int searchTextLength = textBoxSerialTextFind.Text.Length;
				int startIndex = 0;

				// Search in log, if not null text
				if (searchTextLength > 0)
				{
					// Not null search string

					// Find
					// TODO: This is the First searched item...
					//int result = richTextBoxSerialPortTexts.Find(searchText);

					// Find
					int result = 1;
					while (( result = richTextBoxSerialPortTexts.Text.IndexOf(searchText, startIndex)) != -1)
					{
						// Founded a string

						// Select founded string

						richTextBoxSerialPortTexts.Select(result, searchTextLength);
						richTextBoxSerialPortTexts.SelectionBackColor = Color.Yellow;

						startIndex = result + searchTextLength;
					}
				}
			}
				
		}


		/// <summary>
		/// Notify on taskbar
		/// </summary>
		/// <param name="message"></param>
		private void MessageForUser(String message)
		{

			notifyIconApplication.BalloonTipText = message;
			//notifyIconForParent.Text = message;   // Ikon neve
			notifyIconApplication.BalloonTipTitle = "FastenDev";
			notifyIconApplication.ShowBalloonTip(1000);
		}


		////////////////////////////////
		// Calculator
		////////////////////////////////

		public enum CalculateType
		{
			Decimal,
			Hexadecimal,
			Binary
		}


		private void textBoxCalculatorDec_KeyPress(object sender, KeyPressEventArgs e)
		{
			// If pressed in enter
			if (e.KeyChar == (char)Keys.Return)
			{
				// If pressed enter
				Calculate(CalculateType.Decimal);
			}
		}

		private void Calculate(CalculateType calculateType)
		{
			// Calculate

			switch(calculateType)
			{
				case CalculateType.Decimal:

					Int32 value = Int32.Parse(textBoxCalculatorDec.Text);
					textBoxCalculatorHex.Text = value.ToString("X2");	// "x" is good
					break;

					// TODO:...
			}
		}

		private void buttonSettingsFavCommandsRefresh_Click(object sender, EventArgs e)
		{
			LoadCommandsToSetting();
		}



	}
}
