using System;
using System.Windows.Forms;

namespace _2048_eXtendido;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new frmMain());
	}
}
