using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastenTerminal
{

	public class TerminalConfig
	{
		public String portName = "";
		public String baudrate = "115200";

		public bool needLog = true;
		public bool dateLog = true;

		public bool isHex = false;
		public bool isBinaryMode = false;


	}

	public class FastenTerminalConfigs
	{
		public TerminalConfig config;

		// Configs
		const String ConfigFile = @"FastenTerminalConfigs.xml";


		public FastenTerminalConfigs ()
		{
			if (!LoadConfigFromXml())
			{
				config = new TerminalConfig();
			}
		}



		public bool LoadConfigFromXml()
		{

			try
			{
				config = XmlSerialization.ReadFromXmlFile<TerminalConfig>(ConfigFile);
				// EXCEPTION: ha nem találja az adott fájlt

				Log.SendEventLog(ConfigFile + " has loaded.");

				return true;
			}
			catch (Exception e)
			{
				Log.SendErrorLog("Failed to load "+ ConfigFile + "\n" + e.Message);

				return false;
			}
		}



		public void SaveConfigToXml()
		{
			XmlSerialization.WriteToXmlFile<TerminalConfig>(ConfigFile, config);

			Log.SendEventLog(ConfigFile + " has saved.");
		}


	}
}
