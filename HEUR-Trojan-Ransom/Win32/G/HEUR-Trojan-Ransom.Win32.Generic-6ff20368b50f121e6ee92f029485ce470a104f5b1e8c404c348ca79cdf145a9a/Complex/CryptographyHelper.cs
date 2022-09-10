using System;
using System.Security.Cryptography;
using System.Text;

namespace Complex;

public static class CryptographyHelper
{
	private static bool _optimalAsymmetricEncryptionPadding = false;

	private static readonly string PublicKey = "MjA0OCE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+bksvNHYwNlJOS2UzWU9FRTJXRVBQbE9EajF3aFh4UGxZZTcyZXRnUm9uR2JOQ3lMbTJFTjd3aWh6NkIxaDJYRkx5OGsydjhPUUJ6RTFocHZuRE5WOTlJdHQzL3dPaEpJei93QTA0MTg1MVFkY3lnTmlhYkdhT2VFWUdGZEZvQUlOT2VyalNUaFV3S1JuQTUwcW9qekRFc1kzbHhsMFVuUjlDaGJtL3JxM2s5NHZkbFVuNk1GZGw0cVFQTkowdC9SSzdyOGFhKzcvSkNIVTdKRWtVVElMZ3ZhZnd6bHZtZjcxSmd5bUI3Njlvb242eVZFcXoxQVZOZHlWT3lkQnVINEFEYlI5SGlBeVFoT3dWQ0NYdVlHeUEzRHhKbGJUSHh0U2lKaVU2VkNjVjNBV21zMk1DMFR4V0NRakNSNnpNRmpoK2dYMXNmRVlpMHM1RldwVnlPcnJ3PT08L01vZHVsdXM+PEV4cG9uZW50PkFRQUI8L0V4cG9uZW50PjwvUlNBS2V5VmFsdWU+";

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
		if (data == null || data.Length == 0)
		{
			throw new ArgumentException("Data are empty", "data");
		}
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
		return keySize >= 384 && keySize <= 16384 && keySize % 8 == 0;
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
