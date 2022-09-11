using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class GControl10 : Control
{
	public enum GEnum5
	{
		Clear,
		DarkClear,
		SemiBlack,
		DarkPink,
		LightPink
	}

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct5
	{
		internal TextBox textBox_0;

		internal bool bool_0;

		internal HorizontalAlignment horizontalAlignment_0;

		internal bool bool_1;

		internal bool bool_2;
	}

	private GClass1.GEnum3 genum3_0;

	private GEnum5 genum5_0;

	private Color color_0;

	private int int_0;

	public extern int Int32_0 { get; set; }

	public GEnum5 GEnum5_0
	{
		get
		{
			throw /*Error near IL_0001: Stack underflow*/;
		}
		set; }

	public extern GControl10();

	protected override void vmethod_0(EventArgs eventArgs_0)
	{
		checked
		{
			_ = (short)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 3 (out-of-bounds)*/;
		}
	}

	protected override void vmethod_1(MouseEventArgs mouseEventArgs_0)
	{
		//Discarded unreachable code: IL_0012
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between F8 and I8
		_003F val;
		do
		{
			double num = (double)/*Error near IL_0001: Stack underflow*/;
			val = /*Error near IL_0002: Stack underflow*/| num;
		}
		while (/*Error near IL_0007: Stack underflow*/ > val || /*Error near IL_000c: Stack underflow*/<= /*Error near IL_000c: Stack underflow*/);
		/*Error near IL_000c: ldarg 2 (out-of-bounds)*/;
		/*Error near IL_000d: Invalid metadata token*/;
	}

	protected override extern void vmethod_2(MouseEventArgs mouseEventArgs_0);

	protected override void vmethod_3(EventArgs eventArgs_0)
	{
		//Discarded unreachable code: IL_0008, IL_000b, IL_000c, IL_0015, IL_001f, IL_0026, IL_002c, IL_002d, IL_0037, IL_003c
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected I8, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			short num = (short)(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			_ = /*Error near IL_0003: Stack underflow*/* num;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	protected override extern void vmethod_4(PaintEventArgs paintEventArgs_0);
}
