using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JarKonDevApplication
{

	
    public enum ProgrammerType
    {
        AtmelProgram,
        STprogram
    }
	
	public struct ProgrammerStruct
	{
		public ProgrammerType programmerType;
		public String programmerPath;
	}

    public class ProgrammerConfig
    {
        //public ProgrammerType programmer { set; get;}
		public ProgrammerType programmer { set; get; }
        public String command1 { set; get;}
		public String command2 { set; get; }
        public String command3 { set; get; }
        public String flashFile { set; get;}
		public String eepromFile { set; get; }


		public void ProgrammingProcess(JarKonDevApplication form, ref ProgrammerConfigs config)
        {

			bool success = true;

			String command = GetProgrammerPath(config);
			String parameter = "";

			String outputText = "";

			form.ProgressBarChange(5);


			// Command 1
			if (success == true)
			{ 			
				
				// Command
				parameter = this.command1;

				// Print
				form.AppendCommandTextBox("[1. Flash erase + fuse command]\r\n" + command + " " + parameter + "\r\n");
				form.AppendOutputTextBox("[Flash erase + Fuse]\r\n");
				outputText = "";

				// Run
				success = RunProgrammer(command, parameter, form, ref outputText);
				form.AppendOutputTextBox(outputText);

				form.ProgressBarChange(10);
			}

			

			// Command 2
			// <command> -f "flashfile"
			if (success == true)
			{
				// Command
				parameter = this.command2 + " -f " + "\"" + this.flashFile + "\"";

				// Print
				form.AppendCommandTextBox("[2. Flash programming...\r\n" + command + " " + parameter + "\r\n");
				form.AppendOutputTextBox("[Flash programming...]\r\n");
				outputText = "";

				// Run
				success = RunProgrammer(command, parameter, form, ref outputText);
				form.AppendOutputTextBox(outputText);

				form.ProgressBarChange(20);
			}

			

            // Command 3
			if (success == true)
            {
				// Command
				parameter = this.command3 + " -f " + "\""  + this.eepromFile + "\"";
				
				// Print
				form.AppendCommandTextBox("[3. EEPROM programming...\r\n" + command + " " + parameter + "\r\n");
				form.AppendOutputTextBox("[EEPROM programming...]\r\n");
				outputText = "";

				// Run
				success = RunProgrammer(command, parameter, form, ref outputText);
				form.AppendOutputTextBox(outputText);

				form.ProgressBarChange(90);
            }

			if (success == true)
			{
				// Successful
				Common.PlaySound(@"JarKon\Sounds\ProgrammingSuccessful.wav");
				form.ProgressBarChange(100);

			}
			else
			{
				// Error
				form.AppendOutputTextBox("[Error...]\r\n");
				Common.PlaySound(@"JarKon\Sounds\ProgrammingError.wav");
				form.ProgressBarChange(-1);
			}
			
			return;

        }


		public bool RunProgrammer(String command, String parameter, JarKonDevApplication form, ref String outputText)
        {
			
			///*
			// Work and good, but blocking mode
			Process process = new Process();
			process.StartInfo.FileName = command;
			process.StartInfo.Arguments = parameter;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.CreateNoWindow = true;		// Not create new window
			//process.Start();
			// Exception, if there is no this flashFile
			try
			{
				process.Start();

				// Read the output (or the error)
				string output = process.StandardOutput.ReadToEnd();
				Console.WriteLine(output);
				outputText += output;
				string err = process.StandardError.ReadToEnd();
				Console.WriteLine(err);
				outputText += "\r\n" + err;
				process.WaitForExit();

				if (outputText.IndexOf("Could not find tool.") == -1)
				{
					// Not contain "Could not find tool" string.
					return true; 
				}
				else
				{
					// Contain "Could not find tool" string.
					MessageBox.Show("Hiba! Nem található eszköz! Ellenőrizd a programozó csatlakozását és hogy világít-e!","JarKonProgrammer - Hiba");
					return false;
				}
				
			}
			catch (Exception e)
			{
				Console.WriteLine("Program futtatási gond: " + e.Message);
				MessageBox.Show("Program futtatási gond. Lehet, hogy a fájl nem elérhető.\r\n" + e.Message);
				return false;
			}


			//*/



			//
			/*
			/// http://stackoverflow.com/questions/4291912/process-start-how-to-get-the-output
			/// 
			// ASYNC
            Process process = new Process();
            process.StartInfo.FileName = command;
            process.StartInfo.Arguments = parameter;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardError = true;
			process.StartInfo.CreateNoWindow = true;		// Not create new window
            /// Set your output and error (asynchronous) handlers
			process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
			process.ErrorDataReceived += new DataReceivedEventHandler(OutputHandler);
            /// Start process and handlers
            // Exception, if there is no this flashFile
            try
            {
                process.Start();
		
            }
            catch (Exception e)
            {
                Console.WriteLine("Program futtatási gond: " + e.Message);
                MessageBox.Show("Program futtatási gond. Lehet, hogy a fájl nem érhető.");

				return false;
            }
            process.BeginOutputReadLine();
            process.BeginErrorReadLine();
            //process.WaitForExit();

			return true;

			//
			*/
		}


		
        public void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            /// Do your stuff with the output (write to console/log/StringBuilder)
            Console.WriteLine(outLine.Data);
            
            // Unsafe, from other thread, do not use
            //this.textBoxProgramOutput.Text += message;
        
			// Save?
			//formJarKon.AppendOutputTextBox(outLine.Data);

			//outputText += outLine.Data;
        }



		public String GetProgrammerPath (ProgrammerConfigs config)
		{
			if ( this.programmer == ProgrammerType.AtmelProgram)
			{
				return config.AtmelProgrammer;
			}
			else if ( this.programmer == ProgrammerType.STprogram)
			{
				return config.STProgrammer;
			}
			else
			{
				return null;
			}
		}
		

    }


    public class ProgrammerConfigs
    {
        // Program link

        //public String atmelProgramLink = @"C:\Program Files (x86)\Atmel\Atmel Studio 6.2\atbackend\atprogram";
		public String AtmelProgrammer = @"C:\Engineer\AtmelStudio7\7.0\atbackend\atprogram";
		public String STProgrammer = @"";

		/*
		public List<ProgrammerStruct> Programmers = new List<ProgrammerStruct>();
		public ProgrammerConfigs()
		{
			ProgrammerStruct program = new ProgrammerStruct();
			program.programmerType = ProgrammerType.AtmelProgram;
			program.programmerPath = @"C:\Engineer\AtmelStudio7\7.0\atbackend\atprogram";
			Programmers.Add(program);
			program.programmerType = ProgrammerType.STprogram;
			program.programmerPath = @"";
			Programmers.Add(program);
		}
		*/

        //public String stProgramLink = @"";

        public ProgrammerConfig v2Program = new ProgrammerConfig
        {
			//programmer = @"C:\Engineer\AtmelStudio7\7.0\atbackend\atprogram",
			programmer = ProgrammerType.AtmelProgram,
			command1 = @" -t avrispmk2 -i ISP -cl 50khz -d atmega2560 chiperase write -fs --values EFD8FD",
			command2 = @" -t avrispmk2 -i ISP -cl 2mhz -d atmega2560 program -fl --verify",
            command3 = @" -t avrispmk2 -i ISP -cl 2mhz -d atmega2560 program -ee --verify",
			flashFile = @"JarKon\V2\jb294_h2_2560.hex",
			eepromFile = @"JarKon\V2\jb294_h2_2560_eeprom.hex"
        };

        public ProgrammerConfig obuProgram = new ProgrammerConfig
        {
			//programmer = @"C:\Engineer\AtmelStudio7\7.0\atbackend\atprogram",
			programmer = ProgrammerType.AtmelProgram,
			command1 = @" -t avrispmk2 -i ISP -cl 50khz -d atmega2560 chiperase write -fs --values EFD8FD",
			command2 = @" -t avrispmk2 -i ISP -cl 2mhz -d atmega2560 program -fl --verify",
            command3 = @" -t avrispmk2 -i ISP -cl 2mhz -d atmega2560 program -ee --verify",
			flashFile = @"JarKon\OBUfull\OBU_bootloader_flash_1.hex",
			eepromFile = @"JarKon\OBUfull\jo297_OBU_Modified_FullProgram.hex"
        };


		public ProgrammerConfig tasztaProgram = new ProgrammerConfig
		{
			programmer = ProgrammerType.AtmelProgram,
			//programmer = @"C:\Engineer\AtmelStudio7\7.0\atbackend\atprogram",
			command1 = @" -t yyyyyy -i zzz -cl 50khz -d atmega2560 chiperase write -fs --values XXXXXX",
			command2 = @" -t yyyyyy -i zzz -cl 2mhz -d atmega2560 program -fl --verify",
			command3 = @"",
			flashFile = @"JarKon\Taszta\Jarkon-Taszta_v3.elf",
			eepromFile = ""
		};


		public ProgrammerConfig gyorulasProgram = new ProgrammerConfig
		{
			//programmer = @"C:\Engineer\AtmelStudio7\7.0\atbackend\atprogram",
			programmer = ProgrammerType.AtmelProgram,
			command1 = @" -t yyyyyy -i zzz -cl 50khz -d atmega2560 chiperase write -fs --values XXXXXX",
			command2 = @" -t yyyyyy -i zzz -cl 2mhz -d atmega2560 program -fl --verify",
			command3 = @" -t yyyyyy -i zzz -cl 2mhz  -d atmega2560 program -ee --verify",
			flashFile = @"JarKon\Gyorsulas\flash.hex",
			eepromFile = @"JarKon\Gyorsulas\eeprom.hex"
		};


    }


	static class ProgrammerConfigHandler
    {

		static public bool LoadProgrammerConfigFromXml( String ConfigFile, ref ProgrammerConfigs config )
		{

			// Then in some other function.
			//Person person = XmlSerialization.ReadFromXmlFile<Person>("C:\person.txt");
			//List<Person> people = XmlSerialization.ReadFromXmlFile<List<Person>>("C:\people.txt");
			try
			{
				config = XmlSerialization.ReadFromXmlFile<ProgrammerConfigs>(ConfigFile);
				// EXCEPTION: ha nem találja az adott fájlt

				//Log.SendEventLog("Users.xml flashFile loaded succesful.");
				Console.WriteLine("ProgrammerConfigs.xml has loaded.");

				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Failed to load ProgrammerConfigs.xml");
				Console.WriteLine(ex.Message);

				return false;
			}

		}

		static public void SaveProgrammerConfigToXml( String ConfigFile, ProgrammerConfigs config )
		{
			// And then in some function.
			//Person person = new Person() { Name = "Dan", Age = 30; HomeAddress = new Address() { StreetAddress = "123 My St", City = "Regina" }};
			//List<Person> people = GetListOfPeople();
			//XmlSerialization.WriteToXmlFile<Person>("C:\person.txt", person);
			//XmlSerialization.WriteToXmlFile<List<People>>("C:\people.txt", people);
			XmlSerialization.WriteToXmlFile<ProgrammerConfigs>(ConfigFile, config);

			//Log.SendEventLog("Save to xml has been successful.");
			Console.WriteLine("ProgrammerConfigs.xml has saved.");
		}


	}
}
