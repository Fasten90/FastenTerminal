﻿using System;
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
		Escape_Short_NeedAppend,
		Escape_Skip_NotImplemented,
		Escape_Wrong
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
					// The first character is not the ESC, first should print string
					stringLength = startIndex;
					return EscapeType.Escape_StringWithoutEscape;
                    // If startIndex is not 0, do not process more time
				}

                bool results;
                bool needAppend = false;

                // Check it is CLS?
                results = GetItIsClearScreen(message.Substring(startIndex), out escapeType, out length);
                if (results)
				{
					// It is CLS (Clear screen)
					stringLength = length;
				}
                else if (escapeType == EscapeType.Escape_Short_NeedAppend)
                {
                    needAppend = true;
                }

                if (!results)
                {
                    // Jump top left			
                    results = GetItIsStepStopLeft(message.Substring(startIndex), out escapeType, out length);
                    if (results)
                    {
                        // It is CLS (Clear screen)
                        stringLength = length;
                    }
                    else if (escapeType == EscapeType.Escape_Short_NeedAppend)
                    {
                        needAppend = true;
                    }
                }

                if (!results)
                {
                    // Check it is  color escape?
                    results = GetColor(message.Substring(startIndex), out color, out escapeType, out length);
                    if (results)
                    {
                        // It is color escape
                        // Check next string (which can sending)
                        stringLength = length;
                    }
                    else if (escapeType == EscapeType.Escape_Short_NeedAppend)
                    {
                        needAppend = true;
                    }
                }

                // Wrong escape character, skip first escape char
                // TODO: This check only the last "Short_NeedAppend"
                if (needAppend)
				{
					// Need append the next string
					stringLength = message.Length;
					return EscapeType.Escape_Short_NeedAppend;
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
            // E.g. ESC[2J
			// n = 2, entire display clear
			length = 0;
			escapeType = EscapeType.Escape_Nothing;

			if (escapeMessage.Length >= 4)
			{
				// Good length
				if (escapeMessage.StartsWith(((char)27).ToString() + "[2J"))
				{
					// Good
					length = 4;
					escapeType = EscapeType.Escape_CLS;
					return true;
				}
				else
				{
					escapeType = EscapeType.Escape_Wrong;
					return false;
				}
			}
			else
			{
				escapeType = EscapeType.Escape_Short_NeedAppend;
				return false;
			}
		}



		private static bool GetItIsStepStopLeft(string escapeMessage, out EscapeType escapeType, out int length)
		{
			// CSI ;1H
			// E.g.: ESC[1;1H
			// Jump cursor to step top left
			length = 0;
			escapeType = EscapeType.Escape_Nothing;

			if (escapeMessage.Length >= 6)
			{
				// Good length
				if (escapeMessage.StartsWith(((char)27).ToString() + "[1;1H"))
				{
					// Good
					length = 6;
					escapeType = EscapeType.Escape_Skip_NotImplemented;
					return true;
				}
				else
				{
					// Wrong
					escapeType = EscapeType.Escape_Wrong;
					return false;
				}
			}
			else
			{
				// Short
				escapeType = EscapeType.Escape_Short_NeedAppend;
				return false;
			}
		}



		/// <summary>
		/// Get color from string (within escape sequences ... ESC[31m...)
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

			if (escapeMessage.StartsWith(((char)27).ToString()))
			{
				if (escapeMessage.Length >= 2)
				{
					if (escapeMessage[1] == '[')
					{
						isOk = true;
					}
					else
					{
						isOk = false;
						escapeType = EscapeType.Escape_Wrong;
					}
				}
				else
				{
					isOk = false;
					escapeType = EscapeType.Escape_Short_NeedAppend;
				}
					
				if (escapeMessage.Length >= 3)
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
						isOk = false;
						escapeType = EscapeType.Escape_Wrong;
					}
				}
				else
				{
					escapeType = EscapeType.Escape_Short_NeedAppend;
				}

				if (escapeMessage.Length >= 4)
				{
					// Check color
					switch (escapeMessage[3])
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
							isOk = false;
							escapeType = EscapeType.Escape_Wrong;
							break;
					}
				}
				else
				{
					isOk = false;
					escapeType = EscapeType.Escape_Short_NeedAppend;
				}

				// Check 'm' character at end
				// TODO: Last check, it is not good for us
				if (escapeMessage.Length >= 5)
				{
					if (escapeMessage[4] == 'm')
					{
						isOk = true;
						//escapeType has good value
					}
					else
					{
						isOk = false;
						escapeType = EscapeType.Escape_Wrong;
					}
				}
				else
				{
					isOk = false;
					escapeType = EscapeType.Escape_Short_NeedAppend;
				}
			}
			else
			{
				isOk = false;
			}

			if (isOk)
			{
				length = 5;
			}

			return isOk;
		}
	}
}


