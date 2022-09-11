using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class GControl3 : Control
{
	public delegate void GDelegate0(object sender);

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct4
	{
		internal Class4 class4_0;
	}

	[CompilerGenerated]
	private GDelegate0 gdelegate0_0;

	private GControl19.Class14 class14_0;

	public bool Boolean_0
	{
		get
		{
			//Discarded unreachable code: IL_0001, IL_0006, IL_000b, IL_0011, IL_0017, IL_001e, IL_0023, IL_0028, IL_0030, IL_0038, IL_003e
			//IL_000c: Invalid comparison between Unknown and F4
			//IL_0019: Invalid comparison between Unknown and I4
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Expected O, but got Unknown
			//IL_002b: Invalid comparison between Unknown and I4
			/*Error: Unknown opcode: 0xFA*/;
		}
		set; }

	public extern event GDelegate0 Event_0;

	protected override extern void vmethod_0(EventArgs eventArgs_0);

	protected override extern void vmethod_1(MouseEventArgs mouseEventArgs_0);

	protected override extern void vmethod_2(EventArgs eventArgs_0);

	protected override void vmethod_3(MouseEventArgs mouseEventArgs_0)
	{
		//Discarded unreachable code: IL_0004, IL_000a
		//IL_0005: Invalid comparison between Unknown and I4
		//IL_000b: Incompatible stack heights: 0 vs 1
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0015: Invalid comparison between Unknown and I
		while (true)
		{
			/*Error: stloc 0 (out-of-bounds)*/;
			if (/*Error near IL_0003: Stack underflow*/ == /*Error near IL_0003: Stack underflow*/)
			{
				break;
			}
			if (/*Error near IL_0011: Stack underflow*/ >= /*Error near IL_0011: Stack underflow*/)
			{
				nuint num;
				checked
				{
					_003F val = /*Error near IL_0012: Stack underflow*/* /*Error near IL_0012: Stack underflow*/;
					((object[])/*Error near IL_0014: Stack underflow*/)[/*Error near IL_0014: Stack underflow*/] = (object)val;
					num = (nuint)/*Error near IL_0015: Stack underflow*/;
				}
				if ((nint)/*Error near IL_001a: Stack underflow*/ >= (nint)num && /*Error near IL_0021: Stack underflow*/<= /*Error near IL_0021: Stack underflow*/)
				{
					/*Error: Could not find block for branch target IL_0021*/;
				}
			}
		}
		/*Error near IL_0003: Unknown opcode: 0xFA*/;
	}

	protected override extern void vmethod_4(EventArgs eventArgs_0);

	protected override extern void vmethod_5(EventArgs eventArgs_0);

	protected override extern void vmethod_6(EventArgs eventArgs_0);

	public extern GControl3();

	protected unsafe override void vmethod_7(PaintEventArgs paintEventArgs_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0012: Invalid comparison between Unknown and I
		while (true)
		{
			if (/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/>= /*Error near IL_0001: ldloc 1 (out-of-bounds)*/)
			{
				/*Error near IL_000a: stloc 1 (out-of-bounds)*/;
				((long[])/*Error near IL_000c: Stack underflow*/)[/*Error near IL_000c: Stack underflow*/] = (long)/*Error near IL_000c: Stack underflow*/;
				byte num = ((byte[])/*Error near IL_000e: Stack underflow*/)[/*Error near IL_000e: Stack underflow*/];
				*(IntPtr*)(nint)/*Error near IL_000f: Stack underflow*/ = (IntPtr)(int)num;
				IntPtr intPtr = (nint)((Array)/*Error near IL_0010: Stack underflow*/).LongLength;
				if ((nint)/*Error near IL_0017: Stack underflow*/ == (nint)intPtr)
				{
					/*Error: Could not find block for branch target IL_0017*/;
				}
			}
		}
	}
}
