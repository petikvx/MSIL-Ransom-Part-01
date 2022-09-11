using System;
using System.Reflection;
using Microsoft.Win32;

public static class GClass1
{
	public static string smethod_0(string string_0)
	{
		RegistryKey currentUser = Registry.CurrentUser;
		RegistryKey registryKey = currentUser.OpenSubKey("SOFTWARE\\Aktualizacje");
		if (registryKey == null)
		{
			return null;
		}
		try
		{
			return (string)registryKey.GetValue(string_0);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static bool smethod_1(string string_0, object object_0)
	{
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			RegistryKey registryKey = currentUser.CreateSubKey("SOFTWARE\\Aktualizacje");
			registryKey.SetValue(string_0, object_0);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static void smethod_2(bool bool_0, string string_0)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		if (bool_0)
		{
			registryKey.SetValue(Assembly.GetExecutingAssembly().GetName().Name, string_0);
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
