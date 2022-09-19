using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class GClass30
{
	private const int int_0 = 16;

	private const int int_1 = 32;

	private static byte[] byte_0;

	private static byte[] byte_1;

	public static readonly byte[] byte_2 = new byte[32]
	{
		191, 235, 30, 86, 251, 205, 151, 59, 178, 25,
		2, 36, 48, 165, 120, 67, 0, 61, 86, 68,
		210, 30, 98, 185, 212, 241, 128, 231, 230, 195,
		57, 65
	};

	public static void smethod_0(string key)
	{
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(key, byte_2, 50000);
		byte_0 = rfc2898DeriveBytes.GetBytes(16);
		byte_1 = rfc2898DeriveBytes.GetBytes(64);
	}

	public static void smethod_1(string key, string authKey)
	{
		byte_0 = Convert.FromBase64String(key);
		byte_1 = Convert.FromBase64String(authKey);
	}

	public static string smethod_2(string input, string key)
	{
		return Convert.ToBase64String(smethod_5(Encoding.UTF8.GetBytes(input), Encoding.UTF8.GetBytes(key)));
	}

	public static string smethod_3(string input)
	{
		return Convert.ToBase64String(smethod_4(Encoding.UTF8.GetBytes(input)));
	}

	public static byte[] smethod_4(byte[] input)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			if (input != null && input.Length != 0)
			{
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
						aesCryptoServiceProvider.Key = byte_0;
						aesCryptoServiceProvider.GenerateIV();
						using CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
						memoryStream.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length);
						cryptoStream.Write(input, 0, input.Length);
						cryptoStream.FlushFinalBlock();
						using HMACSHA256 hMACSHA = new HMACSHA256(byte_1);
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
			throw new ArgumentException("Input can not be empty.");
		}
		throw new Exception("Key can not be empty.");
	}

	public static byte[] smethod_5(byte[] input, byte[] key)
	{
		if (key != null && key.Length != 0)
		{
			byte[] bytes;
			using (Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(key, byte_2, 50000))
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
		throw new Exception("Key can not be empty.");
	}

	public static string smethod_6(string input)
	{
		return Encoding.UTF8.GetString(smethod_7(Convert.FromBase64String(input)));
	}

	public static byte[] smethod_7(byte[] input)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			if (input != null && input.Length != 0)
			{
				byte[] array = new byte[0];
				try
				{
					using MemoryStream memoryStream = new MemoryStream(input);
					using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
					aesCryptoServiceProvider.KeySize = 128;
					aesCryptoServiceProvider.BlockSize = 128;
					aesCryptoServiceProvider.Mode = CipherMode.CBC;
					aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
					aesCryptoServiceProvider.Key = byte_0;
					using (HMACSHA256 hMACSHA = new HMACSHA256(byte_1))
					{
						byte[] a = hMACSHA.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
						byte[] array2 = new byte[32];
						memoryStream.Read(array2, 0, array2.Length);
						if (!GClass39.smethod_0(a, array2))
						{
							return array;
						}
					}
					byte[] array3 = new byte[16];
					memoryStream.Read(array3, 0, 16);
					aesCryptoServiceProvider.IV = array3;
					using CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read);
					byte[] array4 = new byte[memoryStream.Length - 16L + 1L];
					array = new byte[cryptoStream.Read(array4, 0, array4.Length)];
					Buffer.BlockCopy(array4, 0, array, 0, array.Length);
					return array;
				}
				catch
				{
					return array;
				}
			}
			throw new ArgumentException("Input can not be empty.");
		}
		throw new Exception("Key can not be empty.");
	}
}