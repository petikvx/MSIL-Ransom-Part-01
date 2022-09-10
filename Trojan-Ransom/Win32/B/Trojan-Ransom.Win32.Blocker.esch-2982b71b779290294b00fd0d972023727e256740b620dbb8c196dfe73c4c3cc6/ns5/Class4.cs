using Microsoft.Win32;
using ns6;

namespace ns5;

internal sealed class Class4
{
	public static string smethod_0()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class5.SubkeyApplication);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class5.WowSubkeyApplication);
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
