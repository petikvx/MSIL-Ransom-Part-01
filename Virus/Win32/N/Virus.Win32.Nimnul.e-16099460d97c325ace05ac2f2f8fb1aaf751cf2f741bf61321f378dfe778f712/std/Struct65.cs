using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 28)]
[NativeCppClass]
[MiscellaneousBits(64)]
[UnsafeValueType]
[DebugInfoInPDB]
internal struct Struct65
{
	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct65* pStruct65_0, Struct65* pStruct65_1)
	{
		_003CModule_003E.smethod_809(pStruct65_0, pStruct65_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(Struct65* pStruct65_0)
	{
		_003CModule_003E.smethod_897(pStruct65_0, _Built: true, 0u);
	}
}
