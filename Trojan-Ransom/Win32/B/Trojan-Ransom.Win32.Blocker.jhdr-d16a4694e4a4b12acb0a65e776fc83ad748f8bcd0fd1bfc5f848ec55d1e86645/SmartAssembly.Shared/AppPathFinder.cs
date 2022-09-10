using Microsoft.Win32;
using SmartAssembly.StringsEncoding;

namespace SmartAssembly.Shared;

public class AppPathFinder
{
	public static string ReadInstalledSaPath()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(AppRegistryKeys.SubkeyApplication);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(AppRegistryKeys.WowSubkeyApplication);
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)registryKey.GetValue(Strings.Get(710), null);
			registryKey.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}
}
