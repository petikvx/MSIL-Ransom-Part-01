using System;
using System.Windows.Forms;

namespace a;

internal static class B
{
	[STAThread]
	private static void A()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new a());
	}
}
