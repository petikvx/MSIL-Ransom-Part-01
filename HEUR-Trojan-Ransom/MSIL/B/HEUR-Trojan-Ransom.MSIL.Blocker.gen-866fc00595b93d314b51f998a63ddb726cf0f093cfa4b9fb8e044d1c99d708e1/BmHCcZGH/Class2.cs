using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace BmHCcZGH;

internal sealed class Class2
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 30)]
	private struct Struct0
	{
	}

	private static readonly object object_0;

	private static readonly Array array_0 = new char[15];

	private static readonly object object_1;

	internal static byte byte_0/* Not supported: data(00) */;

	internal static byte[] smethod_0(byte[] byte_1)
	{
		byte[] array = new byte[16]
		{
			57, 49, 9, 59, 188, 159, 53, 107, 24, 145,
			109, 152, 58, 119, 56, 71
		};
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.Key = array;
		rijndaelManaged.IV = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		rijndaelManaged.Padding = PaddingMode.None;
		using ICryptoTransform transform = rijndaelManaged.CreateDecryptor(array, rijndaelManaged.IV);
		using MemoryStream memoryStream = new MemoryStream();
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		cryptoStream.Write(byte_1, 0, byte_1.Length);
		cryptoStream.FlushFinalBlock();
		try
		{
			return memoryStream.ToArray();
		}
		catch
		{
			return null;
		}
		finally
		{
			rijndaelManaged.Dispose();
			memoryStream.Dispose();
			cryptoStream.Dispose();
		}
	}

	static Class2()
	{
		char[] array = new char[8];
		array[2] = '㣣';
		array[0] = 'ஞ';
		array[6] = 'ᐅ';
		array[7] = 'ኊ';
		array[4] = '\u08e7';
		array[3] = 'ㄛ';
		array[5] = '૫';
		array[1] = '⋦';
		object_1 = new string[4];
		object_0 = array;
	}
}
