using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

internal class o
{
	private static readonly object m_a;

	private static readonly int m_b;

	private static readonly int m_c;

	private static readonly MemoryStream m_d;

	private static readonly MemoryStream m_e;

	private static readonly byte f;

	static o()
	{
		o.m_d = t.a;
		o.m_e = t.a;
		o.m_b = int.MaxValue;
		o.m_c = int.MinValue;
		o.m_d = new MemoryStream(0);
		o.m_e = new MemoryStream(0);
		o.m_a = new object();
	}

	private static string a(Assembly P_0)
	{
		string text = P_0.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	private unsafe static byte[] b(Assembly P_0)
	{
		try
		{
			string? fullName = P_0.FullName;
			_003CModule_003E.h = 2081625616;
			string text = fullName;
			h.a = -1592516334;
			int num = text.IndexOf(_003CModule_003E.c((int)((237 + num - -8511 == ~num) ? ((nint)Type.EmptyTypes.LongLength + 1849254090) : ((nint)Type.EmptyTypes.LongLength + 23728)), (int)((nint)Type.EmptyTypes.LongLength + 24785), (int)((nint)Type.EmptyTypes.LongLength + 240)));
			if (num < 0)
			{
				while (true)
				{
					switch (3)
					{
					case 0:
						continue;
					}
					break;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
					byte[] array;
					j.g = array;
				}
				num = text.IndexOf(_003CModule_003E.c((((num & -2093841770) ^ 0x2000169E) == 0) ? checked(2038461982 + -52485310) : 72272, sizeof(float) + 73034, checked(61 * 2)));
			}
			int num2 = num;
			_003CModule_003E.h = 1308380089;
			_003CModule_003E.p = 401140706;
			if (num2 < 0)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						break;
					default:
						return r.a;
					}
				}
			}
			num += 15;
			if (text[num] != 'n')
			{
				if (text[num] != 'N')
				{
					string text2 = text.Substring(num, 16);
					long value = long.Parse(text2, NumberStyles.HexNumber);
					_003CModule_003E.p = 1809257038;
					byte[] bytes = BitConverter.GetBytes(value);
					Array.Reverse((Array)bytes);
					_003CModule_003E.n = 1526447315;
					return bytes;
				}
				while (true)
				{
					switch (1)
					{
					case 0:
						continue;
					}
					break;
				}
			}
			return r.a;
		}
		catch
		{
		}
		_003CModule_003E.l = 796469985;
		return null;
	}

	internal static byte[] c(Stream P_0)
	{
		lock (o.m_a)
		{
			return e(97L, P_0);
		}
	}

	internal static byte[] d(long P_0, Stream P_1)
	{
		try
		{
			return c(P_1);
		}
		catch (HostProtectionException)
		{
			return e(97L, P_1);
		}
	}

	internal static byte[] e(long P_0, Stream P_1)
	{
		Stream stream = P_1;
		MemoryStream memoryStream = t.a;
		ushort num = (ushort)P_1.ReadByte();
		num = (ushort)(~num);
		for (int num2 = 1; num2 < 4; num2++)
		{
			P_1.ReadByte();
		}
		bool flag = default(bool);
		if ((num & 2u) != 0)
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			_003CModule_003E.l = -1437277352;
			byte[] array = s.a(8);
			P_1.Read(array, 0, 8);
			_003CModule_003E.h = -1980982856;
			dESCryptoServiceProvider.IV = array;
			byte[] array2 = s.a(8);
			P_1.Read(array2, 0, 8);
			flag = true;
			byte[] array3 = array2;
			int num3 = 0;
			while (true)
			{
				if (num3 < array3.Length)
				{
					if (array3[num3] != 0)
					{
						flag = false;
						break;
					}
					num3++;
					continue;
				}
				while (true)
				{
					switch (3)
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
				array2 = b(Assembly.GetExecutingAssembly());
			}
			dESCryptoServiceProvider.Key = array2;
			if (o.m_d == null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					break;
				}
				if (o.m_b == int.MaxValue)
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
					o.m_d.Capacity = (int)P_1.Length;
				}
				else
				{
					o.m_d.Capacity = o.m_b;
				}
			}
			w.c = stream;
			o.m_d.Position = 0L;
			ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
			int inputBlockSize = cryptoTransform.InputBlockSize;
			_ = cryptoTransform.OutputBlockSize;
			byte[] array4 = s.a(cryptoTransform.OutputBlockSize);
			byte[] array5 = s.a(cryptoTransform.InputBlockSize);
			int num4;
			for (num4 = (int)P_1.Position; num4 + inputBlockSize < P_1.Length; num4 += inputBlockSize)
			{
				P_1.Read(array5, 0, inputBlockSize);
				int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
				o.m_d.Write(array4, 0, count);
			}
			while (true)
			{
				switch (3)
				{
				case 0:
					continue;
				}
				break;
			}
			P_1.Read(array5, 0, (int)(P_1.Length - num4));
			byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(P_1.Length - num4));
			o.m_d.Write(array6, 0, array6.Length);
			stream = o.m_d;
			stream.Position = 0L;
			memoryStream = o.m_d;
		}
		if ((num & 8u) != 0)
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
			try
			{
				if (o.m_e == null)
				{
					int num5 = o.m_c;
					_003CModule_003E.c = flag;
					if (num5 == int.MinValue)
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
						o.m_e.Capacity = (int)stream.Length * 2;
					}
					else
					{
						o.m_e.Capacity = o.m_c;
					}
				}
				o.m_e.Position = 0L;
				DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
				int num6 = 1000;
				byte[] buffer = s.a(num6);
				int num7;
				do
				{
					num7 = deflateStream.Read(buffer, 0, num6);
					if (num7 <= 0)
					{
						continue;
					}
					while (true)
					{
						switch (3)
						{
						case 0:
							continue;
						}
						break;
					}
					o.m_e.Write(buffer, 0, num7);
				}
				while (num7 >= num6);
				memoryStream = o.m_e;
			}
			catch (Exception)
			{
			}
		}
		if (memoryStream != null)
		{
			while (true)
			{
				switch (1)
				{
				case 0:
					break;
				default:
					return memoryStream.ToArray();
				}
			}
		}
		byte[] array7 = s.a((int)checked((nint)unchecked(P_1.Length - P_1.Position)));
		P_1.Read(array7, 0, array7.Length);
		return array7;
	}
}
