using System;
using System.Windows.Forms;

namespace RansomeWare;

internal static class SelectionContext
{
	[STAThread]
	private static void CloneProcess()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
