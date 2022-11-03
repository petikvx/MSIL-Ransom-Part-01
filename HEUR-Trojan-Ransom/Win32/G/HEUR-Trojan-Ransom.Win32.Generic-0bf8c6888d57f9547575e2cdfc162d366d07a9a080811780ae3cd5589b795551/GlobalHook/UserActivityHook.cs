using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace GlobalHook;

public class UserActivityHook
{
	private delegate int HookProc(int nCode, int wParam, IntPtr lParam);

	private int _hMouseHook;

	private int _hKeyboardHook;

	private static HookProc MouseHookProcedure;

	private static HookProc KeyboardHookProcedure;

	private const int WH_MOUSE_LL = 14;

	private const int WH_KEYBOARD_LL = 13;

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, int dwThreadId);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int idHook);

	public void Start_key()
	{
		KeyboardHookProcedure = KeyboardHookProc;
		_hKeyboardHook = SetWindowsHookEx(13, KeyboardHookProcedure, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
	}

	public void Start_mouse()
	{
		MouseHookProcedure = MouseHookProc;
		_hMouseHook = SetWindowsHookEx(14, MouseHookProcedure, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
	}

	public void Stop_key()
	{
		Stop_key(uninstallKeyboardHook: true, throwExceptions: true);
	}

	public void Stop_mouse()
	{
		Stop_mouse(uninstallMouseHook: true, throwExceptions: true);
	}

	public void Stop_mouse(bool uninstallMouseHook, bool throwExceptions)
	{
		UnhookWindowsHookEx(_hMouseHook);
		_hMouseHook = 0;
	}

	public void Stop_key(bool uninstallKeyboardHook, bool throwExceptions)
	{
		UnhookWindowsHookEx(_hKeyboardHook);
		_hKeyboardHook = 0;
	}

	private int MouseHookProc(int nCode, int wParam, IntPtr lParam)
	{
		return -1;
	}

	private int KeyboardHookProc(int nCode, int wParam, IntPtr lParam)
	{
		return -1;
	}
}
