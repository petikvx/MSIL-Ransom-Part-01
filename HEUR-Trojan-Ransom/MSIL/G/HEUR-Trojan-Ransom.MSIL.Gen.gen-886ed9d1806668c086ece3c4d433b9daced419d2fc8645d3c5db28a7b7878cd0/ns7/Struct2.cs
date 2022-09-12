using System.Runtime.InteropServices;
using ns10;
using ns11;

namespace ns7;

[StructLayout(LayoutKind.Explicit)]
internal struct Struct2
{
	[FieldOffset(0)]
	public Struct6 struct6_0;

	[FieldOffset(16)]
	public Struct5 struct5_0;

	[FieldOffset(32)]
	public Struct5 struct5_1;
}
