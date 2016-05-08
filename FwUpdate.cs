using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

		FwUpdateSource source;
		JarKonSerial serial;

		const int PageAsciiLength = 512;
		const int InnerPageMaxCount = 4;
		const int InnerPageAsciiLength = PageAsciiLength / InnerPageMaxCount;


		public FwUpdate(String codeFile, JarKonSerial serial)
		{
			// TODO:

			// Init variables
			FullCode = "";
			ActualPageCode = "";
			ActualInnerPageCode = "";

			FullPageNum = 0;
			ActualPageNum = 1;
			ActualInnerPageNum = 1;

			// TODO: Source ...
			source = FwUpdateSource.SerialPort;
			this.serial = serial;


			// Get hex file
			// TODO:

			// Process code file
			OpenAndProcessHexFile(codeFile);

			CalculateFullPageNum();

			// Sending in loop
			while (ActualPageNum < FullPageNum)
			{
				// Get next inner page
				GetNextInnerPage();

				// Send this inner page
				SendNextInnerPage();
			}
			
			
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
				ActualPageNum = 1;

				ActualInnerPageCode = ActualPageCode.Substring(0, InnerPageAsciiLength);
				ActualInnerPageNum++;
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
			switch (source)
			{
				case FwUpdateSource.GSM:
					break;
				case FwUpdateSource.SerialPort:

					// Send inner page on serial ...
					SendInnerPageInSerial();
					break;
				case FwUpdateSource.Error:
					break;
				default:
					break;
			}

			// Send inner page

		}

		private void SendInnerPageInSerial()
		{
			String message = "";
			message += "!FWUP";
			message += "0000";								// length
			message += "0000";								// boxprog id
			message += "|";
			message += "PAGE";
			message += ActualPageNum.ToString("%d4");		// ActualPageNum
			message += "|";
			message += ActualInnerPageNum.ToString("%d4");	// InnerPageNum
			message += "|";
			message += ActualInnerPageCode;					// Inner page Data
			message += "|";
			message += "00";								// Checksum
			message += "|";
			message += "\r\n";

			serial.SendMessage(message);

			ActualInnerPageNum++;

		}


	}
}
