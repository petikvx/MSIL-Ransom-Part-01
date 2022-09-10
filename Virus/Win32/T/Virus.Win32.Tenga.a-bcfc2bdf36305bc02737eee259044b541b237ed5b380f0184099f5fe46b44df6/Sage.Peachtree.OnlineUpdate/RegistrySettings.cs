using Microsoft.Win32;

namespace Sage.Peachtree.OnlineUpdate;

public class RegistrySettings
{
	public static string ReadStringValue(string path, string key)
	{
		string text = string.Empty;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(path);
		if (registryKey != null)
		{
			text = (string)registryKey.GetValue(key);
			if (text == null)
			{
				text = string.Empty;
			}
		}
		return text;
	}

	public static int ReadIntValue(string path, string key)
	{
		int result = 0;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(path);
		if (registryKey != null)
		{
			result = (int)registryKey.GetValue(key);
		}
		return result;
	}

	public static void WriteStringValue(string path, string key, string stringValue)
	{
		Registry.LocalMachine.OpenSubKey(path, writable: true)?.SetValue(key, stringValue);
	}

	public static void WriteIntValue(string path, string key, int intValue)
	{
		Registry.LocalMachine.OpenSubKey(path, writable: true)?.SetValue(key, intValue);
	}
}
