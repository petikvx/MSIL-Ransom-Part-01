using System;
using System.Runtime.InteropServices;

namespace SNDBgbsWAO;

internal static class TkJloPYvHU
{
	[Flags]
	private enum TpYjZpRySUdc : uint
	{
		sIyxdeMRuRG = 0x40u,
		vZocGhwPTiZ = 0x80000000u,
		lEyrIugisJwXEjpv = 2u,
		avTePnodRK = 1u
	}

	public static void xQEEzxUjRRuu()
	{
		SetThreadExecutionState(TpYjZpRySUdc.vZocGhwPTiZ | TpYjZpRySUdc.avTePnodRK);
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern TpYjZpRySUdc SetThreadExecutionState(TpYjZpRySUdc tpYjZpRySUdc_0);
}
