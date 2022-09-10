using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[NativeCppClass]
[MiscellaneousBits(64)]
[DebugInfoInPDB]
internal struct c1a
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[MiscellaneousBits(65)]
	[NativeCppClass]
	[CLSCompliant(false)]
	[DebugInfoInPDB]
	public struct b
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[NativeCppClass]
	[MiscellaneousBits(65)]
	[DebugInfoInPDB]
	[CLSCompliant(false)]
	public struct a
	{
	}

	[SpecialName]
	public unsafe static void a(c1a* pC1a_0, c1a* pC1a_1)
	{
	}
}
