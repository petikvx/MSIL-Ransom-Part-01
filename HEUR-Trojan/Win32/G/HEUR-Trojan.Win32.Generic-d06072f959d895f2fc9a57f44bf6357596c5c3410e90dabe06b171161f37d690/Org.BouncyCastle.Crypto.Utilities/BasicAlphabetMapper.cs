using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Utilities;

public class BasicAlphabetMapper : IAlphabetMapper
{
	private readonly IDictionary indexMap = Platform.CreateHashtable();

	private readonly IDictionary charMap = Platform.CreateHashtable();

	public int Radix => indexMap.Count;

	public BasicAlphabetMapper(string alphabet)
		: this(alphabet.ToCharArray())
	{
	}

	public BasicAlphabetMapper(char[] alphabet)
	{
		int num = 0;
		while (true)
		{
			if (num != alphabet.Length)
			{
				if (indexMap.Contains(alphabet[num]))
				{
					break;
				}
				indexMap.Add(alphabet[num], num);
				charMap.Add(num, alphabet[num]);
				num++;
				continue;
			}
			return;
		}
		throw new ArgumentException("duplicate key detected in alphabet: " + alphabet[num]);
	}

	public byte[] ConvertToIndexes(char[] input)
	{
		byte[] array;
		if (indexMap.Count <= 256)
		{
			array = new byte[input.Length];
			for (int i = 0; i != input.Length; i++)
			{
				array[i] = (byte)(int)indexMap[input[i]];
			}
		}
		else
		{
			array = new byte[input.Length * 2];
			for (int j = 0; j != input.Length; j++)
			{
				int num = (int)indexMap[input[j]];
				array[j * 2] = (byte)((uint)(num >> 8) & 0xFFu);
				array[j * 2 + 1] = (byte)((uint)num & 0xFFu);
			}
		}
		return array;
	}

	public char[] ConvertToChars(byte[] input)
	{
		char[] array;
		if (charMap.Count <= 256)
		{
			array = new char[input.Length];
			for (int i = 0; i != input.Length; i++)
			{
				array[i] = (char)charMap[input[i] & 0xFF];
			}
		}
		else
		{
			if (((uint)input.Length & (true ? 1u : 0u)) != 0)
			{
				throw new ArgumentException("two byte radix and input string odd.Length");
			}
			array = new char[input.Length / 2];
			for (int j = 0; j != input.Length; j += 2)
			{
				array[j / 2] = (char)charMap[((input[j] << 8) & 0xFF00) | (input[j + 1] & 0xFF)];
			}
		}
		return array;
	}
}
