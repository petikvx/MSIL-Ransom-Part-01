using System;
using System.Runtime.InteropServices;

namespace Loki.IO.Monitors.WinApi;

public class ZZZZZZZk
{
	[Flags]
	public enum ZZZZZZZm : uint
	{
		SMTO_NORMAL = 0u,
		SMTO_BLOCK = 1u,
		SMTO_ABORTIFHUNG = 2u,
		SMTO_NOTIMEOUTIFNOTHUNG = 8u,
		SMTO_ERRORONEXIT = 0x20u
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr SendMessageTimeout(IntPtr intptr_0, uint uint_0, UIntPtr uintptr_0, IntPtr intptr_1, ZZZZZZZm zzzzzzzm_0, uint uint_1, out UIntPtr uintptr_1);

	public extern ZZZZZZZk();
}
