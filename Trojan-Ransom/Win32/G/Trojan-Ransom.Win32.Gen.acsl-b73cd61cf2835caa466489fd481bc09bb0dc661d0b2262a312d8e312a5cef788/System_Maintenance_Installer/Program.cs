using System;
using System.Windows.Forms;

namespace System_Maintenance_Installer;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Install());
	}
}
