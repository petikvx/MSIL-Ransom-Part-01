using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class GControl3 : Control
{
	public delegate void GDelegate0(object sender);

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct2
	{
		internal Color color_0;

		internal Color color_1;
	}

	private Enum0 enum0_0;

	[CompilerGenerated]
	private GDelegate0 gdelegate0_0;

	private GControl15.Class16 class16_0;

	public unsafe bool Boolean_0
	{
		get
		{
			//Discarded unreachable code: IL_0015, IL_0016
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0003: Invalid comparison between Unknown and I4
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Incompatible stack heights: 0 vs 2
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				_003F val = /*Error near IL_0001: Stack underflow*// /*Error near IL_0001: Stack underflow*/;
				if ((int)/*Error near IL_0008: Stack underflow*/ < (int)(~val))
				{
					IntPtr intPtr = *(IntPtr*)(nint)(/*Error near IL_0009: Stack underflow*/ % /*Error near IL_0009: Stack underflow*/);
					*(short*)(nint)/*Error near IL_000b: Stack underflow*/ = (short)(nint)intPtr;
					/*Error near IL_000c: ldloc 0 (out-of-bounds)*/;
					/*Error near IL_000e: ldloc 1 (out-of-bounds)*/;
				}
			}
		}
		set; }

	public extern event GDelegate0 Event_0;

	protected override extern void vmethod_0(EventArgs eventArgs_0);

	protected override extern void vmethod_1(MouseEventArgs mouseEventArgs_0);

	protected override extern void vmethod_2(EventArgs eventArgs_0);

	protected override extern void vmethod_3(MouseEventArgs mouseEventArgs_0);

	protected override extern void vmethod_4(EventArgs eventArgs_0);

	protected override extern void vmethod_5(EventArgs eventArgs_0);

	protected override extern void vmethod_6(EventArgs eventArgs_0);

	public extern GControl3();

	protected override extern void vmethod_7(PaintEventArgs paintEventArgs_0);

	static extern void NSaBGIfbkNCLgxMGVktCtyxVuCvi(Control control_0);

	static extern void bZSPrZqhNawUeREJkgHClsTXFZYw(Control control_0, int int_0);

	static extern void zmRoqxXkyfFNkYdhXmRSzDgZWEod(Control control_0, int int_0);

	static extern Delegate sFilalwvZhoFxuPafZpSpYhENnCh(Delegate delegate_0, Delegate delegate_1);

	static Delegate bqIBElyWaYzgiIpmvXLpZMEuYyGi(Delegate delegate_0, Delegate delegate_1)
	{
		//Discarded unreachable code: IL_000a, IL_0010
		//IL_000b: Invalid comparison between Unknown and I
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ == /*Error near IL_0005: Stack underflow*/)
			{
			}
		}
	}

	static void vIvtegrSpglDjOOoBifdEicdRiwRA(Control control_0, Color color_0)
	{
		//Discarded unreachable code: IL_0005
		//IL_0007: Expected O, but got I4
		/*Error: Invalid metadata token*/;
	}

	static extern void PYreLMlNnljgwEwtURXIIXSVNFySA(Control control_0, Color color_0);

	static int WnIGkTABWMzeXmMoHWnwBLSfThRb(Control control_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected I4, but got Unknown
		sbyte num = ((sbyte[])/*Error near IL_0003: Stack underflow*/)[/*Error near IL_0003: Stack underflow*/];
		switch (/*Error near IL_0004: Stack underflow*/ % num)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static int ojbXTQlHusdXxiDrkbmnBaoJAIKUb(Control control_0)
	{
		//Discarded unreachable code: IL_000c, IL_0014
		//IL_0002: Expected I8, but got I4
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			((long[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = -1L;
		}
		while (/*Error near IL_0007: Stack underflow*/ <= /*Error near IL_0007: Stack underflow*/);
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern Bitmap hFkTJmNCjlrwdsvOxPTGWcEVkINN(int int_0, int int_1);

	unsafe static Graphics DoNibvzdlKaovxTvlqIcxJOeYsAb(Image image_0)
	{
		//Discarded unreachable code: IL_0021, IL_0027, IL_002f
		do
		{
			/*Error: stloc 3 (out-of-bounds)*/;
			long num = checked((long)/*Error near IL_0002: Stack underflow*/);
			short num2 = ((short[])/*Error near IL_0005: Stack underflow*/)[num];
			((int[])/*Error near IL_000b: Stack underflow*/)[num2] = -1596073417;
			*(long*)(int)checked((ushort)/*Error near IL_000d: Stack underflow*/) = -4727497112805965720L;
		}
		while (/*Error near IL_001c: Stack underflow*/ < /*Error near IL_001c: Stack underflow*/);
		/*Error near IL_001c: Invalid metadata token*/;
	}

	static extern void qkpAytfOfkauwIjCmYQKApokmMGS(Graphics graphics_0, SmoothingMode smoothingMode_0);

	static extern void mfhteOQeRqUGGzZWyiKCsYEFiIHF(Graphics graphics_0, CompositingQuality compositingQuality_0);

	static extern void ZItKaionTClSGFhEDwrZhyrKncnL(Graphics graphics_0, Color color_0);

	static extern LinearGradientBrush mFXhjntyMUEoaoDDOfDzfuufjyhuA(Rectangle rectangle_0, Color color_0, Color color_1, float float_0);

	static extern void FWwDjXoMGvBtlhfSuygWxuulOLYu(Graphics graphics_0, Brush brush_0, GraphicsPath graphicsPath_0);

	static extern Pen PuEkBRQnDnMDUvudlKaoEKiUxSvI(Color color_0);

	static extern void rnoRtWWncRmKUGSVELvrygmUSCew(Graphics graphics_0, Pen pen_0, GraphicsPath graphicsPath_0);
}
