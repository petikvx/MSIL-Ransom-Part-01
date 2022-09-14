using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class10
{
	private static Thread thread_0;

	private static string string_0;

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr FindWindow(string string_1, string string_2);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr GetWindow(IntPtr intptr_0, uint uint_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool IsWindowVisible(IntPtr intptr_0);

	public static extern void smethod_0(string string_1);

	public static void smethod_1()
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0010, IL_001b, IL_0026, IL_002c, IL_0034
		//IL_0016: Invalid comparison between Unknown and I4
		/*Error: Invalid metadata token*/;
	}

	private static extern void smethod_2();

	private static void smethod_3()
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0012, IL_0022, IL_002b, IL_0034, IL_0039
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got I
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0001: Stack underflow*/& /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_4();

	static extern Thread smethod_5(ThreadStart threadStart_0, int int_0);

	static extern void smethod_6(Thread thread_1);

	static extern void smethod_7(Exception exception_0);

	static Exception smethod_8(int int_0)
	{
		//Discarded unreachable code: IL_0005, IL_0010
		//IL_000a: Expected I4, but got I8
		while (true)
		{
		}
	}

	static extern object smethod_9(string string_1, string string_2);

	static extern object smethod_10(object object_0);

	static extern object smethod_11(object object_0, Type type_0, string string_1, object[] object_1, string[] string_2, Type[] type_1, bool[] bool_0, bool bool_1);

	static extern Type smethod_12(RuntimeTypeHandle runtimeTypeHandle_0);

	static extern object smethod_13(object object_0, Type type_0);

	static extern int smethod_14(string string_1, AppWinStyle appWinStyle_0, bool bool_0, int int_0);

	static extern Process[] smethod_15();

	static string smethod_16(Process process_0)
	{
		while (true)
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ == 0)
			{
				/*Error: Could not find block for branch target IL_0005*/;
			}
		}
	}

	static extern bool smethod_17(string string_1, string string_2);

	static void smethod_18(Process process_0)
	{
		//Discarded unreachable code: IL_000c, IL_0016
		//IL_0002: Invalid comparison between Unknown and I
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got I4
		nuint num;
		do
		{
			num = checked((nuint)/*Error near IL_0001: Stack underflow*/);
		}
		while ((nint)/*Error near IL_0007: Stack underflow*/ < (nint)num);
		/*Error near IL_0007: Invalid metadata token*/;
	}
}
