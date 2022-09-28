using System;
using System.Windows.Forms;

internal static class Class5
{
	[STAThread]
	private unsafe static void Main()
	{
		//Discarded unreachable code: IL_0018, IL_001f
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I
		while (true)
		{
			_ = *(int*)(nint)checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0003: stloc 3 (out-of-bounds)*/;
			if (/*Error near IL_0009: Stack underflow*/ > /*Error near IL_0009: Stack underflow*/)
			{
				nuint num = checked((nuint)(/*Error near IL_000a: Stack underflow*/ - /*Error near IL_000a: Stack underflow*/));
				if ((nint)/*Error near IL_0010: Stack underflow*/ >= (nint)num)
				{
					break;
				}
			}
		}
		checked
		{
			_ = (nint)unchecked((int)checked((byte)(*unchecked((float*)(nint)/*Error near IL_0011: Stack underflow*/))));
			/*Error near IL_0013: Invalid metadata token*/;
		}
	}

	static extern void smethod_0();

	static extern void smethod_1(bool bool_0);

	static void smethod_2(Form form_0)
	{
		throw /*Error near IL_0001: Stack underflow*/;
	}
}
