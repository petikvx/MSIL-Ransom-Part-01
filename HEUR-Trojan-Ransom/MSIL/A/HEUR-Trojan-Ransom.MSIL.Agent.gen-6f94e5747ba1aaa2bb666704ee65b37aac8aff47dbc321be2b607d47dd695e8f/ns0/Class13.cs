using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace ns0;

internal sealed class Class13
{
	private static readonly object object_0;

	private static readonly int int_0;

	private static readonly int int_1;

	private static readonly MemoryStream memoryStream_0;

	private static readonly MemoryStream memoryStream_1;

	private static readonly byte byte_0;

	static Class13()
	{
		memoryStream_0 = null;
		memoryStream_1 = null;
		int_0 = int.MaxValue;
		int_1 = int.MinValue;
		memoryStream_0 = new MemoryStream(0);
		memoryStream_1 = new MemoryStream(0);
		object_0 = new object();
	}

	private static string smethod_0(Assembly assembly_0)
	{
		string text = assembly_0.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	private static byte[] smethod_1(Assembly assembly_0)
	{
		try
		{
			string fullName = assembly_0.FullName;
			int num = fullName.IndexOf("PublicKeyToken=");
			if (num < 0)
			{
				num = fullName.IndexOf("publickeytoken=");
			}
			if (num < 0)
			{
				return null;
			}
			num += 15;
			if (fullName[num] != 'n' && fullName[num] != 'N')
			{
				string s = fullName.Substring(num, 16);
				long value = long.Parse(s, NumberStyles.HexNumber);
				byte[] bytes = BitConverter.GetBytes(value);
				Array.Reverse((Array)bytes);
				return bytes;
			}
			return null;
		}
		catch
		{
		}
		return null;
	}

	internal static byte[] smethod_2(Stream stream_0)
	{
		lock (object_0)
		{
			return smethod_4(97L, stream_0);
		}
	}

	internal static byte[] smethod_3(long long_0, Stream stream_0)
	{
		try
		{
			return smethod_2(stream_0);
		}
		catch (HostProtectionException)
		{
			return smethod_4(97L, stream_0);
		}
	}

	internal static byte[] smethod_4(long long_0, Stream stream_0)
	{
		Stream stream = stream_0;
		MemoryStream memoryStream = null;
		for (int i = 1; i < 4; i++)
		{
			stream_0.ReadByte();
		}
		ushort num = (ushort)stream_0.ReadByte();
		num = (ushort)(~num);
		if ((num & 2u) != 0)
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			byte[] array = new byte[8];
			stream_0.Read(array, 0, 8);
			dESCryptoServiceProvider.IV = array;
			byte[] array2 = new byte[8];
			stream_0.Read(array2, 0, 8);
			bool flag = true;
			byte[] array3 = array2;
			for (int j = 0; j < array3.Length; j++)
			{
				if (array3[j] != 0)
				{
					flag = false;
					break;
				}
			}
			if (flag)
			{
				array2 = smethod_1(Assembly.GetExecutingAssembly());
			}
			dESCryptoServiceProvider.Key = array2;
			if (memoryStream_0 == null)
			{
				if (int_0 == int.MaxValue)
				{
					memoryStream_0.Capacity = (int)stream_0.Length;
				}
				else
				{
					memoryStream_0.Capacity = int_0;
				}
			}
			memoryStream_0.Position = 0L;
			ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
			int inputBlockSize = cryptoTransform.InputBlockSize;
			_ = cryptoTransform.OutputBlockSize;
			byte[] array4 = new byte[cryptoTransform.OutputBlockSize];
			byte[] array5 = new byte[cryptoTransform.InputBlockSize];
			int k;
			for (k = (int)stream_0.Position; k + inputBlockSize < stream_0.Length; k += inputBlockSize)
			{
				stream_0.Read(array5, 0, inputBlockSize);
				int count = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
				memoryStream_0.Write(array4, 0, count);
			}
			stream_0.Read(array5, 0, (int)(stream_0.Length - k));
			byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(stream_0.Length - k));
			memoryStream_0.Write(array6, 0, array6.Length);
			stream = memoryStream_0;
			stream.Position = 0L;
			memoryStream = memoryStream_0;
		}
		if ((num & 8u) != 0)
		{
			if (memoryStream_1 == null)
			{
				if (int_1 == int.MinValue)
				{
					memoryStream_1.Capacity = (int)stream.Length * 2;
				}
				else
				{
					memoryStream_1.Capacity = int_1;
				}
			}
			memoryStream_1.Position = 0L;
			DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
			int num2 = 1000;
			byte[] buffer = new byte[1000];
			int num3;
			do
			{
				num3 = deflateStream.Read(buffer, 0, num2);
				if (num3 > 0)
				{
					memoryStream_1.Write(buffer, 0, num3);
				}
			}
			while (num3 >= num2);
			memoryStream = memoryStream_1;
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
