using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Management;
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

            stateInfo = "Command Promt";

            form.AppendTextLogEvent("Command promt opened!");
        }

        ~CommandPromt()
        {
            printSentEvent = false;
            isOpened = false;
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

            //var codepage = Console.OutputEncoding.CodePage;

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
                //StandardOutputEncoding = Encoding.GetEncoding(codepage)
                //StandardOutputEncoding = Encoding.Default
                //StandardOutputEncoding = Encoding.UTF8,
                //StandardErrorEncoding = Encoding.UTF8,
            };

            ///*
            // Output & error 
            cmd.OutputDataReceived += CommandPromt_OutputData;
            cmd.ErrorDataReceived += CommandPromt_ErrorDataReceived;
            //*/

            cmd.Start();

            /*
            t = new Thread(CommandPromt_Read);
            t.Start();
            */

            // Necessary for subscriptions
            cmd.BeginOutputReadLine();

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

            // ReadToEnd() is work, but they will wait the end of command executing
            //String consoleStandardOutput = cmd.StandardOutput.ReadToEnd();
            //String consoleErrorOutput = cmd.StandardError.ReadToEnd();
            while(!cmd.HasExited || !cmd.StandardOutput.EndOfStream || !cmd.StandardError.EndOfStream)
            {
                String consoleStandardOutput = cmd.StandardOutput.ReadLine();
                String consoleErrorOutput = cmd.StandardError.ReadLine();

                if (consoleStandardOutput == null)
                    consoleStandardOutput = "";
                if (consoleErrorOutput == null)
                    consoleErrorOutput = "";

                //string test1 = Encoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(consoleStandardOutput));


                /* TODO: Delete ENCODE PROBLEMS */
                var codepage2 = Console.OutputEncoding.CodePage;        // VG: 1250
                var codepage = CultureInfo.CurrentCulture.TextInfo.OEMCodePage; // VG: 852
                // GetEncoding(codepage)

                byte[] consoleStandardOutputEncoded = Encoding.GetEncoding(codepage2).GetBytes(consoleStandardOutput);
                byte[] consoleErrorOutputEncoded    = Encoding.GetEncoding(codepage2).GetBytes(consoleErrorOutput);
                //byte[] consoleStandardOutputEncoded = Encoding.Default.GetBytes(consoleStandardOutput);
                //byte[] consoleStandardOutputEncoded = Encoding.UTF8.GetBytes(consoleStandardOutput);

                byte[] consoleOutputConverted = Encoding.Convert(Encoding.GetEncoding(codepage), Encoding.GetEncoding(codepage2), consoleStandardOutputEncoded);
                byte[] consoleErrorConverted = Encoding.Convert(Encoding.GetEncoding(codepage), Encoding.GetEncoding(codepage2), consoleErrorOutputEncoded);
                //byte[] test1 = Encoding.Convert(Encoding.Default, Encoding.UTF8, consoleStandardOutputEncoded);
                //byte[] test1 = Encoding.Convert(Encoding.GetEncoding(codepage), Encoding.GetEncoding(codepage2), consoleStandardOutputEncoded);
                //byte[] test1 = Encoding.Convert(Encoding.UTF8, Encoding.GetEncoding(codepage2), consoleStandardOutputEncoded);
                //byte[] test2 = Encoding.Convert(Encoding.GetEncoding(codepage), Encoding.GetEncoding(codepage), consoleStandardOutputEncoded);
                //byte[] test3 = Encoding.Convert(Encoding.GetEncoding(codepage), Encoding.Unicode, consoleStandardOutputEncoded);
                //byte[] test4 = Encoding.Convert(Encoding.GetEncoding(codepage), Encoding.UTF8, consoleStandardOutputEncoded);

                // Encoding.Default
                // Encoding.UTF8
                // Encoding.GetEncoding(codepage)

                String consoleStandardOutputGood = Encoding.GetEncoding(codepage2).GetString(consoleOutputConverted);
                String consoleErrorOutputGood    = Encoding.GetEncoding(codepage2).GetString(consoleErrorConverted);
                //String consoleStandardOutputGood = Encoding.ASCII.GetString(test1);
                //String consoleStandardOutputGood = Encoding.Default.GetString(consoleStandardOutputEncoded);
                //String consoleStandardOutputGood = Encoding.ASCII.GetString(consoleStandardOutputEncoded);
                //String consoleStandardOutputGood2 = Encoding.GetEncoding(codepage).GetString(test2);
                //String consoleStandardOutputGood3 = Encoding.Unicode.GetString(test3);
                //String consoleStandardOutputGood4 = Encoding.UTF8.GetString(test4);

                //Console.OutputEncoding = Encoding.UTF8;  // It will throw exception

                if (consoleStandardOutputGood != "")
                    Console.WriteLine("Console output: " + consoleStandardOutputGood);
                //Console.WriteLine("Console output: " + consoleStandardOutputGood2);
                //Console.WriteLine("Console output: " + consoleStandardOutputGood3);
                //Console.WriteLine("Console output: " + consoleStandardOutputGood4);

                if (consoleErrorOutput != "")
                    Console.WriteLine("Console error: " + consoleErrorOutputGood);


                if (consoleStandardOutputGood != "")
                    AppendReceivedTextToGui(consoleStandardOutputGood + Environment.NewLine);
                if (consoleErrorOutputGood != "")
                    AppendReceivedTextToGui(consoleErrorOutputGood + Environment.NewLine);

                if (consoleStandardOutputGood != "" || consoleErrorOutputGood != "")
                    form.CommReceivedCharacterEvent();

                //cmd.WaitForExit();
            }
        }

        private void CommandPromt_AppendReceivedText(String msg)
        {
            if (msg == null)
                msg = "";


            /* TODO: Delete ENCODE PROBLEMS */
            var codepage2 = Console.OutputEncoding.CodePage;        // VG: 1250
            var codepage = CultureInfo.CurrentCulture.TextInfo.OEMCodePage; // VG: 852
            // GetEncoding(codepage)

            byte[] consoleStandardOutputEncoded = Encoding.GetEncoding(codepage2).GetBytes(msg);

            byte[] consoleOutputConverted = Encoding.Convert(Encoding.GetEncoding(codepage), Encoding.GetEncoding(codepage2), consoleStandardOutputEncoded);

            String consoleStandardOutputGood = Encoding.GetEncoding(codepage2).GetString(consoleOutputConverted);

            if (consoleStandardOutputGood != "")
                Console.WriteLine("Console output: " + consoleStandardOutputGood);

            if (consoleStandardOutputGood != "")
                AppendReceivedTextToGui(consoleStandardOutputGood + Environment.NewLine);

            if (consoleStandardOutputGood != "")
                form.CommReceivedCharacterEvent();
        }

        void CommandPromt_OutputData(object sender, DataReceivedEventArgs e)
        {
            Process p = sender as Process;
            if (p == null)
                return;
            CommandPromt_AppendReceivedText(e.Data);
        }

        void CommandPromt_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            Process p = sender as Process;
            if (p == null)
                return;
            CommandPromt_AppendReceivedText(e.Data);
        }

        public override void Close()
        {
            /*
            if (t != null)
            {
                t.Abort();
            }*/

            if (cmd != null)
            {
                //cmd.Close();
                //cmd.Kill();
                int pid = cmd.Id;
                KillProcessAndChildrens(pid);
            }

            if (printSentEvent)
                form.AppendTextLogEvent("Command promt closed");

            isOpened = false;
            stateInfo = "Closed";
        }

        /*
         * This function source: https://stackoverflow.com/questions/30249873/process-kill-doesnt-seem-to-kill-the-process
         * It is necessary, because the kill was not working all time (e.g. cmd.exe called ping.exe)
         */
        private static void KillProcessAndChildrens(int pid)
        {
            ManagementObjectSearcher processSearcher = new ManagementObjectSearcher
              ("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection processCollection = processSearcher.Get();

            try
            {
                Process proc = Process.GetProcessById(pid);
                if (!proc.HasExited) proc.Kill();
            }
            catch (ArgumentException)
            {
                // Process already exited.
            }

            if (processCollection != null)
            {
                foreach (ManagementObject mo in processCollection)
                {
                    KillProcessAndChildrens(Convert.ToInt32(mo["ProcessID"])); //kill child processes(also kills childrens of childrens etc.)
                }
            }
        }
    }
}
