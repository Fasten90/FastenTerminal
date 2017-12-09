using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FastenTerminal
{
    public class Telnet : Communication
    {
        // TODO: change to 23
        //public const int PORT = 8000;
        public const int PORT = 2000;

        private NetworkStream telnetStream_A;
        private TcpClient telnet_A;
        private Thread t;
        private bool telnet_receiving = false;
        private string Telnet_out;
        // TODO:
        //delegate void Display(string s);

        //private string IP = "news.thundernews.com";
        private string IP = "192.168.1.62";
        private string user;
        private string passwd;


        public Telnet(FormFastenTerminal form)
        {
            this.form = form;
        }

        // SOurce: https://dotblogs.com.tw/masterhsu/2016/07/13/150206
        public bool Telnet_Connect(string IP, string user, string passwd)
        {
            // TODO: Fix this
            //this.IP = IP;
            IP = this.IP;
            this.user = user;
            this.passwd = passwd;

            bool result = false;

            try
            {
                telnet_A = new TcpClient();
                telnet_A.SendTimeout = 1000;
                telnet_A.ReceiveTimeout = 1000;
                telnet_A.Connect(IP, PORT);

                // TODO: Blocked operation!!!!!!!!!!

                if (telnet_A.Connected)
                {
                    telnetStream_A = telnet_A.GetStream();

                    // Open thread to do receive
                    telnet_receiving = true;
                    t = new Thread(Telnet_Read);
                    t.Start();
                    //Thread.Sleep(100);
                    form.AppendTextLogEvent("Telnet connection successful!");
                    result = true;
                    isOpened = true;
                }
                else
                {
                    form.AppendTextLogEvent("Telnet connection failed!");
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                // TODO: Implement
                form.AppendTextLogEvent("Telnet connection failed: " + ex.Message);
                Log.SendErrorLog(ex.Message);
            }

            return result;
        }

        private void Telnet_Read()
        {
            try
            {
                while (telnet_receiving)
                {
                    if (telnetStream_A.DataAvailable)
                    {
                        byte[] bytes = new byte[telnet_A.ReceiveBufferSize];
                        int numBytesRead = telnetStream_A.Read(bytes, 0, (int)telnet_A.ReceiveBufferSize);
                        Array.Resize(ref bytes, numBytesRead);

                        Telnet_out = Encoding.ASCII.GetString(bytes);

                        Console.WriteLine("Received from telnet: " + Telnet_out);

                        AppendReceivedTextToGui(Telnet_out);
                        //form.AppendTextLogData(Telnet_out);

                        // Sent message display
                        // TODO: 
                        //Display d = new Display(ShowMessage);
                        //this.Invoke(d, new Object[] { Telnet_out });
                    }

                    Thread.Sleep(20);
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                // TODO: Implement
                Log.SendErrorLog(ex.Message);
            }
        }

        public override String SendMessage(String message)
        {
            byte[] bytWrite_telnet_A;
            String logMessage = "";

            if (isOpened)
            {
                if (message != null)
                {
                    try
                    {
                        bytWrite_telnet_A = Encoding.ASCII.GetBytes(message + newLineString);
                        // Write datas
                        telnetStream_A.Write(bytWrite_telnet_A, 0, bytWrite_telnet_A.Length);

                        logMessage = "\n[Application] Successful sent message:\t" + message + "\n";
                    }
                    catch (Exception ex)
                    {
                        logMessage = "[Application] Failed sent telnet message:" + ex.Message;
                        Log.SendErrorLog(logMessage);

                        // Stop periodical sending
                        if (PeriodSending_Enable)
                        {
                            PeriodSendingStop();
                        }

                        // TODO: Call TelnetError()

                    }
                }
            }
            else
            {
                logMessage = "[Application] Cannot send message, because there is not connection to telnet\n";

                if (PeriodSending_Enable)
                {
                    PeriodSendingStop();
                }
            }

            if (NeedLog)
            {
                MessageLog.SendLog(logMessage, true);
            }

            if (printSentEvent)
            {
                form.AppendTextLogEvent(logMessage);
            }

            return logMessage;
        }
    }
}
