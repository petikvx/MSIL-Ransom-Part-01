using System;
using System.Windows.Forms;

internal static class Class5
{
	[STAThread]
	private static extern void Main();

	static extern void smethod_0();

	static extern void smethod_1(bool bool_0);

	static void smethod_2(Form form_0)
	{
		/*Error: ldloc 2 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}
}
