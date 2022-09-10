using System;
using System.IO;

namespace Stealerium.Helpers;

internal sealed class Logging
{
	private static readonly string Logfile = Path.Combine(Path.GetTempPath(), "Stealerium-Latest.log");

	public static bool Log(string text, bool ret = true)
	{
		string text2 = "\n";
		if (text.Length > 40 && text.Contains("\n"))
		{
			text2 += "\n\n";
		}
		Console.Write(text + text2);
		if (Config.DebugMode == "1")
		{
			File.AppendAllText(Logfile, text + text2);
		}
		return ret;
	}

	public static void Save(string sSavePath)
	{
		if (!(Config.DebugMode != "1") && File.Exists(Logfile))
		{
			try
			{
				File.Copy(Logfile, sSavePath);
			}
			catch
			{
			}
		}
	}
}
