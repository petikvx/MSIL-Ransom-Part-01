using System;
using System.Windows.Forms;

internal static class Class5
{
	[STAThread]
	private static extern void Main();

	unsafe static void smethod_0()
	{
		//Discarded unreachable code: IL_0004, IL_000a, IL_0010, IL_0015, IL_001d
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		_ = *(IntPtr*)(nint)(/*Error near IL_0002: Stack underflow*/ >> (int)/*Error near IL_0002: Stack underflow*/);
		/*Error near IL_0003: Unknown opcode: 0xF8*/;
	}

	static void smethod_1(bool bool_0)
	{
		//Discarded unreachable code: IL_0011, IL_0016, IL_001f, IL_0026
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I8
		//IL_001a: Invalid comparison between Unknown and I4
		_003F val;
		do
		{
			val = checked(/*Error near IL_0002: Stack underflow*/ * 7);
		}
		while (/*Error near IL_0007: Stack underflow*/ > val);
		_ = /*Error near IL_000b: Stack underflow*/<< (int)/*Error near IL_000b: Stack underflow*/;
		_ = 1;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	static extern void smethod_2(Form form_0);
}
