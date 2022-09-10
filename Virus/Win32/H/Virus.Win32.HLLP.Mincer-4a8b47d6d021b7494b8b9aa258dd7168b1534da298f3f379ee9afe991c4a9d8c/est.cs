using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualC;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[DebugInfoInPDB]
[NativeCppClass]
[MiscellaneousBits(64)]
internal struct est
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[DebugInfoInPDB]
	[CLSCompliant(false)]
	[NativeCppClass]
	[MiscellaneousBits(65)]
	public struct a
	{
	}

	[SpecialName]
	public unsafe static void a(est* pEst_0, est* pEst_1)
	{
		_003CModule_003E.a(pEst_0, pEst_1);
	}
}
