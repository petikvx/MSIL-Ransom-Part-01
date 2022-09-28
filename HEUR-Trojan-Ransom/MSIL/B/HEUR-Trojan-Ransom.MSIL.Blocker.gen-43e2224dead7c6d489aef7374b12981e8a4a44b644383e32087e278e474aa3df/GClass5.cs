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

	public static extern bool Boolean_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[DllImport("user32.dll")]
	private static extern bool GetCursorInfo(out Struct6 struct6_0);

	[DllImport("user32.dll")]
	private static extern bool DrawIcon(IntPtr intptr_0, int int_1, int int_2, IntPtr intptr_1);

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static extern void smethod_0();

	[SecurityPermission(SecurityAction.Demand, ControlThread = true)]
	public static void smethod_1()
	{
		checked
		{
			_ = (int)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	[AsyncStateMachine(/*Could not decode attribute arguments.*/)]
	[DebuggerStepThrough]
	private static extern void smethod_2();

	private static extern Bitmap smethod_3();

	static extern void smethod_4(Thread thread_1);

	static extern void smethod_5(Thread thread_1);

	static extern Thread smethod_6(ThreadStart threadStart_0);

	unsafe static Screen smethod_7()
	{
		//Discarded unreachable code: IL_000d
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		((IntPtr[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (IntPtr)/*Error near IL_0001: Stack underflow*/;
		short num = *(short*)(nint)/*Error near IL_0003: Stack underflow*/;
		*(sbyte*)(nint)/*Error near IL_0005: Stack underflow*/ = (sbyte)num;
		_ = /*Error near IL_0006: Stack underflow*/^ /*Error near IL_0006: Stack underflow*/;
		_ = 1;
		/*Error near IL_0008: Invalid metadata token*/;
	}

	static Rectangle smethod_8(Screen screen_0)
	{
		//Discarded unreachable code: IL_0002
		/*Error near IL_0001: Unknown opcode: 0xFF*/;
	}
}
