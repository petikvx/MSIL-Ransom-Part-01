using System;
using System.Drawing;
using System.Windows.Forms;

public class GControl17 : Control
{
	private GClass1.GEnum3 genum3_0;

	private Color color_0;

	private Color color_1;

	private Color color_2;

	private GControl11.Struct6 struct6_0;

	public unsafe Color Color_0
	{
		get; set
		{
			//Discarded unreachable code: IL_0026, IL_002d, IL_0032, IL_0037, IL_003f
			//IL_0015: Invalid comparison between I4 and Unknown
			//IL_001d: Expected I8, but got I4
			//IL_0029: Expected O, but got I4
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Expected native int or pointer, but got O
			while (true)
			{
				*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
				if (/*Error near IL_0006: Stack underflow*/ == /*Error near IL_0006: Stack underflow*/)
				{
					/*Error near IL_0006: stloc 2 (out-of-bounds)*/;
					if (/*Error near IL_000c: Stack underflow*/ > /*Error near IL_000c: Stack underflow*/&& /*Error near IL_0011: Stack underflow*/>= /*Error near IL_0011: Stack underflow*/&& 2 <= (int)/*Error near IL_0013: ldarg 3 (out-of-bounds)*/)
					{
						break;
					}
				}
			}
			short num = *(short*)(nint)/*Error near IL_001c: Stack underflow*/;
			((long[])/*Error near IL_001d: Stack underflow*/)[/*Error near IL_001d: Stack underflow*/] = num;
			short num2 = ((short[])/*Error near IL_001f: Stack underflow*/)[/*Error near IL_001f: Stack underflow*/];
			((sbyte[])/*Error near IL_0021: Stack underflow*/)[/*Error near IL_0021: Stack underflow*/] = (sbyte)num2;
			/*Error near IL_0021: Invalid metadata token*/;
		}
	}

	public Color Color_1
	{
		get; set
		{
			//Discarded unreachable code: IL_0007, IL_000e, IL_0013, IL_0018, IL_0020
			//IL_000a: Expected O, but got I4
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected native int or pointer, but got O
			((sbyte[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (sbyte)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public extern Color Color_2 { get; set; }

	public extern Color Color_3 { get; set; }

	public extern GControl17();

	protected override extern void vmethod_0(PaintEventArgs paintEventArgs_0);

	protected override extern void vmethod_1(EventArgs eventArgs_0);

	protected override extern void vmethod_2(EventArgs eventArgs_0);

	protected override extern void vmethod_3(EventArgs eventArgs_0);

	protected override extern void vmethod_4(MouseEventArgs mouseEventArgs_0);

	protected unsafe override void vmethod_5(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected native int or pointer, but got F8
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		sbyte num = *(sbyte*)(nint)/*Error near IL_0001: Stack underflow*/;
		_003F val = /*Error near IL_0002: Stack underflow*/| num;
		sbyte num2 = *(sbyte*)(nint)(double)((long[])/*Error near IL_0003: Stack underflow*/)[val];
		checked
		{
			_ = /*Error near IL_0006: Stack underflow*/+ num2;
			_ = 4;
			/*Error: Unexpected end of block*/;
		}
	}

	protected override extern void vmethod_6(EventArgs eventArgs_0);
}
