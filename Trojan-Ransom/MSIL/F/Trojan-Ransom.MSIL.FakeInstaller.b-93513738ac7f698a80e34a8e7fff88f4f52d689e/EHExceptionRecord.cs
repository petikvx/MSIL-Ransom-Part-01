using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

[StructLayout(LayoutKind.Sequential, Size = 32)]
[MiscellaneousBits(65)]
[NativeCppClass]
[DebugInfoInPDB]
internal struct EHExceptionRecord
{
	[StructLayout(LayoutKind.Sequential, Size = 12)]
	[CLSCompliant(false)]
	[MiscellaneousBits(65)]
	[NativeCppClass]
	[DebugInfoInPDB]
	public struct EHParameters
	{
	}
}
