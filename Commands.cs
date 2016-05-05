using JarKonApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarKonApplication
{
	public class Command
	{
		public String CommandString;
		public String CommandName;
	}


	public class CommandConfigs
	{

		public List<Command> CommandList;


		public CommandConfigs()
		{
			CommandList = new List<Command>();
		}

		public void AddCommand(String command, String name)
		{
			Command addCommand = new Command{
				CommandString = command,
				CommandName = name
			};

			CommandList.Add(addCommand);

		}

	}


	public enum CommandSourceType
	{
		Serial,
		GSM
	}


	public class CommandHandler
	{
		public CommandConfigs CommandConfig;

		private JarKonProgrammer form;

		public CommandHandler(JarKonProgrammer form)
		{
			this.form = form;

			CommandConfig = new CommandConfigs();

			if ( LoadCommandConfigFromXml("CommandConfigs.xml", ref CommandConfig) == true)
			{
				// Successful loaded Commands...

			}
			else
			{
				// Create new
				AddNewCommand("FirstCommand", "FirstCommand");
			}
		}


		public void AddNewCommand(String command, String name)
		{
			CommandConfig.AddCommand(command, name);
			SaveCommandConfigToXml("CommandConfigs.xml", CommandConfig);
		}

		
		public List<Command> GetCommands()
		{
			return CommandConfig.CommandList;
		}


		public void SendCommand(String command, CommandSourceType source)
		{
			// TODO: source... send...
			// Check serial available, check gsm available...

			String message = "Send command: " + command + "\r\n";
			Console.WriteLine(message);
			form.AppendTextSerialData("[Application] " + message);
		}



		public bool LoadCommandConfigFromXml(String ConfigFile, ref CommandConfigs config)
		{

			try
			{
				config = XmlSerialization.ReadFromXmlFile<CommandConfigs>(ConfigFile);
				// EXCEPTION: ha nem találja az adott fájlt

				//Log.SendEventLog("CommandConfigs.xml flashFile loaded succesful.");
				Console.WriteLine("CommandConfigs.xml has loaded.");

				return true;
			}
			catch (Exception e)
			{
				Console.WriteLine("Failed to load CommandConfigs.xml");
				Console.WriteLine(e.Message);

				return false;
			}

		}

		public void SaveCommandConfigToXml(String ConfigFile, CommandConfigs config)
		{

			XmlSerialization.WriteToXmlFile<CommandConfigs>(ConfigFile, config);

			//Log.SendEventLog("Save to CommandConfigs.xml has been successful.");
			Console.WriteLine("CommandConfigs.xml has saved.");
		}


	}
}
