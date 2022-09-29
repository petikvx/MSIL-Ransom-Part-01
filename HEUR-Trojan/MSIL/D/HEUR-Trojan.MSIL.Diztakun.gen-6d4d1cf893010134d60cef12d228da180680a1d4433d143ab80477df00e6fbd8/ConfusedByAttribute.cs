using System;

internal class ConfusedByAttribute : Attribute
{
	public unsafe ConfusedByAttribute(string string_0)
	{
		//Discarded unreachable code: IL_000b, IL_001c
		sbyte num = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*OpCode not supported: DebugBreak*/;
		((short[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (short)(-num);
		_ = (ulong)/*Error near IL_0006: Stack underflow*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}
}
