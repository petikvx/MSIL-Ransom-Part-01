using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace ns3;

internal class Class10
{
	private delegate int Delegate0(int nCode, int wParam, IntPtr lParam);

	private struct Struct0
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public IntPtr intptr_0;
	}

	private static Delegate0 delegate0_0;

	private static int int_0;

	private const int int_1 = 13;

	private const int int_2 = 9;

	private const int int_3 = 27;

	private const int int_4 = 46;

	private const int int_5 = 115;

	private const int int_6 = 91;

	private const int int_7 = 92;

	private static int smethod_0(int nCode, int wParam, IntPtr lParam)
	{
		if (nCode < 0)
		{
			return CallNextHookEx(int_0, nCode, (IntPtr)wParam, lParam);
		}
		object? obj = Marshal.PtrToStructure(lParam, typeof(Struct0));
		Struct0 @struct = default(Struct0);
		Struct0 struct2 = ((obj != null) ? ((Struct0)obj) : @struct);
		if ((struct2.int_0 == 9) & ((Computer)Class1.Computer).get_Keyboard().get_AltKeyDown())
		{
			return 1;
		}
		if ((struct2.int_0 == 27) & ((Computer)Class1.Computer).get_Keyboard().get_CtrlKeyDown())
		{
			return 1;
		}
		if ((struct2.int_0 == 91) | (struct2.int_0 == 92))
		{
			return 1;
		}
		if ((struct2.int_0 == 46) & ((Computer)Class1.Computer).get_Keyboard().get_CtrlKeyDown() & ((Computer)Class1.Computer).get_Keyboard().get_AltKeyDown())
		{
			return 1;
		}
		if ((struct2.int_0 == 115) & ((Computer)Class1.Computer).get_Keyboard().get_AltKeyDown())
		{
			return 1;
		}
		return CallNextHookEx(int_0, nCode, (IntPtr)wParam, lParam);
	}

	public static void smethod_1()
	{
		if (int_0 == 0)
		{
			delegate0_0 = smethod_0;
			int_0 = SetWindowsHookEx(13, delegate0_0, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
			if (int_0 != 0)
			{
			}
		}
	}

	public static void smethod_2()
	{
		UnhookWindowsHookEx(int_0);
	}

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern int CallNextHookEx(int idHook, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int SetWindowsHookEx(int idHook, Delegate0 HookProc, IntPtr hInstance, int wParam);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int UnhookWindowsHookEx(int idHook);
}
