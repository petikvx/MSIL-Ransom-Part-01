using System;
using System.Threading;
using System.Windows.Forms;
using Coache.Core;

namespace Coache;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.add_ThreadException((ThreadExceptionEventHandler)AppExceptionHandler.Invoke);
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new MainView());
	}
}
