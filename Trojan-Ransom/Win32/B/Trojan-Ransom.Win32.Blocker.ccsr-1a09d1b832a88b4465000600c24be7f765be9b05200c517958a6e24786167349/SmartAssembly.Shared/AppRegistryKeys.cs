using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using SmartAssembly.Zip;

namespace SmartAssembly.Shared;

public sealed class AppRegistryKeys
{
	public static string SubkeyApplication => ReportSender.smethod_0("Software\\Red Gate\\", AppNameFinder.AppName, 496, 403);

	public static string WowSubkeyApplication => ReportSender.smethod_0("Software\\Wow6432Node\\Red Gate\\", AppNameFinder.AppName, 931, 960);

	public static object GetRegistryEntry(string valueName, object defaultValue)
	{
		using RegistryKey registryKey = SimpleZip.Class8.smethod_0(Registry.LocalMachine, SubkeyApplication, 177, 129);
		if (registryKey == null)
		{
			return defaultValue;
		}
		return SimpleZip.Class4.smethod_0(registryKey, valueName, defaultValue, 520, 585);
	}

	private AppRegistryKeys()
	{
	}

	static AppRegistryKeys()
	{
		DESCryptoIndirector.smethod_0();
	}
}
