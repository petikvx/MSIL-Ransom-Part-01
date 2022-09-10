using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 4)]
[MiscellaneousBits(64)]
[NativeCppClass]
[DebugInfoInPDB]
internal struct locale
{
	[StructLayout(LayoutKind.Sequential, Size = 4)]
	[NativeCppClass]
	[CLSCompliant(false)]
	[DebugInfoInPDB]
	[MiscellaneousBits(64)]
	public struct id
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 52)]
	[MiscellaneousBits(64)]
	[NativeCppClass]
	[CLSCompliant(false)]
	[UnsafeValueType]
	[DebugInfoInPDB]
	public struct _Locimp
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 8)]
	[NativeCppClass]
	[MiscellaneousBits(64)]
	[DebugInfoInPDB]
	[CLSCompliant(false)]
	public struct facet
	{
	}
}
