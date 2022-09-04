using System;

namespace rundll32.encryption;

internal class xor
{
	private static string _b64 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijk.mnopqrstuvwxyz-123456789+/=";

	public static string encrypt(string data, string key)
	{
		int num = 0;
		string text = "";
		foreach (char c in data)
		{
			int value = (c ^ key[num]) + key.Length;
			if (++num >= key.Length)
			{
				num = 0;
			}
			text += DecToBinary(value, 8);
		}
		int num2 = 0;
		string text2 = "";
		for (int j = 0; j < text.Length; j += 4)
		{
			int num3 = BinToDec(text.Substring(j, 4));
			text2 += GetB64FromN(num3 * 4 + num2);
			if (++num2 > 3)
			{
				num2 = 0;
			}
		}
		return text2;
	}

	public static string decrypt(string data, string key)
	{
		int num = 0;
		string text = "";
		foreach (char n in data)
		{
			int value = (GetNFromB64(n) - num) / 4;
			text += DecToBinary(value, 4);
			if (++num > 3)
			{
				num = 0;
			}
		}
		int num2 = 0;
		string text2 = "";
		for (int j = 0; j < text.Length && j + 8 <= text.Length; j += 8)
		{
			int num3 = BinToDec(text.Substring(j, 8));
			int num4 = (num3 - key.Length) ^ key[num2];
			if (++num2 >= key.Length)
			{
				num2 = 0;
			}
			text2 += new string((char)num4, 1);
		}
		return text2;
	}

	private static int GetNFromB64(char n)
	{
		return _b64.IndexOf(n);
	}

	private static string GetB64FromN(int n)
	{
		if (n > _b64.Length)
		{
			return "=";
		}
		return new string(_b64[n], 1);
	}

	private static string DecToBinary(int value, int length)
	{
		string text = "";
		while (value > 0)
		{
			text += value % 2;
			value /= 2;
		}
		string text2 = "";
		string text3 = text;
		foreach (char c in text3)
		{
			text2 = new string(c, 1) + text2;
		}
		text = text2;
		return new string('0', length - text.Length) + text;
	}

	private static int BinToDec(string Binary)
	{
		return Convert.ToInt32(Binary, 2);
	}
}
