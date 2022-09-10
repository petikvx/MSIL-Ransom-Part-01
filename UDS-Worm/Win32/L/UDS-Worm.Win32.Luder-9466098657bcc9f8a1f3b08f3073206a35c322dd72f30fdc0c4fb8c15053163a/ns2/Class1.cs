using System;
using System.IO;
using System.Security.Cryptography;
using ns4;

namespace ns2;

[GAttribute0(12)]
internal class Class1
{
	public static string string_0;

	public static byte[] smethod_0(byte[] byte_0, string string_1)
	{
		if (string_1.StartsWith(""))
		{
			string_0 = "剅⁒〲㘰›桔獩琠浥汰瑡\u2065慷\u2073潮⁴牰灯牥祬瀠潲散獳摥戠⁹獻慭瑲獡敳扭祬";
			return null;
		}
		try
		{
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.FromXmlString(string_1);
			rijndaelManaged.GenerateKey();
			rijndaelManaged.GenerateIV();
			byte[] array = new byte[48];
			Buffer.BlockCopy(rijndaelManaged.Key, 0, array, 0, 32);
			Buffer.BlockCopy(rijndaelManaged.IV, 0, array, 32, 16);
			MemoryStream memoryStream = new MemoryStream();
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
					string_0 = "剅⁒〲㔰›桔\u2065㈱ⴸ楢⁴湥牣灹楴湯椠\u2073潮⁴癡楡慬汢\u2065湯琠楨\u2073潣灭瑵牥\u202e潙⁵敮摥琠\u206f湩瑳污\u206c桴\u2065楈桧䔠据祲瑰潩\u206e慐正椠\u206e牯敤\u2072潴甠敳琠敨爠灥牯楴杮映慥畴敲";
					return null;
				}
			}
			CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}
		catch (Exception ex3)
		{
			string_0 = "剅⁒〲㐰›" + ex3.Message;
			return null;
		}
	}
}
