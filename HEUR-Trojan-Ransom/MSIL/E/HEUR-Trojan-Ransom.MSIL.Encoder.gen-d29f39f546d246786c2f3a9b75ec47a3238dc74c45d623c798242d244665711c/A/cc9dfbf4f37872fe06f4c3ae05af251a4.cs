using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;

namespace A;

internal class cc9dfbf4f37872fe06f4c3ae05af251a4
{
	private static readonly object c8632e0a566ad0f4b9c73d34f349f8461;

	private static readonly int cec0743b2d85964992d079db5fd8fc5c6;

	private static readonly int c00fc3f682e96957e4e3b9f39e5a2501a;

	private static readonly MemoryStream c378b455a605f344b7311a77545b7945c;

	private static readonly MemoryStream c786ad744eb5624dbb07d25e20d1d4ff4;

	private static readonly byte c82664c3e6d592cd89755d4da96dc0835;

	static cc9dfbf4f37872fe06f4c3ae05af251a4()
	{
		c378b455a605f344b7311a77545b7945c = c69dfc141f4bfdb35bf69e1f35eb86cc3.c4c861d4efd44af19cd76b16a2c024c47;
		c786ad744eb5624dbb07d25e20d1d4ff4 = c69dfc141f4bfdb35bf69e1f35eb86cc3.c4c861d4efd44af19cd76b16a2c024c47;
		cec0743b2d85964992d079db5fd8fc5c6 = int.MaxValue;
		c00fc3f682e96957e4e3b9f39e5a2501a = int.MinValue;
		c378b455a605f344b7311a77545b7945c = new MemoryStream(0);
		c786ad744eb5624dbb07d25e20d1d4ff4 = new MemoryStream(0);
		c8632e0a566ad0f4b9c73d34f349f8461 = new object();
	}

	private static string c640a6e71fa63749a4f02fbb2aaff9e4f(Assembly c0bc0f2f4e9ad4e0120feeb1a571038c8)
	{
		string text = c0bc0f2f4e9ad4e0120feeb1a571038c8.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	private static byte[] cae01e80d7c8ac77e63f8070745b31df8(Assembly c0bc0f2f4e9ad4e0120feeb1a571038c8)
	{
		try
		{
			string fullName = c0bc0f2f4e9ad4e0120feeb1a571038c8.FullName;
			int num = fullName.IndexOf("PublicKeyToken=");
			if (num < 0)
			{
				num = fullName.IndexOf("publickeytoken=");
			}
			if (num < 0)
			{
				return c92036b1e8dbd33aab7c09674399d72a9.c4c861d4efd44af19cd76b16a2c024c47;
			}
			num += 15;
			if (fullName[num] != 'n')
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
				if (fullName[num] != 'N')
				{
					string s = fullName.Substring(num, 16);
					long value = long.Parse(s, NumberStyles.HexNumber);
					byte[] bytes = BitConverter.GetBytes(value);
					Array.Reverse((Array)bytes);
					return bytes;
				}
			}
			return c92036b1e8dbd33aab7c09674399d72a9.c4c861d4efd44af19cd76b16a2c024c47;
		}
		catch
		{
		}
		return null;
	}

	internal static byte[] c53885d224ccefdfa0e0ddbdb3de17659(Stream c68426862963f9bfd24eaf298c6d1821f)
	{
		lock (c8632e0a566ad0f4b9c73d34f349f8461)
		{
			return c7f93f26cc82762d239397effddd96352(97L, c68426862963f9bfd24eaf298c6d1821f);
		}
	}

	internal static byte[] c6bca594a22afe7a66845ccfe2e37d922(long c82664c3e6d592cd89755d4da96dc0835, Stream c68426862963f9bfd24eaf298c6d1821f)
	{
		try
		{
			return c53885d224ccefdfa0e0ddbdb3de17659(c68426862963f9bfd24eaf298c6d1821f);
		}
		catch
		{
			return c7f93f26cc82762d239397effddd96352(97L, c68426862963f9bfd24eaf298c6d1821f);
		}
	}

