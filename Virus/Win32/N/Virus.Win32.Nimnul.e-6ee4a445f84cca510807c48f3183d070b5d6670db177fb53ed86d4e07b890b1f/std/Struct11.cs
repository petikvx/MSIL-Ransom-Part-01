using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 28)]
[DebugInfoInPDB]
[UnsafeValueType]
[NativeCppClass]
[MiscellaneousBits(64)]
internal struct Struct11
{
	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct11* pStruct11_0, Struct11* pStruct11_1)
	{
		_003CModule_003E.smethod_81(pStruct11_0, pStruct11_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(Struct11* pStruct11_0)
	{
		_003CModule_003E.smethod_96(pStruct11_0, _Built: true, 0u);
	}
}
