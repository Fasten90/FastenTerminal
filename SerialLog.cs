using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastenTerminal
{
	static public class SerialLog
	{
		// Copy form "Log.cs"

		static TextWriterTraceListener Logger;
		static public String logFileName = "";

		static SerialLog()
		{
			// Old version:
			//Logger = new TextWriterTraceListener("Serial.log", "SerialLog");

			logFileName = "Serial_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".log";
			Logger = new TextWriterTraceListener(logFileName, "SerialLog");

			SendLog("Serial LOG has been started.", true);

		}

		static public void SendLog(String text, bool putDatetime = false)
		{
			if (putDatetime)
			{
				Logger.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t " + text);
			}
			else
			{
				Logger.WriteLine(text);
			}		
			Logger.Flush();
			Console.WriteLine(text);
		}

	}
}
