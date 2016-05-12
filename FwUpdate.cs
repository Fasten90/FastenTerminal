using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace JarKonApplication
{
	public enum FwUpdateSource
	{
		GSM,
		SerialPort,
		Error
	}

	public class FwUpdate
	{

		int FullPageNum;
		int ActualPageNum;
		int ActualInnerPageNum;

		String FullCode;
		String ActualPageCode;
		String ActualInnerPageCode;

		String VersionName;

		FwUpdateSource source;
		JarKonSerial serial;
		JarKonDevApplication form;
		Thread updateThread;

		const int PageAsciiLength = 512;
		const int InnerPageMaxCount = 4;
		const int InnerPageAsciiLength = PageAsciiLength / InnerPageMaxCount;


		bool ReceivedFwUpdateMessage;
		String ReceivedMessage;


		public FwUpdate(String codeFile, String versionName, JarKonSerial serial, JarKonDevApplication form)
		{
			// TODO:

			// Init variables
			FullCode = "";
			ActualPageCode = "";
			ActualInnerPageCode = "";

			FullPageNum = 0;
			ActualPageNum = 1;	// First page
			ActualInnerPageNum = 1;		// First inner page --> create new inner page

			VersionName = versionName;

			// TODO: Source ...
			source = FwUpdateSource.SerialPort;
			this.serial = serial;
			this.form = form;


			//StartFirmWareUpdate(codeFile);

			// Start in new process
			updateThread = new Thread(() => StartFirmWareUpdate(codeFile));
			updateThread.Start();
			
	
		}

		private void StartFirmWareUpdate(String codeFile)
		{
			// Get hex file


			// Process code file
			OpenAndProcessHexFile(codeFile);

			CalculateFullPageNum();

			form.FwUpdateWaitMessage = true;

			// Send "START"
			SendStartCommand(source);
			Thread.Sleep(3000);

			// Sending in loop
			while (ActualPageNum <= FullPageNum)
			{
				// Get next inner page
				GetNextInnerPage();

				// Send this inner page
				SendNextInnerPage();

				String text = ActualPageNum.ToString() + "." + ActualInnerPageNum.ToString() + "/" + FullPageNum.ToString();
				form.AppendFwUpdateState(text);

				Thread.Sleep(3000);
				
			}

			// Send "FINISH"
			SendFinishCommand(source);

			form.FwUpdateWaitMessage = false;
		}

		private void CalculateFullPageNum()
		{
			FullPageNum = (int)FullCode.Length / 512;
		}

		private void GetNextInnerPage()
		{
			// Ha új Page jön:
			if ( ( ActualInnerPageNum % 4) == 1)
			{
				// InnerPage = 1 (new page starting)
				// Get new page
				ActualPageCode = FullCode.Substring((ActualPageNum - 1) * PageAsciiLength, PageAsciiLength);
				//ActualPageNum++; // delete
				
				ActualInnerPageCode = ActualPageCode.Substring(0, InnerPageAsciiLength);
				ActualInnerPageNum = 1;
			}
			else
			{
				// Next inner page
				ActualInnerPageCode = ActualPageCode.Substring(
					(ActualInnerPageNum - 1) * InnerPageAsciiLength,
					InnerPageAsciiLength );
				//ActualInnerPageNum++;
			}
		}



		private bool OpenAndProcessHexFile(string codeFile)
		{

			FullCode = "";


			// Source: https://msdn.microsoft.com/en-us/library/aa287535%28v=vs.71%29.aspx
			string line;
			int counter = 0;

			// Read the file and display it line by line.
			System.IO.StreamReader file = new System.IO.StreamReader(codeFile);
			while ((line = file.ReadLine()) != null)
			{
				//Console.WriteLine(line);
				counter++;
				if (line.StartsWith(":02"))
				{
					// drop
				}
				else if (line.StartsWith(":10"))
				{
					// Save
					// Substring from 9.char, 32 char length
					String dataLine = line.Substring(9, 32);
					FullCode += dataLine;
				}
			}

			file.Close();


			// TODO: Kiegészítés *512 bájtra


			return true;
		}


		public void SendNextInnerPage()
		{
			// TODO:

			// Need source?
			// Send inner page
			SendInnerPage(source);
			/*
			switch (source)
			{
				case FwUpdateSource.GSM:
					break;
				case FwUpdateSource.SerialPort:

					// Send inner page on serial ...
					
					break;
				case FwUpdateSource.Error:
					break;
				default:
					break;
			}
			*/

			if (ActualInnerPageNum < InnerPageMaxCount)
			{
				ActualInnerPageNum++;
			}
			else
			{
				// End of page...
				// Receive answer !! And check that

				// Check response
				if ( WaitPageResponse(10000))
				{
					ActualInnerPageNum = 1;
					ActualPageNum++;
					// Next Page...
				}
				else
				{
					// Error
					// Start from inner page 1
					ActualInnerPageNum = 1;
				}
				
			}
			


		}


		private void SendStartCommand(FwUpdateSource source)
		{
			String message = "";
			int length = 0;

			if (source == FwUpdateSource.SerialPort)
			{
				message += "!";
				//length += 1;
			}

			length += 5 + 1 + VersionName.Length + 1 + 5 + 1;

			message += "FWUP";
			message += length.ToString("D4");				// message length
			message += "0000";								// boxprog id
			message += "|";
			message += "START";
			message += "|";
			message += VersionName;							// Version
			// TODO: Version
			message += "|";
			message += FullPageNum.ToString("D5");			// FulllPageNum
			message += "|";
			message += "\r\n";

			if (source == FwUpdateSource.SerialPort)
			{
				SendSerialMessage(message);
			}
			
		}



		private void SendSerialMessage(string message)
		{
			String result = serial.SendMessage(message);
			form.AppendTextSerialData(result);
			form.AppendTextSerialData(message);
		}



		private void SendInnerPage(FwUpdateSource source)
		{
			// Example:
			// &FWUP<MessageLength:4><BoxProgID:4>|PAGE|<page:5>|<innerPage:2>|<containedPageInASCII>|<checksum:2>|
			// &FWUP01460142|PAGE|00001|01|00111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111|00|

			String message = "";
			int length = 0;
			if (source == FwUpdateSource.SerialPort)
			{
				message += "!";
				//length += 1;
			}
			length += 4 + 1 + 4 + 1 + 4 + 1 + ActualInnerPageCode.Length + 1 + 2 + 1;

			message += "FWUP";
			message += length.ToString("D4");				// message length
			message += "0000";								// boxprog id
			message += "|";
			message += "PAGE";
			message += "|";
			message += ActualPageNum.ToString("D5");		// ActualPageNum
			message += "|";
			message += ActualInnerPageNum.ToString("D2");	// InnerPageNum
			message += "|";
			message += ActualInnerPageCode;					// Inner page Data
			message += "|";
			message += "00";								// Checksum			// TODO: Checksum
			message += "|";
			message += "\r\n";

			if (source == FwUpdateSource.SerialPort)
			{
				SendSerialMessage(message);
			}
			
		}



		private void SendFinishCommand(FwUpdateSource source)
		{
			String message = "";
			int length = 0;
			if (source == FwUpdateSource.SerialPort)
			{
				message += "!";
				//length += 1;
			}

			length += 6 + 1;
			message += "FWUP";
			message += length.ToString("D4");				// message length
			message += "0000";								// boxprog id
			message += "|";
			message += "FINISH";
			message += "|";
			message += "\r\n";

			if (source == FwUpdateSource.SerialPort)
			{
				SendSerialMessage(message);
			}

		}



		private bool WaitPageResponse(int maxMiliSecond)
		{

			bool successful = false;

			if (source == FwUpdateSource.SerialPort)
			{

				int actualMiliSeond = 0;
				while (actualMiliSeond < maxMiliSecond)
				{
					actualMiliSeond += 100;
					Thread.Sleep(100);

					if (ReceivedFwUpdateMessage == true)
					{
						if (ReceivedMessage.Contains("FWUP"))
						{
							if (ReceivedMessage.Contains("PAGE"))
							{
								String pageNumString = ReceivedMessage.Substring(20, 5);
								try
								{
									int pageNum = Int32.Parse(pageNumString);

									if (pageNum == ActualPageNum)
									{
										if (ReceivedMessage.Contains("OK"))
										{
											successful = true;
											return successful;
										}
										else if (ReceivedMessage.Contains("ERROR"))
										{
											successful = false;
											return successful;
										}
									}
								}
								catch (Exception e)
								{
									// ...
								}

							}

						}

						ReceivedFwUpdateMessage = false;
					}
					else
					{
						//successful = false;
					}

				}	// End of while (wait response)


				//successful = false;
			}
			else
			{
				successful = false;
			}

			return successful;

		}



		public void ReceivedAnMessage(String message)
		{
			ReceivedFwUpdateMessage = true; ;
			ReceivedMessage = message;

		}


		public void FwUpdateStop()
		{
			form.FwUpdateWaitMessage = false;

			updateThread.Abort();
		}

	}

}
