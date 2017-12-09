using System;
using System.Diagnostics;
using System.IO;

namespace FastenTerminal
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
            /*
            // Example:
            string logFilePath = Environment.ExpandEnvironmentVariables("%userprofile%") + @"\AppData\MyApp\MyApp.log";
            FileStream hlogFile = new FileStream(logFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            TextWriterTraceListener myListener = new TextWriterTraceListener(hlogFile);
            Trace.Listeners.Add(myListener);
            Trace.WriteLine("Sample Log");
            */
            string eventFileName = @"\LOG\Events.log";
            string eventLogFilePath = Environment.CurrentDirectory + eventFileName;
            FileStream eventLogFileStream;
            try
            {
                eventLogFileStream = new FileStream(eventLogFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error with event file using: " + e.Message);
                eventFileName = @"\LOG\Events_" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".log";
                eventLogFilePath = Environment.CurrentDirectory + eventFileName;
                eventLogFileStream = new FileStream(eventLogFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            }

            EventLogger = new TextWriterTraceListener(eventLogFileStream, "EventLog");    // "Events.log"

            string errorFileName = @"\LOG\Errors.log";
            string errorLogFilePath = Environment.CurrentDirectory + errorFileName;
            FileStream errorLogFileStream;
            try
            {
                errorLogFileStream = new FileStream(errorLogFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error with error file using: " + e.Message);
                errorFileName = @"\LOG\Errors" + DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss") + ".log";
                errorLogFilePath = Environment.CurrentDirectory + errorFileName;
                errorLogFileStream = new FileStream(errorLogFilePath, FileMode.OpenOrCreate, FileAccess.Write);
            }

            ErrorLogger = new TextWriterTraceListener(errorLogFileStream, "ErrorLog");    // "Errors.log"

            SendEventLog("EventLog has been started.");
			SendErrorLog("ErrorLog has been started.");
		}

		static public void SendEventLog(String text)
		{
			EventLogger.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t " + text);
			EventLogger.Flush();
			Console.WriteLine("[Application Event] " + text);
		}

		static public void SendErrorLog(String text)
		{
			ErrorLogger.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\t " + text);
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
