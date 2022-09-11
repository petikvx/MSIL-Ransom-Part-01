using System.Runtime.InteropServices;

namespace ns0;

[StructLayout(LayoutKind.Explicit, Pack = 8)]
internal struct Struct0
{
	[FieldOffset(0)]
	public int int_0;

	[FieldOffset(4)]
	public uint uint_0;

	[FieldOffset(8)]
	public int int_1;

	[FieldOffset(12)]
	public int int_2;

	[FieldOffset(16)]
	public uint uint_1;

	[FieldOffset(20)]
	public int int_3;

	[FieldOffset(24)]
	public int int_4;
}
