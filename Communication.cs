using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastenTerminal
{
    public class Communication
    {
        public string stateInfo = "";

        public bool isOpened = false;
        public bool receiverModeBinary = false;
        public bool needToConvertHex = false;

        public string newLineString { get; set; }

        protected String receivedMsg = "";

        // LOG - aux variables
        protected String logMessage = "";

        protected string LogSaveStartCharacters = "\r\n\0";


        public bool printSentEvent = true;

        // LOG - settings
        public bool NeedLog = true;
        public bool LogWithDateTime = true;


        protected Object receiveLocker = new Object();
        protected string receivedMessage = "";
        protected string actualReceivedMessage = "";

        protected Object messageLocker = new Object();

        // Periodical sending
        public bool PeriodSending_Enable = false;
        public float PeriodSending_Time = 5.0f;
        protected System.Windows.Forms.Timer PeriodSending_Timer;
        protected string PeriodSending_Message = "";

        // Form
        protected FormFastenTerminal form;

        // For secure closing
        public bool needPrint = true;


        public void SaveLineLog(object state)
        {
            String checkMsg = "";


            // Event function - received serial message

            // For secure: drop "" (null) string
            if (receivedMessage == "")
            {
                // Do not Log this null message
                return;
            }


            // Get string from serial buffer
            lock (receiveLocker)
            {
                checkMsg = receivedMessage;
                receivedMessage = "";
            }


            // OLD version: PROBLEM: once character is printed one line
            // Example: received "Fasten", printed in log sometimes, "F", "a", "st", "en" "\r\n"

            // Save received message
            lock (messageLocker)
            {
                if (!receiverModeBinary)
                {
                    if (logMessage == "")
                    {
                        // Drop first newline characters
                        logMessage = DropStartNewlineCharacters(checkMsg);
                    }
                    else
                    {
                        // We have a string, it is endline characters
                        // Append
                        logMessage += checkMsg;
                    }


                    // Has end character?
                    int length = IsHasEndCharacter(logMessage);
                    if ((length > -1) && (logMessage != "") && (length <= logMessage.Length))
                    {
                        // Has end character, and not start with it
                        // First "line"
                        String cleanedMsg = logMessage.Substring(0, (length + 1));
                        cleanedMsg = DropEndNewlineCharacters(cleanedMsg);

                        // After line
                        logMessage = logMessage.Substring((length + 1));
                        // Drop newline characters from begin
                        logMessage = DropStartNewlineCharacters(logMessage);

                        // This is a line, which can be processing
                        // Process message (Log and process)
                        saveMsg(cleanedMsg);
                    }
                }
                else
                {
                    // receiverModeBinary
                    saveMsg(checkMsg);
                }
            }
        }

        private void saveMsg(string msg)
        {
            // Send to protocol Checker
            // TODO: do with "event" or delegate

            // Process
            if (msg != "")
            {
                // Need log?
                if (NeedLog)
                {
                    // LogWithDateTime parameter --> put or do not put DateTime to log file
                    MessageLog.SendLog(msg, LogWithDateTime);
                }
            }

            return;
        }

        private int IsHasEndCharacter(string message)
        {
            int length = -1;
            int result = -1;

            if (message != "")
            {
                // TODO: Why dont used .IndexOfAny("*&#".ToCharArray()) != -1
                // newline characters
                List<char> newlineCharacters = new List<char>();
                newlineCharacters.Add('\r');
                newlineCharacters.Add('\n');
                newlineCharacters.Add('\0');

                foreach (char endCharacter in newlineCharacters)
                {
                    result = message.IndexOf(endCharacter);

                    // The first endLine character index:
                    if (result > -1)
                    {
                        // Found end character
                        if (length == -1)
                        {
                            // This is the first endline character
                            length = result;
                        }
                        else
                        {
                            if (length > result)
                            {
                                // We found before endline character
                                // But this is the first endline character
                                length = result;
                            }
                            else
                            {
                                // We found before endline character
                                // But this is after that
                                // length = length;
                            }
                        }
                    }
                }
            }

            return length;
        }

        private bool IsHasStartEndCharacter(string receivedMessage)
        {
            // Is start with end character?
            if (receivedMessage.StartsWith("\r") ||
                receivedMessage.StartsWith("\n") ||
                receivedMessage.StartsWith("\0")
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string DropStartNewlineCharacters(string receivedMessage)
        {
            String goodMessage = "";

            for (int i = 0; i < receivedMessage.Length; i++)
            {
                if (IsHasStartEndCharacter(receivedMessage))
                {
                    // Started with "\n", do not put it	
                    receivedMessage = receivedMessage.Substring(1);
                }
                else
                {
                    // Normal message, not start with "\n"
                    break;
                }
            }

            // Finish
            goodMessage = receivedMessage;

            return goodMessage;

        }

        private string DropEndNewlineCharacters(string processMessage)
        {
            String goodMessage = processMessage;

            int length = 0;

            while (length != -1)
            {
                length = IsHasEndCharacter(goodMessage);

                if (length > -1)
                {
                    // Drop end character
                    goodMessage = processMessage.Substring(0, length);
                }
            }

            return goodMessage;
        }

        protected void AppendReceivedTextToGui(string message)
        {
            if (!receiverModeBinary)
            {
                // String mode
                /*
                // New line
                // Print on output text
                // For richText, where \r\n is two new line, we need only one newline
                // Drop '\n', and hold '\r'
                String dropCharacter = "\n";
                if (message.Contains(dropCharacter))
                {
                    message = message.Replace(dropCharacter, String.Empty);
                }

                // Replace '\r' to '\r\n'
                String needReplaceCharacter = "\r";
                message = message.Replace(needReplaceCharacter, Environment.NewLine);
                */
            }

            /*
             *      Append received text on text log
             */
            form.AppendTextLogData(message);
        }


        public virtual String SendMessage(String message)
        {
            return "ERROR: Virtual SendMesage, do not call!";
        }

        /*
         *      Periodical Sending
         */

        public void PeriodSendingStart(float sec, string message)
        {
            // Start periodical sending
            PeriodSending_Enable = true;
            PeriodSending_Time = sec;
            PeriodSending_Message = message;

            // Start timer
            PeriodSending_Timer = new System.Windows.Forms.Timer();
            PeriodSending_Timer.Interval = (int)(PeriodSending_Time * 1000);    // =millisec
            PeriodSending_Timer.Enabled = true;
            PeriodSending_Timer.Start();
            PeriodSending_Timer.Tick += new System.EventHandler(this.timerPeriodTimerSending_Tick);

            // Log
            string logMessage = "Periodical message sending started...\n" +
                "  Time: " + PeriodSending_Time.ToString() + "  Message: " + PeriodSending_Message;
            form.AppendTextLogEvent(logMessage);
            Log.SendEventLog(logMessage);
        }
  
        public void PeriodSendingStop()
        {
            // Stop periodical sending
            PeriodSending_Enable = false;

            // Stop timer
            PeriodSending_Timer.Stop();
            PeriodSending_Timer.Enabled = false;

            // Log
            string logMessage = "Periodical message sending stopped";
            form.AppendTextLogEvent(logMessage);
            Log.SendEventLog(logMessage);

            // Not running state
            form.SerialPeriodSend_SetState(false);
        }

        private void timerPeriodTimerSending_Tick(object sender, EventArgs e)
        {
            // Period Sending time actual

            // Send message
            SendMessage(PeriodSending_Message);

            // Log
            //form.AppendTextSerialLogEvent("[Application] Periodical sending message:\n\t" + PeriodSendingMessage +"\n");
        }

        public virtual void Close()
        {
            Console.WriteLine("Do not call virtual Close()");
        }

    }
}
