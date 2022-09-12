using System.Runtime.InteropServices;
using ns49;

namespace ns42;

internal class Class21
{
	internal struct Struct15
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;
	}

	private delegate int Delegate0(int Code, int wParam, ref Struct15 lParam);

	private object object_0;

	private static object object_1;

	[DllImport("user32")]
	private static extern int UnhookWindowsHookEx(int int_0);

	[DllImport("user32")]
	private static extern int SetWindowsHookExA(int int_0, Delegate0 delegate0_0, int int_1, int int_2);

	[DllImport("user32")]
	private static extern int CallNextHookEx(int int_0, int int_1, int int_2, Struct15 struct15_0);

	public void method_0()
	{
	}

	public int method_1(int int_0, int int_1, ref Struct15 struct15_0)
	{
		return 0;
	}

	static Class21()
	{
		Class25.smethod_22();
		smethod_2();
	}

	internal static bool smethod_0()
	{
		return true;
	}

	internal static Class21 smethod_1()
	{
		return null;
	}

	internal static void smethod_2()
	{
	}
}
