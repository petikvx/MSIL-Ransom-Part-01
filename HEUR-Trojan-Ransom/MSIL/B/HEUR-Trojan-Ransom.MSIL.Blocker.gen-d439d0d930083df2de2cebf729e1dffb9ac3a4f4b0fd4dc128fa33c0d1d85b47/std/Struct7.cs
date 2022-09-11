using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 28)]
[MiscellaneousBits(64)]
[DebugInfoInPDB]
[NativeCppClass]
[UnsafeValueType]
internal struct Struct7
{
	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct7* pStruct7_0, Struct7* pStruct7_1)
	{
		_003CModule_003E.smethod_75(pStruct7_0, pStruct7_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(Struct7* pStruct7_0)
	{
		_003CModule_003E.smethod_76(pStruct7_0);
	}
}
