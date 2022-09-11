using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class GControl15 : Control
{
	public delegate void GDelegate6(object sender);

	private int int_0;

	private int int_1;

	private Color color_0;

	[CompilerGenerated]
	private GDelegate6 gdelegate6_0;

	private GControl20.Struct5 struct5_0;

	public extern int Int32_0 { get; set; }

	public int Int32_1
	{
		get; set
		{
			_ = (float)checked((long)/*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0002: stloc 0 (out-of-bounds)*/;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	public unsafe int Int32_2
	{
		get
		{
			_ = *(*(short**)(nint)/*Error near IL_0004: Stack underflow*/);
			/*Error near IL_0005: ldloca 0 (out-of-bounds)*/;
			_ = 7565592821274001668L;
			_ = -942808682;
			/*Error: Unexpected end of block*/;
		}
		set; }

	public extern Color Color_0 { get; set; }

	public unsafe Color Color_1
	{
		get; set
		{
			//Discarded unreachable code: IL_001d, IL_0022
			//IL_0004: Invalid comparison between Unknown and F4
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected I8, but got Unknown
			float num2;
			do
			{
				int num = *(int*)(nint)/*Error near IL_0002: Stack underflow*/;
				num2 = ((float[])/*Error near IL_0004: Stack underflow*/)[num];
			}
			while (((float)/*Error near IL_0006: Stack underflow*/ == num2 && /*Error near IL_000b: Stack underflow*/== /*Error near IL_000b: Stack underflow*/) || (int)/*Error near IL_0011: Stack underflow*/ == 0 || /*Error near IL_0017: Stack underflow*/> /*Error near IL_0017: Stack underflow*/);
			/*Error near IL_0018: Invalid metadata token*/;
		}
	}

	public extern Color Color_2 { get; set; }

	public unsafe event GDelegate6 Event_0
	{
		[CompilerGenerated]
		add
		{
			//IL_0005: Expected F4, but got I4
			checked
			{
				int num = *unchecked((sbyte*)(nint)/*Error near IL_0002: Stack underflow*/) + 3;
				((float[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = num;
				/*Error near IL_0005: ldloca 0 (out-of-bounds)*/;
				/*Error: Unexpected end of block*/;
			}
		}
		[CompilerGenerated]
		remove
		{
			//Discarded unreachable code: IL_000a, IL_0010, IL_0016, IL_001b, IL_0022
			//IL_000b: Invalid comparison between Unknown and F8
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Invalid comparison between Unknown and I4
			nuint num = checked((nuint)/*Error near IL_0003: Stack underflow*/);
			_ = ((sbyte[])/*Error near IL_0004: Stack underflow*/)[num];
			/*Error near IL_0005: Invalid metadata token*/;
		}
	}

	protected override extern void vmethod_0(PaintEventArgs paintEventArgs_0);

	public extern GControl15();

	public extern void method_0();

	static extern void pCpFGnhaBNFYvDmWrxzTytCzKhcAb(Control control_0);

	static extern int DpxyvEpJEOkZJMucGPNTzOHaALC(Control control_0);

	static extern int xOVtTHpPbNUsMmZSbcnGSvzdRsOV(Control control_0);

	static extern Bitmap pqOEGUPqjmeuvGbyYheBkFqmpacVA(int int_2, int int_3);

	static extern Graphics OZHKeywWfgQBzODZegaVzMlZxTFs(Image image_0);

	static extern void ljntFRmdCDAoaJUcqnyPekZRayNy(Graphics graphics_0, SmoothingMode smoothingMode_0);

	static extern SolidBrush jqVgiAZsemUaaRRBpVwjJrAOqwvB(Color color_1);

	static void xeLiQrCsGOxBnYRmoajLByMpZVnQA(Control control_0, Color color_1)
	{
		//Discarded unreachable code: IL_0004
		_ = (long)/*Error near IL_0001: Stack underflow*/;
		_ = -97;
		/*Error near IL_0003: Unknown opcode: 0xFF*/;
	}

	static extern int GFEDmwqnhyEyKahzYtifrlrpvKpL(int int_2);

	static extern Delegate ffLEJXVAPHHUJJyawCDowYPeasFS(Delegate delegate_0, Delegate delegate_1);

	static extern Delegate qhzKHcfNuZbpPazPIOSbDEhSOgQRA(Delegate delegate_0, Delegate delegate_1);

	static extern double sYCXoFYGeSJPwzVInPWLZTvSdJcq(double double_0);
}
