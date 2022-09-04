using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Security;
using System.Security.Cryptography;

namespace ns0;

internal sealed class SymbolAttribute
{
	private static readonly object previousNames;

	private static readonly int previousNames;

	private static readonly int categoryList;

	private static readonly MemoryStream previousNames;

	private static readonly MemoryStream categoryList;

	private static readonly byte previousNames;

	static SymbolAttribute()
	{
		SymbolAttribute.previousNames = null;
		categoryList = null;
		SymbolAttribute.previousNames = int.MaxValue;
		SymbolAttribute.categoryList = int.MinValue;
		SymbolAttribute.previousNames = new MemoryStream(0);
		categoryList = new MemoryStream(0);
		SymbolAttribute.previousNames = new object();
	}

	private static string CopyDatabase(Assembly assembly_0)
	{
		string text = assembly_0.FullName;
		int num = text.IndexOf(',');
		if (num >= 0)
		{
			text = text.Substring(0, num);
		}
		return text;
	}

	private static byte[] CopyDatabase(Assembly assembly_0)
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

	internal static byte[] CopyDatabase(Stream stream_0)
	{
		lock (SymbolAttribute.previousNames)
		{
			return AddBuilder(97L, stream_0);
		}
	}

	internal static byte[] CopyDatabase(long long_0, Stream stream_0)
	{
		try
		{
			return CopyDatabase(stream_0);
		}
		catch (HostProtectionException)
		{
			return AddBuilder(97L, stream_0);
		}
	}

	internal static byte[] AddBuilder(long long_0, Stream stream_0)
	{
		Stream stream = stream_0;
		MemoryStream memoryStream = null;
		ushort num = (ushort)stream_0.ReadByte();
		num = (ushort)(~num);
		for (int i = 1; i < 3; i++)
		{
			stream_0.ReadByte();
		}
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
				array2 = SymbolAttribute.CopyDatabase(Assembly.GetExecutingAssembly());
			}
			dESCryptoServiceProvider.Key = array2;
			if (SymbolAttribute.previousNames == null)
			{
				if (SymbolAttribute.previousNames == int.MaxValue)
				{
					SymbolAttribute.previousNames.Capacity = (int)stream_0.Length;
				}
				else
				{
					SymbolAttribute.previousNames.Capacity = SymbolAttribute.previousNames;
				}
			}
			SymbolAttribute.previousNames.Position = 0L;
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
				SymbolAttribute.previousNames.Write(array4, 0, count);
			}
			stream_0.Read(array5, 0, (int)(stream_0.Length - k));
			byte[] array6 = cryptoTransform.TransformFinalBlock(array5, 0, (int)(stream_0.Length - k));
			SymbolAttribute.previousNames.Write(array6, 0, array6.Length);
			stream = SymbolAttribute.previousNames;
			stream.Position = 0L;
			memoryStream = SymbolAttribute.previousNames;
		}
		if ((num & 8u) != 0)
		{
			try
			{
				if (categoryList == null)
				{
					if (SymbolAttribute.categoryList == int.MinValue)
					{
						categoryList.Capacity = (int)stream.Length * 2;
					}
					else
					{
						categoryList.Capacity = SymbolAttribute.categoryList;
					}
				}
				categoryList.Position = 0L;
				DeflateStream deflateStream = new DeflateStream(stream, CompressionMode.Decompress);
				int num2 = 1000;
				byte[] buffer = new byte[1000];
				int num3;
				do
				{
					num3 = deflateStream.Read(buffer, 0, num2);
					if (num3 > 0)
					{
						categoryList.Write(buffer, 0, num3);
					}
				}
				while (num3 >= num2);
				memoryStream = categoryList;
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
