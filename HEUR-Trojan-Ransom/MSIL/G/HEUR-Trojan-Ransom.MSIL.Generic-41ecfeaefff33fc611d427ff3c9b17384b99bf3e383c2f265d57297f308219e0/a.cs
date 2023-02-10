using System;
using System.Windows.Forms;
using altappa;

internal static class a
{
	[STAThread]
	private static void a()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
