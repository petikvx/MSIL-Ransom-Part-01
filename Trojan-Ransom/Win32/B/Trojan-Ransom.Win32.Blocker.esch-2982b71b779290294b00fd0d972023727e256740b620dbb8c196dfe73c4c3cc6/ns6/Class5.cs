using Microsoft.Win32;
using ns5;

namespace ns6;

internal sealed class Class5
{
	public static string SubkeyApplication => "Software\\Red Gate\\" + Class3.AppName;

	public static string WowSubkeyApplication => "Software\\Wow6432Node\\Red Gate\\" + Class3.AppName;

	public static object smethod_0(string valueName, object defaultValue)
	{
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(SubkeyApplication);
		if (registryKey == null)
		{
			return defaultValue;
		}
		return registryKey.GetValue(valueName, defaultValue);
	}

	private Class5()
	{
	}
}
