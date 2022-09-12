using System.Collections.Generic;

public class GClass11
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

	public unsafe GClass11()
	{
		_ = (short)/*Error near IL_0001: Stack underflow*/;
		checked
		{
			_ = (byte)(*unchecked((nint*)(sbyte)/*Error near IL_0001: ldloca 0 (out-of-bounds)*/));
			_ = 2;
			/*Error: Unexpected end of block*/;
		}
	}

	public override string ToString()
	{
		//Discarded unreachable code: IL_0005, IL_000a
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}
}
