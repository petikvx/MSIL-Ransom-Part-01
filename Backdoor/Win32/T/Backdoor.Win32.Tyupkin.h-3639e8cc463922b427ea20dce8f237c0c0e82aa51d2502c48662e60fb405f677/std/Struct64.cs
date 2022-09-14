using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[MiscellaneousBits(64)]
[DebugInfoInPDB]
[NativeCppClass]
internal struct Struct64
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[CLSCompliant(false)]
	[NativeCppClass]
	[MiscellaneousBits(65)]
	[DebugInfoInPDB]
	public struct Struct65
	{
	}

	[SpecialName]
	public unsafe static void _003CMarshalCopy_003E(Struct64* pStruct64_0, Struct64* pStruct64_1)
	{
	}
}
