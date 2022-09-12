using System;
using System.Windows.Forms;
using REDsweeper._0;

namespace REDsweeper;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new WormLocker2());
	}
}
