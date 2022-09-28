using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;

public static class GClass5
{
	private struct Struct6
	{
		public int int_0;

		public readonly int int_1;

		public readonly IntPtr intptr_0;

		public readonly Struct7 struct7_0;
	}

	private struct Struct7
	{
		public readonly int int_0;

		public readonly int int_1;
	}

	private const int int_0 = 1;

	private static Thread thread_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static bool bool_0;

	public static bool Boolean_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
		}
	}

	[DllImport("user32.dll")]
	private static extern bool GetCursorInfo(out Struct6 struct6_0);

	[DllImport("user32.dll")]
	private static extern bool DrawIcon(IntPtr intptr_0, int int_1, int int_2, IntPtr intptr_1);

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public unsafe static void smethod_0()
	{
		//Discarded unreachable code: IL_0019, IL_0021, IL_0027, IL_0028, IL_002f
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got I4
		sbyte num = *(sbyte*)checked((nint)(*unchecked((short*)(nint)/*Error: ldloc 1 (out-of-bounds)*/)));
		_ = /*Error near IL_0005: Stack underflow*/>> (int)num;
		checked
		{
			_ = (uint)/*Error near IL_0005: ldloc 3 (out-of-bounds)*/;
			_ = -649816983216656725L;
			/*Error near IL_0014: Invalid metadata token*/;
		}
	}

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static extern void smethod_1();

	[AsyncStateMachine(typeof(Class7))]
	[DebuggerStepThrough]
	private static extern void smethod_2();

	private static Bitmap smethod_3()
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_0013, IL_0018, IL_0028, IL_002f
		//IL_0020: Expected I4, but got Unknown
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_4(Thread thread_1);

	static extern void smethod_5(Thread thread_1);

	static extern Thread smethod_6(ThreadStart threadStart_0);

	static extern Screen smethod_7();

	static extern Rectangle smethod_8(Screen screen_0);
}
