using System;
using System.Security.Cryptography;
using System.Text;

public sealed class poly
{
	private static string string_0 = "secretkey";

	public static string Encrypt(string plaintext)
	{
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string s = string_0;
		byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.Unicode.GetBytes(s));
		mD5CryptoServiceProvider = null;
		tripleDESCryptoServiceProvider.Key = key;
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		byte[] bytes = Encoding.Unicode.GetBytes(plaintext);
		return Convert.ToBase64String(tripleDESCryptoServiceProvider.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length));
	}

	public static string Decrypt(string plaintext)
	{
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string s = string_0;
		byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.Unicode.GetBytes(s));
		mD5CryptoServiceProvider = null;
		tripleDESCryptoServiceProvider.Key = key;
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		byte[] array = Convert.FromBase64String(plaintext);
		return Encoding.Unicode.GetString(tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(array, 0, array.Length));
	}
}
