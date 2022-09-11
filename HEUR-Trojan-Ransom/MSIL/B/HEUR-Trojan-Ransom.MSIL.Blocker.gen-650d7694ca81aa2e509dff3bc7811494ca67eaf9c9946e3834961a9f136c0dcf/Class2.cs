using System;
using System.Windows.Forms;

internal static class Class2
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new MatPlot());
	}
}
