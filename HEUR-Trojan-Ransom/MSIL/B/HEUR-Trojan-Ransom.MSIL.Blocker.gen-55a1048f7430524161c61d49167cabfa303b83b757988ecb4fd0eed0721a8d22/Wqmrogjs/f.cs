using System;
using System.Windows.Forms;

namespace Wqmrogjs;

internal static class f
{
	[STAThread]
	private static void a()
	{
		if (8u != 0)
		{
			Application.EnableVisualStyles();
		}
		if (4u != 0)
		{
			Application.SetCompatibleTextRenderingDefault(false);
		}
		a obj = new a();
		if (3u != 0)
		{
			Application.Run((Form)(object)obj);
		}
	}
}
