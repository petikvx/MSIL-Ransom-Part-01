using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 28)]
[MiscellaneousBits(64)]
[NativeCppClass]
[UnsafeValueType]
[DebugInfoInPDB]
internal struct Struct12
{
	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct12* pStruct12_0, Struct12* pStruct12_1)
	{
		_003CModule_003E.smethod_85(pStruct12_0, pStruct12_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(Struct12* pStruct12_0)
	{
		_003CModule_003E.smethod_113(pStruct12_0, _Built: true, 0u);
	}
}
