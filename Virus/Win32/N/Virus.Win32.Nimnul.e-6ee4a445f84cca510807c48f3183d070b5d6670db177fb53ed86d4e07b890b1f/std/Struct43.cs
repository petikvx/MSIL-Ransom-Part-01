using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 28)]
[DebugInfoInPDB]
[UnsafeValueType]
[MiscellaneousBits(64)]
[NativeCppClass]
internal struct Struct43
{
	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct43* pStruct43_0, Struct43* pStruct43_1)
	{
		_003CModule_003E.smethod_452(pStruct43_0, pStruct43_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(Struct43* pStruct43_0)
	{
		_003CModule_003E.smethod_462(pStruct43_0, _Built: true, 0u);
	}
}
