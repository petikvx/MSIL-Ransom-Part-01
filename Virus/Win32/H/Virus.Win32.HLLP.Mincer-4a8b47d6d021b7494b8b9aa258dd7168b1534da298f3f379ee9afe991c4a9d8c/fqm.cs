using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

[StructLayout(LayoutKind.Sequential, Size = 60)]
[DebugInfoInPDB]
[NativeCppClass]
[MiscellaneousBits(64)]
internal struct fqm
{
	[StructLayout(LayoutKind.Sequential, Size = 4)]
	[NativeCppClass]
	[DebugInfoInPDB]
	[CLSCompliant(false)]
	[MiscellaneousBits(64)]
	public struct a
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 8)]
	[DebugInfoInPDB]
	[CLSCompliant(false)]
	[NativeCppClass]
	[MiscellaneousBits(64)]
	public struct b
	{
	}
}
