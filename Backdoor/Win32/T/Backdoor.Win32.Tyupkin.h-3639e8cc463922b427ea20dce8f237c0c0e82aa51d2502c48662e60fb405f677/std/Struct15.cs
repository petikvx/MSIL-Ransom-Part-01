using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 16)]
[MiscellaneousBits(64)]
[DebugInfoInPDB]
[NativeCppClass]
internal struct Struct15
{
	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct15* pStruct15_0, Struct15* pStruct15_1)
	{
		_003CModule_003E.smethod_48(pStruct15_0, pStruct15_1);
	}

	[SpecialName]
	public unsafe static void _003CMarshalDestroy_003E(Struct15* pStruct15_0)
	{
		uint num = *(uint*)((byte*)pStruct15_0 + 4);
		if (num != 0)
		{
			_003CModule_003E.delete((void*)(int)num);
		}
		*(int*)((byte*)pStruct15_0 + 4) = 0;
		*(int*)((byte*)pStruct15_0 + 8) = 0;
		*(int*)((byte*)pStruct15_0 + 12) = 0;
	}
}
