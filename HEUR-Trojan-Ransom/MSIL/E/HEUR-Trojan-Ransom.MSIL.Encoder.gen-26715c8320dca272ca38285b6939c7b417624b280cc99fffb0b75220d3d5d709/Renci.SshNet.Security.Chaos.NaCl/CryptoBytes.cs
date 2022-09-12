using System;

namespace Renci.SshNet.Security.Chaos.NaCl;

internal static class CryptoBytes
{
	internal static bool ConstantTimeEquals(byte[] x, byte[] y)
	{
		if (x == null)
		{
			throw new ArgumentNullException("x");
		}
		if (y == null)
		{
			throw new ArgumentNullException("y");
		}
		if (x.Length != y.Length)
		{
			throw new ArgumentException("x.Length must equal y.Length");
		}
		return InternalConstantTimeEquals(x, 0, y, 0, x.Length) != 0;
	}

	internal static bool ConstantTimeEquals(ArraySegment<byte> x, ArraySegment<byte> y)
	{
		if (x.Array == null)
		{
			throw new ArgumentNullException("x.Array");
		}
		if (y.Array == null)
		{
			throw new ArgumentNullException("y.Array");
		}
		if (x.Count != y.Count)
		{
			throw new ArgumentException("x.Count must equal y.Count");
		}
		return InternalConstantTimeEquals(x.Array, x.Offset, y.Array, y.Offset, x.Count) != 0;
	}

	internal static bool ConstantTimeEquals(byte[] x, int xOffset, byte[] y, int yOffset, int length)
	{
		if (x == null)
		{
			throw new ArgumentNullException("x");
		}
		if (xOffset < 0)
		{
			throw new ArgumentOutOfRangeException("xOffset", "xOffset < 0");
		}
		if (y == null)
		{
			throw new ArgumentNullException("y");
		}
		if (yOffset < 0)
		{
			throw new ArgumentOutOfRangeException("yOffset", "yOffset < 0");
		}
		if (length < 0)
		{
			throw new ArgumentOutOfRangeException("length", "length < 0");
		}
		if (x.Length - xOffset < length)
		{
			throw new ArgumentException("xOffset + length > x.Length");
		}
		if (y.Length - yOffset < length)
		{
			throw new ArgumentException("yOffset + length > y.Length");
		}
		return InternalConstantTimeEquals(x, xOffset, y, yOffset, length) != 0;
	}

	private static uint InternalConstantTimeEquals(byte[] x, int xOffset, byte[] y, int yOffset, int length)
	{
		int num = 0;
		for (int i = 0; i < length; i++)
		{
			num |= x[xOffset + i] ^ y[yOffset + i];
		}
		return 1u & ((uint)(num - 1) >> 8);
	}

	internal static void Wipe(byte[] data)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		InternalWipe(data, 0, data.Length);
	}

	internal static void Wipe(byte[] data, int offset, int count)
	{
		if (data == null)
		{
			throw new ArgumentNullException("data");
		}
		if (offset < 0)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		if (count < 0)
		{
			throw new ArgumentOutOfRangeException("count", "Requires count >= 0");
		}
		if ((uint)(offset + count) > (uint)data.Length)
		{
			throw new ArgumentException("Requires offset + count <= data.Length");
		}
		InternalWipe(data, offset, count);
	}

	internal static void Wipe(ArraySegment<byte> data)
	{
		if (data.Array == null)
		{
			throw new ArgumentNullException("data.Array");
		}
		InternalWipe(data.Array, data.Offset, data.Count);
	}

	internal static void InternalWipe(byte[] data, int offset, int count)
	{
		Array.Clear(data, offset, count);
	}

	internal static void InternalWipe<T>(ref T data) where T : struct
	{
		data = default(T);
	}

	internal static string ToHexStringUpper(byte[] data)
	{
		if (data == null)
		{
			return null;
		}
		char[] array = new char[data.Length * 2];
		for (int i = 0; i < data.Length; i++)
		{
			int num = data[i] >> 4;
			array[i * 2] = (char)(55 + num + ((num - 10 >> 31) & -7));
			num = data[i] & 0xF;
			array[i * 2 + 1] = (char)(55 + num + ((num - 10 >> 31) & -7));
		}
		return new string(array);
	}

	internal static string ToHexStringLower(byte[] data)
	{
		if (data == null)
		{
			return null;
		}
		char[] array = new char[data.Length * 2];
		for (int i = 0; i < data.Length; i++)
		{
			int num = data[i] >> 4;
			array[i * 2] = (char)(87 + num + ((num - 10 >> 31) & -39));
			num = data[i] & 0xF;
			array[i * 2 + 1] = (char)(87 + num + ((num - 10 >> 31) & -39));
		}
		return new string(array);
	}

	internal static byte[] FromHexString(string hexString)
	{
		if (hexString == null)
		{
			return null;
		}
		if (hexString.Length % 2 != 0)
		{
			throw new FormatException("The hex string is invalid because it has an odd length");
		}
		byte[] array = new byte[hexString.Length / 2];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
		}
		return array;
	}

	internal static string ToBase64String(byte[] data)
	{
		if (data == null)
		{
			return null;
		}
		return Convert.ToBase64String(data);
	}

	internal static byte[] FromBase64String(string s)
	{
		if (s == null)
		{
			return null;
		}
		return Convert.FromBase64String(s);
	}
}
