using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace ns22;

public class GClass29
{
	private const int int_0 = 32;

	private const int int_1 = 64;

	private const int int_2 = 16;

	private const int int_3 = 32;

	private readonly byte[] byte_0;

	private readonly byte[] byte_1;

	private static readonly byte[] byte_2 = new byte[32]
	{
		191, 235, 30, 86, 251, 205, 151, 59, 178, 25,
		2, 36, 48, 165, 120, 67, 0, 61, 86, 68,
		210, 30, 98, 185, 212, 241, 128, 231, 230, 195,
		57, 65
	};

	public GClass29(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			throw new ArgumentException("masterKey can not be null or empty.");
		}
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(string_0, byte_2, 50000);
		byte_0 = rfc2898DeriveBytes.GetBytes(32);
		byte_1 = rfc2898DeriveBytes.GetBytes(64);
	}

	public string method_0(string string_0)
	{
		return Convert.ToBase64String(method_1(Encoding.UTF8.GetBytes(string_0)));
	}

	public byte[] method_1(byte[] byte_3)
	{
		if (byte_3 == null)
		{
			throw new ArgumentNullException("input can not be null.");
		}
		using MemoryStream memoryStream = new MemoryStream();
		memoryStream.Position = 32L;
		using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
		{
			aesCryptoServiceProvider.KeySize = 256;
			aesCryptoServiceProvider.BlockSize = 128;
			aesCryptoServiceProvider.Mode = CipherMode.CBC;
			aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			aesCryptoServiceProvider.Key = byte_0;
			aesCryptoServiceProvider.GenerateIV();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
			memoryStream.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length);
			cryptoStream.Write(byte_3, 0, byte_3.Length);
			cryptoStream.FlushFinalBlock();
			using HMACSHA256 hMACSHA = new HMACSHA256(byte_1);
			byte[] array = hMACSHA.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
			memoryStream.Position = 0L;
			memoryStream.Write(array, 0, array.Length);
		}
		return memoryStream.ToArray();
	}

	public string method_2(string string_0)
	{
		return Encoding.UTF8.GetString(method_3(Convert.FromBase64String(string_0)));
	}

	public byte[] method_3(byte[] byte_3)
	{
		if (byte_3 == null)
		{
			throw new ArgumentNullException("input can not be null.");
		}
		using MemoryStream memoryStream = new MemoryStream(byte_3);
		using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		aesCryptoServiceProvider.KeySize = 256;
		aesCryptoServiceProvider.BlockSize = 128;
		aesCryptoServiceProvider.Mode = CipherMode.CBC;
		aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		aesCryptoServiceProvider.Key = byte_0;
		using (HMACSHA256 hMACSHA = new HMACSHA256(byte_1))
		{
			byte[] byte_4 = hMACSHA.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
			byte[] array = new byte[32];
			memoryStream.Read(array, 0, array.Length);
			if (!method_4(byte_4, array))
			{
				throw new CryptographicException("Invalid message authentication code (MAC).");
			}
		}
		byte[] array2 = new byte[16];
		memoryStream.Read(array2, 0, 16);
		aesCryptoServiceProvider.IV = array2;
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateDecryptor(), CryptoStreamMode.Read);
		byte[] array3 = new byte[memoryStream.Length - 16L + 1L];
		byte[] array4 = new byte[cryptoStream.Read(array3, 0, array3.Length)];
		Buffer.BlockCopy(array3, 0, array4, 0, array4.Length);
		return array4;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private bool method_4(byte[] byte_3, byte[] byte_4)
	{
		bool result = true;
		for (int i = 0; i < byte_3.Length; i++)
		{
			if (byte_3[i] != byte_4[i])
			{
				result = false;
			}
		}
		return result;
	}
}
