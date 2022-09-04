using System;
using System.IO;
using System.Security.Cryptography;

namespace SmartAssembly.SmartExceptionsCore;

internal class Encryption1
{
	public static string ExceptionMessage;

	public static byte[] Encrypt(byte[] data, string xmlPublicKey)
	{
		RijndaelManaged rijndaelManaged = default(RijndaelManaged);
		RSACryptoServiceProvider rSACryptoServiceProvider = default(RSACryptoServiceProvider);
		MemoryStream memoryStream = default(MemoryStream);
		CryptoStream cryptoStream = default(CryptoStream);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		byte[] array3 = default(byte[]);
		byte[] array4 = default(byte[]);
		byte[] array5 = default(byte[]);
		byte[] array6 = default(byte[]);
		byte[] array7 = default(byte[]);
		byte[] array8 = default(byte[]);
		Exception ex4 = default(Exception);
		try
		{
			if (xmlPublicKey.StartsWith("{"))
			{
				ExceptionMessage = "ERR 2006: This template was not properly processed by SmartAssembly";
				return null;
			}
			rijndaelManaged = null;
			rSACryptoServiceProvider = null;
			memoryStream = null;
			cryptoStream = null;
			try
			{
				rijndaelManaged = new RijndaelManaged();
				rSACryptoServiceProvider = new RSACryptoServiceProvider();
				rSACryptoServiceProvider.FromXmlString(xmlPublicKey);
				rijndaelManaged.GenerateKey();
				rijndaelManaged.GenerateIV();
				array = new byte[48];
				Buffer.BlockCopy(rijndaelManaged.Key, 0, array, 0, 32);
				Buffer.BlockCopy(rijndaelManaged.IV, 0, array, 32, 16);
				memoryStream = new MemoryStream();
				try
				{
					array2 = rSACryptoServiceProvider.Encrypt(array, fOAEP: false);
					memoryStream.WriteByte(1);
					memoryStream.WriteByte(Convert.ToByte(array2.Length / 8));
					memoryStream.Write(array2, 0, array2.Length);
				}
				catch (CryptographicException)
				{
					try
					{
						array3 = new byte[16];
						array4 = new byte[16];
						Buffer.BlockCopy(rijndaelManaged.Key, 0, array3, 0, 16);
						Buffer.BlockCopy(rijndaelManaged.Key, 16, array4, 0, 16);
						array5 = rSACryptoServiceProvider.Encrypt(array3, fOAEP: false);
						array6 = rSACryptoServiceProvider.Encrypt(array4, fOAEP: false);
						array7 = rSACryptoServiceProvider.Encrypt(rijndaelManaged.IV, fOAEP: false);
						memoryStream.WriteByte(2);
						memoryStream.WriteByte(Convert.ToByte(array5.Length / 8));
						memoryStream.Write(array5, 0, array5.Length);
						memoryStream.Write(array6, 0, array6.Length);
						memoryStream.Write(array7, 0, array7.Length);
					}
					catch (CryptographicException)
					{
						ExceptionMessage = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
						array8 = null;
						return array8;
					}
				}
				cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(data, 0, data.Length);
				cryptoStream.FlushFinalBlock();
				array8 = memoryStream.ToArray();
				return array8;
			}
			catch (Exception ex3)
			{
				ex4 = ex3;
				ExceptionMessage = "ERR 2004: " + ex4.Message;
				array8 = null;
				return array8;
			}
			finally
			{
				rijndaelManaged?.Clear();
				rSACryptoServiceProvider?.Clear();
				memoryStream?.Close();
				cryptoStream?.Close();
			}
		}
		catch (Exception caughtException)
		{
			StackFrameHelper.CreateExceptionN(caughtException, new object[15]
			{
				rijndaelManaged, rSACryptoServiceProvider, memoryStream, cryptoStream, array, array2, array3, array4, array5, array6,
				array7, ex4, array8, data, xmlPublicKey
			});
			throw;
		}
	}
}
