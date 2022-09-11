using System;
using System.Security.Cryptography;
using System.Text;

namespace Complex;

public static class CryptographyHelper
{
	private static bool _optimalAsymmetricEncryptionPadding = false;

	private static readonly string PublicKey = "NDA5NiE8UlNBS2V5VmFsdWU+PE1vZHVsdXM+cGxXditMYldoOW9HNS94TUlvNzhRZnpiY1pLY2s3UVlqeCtLSG1lTEx5cUJkOFlQV0djV0daci9KMUtleXBkMlJuTXRmT0xDczhOR0krMk84cENqN3E5eWNzc3lSdnpkbmM1UThEU2JIZ2p0a1lWMUVlRVZlYk4vWjVKUzg5Rmt0WVNYcW5NTzk0dzVtS3RQd0tNVzE0Nk4yRW4zN1JaVk5sWnFNM1UrNlZKZzVtQW44aDRYTjRkeHZzRzNRUm9qZmdsTzZ4Z2Z6TVkxcGhUTTBHTkNIYklvUGp3REllMEFUMmsrVzVGZG8xTThBcmswck1pWklubkpFZGFEUC9TQmFyMmd4MFFSZEtwSk4yUXl6OUc0d1hQc3hNNTRqekdEYlgyZnZyeCtWcDNKVk5aYks5QngySEZHVnFCdmNVeHdwTmJpUzNhWjFMZmxha0p1Y0pFVWhVUkd4bzVKR29ySkNoR25ZNlY4OEx2ZnBIZXdGZWZCb3NoZXNwY3ZSNisxSTF4MmxUcThBN2MyeW42ZWZMRWtNYnpVOXZYUjRTV0JxaDZpYU9ZeGlsMm9pMS9VYWtualFId1U5VjJ6RkY4cVZ1WVNBN0RMcStiK2o4d1lRQVAxcUFiUHlRdmx5cERNRDNiZUxuY0VwTXNza1llU3VqZVRIdUpuTHhiUkl6L0xPdWFDZUpta3kzL1dTODJrYUpKUVM4Q1ozVU1aSHdVZVVCNWFCVFdpN01BY2dBUjFuNUhxVit3V0hBWFBtRW94My80bGk2dERjUzcraXpNd3Z1NWdOZTZ4WWYrMUlyblhPZmgzd1RxRzZKTC9RZHpCK2E1RnRBdWVvTHdmVnlKNWtqZ1ZZcU9WTHFUSnZ3V2o3aXpOd1FkdUFKOFljenc3Z3VxR3lwbitqKzA9PC9Nb2R1bHVzPjxFeHBvbmVudD5BUUFCPC9FeHBvbmVudD48L1JTQUtleVZhbHVlPg==";

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
