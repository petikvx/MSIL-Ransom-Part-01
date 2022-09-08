using System;
using Microsoft.Win32;

namespace Orcus.Commands.Passwords.Utilities;

public static class RegistryKeyHelper
{
	public static bool AddRegistryKeyValue(RegistryHive hive, string path, string name, string value, bool addQuotes = false)
	{
		try
		{
			using RegistryKey registryKey = RegistryExtensions.OpenBaseKey(hive, RegistryExtensions.RegistryView.Registry64).OpenWritableSubKeySafe(path);
			if (registryKey == null)
			{
				return false;
			}
			if (addQuotes && !value.StartsWith("\"") && !value.EndsWith("\""))
			{
				value = "\"" + value + "\"";
			}
			registryKey.SetValue(name, value);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static RegistryKey OpenReadonlySubKey(RegistryHive hive, string path)
	{
		try
		{
			return RegistryExtensions.OpenBaseKey(hive, RegistryExtensions.RegistryView.Registry64).OpenSubKey(path, writable: false);
		}
		catch
		{
			return null;
		}
	}

	public static bool DeleteRegistryKeyValue(RegistryHive hive, string path, string name)
	{
		try
		{
			using RegistryKey registryKey = RegistryExtensions.OpenBaseKey(hive, RegistryExtensions.RegistryView.Registry64).OpenWritableSubKeySafe(path);
			if (registryKey == null)
			{
				return false;
			}
			registryKey.DeleteValue(name, throwOnMissingValue: true);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
