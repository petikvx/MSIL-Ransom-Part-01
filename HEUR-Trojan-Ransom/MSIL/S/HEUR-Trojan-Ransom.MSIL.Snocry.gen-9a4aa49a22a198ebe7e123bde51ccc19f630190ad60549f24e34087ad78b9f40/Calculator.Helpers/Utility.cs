using System;
using System.Globalization;

namespace Calculator.Helpers;

internal static class Utility
{
	public static byte[] ConvertHexStringToByteArray(string hstring)
	{
		if (hstring.Length % 2 != 0)
		{
			throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", new object[1] { hstring }));
		}
		byte[] array = new byte[hstring.Length / 2];
		for (int i = 0; i < array.Length; i++)
		{
			string s = hstring.Substring(i * 2, 2);
			array[i] = byte.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
		}
		return array;
	}

	public static string RandomString(int length)
	{
		Random random = new Random();
		string text = string.Empty;
		char[] array = "ящертюиопасдфгхй金明铼消圻戎痱飞情呢朔姆内卜重1234567890!@#$%^&*()_+=-*/".ToCharArray();
		for (int i = 0; i < length; i++)
		{
			text += array[random.Next(array.Length)];
		}
		return text;
	}
}
