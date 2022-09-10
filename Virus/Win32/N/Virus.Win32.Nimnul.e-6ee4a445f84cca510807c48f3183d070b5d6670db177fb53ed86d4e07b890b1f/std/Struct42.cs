using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 28)]
[UnsafeValueType]
[DebugInfoInPDB]
[NativeCppClass]
[MiscellaneousBits(64)]
internal struct Struct42
{
	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct42* pStruct42_0, Struct42* pStruct42_1)
	{
		_003CModule_003E.smethod_451(pStruct42_0, pStruct42_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(Struct42* pStruct42_0)
	{
		_003CModule_003E.smethod_456(pStruct42_0, _Built: true, 0u);
	}
}
