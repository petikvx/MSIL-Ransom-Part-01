using Microsoft.Win32;

namespace ns4;

internal class Class17
{
	public static string smethod_0()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class18.SubkeyApplication);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class18.WowSubkeyApplication);
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
