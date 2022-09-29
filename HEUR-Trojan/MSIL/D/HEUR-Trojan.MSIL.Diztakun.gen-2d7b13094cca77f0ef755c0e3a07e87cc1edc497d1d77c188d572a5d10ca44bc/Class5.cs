using System;
using System.Windows.Forms;

internal static class Class5
{
	[STAThread]
	private static extern void Main();

	static void smethod_0()
	{
		_ = (nuint)/*Error near IL_0001: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_1(bool bool_0);

	static extern void smethod_2(Form form_0);
}
