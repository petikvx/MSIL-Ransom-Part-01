using System;
using System.Runtime.InteropServices;

namespace jDlAujUelC;

internal static class oawtWZlRLJH
{
	[Flags]
	private enum fuHABUgvdkoRtbD : uint
	{
		pMscLqAixVQUi = 0x40u,
		gWJQsuicanIT = 0x80000000u,
		mllenRcBLBpL = 2u,
		vOslmnujEmSoTSV = 1u
	}

	public static void SnPGvXQHWhVWJO()
	{
		SetThreadExecutionState(fuHABUgvdkoRtbD.gWJQsuicanIT | fuHABUgvdkoRtbD.vOslmnujEmSoTSV);
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern fuHABUgvdkoRtbD SetThreadExecutionState(fuHABUgvdkoRtbD fuHABUgvdkoRtbD_0);
}
