using System;
using System.IO;
using System.Security.Cryptography;

namespace ns0;

internal sealed class Class21
{
	public static string string_0;

	public static byte[] smethod_0(byte[] CO_, string CO_)
	{
		if (CO_.StartsWith(Class5.smethod_0(79379)))
		{
			string_0 = Class5.smethod_0(79384);
			return null;
		}
		RijndaelManaged rijndaelManaged = null;
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		MemoryStream memoryStream = null;
		CryptoStream cryptoStream = default(CryptoStream);
		if (0 == 0)
		{
			cryptoStream = null;
		}
		try
		{
			rijndaelManaged = new RijndaelManaged();
			rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.FromXmlString(CO_);
			rijndaelManaged.GenerateKey();
			rijndaelManaged.GenerateIV();
			byte[] array = new byte[48];
			if (0 == 0)
			{
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
						string_0 = Class5.smethod_0(79477);
						return null;
					}
				}
				cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(CO_, 0, CO_.Length);
				cryptoStream.FlushFinalBlock();
			}
			return memoryStream.ToArray();
		}
		catch (Exception ex3)
		{
			string_0 = Class5.smethod_0(79683) + ex3.Message;
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
