using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarKonDevApplication
{
	static class Log
	{

		static TextWriterTraceListener EventLogger;
		static TextWriterTraceListener ErrorLogger;

		// !! IMPORTANT !! - TRACE
		/*
		EventLogger = new TextWriterTraceListener("Events.log", "EventLog");
		ErrorLogger = new TextWriterTraceListener("Errors.log", "ErrorLog");
		EventLogger.WriteLine("#EventLog has been started.");
		EventLogger.WriteLine(DateTime.Now.ToString());
		EventLogger.Flush();
		*/
		/*
		// EXAMPLE FOR TRACE
		TextWriterTraceListener myListener = new TextWriterTraceListener("TextWriterOutput.log", "myListener");
		myListener.WriteLine("Test message.");
		// You must close or flush the trace listener to empty the output buffer.
		myListener.Flush();
		*/

		static Log()
		{
			EventLogger = new TextWriterTraceListener("Log\\Events.log", "EventLog");
			ErrorLogger = new TextWriterTraceListener("Log\\Errors.log", "ErrorLog");

			SendEventLog("EventLog has been started.");
			SendErrorLog("ErrorLog has been started.");
			//EventLogger.WriteLine("#EventLog has been started.");
			//EventLogger.WriteLine(DateTime.Now.ToString());

		}

		static public void SendEventLog(String text)
		{
			EventLogger.WriteLine(DateTime.Now.ToString() + "\t " + text);
			EventLogger.Flush();
			Console.WriteLine(text);
		}

		static public void SendErrorLog(String text)
		{
			ErrorLogger.WriteLine(DateTime.Now.ToString() + "\t " + text);
			ErrorLogger.Flush();
			Console.WriteLine(text);
		}

		/*
		static public void WriteLine(String text)
		{
			EventLogger.WriteLine(DateTime.Now.ToString() + "\t " + text);
			EventLogger.Flush();
			Console.WriteLine(text);
		}
		*/


	}
}
