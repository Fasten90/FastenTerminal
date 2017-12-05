using System;
using System.Diagnostics;
using System.IO;

namespace FastenTerminal
{
	static public class SerialLog
	{
		// Copied form "Log.cs"

		static TextWriterTraceListener Logger;
		static public String logFileName = "";

		static SerialLog()
		{
            logFileName = "Serial_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".log";

            String logFilePath = Environment.CurrentDirectory + @"\LOG\" + logFileName;
            FileStream logFileStream = new FileStream(logFilePath, FileMode.OpenOrCreate, FileAccess.Write);

			Logger = new TextWriterTraceListener(logFileStream, "SerialLog");

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
