using Microsoft.Win32;
using ns4;

namespace ns2;

public sealed class GClass2
{
	public static string SubkeyApplication => "Software\\Red Gate\\" + GClass0.AppName;

	public static string WowSubkeyApplication => "Software\\Wow6432Node\\Red Gate\\" + GClass0.AppName;

	public static object smethod_0(string string_0, object object_0)
	{
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(SubkeyApplication);
		if (registryKey == null)
		{
			return object_0;
		}
		return registryKey.GetValue(string_0, object_0);
	}

	private GClass2()
	{
	}

	static GClass2()
	{
		GClass11.smethod_0();
	}
}
