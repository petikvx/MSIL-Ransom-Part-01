using System;
using System.Windows.Forms;

namespace Esulsglfyznb;

internal static class f
{
	[STAThread]
	private static void a()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new b());
	}
}
