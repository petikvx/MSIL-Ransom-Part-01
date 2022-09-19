using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
internal struct Struct0
{
	[FieldOffset(0)]
	public Struct4 struct4_0;

	[FieldOffset(22)]
	public short short_0;

	public Struct3 method_0()
	{
		Struct3 result = default(Struct3);
		result.struct4_0 = struct4_0;
		result.short_0 = short_0;
		result.int_0 = Environment.TickCount;
		return result;
	}
}
