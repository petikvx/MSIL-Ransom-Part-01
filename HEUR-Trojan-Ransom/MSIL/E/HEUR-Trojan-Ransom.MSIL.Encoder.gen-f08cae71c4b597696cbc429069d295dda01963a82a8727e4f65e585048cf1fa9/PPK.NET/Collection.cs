using System;
using System.Security.Cryptography;
using System.Text;

namespace PPK.NET;

public class Collection
{
	private readonly byte[] _Code;

	public readonly byte[] consumer;

	public static byte[] byte_0;

	public Collection(string last)
	{
		Class.SetupThread();
		base._002Ector();
		consumer = Encoding.ASCII.GetBytes(last);
		_Code = PrepareCollection(byte_0);
	}

	public byte[] OrderCollection(byte[] asset)
	{
		if (asset.Length == 0)
		{
			return asset;
		}
		return DisableCollection(LogoutCollection(SelectCollection(asset, appendcfg: true), SelectCollection(_Code, appendcfg: false)), secondreguired: false);
	}

	private uint[] LogoutCollection(uint[] instance, uint[] ord)
	{
		int num = instance.Length - 1;
		if (num < 1)
		{
			return instance;
		}
		uint start_third = instance[num];
		uint num2 = 0u;
		int num3 = 6 + 52 / (num + 1);
		while (0 < num3--)
		{
			num2 += 3735929054u;
			uint flagscol = (num2 >> 2) & 3u;
			int i;
			uint indexOf_col;
			for (i = 0; i < num; i++)
			{
				indexOf_col = instance[i + 1];
				start_third = (instance[i] += EnableCollection(num2, indexOf_col, start_third, i, flagscol, ord));
			}
			indexOf_col = instance[0];
			start_third = (instance[num] += EnableCollection(num2, indexOf_col, start_third, i, flagscol, ord));
		}
		return instance;
	}

	private uint EnableCollection(uint last_X, uint indexOf_col, uint start_third, int cont2_Ptr, uint flagscol3, uint[] cfg4)
	{
		return (((start_third >> 5) ^ (indexOf_col << 2)) + ((indexOf_col >> 3) ^ (start_third << 4))) ^ ((last_X ^ indexOf_col) + (cfg4[(cont2_Ptr & 3) ^ flagscol3] ^ start_third));
	}

	private byte[] PrepareCollection(byte[] asset)
	{
		if (asset.Length == 16)
		{
			return asset;
		}
		byte[] array = new byte[16];
		if (asset.Length < 16)
		{
			asset.CopyTo(array, 0);
		}
		else
		{
			Array.Copy(asset, 0, array, 0, 16);
		}
		return array;
	}

	private uint[] SelectCollection(byte[] spec, bool appendcfg)
	{
		int num = spec.Length;
		int num2 = (((num & 3) == 0) ? (num >> 2) : ((num >> 2) + 1));
		uint[] array;
		if (appendcfg)
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
			array[i >> 2] |= (uint)(spec[i] << ((i & 3) << 3));
		}
		return array;
	}

	private byte[] DisableCollection(uint[] init, bool secondreguired)
	{
		int num = init.Length << 2;
		if (secondreguired)
		{
			int num2 = (int)init[^1];
			num -= 4;
			if (num2 < num - 3 || num2 > num)
			{
				return null;
			}
			num = num2;
		}
		byte[] array = new byte[num + consumer.Length];
		Buffer.BlockCopy(consumer, 0, array, 0, consumer.Length);
		for (int i = 0; i < num; i++)
		{
			array[i + consumer.Length] = (byte)(init[i >> 2] >> ((i & 3) << 3));
		}
		return array;
	}

	static Collection()
	{
		Class.SetupThread();
		byte_0 = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(Environment.UserName));
	}
}
