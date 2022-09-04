using Microsoft.Win32;

namespace SmartAssembly.Shared;

public sealed class AppRegistryKeys1
{
	public static string SubkeyApplication => "Software\\Red Gate\\" + AppNameFinder1.AppName;

	public static string WowSubkeyApplication => "Software\\Wow6432Node\\Red Gate\\" + AppNameFinder1.AppName;

	public static object GetRegistryEntry(string valueName, object defaultValue)
	{
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(SubkeyApplication);
		if (registryKey == null)
		{
			return defaultValue;
		}
		return registryKey.GetValue(valueName, defaultValue);
	}

	private AppRegistryKeys1()
	{
	}
}
