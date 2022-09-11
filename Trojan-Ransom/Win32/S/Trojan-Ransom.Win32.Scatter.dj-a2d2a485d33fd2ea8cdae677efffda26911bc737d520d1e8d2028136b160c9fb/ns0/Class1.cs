using System;
using System.Windows.Forms;
using Nuke;

namespace ns0;

internal static class Class1
{
	[STAThread]
	private static void Main()
	{
		Class5.smethod_2();
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
