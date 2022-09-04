using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace ns1;

internal class Class9
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

	private static int smethod_0(int int_1, int int_2, IntPtr intptr_0)
	{
		if (int_1 < 0)
		{
			return CallNextHookEx(int_0, int_1, (IntPtr)int_2, intptr_0);
		}
		object? obj = Marshal.PtrToStructure(intptr_0, typeof(Struct0));
		Struct0 @struct = default(Struct0);
		Struct0 struct2 = ((obj != null) ? ((Struct0)obj) : @struct);
		if ((struct2.int_0 == 9) & ((Computer)Class1.smethod_0()).get_Keyboard().get_AltKeyDown())
		{
			return 1;
		}
		if ((struct2.int_0 == 27) & ((Computer)Class1.smethod_0()).get_Keyboard().get_CtrlKeyDown())
		{
			return 1;
		}
		if ((struct2.int_0 == 91) | (struct2.int_0 == 92))
		{
			return 1;
		}
		if ((struct2.int_0 == 46) & ((Computer)Class1.smethod_0()).get_Keyboard().get_CtrlKeyDown() & ((Computer)Class1.smethod_0()).get_Keyboard().get_AltKeyDown())
		{
			return 1;
		}
		if ((struct2.int_0 == 115) & ((Computer)Class1.smethod_0()).get_Keyboard().get_AltKeyDown())
		{
			return 1;
		}
		return CallNextHookEx(int_0, int_1, (IntPtr)int_2, intptr_0);
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

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern int CallNextHookEx(int int_1, int int_2, IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int SetWindowsHookEx(int int_1, Delegate0 delegate0_1, IntPtr intptr_0, int int_2);
}
