using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GControl14 : Control
{
	public delegate void GDelegate5(object sender);

	internal sealed class Class13
	{
		internal Class4 class4_0;

		internal extern Class13();
	}

	protected bool bool_0;

	protected GClass1.GEnum3 genum3_0;

	[CompilerGenerated]
	private GDelegate5 gdelegate5_0;

	private Color color_0;

	public extern bool Boolean_0 { get; set; }

	public unsafe Color Color_0
	{
		get; set
		{
			//Discarded unreachable code: IL_000d, IL_0014, IL_0022
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Expected O, but got I
			//IL_002e: Expected native int or pointer, but got O
			//IL_0031: Invalid comparison between Unknown and I4
			checked
			{
				_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
				_ = (nint)unchecked((int)(*(byte*)checked((short)(object)null)));
				/*Error near IL_0008: Invalid metadata token*/;
			}
		}
	}

	public event GDelegate5 Event_0
	{
		[CompilerGenerated]
		add;
		[CompilerGenerated]
		remove
		{
			short num = (short)/*Error near IL_0002: Stack underflow*/;
			_ = ((ushort[])/*Error near IL_0003: Stack underflow*/)[num];
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	protected override extern void vmethod_0(EventArgs eventArgs_0);

	protected override void vmethod_1(PaintEventArgs paintEventArgs_0)
	{
		/*Error: Unexpected end of block*/;
	}

	public extern GControl14();

	protected unsafe override void vmethod_2(EventArgs eventArgs_0)
	{
		//Discarded unreachable code: IL_0026
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected native int or pointer, but got O
		//IL_001b: Invalid comparison between Unknown and I4
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
			{
				continue;
			}
			_003F val = /*Error near IL_0006: Stack underflow*/& /*Error near IL_0006: Stack underflow*/;
			if (/*Error near IL_000b: Stack underflow*/ != val)
			{
				ushort num = (ushort)/*Error near IL_000c: Stack underflow*/;
				*(double*)(nint)this = 7.81312495237836E-143;
				byte num2;
				checked
				{
					num2 = (byte)unchecked((int)num);
				}
				if ((int)/*Error near IL_0020: Stack underflow*/ >= (int)num2)
				{
					break;
				}
			}
		}
		_ = 2;
		/*Error near IL_0021: Invalid metadata token*/;
	}

	protected override extern void vmethod_3();

	protected override extern void vmethod_4(EventArgs eventArgs_0);

	protected override extern void vmethod_5(EventArgs eventArgs_0);

	protected override extern void vmethod_6(EventArgs eventArgs_0);

	protected override extern void vmethod_7(EventArgs eventArgs_0);

	static extern Delegate WSifEYgrmQYSFMYLHGiAnHBHTCbK(Delegate delegate_0, Delegate delegate_1);

	static extern Delegate OcwFMrpSUmFrPcfZcoXBaUiQYFGQ(Delegate delegate_0, Delegate delegate_1);

	static extern void ZBjHBnxCNVtIXFrfizMxqPPTqqAK(Control control_0);

	static extern int noZojhBjGXySJaHNlCGQFczXlYpr(Control control_0);

	static extern int tYiUxAJccwKBFhExXiMgQQJkYjHe(Control control_0);

	static extern Bitmap jDaHlQEytHqWlHCcapiMeGaFeDQg(int int_0, int int_1);

	static extern Graphics WxpdUIgsQvRshGiDvtzozYkLMcHC(Image image_0);

	unsafe static void oidIIIOdDegMifqxQMwzuUUcXVJS(Graphics graphics_0, SmoothingMode smoothingMode_0)
	{
		//Discarded unreachable code: IL_001f, IL_0026, IL_002d
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected I4, but got Unknown
		//IL_0019: Expected I4, but got I8
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0006: Stack underflow*/ < /*Error near IL_0006: Stack underflow*/)
		{
		}
		long num = (long)/*Error near IL_0007: Stack underflow*/;
		long num2 = ((ushort[])/*Error near IL_0008: Stack underflow*/)[num];
		_003F val = /*Error near IL_000a: Stack underflow*/* num2;
		((int[])/*Error near IL_000b: Stack underflow*/)[/*Error near IL_000b: Stack underflow*/] = (int)val;
		*(_003F*)(nint)/*Error near IL_000d: Stack underflow*/ = /*Error near IL_000d: Stack underflow*/;
		((int[])/*Error near IL_0019: Stack underflow*/)[/*Error near IL_0019: Stack underflow*/] = 0;
		/*Error near IL_001a: Invalid metadata token*/;
	}

	unsafe static SolidBrush eZyeUkALLEJpYBIVACyftLuKRUFBB(Color color_1)
	{
		//Discarded unreachable code: IL_0013, IL_001a, IL_0021, IL_002d, IL_0033
		//IL_000d: Expected I4, but got I8
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		((int[])/*Error near IL_000d: Stack underflow*/)[/*Error near IL_000d: Stack underflow*/] = 0;
		/*Error near IL_000e: Invalid metadata token*/;
	}

	static extern Cursor NpYfthBXlrIpGBovnOiavURAeQIcA();

	static extern void OOcxqWRxPxoLzWIhXDjMSKrBgQCCA(Control control_0, Cursor cursor_0);
}
