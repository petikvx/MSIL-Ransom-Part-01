using Microsoft.Win32;

internal sealed class Class2
{
	public static string smethod_0()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class3.smethod_0());
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class3.smethod_1());
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
