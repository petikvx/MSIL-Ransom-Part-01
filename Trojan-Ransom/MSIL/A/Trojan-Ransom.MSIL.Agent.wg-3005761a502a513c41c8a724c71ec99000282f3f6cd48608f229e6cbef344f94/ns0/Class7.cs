using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace ns0;

internal sealed class Class7
{
	private static readonly object object_0;

	private static readonly int int_0;

	private static readonly int int_1;

	private static readonly MemoryStream memoryStream_0;

	private static readonly MemoryStream memoryStream_1;

	private static readonly byte byte_0;

	static Class7()
	{
		memoryStream_0 = null;
		memoryStream_1 = null;
		int_0 = int.MaxValue;
		int_1 = int.MinValue;
		memoryStream_0 = Delegate70.smethod_0(0);
		memoryStream_1 = Delegate70.smethod_0(0);
		object_0 = Delegate191.smethod_0();
	}

	private static string smethod_0(Assembly assembly_0)
	{
		string result = Delegate338.smethod_0(assembly_0);
		int num = Delegate205.smethod_0(result, ',');
		if (num >= 0)
		{
			result = Delegate232.smethod_0(result, 0, num);
		}
		return result;
	}

	private static byte[] smethod_1(Assembly assembly_0)
	{
		try
		{
			string text = Delegate338.smethod_0(assembly_0);
			int num = Delegate245.smethod_0(text, "PublicKeyToken=");
			if (num < 0)
			{
				num = Delegate245.smethod_0(text, "publickeytoken=");
			}
			if (num < 0)
			{
				return null;
			}
			num += 15;
			if (Delegate17.smethod_0(text, num) != 'n' && Delegate17.smethod_0(text, num) != 'N')
			{
				string string_ = Delegate232.smethod_0(text, num, 16);
				long long_ = Delegate150.smethod_0(string_, NumberStyles.HexNumber);
				byte[] array = Delegate219.smethod_0(long_);
				Delegate164.smethod_0(array);
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
		Delegate325.smethod_0(obj = object_0);
		try
		{
			return smethod_4(97L, stream_0);
		}
		finally
		{
			Delegate137.smethod_0(obj);
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
		Stream stream_ = stream_0;
		MemoryStream memoryStream = null;
		for (int i = 1; i < 4; i++)
		{
			Delegate273.smethod_0(stream_0);
		}
		ushort num = (ushort)Delegate273.smethod_0(stream_0);
		num = (ushort)(~num);
		if ((num & 2u) != 0)
		{
			DESCryptoServiceProvider dESCryptoServiceProvider = Delegate44.smethod_0();
			byte[] array = new byte[8];
			Delegate286.smethod_0(stream_0, array, 0, 8);
			Delegate259.smethod_0(dESCryptoServiceProvider, array);
			byte[] array2 = new byte[8];
			Delegate286.smethod_0(stream_0, array2, 0, 8);
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
				array2 = smethod_1(Delegate98.smethod_0());
			}
			Delegate57.smethod_0(dESCryptoServiceProvider, array2);
			if (memoryStream_0 == null)
			{
				if (int_0 == int.MaxValue)
				{
					Delegate124.smethod_0(memoryStream_0, (int)Delegate21.smethod_0(stream_0));
				}
				else
				{
					Delegate124.smethod_0(memoryStream_0, int_0);
				}
			}
			Delegate233.smethod_0(memoryStream_0, 0L);
			ICryptoTransform cryptoTransform = Delegate352.smethod_0(dESCryptoServiceProvider);
			int num2 = Delegate111.smethod_0(cryptoTransform);
			Delegate31.smethod_0(cryptoTransform);
			byte[] byte_ = new byte[Delegate31.smethod_0(cryptoTransform)];
			byte[] array4 = new byte[Delegate111.smethod_0(cryptoTransform)];
			int k;
			for (k = (int)Delegate299.smethod_0(stream_0); k + num2 < Delegate21.smethod_0(stream_0); k += num2)
			{
				Delegate286.smethod_0(stream_0, array4, 0, num2);
				int num3 = Delegate312.smethod_0(cryptoTransform, array4, 0, num2, byte_, 0);
				Delegate143.smethod_0(memoryStream_0, byte_, 0, num3);
			}
			Delegate286.smethod_0(stream_0, array4, 0, (int)(Delegate21.smethod_0(stream_0) - k));
			byte[] array5 = Delegate246.smethod_0(cryptoTransform, array4, 0, (int)(Delegate21.smethod_0(stream_0) - k));
			Delegate143.smethod_0(memoryStream_0, array5, 0, array5.Length);
			stream_ = memoryStream_0;
			Delegate233.smethod_0(stream_, 0L);
			memoryStream = memoryStream_0;
		}
		if ((num & 8u) != 0)
		{
			if (memoryStream_1 == null)
			{
				if (int_1 == int.MinValue)
				{
					Delegate124.smethod_0(memoryStream_1, (int)Delegate21.smethod_0(stream_) * 2);
				}
				else
				{
					Delegate124.smethod_0(memoryStream_1, int_1);
				}
			}
			Delegate233.smethod_0(memoryStream_1, 0L);
			DeflateStream deflateStream = Delegate178.smethod_0(stream_, CompressionMode.Decompress);
			int num4 = 1000;
			byte[] array6 = new byte[1000];
			int num5;
			do
			{
				num5 = Delegate286.smethod_0(deflateStream, array6, 0, num4);
				if (num5 > 0)
				{
					Delegate143.smethod_0(memoryStream_1, array6, 0, num5);
				}
			}
			while (num5 >= num4);
			memoryStream = memoryStream_1;
		}
		if (memoryStream != null)
		{
			return Delegate302.smethod_0(memoryStream);
		}
		byte[] array7 = new byte[Delegate21.smethod_0(stream_0) - Delegate299.smethod_0(stream_0)];
		Delegate286.smethod_0(stream_0, array7, 0, array7.Length);
		return array7;
	}
}
