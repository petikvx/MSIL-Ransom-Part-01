using System;
using System.Windows.Forms;

namespace ns1;

internal static class Class6
{
	[STAThread]
	private static void Main()
	{
		Class5 @class = new Class5();
		if (@class.method_2())
		{
			Application.EnableVisualStyles();
		}
		Application.SetCompatibleTextRenderingDefault(false);
		if (@class.method_0())
		{
			Application.Run((Form)(object)new GForm0());
		}
	}
}
