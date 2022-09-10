using Microsoft.Win32;
using SmartAssembly.StringsEncoding;

namespace SmartAssembly.Shared;

public sealed class AppRegistryKeys
{
	public static string SubkeyApplication => Strings.Get(719) + AppNameFinder.AppName;

	public static string WowSubkeyApplication => Strings.Get(744) + AppNameFinder.AppName;

	public static object GetRegistryEntry(string valueName, object defaultValue)
	{
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(SubkeyApplication);
		if (registryKey == null)
		{
			return defaultValue;
		}
		return registryKey.GetValue(valueName, defaultValue);
	}

	private AppRegistryKeys()
	{
	}
}
