using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 40)]
[MiscellaneousBits(64)]
[NativeCppClass]
[DebugInfoInPDB]
internal struct ios_base
{
	[MiscellaneousBits(64)]
	[NativeCppClass]
	[CLSCompliant(false)]
	[DebugInfoInPDB]
	public enum @event
	{

	}

	[StructLayout(LayoutKind.Sequential, Size = 40)]
	[CLSCompliant(false)]
	[UnsafeValueType]
	[DebugInfoInPDB]
	[NativeCppClass]
	[MiscellaneousBits(64)]
	public struct failure
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[NativeCppClass]
	[MiscellaneousBits(64)]
	[DebugInfoInPDB]
	[CLSCompliant(false)]
	public struct Init
	{
	}
}
