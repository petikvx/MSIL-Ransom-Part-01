using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class GControl18 : Control
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Struct7
	{
		internal Color color_0;

		internal Color color_1;
	}

	private GClass1.GEnum3 genum3_0;

	private Color color_0;

	private Color color_1;

	private Color color_2;

	private GControl11.Struct6 struct6_0;

	public Color Color_0
	{
		get
		{
			_ = 4;
			/*Error: Unexpected end of block*/;
		}
		set; }

	public unsafe Color Color_1
	{
		get
		{
			//Discarded unreachable code: IL_0006, IL_0017, IL_0021, IL_0027, IL_002c
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected I4, but got O
			/*Error near IL_0001: Invalid metadata token*/;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			byte num;
			do
			{
				num = *(byte*)(nint)/*Error near IL_0001: Stack underflow*/;
			}
			while ((sbyte)(/*Error near IL_0002: Stack underflow*/ % num) != 0);
			((int[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (int)/*Error near IL_0009: Stack underflow*/;
			throw /*Error near IL_000a: Stack underflow*/;
		}
	}

	public extern Color Color_2 { get; set; }

	public extern Color Color_3 { get; set; }

	public extern GControl18();

	protected override extern void vmethod_0(PaintEventArgs paintEventArgs_0);

	protected override extern void vmethod_1(EventArgs eventArgs_0);

	protected override extern void vmethod_2(EventArgs eventArgs_0);

	protected override extern void vmethod_3(EventArgs eventArgs_0);

	protected override extern void vmethod_4(MouseEventArgs mouseEventArgs_0);

	protected override void vmethod_5(MouseEventArgs mouseEventArgs_0)
	{
		//Discarded unreachable code: IL_000c
		while (/*Error near IL_0006: Stack underflow*/ < /*Error near IL_0006: Stack underflow*/)
		{
		}
		/*Error near IL_0007: Invalid metadata token*/;
	}

	protected override extern void vmethod_6(EventArgs eventArgs_0);
}
