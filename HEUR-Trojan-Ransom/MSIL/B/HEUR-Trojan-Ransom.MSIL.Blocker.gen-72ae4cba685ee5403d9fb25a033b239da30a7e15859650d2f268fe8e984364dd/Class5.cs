using System;
using System.Windows.Forms;

internal static class Class5
{
	[STAThread]
	private static void Main()
	{
		//Discarded unreachable code: IL_0027, IL_002e
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			/*Error near IL_0002: ldloc 0 (out-of-bounds)*/;
			/*Error near IL_0004: stloc 3 (out-of-bounds)*/;
			((IntPtr[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/] = (IntPtr)/*Error near IL_0006: Stack underflow*/;
			if (/*Error near IL_000b: Stack underflow*/ != /*Error near IL_000b: Stack underflow*/&& /*Error near IL_0011: Stack underflow*/< /*Error near IL_0011: Stack underflow*/)
			{
				long num = checked((long)/*Error near IL_0012: Stack underflow*/);
				if ((nint)checked((nuint)unchecked((uint)((sbyte[])/*Error near IL_0013: Stack underflow*/)[num])) >= (nint)checked((nuint)(ushort)/*Error near IL_0015: ldloca 0 (out-of-bounds)*/) - (nint)(-1))
				{
					break;
				}
			}
		}
		/*Error near IL_0022: Invalid metadata token*/;
	}

	static extern void smethod_0();

	static void smethod_1(bool bool_0)
	{
		_ = ((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
	}

	static extern void smethod_2(Form form_0);
}
