using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class GControl0 : Control
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 10)]
	private struct Struct2
	{
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct3
	{
		internal int int_0;

		internal bool bool_0;

		internal string string_0;
	}

	private Class7.Class8 class8_0;

	private static readonly Array array_0;

	private static readonly object object_0;

	private static readonly object object_1;

	internal static Struct2 struct2_0/* Not supported: data(FC 91 91 E8 BF 83 26 41 5D F8) */;

	protected override void vmethod_0(MouseEventArgs mouseEventArgs_0)
	{
		//Discarded unreachable code: IL_0009, IL_000e, IL_0014, IL_001a, IL_0024, IL_002c, IL_0031, IL_0037, IL_003c
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		nint num = (nint)/*Error near IL_0001: Stack underflow*/;
		_ = /*Error near IL_0003: Stack underflow*/>> (int)num;
		_ = 0;
		/*Error near IL_0004: Invalid metadata token*/;
	}

	protected override void vmethod_1(MouseEventArgs mouseEventArgs_0)
	{
		//Discarded unreachable code: IL_0008
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/)
		{
		}
		_ = /*Error near IL_0006: Stack underflow*/% /*Error near IL_0006: Stack underflow*/;
		/*Error near IL_0007: Unknown opcode: 0xFA*/;
	}

	protected override extern void vmethod_2(EventArgs eventArgs_0);

	protected override extern void vmethod_3(EventArgs eventArgs_0);

	public extern GControl0();

	protected override extern void vmethod_4(PaintEventArgs paintEventArgs_0);

	internal static extern string smethod_0(long long_0, int int_0, char char_0, int int_1);
}
