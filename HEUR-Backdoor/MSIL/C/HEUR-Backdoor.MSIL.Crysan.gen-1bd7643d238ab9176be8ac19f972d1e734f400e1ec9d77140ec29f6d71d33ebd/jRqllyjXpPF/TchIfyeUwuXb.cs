using System;
using Microsoft.Win32;
using mQpicvPmEcMJ;
using tXzQcBesFjj;

namespace jRqllyjXpPF;

public static class TchIfyeUwuXb
{
	private static readonly string PYHJkOtBKnAt = "Software\\" + dqIziPtAElY.nCfRukxEnMCPvfKsv;

	public static bool JQCvsmfEZeBzCR(string BHjVFmojPHM, byte[] xBwjLmOXXUppN)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(PYHJkOtBKnAt, RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.SetValue(BHjVFmojPHM, xBwjLmOXXUppN, RegistryValueKind.Binary);
			return true;
		}
		catch (Exception ex)
		{
			udvtJaQZJQEug.EUMFuMEVfge(ex.Message);
		}
		return false;
	}

	public static byte[] dFTpybzMcRvJV(string FweuEOjgTDO)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(PYHJkOtBKnAt);
			return (byte[])registryKey.GetValue(FweuEOjgTDO);
		}
		catch (Exception ex)
		{
			udvtJaQZJQEug.EUMFuMEVfge(ex.Message);
		}
		return null;
	}

	public static bool GxaNOqEpVzEG(string isafBrRYsPrDww)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(PYHJkOtBKnAt);
			registryKey.DeleteValue(isafBrRYsPrDww);
			return true;
		}
		catch (Exception ex)
		{
			udvtJaQZJQEug.EUMFuMEVfge(ex.Message);
		}
		return false;
	}

	public static bool zksQcuKJDhLD()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("", writable: true);
			registryKey.DeleteSubKeyTree(PYHJkOtBKnAt);
			return true;
		}
		catch (Exception ex)
		{
			udvtJaQZJQEug.EUMFuMEVfge(ex.Message);
		}
		return false;
	}
}
