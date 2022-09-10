using System;
using System.IO;

namespace Helper;

public static class TraceLog
{
	public const string c_LogFile = "log.txt";

	private static bool _newLine = true;

	public static bool WriteToFile = false;

	public static void Print(string format, params object[] args)
	{
		string message = GetMessage(format, args);
		DateTime dateTime = DateTime.Now.ToLocalTime();
		ConsoleColor foregroundColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.Gray;
		if (_newLine)
		{
			string text = $"[{dateTime}]: ";
			Console.Write(text);
			WriteToLogFile(text);
			_newLine = false;
		}
		Console.ForegroundColor = ConsoleColor.Green;
		Console.Write(message);
		WriteToLogFile(message);
		Console.ForegroundColor = foregroundColor;
	}

	public static void PrintLn(string format, params object[] args)
	{
		Print(format, args);
		WriteToLogFile("\r\n");
		Console.WriteLine();
		_newLine = true;
	}

	public static void Error(string format, params object[] args)
	{
		string message = GetMessage(format, args);
		DateTime dateTime = DateTime.Now.ToLocalTime();
		ConsoleColor foregroundColor = Console.ForegroundColor;
		Console.ForegroundColor = ConsoleColor.Red;
		if (!_newLine)
		{
			WriteToLogFile("\r\n");
			Console.WriteLine();
		}
		string text = $"[{dateTime}]: {message}";
		WriteToLogFile(text + "\r\n");
		Console.WriteLine(text);
		Console.ForegroundColor = foregroundColor;
		_newLine = true;
	}

	private static string GetMessage(string format, object[] args)
	{
		if (args.Length > 0)
		{
			return string.Format(format, args);
		}
		return format;
	}

	private static void WriteToLogFile(string str)
	{
		if (WriteToFile && !string.IsNullOrEmpty(str))
		{
			str = str.Replace("\b", "");
			StreamWriter streamWriter = new StreamWriter("log.txt", append: true);
			streamWriter.Write(str);
			streamWriter.Flush();
			streamWriter.Close();
		}
	}
}
