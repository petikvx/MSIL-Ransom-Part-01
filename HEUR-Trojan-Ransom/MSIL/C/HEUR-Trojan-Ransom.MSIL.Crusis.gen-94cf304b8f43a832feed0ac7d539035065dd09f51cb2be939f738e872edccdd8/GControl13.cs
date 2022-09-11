using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Layout;

public class GControl13 : Control
{
	public delegate void GDelegate4(object sender);

	[StructLayout(LayoutKind.Auto)]
	internal struct Struct3
	{
		internal bool bool_0;

		internal Color color_0;
	}

	private int int_0;

	[CompilerGenerated]
	private GDelegate4 gdelegate4_0;

	private Color color_0;

	private Struct3 struct3_0;

	public extern bool Boolean_0 { get; set; }

	public extern int Int32_0 { get; set; }

	public unsafe Color Color_0
	{
		get; set
		{
			//Discarded unreachable code: IL_0012, IL_001a, IL_001f, IL_0027, IL_0029
			//IL_0004: Expected O, but got I4
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected native int or pointer, but got F8
			//IL_0015: Invalid comparison between Unknown and O
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			do
			{
				this = (GControl13)(*(short*)(int)(*(byte*)(nint)/*Error near IL_0001: Stack underflow*/));
				_ = /*Error near IL_0005: Stack underflow*/* /*Error near IL_0005: Stack underflow*/;
				/*Error near IL_0005: stloc 3 (out-of-bounds)*/;
			}
			while ((int)/*Error near IL_000b: Stack underflow*/ != 0);
			/*Error near IL_000b: stloc 0 (out-of-bounds)*/;
			/*Error near IL_000d: Invalid metadata token*/;
		}
	}

