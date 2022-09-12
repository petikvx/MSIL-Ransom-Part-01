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
	public static extern void smethod_1();

	[AsyncStateMachine(/*Could not decode attribute arguments.*/)]
	[DebuggerStepThrough]
	private static extern void smethod_2();

	private static extern Bitmap smethod_3();

	static extern void smethod_4(Thread thread_1);

	static extern void smethod_5(Thread thread_1);

	unsafe static Thread smethod_6(ThreadStart threadStart_0)
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

	static extern Screen smethod_7();

	static extern Rectangle smethod_8(Screen screen_0);
}
