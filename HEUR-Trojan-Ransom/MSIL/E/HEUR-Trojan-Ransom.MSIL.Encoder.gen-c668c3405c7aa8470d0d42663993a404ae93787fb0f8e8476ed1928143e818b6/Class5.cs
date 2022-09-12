using System;
using System.Windows.Forms;

internal static class Class5
{
	[STAThread]
	private static extern void Main();

	static extern void smethod_0();

	static extern void smethod_1(bool bool_0);

	unsafe static void smethod_2(Form form_0)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0016, IL_001b
		//IL_000d: Expected I8, but got Unknown
		//IL_001e: Expected F8, but got I4
		_ = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}
}
