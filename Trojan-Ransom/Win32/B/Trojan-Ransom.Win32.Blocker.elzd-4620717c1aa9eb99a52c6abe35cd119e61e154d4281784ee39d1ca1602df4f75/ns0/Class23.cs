using System;
using System.IO;
using System.Security.Cryptography;
using SmartAssembly.SmartExceptionsCore;

namespace ns0;

internal sealed class Class23
{
	public static string string_0;

	public static byte[] smethod_0(byte[] byte_0, string string_1)
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
			if (string_1.StartsWith("{"))
			{
				string_0 = "ERR 2006: This template was not properly processed by SmartAssembly";
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
				rSACryptoServiceProvider.FromXmlString(string_1);
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
						string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
						array8 = null;
						return array8;
					}
				}
				cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(byte_0, 0, byte_0.Length);
				cryptoStream.FlushFinalBlock();
				array8 = memoryStream.ToArray();
				return array8;
			}
			catch (Exception ex3)
			{
				ex4 = ex3;
				string_0 = "ERR 2004: " + ex4.Message;
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
		catch (Exception exception_)
		{
			StackFrameHelper.CreateExceptionN(exception_, new object[15]
			{
				rijndaelManaged, rSACryptoServiceProvider, memoryStream, cryptoStream, array, array2, array3, array4, array5, array6,
				array7, ex4, array8, byte_0, string_1
			});
			throw;
		}
	}
}
