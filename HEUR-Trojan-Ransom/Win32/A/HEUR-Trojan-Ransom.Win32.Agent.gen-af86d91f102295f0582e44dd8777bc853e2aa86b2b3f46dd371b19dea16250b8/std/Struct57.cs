using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 28)]
[MiscellaneousBits(64)]
[UnsafeValueType]
[DebugInfoInPDB]
[NativeCppClass]
internal struct Struct57
{
	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct57* pStruct57_0, Struct57* pStruct57_1)
	{
		_003CModule_003E.smethod_49(pStruct57_0, pStruct57_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(Struct57* pStruct57_0)
	{
		_003CModule_003E.smethod_81(pStruct57_0, _Built: true, 0u);
	}
}
