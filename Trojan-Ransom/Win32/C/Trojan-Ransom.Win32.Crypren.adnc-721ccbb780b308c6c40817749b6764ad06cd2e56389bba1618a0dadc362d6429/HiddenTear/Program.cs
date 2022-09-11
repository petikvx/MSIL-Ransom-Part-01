using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace HiddenTear;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length <= 1)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new Form1());
		}
	}
}
