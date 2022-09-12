using System;
using System.Linq;
using System.Text;

namespace BankiaCry;

public static class Base32
{
	private const string Base32AllowedCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";

	public static string ToBase32String(this byte[] input, bool addPadding = true)
	{
		if (input == null || input.Length == 0)
		{
			return string.Empty;
		}
		string bits = input.Select((byte b) => Convert.ToString(b, 2).PadLeft(8, '0')).Aggregate((string a, string b) => a + b).PadRight((int)(Math.Ceiling((double)(input.Length * 8) / 5.0) * 5.0), '0');
		string text = (from i in Enumerable.Range(0, bits.Length / 5)
			select "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567".Substring(Convert.ToInt32(bits.Substring(i * 5, 5), 2), 1)).Aggregate((string a, string b) => a + b);
		if (addPadding)
		{
			text = text.PadRight((int)(Math.Ceiling((double)text.Length / 8.0) * 8.0), '=');
		}
		return text;
	}

	public static string EncodeAsBase32String(this string input, bool addPadding = true)
	{
		if (string.IsNullOrEmpty(input))
		{
			return string.Empty;
		}
		byte[] bytes = Encoding.UTF8.GetBytes(input);
		return bytes.ToBase32String(addPadding);
	}

	public static string DecodeFromBase32String(this string input)
	{
		if (string.IsNullOrEmpty(input))
		{
			return string.Empty;
		}
		byte[] bytes = input.ToByteArray();
		return Encoding.UTF8.GetString(bytes);
	}

	public static byte[] ToByteArray(this string input)
	{
		if (string.IsNullOrEmpty(input))
		{
			return new byte[0];
		}
		string bits = (from c in input.TrimEnd(new char[1] { '=' }).ToUpper().ToCharArray()
			select Convert.ToString("ABCDEFGHIJKLMNOPQRSTUVWXYZ234567".IndexOf(c), 2).PadLeft(5, '0')).Aggregate((string a, string b) => a + b);
		return (from i in Enumerable.Range(0, bits.Length / 8)
			select Convert.ToByte(bits.Substring(i * 8, 8), 2)).ToArray();
	}
}
