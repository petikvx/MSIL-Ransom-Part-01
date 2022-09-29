using System;

internal class ConfusedByAttribute : Attribute
{
	public unsafe ConfusedByAttribute(string string_0)
	{
		//Discarded unreachable code: IL_0009
		//IL_0004: Expected O, but got I8
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		this = (ConfusedByAttribute)((long[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		_ = ((int[])/*Error near IL_0004: ldarg 3 (out-of-bounds)*/)[/*Error near IL_0006: ldloc 0 (out-of-bounds)*/];
		/*Error near IL_0008: Unknown opcode: 0xF8*/;
	}
}
