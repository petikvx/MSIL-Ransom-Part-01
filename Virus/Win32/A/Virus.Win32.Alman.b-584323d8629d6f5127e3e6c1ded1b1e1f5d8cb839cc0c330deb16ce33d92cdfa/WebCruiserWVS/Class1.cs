using System;
using System.Windows.Forms;

namespace WebCruiserWVS;

internal static class Class1
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new FormMain());
	}
}
