using System;
using System.Windows.Forms;

internal static class Class5
{
	[STAThread]
	private static extern void Main();

	static void smethod_0()
	{
		//Discarded unreachable code: IL_0007, IL_0017, IL_001c, IL_0021, IL_002c, IL_0032, IL_0039, IL_003f
		//IL_0012: Expected I, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Invalid comparison between Unknown and I
		_ = ((byte[])/*Error near IL_0002: Stack underflow*/)[4];
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern void smethod_1(bool bool_0);

	static extern void smethod_2(Form form_0);
}
