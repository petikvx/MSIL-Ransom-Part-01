using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Encoder;

public class EncDec
{
	public static byte[] Encrypt(byte[] clearData, byte[] Key, byte[] IV)
	{
		MemoryStream memoryStream = new MemoryStream();
		Rijndael rijndael = Rijndael.Create();
		rijndael.Key = Key;
		rijndael.IV = IV;
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(clearData, 0, clearData.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	public static string Encrypt(string clearText, string Password)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(clearText);
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, new byte[13]
		{
			73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
			100, 101, 118
		});
		byte[] inArray = Encrypt(bytes, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
		return Convert.ToBase64String(inArray);
	}

	public static byte[] Encrypt(byte[] clearData, string Password)
	{
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, new byte[13]
		{
			73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
			100, 101, 118
		});
		return Encrypt(clearData, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
	}

	public static void Encrypt(string fileIn, string fileOut, string Password)
	{
		FileStream fileStream = new FileStream(fileIn, FileMode.Open, FileAccess.Read);
		FileStream stream = new FileStream(fileOut, FileMode.OpenOrCreate, FileAccess.Write);
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, new byte[13]
		{
			73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
			100, 101, 118
		});
		Rijndael rijndael = Rijndael.Create();
		rijndael.Key = passwordDeriveBytes.GetBytes(32);
		rijndael.IV = passwordDeriveBytes.GetBytes(16);
		CryptoStream cryptoStream = new CryptoStream(stream, rijndael.CreateEncryptor(), CryptoStreamMode.Write);
		int count = 4096;
		byte[] buffer = new byte[4096];
		int num;
		do
		{
			num = fileStream.Read(buffer, 0, count);
			cryptoStream.Write(buffer, 0, num);
		}
		while (num != 0);
		cryptoStream.Close();
		fileStream.Close();
	}

	public static byte[] Decrypt(byte[] cipherData, byte[] Key, byte[] IV)
	{
		MemoryStream memoryStream = new MemoryStream();
		Rijndael rijndael = Rijndael.Create();
		rijndael.Key = Key;
		rijndael.IV = IV;
		CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(cipherData, 0, cipherData.Length);
		cryptoStream.Close();
		return memoryStream.ToArray();
	}

	public static string Decrypt(string cipherText, string Password)
	{
		byte[] cipherData = Convert.FromBase64String(cipherText);
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, new byte[13]
		{
			73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
			100, 101, 118
		});
		byte[] bytes = Decrypt(cipherData, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
		return Encoding.Unicode.GetString(bytes);
	}

	public static byte[] Decrypt(byte[] cipherData, string Password)
	{
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, new byte[13]
		{
			73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
			100, 101, 118
		});
		return Decrypt(cipherData, passwordDeriveBytes.GetBytes(32), passwordDeriveBytes.GetBytes(16));
	}

	public static void Decrypt(string fileIn, string fileOut, string Password)
	{
		FileStream fileStream = new FileStream(fileIn, FileMode.Open, FileAccess.Read);
		FileStream stream = new FileStream(fileOut, FileMode.OpenOrCreate, FileAccess.Write);
		PasswordDeriveBytes passwordDeriveBytes = new PasswordDeriveBytes(Password, new byte[13]
		{
			73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
			100, 101, 118
		});
		Rijndael rijndael = Rijndael.Create();
		rijndael.Key = passwordDeriveBytes.GetBytes(32);
		rijndael.IV = passwordDeriveBytes.GetBytes(16);
		CryptoStream cryptoStream = new CryptoStream(stream, rijndael.CreateDecryptor(), CryptoStreamMode.Write);
		int count = 4096;
		byte[] buffer = new byte[4096];
		int num;
		do
		{
			num = fileStream.Read(buffer, 0, count);
			cryptoStream.Write(buffer, 0, num);
		}
		while (num != 0);
		cryptoStream.Close();
		fileStream.Close();
	}
}
