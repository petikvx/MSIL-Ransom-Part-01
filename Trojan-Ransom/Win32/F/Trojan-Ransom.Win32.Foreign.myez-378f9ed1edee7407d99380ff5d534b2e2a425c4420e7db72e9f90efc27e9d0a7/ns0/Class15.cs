using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;
using System.Threading;

namespace ns0;

internal sealed class Class15
{
	private static readonly object object_0;

	private static readonly int int_0;

	private static readonly int int_1;

	private static readonly MemoryStream memoryStream_0;

	private static readonly MemoryStream memoryStream_1;

	static Class15()
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
		string text = default(string);
		int num = default(int);
		try
		{
			text = assembly_0.FullName;
			num = text.IndexOf(',');
			if (num >= 0)
			{
				text = text.Substring(0, num);
			}
			return text;
		}
		catch (Exception exception_)
		{
			Class9.smethod_23(exception_, assembly_0, text, num);
			throw;
		}
	}

	private static byte[] smethod_1(Assembly assembly_0)
	{
		string fullName = default(string);
		int num = default(int);
		byte[] array = default(byte[]);
		string text = default(string);
		long num2 = default(long);
		byte[] bytes = default(byte[]);
		try
		{
			try
			{
				fullName = assembly_0.FullName;
				num = fullName.IndexOf("PublicKeyToken=");
				if (num < 0)
				{
					num = fullName.IndexOf("publickeytoken=");
				}
				if (num < 0)
				{
					array = null;
					return array;
				}
				num += 15;
				if (fullName[num] != 'n' && fullName[num] != 'N')
				{
					text = fullName.Substring(num, 16);
					num2 = long.Parse(text, NumberStyles.HexNumber);
					bytes = BitConverter.GetBytes(num2);
					Array.Reverse((Array)bytes);
					array = bytes;
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
			Class9.smethod_27(exception_, assembly_0, fullName, num, text, num2, bytes, array);
			throw;
		}
	}

	internal static byte[] smethod_2(Stream stream_0)
	{
		object obj = default(object);
		byte[] array = default(byte[]);
		try
		{
			Monitor.Enter(obj = object_0);
			try
			{
				array = smethod_4(0, stream_0);
				return array;
			}
			finally
			{
				Monitor.Exit(obj);
			}
		}
		catch (Exception exception_)
		{
			Class9.smethod_23(exception_, stream_0, array, obj);
			throw;
		}
	}

	internal static byte[] smethod_3(sbyte sbyte_0, Stream stream_0)
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
				array = smethod_4(0, stream_0);
				return array;
			}
		}
		catch (Exception exception_)
		{
			Class9.smethod_23(exception_, sbyte_0, stream_0, array);
			throw;
		}
	}

	internal static byte[] smethod_4(sbyte sbyte_0, Stream stream_0)
	{
		Stream stream = default(Stream);
		MemoryStream memoryStream = default(MemoryStream);
		ushort num = default(ushort);
		int i = default(int);
		DESCryptoServiceProvider dESCryptoServiceProvider = default(DESCryptoServiceProvider);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		bool flag = default(bool);
		byte[] array3 = default(byte[]);
		int j = default(int);
		byte b = default(byte);
		ICryptoTransform cryptoTransform = default(ICryptoTransform);
		int inputBlockSize = default(int);
		byte[] array4 = default(byte[]);
		byte[] array5 = default(byte[]);
		int k = default(int);
		int num2 = default(int);
		byte[] array6 = default(byte[]);
		DeflateStream deflateStream = default(DeflateStream);
		int num3 = default(int);
		byte[] array7 = default(byte[]);
		int num4 = default(int);
		byte[] array8 = default(byte[]);
		try
		{
			stream = stream_0;
			memoryStream = null;
			num = (ushort)stream_0.ReadByte();
			num = (ushort)(~num);
			for (i = 1; i < 3; i++)
			{
				stream_0.ReadByte();
			}
			if ((num & 2u) != 0)
			{
				dESCryptoServiceProvider = new DESCryptoServiceProvider();
				array = new byte[8];
				stream_0.Read(array, 0, 8);
				dESCryptoServiceProvider.IV = array;
				array2 = new byte[8];
				stream_0.Read(array2, 0, 8);
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
				cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
				inputBlockSize = cryptoTransform.InputBlockSize;
				_ = cryptoTransform.OutputBlockSize;
				array4 = new byte[cryptoTransform.OutputBlockSize];
				array5 = new byte[cryptoTransform.InputBlockSize];
				for (k = (int)stream_0.Position; k + inputBlockSize < stream_0.Length; k += inputBlockSize)
				{
					stream_0.Read(array5, 0, inputBlockSize);
					num2 = cryptoTransform.TransformBlock(array5, 0, inputBlockSize, array4, 0);
					memoryStream_0.Write(array4, 0, num2);
				}
				stream_0.Read(array5, 0, (int)(stream_0.Length - k));
				array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(stream_0.Length - k));
				memoryStream_0.Write(array6, 0, array6.Length);
				stream = memoryStream_0;
				stream.Position = 0L;
				memoryStream = memoryStream_0;
			}
			if ((num & 8u) != 0)
			{
				try
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
					deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
					num3 = 1000;
					array7 = new byte[1000];
					do
					{
						num4 = deflateStream.Read(array7, 0, num3);
						if (num4 > 0)
						{
							memoryStream_1.Write(array7, 0, num4);
						}
					}
					while (num4 >= num3);
					memoryStream = memoryStream_1;
				}
				catch (Exception)
				{
				}
			}
			if (memoryStream != null)
			{
				return memoryStream.ToArray();
			}
			array8 = new byte[stream_0.Length - stream_0.Position];
			stream_0.Read(array8, 0, array8.Length);
			return array8;
		}
		catch (Exception exception_)
		{
			Class9.smethod_31(exception_, new object[25]
			{
				sbyte_0, stream_0, stream, memoryStream, num, i, dESCryptoServiceProvider, array, array2, flag,
				b, cryptoTransform, inputBlockSize, array4, array5, k, num2, array6, deflateStream, num3,
				num4, array7, array8, array3, j
			});
			throw;
		}
	}
}
