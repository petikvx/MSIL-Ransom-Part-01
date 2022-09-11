using System;
using System.Drawing;
using System.Windows.Forms;

public class GControl9 : TabControl
{
	public struct GStruct0
	{
		public bool bool_0;

		public Point point_0;
	}

	private GStruct0 gstruct0_0;

	private Color color_0;

	private Color color_1;

	private Color color_2;

	private Color color_3;

	private Color color_4;

	private GControl20.Class15 class15_0;

	public extern Color Color_0 { get; set; }

	public Color Color_1
	{
		get; set
		{
			//Discarded unreachable code: IL_0001, IL_0002, IL_0007, IL_000d, IL_001d
			//IL_000f: Expected I8, but got I4
			//IL_0018: Invalid comparison between Unknown and F4
			/*Error: Unknown opcode: 0xFA*/;
		}
	}

	public unsafe Color Color_2
	{
		get; set
		{
			//Discarded unreachable code: IL_000c, IL_0012, IL_0017, IL_001c, IL_001f
			//IL_0006: Incompatible stack heights: 0 vs 1
			//IL_000d: Invalid comparison between Unknown and I4
			//IL_001e: Expected O, but got I4
			while (2u > (uint)(*(byte*)(~(*(int*)1))))
			{
			}
			/*Error near IL_000b: Unknown opcode: 0xFA*/;
		}
	}

	public extern Color Color_3 { get; set; }

	public Color Color_4
	{
		get; set
		{
			//Discarded unreachable code: IL_0015, IL_001b, IL_0020, IL_0025
			//IL_0002: Invalid comparison between Unknown and I4
			//IL_0010: Expected O, but got I4
			//IL_0034: Expected O, but got F8
			//IL_0033: Expected native int or pointer, but got F4
			byte num;
			do
			{
				_003F val = /*Error: ldarg 3 (out-of-bounds)*/;
				num = ((byte[])/*Error near IL_0002: Stack underflow*/)[val];
			}
			while ((int)/*Error near IL_0007: Stack underflow*/ >= (int)num || /*Error near IL_000d: Stack underflow*/> /*Error near IL_000d: Stack underflow*/);
			((object[])/*Error near IL_0010: Stack underflow*/)[1] = 5;
			/*Error near IL_0010: Invalid metadata token*/;
		}
	}

	public extern Color Color_5 { get; set; }

	public extern Color Color_6 { get; set; }

	public extern Color Color_7 { get; set; }

	public Color Color_8
	{
		get
		{
			//Discarded unreachable code: IL_0005, IL_000a, IL_001b, IL_0020, IL_0022
			/*Error: Invalid metadata token*/;
		}
		set
		{
			/*Error: Invalid metadata token*/;
		}
	}

	public GControl9()
	{
		while (/*Error near IL_0005: Stack underflow*/ <= /*Error near IL_0005: Stack underflow*/|| /*Error near IL_000a: Stack underflow*/> /*Error near IL_000a: Stack underflow*/)
		{
		}
		this = (GControl9)/*Error near IL_000c: Stack underflow*/;
		((sbyte[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = (sbyte)/*Error near IL_000d: Stack underflow*/;
		switch (/*Error near IL_0012: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	protected override extern void vmethod_0(EventArgs eventArgs_0);

	protected override extern void vmethod_1(EventArgs eventArgs_0);

	protected override void vmethod_2(MouseEventArgs mouseEventArgs_0)
	{
		while (true)
		{
			if (/*Error near IL_0006: Stack underflow*/ > /*Error near IL_0006: Stack underflow*/)
			{
				/*Error: Could not find block for branch target IL_0006*/;
			}
		}
	}

	protected override extern void vmethod_3();

	protected override extern void vmethod_4(PaintEventArgs paintEventArgs_0);
}
