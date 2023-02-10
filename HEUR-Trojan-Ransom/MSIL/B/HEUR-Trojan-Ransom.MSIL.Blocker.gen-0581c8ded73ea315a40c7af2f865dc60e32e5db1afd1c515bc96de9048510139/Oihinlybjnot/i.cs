using System;
using System.Windows.Forms;

namespace Oihinlybjnot;

internal static class i
{
	[STAThread]
	private static void a()
	{
		if (true)
		{
			Application.EnableVisualStyles();
		}
		if (uint.MaxValue != 0)
		{
			Application.SetCompatibleTextRenderingDefault(false);
		}
		g obj = new g();
		if (true)
		{
			Application.Run((Form)(object)obj);
		}
	}
}
