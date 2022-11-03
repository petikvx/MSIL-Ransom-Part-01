using System;
using System.IO;
using System.Windows.Forms;

namespace ranmPOC;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
		File.Delete(Application.get_ExecutablePath());
	}
}
