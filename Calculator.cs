using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastenTerminal
{
	public enum CalculateType
	{
		Decimal,
		Hexadecimal,
		Binary
	}


	public static class Calculator
	{


		public static void Calculate(CalculateType calculateType, String inputValue,
			ref String decimalString, ref String hexadecimalString, ref String binaryString)
		{
			// Calculate
			Int32 value;

			switch (calculateType)
			{
				case CalculateType.Decimal:
					
					// Convert from decimal to others
					value = Int32.Parse(inputValue);
					decimalString = inputValue;
					hexadecimalString = "0x" + value.ToString("X2");	// "x" is good
					binaryString = DecimalToBinary(value);
					
					break;

				case CalculateType.Binary:

					// Convert from binary to others
					value = BinaryStringToDecimal(inputValue);
					if (value != -1)
					{
						// Successful converted binary value to Int32
						decimalString = value.ToString();
						hexadecimalString = value.ToString("X2");	// "x" is good
						binaryString = inputValue;
					}
					else
					{
						decimalString = "-";
						hexadecimalString = "-";
						binaryString = inputValue;
					}
					break;

				case CalculateType.Hexadecimal:

					// Convert from hexacimal to others
					try
					{
						value = Convert.ToInt32(inputValue, 16);
					}
					catch
					{
						value = -1;
					}
					
					if (value != -1)
					{
						// Successful converted binary value to Int32
						decimalString = value.ToString();
						hexadecimalString = inputValue;
						binaryString = DecimalToBinary(value);
					}
					else
					{
						decimalString = "-";
						hexadecimalString = inputValue;
						binaryString = "-";
					}

					break;

				default:

					break;

			}
		}


		public static string DecimalToBinary(int value)
		{
			string binaryValue = "";
			int i = 0;

			while (value >= 0)
			{
				i++;
				// Put digit
				if ((value % 2) == 1)
				{
					binaryValue = "1" + binaryValue;
				}
				else
				{
					binaryValue = "0" + binaryValue;
				}

				// Put space
				if ((i % 4) == 0)
				{
					binaryValue = " " + binaryValue;
				}

				// Shift value
				value >>= 1;

				if (value == 0)
				{
					break;
				}

			}

			return binaryValue;
		}


		public static Int32 BinaryStringToDecimal (string boolValue)
		{
			Int32 value = 0;

			int i;
			for (i = 0; i < boolValue.Length; i++ )
			{
				// Shift to left
				
				if ( boolValue[i] == '1' )
				{
					value <<= 1;
					// If bit = 1
					value += 1;
				}
				else if ( boolValue[i] == '0' )
				{
					value <<= 1;
					// Value += 0;
				}
				else if ( boolValue[i] == ' ' )
				{
					// space, skipped
				}
				else
				{
					// Error, not 0 and not 1!
					return -1;
				}
			}

			return value;

		}


	}	// End of class
}	// End of namespace
