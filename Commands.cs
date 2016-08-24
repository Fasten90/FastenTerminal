using FastenTerminal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastenTerminal
{
	public class Command
	{
		public String CommandString { set; get; }
		public String CommandName { set; get; }
	}


	public class CommandConfigs
	{

		public List<Command> CommandList  { set; get; }


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



	public class CommandHandler
	{
		public CommandConfigs CommandConfig;

		private FastenTerminal form;


		// Configs
		const String CommandConfigFile = @"CommandConfigs.xml";


		// TODO: szebb megoldás a formra átadás helyett?
		public CommandHandler(FastenTerminal form)
		{
			this.form = form;

			CommandConfig = new CommandConfigs();

			if (LoadCommandConfigFromXml(CommandConfigFile, ref CommandConfig) == true)
			{
				// Successful loaded Commands...
			}
			else
			{
				// Create new
				AddNewCommand("ThereIsNoAddedCommand", "ThereIsNoAddedCommand");
			}
		}


		public void AddNewCommand(String command, String name)
		{
			CommandConfig.AddCommand(command, name);
			SaveCommandConfigToXml(CommandConfigFile, CommandConfig);
		}

		
		public List<Command> GetCommands()
		{
			return CommandConfig.CommandList;
		}


		public void SendCommand(String command)
		{
			// +"\r\n";	SendMessage() függvényben lett
			String message = "[Application] Send command: " + command;
			form.AppendTextSerialData(message);
			Log.SendEventLog(message);


			String messageResult = "";

			// Send on serial
			messageResult = form.serial.SendMessage(command,true);


			Log.SendEventLog(messageResult);
			
		}



		public bool LoadCommandConfigFromXml(String ConfigFile, ref CommandConfigs config)
		{

			try
			{
				config = XmlSerialization.ReadFromXmlFile<CommandConfigs>(ConfigFile);
				// EXCEPTION: ha nem találja az adott fájlt

				Log.SendEventLog("CommandConfigs.xml has loaded.");

				return true;
			}
			catch (Exception e)
			{
				Log.SendErrorLog("Failed to load CommandConfigs.xml" + e.Message);

				return false;
			}

		}



		public void SaveCommandConfigToXml(String ConfigFile, CommandConfigs config)
		{

			XmlSerialization.WriteToXmlFile<CommandConfigs>(ConfigFile, config);

			Log.SendEventLog("CommandConfigs.xml has saved.");
		}


	}
}
