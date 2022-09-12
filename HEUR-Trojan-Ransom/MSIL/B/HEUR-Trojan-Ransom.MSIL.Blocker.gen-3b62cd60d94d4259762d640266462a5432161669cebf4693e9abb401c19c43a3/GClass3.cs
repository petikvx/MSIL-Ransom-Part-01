using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;

public static class GClass3
{
	private static readonly GClass1 gclass1_0;

	private static Thread thread_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static bool bool_0;

	private static extern bool Boolean_0
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

	private static void smethod_2()
	{
		//Discarded unreachable code: IL_000c, IL_0012, IL_001a, IL_001e
		//IL_0007: Expected I8, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		((long[])(-1))[/*Error near IL_0002: ldloc 0 (out-of-bounds)*/] = (long)/*Error near IL_0004: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_0007: Invalid metadata token*/;
	}

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
}
