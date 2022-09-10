using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

[StructLayout(LayoutKind.Sequential, Size = 128)]
[MiscellaneousBits(64)]
[NativeCppClass]
[DebugInfoInPDB]
internal struct chm
{
	[StructLayout(LayoutKind.Sequential, Size = 4)]
	[DebugInfoInPDB]
	[NativeCppClass]
	[MiscellaneousBits(64)]
	[CLSCompliant(false)]
	public struct a
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 4)]
	[NativeCppClass]
	[CLSCompliant(false)]
	[DebugInfoInPDB]
	[MiscellaneousBits(64)]
	public struct b
	{
	}
}
