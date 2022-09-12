using System.Runtime.InteropServices;
using ns10;
using ns9;

namespace ns5;

[StructLayout(LayoutKind.Explicit)]
internal struct Struct1
{
	[FieldOffset(0)]
	public Struct6 struct6_0;

	[FieldOffset(16)]
	public Struct5 struct5_0;

	[FieldOffset(28)]
	public Struct5 struct5_1;
}
