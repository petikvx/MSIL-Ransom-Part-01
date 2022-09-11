using System;

internal class Attribute3 : Attribute
{
	internal readonly int int_0;

	internal extern Attribute3(int int_1);

	public unsafe override int vmethod_0()
	{
		//IL_0005: Expected native int or pointer, but got O
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		_003F val2;
		do
		{
			int num = *(int*)unchecked((nint)"");
			*(IntPtr*)(nint)/*Error near IL_0007: Stack underflow*/ = (IntPtr)num;
			_003F val = /*Error near IL_0007: ldarg 3 (out-of-bounds)*/;
			val2 = /*Error near IL_0009: Stack underflow*// val;
		}
		while (/*Error near IL_000e: Stack underflow*/ <= val2);
		/*Error near IL_000e: stloc 3 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}
}
