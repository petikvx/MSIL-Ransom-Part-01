using System;
using System.Runtime.InteropServices;

namespace Crypt_it;

internal static class NativeMethods
{
	[Flags]
	private enum ExecutionState : uint
	{
		EsAwaymodeRequired = 0x40u,
		EsContinuous = 0x80000000u,
		EsDisplayRequired = 2u,
		EsSystemRequired = 1u
	}

	public static void PreventSleep()
	{
		SetThreadExecutionState(ExecutionState.EsContinuous | ExecutionState.EsSystemRequired);
	}

	public static void AllowSleep()
	{
		SetThreadExecutionState(ExecutionState.EsContinuous);
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern ExecutionState SetThreadExecutionState(ExecutionState esFlags);
}
