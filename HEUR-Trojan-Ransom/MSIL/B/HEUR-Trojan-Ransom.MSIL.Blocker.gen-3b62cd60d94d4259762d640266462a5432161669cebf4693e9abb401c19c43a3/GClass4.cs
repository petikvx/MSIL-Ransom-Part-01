using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading;

public static class GClass4
{
	private static Thread thread_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static bool bool_0;

	public static extern bool Boolean_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static extern void smethod_0();

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static extern void smethod_1();

	public static extern void smethod_2();

	static extern void smethod_3(Thread thread_1);

	static extern void smethod_4(Thread thread_1);

	unsafe static Thread smethod_5(ThreadStart threadStart_0)
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

	static extern PerformanceCounter smethod_6(string string_0, string string_1, string string_2);

	static extern PerformanceCounter smethod_7(string string_0, string string_1);

	static extern float smethod_8(PerformanceCounter performanceCounter_0);

	static extern string smethod_9(object[] object_0);

	unsafe static Encoding smethod_10()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I
		while (true)
		{
			_003F val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
			long num = ((long[])/*Error near IL_0002: Stack underflow*/)[val];
			((long[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/] = num;
			if (checked((uint)/*Error near IL_0004: Stack underflow*/) != 0)
			{
				IntPtr intPtr = *(IntPtr*)(nint)/*Error near IL_000b: Stack underflow*/;
				if ((nint)/*Error near IL_0010: Stack underflow*/ <= (nint)intPtr)
				{
					/*Error: Could not find block for branch target IL_0010*/;
				}
			}
		}
	}

	static byte[] smethod_11(Encoding encoding_0, string string_0)
	{
		//Discarded unreachable code: IL_0006, IL_0014, IL_001a
		//IL_0006: Unsupported input type for neg.
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldloc 3 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_12(int int_0);
}
