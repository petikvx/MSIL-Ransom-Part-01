using System;
using System.Windows.Forms;
using Polyhook;

namespace ns0;

internal static class Class3
{
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run((Form)(object)new Start());
	}
}
