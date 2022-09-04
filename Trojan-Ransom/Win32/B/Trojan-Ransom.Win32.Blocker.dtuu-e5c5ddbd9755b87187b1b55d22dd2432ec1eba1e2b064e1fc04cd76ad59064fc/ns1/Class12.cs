using Microsoft.Win32;
using ns0;

namespace ns1;

internal sealed class Class12
{
	public static string SubkeyApplication => "Software\\Red Gate\\" + Class10.AppName;

	public static string WowSubkeyApplication => "Software\\Wow6432Node\\Red Gate\\" + Class10.AppName;

	public static object smethod_0(string string_0, object object_0)
	{
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(SubkeyApplication);
		if (registryKey == null)
		{
			return object_0;
		}
		return registryKey.GetValue(string_0, object_0);
	}

	private Class12()
	{
	}
}
