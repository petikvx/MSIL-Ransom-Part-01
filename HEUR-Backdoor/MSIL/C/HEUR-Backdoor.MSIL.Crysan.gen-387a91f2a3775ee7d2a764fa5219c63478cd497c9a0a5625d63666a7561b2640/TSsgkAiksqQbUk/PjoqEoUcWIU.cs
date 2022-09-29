using System;
using FLyjDGiQaWOL;
using Microsoft.Win32;
using gDUxSbRqUN;

namespace TSsgkAiksqQbUk;

public static class PjoqEoUcWIU
{
	private static readonly string fRgJtxwCFJkSG = "Software\\" + slKZMvijUhIUq.XzgMNqxRIl;

	public static bool LXCwoVoTCBpwp(string ObzkCLzGZcYjBsj, byte[] ItZQitsicWAKS)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(fRgJtxwCFJkSG, RegistryKeyPermissionCheck.ReadWriteSubTree);
			registryKey.SetValue(ObzkCLzGZcYjBsj, ItZQitsicWAKS, RegistryValueKind.Binary);
			return true;
		}
		catch (Exception ex)
		{
			tXsdFYrhAJnAoTF.tyVAlXhLSrok(ex.Message);
		}
		return false;
	}

	public static byte[] LhuGdihocg(string HHHHMIqKgkLg)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(fRgJtxwCFJkSG);
			return (byte[])registryKey.GetValue(HHHHMIqKgkLg);
		}
		catch (Exception ex)
		{
			tXsdFYrhAJnAoTF.tyVAlXhLSrok(ex.Message);
		}
		return null;
	}

	public static bool dWcbqYaCjXjDv(string BKKKOzflTk)
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(fRgJtxwCFJkSG);
			registryKey.DeleteValue(BKKKOzflTk);
			return true;
		}
		catch (Exception ex)
		{
			tXsdFYrhAJnAoTF.tyVAlXhLSrok(ex.Message);
		}
		return false;
	}

	public static bool cWxawrYEoNFDOhh()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("", writable: true);
			registryKey.DeleteSubKeyTree(fRgJtxwCFJkSG);
			return true;
		}
		catch (Exception ex)
		{
			tXsdFYrhAJnAoTF.tyVAlXhLSrok(ex.Message);
		}
		return false;
	}
}
