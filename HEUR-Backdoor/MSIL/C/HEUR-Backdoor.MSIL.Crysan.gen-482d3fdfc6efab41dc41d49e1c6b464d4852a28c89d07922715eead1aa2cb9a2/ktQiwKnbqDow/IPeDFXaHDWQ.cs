using System;
using Microsoft.Win32;
using XQTTiTqzQXXI;
using rKqbOBEzRh;

namespace ktQiwKnbqDow;

public static class IPeDFXaHDWQ
{
	private static readonly string xzfFFRfLqipPW = "Software\\" + OOyHmWyLirxV.bRvphStTyKGSHuM;

	public static bool tExVPMaUfS(string hrQMJKZLdThj, byte[] TufGcGqaIYCPp)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(xzfFFRfLqipPW, RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.SetValue(hrQMJKZLdThj, TufGcGqaIYCPp, RegistryValueKind.Binary);
			return true;
		}
		catch (Exception ex)
		{
			AyjlGwqvgbad.VyXvgDdgmLoO(ex.Message);
		}
		return false;
	}

	public static byte[] uuBNtWKxHqnXlwdl(string wVAUNrhuZPHSndvf)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(xzfFFRfLqipPW);
			return (byte[])registryKey.GetValue(wVAUNrhuZPHSndvf);
		}
		catch (Exception ex)
		{
			AyjlGwqvgbad.VyXvgDdgmLoO(ex.Message);
		}
		return null;
	}

	public static bool jzofpgEBwVhbUNJhE(string NrJHymPChKZvl)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(xzfFFRfLqipPW);
			registryKey.DeleteValue(NrJHymPChKZvl);
			return true;
		}
		catch (Exception ex)
		{
			AyjlGwqvgbad.VyXvgDdgmLoO(ex.Message);
		}
		return false;
	}

	public static bool RafroOdKmXja()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("", writable: true);
			registryKey.DeleteSubKeyTree(xzfFFRfLqipPW);
			return true;
		}
		catch (Exception ex)
		{
			AyjlGwqvgbad.VyXvgDdgmLoO(ex.Message);
		}
		return false;
	}
}
