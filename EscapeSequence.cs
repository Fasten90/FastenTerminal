using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastenTerminal
{
	public enum EscapeType
	{
		Escape_Nothing,
		Escape_StringWithoutEscape,
		Escape_CLS,
		Escape_TextColor,
		Escape_BackgroundColor,
		Escape_CursorMoving,
		Escape_Short_NeedAppend
	}

	public static class EscapeSequence
	{

		public static EscapeType ProcessEscapeMessage(String message, out Color color, out int stringLength)
		{

			// Search Escape character

			color = Color.Black;
			stringLength = message.Length;

			EscapeType escapeType = EscapeType.Escape_Nothing;
			int length = 0;

			// It is contain escape char?
			int startIndex = message.IndexOf(((char)27).ToString());
			if (startIndex > -1)
			{
				// Has escape character
				if (startIndex != 0 )
				{
					// Should print string
					stringLength = startIndex;
					escapeType = EscapeType.Escape_StringWithoutEscape;
				}
				// Check it is  color escape?
				else if (GetColor(message.Substring(startIndex), out color, out escapeType, out length))
				{
					// It is color escape
					// Check next string (which can sending)
					stringLength = length;
				}
				// Check it is CLS?
				else if (GetItIsClearScreen(message.Substring(startIndex), out escapeType, out length))
				{
					// It is CLS (Clear screen)
					stringLength = length;
				}
				else
				{
					// Wrong escape character, skip first escape char
					if (message.Length < 5)
					{
						stringLength = message.Length;
						return EscapeType.Escape_Short_NeedAppend;
					}
					else
					{
						// Wrong escape sequence, can write it
						stringLength = 1;
						return EscapeType.Escape_StringWithoutEscape;
					}
				}

				// Setted escape
				return escapeType;

			}
			else
			{
				// There is no Escape character
				stringLength = message.Length;
				return EscapeType.Escape_StringWithoutEscape;
			}

			//return EscapeType.Escape_Nothing;
		}

		private static bool GetItIsClearScreen(string escapeMessage, out EscapeType escapeType, out int length)
		{
			// CSI n J
			// n = 2, entire display clear
			length = 0;
			escapeType = EscapeType.Escape_Nothing;

			if (escapeMessage.StartsWith(((char)27).ToString() + "[2J"))
			{
				length = 4;
				escapeType = EscapeType.Escape_CLS;
				return true;
			}

			return false;
		}


		/// <summary>
		/// Get color from string (within escape sequences ... ESC[31m...
		/// </summary>
		/// <param name="escapeMessage"></param>
		/// <returns></returns>
		private static bool GetColor(String escapeMessage, out Color color, out EscapeType escapeType, out int length)
		{
			// Substring after ESC
			// ANSI Escape: https://en.wikipedia.org/wiki/ANSI_escape_code
			// ESC[31m
			// Coloring:
			// ESC[39m
			// ESC[31m
			//0x1B
			//const char ESC = '\x1B';
			//(char)27).ToString());

			bool isOk = false;
			color = Color.Black;
			escapeType = EscapeType.Escape_Nothing;
			length = 0;

			if (escapeMessage.StartsWith(((char)27).ToString() + "["))
			{
				if (escapeMessage[2] == '3')
				{
					escapeType = EscapeType.Escape_TextColor;
				}
				else if (escapeMessage[2] == '4')
				{
					escapeType = EscapeType.Escape_BackgroundColor;
				}
				else
				{
					//escapeType = EscapeType.Escape_Nothing;
					return false;
				}

				// Check 'm' character at end
				if (escapeMessage[4] != 'm' )
				{
					return false;
				}

				// Check color
				char colorChar = escapeMessage[3];
				switch (colorChar)
				{
					case '0':
						color = Color.Black;
						isOk = true;
						break;
					case '1':
						color = Color.Red;
						isOk = true;
						break;
					case '2':
						color = Color.Green;
						isOk = true;
						break;
					case '3':
						color = Color.Yellow;
						isOk = true;
						break;
					case '4':
						color = Color.Blue;
						isOk = true;
						break;
					case '5':
						color = Color.Magenta;
						isOk = true;
						break;
					case '6':
						color = Color.Cyan;
						isOk = true;
						break;
					case '7':
						color = Color.White;
						isOk = true;
						break;
					default:
						break;

				}
			}

			length = 5;
			return isOk;

		}
	}
}
