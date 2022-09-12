using System;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp25;

public static class b
{
	[STAThread]
	public static void a()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.SetUnhandledExceptionMode((UnhandledExceptionMode)2);
		Application.add_ThreadException((ThreadExceptionEventHandler)a);
		AppDomain.CurrentDomain.UnhandledException += a;
		Application.Run((Form)(object)new a());
	}

	private static void a(object sender, UnhandledExceptionEventArgs e)
	{
		Environment.Exit(0);
	}

	private static void a(object sender, ThreadExceptionEventArgs e)
	{
		Environment.Exit(0);
	}
}
