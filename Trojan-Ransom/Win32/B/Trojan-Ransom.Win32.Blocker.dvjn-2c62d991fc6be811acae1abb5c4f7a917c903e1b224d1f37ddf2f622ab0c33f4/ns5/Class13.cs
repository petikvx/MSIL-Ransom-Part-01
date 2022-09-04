using Microsoft.Win32;
using ns8;
using ns9;

namespace ns5;

internal sealed class Class13
{
	public static string smethod_0()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class14.smethod_0());
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class14.smethod_1());
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)registryKey.GetValue(Class15.smethod_0(949191), null);
			registryKey.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}
}
