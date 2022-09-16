using System;
using Microsoft.Win32;
using QoJxByZkfRQq;
using cMmGWpngxFJQy;

namespace TRjqmOcqLzx;

public static class VNtFEJxQkxpTWB
{
	private static readonly string GUEbQOvYuQu = "Software\\" + hFmOFeqzArJ.yihvSlyKIDo;

	public static bool RGZQvgTHyswE(string lXUekSAWpHeFTxfuU, byte[] mtJeYNTGWwFta)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(GUEbQOvYuQu, RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.SetValue(lXUekSAWpHeFTxfuU, mtJeYNTGWwFta, RegistryValueKind.Binary);
			return true;
		}
		catch (Exception ex)
		{
			xzhpUDLIXjgv.JDmUHRTkLLFM(ex.Message);
		}
		return false;
	}

	public static byte[] nLvMzrCkSqqurOO(string UXZpeISGPOi)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(GUEbQOvYuQu);
			return (byte[])registryKey.GetValue(UXZpeISGPOi);
		}
		catch (Exception ex)
		{
			xzhpUDLIXjgv.JDmUHRTkLLFM(ex.Message);
		}
		return null;
	}

	public static bool jfJAzHzcxrsti(string MqodTQAlWqtB)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(GUEbQOvYuQu);
			registryKey.DeleteValue(MqodTQAlWqtB);
			return true;
		}
		catch (Exception ex)
		{
			xzhpUDLIXjgv.JDmUHRTkLLFM(ex.Message);
		}
		return false;
	}

	public static bool toCylCAwbLoTyb()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("", writable: true);
			registryKey.DeleteSubKeyTree(GUEbQOvYuQu);
			return true;
		}
		catch (Exception ex)
		{
			xzhpUDLIXjgv.JDmUHRTkLLFM(ex.Message);
		}
		return false;
	}
}
