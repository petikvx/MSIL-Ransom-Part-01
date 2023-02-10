using System;
using System.Windows.Forms;

namespace Ftimbrpvarr;

internal static class e
{
	[STAThread]
	private static void a()
	{
		if (uint.MaxValue != 0)
		{
			Application.EnableVisualStyles();
		}
		if (3u != 0)
		{
			Application.SetCompatibleTextRenderingDefault(false);
		}
		c obj = new c();
		if (7u != 0)
		{
			Application.Run((Form)(object)obj);
		}
	}
}
