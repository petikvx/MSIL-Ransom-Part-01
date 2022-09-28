using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;

public static class GClass0
{
	private static Thread thread_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static bool bool_0;

	public unsafe static bool Boolean_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_0007, IL_0008, IL_0018, IL_001e, IL_0029, IL_0033
			//IL_0019: Invalid comparison between Unknown and I
			//IL_0021: Expected I, but got O
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Expected I4, but got F4
			//IL_0036: Invalid comparison between Unknown and I
			_ = *(byte*)8;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public static extern void smethod_0();

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static void smethod_1()
	{
		//Discarded unreachable code: IL_000d, IL_0013, IL_001a, IL_001f
		//IL_000e: Invalid comparison between Unknown and I
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0021: Invalid comparison between Unknown and O
		_ = checked((nuint)/*Error near IL_0003: Stack underflow*/) % (nuint)(int)(byte)/*Error near IL_0003: ldloca 0 (out-of-bounds)*/;
		/*Error near IL_0007: stloc 3 (out-of-bounds)*/;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	private static extern void smethod_2();

	private static extern bool smethod_3(string string_0, string string_1);

	private static extern void smethod_4(uint uint_0);

	[DllImport("kernel32.dll")]
	private static extern IntPtr CreateToolhelp32Snapshot(uint uint_0, uint uint_1);

	[DllImport("kernel32.dll")]
	private static extern bool Process32First(IntPtr intptr_0, ref GStruct0 gstruct0_0);

	[DllImport("kernel32.dll")]
	private static extern bool Process32Next(IntPtr intptr_0, ref GStruct0 gstruct0_0);

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(uint uint_0, bool bool_1, uint uint_1);

	[DllImport("kernel32.dll")]
	private static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	private static extern bool TerminateProcess(IntPtr intptr_0, int int_0);

	static extern void smethod_5(Thread thread_1);

	static extern void smethod_6(Thread thread_1);

	static extern Thread smethod_7(ThreadStart threadStart_0);

	static extern Type smethod_8(RuntimeTypeHandle runtimeTypeHandle_0);

	static extern int smethod_9(Type type_0);

	static extern void smethod_10(int int_0);

	static extern bool smethod_11(string string_0, string string_1, StringComparison stringComparison_0);
}
