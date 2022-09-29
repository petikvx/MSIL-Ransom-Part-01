using System;
using System.Windows.Forms;

internal static class Class5
{
	[STAThread]
	private static extern void Main();

	static extern void smethod_0();

	unsafe static void smethod_1(bool bool_0)
	{
		//Discarded unreachable code: IL_0013, IL_0018, IL_001d, IL_0022
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (nint)(*unchecked((object*)(nint)/*Error near IL_0001: Stack underflow*/));
			/*Error near IL_0003: stloc 0 (out-of-bounds)*/;
			_ = 8;
			/*Error near IL_0005: ldloc 0 (out-of-bounds)*/;
			_ = -1497985037;
		}
		_ = *(float*)(-1497985037);
		/*Error near IL_0012: Unknown opcode: 0xF8*/;
	}

	static extern void smethod_2(Form form_0);
}
