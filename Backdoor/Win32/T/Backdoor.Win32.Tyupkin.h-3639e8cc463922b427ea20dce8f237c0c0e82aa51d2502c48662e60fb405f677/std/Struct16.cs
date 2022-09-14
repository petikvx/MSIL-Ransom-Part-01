using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 16)]
[MiscellaneousBits(64)]
[NativeCppClass]
[DebugInfoInPDB]
internal struct Struct16
{
	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct16* pStruct16_0, Struct16* pStruct16_1)
	{
		_003CModule_003E.smethod_59(pStruct16_0, pStruct16_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(Struct16* pStruct16_0)
	{
		uint num = *(uint*)((byte*)pStruct16_0 + 4);
		if (num != 0)
		{
			_003CModule_003E.delete((void*)(int)num);
		}
		*(int*)((byte*)pStruct16_0 + 4) = 0;
		*(int*)((byte*)pStruct16_0 + 8) = 0;
		*(int*)((byte*)pStruct16_0 + 12) = 0;
	}
}
