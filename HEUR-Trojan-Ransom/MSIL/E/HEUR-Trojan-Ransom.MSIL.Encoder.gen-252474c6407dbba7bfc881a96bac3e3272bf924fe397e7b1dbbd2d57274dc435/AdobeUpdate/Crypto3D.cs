using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace AdobeUpdate;

public class Crypto3D
{
	private TripleDESCryptoServiceProvider TripleDes;

	private byte[] TruncateHash(string key, int length)
	{
		SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		byte[] bytes = Encoding.Unicode.GetBytes(key);
		byte[] array = sHA1CryptoServiceProvider.ComputeHash(bytes);
		return (byte[])Utils.CopyArray((Array)array, (Array)new byte[checked(length - 1 + 1)]);
	}

	public Crypto3D(string key)
	{
		TripleDes = new TripleDESCryptoServiceProvider();
		TripleDes.Key = TruncateHash(key, TripleDes.KeySize / 8);
		TripleDes.IV = TruncateHash("", TripleDes.BlockSize / 8);
	}

	public string EncryptData(string plaintext)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(plaintext);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, TripleDes.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		return Convert.ToBase64String(memoryStream.ToArray());
	}

	public string DecryptData(string encryptedtext)
	{
		byte[] array = Convert.FromBase64String(encryptedtext);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, TripleDes.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(array, 0, array.Length);
		cryptoStream.FlushFinalBlock();
		return Encoding.Unicode.GetString(memoryStream.ToArray());
	}
}
