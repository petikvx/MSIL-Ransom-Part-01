using System;
using System.Windows.Forms;

internal static class Class25
{
	[STAThread]
	private static void Main(string[] args)
	{
		if (!GClass0.smethod_5())
		{
			GClass0.smethod_0();
		}
		Application.EnableVisualStyles();
		Application.Run((Form)(object)new GForm0());
	}
}
