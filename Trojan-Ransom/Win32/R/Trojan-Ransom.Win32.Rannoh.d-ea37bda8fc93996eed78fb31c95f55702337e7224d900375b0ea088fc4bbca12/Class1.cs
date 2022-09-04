using Microsoft.Win32;

internal static class Class1
{
	public static string smethod_0()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(smethod_1());
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(smethod_2());
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)registryKey.GetValue("InstallDir", null);
			registryKey.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}

	private static string smethod_1()
	{
		return "Software\\" + Class0.smethod_0();
	}

	private static string smethod_2()
	{
		return "Software\\Wow6432Node\\" + Class0.smethod_0();
	}
}
