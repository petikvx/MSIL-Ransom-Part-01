using System;

namespace WinTro_3_Client;

internal class Debug
{
	public static string completeLog = "";

	public static void Log(string text)
	{
		string text2 = completeLog;
		completeLog = text2 + DateTime.Now.TimeOfDay.ToString().Remove(9, 4) + " [INFO]: " + text + "\r\n";
		Console.WriteLine(DateTime.Now.TimeOfDay.ToString().Remove(9, 4) + " [INFO]: " + text + "\r\n");
	}

	public static void LogError(string text)
	{
		string text2 = completeLog;
		completeLog = text2 + DateTime.Now.TimeOfDay.ToString().Remove(9, 4) + " [ERR]: " + text + "\r\n";
		Console.WriteLine(DateTime.Now.TimeOfDay.ToString().Remove(9, 4) + " [ERR]: " + text + "\r\n");
	}

	public static void LogWarning(string text)
	{
		string text2 = completeLog;
		completeLog = text2 + DateTime.Now.TimeOfDay.ToString().Remove(9, 4) + " [WARN]: " + text + "\r\n";
		Console.WriteLine(DateTime.Now.TimeOfDay.ToString().Remove(9, 4) + " [WARN]: " + text + "\r\n");
	}

	public static void ClearLog()
	{
		completeLog = "Log cleared";
	}
}
