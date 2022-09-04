using Microsoft.Win32;
using ns6;

namespace ns5;

internal class Class10
{
	public static string smethod_0()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class11.smethod_0());
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class11.smethod_1());
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
