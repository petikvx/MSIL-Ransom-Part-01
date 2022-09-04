using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

internal static class Class0
{
	[STAThread]
	private static void Main()
	{
		Thread.CurrentThread.CurrentCulture = new CultureInfo(1033);
		Thread.CurrentThread.CurrentUICulture = new CultureInfo(1033);
		Application.Run((Form)(object)new fHookKey());
	}
}
