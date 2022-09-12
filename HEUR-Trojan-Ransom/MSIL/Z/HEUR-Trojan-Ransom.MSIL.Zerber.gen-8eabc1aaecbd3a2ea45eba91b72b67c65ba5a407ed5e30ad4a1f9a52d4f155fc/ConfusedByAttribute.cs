using System;

internal class ConfusedByAttribute : Attribute
{
	public unsafe ConfusedByAttribute(string string_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		_ = *(double*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: stloc 3 (out-of-bounds)*/;
		_ = /*Error near IL_0003: Stack underflow*/- /*Error near IL_0003: Stack underflow*/;
		/*Error near IL_0003: ldloc 1 (out-of-bounds)*/;
		/*Error near IL_0004: Invalid metadata token*/;
	}
}
