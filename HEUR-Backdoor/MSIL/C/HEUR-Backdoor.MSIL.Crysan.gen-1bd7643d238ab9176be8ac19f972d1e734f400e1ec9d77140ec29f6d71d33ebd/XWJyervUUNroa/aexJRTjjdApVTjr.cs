using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace XWJyervUUNroa;

public class aexJRTjjdApVTjr
{
	private const int FHMhBRBGafIgp = 32;

	private const int WscOKyUgiWPVTKb = 64;

	private const int XwqmMSmEPsQBtc = 16;

	private const int EDotXzNemA = 32;

	private readonly byte[] osOFAjzszCrynyJ;

	private readonly byte[] AFHvBkMRtNuEz;

	private static readonly byte[] OivNSrnKoTHB = new byte[32]
	{
		191, 235, 30, 86, 251, 205, 151, 59, 178, 25,
		2, 36, 48, 165, 120, 67, 0, 61, 86, 68,
		210, 30, 98, 185, 212, 241, 128, 231, 230, 195,
		57, 65
	};

	public aexJRTjjdApVTjr(string nbXidZdzzevL)
	{
		if (string.IsNullOrEmpty(nbXidZdzzevL))
		{
			throw new ArgumentException("masterKey can not be null or empty.");
		}
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(nbXidZdzzevL, OivNSrnKoTHB, 50000);
		osOFAjzszCrynyJ = rfc2898DeriveBytes.GetBytes(32);
		AFHvBkMRtNuEz = rfc2898DeriveBytes.GetBytes(64);
	}

	public string LkhiPrQZynzk(string BwjLyaXSeXTJ)
	{
		return Convert.ToBase64String(kzozLObdcxhQR(Encoding.UTF8.GetBytes(BwjLyaXSeXTJ)));
	}

	public byte[] kzozLObdcxhQR(byte[] bnUcDFLPYUay)
	{
		if (bnUcDFLPYUay == null)
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
			aesCryptoServiceProvider.Key = osOFAjzszCrynyJ;
			aesCryptoServiceProvider.GenerateIV();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
			memoryStream.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length);
			cryptoStream.Write(bnUcDFLPYUay, 0, bnUcDFLPYUay.Length);
			cryptoStream.FlushFinalBlock();
			using HMACSHA256 hMACSHA = new HMACSHA256(AFHvBkMRtNuEz);
			byte[] array = hMACSHA.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
			memoryStream.Position = 0L;
			memoryStream.Write(array, 0, array.Length);
		}
		return memoryStream.ToArray();
	}

	public string vyUursfgzSbLoASHh(string jZLuZIqRoQCmSo)
	{
		return Encoding.UTF8.GetString(iyLAzwSiRUrcI(Convert.FromBase64String(jZLuZIqRoQCmSo)));
	}

	public byte[] iyLAzwSiRUrcI(byte[] JxbIeSzkQOOv)
	{
		if (JxbIeSzkQOOv == null)
		{
			throw new ArgumentNullException("input can not be null.");
		}
		using MemoryStream memoryStream = new MemoryStream(JxbIeSzkQOOv);
		using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		aesCryptoServiceProvider.KeySize = 256;
		aesCryptoServiceProvider.BlockSize = 128;
		aesCryptoServiceProvider.Mode = CipherMode.CBC;
		aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		aesCryptoServiceProvider.Key = osOFAjzszCrynyJ;
		using (HMACSHA256 hMACSHA = new HMACSHA256(AFHvBkMRtNuEz))
		{
			byte[] otssRMGXyfghkt = hMACSHA.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
			byte[] array = new byte[32];
			memoryStream.Read(array, 0, array.Length);
			if (!EtMNgTBhfMWgLjtn(otssRMGXyfghkt, array))
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
	private bool EtMNgTBhfMWgLjtn(byte[] OtssRMGXyfghkt, byte[] mcDOQwuiqlUT)
	{
		bool result = true;
		for (int i = 0; i < OtssRMGXyfghkt.Length; i++)
		{
			if (OtssRMGXyfghkt[i] != mcDOQwuiqlUT[i])
			{
				result = false;
			}
		}
		return result;
	}
}
