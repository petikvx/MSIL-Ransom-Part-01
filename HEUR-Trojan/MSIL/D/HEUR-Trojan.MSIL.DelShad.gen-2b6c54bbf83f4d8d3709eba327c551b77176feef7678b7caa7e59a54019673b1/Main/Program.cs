using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Main;

public static class Program
{
	[STAThread]
	public static void Main()
	{
		if (Process.GetProcessesByName(Process.GetCurrentProcess().ProcessName).Length <= 1)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new Form1());
		}
	}
}
