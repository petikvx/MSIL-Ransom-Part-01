using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ARFT;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		SetProcessDPIAware();
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}

	[DllImport("user32.dll")]
	private static extern bool SetProcessDPIAware();
}
