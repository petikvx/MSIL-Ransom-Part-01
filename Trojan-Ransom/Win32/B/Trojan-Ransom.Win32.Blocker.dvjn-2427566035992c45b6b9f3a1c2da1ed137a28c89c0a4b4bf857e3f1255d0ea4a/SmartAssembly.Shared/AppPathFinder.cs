using Microsoft.Win32;

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
			string result = (string)registryKey.GetValue("Path", null);
			registryKey.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}

	public AppPathFinder()
	{
		Class2.l4t8M9wzGUypc();
		base._002Ector();
	}
}
