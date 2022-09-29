using System;

internal class ConfusedByAttribute : Attribute
{
	public unsafe ConfusedByAttribute(string string_0)
	{
		//IL_0004: Expected native int or pointer, but got O
		//IL_0008: Invalid comparison between Unknown and I4
		int num;
		do
		{
			((int[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = 6;
			num = *(int*)(nint)(*(object*)(nint)/*Error near IL_0004: Stack underflow*/);
		}
		while ((int)/*Error near IL_000d: Stack underflow*/ <= -num);
		/*Error: Unexpected end of block*/;
	}
}
