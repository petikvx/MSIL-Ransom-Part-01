using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace Utilities;

internal class GlobalKeyboardHook
{
	public delegate int keyboardHookProc(int code, int wParam, ref keyboardHookStruct lParam);

	public struct keyboardHookStruct
	{
		public int vkCode;

		public int scanCode;

		public int flags;

		public int time;

		public int dwExtraInfo;
	}

	private const int WH_KEYBOARD_LL = 13;

	private const int WM_KEYDOWN = 256;

	private const int WM_KEYUP = 257;

	private const int WM_SYSKEYDOWN = 260;

	private const int WM_SYSKEYUP = 261;

	public List<Keys> HookedKeys = new List<Keys>();

	private IntPtr hhook = IntPtr.Zero;

	public event KeyEventHandler KeyDown
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = this.KeyDown;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.KeyDown, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = this.KeyDown;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.KeyDown, value2, val2);
			}
			while (val != val2);
		}
	}

	public event KeyEventHandler KeyUp
	{
		[CompilerGenerated]
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = this.KeyUp;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.KeyUp, value2, val2);
			}
			while (val != val2);
		}
		[CompilerGenerated]
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			KeyEventHandler val = this.KeyUp;
			KeyEventHandler val2;
			do
			{
				val2 = val;
				KeyEventHandler value2 = (KeyEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.KeyUp, value2, val2);
			}
			while (val != val2);
		}
	}

	public GlobalKeyboardHook()
	{
		hook();
	}

	~GlobalKeyboardHook()
	{
		unhook();
	}

	public void hook()
	{
		IntPtr hInstance = LoadLibrary("User32");
		hhook = SetWindowsHookEx(13, hookProc, hInstance, 0u);
	}

	public void unhook()
	{
		UnhookWindowsHookEx(hhook);
	}

	public int hookProc(int code, int wParam, ref keyboardHookStruct lParam)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		if (code >= 0)
		{
			Keys val = (Keys)lParam.vkCode;
			if (HookedKeys.Contains(val))
			{
				KeyEventArgs val2 = new KeyEventArgs(val);
				if ((wParam == 256 || wParam == 260) && this.KeyDown != null)
				{
					this.KeyDown.Invoke((object)this, val2);
				}
				else if ((wParam == 257 || wParam == 261) && this.KeyUp != null)
				{
					this.KeyUp.Invoke((object)this, val2);
				}
				if (val2.get_Handled())
				{
					return 1;
				}
			}
		}
		return CallNextHookEx(hhook, code, wParam, ref lParam);
	}

	[DllImport("user32.dll")]
	private static extern IntPtr SetWindowsHookEx(int idHook, keyboardHookProc callback, IntPtr hInstance, uint threadId);

	[DllImport("user32.dll")]
	private static extern bool UnhookWindowsHookEx(IntPtr hInstance);

	[DllImport("user32.dll")]
	private static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref keyboardHookStruct lParam);

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string lpFileName);
}
