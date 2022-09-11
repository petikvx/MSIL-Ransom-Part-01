using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Szymekk;

public sealed class Class1
{
	private TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider_0;

	public Class1(string key)
	{
		tripleDESCryptoServiceProvider_0 = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider_0.Key = method_0(key, tripleDESCryptoServiceProvider_0.KeySize / 8);
		tripleDESCryptoServiceProvider_0.IV = method_0("", tripleDESCryptoServiceProvider_0.BlockSize / 8);
	}

	private byte[] method_0(string string_0, int int_0)
	{
		SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		byte[] bytes = Encoding.Unicode.GetBytes(string_0);
		byte[] array = sHA1CryptoServiceProvider.ComputeHash(bytes);
		return (byte[])Utils.CopyArray((Array)array, (Array)new byte[checked(int_0 - 1 + 1)]);
	}

	public string EncryptData(string plaintext)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(plaintext);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDESCryptoServiceProvider_0.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		return Convert.ToBase64String(memoryStream.ToArray());
	}

	public string DecryptData(string encryptedtext)
	{
		byte[] array = Convert.FromBase64String(encryptedtext);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, tripleDESCryptoServiceProvider_0.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(array, 0, array.Length);
		cryptoStream.FlushFinalBlock();
		return Encoding.Unicode.GetString(memoryStream.ToArray());
	}
}
