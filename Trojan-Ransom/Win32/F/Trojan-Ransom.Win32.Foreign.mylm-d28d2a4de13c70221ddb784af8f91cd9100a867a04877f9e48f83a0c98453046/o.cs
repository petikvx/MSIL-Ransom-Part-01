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
		o.m_d = null;
		o.m_e = null;
		o.m_b = int.MaxValue;
		o.m_c = int.MinValue;
		o.m_d = new MemoryStream(0);
		o.m_e = new MemoryStream(0);
		o.m_a = new object();
	}

	private static string a(Assembly assembly_0)
	{
		string text = assembly_0.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	private static byte[] b(Assembly assembly_0)
	{
		try
		{
			string? fullName = assembly_0.FullName;
			_003CModule_003E.h = 2081625616;
			string text = fullName;
			h.a = -1592516334;
			int num = text.IndexOf("PublicKeyToken=");
			if (num < 0)
			{
				num = text.IndexOf("publickeytoken=");
			}
			int num2 = num;
			_003CModule_003E.h = 1308380089;
			_003CModule_003E.p = 401140706;
			if (num2 < 0)
			{
				return null;
			}
			num += 15;
			if (text[num] != 'n' && text[num] != 'N')
			{
				string s = text.Substring(num, 16);
				long value = long.Parse(s, NumberStyles.HexNumber);
				_003CModule_003E.p = 1809257038;
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse((Array)bytes);
				_003CModule_003E.n = 1526447315;
				return bytes;
			}
			return null;
		}
		catch
		{
		}
		_003CModule_003E.l = 796469985;
		return null;
	}

	internal static byte[] c(Stream stream_0)
	{
		lock (o.m_a)
		{
			return e(97L, stream_0);
		}
	}

	internal static byte[] d(long long_0, Stream stream_0)
	{
		try
		{
			return c(stream_0);
		}
		catch (HostProtectionException)
		{
			return e(97L, stream_0);
		}
	}

	internal static byte[] e(long long_0, Stream stream_0)
	{
		Stream stream = stream_0;
		MemoryStream memoryStream = null;
		ushort num = (ushort)stream_0.ReadByte();
		num = (ushort)(~num);
		for (int l = 1; l < 4; l++)
		{
			stream_0.ReadByte();
		}
		bool flag = default(bool);
		if ((num & 2u) != 0)
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			_003CModule_003E.l = -1437277352;
			byte[] array = new byte[8];
			stream_0.Read(array, 0, 8);
			_003CModule_003E.h = -1980982856;
			dESCryptoServiceProvider.IV = array;
			byte[] array2 = new byte[8];
			stream_0.Read(array2, 0, 8);
			flag = true;
			byte[] array3 = array2;
			for (int num2 = 0; num2 < array3.Length; num2++)
			{
				if (array3[num2] != 0)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				array2 = b(Assembly.GetExecutingAssembly());
			}
			dESCryptoServiceProvider.Key = array2;
			if (o.m_d == null)
			{
				if (o.m_b == int.MaxValue)
				{
					o.m_d.Capacity = (int)stream_0.Length;
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
			byte[] array4 = new byte[cryptoTransform.OutputBlockSize];
			byte[] array5 = new byte[cryptoTransform.InputBlockSize];
			int num3;
			for (num3 = (int)stream_0.Position; num3 + inputBlockSize < stream_0.Length; num3 += inputBlockSize)
			{
				stream_0.Read(array5, 0, inputBlockSize);
				int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
				o.m_d.Write(array4, 0, count);
			}
			stream_0.Read(array5, 0, (int)(stream_0.Length - num3));
			byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(stream_0.Length - num3));
			o.m_d.Write(array6, 0, array6.Length);
			stream = o.m_d;
			stream.Position = 0L;
			memoryStream = o.m_d;
		}
		if ((num & 8u) != 0)
		{
			try
			{
				if (o.m_e == null)
				{
					int num4 = o.m_c;
					_003CModule_003E.c = flag;
					if (num4 == int.MinValue)
					{
						o.m_e.Capacity = (int)stream.Length * 2;
					}
					else
					{
						o.m_e.Capacity = o.m_c;
					}
				}
				o.m_e.Position = 0L;
				DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
				int num5 = 1000;
				byte[] buffer = new byte[1000];
				int num6;
				do
				{
					num6 = deflateStream.Read(buffer, 0, num5);
					if (num6 > 0)
					{
						o.m_e.Write(buffer, 0, num6);
					}
				}
				while (num6 >= num5);
				memoryStream = o.m_e;
			}
			catch (Exception)
			{
			}
		}
		if (memoryStream != null)
		{
			return memoryStream.ToArray();
		}
		byte[] array7 = new byte[stream_0.Length - stream_0.Position];
		stream_0.Read(array7, 0, array7.Length);
		return array7;
	}
}
