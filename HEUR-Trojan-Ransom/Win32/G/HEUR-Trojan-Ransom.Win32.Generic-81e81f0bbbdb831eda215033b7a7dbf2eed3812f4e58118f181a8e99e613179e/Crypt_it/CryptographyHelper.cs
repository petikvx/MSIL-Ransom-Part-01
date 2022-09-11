using System;
using System.Security.Cryptography;
using System.Text;

namespace Crypt_it;

public static class CryptographyHelper
{
	private static bool _optimalAsymmetricEncryptionPadding = false;

	private static readonly string PublicKey = "MjA0OCE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+ejkzREcvV1hjM05DcjVCQUtnTHB3ckpXbzdOaTBRSFp6RTg3eVA1akFvaWJCdzBPcWlQYnIyL3ZBa2x1SUxwYTVtT0FHQnd5ajBTdDBTOFVwNWVYa1RkTE9SQTNtTGJLK3hVY3FxZ29yR3h6bWl3REJjTmNWM3BGSEFHUkw0VnloOVRyaEoyRFlsZTdoYTNrRnk2TzcxT1FTWk5zUHUydTdpbXcyallDNkZCYW5OQW5Ua0dQdWsyeUpzRnJ0eDdVM0RmM3RjUDZhZjRQL0pFQVQ1TUZFWUJOVnFpMHdyTTlPWFJReURhUmVPclRUQ0lJeFRDaUdtVk1VUHMxNUJNQzZPMGJxSXAzelRZR2UvbFBtck50QTlQSWxBSDRjZ1haK1RZaVdPK1Rlck1QV050TmtqMFNFMHRQa1RHRnVMKzBMakNVNlhQVzhIRktZWmdFaStsaHdRPT08L01vZHVsdXM+PEV4cG9uZW50PkFRQUI8L0V4cG9uZW50PjwvUlNBS2V5VmFsdWU+";

	public static string Encrypt(string plainText)
	{
		int keySize = 0;
		string xmlKey = "";
		GetKeyFromEncryptionString(PublicKey, out keySize, out xmlKey);
		byte[] inArray = Encrypt(Encoding.UTF8.GetBytes(plainText), keySize, xmlKey);
		return Convert.ToBase64String(inArray);
	}

	private static byte[] Encrypt(byte[] data, int keySize, string publicKeyXml)
	{
		if (data != null && data.Length != 0)
		{
			int maxDataLength = GetMaxDataLength(keySize);
			if (data.Length > maxDataLength)
			{
				throw new ArgumentException($"Maximum data length is {maxDataLength}", "data");
			}
			if (!IsKeySizeValid(keySize))
			{
				throw new ArgumentException("Key size is not valid", "keySize");
			}
			if (string.IsNullOrEmpty(publicKeyXml))
			{
				throw new ArgumentException("Key is null or empty", "publicKeyXml");
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(keySize);
			rSACryptoServiceProvider.FromXmlString(publicKeyXml);
			return rSACryptoServiceProvider.Encrypt(data, _optimalAsymmetricEncryptionPadding);
		}
		throw new ArgumentException("Data are empty", "data");
	}

	private static int GetMaxDataLength(int keySize)
	{
		if (_optimalAsymmetricEncryptionPadding)
		{
			return (keySize - 384) / 8 + 7;
		}
		return (keySize - 384) / 8 + 37;
	}

	private static bool IsKeySizeValid(int keySize)
	{
		if (keySize >= 384 && keySize <= 16384)
		{
			return keySize % 8 == 0;
		}
		return false;
	}

	private static void GetKeyFromEncryptionString(string rawkey, out int keySize, out string xmlKey)
	{
		keySize = 0;
		xmlKey = "";
		if (rawkey == null || rawkey.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(rawkey);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				keySize = int.Parse(array[0]);
				xmlKey = array[1];
			}
			catch (Exception)
			{
			}
		}
	}
}
