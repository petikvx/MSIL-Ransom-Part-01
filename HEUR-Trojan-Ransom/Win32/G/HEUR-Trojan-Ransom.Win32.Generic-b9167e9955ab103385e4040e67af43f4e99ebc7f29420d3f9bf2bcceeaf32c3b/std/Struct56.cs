using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 28)]
[UnsafeValueType]
[DebugInfoInPDB]
[MiscellaneousBits(64)]
[NativeCppClass]
internal struct Struct56
{
	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct56* pStruct56_0, Struct56* pStruct56_1)
	{
		_003CModule_003E.smethod_93(pStruct56_0, pStruct56_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(Struct56* pStruct56_0)
	{
		_003CModule_003E.smethod_94(pStruct56_0);
	}
}
