using System;
using System.Windows.Forms;

namespace FC2ServerLauncher;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(true);
		Application.Run((Form)(object)new MainForm());
	}
}
