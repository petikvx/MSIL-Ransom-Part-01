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
		//Discarded unreachable code: IL_001a
		//IL_000a: Expected I, but got F4
		//IL_000d: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected I8, but got Unknown
		do
		{
			object obj = ((object[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
			*(IntPtr*)5 = (IntPtr)1.4448442E+20f;
			uint num = ((uint[])/*Error near IL_000b: Stack underflow*/)[obj];
			_003F val = /*Error near IL_000b: ldloc 2 (out-of-bounds)*/;
			((object[])/*Error near IL_000d: Stack underflow*/)[num] = (object)val;
		}
		while (/*Error near IL_0012: Stack underflow*/ > /*Error near IL_0012: Stack underflow*/);
		_003F val2 = /*Error near IL_0013: Stack underflow*/- /*Error near IL_0013: Stack underflow*/;
		((long[])/*Error near IL_0014: Stack underflow*/)[/*Error near IL_0014: Stack underflow*/] = (long)val2;
		_ = *(byte*)(nint)/*Error near IL_0015: Stack underflow*/;
		/*Error near IL_0015: Invalid metadata token*/;
	}
}
