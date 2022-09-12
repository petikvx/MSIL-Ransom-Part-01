using System;
using System.Windows.Forms;

internal static class Class5
{
	[STAThread]
	private static extern void Main();

	unsafe static void smethod_0()
	{
		//Discarded unreachable code: IL_0008, IL_000e, IL_0013, IL_0019, IL_0022
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Incompatible stack heights: 0 vs 2
		while (true)
		{
			_ = /*Error near IL_0001: Stack underflow*/>> (int)/*Error near IL_0001: Stack underflow*/;
			_ = *(byte*)(nint)/*Error near IL_0001: ldarg 3 (out-of-bounds)*/;
		}
	}

	static extern void smethod_1(bool bool_0);

	static extern void smethod_2(Form form_0);
}
