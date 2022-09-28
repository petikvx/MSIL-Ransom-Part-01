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

	private static bool Boolean_0
	{
		[CompilerGenerated]
		get
		{
			_ = ((Array)/*Error near IL_0001: Stack underflow*/).LongLength;
			/*Error: Unexpected end of block*/;
		}
		[CompilerGenerated]
		set;
	}

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public unsafe static void smethod_0()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			sbyte num = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
			_003F val = /*Error near IL_0002: Stack underflow*/<< (int)num;
			if (/*Error near IL_0007: Stack underflow*/ <= val)
			{
				/*Error: Could not find block for branch target IL_0007*/;
			}
		}
	}

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static void smethod_1()
	{
		//Discarded unreachable code: IL_000d, IL_0013, IL_0019, IL_0021
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_001c: Expected I4, but got I8
		//IL_0021: Unsupported input type for neg.
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		uint num;
		do
		{
			num = ((uint[])/*Error near IL_0003: Stack underflow*/)[-1];
		}
		while ((int)/*Error near IL_0008: Stack underflow*/ > (int)num);
		/*Error near IL_0008: Invalid metadata token*/;
	}

	private static void smethod_2()
	{
		//Discarded unreachable code: IL_0014
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		while ((int)(~/*Error near IL_0001: ldarg 2 (out-of-bounds)*/) == 0)
		{
		}
		_ = /*Error near IL_000b: Stack underflow*// /*Error near IL_000b: Stack underflow*/;
		/*Error near IL_000b: stloc 0 (out-of-bounds)*/;
		/*Error near IL_000f: Invalid metadata token*/;
	}

	static extern void smethod_3(Thread thread_1);

	static extern void smethod_4(Thread thread_1);

	static extern Thread smethod_5(ThreadStart threadStart_0);
}
