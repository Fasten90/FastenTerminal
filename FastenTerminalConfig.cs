using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastenTerminal
{

	public class TerminalConfig
	{
        // Default configs

        // Application configs
        public String BackgroundColor = ColorTranslator.ToHtml(Color.Gainsboro);
        public String TextColor = ColorTranslator.ToHtml(Color.Black);

        public String EventBackgroundColor = ColorTranslator.ToHtml(Color.Yellow);
        public String EventTextColor = ColorTranslator.ToHtml(Color.Blue);
        
        // Wrong solutions
        //public String TextColor = Color.Black.Name;
        //public String EventBackgroundColor = Color.Yellow.ToString();
        //public String EventTextColor = Color.Blue.ToString();

        // Communcation & log configs
        public bool needLog = true;
		public bool dateLog = true;
		public bool isBinaryMode = false;
        public string newLineString = "\r\n";
        public bool mute = false;
        public bool wordWrap = false;
        public bool printSendingMsg = true;
        public bool escapeSequenceIsEnabled = true;
        
        // Telnet
        public String TelnetIPaddress = "192.168.1.62";
        public String TelnetPort = "2000";
        
        // Serial
		public String SerialBaudrate = "115200";
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
