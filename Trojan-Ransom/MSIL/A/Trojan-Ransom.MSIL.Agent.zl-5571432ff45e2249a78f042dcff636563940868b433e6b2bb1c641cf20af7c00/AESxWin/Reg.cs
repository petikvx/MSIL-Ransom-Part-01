using System;
using System.Reflection;
using Microsoft.Win32;

namespace AESxWin;

public static class Reg
{
	public static string Read(string KeyName)
	{
		RegistryKey currentUser = Registry.CurrentUser;
		RegistryKey registryKey = currentUser.OpenSubKey("SOFTWARE\\AESxWin");
		if (registryKey == null)
		{
			return null;
		}
		try
		{
			return (string)registryKey.GetValue(KeyName);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static bool Write(string KeyName, object Value)
	{
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			RegistryKey registryKey = currentUser.CreateSubKey("SOFTWARE\\AESxWin");
			registryKey.SetValue(KeyName, Value);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static void RegisterInStartup(bool isChecked, string executablePath)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (isChecked)
		{
			registryKey.SetValue(Assembly.GetExecutingAssembly().GetName().Name, executablePath);
			return;
		}
		try
		{
			registryKey.DeleteValue(Assembly.GetExecutingAssembly().GetName().Name);
		}
		catch
		{
		}
	}
}
