using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FastenTerminal
{
    public class CommandPromt : Communication
    {
        private Thread t;
        Process cmd;

        public CommandPromt(FormFastenTerminal form)
        {
            // TODO: Do more beautiful (delegate?)
            this.form = form;

            // TODO: Do more beautiful
            // Registrate
            isOpened = true;
        }

        ~CommandPromt()
        {
            printSentEvent = false;
            Close();
        }

        //public void CommandPromt_Start()
        public void CommandPromt_Start(string cmdMsg)
        {
            /* Source: https://stackoverflow.com/questions/1469764/run-command-prompt-commands */
            /*
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("echo Oscar");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
            Console.WriteLine(cmd.StandardOutput.ReadToEnd());
            // This code not work :( The real command need to go in argument
            */

            /*
            cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = false;
            cmd.StartInfo.UseShellExecute = false;
            //cmd.StartInfo.WorkingDirectory = @"C:\";
            */

            var codepage = Console.OutputEncoding.CodePage;

            cmd = new Process();
            cmd.StartInfo = new ProcessStartInfo("cmd.exe")
            {
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                WorkingDirectory = @"C:\",
                //Arguments = "/c echo test",
                Arguments = "/c " + cmdMsg,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.GetEncoding(codepage)
                //StandardOutputEncoding = Encoding.Default
                //StandardOutputEncoding = Encoding.UTF8,
                //StandardErrorEncoding = Encoding.UTF8,
            };

            /*
            // Output & error 
            cmd.OutputDataReceived += CommandPromt_OutputData;
            cmd.ErrorDataReceived += CommandPromt_ErrorDataReceived;
            */

            cmd.Start();

            t = new Thread(CommandPromt_Read);
            t.Start();

            //CommandPromt_Send("echo test");

            //wait - do not use, it is blocking
            //cmd.WaitForExit();

            // Registrate
            isOpened = true;
        }

        public override String SendMessage(String message)
        {
            /* TODO: Make more beautiful */
            //CommandPromt_Send(message);
            CommandPromt_Start(message);

            String logMessage = "";

            logMessage = "Successful sent message: \"" + message + "\"";

            if (NeedLog && printSentEvent)
            {
                flushLogMsg();
                MessageLog.SendLog(logMessage, true);
            }

            if (printSentEvent)
            {
                form.AppendTextLogEvent(logMessage);
            }

            return logMessage;
        }

        public void CommandPromt_Send(String msg)
        {
            cmd.StandardInput.WriteLine(msg.TrimEnd());
            cmd.StandardInput.Flush();
            //cmd.StandardInput.Close();
        }

        private void CommandPromt_Read()
        {
            //cmd.WaitForExit();
            /*
            while (true)
            {
                try
                {
                    Console.WriteLine(cmd.StandardOutput.ReadToEnd());
                }
                catch(Exception)
                {
                    Console.WriteLine("Failed read standard output");
                }

                

                // TODO: Ugly solution
                Thread.Sleep(20);
            }
            */

            String consoleStandardOutput = cmd.StandardOutput.ReadToEnd();
            String consoleErrorOutput = cmd.StandardError.ReadToEnd();

            /* TODO: ENCODE PROBLEMS */
            //var codepage = Console.OutputEncoding.CodePage;
            // GetEncoding(codepage)

            byte[] consoleStandardOutputEncoded = Encoding.Default.GetBytes(consoleStandardOutput);
            // Encoding.Default
            // Encoding.UTF8
            // Encoding.GetEncoding(codepage)
            String consoleStandardOutputGood = Encoding.Default.GetString(consoleStandardOutputEncoded);
            String consoleStandardOutputANSI = Encoding.ASCII.GetString(consoleStandardOutputEncoded);

            //Console.OutputEncoding = Encoding.UTF8;  // It will throw exception
            Console.WriteLine("Console output: " + consoleStandardOutput);
            Console.WriteLine("Console error: " + consoleErrorOutput);

            ///*
            AppendReceivedTextToGui(consoleStandardOutputANSI);
            if (consoleErrorOutput != "")
                AppendReceivedTextToGui(consoleErrorOutput);
            //*/

            form.CommReceivedCharacterEvent();

            cmd.WaitForExit();
        }

        static void CommandPromt_OutputData(object sender, DataReceivedEventArgs e)
        {
            Process p = sender as Process;
            if (p == null)
                return;
            Console.WriteLine(e.Data);
        }

        static void CommandPromt_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Process p = sender as Process;
            if (p == null)
                return;
            Console.WriteLine(e.Data);
        }
    }
}
