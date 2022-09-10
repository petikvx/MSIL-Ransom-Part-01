using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace ns0;

internal class Class15
{
	private static readonly object object_0;

	private static readonly int int_0;

	private static readonly int int_1;

	private static readonly MemoryStream memoryStream_0;

	private static readonly MemoryStream memoryStream_1;

	private static readonly byte byte_0;

	static Class15()
	{
		memoryStream_0 = null;
		memoryStream_1 = null;
		int_0 = int.MaxValue;
		int_1 = int.MinValue;
		memoryStream_0 = Delegate68.smethod_0(0);
		memoryStream_1 = Delegate68.smethod_0(0);
		object_0 = Delegate124.smethod_0();
	}

	private static string smethod_0(Assembly assembly_0)
	{
		string text = default(string);
		int num = default(int);
		try
		{
			text = Delegate88.smethod_0(assembly_0);
			num = Delegate91.smethod_0(text, ',');
			if (num >= 0)
			{
				text = Delegate127.smethod_0(text, 0, num);
			}
			return text;
		}
		catch (Exception exception_)
		{
			Class9.smethod_27(exception_, assembly_0, text, num);
			throw;
		}
	}

	private static byte[] smethod_1(Assembly assembly_0)
	{
		string object_ = default(string);
		int num = default(int);
		byte[] array = default(byte[]);
		string text = default(string);
		long num2 = default(long);
		byte[] array2 = default(byte[]);
		try
		{
			try
			{
				object_ = Delegate88.smethod_0(assembly_0);
				num = Delegate117.smethod_0(object_, "PublicKeyToken=");
				if (num < 0)
				{
					num = Delegate117.smethod_0(object_, "publickeytoken=");
				}
				if (num < 0)
				{
					array = null;
					return array;
				}
				num += 15;
				if (Delegate30.smethod_0(object_, num) != 'n' && Delegate30.smethod_0(object_, num) != 'N')
				{
					text = Delegate127.smethod_0(object_, num, 16);
					num2 = Delegate42.smethod_0(text, NumberStyles.HexNumber);
					array2 = Delegate60.smethod_0(num2);
					Delegate130.smethod_0(array2);
					array = array2;
					return array;
				}
				array = null;
				return array;
			}
			catch
			{
			}
			return null;
		}
		catch (Exception exception_)
		{
			Class9.smethod_31(exception_, assembly_0, object_, num, text, num2, array2, array);
			throw;
		}
	}

	internal static byte[] smethod_2(Stream stream_0)
	{
		object object_ = default(object);
		byte[] array = default(byte[]);
		try
		{
			Delegate101.smethod_0(object_ = object_0);
			try
			{
				array = smethod_4(97L, stream_0);
				return array;
			}
			finally
			{
				Delegate96.smethod_0(object_);
			}
		}
		catch (Exception exception_)
		{
			Class9.smethod_27(exception_, stream_0, array, object_);
			throw;
		}
	}

	internal static byte[] smethod_3(long long_0, Stream stream_0)
	{
		byte[] array = default(byte[]);
		try
		{
			try
			{
				array = smethod_2(stream_0);
				return array;
			}
			catch (HostProtectionException)
			{
				array = smethod_4(97L, stream_0);
				return array;
			}
		}
		catch (Exception exception_)
		{
			Class9.smethod_27(exception_, long_0, stream_0, array);
			throw;
		}
	}

