using System;
using System.Runtime.InteropServices;
using ns34;
using ns49;

namespace ns33;

internal class Class20
{
	internal struct Struct12
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;
	}

	private static object object_0;

	public static int smethod_0(IntPtr intptr_0)
	{
		return 0;
	}

	[DllImport("user32.dll")]
	private static extern int SetWindowCompositionAttribute(IntPtr intptr_0, ref Struct13 struct13_0);

	public static int smethod_1(IntPtr intptr_0, Struct12 struct12_0)
	{
		return 0;
	}

	[DllImport("DwmApi.dll")]
	private static extern int DwmExtendFrameIntoClientArea(IntPtr intptr_0, ref Struct12 struct12_0);

	static Class20()
	{
		Class25.smethod_22();
		smethod_4();
	}

	internal static bool smethod_2()
	{
		return true;
	}

	internal static Class20 smethod_3()
	{
		return null;
	}

	internal static void smethod_4()
	{
	}
}
