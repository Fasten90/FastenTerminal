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
		Escape_TextFormat,
		Escape_CursorMoving,
		Escape_Short_NeedAppend,
		Escape_Skip_NotImplemented,
		Escape_Wrong
	}

    public enum FormatType
    {
        FormatType_Nothing,

        FormatType_BackgroundColor,
        FormatType_TextColor,

        FormatType_Reset,
        FormatType_Bold,
        FormatType_Underscore,
    }

	public static class EscapeSequence
	{

		public static EscapeType ProcessEscapeMessage(String message, out int stringLength, out List<FormatType> formatList, out List<Color> colorList)
		{
			// Search Escape character
			stringLength = message.Length;

			EscapeType escapeType = EscapeType.Escape_Nothing;
			int length = 0;

            formatList = new List<FormatType>();
            colorList = new List<Color>();

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

                    results = GetTextFormats(message.Substring(startIndex), out escapeType, out formatList, out colorList, out length);
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
                    // else if (escapeType == EscapeType.Wrong...) --> not need to do anything
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
        /// Get TextFormat (format or color from string (within escape sequences ... e.g. ESC[31m...))
        /// </summary>
        /// <param name="escapeMessage"></param>
        /// <returns></returns>
        private static bool GetTextFormats(String escapeMessage, out EscapeType escapeType, out List<FormatType> formatList, out List<Color> colorList, out int length)
        {
            // Substring after ESC
            // ANSI Escape: https://en.wikipedia.org/wiki/ANSI_escape_code
            // ESC[31m
            // Coloring:
            // ESC[39m
            // ESC[31m
            // Format clear
            // ESC[0m - for
            //0x1B
            //const char ESC = '\x1B';
            //(char)27).ToString());

            bool isOk = false;

            escapeType = EscapeType.Escape_Nothing;
            formatList = new List<FormatType>();
            colorList = new List<Color>();

			length = 0;
            int escapeFinishPos = 0;

            if (escapeMessage.StartsWith(((char)27).ToString()))
			{
                // Minimal length: "ESC[0m"
				if (escapeMessage.Length >= 4)
                {
					if (escapeMessage[1] == '[')
					{
                        // Good next character
                        escapeFinishPos = escapeMessage.IndexOf('m');
                        if (escapeFinishPos >= 3)
                        {
                            // Has 'm', so escape sequence is finished
                            isOk = true;
                            // Cutted string from '[' to 'm'
                            escapeMessage = escapeMessage.Substring(2, escapeFinishPos - 2);

                            // Check ';' (list separater)
                            if (escapeMessage.IndexOf(';') >= 0)
                            {
                                // It is list
                                String[] colorStrings = escapeMessage.Split(';');

                                Color newColor;
                                FormatType newFormat;

                                foreach (String colorString in colorStrings)
                                {
                                    if (GetColorFromCode(colorString, out newColor, out newFormat))
                                    {
                                        // Good
                                        // Add to list
                                        colorList.Add(newColor);
                                        formatList.Add(newFormat);

                                        isOk = true;
                                        escapeType = EscapeType.Escape_TextFormat;
                                    }
                                    else
                                    {
                                        // Wrong ---> return
                                        isOk = false;
                                        escapeType = EscapeType.Escape_Wrong;
                                    }
                                }
                            }
                            else
                            {
                                // Not list, has only one parameter
                                Color newColor;
                                FormatType newFormat;
                                if (GetColorFromCode(escapeMessage, out newColor, out newFormat))
                                {
                                    // Good code
                                    colorList.Add(newColor);
                                    formatList.Add(newFormat);

                                    isOk = true;
                                    escapeType = EscapeType.Escape_TextFormat;
                                }
                                else
                                {
                                    // Not good code
                                    isOk = false;
                                    escapeType = EscapeType.Escape_Wrong;
                                }
                            }

                            if(isOk)
                            {
                                // If escape sequence is good, set the "delete length". (end position + 1)
                                length = escapeFinishPos + 1;
                            }
                        }
                        else
                        {
                            // There is no 'm' - Wrong or not finished
                            isOk = false;
                            escapeType = EscapeType.Escape_Short_NeedAppend;
                        }
					}
					else
					{
                        // '[' not found, WRONG!
						isOk = false;
						escapeType = EscapeType.Escape_Wrong;
					}
                }
				else
				{
                    // Too short, check "later"
					isOk = false;
					escapeType = EscapeType.Escape_Short_NeedAppend;
				}
			}
			else
			{
                // Not started with ESC, wrong!
				isOk = false;
                escapeType = EscapeType.Escape_Wrong;
            }

			return isOk;
		}

        private static bool GetColorFromCode(string colorString, out Color color, out FormatType format)
        {
            bool isOk = false;
            bool isColor = false;
            char formatChar = '\0';

            format = FormatType.FormatType_Nothing;
            color = Color.Empty;

            if (colorString.Length == 2)
            {
                if (colorString[0] == '3')
                {
                    isColor = true;
                    format = FormatType.FormatType_TextColor;
                    formatChar = colorString[1];
                }
                else if (colorString[0] == '4')
                {
                    isColor = true;
                    format = FormatType.FormatType_BackgroundColor;
                    formatChar = colorString[1];
                }
                else
                {
                    // Two character but not background and color. It is wrong
                    isOk = false;
                    return isOk;
                }
            }
            else if (colorString.Length == 1)
            {
                formatChar = colorString[0];
                // color = not used
                // format = will set at below
            }
            else
            {
                // Wrong
                isOk = false;
                return isOk;
            }


            // Only received this code, if we can check the formatChar
            // Check color
            if (isColor)
            {
                // Color
                switch (formatChar)
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
                        color = Color.Empty;
                        break;
                }
            }
            else
            {
                // Not color - it is text attribute
                switch (formatChar)
                {
                    case '0':
                        format = FormatType.FormatType_Reset;
                        isOk = true;
                        break;

                    case '1':
                        format = FormatType.FormatType_Bold;
                        isOk = true;
                        break;

                    case '4':
                        format = FormatType.FormatType_Underscore;
                        isOk = true;
                        break;

                    case '5':
                    case '7':
                    case '8':
                        // Blink on - now not used
                        format = FormatType.FormatType_Nothing;
                        isOk = true;
                        break;

                    default:
                        // Wrong character...
                        isOk = false;
                        break;
                }
            }

            return isOk;
        }
	}
}


