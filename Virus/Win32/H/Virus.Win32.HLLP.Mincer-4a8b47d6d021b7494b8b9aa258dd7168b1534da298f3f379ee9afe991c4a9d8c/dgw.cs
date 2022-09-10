using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

[StructLayout(LayoutKind.Sequential, Size = 20)]
[MiscellaneousBits(65)]
[DebugInfoInPDB]
[NativeCppClass]
internal struct dgw
{
	[StructLayout(LayoutKind.Explicit, Size = 4)]
	[UnsafeValueType]
	[NativeCppClass]
	[MiscellaneousBits(66)]
	[DebugInfoInPDB]
	internal struct a
	{
		[StructLayout(LayoutKind.Sequential, Size = 4)]
		[UnsafeValueType]
		[DebugInfoInPDB]
		[CLSCompliant(false)]
		[MiscellaneousBits(65)]
		[NativeCppClass]
		public struct a
		{
		}

		[StructLayout(LayoutKind.Sequential, Size = 1)]
		[CLSCompliant(false)]
		[NativeCppClass]
		[DebugInfoInPDB]
		[UnsafeValueType]
		[MiscellaneousBits(65)]
		public struct b
		{
		}
	}
}
