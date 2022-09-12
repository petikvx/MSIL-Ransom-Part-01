using System;
using System.Windows.Forms;

internal static class Class5
{
	[STAThread]
	private static extern void Main();

	unsafe static void smethod_0()
	{
		//Discarded unreachable code: IL_0002, IL_0004, IL_000b, IL_0012, IL_0018, IL_001d, IL_0022, IL_0028
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xFC*/;
	}

	static void smethod_1(bool bool_0)
	{
		//Discarded unreachable code: IL_000e, IL_0014
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0001: Stack underflow*/ % /*Error near IL_0001: Stack underflow*/<= /*Error near IL_0001: ldloca 0 (out-of-bounds)*/)
			{
			}
		}
	}

	static extern void smethod_2(Form form_0);
}
