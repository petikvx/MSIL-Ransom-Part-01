using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 28)]
[MiscellaneousBits(64)]
[DebugInfoInPDB]
[NativeCppClass]
[UnsafeValueType]
internal struct Struct74
{
	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct74* pStruct74_0, Struct74* pStruct74_1)
	{
		_003CModule_003E.smethod_854(pStruct74_0, pStruct74_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(Struct74* pStruct74_0)
	{
		_003CModule_003E.smethod_917(pStruct74_0, _Built: true, 0u);
	}
}
