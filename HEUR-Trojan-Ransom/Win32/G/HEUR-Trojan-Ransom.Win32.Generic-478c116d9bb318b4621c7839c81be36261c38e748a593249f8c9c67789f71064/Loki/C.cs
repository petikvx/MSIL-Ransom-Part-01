using System;
using System.Collections.Generic;

namespace Loki;

internal class C
{
	public static extern IEnumerable<string> D(string string_0);

	public static extern void E(string string_0);

	public static extern void F(string string_0);

	public static extern void G(string string_0);

	public unsafe static void H(string string_0)
	{
		//Discarded unreachable code: IL_0019, IL_0020
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			_ = 0;
		}
		while ((short)(*(long*)1) > 0 || (int)/*Error near IL_0012: Stack underflow*/ != 5);
		_003F val = /*Error near IL_0012: ldloc 0 (out-of-bounds)*/;
		checked
		{
			_ = (nint)unchecked((nuint)(nint)((IntPtr[])/*Error near IL_0014: Stack underflow*/)[val]);
			/*Error near IL_0018: Unknown opcode: 0xF8*/;
		}
	}

	public static extern void I(string string_0);

	public extern C();
}
