using System;
using System.Windows.Forms;

internal static class Class5
{
	[STAThread]
	private static extern void Main();

	static void smethod_0()
	{
		//Discarded unreachable code: IL_000a, IL_000c, IL_0011, IL_001b, IL_0021, IL_0026, IL_002b, IL_0033
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected I4, but got Unknown
		byte num;
		checked
		{
			num = (byte)unchecked((long)checked((ulong)/*Error near IL_0002: Stack underflow*/));
		}
		_ = (long)((float[])/*Error near IL_0004: Stack underflow*/)[num];
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern void smethod_1(bool bool_0);

	static extern void smethod_2(Form form_0);
}
