using System;
using System.Runtime.InteropServices;

namespace tmhhYTpfSQZiU;

public static class fNiFwRgRZTE
{
	private enum xghDAGHQkoHDbPX
	{
		dfzORYwxdYTr = 1,
		LUzucYjiSKApKZ = 1,
		BSbWxYoNvghR = 4
	}

	[DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
	private static extern uint SHEmptyRecycleBin(IntPtr intptr_0, string string_0, xghDAGHQkoHDbPX xghDAGHQkoHDbPX_0);

	public static void OStiLsXAjLpUW()
	{
		try
		{
			SHEmptyRecycleBin(IntPtr.Zero, null, (xghDAGHQkoHDbPX)5);
		}
		catch
		{
		}
	}
}
