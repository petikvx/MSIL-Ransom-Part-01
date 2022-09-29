using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace cvpudwZpTgsLkc;

public class oTkAyenLTaYwJ
{
	private const int WFGCNoAXiVbLYeCN = 32;

	private const int PPuizJBHBPq = 64;

	private const int dqwFDPGYlY = 16;

	private const int wIfNhBAxWlC = 32;

	private readonly byte[] gwljcLyFEpUz;

	private readonly byte[] aKdCUSHNSOsFkKIW;

	private static readonly byte[] rqFWgNEpnsaC = new byte[32]
	{
		191, 235, 30, 86, 251, 205, 151, 59, 178, 25,
		2, 36, 48, 165, 120, 67, 0, 61, 86, 68,
		210, 30, 98, 185, 212, 241, 128, 231, 230, 195,
		57, 65
	};

	public oTkAyenLTaYwJ(string LPTWcCQPlMwv)
	{
		if (string.IsNullOrEmpty(LPTWcCQPlMwv))
		{
			throw new ArgumentException("masterKey can not be null or empty.");
		}
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(LPTWcCQPlMwv, rqFWgNEpnsaC, 50000);
		gwljcLyFEpUz = rfc2898DeriveBytes.GetBytes(32);
		aKdCUSHNSOsFkKIW = rfc2898DeriveBytes.GetBytes(64);
	}

	public string XNyimGvPWmQevcWBI(string WIySZGGJnlar)
	{
		return Convert.ToBase64String(WmCGGcuCOMFWkC(Encoding.UTF8.GetBytes(WIySZGGJnlar)));
	}

	public byte[] WmCGGcuCOMFWkC(byte[] mnZbkqmiYRvp)
	{
		if (mnZbkqmiYRvp == null)
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
			aesCryptoServiceProvider.Key = gwljcLyFEpUz;
			aesCryptoServiceProvider.GenerateIV();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
			memoryStream.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length);
			cryptoStream.Write(mnZbkqmiYRvp, 0, mnZbkqmiYRvp.Length);
			cryptoStream.FlushFinalBlock();
			using HMACSHA256 hMACSHA = new HMACSHA256(aKdCUSHNSOsFkKIW);
			byte[] array = hMACSHA.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
			memoryStream.Position = 0L;
			memoryStream.Write(array, 0, array.Length);
		}
		return memoryStream.ToArray();
	}

	public string OGkMINkJEaIIju(string lqtObWQAnyNatx)
	{
		return Encoding.UTF8.GetString(njIjEeHkNcan(Convert.FromBase64String(lqtObWQAnyNatx)));
	}

	public byte[] njIjEeHkNcan(byte[] ZFhHfzzRaw)
	{
		if (ZFhHfzzRaw == null)
		{
			throw new ArgumentNullException("input can not be null.");
		}
		using MemoryStream memoryStream = new MemoryStream(ZFhHfzzRaw);
		using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		aesCryptoServiceProvider.KeySize = 256;
		aesCryptoServiceProvider.BlockSize = 128;
		aesCryptoServiceProvider.Mode = CipherMode.CBC;
		aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		aesCryptoServiceProvider.Key = gwljcLyFEpUz;
		using (HMACSHA256 hMACSHA = new HMACSHA256(aKdCUSHNSOsFkKIW))
		{
			byte[] wISTyzXyKP = hMACSHA.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
			byte[] array = new byte[32];
			memoryStream.Read(array, 0, array.Length);
			if (!pLuMaiqKBNStngRC(wISTyzXyKP, array))
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
	private bool pLuMaiqKBNStngRC(byte[] wISTyzXyKP, byte[] ZSJcDAleIrcnSs)
	{
		bool result = true;
		for (int i = 0; i < wISTyzXyKP.Length; i++)
		{
			if (wISTyzXyKP[i] != ZSJcDAleIrcnSs[i])
			{
				result = false;
			}
		}
		return result;
	}
}
