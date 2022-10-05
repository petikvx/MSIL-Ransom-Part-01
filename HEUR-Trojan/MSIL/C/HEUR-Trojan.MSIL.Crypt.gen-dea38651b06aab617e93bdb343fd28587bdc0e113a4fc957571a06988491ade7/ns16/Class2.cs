using System;
using System.Windows.Forms;
using ns11;

namespace ns16;

internal static class Class2
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Form1());
	}
}
