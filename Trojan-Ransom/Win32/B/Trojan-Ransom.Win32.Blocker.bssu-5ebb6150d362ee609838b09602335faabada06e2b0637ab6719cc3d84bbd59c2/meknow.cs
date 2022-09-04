using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

public class meknow
{
	public const char StandardPaddingChar = '=';

	public const string urlStandardAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";

	public const string ZurlAlphabet = "ybndrfg8ejkmcpqxot1uwisza345h769";

	public char PaddingChar;

	public bool UsePadding;

	public bool IsCaseSensitive;

	public bool IgnoreWhiteSpaceWhenDecoding;

	private readonly string _alphabet;

	private Dictionary<string, uint> _index;

	private Dictionary<string, Dictionary<string, uint>> _indexes = new Dictionary<string, Dictionary<string, uint>>(2, StringComparer.InvariantCulture);

	public meknow()
		: this(padding: false, caseSensitive: false, ignoreWhiteSpaceWhenDecoding: false, "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567")
	{
	}

	public meknow(bool padding)
		: this(padding, caseSensitive: false, ignoreWhiteSpaceWhenDecoding: false, "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567")
	{
	}

	public meknow(bool padding, bool caseSensitive)
		: this(padding, caseSensitive, ignoreWhiteSpaceWhenDecoding: false, "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567")
	{
	}

	public meknow(bool padding, bool caseSensitive, bool ignoreWhiteSpaceWhenDecoding)
		: this(padding, caseSensitive, ignoreWhiteSpaceWhenDecoding, "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567")
	{
	}

	public meknow(string alternateAlphabet)
		: this(padding: false, caseSensitive: false, ignoreWhiteSpaceWhenDecoding: false, alternateAlphabet)
	{
	}

	public meknow(bool padding, bool caseSensitive, bool ignoreWhiteSpaceWhenDecoding, string alternateAlphabet)
	{
		_ = alternateAlphabet.Length;
		PaddingChar = '=';
		UsePadding = padding;
		IsCaseSensitive = caseSensitive;
		IgnoreWhiteSpaceWhenDecoding = ignoreWhiteSpaceWhenDecoding;
		_alphabet = alternateAlphabet;
	}

	public byte[] lol(string input, string input2)
	{
		return new meknow().Decode(input);
	}

	public byte[] Decode(string input)
	{
		if (IgnoreWhiteSpaceWhenDecoding)
		{
			input = Regex.Replace(input, "\\s+", "");
		}
		if (UsePadding)
		{
			if (input.Length % 8 != 0)
			{
				throw new ArgumentException("Invalid length for a url string with padding.");
			}
			input = input.TrimEnd(new char[1] { PaddingChar });
		}
		EnsureAlphabetIndexed();
		MemoryStream memoryStream = new MemoryStream(Math.Max((int)Math.Ceiling((double)(input.Length * 5) / 8.0), 1));
		for (int i = 0; i < input.Length; i += 8)
		{
			int num = Math.Min(input.Length - i, 8);
			ulong num2 = 0uL;
			int num3 = (int)Math.Floor((double)num * 0.625);
			for (int j = 0; j < num; j++)
			{
				if (_index.TryGetValue(input.Substring(i + j, 1), out var value))
				{
					num2 |= (ulong)value << (num3 + 1) * 8 - j * 5 - 5;
					continue;
				}
				throw new ArgumentException("Invalid character '" + input.Substring(i + j, 1) + "' in url string, valid characters are: " + _alphabet);
			}
			byte[] bytes = BitConverter.GetBytes(num2);
			Array.Reverse((Array)bytes);
			memoryStream.Write(bytes, bytes.Length - (num3 + 1), num3);
		}
		return memoryStream.ToArray();
	}

	private void EnsureAlphabetIndexed()
	{
		if (_index != null)
		{
			return;
		}
		string key = (IsCaseSensitive ? "S" : "I") + _alphabet;
		if (!_indexes.TryGetValue(key, out var value))
		{
			lock (_indexes)
			{
				if (!_indexes.TryGetValue(key, out value))
				{
					value = new Dictionary<string, uint>(_alphabet.Length, IsCaseSensitive ? StringComparer.InvariantCulture : StringComparer.InvariantCultureIgnoreCase);
					for (int i = 0; i < _alphabet.Length; i++)
					{
						value[_alphabet.Substring(i, 1)] = (uint)i;
					}
					_indexes.Add(key, value);
				}
			}
		}
		_index = value;
	}
}
