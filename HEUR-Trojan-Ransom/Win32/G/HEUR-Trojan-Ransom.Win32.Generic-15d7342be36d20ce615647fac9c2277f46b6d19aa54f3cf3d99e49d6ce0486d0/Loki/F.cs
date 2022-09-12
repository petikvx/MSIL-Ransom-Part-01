using System.Collections.Generic;

namespace Loki;

internal class F
{
	public static extern IEnumerable<string> G(string string_0);

	public static void H(string string_0)
	{
		checked
		{
			_ = (nint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	public static void I(string string_0)
	{
		//IL_0005: Expected I4, but got O
		ulong num = checked((ulong)(float)/*Error near IL_0002: Stack underflow*/);
		object obj = ((object[])/*Error near IL_0004: Stack underflow*/)[num];
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)(int)obj;
		/*Error: Unexpected end of block*/;
	}

	public static extern void J(string string_0);

	public static extern void K(string string_0);

	public static extern void L(string string_0);

	public extern F();
}
