using System.IO;
using System.Security.Cryptography;

namespace ns1;

internal class Class1
{
	private static byte[] smethod_0(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		MemoryStream memoryStream = new MemoryStream();
		Rijndael rijndael = Rijndael.Create();
		rijndael.Key = byte_1;
		rijndael.IV = byte_2;
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(byte_0, 0, byte_0.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	public static byte[] smethod_1(byte[] byte_0, string string_0)
	{
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(string_0, new byte[13]
		{
			73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
			100, 101, 118
		});
		return smethod_0(byte_0, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
	}
}
