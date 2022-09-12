using System;
using System.Runtime.InteropServices;
using ns49;

namespace ns15;

internal class Class8
{
	[Flags]
	internal enum Enum0
	{

	}

	[Flags]
	internal enum Enum1
	{

	}

	public static int int_0;

	public static int int_1;

	public static object object_0;

	public static IntPtr intptr_0;

	public static long long_0;

	public static object object_1;

	private static object object_2;

	public static void smethod_0(object object_3)
	{
	}

	public static void smethod_1(IntPtr intptr_1)
	{
	}

	public static long smethod_2(object object_3)
	{
		return 0L;
	}

	public static string smethod_3(long long_1, int int_2)
	{
		return null;
	}

	public static T smethod_4<T>(long long_1) where T : struct
	{
		return (T)null;
	}

	public static byte[] smethod_5(long long_1, int int_2)
	{
		return null;
	}

	public static float[] smethod_6<T>(long long_1, int int_2) where T : struct
	{
		return null;
	}

	public static void smethod_7<T>(long long_1, object object_3) where T : struct
	{
	}

	public static void smethod_8(object object_3, long long_1, object object_4)
	{
	}

	public static byte[] smethod_9(object object_3, int int_2 = 0)
	{
		return null;
	}

	public static float[] smethod_10(object object_3)
	{
		return null;
	}

	private static T smethod_11<T>(object object_3) where T : struct
	{
		return (T)null;
	}

	public static IntPtr smethod_12(uint uint_0)
	{
		return (IntPtr)(object)null;
	}

	private static byte[] smethod_13(object object_3)
	{
		return null;
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(int int_2, bool bool_0, int int_3);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr intptr_1, IntPtr intptr_2, uint uint_0, Enum0 enum0_0, Enum1 enum1_0);

	internal static T smethod_14<T>(object object_3)
	{
		return (T)null;
	}

	internal int method_0(string string_0)
	{
		return 0;
	}

	internal void method_1(int int_2)
	{
	}

	static Class8()
	{
		Class25.smethod_22();
		smethod_18();
		Delegate11.smethod_0(Delegate11.delegate11_0);
		Delegate11.smethod_0(Delegate11.delegate11_2);
		int_0 = 0;
		int_1 = 0;
		intptr_0 = IntPtr.Zero;
	}

	internal static bool smethod_15()
	{
		return true;
	}

	internal static Class8 smethod_16()
	{
		return null;
	}

	internal static object smethod_17(object object_3)
	{
		return null;
	}

	internal static void smethod_18()
	{
	}
}
