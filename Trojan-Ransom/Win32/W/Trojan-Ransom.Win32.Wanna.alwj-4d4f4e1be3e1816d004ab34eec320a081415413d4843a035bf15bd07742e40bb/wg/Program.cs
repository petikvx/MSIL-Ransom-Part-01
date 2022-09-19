using System;
using System.Windows.Forms;

namespace wg;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		PS.RedirectOutput = false;
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new MainForm());
	}
}
