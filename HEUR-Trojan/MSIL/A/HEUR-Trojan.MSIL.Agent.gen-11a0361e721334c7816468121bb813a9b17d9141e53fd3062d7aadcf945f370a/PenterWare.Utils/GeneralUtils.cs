using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace PenterWare.Utils;

internal class GeneralUtils
{
	private static string timeFormat = "dd-MM-yyyy HH:mm:ss";

	public static double ConvertBytesToMegabytes(long bytes)
	{
		return (float)bytes / 1024f / 1024f;
	}

	public static string Base64Encode(string plainText)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(plainText));
	}

	public static string Base64Decode(string base64EncodedData)
	{
		byte[] bytes = Convert.FromBase64String(base64EncodedData);
		return Encoding.UTF8.GetString(bytes);
	}

	public static void Log(string message)
	{
		if (ResourceData.Verbose)
		{
			WriteToDebugLogFile(message);
		}
	}

	public static void WriteToDebugLogFile(string message)
	{
		string value = DateTime.Now.ToString(timeFormat) + " " + message;
		string path = "C:\\ProgramData\\PenterWare.txt";
		try
		{
			using StreamWriter streamWriter = new StreamWriter(path, append: true);
			streamWriter.WriteLine(value);
		}
		catch
		{
			Console.WriteLine("Could not write to log");
		}
	}

	public static void SelfDestruct()
	{
		Log("Self destructing...");
		string empty = string.Empty;
		string text = Assembly.GetExecutingAssembly().CodeBase!.Replace("file:///", string.Empty).Replace("/", "\\");
		empty += "@ECHO OFF\n";
		empty += "ping 127.0.0.1 > nul\n";
		empty += "echo j | del /F ";
		empty = empty + text + "\n";
		empty += "echo j | del deleteMyProgram.bat";
		File.WriteAllText("deleteMyProgram.bat", empty);
		Process process = new Process();
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo.FileName = "deleteMyProgram.bat";
		process.Start();
	}
}
