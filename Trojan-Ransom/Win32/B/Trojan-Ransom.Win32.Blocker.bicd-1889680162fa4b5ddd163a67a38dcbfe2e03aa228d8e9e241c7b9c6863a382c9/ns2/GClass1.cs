using Microsoft.Win32;
using ns4;

namespace ns2;

public class GClass1
{
	public static string smethod_0()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(GClass2.SubkeyApplication);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(GClass2.WowSubkeyApplication);
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

	static GClass1()
	{
		GClass11.smethod_0();
	}
}
