using System;
using System.Windows.Forms;

namespace Kvpbvpfa;

internal static class k
{
	[STAThread]
	private static void a()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new i());
	}
}
