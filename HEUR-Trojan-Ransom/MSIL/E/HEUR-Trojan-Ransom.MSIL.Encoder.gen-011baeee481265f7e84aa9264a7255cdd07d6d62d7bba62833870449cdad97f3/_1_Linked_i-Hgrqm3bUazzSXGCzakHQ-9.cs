using System.IO;
using System.Security.Cryptography;

public static class _1_Linked_i_002DHgrqm3bUazzSXGCzakHQ_002D9
{
	public const int int_0 = default(int);

	public static byte[] smethod_0(byte[] byte_0)
	{
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Mode = CipherMode.CBC;
		rijndaelManaged.GenerateKey();
		rijndaelManaged.GenerateIV();
		using MemoryStream memoryStream = new MemoryStream(byte_0);
		byte[] array = new byte[rijndaelManaged.Key.Length];
		byte[] array2 = new byte[rijndaelManaged.IV.Length];
		memoryStream.Read(array, 0, array.Length);
		memoryStream.Read(array2, 0, array2.Length);
		using ICryptoTransform transform = rijndaelManaged.CreateDecryptor(array, array2);
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
		byte[] array3 = new byte[memoryStream.Length - memoryStream.Position];
		cryptoStream.Read(array3, 0, array3.Length);
		return array3;
	}

	public static byte[] smethod_1(Stream stream_0)
	{
		byte[] array = new byte[stream_0.Length];
		stream_0.Read(array, 0, array.Length);
		return smethod_0(array);
	}
}
