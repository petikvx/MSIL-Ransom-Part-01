using System;

namespace Loki;

internal class ZZD
{
	[STAThread]
	private unsafe static void ZZE(string[] args)
	{
		//Discarded unreachable code: IL_0007, IL_0012, IL_0017
		_ = *(byte*)(nint)/*Error near IL_0002: Stack underflow*/;
		checked
		{
			_ = (nuint)/*Error near IL_0002: ldloc 2 (out-of-bounds)*/;
			_ = 4;
			/*Error near IL_0006: Unknown opcode: 0xF8*/;
		}
	}

	public extern ZZD();
}
