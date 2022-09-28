using System;

[AttributeUsage(AttributeTargets.Method)]
public sealed class GAttribute0 : Attribute
{
	public unsafe GAttribute0()
	{
		//Discarded unreachable code: IL_0010, IL_001b, IL_0020, IL_0026, IL_002b, IL_003c
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		//IL_002e: Expected F8, but got I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		_ = *(long*)(~(sbyte)checked((nint)/*Error near IL_0001: Stack underflow*/));
		/*Error near IL_000a: stloc 2 (out-of-bounds)*/;
		/*Error near IL_000b: Invalid metadata token*/;
	}
}
