using System;
using System.Security.Cryptography;
using System.Text;

namespace Cockblocker;

public class Encryption
{
	[Serializable]
	public class EncryptorRSAKeys
	{
		public string PublicKey { get; set; }

		public string PrivateKey { get; set; }
	}

	private static bool _optimalAsymmetricEncryptionPadding;

	public static EncryptorRSAKeys GenerateKeys(int keySize)
	{
		if (keySize % 2 == 0 && keySize >= 512)
		{
			EncryptorRSAKeys encryptorRSAKeys = new EncryptorRSAKeys();
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(keySize);
			string publicKey = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: false);
			string publicKey2 = rSACryptoServiceProvider.ToXmlString(includePrivateParameters: true);
			string publicKey3 = IncludeKeyInEncryptionString(publicKey, keySize);
			string privateKey = IncludeKeyInEncryptionString(publicKey2, keySize);
			encryptorRSAKeys.PublicKey = publicKey3;
			encryptorRSAKeys.PrivateKey = privateKey;
			return encryptorRSAKeys;
		}
		throw new Exception("Key should be multiple of two and greater than 512.");
	}

	public static string EncryptText(string text, string publicKey)
	{
		int keySize = 0;
		string xmlKey = "";
		GetKeyFromEncryptionString(publicKey, out keySize, out xmlKey);
		return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(text), keySize, xmlKey));
	}

	public static byte[] EncryptBytes(byte[] bytes, string publicKey)
	{
		int keySize = 0;
		string xmlKey = "";
		GetKeyFromEncryptionString(publicKey, out keySize, out xmlKey);
		return Encrypt(bytes, keySize, xmlKey);
	}

	public static byte[] Encrypt(byte[] data, int keySize, string publicKeyXml)
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

	public static string DecryptText(string text, string privateKey)
	{
		int keySize = 0;
		string xmlKey = "";
		GetKeyFromEncryptionString(privateKey, out keySize, out xmlKey);
		byte[] bytes = Decrypt(Convert.FromBase64String(text), keySize, xmlKey);
		return Encoding.UTF8.GetString(bytes);
	}

	public static byte[] Decrypt(byte[] data, int keySize, string publicAndPrivateKeyXml)
	{
		if (data != null && data.Length != 0)
		{
			if (!IsKeySizeValid(keySize))
			{
				throw new ArgumentException("Key size is not valid", "keySize");
			}
			if (string.IsNullOrEmpty(publicAndPrivateKeyXml))
			{
				throw new ArgumentException("Key is null or empty", "publicAndPrivateKeyXml");
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(keySize);
			rSACryptoServiceProvider.FromXmlString(publicAndPrivateKeyXml);
			return rSACryptoServiceProvider.Decrypt(data, _optimalAsymmetricEncryptionPadding);
		}
		throw new ArgumentException("Data are empty", "data");
	}

	public static int GetMaxDataLength(int keySize)
	{
		if (_optimalAsymmetricEncryptionPadding)
		{
			return (keySize - 384) / 8 + 7;
		}
		return (keySize - 384) / 8 + 37;
	}

	public static bool IsKeySizeValid(int keySize)
	{
		if (keySize >= 384 && keySize <= 16384)
		{
			return keySize % 8 == 0;
		}
		return false;
	}

	private static string IncludeKeyInEncryptionString(string publicKey, int keySize)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(keySize + "!" + publicKey));
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
			catch
			{
			}
		}
	}
}