	public unsafe Color Color_1
	{
		get
		{
			//Discarded unreachable code: IL_0017
			//IL_000c: Expected F8, but got I
			//IL_0011: Expected I4, but got Unknown
			while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/|| /*Error near IL_000a: Stack underflow*/< /*Error near IL_000a: Stack underflow*/)
			{
			}
			nint num = checked((nint)/*Error near IL_000b: Stack underflow*/);
			((double[])/*Error near IL_000c: Stack underflow*/)[/*Error near IL_000c: Stack underflow*/] = num;
			_003F val = /*Error near IL_000c: ldloca 0 (out-of-bounds)*/;
			*(int*)(nint)/*Error near IL_0011: Stack underflow*/ = (int)val;
			_ = -1;
			/*Error near IL_0012: Invalid metadata token*/;
		}
		set; }

	public unsafe event GDelegate4 Event_0
	{
		[CompilerGenerated]
		add;
		[CompilerGenerated]
		remove
		{
			//Discarded unreachable code: IL_0013
			//IL_0008: Expected O, but got F8
			//IL_0007: Expected native int or pointer, but got O
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unsupported input type for neg.
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			do
			{
				int num = checked((int)/*Error near IL_0001: Stack underflow*/);
				object obj = ((object[])/*Error near IL_0002: Stack underflow*/)[num];
				/*OpCode not supported: DebugBreak*/;
				*(object*)(nint)obj = *(double*)6;
			}
			while (/*Error near IL_000d: Stack underflow*/ != /*Error near IL_000d: Stack underflow*/);
			int num2 = /*Error near IL_000e: Stack underflow*/>> (int)/*Error near IL_000e: Stack underflow*/;
			_ = ((sbyte[])/*Error near IL_0011: Stack underflow*/)[num2];
			/*Error near IL_0012: Unknown opcode: 0xF8*/;
		}
	}

	public extern GControl13();

	protected override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		//Discarded unreachable code: IL_0006, IL_000c, IL_0012
		/*Error near IL_0001: Invalid metadata token*/;
	}

	protected override extern void vmethod_1(EventArgs eventArgs_0);

	protected unsafe override void vmethod_2(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected native int or pointer, but got O
		//IL_000f: Expected native int or pointer, but got F4
		_003F val;
		do
		{
			val = /*Error near IL_0001: Stack underflow*/>> (int)/*Error near IL_0001: Stack underflow*/;
		}
		while (/*Error near IL_0006: Stack underflow*/ >= val);
		_ = *(byte*)(nint)this;
		_ = *(float*)null;
		_ = 2;
		/*Error near IL_0013: Invalid metadata token*/;
	}

	protected override extern void vmethod_3(EventArgs eventArgs_0);

	private void method_0()
	{
		//Discarded unreachable code: IL_0005, IL_0010, IL_0015, IL_0025, IL_002a
		//IL_0008: Expected F4, but got O
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_001b: Expected I4, but got O
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected I4, but got Unknown
		/*Error: Invalid metadata token*/;
	}

	protected override extern void vmethod_4();

	static extern Delegate MDvcyGSLxYfhxerZlJICXHtVSnVOA(Delegate delegate_0, Delegate delegate_1);

	static extern Delegate fSGZkZONkXVCSwKhGsySiimCIGHy(Delegate delegate_0, Delegate delegate_1);

	static extern void VyYruyXsrkTlEGROIgdhxpdyHZPv(Control control_0);

	static extern Cursor BMIelkgUuBbxVKjvpwYzmXfNedIe();

	static extern void KLweNHgieFhKBqoPKhoEScfoHoprA(Control control_0, Cursor cursor_0);

	static extern Font JmsKZpSxOdZaNxJVpQSzbPRBcasD(string string_0, float float_0, FontStyle fontStyle_0);

	static void clcZJYwOFRgQvSyXKhZhhmfkpdQJ(Control control_0, Font font_0)
	{
		//IL_000c: Expected I4, but got Unknown
		while (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
		{
		}
		switch ((int)/*Error near IL_0005: ldloc 0 (out-of-bounds)*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern int mkvaehhIcTErfEUMcRBxDSPgFWaJe(Control control_0);

	static extern int BMqcyrwoACuzZpsqfzQsqGHZgGWM(Control control_0);

	static extern Bitmap UXeQzZGuidpvLpFCIEADdFLbvRZP(int int_1, int int_2);

	static extern Graphics RphQuxzwNbfFiOkJHbugiJyTkXLCA(Image image_0);

	static void JcOfYRULhdyqTwtmlTbYJPLutpxi(Graphics graphics_0, TextRenderingHint textRenderingHint_0)
	{
		//Discarded unreachable code: IL_0009, IL_0011, IL_0018, IL_001e, IL_002a, IL_0031
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and F4
		//IL_0022: Expected I, but got F8
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected I4, but got Unknown
		//IL_0039: Invalid comparison between Unknown and I4
		long num = ((long[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		checked
		{
			_ = /*Error near IL_0003: Stack underflow*/* num;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	unsafe static void yQOXBgcHVCFBlFdCsiFNBEYBdmAIB(Graphics graphics_0, SmoothingMode smoothingMode_0)
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

	static extern int rgqLmszHsYHkVXmUebWbDaayThfy(double double_0);

	static extern Pen EapDYlKMIAfoFAbuWGzrvvxIAhoR(Color color_1, float float_0);

	static extern void delEhOCufWnlcnvTXdgQVURIaIJj(Graphics graphics_0, Pen pen_0, int int_1, int int_2, int int_3, int int_4);

	unsafe static SolidBrush NLtobWOjdUkNAeCKXeGOJpDrsxTE(Color color_1)
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

	static void dwEdAEqmPUHQagPUxHGSiLZpdSxpA(Control control_0, int int_1)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_000b, IL_0013, IL_001c, IL_0022, IL_0028, IL_002f, IL_0034, IL_003b
		//IL_002a: Expected native int or pointer, but got F4
		//IL_0036: Invalid comparison between Unknown and I4
		while (true)
		{
		}
	}

	static extern bool IWlEfeIciARSqXTnSbxteYSzgEPo(Control control_0);

	static extern Control BlHVHehrrtnIftPuAwNYeHcHeoyE(Control control_0);

	static extern ControlCollection AwjqTWfDVCMgWSANsVdsMwsOjpZU(Control control_0);

	static extern IEnumerator XobcbogShBQNxQZSaOsjvledsMhN(ArrangedElementCollection arrangedElementCollection_0);

	static object tdDgKGFshleqkIldgrNoYkaJpIIl(IEnumerator ienumerator_0)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_000f, IL_001f
		//IL_0012: Expected F8, but got I4
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected F4, but got Unknown
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern bool pffjXqotvLtyXBpjKmHvGQDIfYhS(IEnumerator ienumerator_0);

	static extern void GRiQUTPOfqtXWMqGSTnlbODcFeeA(IDisposable idisposable_0);
}
