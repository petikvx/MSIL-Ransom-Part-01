using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 56)]
[NativeCppClass]
[DebugInfoInPDB]
[MiscellaneousBits(64)]
internal struct Struct8
{
	[StructLayout(LayoutKind.Sequential, Size = 4)]
	[NativeCppClass]
	[DebugInfoInPDB]
	[CLSCompliant(false)]
	[MiscellaneousBits(64)]
	public struct _Sentry_base
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 8)]
	[MiscellaneousBits(64)]
	[NativeCppClass]
	[CLSCompliant(false)]
	[DebugInfoInPDB]
	public struct sentry
	{
	}
}
