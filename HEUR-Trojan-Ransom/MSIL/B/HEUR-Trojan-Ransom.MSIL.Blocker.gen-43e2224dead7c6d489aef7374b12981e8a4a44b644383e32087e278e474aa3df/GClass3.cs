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

	private static bool Boolean_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_0003, IL_000e, IL_0016, IL_001d
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unsupported input type for neg.
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			_ = (uint)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Unknown opcode: 0xFB*/;
		}
	}

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static extern void smethod_0();

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static void smethod_1()
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		uint num = checked((uint)/*Error near IL_0001: ldarga 0 (out-of-bounds)*/);
		_003F val = /*Error near IL_0005: Stack underflow*/% num;
		_ = ((long[])/*Error near IL_0006: Stack underflow*/)[val];
		/*Error: Unexpected end of block*/;
	}

	private static extern void smethod_2();

	static extern void smethod_3(Thread thread_1);

	static extern void smethod_4(Thread thread_1);

	static extern Thread smethod_5(ThreadStart threadStart_0);
}
