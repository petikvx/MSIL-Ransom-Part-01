using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace fuck_rats_antivirus;

public class Class1
{
	private TripleDESCryptoServiceProvider gvddsawrfvdv;

	private byte[] TruncateHas(string key, int length)
	{
		SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		byte[] bytes = Encoding.Unicode.GetBytes(key);
		return (byte[])Utils.CopyArray((Array)sHA1CryptoServiceProvider.ComputeHash(bytes), (Array)new byte[checked(length - 1 + 1)]);
	}

	public Class1(string key)
	{
		gvddsawrfvdv = new TripleDESCryptoServiceProvider();
		gvddsawrfvdv.Key = TruncateHas(key, gvddsawrfvdv.KeySize / 8);
		gvddsawrfvdv.IV = TruncateHas("", gvddsawrfvdv.BlockSize / 8);
	}

	public string EncryptData(string plaintext)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(plaintext);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, gvddsawrfvdv.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		return Convert.ToBase64String(memoryStream.ToArray());
	}

	public string DecryptData(string encryptedtext)
	{
		byte[] array = Convert.FromBase64String(encryptedtext);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, gvddsawrfvdv.CreateDecryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(array, 0, array.Length);
		cryptoStream.FlushFinalBlock();
		return Encoding.Unicode.GetString(memoryStream.ToArray());
	}
}
