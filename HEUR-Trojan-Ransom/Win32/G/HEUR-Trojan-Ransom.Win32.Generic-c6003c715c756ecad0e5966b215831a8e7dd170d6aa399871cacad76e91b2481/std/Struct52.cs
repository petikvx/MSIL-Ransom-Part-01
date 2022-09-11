using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 28)]
[NativeCppClass]
[UnsafeValueType]
[DebugInfoInPDB]
[MiscellaneousBits(64)]
internal struct Struct52
{
	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct52* pStruct52_0, Struct52* pStruct52_1)
	{
		_003CModule_003E.smethod_94(pStruct52_0, pStruct52_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(Struct52* pStruct52_0)
	{
		_003CModule_003E.smethod_95(pStruct52_0);
	}
}
