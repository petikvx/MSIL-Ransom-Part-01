using System;
using System.IO;
using System.Security.Cryptography;

namespace SmartAssembly.SmartExceptionsCore;

internal class Encryption
{
	public static string ExceptionMessage;

	public static byte[] Encrypt(byte[] byte_0, string string_0)
	{
		if (string_0.StartsWith("{"))
		{
			ExceptionMessage = "ERR 2006: This template was not properly processed by SmartAssembly";
			return null;
		}
		RijndaelManaged rijndaelManaged = null;
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		MemoryStream memoryStream = null;
		CryptoStream cryptoStream = null;
		try
		{
			rijndaelManaged = new RijndaelManaged();
			rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.FromXmlString(string_0);
			rijndaelManaged.GenerateKey();
			rijndaelManaged.GenerateIV();
			byte[] array = new byte[48];
			Buffer.BlockCopy(rijndaelManaged.Key, 0, array, 0, 32);
			Buffer.BlockCopy(rijndaelManaged.IV, 0, array, 32, 16);
			memoryStream = new MemoryStream();
			try
			{
				byte[] array2 = rSACryptoServiceProvider.Encrypt(array, fOAEP: false);
				memoryStream.WriteByte(1);
				memoryStream.WriteByte(Convert.ToByte(array2.Length / 8));
				memoryStream.Write(array2, 0, array2.Length);
			}
			catch (CryptographicException)
			{
				try
				{
					byte[] array3 = new byte[16];
					byte[] array4 = new byte[16];
					Buffer.BlockCopy(rijndaelManaged.Key, 0, array3, 0, 16);
					Buffer.BlockCopy(rijndaelManaged.Key, 16, array4, 0, 16);
					byte[] array5 = rSACryptoServiceProvider.Encrypt(array3, fOAEP: false);
					byte[] array6 = rSACryptoServiceProvider.Encrypt(array4, fOAEP: false);
					byte[] array7 = rSACryptoServiceProvider.Encrypt(rijndaelManaged.IV, fOAEP: false);
					memoryStream.WriteByte(2);
					memoryStream.WriteByte(Convert.ToByte(array5.Length / 8));
					memoryStream.Write(array5, 0, array5.Length);
					memoryStream.Write(array6, 0, array6.Length);
					memoryStream.Write(array7, 0, array7.Length);
				}
				catch (CryptographicException)
				{
					ExceptionMessage = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
					return null;
				}
			}
			cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}
		catch (Exception ex3)
		{
			ExceptionMessage = "ERR 2004: " + ex3.Message;
			return null;
		}
		finally
		{
			rijndaelManaged?.Clear();
			rSACryptoServiceProvider?.Clear();
			memoryStream?.Close();
			cryptoStream?.Close();
		}
	}
}