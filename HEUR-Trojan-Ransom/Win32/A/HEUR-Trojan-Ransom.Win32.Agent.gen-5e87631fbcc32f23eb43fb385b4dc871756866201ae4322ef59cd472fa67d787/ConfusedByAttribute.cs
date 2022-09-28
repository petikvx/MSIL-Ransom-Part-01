using System;

internal class ConfusedByAttribute : Attribute
{
	public ConfusedByAttribute(string string_0)
	{
		nuint num = (nuint)/*Error near IL_0001: Stack underflow*/;
		float num2 = ((float[])/*Error near IL_0002: Stack underflow*/)[num];
		((double[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = num2;
		checked
		{
			_ = (uint)/*Error near IL_0004: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}
	}
}
