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
		get
		{
			//Discarded unreachable code: IL_0010
			_003F val;
			do
			{
				val = /*Error: Stack underflow*/;
			}
			while (/*Error near IL_0006: Stack underflow*/ > val);
			_003F val2 = /*Error near IL_0006: ldloca 0 (out-of-bounds)*/;
			uint num = ((uint[])/*Error near IL_0009: Stack underflow*/)[val2];
			_ = ((uint[])/*Error near IL_000a: Stack underflow*/)[num];
			/*Error near IL_000b: Invalid metadata token*/;
		}
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_0008
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			long num = *(long*)(nint)/*Error near IL_0001: Stack underflow*/;
			_003F val = checked(/*Error near IL_0002: Stack underflow*/ + num);
			_ = /*Error near IL_0003: Stack underflow*// val;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	public static extern void smethod_0();

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static extern void smethod_1();

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

	static GClass0()
	{
		//Discarded unreachable code: IL_0005, IL_000b
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_5(Thread thread_1);

	static extern void smethod_6(Thread thread_1);

	unsafe static Thread smethod_7(ThreadStart threadStart_0)
	{
		//Discarded unreachable code: IL_0019, IL_001f, IL_002b, IL_0031, IL_0047
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected I, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
		//IL_0026: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Incompatible stack heights: 0 vs 1
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			((double[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (double)/*Error near IL_0002: Stack underflow*/;
			*(_003F*)(nint)/*Error near IL_0003: Stack underflow*/ = /*Error near IL_0003: Stack underflow*/;
			byte num = ((byte[])/*Error near IL_0004: Stack underflow*/)[/*Error near IL_0004: Stack underflow*/];
			*(short*)(nint)/*Error near IL_0005: Stack underflow*/ = num;
			int num2 = checked((int)/*Error near IL_0006: Stack underflow*/);
			_003F val = /*Error near IL_0007: Stack underflow*/+ num2;
			((IntPtr[])/*Error near IL_0008: Stack underflow*/)[/*Error near IL_0008: Stack underflow*/] = (IntPtr)val;
		}
		while (/*Error near IL_0009: Stack underflow*/ % /*Error near IL_0009: Stack underflow*/>= /*Error near IL_0009: ldarg 3 (out-of-bounds)*/|| /*Error near IL_0014: Stack underflow*/>= /*Error near IL_0014: Stack underflow*/);
		/*Error near IL_0014: Invalid metadata token*/;
	}

	unsafe static Type smethod_8(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		//Discarded unreachable code: IL_000b, IL_0010, IL_0018, IL_001d, IL_0022
		//IL_0001: Invalid comparison between Unknown and F4
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			float num = *(float*)(nint)/*Error near IL_0001: Stack underflow*/;
			if ((float)/*Error near IL_0006: Stack underflow*/ > num)
			{
			}
		}
	}

	static int smethod_9(Type type_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw /*Error near IL_0001: Stack underflow*/& /*Error near IL_0001: Stack underflow*/;
	}

	static extern void smethod_10(int int_0);

	static extern bool smethod_11(string string_0, string string_1, StringComparison stringComparison_0);
}
