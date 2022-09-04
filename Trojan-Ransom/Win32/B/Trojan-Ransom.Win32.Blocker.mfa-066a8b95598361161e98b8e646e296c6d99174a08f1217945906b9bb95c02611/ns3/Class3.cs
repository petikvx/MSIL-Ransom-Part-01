using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security.Cryptography;

namespace ns3;

internal sealed class Class3
{
	private static MemoryStream memoryStream_0;

	private static MemoryStream memoryStream_1;

	private static object object_0;

	private static int int_0;

	private static int int_1;

	static Class3()
	{
		int_0 = int.MaxValue;
		int_1 = int.MinValue;
		memoryStream_0 = null;
		memoryStream_1 = null;
		object_0 = new object();
	}

	private static byte[] smethod_0(Assembly assembly_0)
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

	internal unsafe static byte[] smethod_1(Stream stream_0)
	{
		void* ptr = stackalloc byte[14];
		lock (object_0)
		{
			Stream stream = stream_0;
			MemoryStream memoryStream = null;
			byte b = (byte)stream_0.ReadByte();
			if ((b & 2u) != 0)
			{
				DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
				byte[] array = new byte[8];
				stream_0.Read(array, 0, 8);
				dESCryptoServiceProvider.IV = array;
				byte[] array2 = new byte[8];
				stream_0.Read(array2, 0, 8);
				((byte*)ptr)[12] = 1;
				byte[] array3 = array2;
				*(int*)((byte*)ptr + 8) = 0;
				while (*(int*)((byte*)ptr + 8) < array3.Length)
				{
					((byte*)ptr)[13] = array3[*(int*)((byte*)ptr + 8)];
					if (((byte*)ptr)[13] == 0)
					{
						(*(int*)((byte*)ptr + 8))++;
						continue;
					}
					((byte*)ptr)[12] = 0;
					break;
				}
				if (((byte*)ptr)[12] != 0)
				{
					array2 = smethod_0(Assembly.GetExecutingAssembly());
				}
				dESCryptoServiceProvider.Key = array2;
				if (memoryStream_0 == null)
				{
					if (int_0 == int.MaxValue)
					{
						memoryStream_0 = new MemoryStream((int)stream_0.Length);
					}
					else
					{
						memoryStream_0 = new MemoryStream(int_0);
					}
				}
				memoryStream_0.Position = 0L;
				ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
				*(int*)ptr = cryptoTransform.InputBlockSize;
				_ = cryptoTransform.OutputBlockSize;
				byte[] array4 = new byte[cryptoTransform.OutputBlockSize];
				byte[] array5 = new byte[cryptoTransform.InputBlockSize];
				int i;
				for (i = (int)stream_0.Position; i + *(int*)ptr < stream_0.Length; i += *(int*)ptr)
				{
					stream_0.Read(array5, 0, *(int*)ptr);
					int count = cryptoTransform.TransformBlock(array5, 0, *(int*)ptr, array4, 0);
					memoryStream_0.Write(array4, 0, count);
				}
				stream_0.Read(array5, 0, (int)(stream_0.Length - i));
				byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(stream_0.Length - i));
				memoryStream_0.Write(array6, 0, array6.Length);
				stream = memoryStream_0;
				stream.Position = 0L;
				memoryStream = memoryStream_0;
			}
			if ((b & 8u) != 0)
			{
				try
				{
					if (memoryStream_1 == null)
					{
						if (int_1 == int.MinValue)
						{
							memoryStream_1 = new MemoryStream((int)stream.Length * 2);
						}
						else
						{
							memoryStream_1 = new MemoryStream(int_1);
						}
					}
					memoryStream_1.Position = 0L;
					DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
					*(int*)((byte*)ptr + 4) = 1000;
					byte[] buffer = new byte[*(int*)((byte*)ptr + 4)];
					int num;
					do
					{
						num = deflateStream.Read(buffer, 0, *(int*)((byte*)ptr + 4));
						if (num > 0)
						{
							memoryStream_1.Write(buffer, 0, num);
						}
					}
					while (num >= *(int*)((byte*)ptr + 4));
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
			byte[] array7 = new byte[stream_0.Length - stream_0.Position];
			stream_0.Read(array7, 0, array7.Length);
			return array7;
		}
	}
}
