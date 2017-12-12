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
        //public const int PORT = 8000;
        public int port = 2000;

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
            // TODO: Do more beautiful (delegate?)
            this.form = form;
        }

        // Source: https://dotblogs.com.tw/masterhsu/2016/07/13/150206
        public bool Telnet_Connect(string IP, int port = 23, string user = "", string passwd = "")
        {
            this.IP = IP;
            this.port = port;
            this.user = user;
            this.passwd = passwd;

            bool result = false;

            try
            {
                telnet_A = new TcpClient();
                telnet_A.SendTimeout = 1000;
                telnet_A.ReceiveTimeout = 1000;
                telnet_A.Connect(IP, port);

                // TODO: Blocked operation!!!!!!!!!!

                if (telnet_A.Connected)
                {
                    telnetStream_A = telnet_A.GetStream();

                    // Open thread to do receive
                    telnet_receiving = true;
                    t = new Thread(Telnet_Read);
                    t.Start();
                    form.AppendTextLogEvent("Telnet connection successful!");
                    result = true;
                    isOpened = true;
                    stateInfo = "Telnet: " + IP + ":" + port.ToString();
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
                form.AppendTextLogEvent("Telnet connection failed:\n" + ex.Message);
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

                        logMessage = "Successful sent message: \"" + message + "\"";
                    }
                    catch (Exception ex)
                    {
                        logMessage = "ERROR! Failed sent telnet message: " + ex.Message;
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
                logMessage = "Cannot send message, because there is not connection to telnet";

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

        public override void Close()
        {
            if (telnetStream_A != null)
            {
                telnetStream_A.Close();
                form.AppendTextLogEvent("Telnet connection closed");
                isOpened = false;
                stateInfo = "Closed";
            }
        }
    }
}
