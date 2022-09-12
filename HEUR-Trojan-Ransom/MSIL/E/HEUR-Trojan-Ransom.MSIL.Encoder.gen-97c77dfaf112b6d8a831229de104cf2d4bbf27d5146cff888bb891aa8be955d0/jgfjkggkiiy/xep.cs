using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace jgfjkggkiiy;

internal class xep : iep
{
	private readonly UTF8Encoding utf8 = new UTF8Encoding();

	private const uint delta = 2654435769u;

	private byte[] EncryptionKey
	{
		[CompilerGenerated]
		get
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
			return _003CEncryptionKey_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					_003CEncryptionKey_003Ek__BackingField = value;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}
	}

	private byte[] AvatarIconset_HoursPlayedLastTwoWeeksset_PrivacyState
	{
		get
		{
			if (data.Length == 0)
			{
				return data;
			}
			return this.get_NameAwakeReload(RemovePlayerFromGroupStartget_Directory(this.set_MemberSinceRegisterAddGroup(data, value: true), this.set_MemberSinceRegisterAddGroup(ParseStringIsValidCSteamIDget_PrivacyState(key), value: false)), includeLength: false);
		}
	}

	private bool MemberSinceRegisterAddGroup
	{
		set
		{
			int num = data.Length;
			int num2 = (((num & 3) == 0) ? (num >> 2) : ((num >> 2) + 1));
			uint[] array;
			if (value)
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
	}

	private byte[] NameAwakeReload
	{
		get
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
			byte[] array = new byte[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = (byte)(data[i >> 2] >> ((i & 3) << 3));
			}
			return array;
		}
	}

	public byte[] CreateEncryptionKey()
	{
		int num = 0;
		byte[] key = default(byte[]);
		do
		{
			if (num == 1)
			{
				TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
				tripleDESCryptoServiceProvider.KeySize = 192;
				tripleDESCryptoServiceProvider.GenerateKey();
				key = tripleDESCryptoServiceProvider.Key;
				tripleDESCryptoServiceProvider.Dispose();
				num = 2;
			}
			if (num == 2)
			{
				EncryptionKey = key;
				num = 3;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 3);
		return key;
	}

	public byte[] GetEncryptionKey()
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return EncryptionKey;
	}

	public byte[] EncryptBytes(byte[] fileBytes, byte[] encryptionKey)
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		try
		{
			return this.get_AvatarIconset_HoursPlayedLastTwoWeeksset_PrivacyState(fileBytes, encryptionKey);
		}
		catch
		{
			return null;
		}
	}

	private uint GetOpenWindowsIsDependencyLoadedget_AllowedCaller(uint sum, uint y, uint z, int p, uint e, uint[] k)
	{
		int num = 0;
		do
		{
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 1);
		return (((z >> 5) ^ (y << 2)) + ((y >> 3) ^ (z << 4))) ^ ((sum ^ y) + (k[(p & 3) ^ e] ^ z));
	}

	private uint[] RemovePlayerFromGroupStartget_Directory(uint[] v, uint[] k)
	{
		int num = 0;
		int num2 = default(int);
		do
		{
			if (num == 1)
			{
				num2 = v.Length - 1;
				num = 2;
			}
			if (num != 3)
			{
				if (num == 2)
				{
					if (num2 >= 1)
					{
						break;
					}
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
				continue;
			}
			return v;
		}
		while (num != 4);
		uint z = v[num2];
		uint num3 = 0u;
		int num4 = 6 + 52 / (num2 + 1);
		while (0 < num4--)
		{
			num3 += 2654435769u;
			uint e = (num3 >> 2) & 3u;
			int i;
			uint y;
			for (i = 0; i < num2; i++)
			{
				y = v[i + 1];
				z = (v[i] += GetOpenWindowsIsDependencyLoadedget_AllowedCaller(num3, y, z, i, e, k));
			}
			y = v[0];
			z = (v[num2] += GetOpenWindowsIsDependencyLoadedget_AllowedCaller(num3, y, z, i, e, k));
		}
		return v;
	}

	private byte[] ParseStringIsValidCSteamIDget_PrivacyState(byte[] key)
	{
		int num = 0;
		do
		{
			if (num == 1)
			{
				if (key.Length != 16)
				{
					break;
				}
				num = 2;
			}
			switch (num)
			{
			case 0:
				num = 1;
				break;
			case 2:
				return key;
			}
		}
		while (num != 3);
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
}
