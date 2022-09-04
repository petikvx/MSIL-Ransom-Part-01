using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

internal static class Class0
{
	[STAThread]
	private static void Main()
	{
		Thread.CurrentThread.CurrentCulture = new CultureInfo("us");
		Thread.CurrentThread.CurrentUICulture = new CultureInfo("us");
		Application.Run((Form)(object)new fHookKey());
	}
}
