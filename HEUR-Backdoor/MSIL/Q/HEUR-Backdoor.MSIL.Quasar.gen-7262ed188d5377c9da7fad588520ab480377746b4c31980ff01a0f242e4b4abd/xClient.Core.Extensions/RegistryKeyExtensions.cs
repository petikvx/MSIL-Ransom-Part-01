using System.Collections.Generic;
using System.Linq;
using Microsoft.Win32;

namespace xClient.Core.Extensions;

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

	public static RegistryKey CreateSubKeySafe(this RegistryKey key, string name)
	{
		try
		{
			return key.CreateSubKey(name);
		}
		catch
		{
			return null;
		}
	}

	public static bool DeleteSubKeyTreeSafe(this RegistryKey key, string name)
	{
		try
		{
			key.DeleteSubKeyTree(name, throwOnMissingSubKey: true);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool RenameSubKeySafe(this RegistryKey key, string oldName, string newName)
	{
		try
		{
			key.CopyKey(oldName, newName);
			key.DeleteSubKeyTree(oldName);
			return true;
		}
		catch
		{
			key.DeleteSubKeyTreeSafe(newName);
			return false;
		}
	}

	public static void CopyKey(this RegistryKey key, string oldName, string newName)
	{
		using RegistryKey destKey = key.CreateSubKey(newName);
		using RegistryKey sourceKey = key.OpenSubKey(oldName, writable: true);
		RecursiveCopyKey(sourceKey, destKey);
	}

	private static void RecursiveCopyKey(RegistryKey sourceKey, RegistryKey destKey)
	{
		string[] valueNames = sourceKey.GetValueNames();
		foreach (string name in valueNames)
		{
			object value = sourceKey.GetValue(name);
			RegistryValueKind valueKind = sourceKey.GetValueKind(name);
			destKey.SetValue(name, value, valueKind);
		}
		valueNames = sourceKey.GetSubKeyNames();
		foreach (string text in valueNames)
		{
			using RegistryKey sourceKey2 = sourceKey.OpenSubKey(text);
			using RegistryKey destKey2 = destKey.CreateSubKey(text);
			RecursiveCopyKey(sourceKey2, destKey2);
		}
	}

	public static bool SetValueSafe(this RegistryKey key, string name, object data, RegistryValueKind kind)
	{
		try
		{
			key.SetValue(name, data, kind);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool DeleteValueSafe(this RegistryKey key, string name)
	{
		try
		{
			key.DeleteValue(name);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static bool RenameValueSafe(this RegistryKey key, string oldName, string newName)
	{
		try
		{
			key.CopyValue(oldName, newName);
			key.DeleteValue(oldName);
			return true;
		}
		catch
		{
			key.DeleteValueSafe(newName);
			return false;
		}
	}

	public static void CopyValue(this RegistryKey key, string oldName, string newName)
	{
		RegistryValueKind valueKind = key.GetValueKind(oldName);
		object value = key.GetValue(oldName);
		key.SetValue(newName, value, valueKind);
	}

	public static bool ContainsSubKey(this RegistryKey key, string name)
	{
		string[] subKeyNames = key.GetSubKeyNames();
		int num = 0;
		while (true)
		{
			if (num < subKeyNames.Length)
			{
				if (subKeyNames[num] == name)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	public static bool ContainsValue(this RegistryKey key, string name)
	{
		string[] valueNames = key.GetValueNames();
		int num = 0;
		while (true)
		{
			if (num < valueNames.Length)
			{
				if (valueNames[num] == name)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
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

	public static object GetDefault(this RegistryValueKind valueKind)
	{
		switch (valueKind)
		{
		case RegistryValueKind.String:
		case RegistryValueKind.ExpandString:
			return "";
		case RegistryValueKind.Binary:
			return new byte[0];
		case RegistryValueKind.DWord:
			return 0;
		case RegistryValueKind.MultiString:
			return new string[0];
		default:
			return null;
		case RegistryValueKind.QWord:
			return 0L;
		}
	}
}
