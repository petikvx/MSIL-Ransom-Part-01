using System;
using System.Windows.Forms;

internal static class Class5
{
	[STAThread]
	private static extern void Main();

	static extern void smethod_0();

	unsafe static void smethod_1(bool bool_0)
	{
		//Discarded unreachable code: IL_0007, IL_0018, IL_001f, IL_002f
		//IL_0009: Expected I4, but got F4
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		_ = *(short*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern void smethod_2(Form form_0);
}
