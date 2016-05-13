using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarKonApplication
{
	static class JarKonSerialLog
	{
		// Copy form "Log.cs"

		static TextWriterTraceListener Logger;


		static JarKonSerialLog()
		{
			Logger = new TextWriterTraceListener("Serial.log", "SerialLog");

			SendLog("Serial LOG has been started.", true);

		}

		static public void SendLog(String text, bool putDatetime = false)
		{
			if (putDatetime)
			{
				Logger.WriteLine(DateTime.Now.ToString() + "\t " + text);
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
