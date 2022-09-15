using System;
using System.Threading;
using System.Windows.Forms;

namespace PubnubApi.WinFormExample;

internal static class Program
{
	private static string appGuid = "12as2345-12ab-sw12sff2-b9d9-d32123456";

	[STAThread]
	private static void Main()
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + appGuid);
		if (mutex.WaitOne(0, exitContext: false))
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			new PubnubDemoForm();
			Application.Run();
		}
	}
}
