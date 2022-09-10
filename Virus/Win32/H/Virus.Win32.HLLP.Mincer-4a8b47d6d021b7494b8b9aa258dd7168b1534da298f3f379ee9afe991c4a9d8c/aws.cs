using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

[StructLayout(LayoutKind.Sequential, Size = 16)]
[DebugInfoInPDB]
[NativeCppClass]
[MiscellaneousBits(65)]
internal struct aws
{
	[StructLayout(LayoutKind.Explicit, Size = 2)]
	[DebugInfoInPDB]
	[MiscellaneousBits(66)]
	[NativeCppClass]
	internal struct a
	{
		[StructLayout(LayoutKind.Sequential, Size = 2)]
		[MiscellaneousBits(65)]
		[DebugInfoInPDB]
		[NativeCppClass]
		internal struct a
		{
		}
	}

	[StructLayout(LayoutKind.Explicit, Size = 8)]
	[MiscellaneousBits(66)]
	[DebugInfoInPDB]
	[NativeCppClass]
	internal struct b
	{
		[StructLayout(LayoutKind.Sequential, Size = 8)]
		[DebugInfoInPDB]
		[MiscellaneousBits(65)]
		[NativeCppClass]
		internal struct a
		{
		}
	}
}
