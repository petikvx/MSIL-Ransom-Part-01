using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class GControl17 : Control
{
	[StructLayout(LayoutKind.Auto)]
	internal struct Struct3
	{
		internal int int_0;

		internal bool bool_0;

		internal Color color_0;
	}

	private GClass1.GEnum1 genum1_0;

	private Color color_0;

	private Color color_1;

	private Color color_2;

	private GControl12.Class7 class7_0;

	public extern Color Color_0 { get; set; }

	public unsafe Color Color_1
	{
		get; set
		{
			//Discarded unreachable code: IL_0011, IL_0017, IL_003d
			//IL_0003: Expected F8, but got O
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Expected I4, but got O
			//IL_0038: Incompatible stack heights: 0 vs 2
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			do
			{
				object obj = ((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
				*(double*)(nint)/*Error near IL_0003: Stack underflow*/ = (double)obj;
			}
			while (/*Error near IL_0004: Stack underflow*/ / /*Error near IL_0004: Stack underflow*/!= 0);
			_ = *(IntPtr*)(nint)/*Error near IL_000a: Stack underflow*/;
			/*Error near IL_000b: stloc 0 (out-of-bounds)*/;
			/*Error near IL_000c: Invalid metadata token*/;
		}
	}

	public extern Color Color_2 { get; set; }

	public Color Color_3
	{
		get
		{
			while (true)
			{
				if (/*Error near IL_0002: Stack underflow*/ >= /*Error near IL_0002: Stack underflow*/)
				{
				}
				if (/*Error near IL_0008: Stack underflow*/ >= /*Error near IL_0008: Stack underflow*/)
				{
				}
			}
		}
		set; }

	public GControl17()
	{
		//Discarded unreachable code: IL_000f, IL_001a
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_000a: Stack underflow*// -126L;
		/*Error near IL_000a: Invalid metadata token*/;
	}

	protected override extern void vmethod_0(PaintEventArgs paintEventArgs_0);

	protected override extern void vmethod_1(EventArgs eventArgs_0);

	protected override extern void vmethod_2(EventArgs eventArgs_0);

	protected override extern void vmethod_3(EventArgs eventArgs_0);

	protected override extern void vmethod_4(MouseEventArgs mouseEventArgs_0);

	protected override void vmethod_5(MouseEventArgs mouseEventArgs_0)
	{
		//Discarded unreachable code: IL_0001, IL_0006, IL_000d
		//IL_000a: Expected I8, but got F8
		/*Error: Unknown opcode: 0xFD*/;
	}

	protected override extern void vmethod_6(EventArgs eventArgs_0);

	static extern void LdZHvEZwWZvoqYbduKxQvOyAAaRT(Control control_0, Color color_3);

	static extern Font cCELgoHIdlKXtaabriGEdfXblDFq(string string_0, float float_0);

	static extern void mjsgwjpgdaQagzRHjMQywTPreZbL(Control control_0, Font font_0);

	static void ZClzmfgzpQaDaQjIDjWaOjudUVoR(Control control_0)
	{
		//Discarded unreachable code: IL_0005, IL_0016
		/*Error: Invalid metadata token*/;
	}

	static extern void nZXjIQrPonnvaVbTbbasFvnFJpkY(int int_0);

	static void CnrxPjsSlAzQZewvnLYMBGipdow()
	{
		//Discarded unreachable code: IL_0012
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		byte num3;
		do
		{
			uint num = ((uint[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
			_003F val = /*Error near IL_0004: Stack underflow*/<< (int)num;
			float num2 = ((float[])/*Error near IL_0005: Stack underflow*/)[val];
			checked
			{
				num3 = (byte)unchecked(/*Error near IL_0006: Stack underflow*/ / num2);
			}
		}
		while ((int)/*Error near IL_000c: Stack underflow*/ > (int)num3);
		/*Error near IL_000d: Invalid metadata token*/;
	}
}
