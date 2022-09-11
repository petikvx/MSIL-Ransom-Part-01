using System;
using System.Diagnostics;

internal class Class8
{
	private static extern void Main(string[] args);

	public extern Class8();

	static extern void smethod_0(ConsoleColor consoleColor_0);

	static extern void smethod_1(string string_0);

	static extern void smethod_2(int int_0);

	static extern void smethod_3();

	unsafe static Process smethod_4(string string_0)
	{
		//IL_000c: Expected I8, but got O
		//IL_000e: Invalid comparison between Unknown and I4
		while (true)
		{
			/*OpCode not supported: Ckfinite*/;
			((long[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (long)/*Error near IL_0004: Stack underflow*/;
			((int[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (int)/*Error near IL_0005: Stack underflow*/;
			if ((int)/*Error near IL_000a: Stack underflow*/ == 0)
			{
				*(long*)(nint)/*Error near IL_000c: Stack underflow*/ = (long)null;
				if ((int)/*Error near IL_0013: Stack underflow*/ > 5)
				{
					break;
				}
			}
		}
		/*Error near IL_0013: stloc 1 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}
}
