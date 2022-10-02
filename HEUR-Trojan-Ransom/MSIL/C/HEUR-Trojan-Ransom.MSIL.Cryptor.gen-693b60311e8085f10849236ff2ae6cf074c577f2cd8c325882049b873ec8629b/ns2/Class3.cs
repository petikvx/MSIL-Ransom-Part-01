using System;
using System.Windows.Forms;

namespace ns2;

internal static class Class3
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new GForm0());
	}
}
