using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.Zip;

namespace SmartAssembly.Shared;

public class AppPathFinder
{
	public static string ReadInstalledSaPath()
	{
		try
		{
			RegistryKey registryKey = SimpleZip.Class8.smethod_0(Registry.LocalMachine, AppRegistryKeys.SubkeyApplication, 793, 809);
			if (registryKey == null)
			{
				registryKey = SimpleZip.Class8.smethod_0(Registry.LocalMachine, AppRegistryKeys.WowSubkeyApplication, 496, 448);
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)SimpleZip.Class4.smethod_0(registryKey, "Path", null, 590, 527);
			DoNotPruneTypeAttribute.smethod_0(registryKey, 1004, 972);
			return result;
		}
		catch
		{
			return null;
		}
	}

	static AppPathFinder()
	{
		DESCryptoIndirector.smethod_0();
	}
}