	internal static byte[] smethod_4(long long_0, Stream stream_0)
	{
		Stream stream = default(Stream);
		MemoryStream memoryStream = default(MemoryStream);
		int i = default(int);
		ushort num = default(ushort);
		DESCryptoServiceProvider dESCryptoServiceProvider = default(DESCryptoServiceProvider);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		bool flag = default(bool);
		byte[] array3 = default(byte[]);
		int j = default(int);
		byte b = default(byte);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		int num2 = default(int);
		byte[] array4 = default(byte[]);
		byte[] array5 = default(byte[]);
		int k = default(int);
		int num3 = default(int);
		byte[] array6 = default(byte[]);
		DeflateStream deflateStream = default(DeflateStream);
		int num4 = default(int);
		byte[] array7 = default(byte[]);
		int num5 = default(int);
		byte[] array8 = default(byte[]);
		try
		{
			stream = stream_0;
			memoryStream = null;
			for (i = 1; i < 4; i++)
			{
				Delegate78.smethod_0(stream_0);
			}
			num = (ushort)Delegate78.smethod_0(stream_0);
			num = (ushort)(~num);
			if ((num & 2u) != 0)
			{
				dESCryptoServiceProvider = Delegate27.smethod_0();
				array = new byte[8];
				Delegate132.smethod_0(stream_0, array, 0, 8);
				Delegate14.smethod_0(dESCryptoServiceProvider, array);
				array2 = new byte[8];
				Delegate132.smethod_0(stream_0, array2, 0, 8);
				flag = true;
				array3 = array2;
				for (j = 0; j < array3.Length; j++)
				{
					b = array3[j];
					if (b != 0)
					{
						flag = false;
						break;
					}
				}
				if (flag)
				{
					array2 = smethod_1(Delegate79.smethod_0());
				}
				Delegate97.smethod_0(dESCryptoServiceProvider, array2);
				if (memoryStream_0 == null)
				{
					if (int_0 == int.MaxValue)
					{
						Delegate122.smethod_0(memoryStream_0, (int)Delegate106.smethod_0(stream_0));
					}
					else
					{
						Delegate122.smethod_0(memoryStream_0, int_0);
					}
				}
				Delegate90.smethod_0(memoryStream_0, 0L);
				cryptoTransform = Delegate34.smethod_0(dESCryptoServiceProvider);
				num2 = Delegate36.smethod_0(cryptoTransform);
				Delegate46.smethod_0(cryptoTransform);
				array4 = new byte[Delegate46.smethod_0(cryptoTransform)];
				array5 = new byte[Delegate36.smethod_0(cryptoTransform)];
				for (k = (int)Delegate55.smethod_0(stream_0); k + num2 < Delegate106.smethod_0(stream_0); k += num2)
				{
					Delegate132.smethod_0(stream_0, array5, 0, num2);
					num3 = Delegate128.smethod_0(cryptoTransform, array5, 0, num2, array4, 0);
					Delegate86.smethod_0(memoryStream_0, array4, 0, num3);
				}
				Delegate132.smethod_0(stream_0, array5, 0, (int)(Delegate106.smethod_0(stream_0) - k));
				array6 = Delegate45.smethod_0(cryptoTransform, array5, 0, (int)(Delegate106.smethod_0(stream_0) - k));
				Delegate86.smethod_0(memoryStream_0, array6, 0, array6.Length);
				stream = memoryStream_0;
				Delegate90.smethod_0(stream, 0L);
				memoryStream = memoryStream_0;
			}
			if ((num & 8u) != 0)
			{
				if (memoryStream_1 == null)
				{
					if (int_1 == int.MinValue)
					{
						Delegate122.smethod_0(memoryStream_1, (int)Delegate106.smethod_0(stream) * 2);
					}
					else
					{
						Delegate122.smethod_0(memoryStream_1, int_1);
					}
				}
				Delegate90.smethod_0(memoryStream_1, 0L);
				deflateStream = Delegate98.smethod_0(stream, CompressionMode.Decompress);
				num4 = 1000;
				array7 = new byte[1000];
				do
				{
					num5 = Delegate132.smethod_0(deflateStream, array7, 0, num4);
					if (num5 > 0)
					{
						Delegate86.smethod_0(memoryStream_1, array7, 0, num5);
					}
				}
				while (num5 >= num4);
				memoryStream = memoryStream_1;
			}
			if (memoryStream != null)
			{
				return Delegate57.smethod_0(memoryStream);
			}
			array8 = new byte[Delegate106.smethod_0(stream_0) - Delegate55.smethod_0(stream_0)];
			Delegate132.smethod_0(stream_0, array8, 0, array8.Length);
			return array8;
		}
		catch (Exception exception_)
		{
			Class9.smethod_35(exception_, new object[25]
			{
				long_0, stream_0, stream, memoryStream, i, num, dESCryptoServiceProvider, array, array2, flag,
				b, cryptoTransform, num2, array4, array5, k, num3, array6, deflateStream, num4,
				num5, array7, array8, array3, j
			});
			throw;
		}
	}
}
