using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;

namespace ns0;

internal class Class5
{
	private static readonly object object_0;

	private static readonly int int_0;

	private static readonly int int_1;

	private static readonly MemoryStream memoryStream_0;

	private static readonly MemoryStream memoryStream_1;

	private static readonly byte byte_0;

	static Class5()
	{
		memoryStream_0 = null;
		memoryStream_1 = null;
		int_0 = int.MaxValue;
		int_1 = int.MinValue;
		memoryStream_0 = Delegate67.smethod_0(0);
		memoryStream_1 = Delegate67.smethod_0(0);
		object_0 = Delegate31.smethod_0();
	}

	private static string smethod_0(Assembly assembly_0)
	{
		string result = Delegate60.smethod_0(assembly_0);
		int num = Delegate94.smethod_0(result, ',');
		if (num >= 0)
		{
			result = Delegate56.smethod_0(result, 0, num);
		}
		return result;
	}

	private static byte[] smethod_1(Assembly assembly_0)
	{
		try
		{
			string text = Delegate60.smethod_0(assembly_0);
			int num = Delegate35.smethod_0(text, "PublicKeyToken=");
			if (num < 0)
			{
				num = Delegate35.smethod_0(text, "publickeytoken=");
			}
			if (num < 0)
			{
				return null;
			}
			num += 15;
			if (Delegate101.smethod_0(text, num) != 'n' && Delegate101.smethod_0(text, num) != 'N')
			{
				string string_ = Delegate56.smethod_0(text, num, 16);
				long long_ = Delegate102.smethod_0(string_, NumberStyles.HexNumber);
				byte[] array = Delegate109.smethod_0(long_);
				Delegate92.smethod_0(array);
				return array;
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
		object obj;
		Delegate42.smethod_0(obj = object_0);
		try
		{
			return smethod_4(97L, stream_0);
		}
		finally
		{
			Delegate87.smethod_0(obj);
		}
	}

	internal static byte[] smethod_3(long long_0, Stream stream_0)
	{
		try
		{
			return smethod_2(stream_0);
		}
		catch
		{
			return smethod_4(97L, stream_0);
		}
	}

	internal static byte[] smethod_4(long long_0, object object_1)
	{
		Stream stream = object_1 as Stream;
		Stream stream_ = stream;
		MemoryStream memoryStream = null;
		for (int i = 1; i < 4; i++)
		{
			Delegate106.smethod_0(stream);
		}
		ushort num = (ushort)Delegate106.smethod_0(stream);
		num = (ushort)(~num);
		if ((num & 2u) != 0)
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = Delegate49.smethod_0();
			byte[] array = new byte[8];
			Delegate24.smethod_0(stream, array, 0, 8);
			Delegate12.smethod_0(dESCryptoServiceProvider, array);
			byte[] array2 = new byte[8];
			Delegate24.smethod_0(stream, array2, 0, 8);
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
				array2 = smethod_1(Delegate104.smethod_0());
			}
			Delegate57.smethod_0(dESCryptoServiceProvider, array2);
			if (memoryStream_0 == null)
			{
				if (int_0 == int.MaxValue)
				{
					Delegate108.smethod_0(memoryStream_0, (int)Delegate2.smethod_0(stream));
				}
				else
				{
					Delegate108.smethod_0(memoryStream_0, int_0);
				}
			}
			Delegate1.smethod_0(memoryStream_0, 0L);
			ICryptoTransform cryptoTransform = Delegate112.smethod_0(dESCryptoServiceProvider);
			int num2 = Delegate17.smethod_0(cryptoTransform);
			Delegate91.smethod_0(cryptoTransform);
			byte[] byte_ = new byte[Delegate91.smethod_0(cryptoTransform)];
			byte[] array4 = new byte[Delegate17.smethod_0(cryptoTransform)];
			int k;
			for (k = (int)Delegate58.smethod_0(stream); k + num2 < Delegate2.smethod_0(stream); k += num2)
			{
				Delegate24.smethod_0(stream, array4, 0, num2);
				int num3 = Delegate9.smethod_0(cryptoTransform, array4, 0, num2, byte_, 0);
				Delegate76.smethod_0(memoryStream_0, byte_, 0, num3);
			}
			Delegate24.smethod_0(stream, array4, 0, (int)(Delegate2.smethod_0(stream) - k));
			byte[] array5 = Delegate86.smethod_0(cryptoTransform, array4, 0, (int)(Delegate2.smethod_0(stream) - k));
			Delegate76.smethod_0(memoryStream_0, array5, 0, array5.Length);
			stream_ = memoryStream_0;
			Delegate1.smethod_0(stream_, 0L);
			memoryStream = memoryStream_0;
		}
		if ((num & 8u) != 0)
		{
			if (memoryStream_1 == null)
			{
				if (int_1 == int.MinValue)
				{
					Delegate108.smethod_0(memoryStream_1, (int)Delegate2.smethod_0(stream_) * 2);
				}
				else
				{
					Delegate108.smethod_0(memoryStream_1, int_1);
				}
			}
			Delegate1.smethod_0(memoryStream_1, 0L);
			DeflateStream deflateStream = Delegate99.smethod_0(stream_, CompressionMode.Decompress);
			int num4 = 1000;
			byte[] array6 = new byte[1000];
			int num5;
			do
			{
				num5 = Delegate24.smethod_0(deflateStream, array6, 0, num4);
				if (num5 > 0)
				{
					Delegate76.smethod_0(memoryStream_1, array6, 0, num5);
				}
			}
			while (num5 >= num4);
			memoryStream = memoryStream_1;
		}
		if (memoryStream != null)
		{
			return Delegate118.smethod_0(memoryStream);
		}
		byte[] array7 = new byte[Delegate2.smethod_0(stream) - Delegate58.smethod_0(stream)];
		Delegate24.smethod_0(stream, array7, 0, array7.Length);
		return array7;
	}
}
