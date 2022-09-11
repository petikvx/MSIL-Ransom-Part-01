using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class KeyboardFilter
{
	private struct KBDLLHOOKSTRUCT
	{
		public Keys key;

		public int scanCode;

		public int flags;

		public int time;

		public IntPtr extra;
	}

	private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

	private Keys[] mFilter;

	private IntPtr mHook;

	private LowLevelKeyboardProc mProc;

	public KeyboardFilter(Keys[] keysToFilter)
	{
		mFilter = keysToFilter;
		ProcessModule mainModule = Process.GetCurrentProcess().MainModule;
		mProc = KeyboardProc;
		mHook = SetWindowsHookEx(13, mProc, GetModuleHandle(mainModule.ModuleName), 0u);
		if (mHook == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error(), "Failed to set hook");
		}
	}

	public void Dispose()
	{
		if (mHook != IntPtr.Zero)
		{
			UnhookWindowsHookEx(mHook);
			mHook = IntPtr.Zero;
		}
	}

	private IntPtr KeyboardProc(int nCode, IntPtr wp, IntPtr lp)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		if (nCode >= 0)
		{
			KBDLLHOOKSTRUCT kBDLLHOOKSTRUCT = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lp, typeof(KBDLLHOOKSTRUCT));
			Keys[] array = mFilter;
			foreach (Keys val in array)
			{
				if ((Keys)(val & 0xFFFF) == kBDLLHOOKSTRUCT.key && CheckModifier(val))
				{
					return (IntPtr)1;
				}
			}
		}
		return CallNextHookEx(mHook, nCode, wp, lp);
	}

	private bool CheckModifier(Keys key)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Invalid comparison between Unknown and I4
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		if ((key & 0x20000) == 131072 && GetAsyncKeyState((Keys)162) == 0 && GetAsyncKeyState((Keys)163) == 0)
		{
			return false;
		}
		if ((key & 0x10000) == 65536 && GetAsyncKeyState((Keys)160) == 0 && GetAsyncKeyState((Keys)161) == 0)
		{
			return false;
		}
		if ((key & 0x40000) == 262144 && GetAsyncKeyState((Keys)164) == 0 && GetAsyncKeyState((Keys)165) == 0)
		{
			return false;
		}
		return true;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int id, LowLevelKeyboardProc callback, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool UnhookWindowsHookEx(IntPtr hook);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr hook, int nCode, IntPtr wp, IntPtr lp);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string name);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern short GetAsyncKeyState(Keys key);
}
