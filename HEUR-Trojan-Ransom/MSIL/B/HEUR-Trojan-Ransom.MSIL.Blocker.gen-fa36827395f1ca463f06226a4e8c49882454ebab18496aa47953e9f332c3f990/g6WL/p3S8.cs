using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace g6WL;

[StandardModule]
internal sealed class p3S8
{
	private static TripleDESCryptoServiceProvider TripleDes = new TripleDESCryptoServiceProvider();

	public static byte[] Nd05(string Cc01, int b1Y8)
	{
		SHA1CryptoServiceProvider sHA1CryptoServiceProvider = new SHA1CryptoServiceProvider();
		byte[] bytes = Encoding.Unicode.GetBytes(Cc01);
		byte[] array = sHA1CryptoServiceProvider.ComputeHash(bytes);
		return (byte[])Utils.CopyArray((Array)array, (Array)new byte[checked(b1Y8 - 1 + 1)]);
	}

	public static string s4G1(string k1F9, string Tc51 = "password")
	{
		TripleDes.Key = Nd05(Tc51, TripleDes.KeySize / 8);
		TripleDes.IV = Nd05("", TripleDes.BlockSize / 8);
		byte[] bytes = Encoding.Unicode.GetBytes(k1F9);
		MemoryStream memoryStream = new MemoryStream();
		CryptoStream cryptoStream = new CryptoStream(memoryStream, TripleDes.CreateEncryptor(), CryptoStreamMode.Write);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		return Convert.ToBase64String(memoryStream.ToArray());
	}
}
