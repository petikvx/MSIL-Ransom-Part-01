using System;
using System.Diagnostics;
using System.Windows.Forms;
using ns1;

namespace ns0;

internal static class Class1
{
	[STAThread]
	private static void Main()
	{
		if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length > 1)
		{
			Application.Exit();
			return;
		}
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
