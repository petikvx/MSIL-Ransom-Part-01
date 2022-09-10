using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace SuRuOqJLMjKylb;

public class zAIvmrFQADQUgTG
{
	private const int tBgMnfQbWNoD = 32;

	private const int zHpQeVnwXuL = 64;

	private const int UCzuoGttAXuu = 16;

	private const int VfYrDPEQoAlkcWY = 32;

	private readonly byte[] qftdAYwwYWSlN;

	private readonly byte[] OnPexPrsMYcfY;

	private static readonly byte[] xWnvlYpSLVrcw = new byte[32]
	{
		191, 235, 30, 86, 251, 205, 151, 59, 178, 25,
		2, 36, 48, 165, 120, 67, 0, 61, 86, 68,
		210, 30, 98, 185, 212, 241, 128, 231, 230, 195,
		57, 65
	};

	public zAIvmrFQADQUgTG(string tellRUMCZjpdX)
	{
		if (string.IsNullOrEmpty(tellRUMCZjpdX))
		{
			throw new ArgumentException("masterKey can not be null or empty.");
		}
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(tellRUMCZjpdX, xWnvlYpSLVrcw, 50000);
		qftdAYwwYWSlN = rfc2898DeriveBytes.GetBytes(32);
		OnPexPrsMYcfY = rfc2898DeriveBytes.GetBytes(64);
	}

	public string zNdoaBCLXMaFPAys(string LhbzkytjHNI)
	{
		return Convert.ToBase64String(hKvZQrzTmHOFr(Encoding.UTF8.GetBytes(LhbzkytjHNI)));
	}

	public byte[] hKvZQrzTmHOFr(byte[] hdvNjYIktkGVho)
	{
		if (hdvNjYIktkGVho == null)
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
			aesCryptoServiceProvider.Key = qftdAYwwYWSlN;
			aesCryptoServiceProvider.GenerateIV();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
			memoryStream.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length);
			cryptoStream.Write(hdvNjYIktkGVho, 0, hdvNjYIktkGVho.Length);
			cryptoStream.FlushFinalBlock();
			using HMACSHA256 hMACSHA = new HMACSHA256(OnPexPrsMYcfY);
			byte[] array = hMACSHA.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
			memoryStream.Position = 0L;
			memoryStream.Write(array, 0, array.Length);
		}
		return memoryStream.ToArray();
	}

	public string QSECOdEJOxeRbtGT(string lzCXlxWBTPwKMA)
	{
		return Encoding.UTF8.GetString(meHnMrCfIUc(Convert.FromBase64String(lzCXlxWBTPwKMA)));
	}

	public byte[] meHnMrCfIUc(byte[] XRBXxwUWwPZd)
	{
		if (XRBXxwUWwPZd == null)
		{
			throw new ArgumentNullException("input can not be null.");
		}
		using MemoryStream memoryStream = new MemoryStream(XRBXxwUWwPZd);
		using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		aesCryptoServiceProvider.KeySize = 256;
		aesCryptoServiceProvider.BlockSize = 128;
		aesCryptoServiceProvider.Mode = CipherMode.CBC;
		aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		aesCryptoServiceProvider.Key = qftdAYwwYWSlN;
		using (HMACSHA256 hMACSHA = new HMACSHA256(OnPexPrsMYcfY))
		{
			byte[] yScPZpPeRpQBmB = hMACSHA.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
			byte[] array = new byte[32];
			memoryStream.Read(array, 0, array.Length);
			if (!RltMQIbDcuKL(yScPZpPeRpQBmB, array))
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
	private bool RltMQIbDcuKL(byte[] YScPZpPeRpQBmB, byte[] eObPAZGiEl)
	{
		bool result = true;
		for (int i = 0; i < YScPZpPeRpQBmB.Length; i++)
		{
			if (YScPZpPeRpQBmB[i] != eObPAZGiEl[i])
			{
				result = false;
			}
		}
		return result;
	}
}
