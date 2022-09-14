using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 40)]
[NativeCppClass]
[MiscellaneousBits(64)]
[DebugInfoInPDB]
internal struct ios_base
{
	[CLSCompliant(false)]
	[DebugInfoInPDB]
	[MiscellaneousBits(64)]
	[NativeCppClass]
	public enum @event
	{

	}

	[StructLayout(LayoutKind.Sequential, Size = 40)]
	[MiscellaneousBits(64)]
	[NativeCppClass]
	[UnsafeValueType]
	[DebugInfoInPDB]
	[CLSCompliant(false)]
	public struct failure
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[DebugInfoInPDB]
	[CLSCompliant(false)]
	[NativeCppClass]
	[MiscellaneousBits(64)]
	public struct Init
	{
	}
}
