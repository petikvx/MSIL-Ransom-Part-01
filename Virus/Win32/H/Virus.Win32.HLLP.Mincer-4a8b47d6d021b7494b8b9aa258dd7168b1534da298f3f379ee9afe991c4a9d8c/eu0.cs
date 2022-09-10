using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

[StructLayout(LayoutKind.Sequential, Size = 4)]
[NativeCppClass]
[DebugInfoInPDB]
[MiscellaneousBits(65)]
internal struct eu0
{
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	[DebugInfoInPDB]
	[MiscellaneousBits(66)]
	[CLSCompliant(false)]
	[NativeCppClass]
	public struct a
	{
		[StructLayout(LayoutKind.Sequential, Size = 4)]
		[NativeCppClass]
		[CLSCompliant(false)]
		[MiscellaneousBits(65)]
		[DebugInfoInPDB]
		public struct a
		{
		}

		[StructLayout(LayoutKind.Sequential, Size = 4)]
		[NativeCppClass]
		[MiscellaneousBits(65)]
		[CLSCompliant(false)]
		[DebugInfoInPDB]
		public struct b
		{
		}
	}
}
