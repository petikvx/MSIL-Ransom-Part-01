using Microsoft.Win32;

namespace SmartAssembly.Shared;

public class AppPathFinder1
{
	public static string ReadInstalledSaPath()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(AppRegistryKeys1.SubkeyApplication);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(AppRegistryKeys1.WowSubkeyApplication);
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)registryKey.GetValue("Path", null);
			registryKey.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}
}
