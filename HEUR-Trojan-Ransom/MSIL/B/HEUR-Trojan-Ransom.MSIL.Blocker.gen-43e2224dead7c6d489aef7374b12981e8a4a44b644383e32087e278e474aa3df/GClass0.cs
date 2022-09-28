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

	public static bool Boolean_0
	{
		[CompilerGenerated]
		get
		{
			while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/)
			{
			}
			throw /*Error near IL_0007: Stack underflow*/;
		}
		[CompilerGenerated]
		set;
	}

	public unsafe static void smethod_0()
	{
		//Discarded unreachable code: IL_0017, IL_0020, IL_0026, IL_002a
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Invalid comparison between Unknown and I4
		_ = *(uint*)(nint)checked(/*Error near IL_0002: Stack underflow*/ - /*Error near IL_0002: Stack underflow*/);
		_ = -5.634686714987542E-249 * checked((ushort)/*Error near IL_000c: ldarga 0 (out-of-bounds)*/);
		/*Error near IL_0012: Invalid metadata token*/;
	}

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static extern void smethod_1();

	private static extern void smethod_2();

	private static extern bool smethod_3(string string_0, string string_1);

	private static void smethod_4(uint uint_0)
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0017, IL_0019, IL_001e
		//IL_0000: Unsupported input type for neg.
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected F8, but got Unknown
		//IL_0012: Expected O, but got I4
		//IL_0012: Invalid comparison between Unknown and I
		_003F val = 0 - /*Error near IL_0001: Stack underflow*/;
		_003F val2 = /*Error near IL_0003: Stack underflow*/| (ulong)val;
		((double[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/] = (double)val2;
		/*Error near IL_0004: Unknown opcode: 0xF8*/;
	}

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

	static Type smethod_8(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		//Discarded unreachable code: IL_0006
		_ = (uint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static int smethod_9(Type type_0)
	{
		//Discarded unreachable code: IL_001b, IL_0024, IL_0029
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I8
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			nuint num = (nuint)/*Error near IL_0001: Stack underflow*/;
			val = /*Error near IL_0003: Stack underflow*/% num;
		}
		while ((long)/*Error near IL_0009: Stack underflow*/ > (long)(ulong)val);
		uint num3;
		checked
		{
			nint num2 = (nint)/*Error near IL_000a: Stack underflow*/;
			/*OpCode not supported: DebugBreak*/;
			num3 = (uint)(/*Error near IL_000e: Stack underflow*/ + num2);
		}
		_ = ((float[])(/*Error near IL_0011: Stack underflow*/ >> (int)num3))[/*Error near IL_0011: ldloca 0 (out-of-bounds)*/];
		/*Error near IL_0014: ldloca 0 (out-of-bounds)*/;
		/*Error near IL_0016: Invalid metadata token*/;
	}

	static extern void smethod_10(int int_0);

	static extern bool smethod_11(string string_0, string string_1, StringComparison stringComparison_0);
}
