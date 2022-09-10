using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

[StructLayout(LayoutKind.Sequential, Size = 28)]
[DebugInfoInPDB]
[MiscellaneousBits(64)]
[NativeCppClass]
internal struct cpm
{
	[StructLayout(LayoutKind.Sequential, Size = 8)]
	[NativeCppClass]
	[DebugInfoInPDB]
	[CLSCompliant(false)]
	[MiscellaneousBits(65)]
	public struct a
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 16)]
	[MiscellaneousBits(64)]
	[DebugInfoInPDB]
	[NativeCppClass]
	internal struct b
	{
	}
}
