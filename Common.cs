﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FastenTerminal
{
	public static class Common
	{

		public static void PlaySound(String sound)
		{
			try
			{
				if (sound != null)
				{
					System.Media.SoundPlayer player = new System.Media.SoundPlayer(sound);
					player.Play();
				}
				else
				{
					//Log.SendErrorLog("Sound parameter is null.");
				}
			}
			catch (Exception e)
			{
				//Log.SendErrorLog("Sound playing has been failed. " + e.Message);
				Console.WriteLine("Sound playing has been failed. " + e.Message);
			}

		}

		/// <summary>
		/// Function: convert ASCII string to Hex string
		/// Source: http://stackoverflow.com/questions/16999604/convert-string-to-hex-string-in-c-sharp
		/// </summary>
		/// <param name="str"></param>
		/// <returns></returns>
		public static string ToHexString(string str)
		{
			var sb = new StringBuilder();

			var bytes = Encoding.Default.GetBytes(str);
			foreach (var t in bytes)
			{
				sb.Append(t.ToString("X2"));
			}

			return sb.ToString(); // returns: "48656C6C6F20776F726C64" for "Hello world"
		}


		// Source: http://stackoverflow.com/questions/311165/how-do-you-convert-byte-array-to-hexadecimal-string-and-vice-versa
		public static string ByteArrayToString(byte[] ba)
		{
			StringBuilder hex = new StringBuilder(ba.Length * 2);
			foreach (byte b in ba)
				hex.AppendFormat("{0:x2}", b);
			return hex.ToString();
		}


		/*
		You need System.Diagnostics.Process.Start().

		The simplest example:

		Process.Start("notepad.exe", fileName);

		More Generic Approach:

		Process.Start(fileName);
		 */
		public static void OpenTextFile(String logFilePath)
		{
			Process.Start(logFilePath);
		}


        public static String ConvertNewLineToReal(String newLineTypeName)
        {
            String newLineString = "";

            if (newLineTypeName != null)
            {
                if (newLineTypeName == "\\r\\n")
                {
                    newLineString = "\r\n";
                }
                else if (newLineTypeName == "\\r")
                {
                    newLineString = "\r";
                }
                else if (newLineTypeName == "\\n")
                {
                    newLineString = "\n";
                }
            }

            return newLineString;
        }

        public static bool CheckIpAddressIsValid(String IPstring)
        {
            IPAddress ipAddress;
            if (IPAddress.TryParse(IPstring, out ipAddress))
            {
                // Valid ip
                return true;
            }
            else
            {
                // Is not valid ip
                return false;
            }
        }

        public static bool CheckPortisValid(String portString, out int port)
        {
            if (portString != null)
            {
                try
                {
                    int convertedPort = 0;
                    if (int.TryParse(portString, out convertedPort))
                    {
                        port = convertedPort;
                        return true;
                    }
                    else
                    {
                        port = -1;
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Log.SendErrorLog(ex.Message);
                    port = -1;
                    return false;
                }
            }
            else
            {
                port = -1;
                return false;
            }
        }

    }
}
