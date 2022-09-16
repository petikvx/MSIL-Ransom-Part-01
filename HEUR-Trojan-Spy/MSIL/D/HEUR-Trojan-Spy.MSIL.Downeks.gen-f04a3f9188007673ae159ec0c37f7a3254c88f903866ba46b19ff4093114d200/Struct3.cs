using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
internal struct Struct3
{
	[FieldOffset(0)]
	public Struct4 struct4_0;

	[FieldOffset(10)]
	public short short_0;

	[FieldOffset(16)]
	public int int_0;
}
