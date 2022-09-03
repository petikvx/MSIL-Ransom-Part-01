using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JavaCPL;

public static class GClass0
{
	private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

	private enum MouseMessages
	{
		WM_LBUTTONDOWN = 513,
		WM_LBUTTONUP = 514,
		WM_MOUSEMOVE = 512,
		WM_MOUSEWHEEL = 522,
		WM_RBUTTONDOWN = 516,
		WM_RBUTTONUP = 517
	}

	private struct POINT
	{
		public int x;

		public int y;
	}

	private struct MSLLHOOKSTRUCT
	{
		public POINT pt;

		public uint mouseData;

		public uint flags;

		public uint time;

		public IntPtr dwExtraInfo;
	}

	private const int int_0 = 14;

	private static LowLevelMouseProc lowLevelMouseProc_0 = smethod_3;

	private static IntPtr intptr_0 = IntPtr.Zero;

	public static bool bool_0 = false;

	private static bool bool_1 = false;

	public static void smethod_0()
	{
		bool flag = false;
		while (flag)
		{
			flag = false;
		}
		try
		{
			if (!bool_1)
			{
				bool_1 = true;
				intptr_0 = smethod_2(lowLevelMouseProc_0);
				Application.Run();
			}
		}
		catch (Exception)
		{
			flag = true;
		}
	}

	public static void smethod_1()
	{
		try
		{
			bool_1 = false;
			UnhookWindowsHookEx(intptr_0);
			Application.Exit();
		}
		catch (Exception)
		{
		}
	}

	private static IntPtr smethod_2(LowLevelMouseProc lowLevelMouseProc_1)
	{
		bool flag = false;
		while (flag)
		{
			flag = false;
		}
		try
		{
			using Process process = Process.GetCurrentProcess();
			using ProcessModule processModule = process.MainModule;
			return SetWindowsHookEx(14, lowLevelMouseProc_1, GetModuleHandle(processModule.ModuleName), 0u);
		}
		catch (Exception)
		{
			flag = true;
			using Process process2 = Process.GetCurrentProcess();
			using ProcessModule processModule2 = process2.MainModule;
			return SetWindowsHookEx(14, lowLevelMouseProc_1, GetModuleHandle(processModule2.ModuleName), 0u);
		}
	}

	private static IntPtr smethod_3(int int_1, IntPtr intptr_1, IntPtr intptr_2)
	{
		bool flag = false;
		while (flag)
		{
			flag = false;
		}
		try
		{
			if (int_1 >= 0 && 513 == (int)intptr_1)
			{
				MSLLHOOKSTRUCT mSLLHOOKSTRUCT = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(intptr_2, typeof(MSLLHOOKSTRUCT));
				if (!bool_0 && GClass4.smethod_7())
				{
					GClass1.smethod_0(mSLLHOOKSTRUCT.pt.x, mSLLHOOKSTRUCT.pt.y);
				}
			}
		}
		catch (Exception)
		{
			flag = true;
		}
		return CallNextHookEx(intptr_0, int_1, intptr_1, intptr_2);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr SetWindowsHookEx(int int_1, LowLevelMouseProc lowLevelMouseProc_1, IntPtr intptr_1, uint uint_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool UnhookWindowsHookEx(IntPtr intptr_1);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr CallNextHookEx(IntPtr intptr_1, int int_1, IntPtr intptr_2, IntPtr intptr_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string string_0);
}
