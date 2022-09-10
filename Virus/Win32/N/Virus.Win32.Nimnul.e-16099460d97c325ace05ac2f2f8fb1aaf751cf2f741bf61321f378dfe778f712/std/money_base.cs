using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 8)]
[MiscellaneousBits(65)]
[DebugInfoInPDB]
[NativeCppClass]
internal struct money_base
{
	[StructLayout(LayoutKind.Sequential, Size = 4)]
	[DebugInfoInPDB]
	[MiscellaneousBits(65)]
	[UnsafeValueType]
	[CLSCompliant(false)]
	[NativeCppClass]
	public struct pattern
	{
	}
}
