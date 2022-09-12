using System;
using System.Runtime.InteropServices;
using ns49;

namespace ns43;

internal class Class22
{
	internal static object object_0;

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern bool SetWindowPos(IntPtr intptr_0, IntPtr intptr_1, int int_0, int int_1, int int_2, int int_3, int int_4);

	static Class22()
	{
		Class25.smethod_22();
		smethod_2();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Class22 smethod_1()
	{
		return null;
	}

	internal static void smethod_2()
	{
	}
}
