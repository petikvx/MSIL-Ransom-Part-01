using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

namespace std;

[StructLayout(LayoutKind.Sequential, Size = 56)]
[DebugInfoInPDB]
[MiscellaneousBits(64)]
[NativeCppClass]
internal struct Struct5
{
	[StructLayout(LayoutKind.Sequential, Size = 4)]
	[DebugInfoInPDB]
	[NativeCppClass]
	[MiscellaneousBits(64)]
	[CLSCompliant(false)]
	public struct _Sentry_base
	{
	}

	[StructLayout(LayoutKind.Sequential, Size = 8)]
	[DebugInfoInPDB]
	[CLSCompliant(false)]
	[MiscellaneousBits(64)]
	[NativeCppClass]
	public struct sentry
	{
	}
}
