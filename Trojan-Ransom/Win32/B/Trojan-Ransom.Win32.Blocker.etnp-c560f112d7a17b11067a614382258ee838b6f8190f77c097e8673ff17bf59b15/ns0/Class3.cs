using Microsoft.Win32;

namespace ns0;

internal sealed class Class3
{
	public static string smethod_0()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class4.smethod_0());
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class4.smethod_1());
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)registryKey.GetValue(Class5.smethod_0(79304), null);
			registryKey.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}
}