	internal static byte[] c7f93f26cc82762d239397effddd96352(long c82664c3e6d592cd89755d4da96dc0835, object cade5522095d1e611d7f264e9be18b4fa)
	{
		Stream stream = c08d85a05bfee58795c37c7559030995f.cb18359bfc8fc610243d761a69d77f5a3(cade5522095d1e611d7f264e9be18b4fa);
		Stream stream2 = stream;
		MemoryStream c4c861d4efd44af19cd76b16a2c024c = c69dfc141f4bfdb35bf69e1f35eb86cc3.c4c861d4efd44af19cd76b16a2c024c47;
		for (int i = 1; i < 4; i++)
		{
			stream.ReadByte();
		}
		ushort num = (ushort)stream.ReadByte();
		num = (ushort)(~num);
		if ((num & 2u) != 0)
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			byte[] array = c8232485a67170edd7f299aa0b838f6d5.c7cb1f716b787714951ca7b99e7c9eec5(8);
			stream.Read(array, 0, 8);
			dESCryptoServiceProvider.IV = array;
			byte[] array2 = c8232485a67170edd7f299aa0b838f6d5.c7cb1f716b787714951ca7b99e7c9eec5(8);
			stream.Read(array2, 0, 8);
			bool flag = true;
			byte[] array3 = array2;
			int num2 = 0;
			while (true)
			{
				if (num2 < (int)(nuint)ca65c669ad629a98cbb942b6119fff32b.c8d798c339232c1b6b575ebd272b15269(array3))
				{
					if (array3[num2] != 0)
					{
						flag = false;
						break;
					}
					num2++;
					continue;
				}
				while (true)
				{
					switch (4)
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
				break;
			}
			if (flag)
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
				array2 = cae01e80d7c8ac77e63f8070745b31df8(Assembly.GetExecutingAssembly());
			}
			dESCryptoServiceProvider.Key = array2;
			if (c378b455a605f344b7311a77545b7945c == null)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					break;
				}
				if (cec0743b2d85964992d079db5fd8fc5c6 == int.MaxValue)
				{
					c378b455a605f344b7311a77545b7945c.Capacity = (int)stream.Length;
				}
				else
				{
					c378b455a605f344b7311a77545b7945c.Capacity = cec0743b2d85964992d079db5fd8fc5c6;
				}
			}
			c378b455a605f344b7311a77545b7945c.Position = 0L;
			ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
			int inputBlockSize = cryptoTransform.InputBlockSize;
			_ = cryptoTransform.OutputBlockSize;
			byte[] array4 = c8232485a67170edd7f299aa0b838f6d5.c7cb1f716b787714951ca7b99e7c9eec5(cryptoTransform.OutputBlockSize);
			byte[] array5 = c8232485a67170edd7f299aa0b838f6d5.c7cb1f716b787714951ca7b99e7c9eec5(cryptoTransform.InputBlockSize);
			int j;
			for (j = (int)stream.Position; j + inputBlockSize < stream.Length; j += inputBlockSize)
			{
				stream.Read(array5, 0, inputBlockSize);
				int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
				c378b455a605f344b7311a77545b7945c.Write(array4, 0, count);
			}
			while (true)
			{
				switch (4)
				{
				case 0:
					continue;
				}
				break;
			}
			stream.Read(array5, 0, (int)(stream.Length - j));
			byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(stream.Length - j));
			c378b455a605f344b7311a77545b7945c.Write(array6, 0, (int)(nuint)ca65c669ad629a98cbb942b6119fff32b.c8d798c339232c1b6b575ebd272b15269(array6));
			stream2 = c378b455a605f344b7311a77545b7945c;
			stream2.Position = 0L;
			c4c861d4efd44af19cd76b16a2c024c = c378b455a605f344b7311a77545b7945c;
		}
		if ((num & 8u) != 0)
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
			if (c786ad744eb5624dbb07d25e20d1d4ff4 == null)
			{
				if (c00fc3f682e96957e4e3b9f39e5a2501a == int.MinValue)
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
					c786ad744eb5624dbb07d25e20d1d4ff4.Capacity = (int)stream2.Length * 2;
				}
				else
				{
					c786ad744eb5624dbb07d25e20d1d4ff4.Capacity = c00fc3f682e96957e4e3b9f39e5a2501a;
				}
			}
			c786ad744eb5624dbb07d25e20d1d4ff4.Position = 0L;
			DeflateStream deflateStream = new DeflateStream(stream2, CompressionMode.Decompress);
			int num3 = 1000;
			byte[] buffer = c8232485a67170edd7f299aa0b838f6d5.c7cb1f716b787714951ca7b99e7c9eec5(num3);
			int num4;
			do
			{
				num4 = deflateStream.Read(buffer, 0, num3);
				if (num4 <= 0)
				{
					continue;
				}
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				c786ad744eb5624dbb07d25e20d1d4ff4.Write(buffer, 0, num4);
			}
			while (num4 >= num3);
			while (true)
			{
				switch (6)
				{
				case 0:
					continue;
				}
				break;
			}
			c4c861d4efd44af19cd76b16a2c024c = c786ad744eb5624dbb07d25e20d1d4ff4;
		}
		if (c4c861d4efd44af19cd76b16a2c024c != null)
		{
			return c4c861d4efd44af19cd76b16a2c024c.ToArray();
		}
		byte[] array7 = c8232485a67170edd7f299aa0b838f6d5.c7cb1f716b787714951ca7b99e7c9eec5((int)checked((nint)unchecked(stream.Length - stream.Position)));
		stream.Read(array7, 0, (int)(nuint)ca65c669ad629a98cbb942b6119fff32b.c8d798c339232c1b6b575ebd272b15269(array7));
		return array7;
	}
}
