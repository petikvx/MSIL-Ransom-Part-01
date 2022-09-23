using System.Collections.Generic;

public class GClass17
{
	private enum Enum0
	{
		const_0,
		const_1,
		const_2,
		const_3
	}

	private const int int_0 = 8;

	private const int int_1 = 24;

	private const uint uint_0 = 3u;

	private readonly int int_2;

	private readonly List<uint> list_0;

	public GClass17()
	{
		//Discarded unreachable code: IL_000e
		while ((int)/*Error near IL_0005: Stack underflow*/ == 0)
		{
		}
		checked
		{
			_ = (ushort)unchecked((int)((byte[])/*Error near IL_0006: Stack underflow*/)[/*Error near IL_0006: Stack underflow*/]);
			/*Error near IL_000a: ldloca 0 (out-of-bounds)*/;
			/*Error near IL_000d: Unknown opcode: 0xF9*/;
		}
	}

	public override extern string ToString();
}
