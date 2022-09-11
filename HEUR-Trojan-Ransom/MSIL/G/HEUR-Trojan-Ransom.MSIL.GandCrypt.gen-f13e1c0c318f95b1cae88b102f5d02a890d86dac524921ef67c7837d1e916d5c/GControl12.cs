using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class GControl12 : Control
{
	private TextBox textBox_0;

	private HorizontalAlignment horizontalAlignment_0;

	private bool bool_0;

	private Image image_0;

	private bool bool_1;

	protected GClass1.GEnum3 genum3_0;

	private Color color_0;

	private Color color_1;

	private Color color_2;

	private GControl0.Struct3 struct3_0;

	[EditorBrowsable(EditorBrowsableState.Never)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	[Browsable(false)]
	public extern BorderStyle BorderStyle_0 { get; }

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public extern bool Boolean_0 { get; set; }

	public extern HorizontalAlignment HorizontalAlignment_0 { get; set; }

	public extern int Int32_0 { get; set; }

	public bool Boolean_1
	{
		get
		{
			_003F val = /*Error: ldarg 2 (out-of-bounds)*/;
			_ = (uint)((sbyte[])/*Error near IL_0002: Stack underflow*/)[val];
			/*Error near IL_0005: Invalid metadata token*/;
		}
		set
		{
			//Discarded unreachable code: IL_0009, IL_000b, IL_0016
			while (true)
			{
			}
		}
	}

	public unsafe bool Boolean_2
	{
		get; set
		{
			//Discarded unreachable code: IL_000f, IL_0017, IL_001d
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			_003F val = checked(/*Error near IL_0001: Stack underflow*/ + /*Error near IL_0001: Stack underflow*/);
			_ = *(int*)(nint)(/*Error near IL_0002: Stack underflow*/ % val);
			_ = (nint)0;
			/*Error near IL_000e: Unknown opcode: 0xFC*/;
		}
	}

	public extern string String_0 { get; set; }

	public Image Image_0
	{
		get
		{
			return (Image)(object)/*OpCode not supported: Nop*/;
		}
		set; }

	[Browsable(false)]
	public override Image Image_1
	{
		get; set
		{
			//Discarded unreachable code: IL_0009, IL_000e
			do
			{
				this = (GControl12)/*Error near IL_0002: Stack underflow*/;
			}
			while (/*Error near IL_0008: Stack underflow*/ < /*Error near IL_0008: Stack underflow*/);
			/*Error near IL_0008: Unknown opcode: 0xFF*/;
		}
	}

	[Browsable(false)]
	public override extern ImageLayout ImageLayout_0 { get; set; }

	public unsafe override string String_1
	{
		get
		{
			//Discarded unreachable code: IL_000e, IL_0011, IL_0016, IL_001d
			*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
			checked
			{
				_ = (ulong)/*Error near IL_0002: ldloc 0 (out-of-bounds)*/;
				_ = (byte)/*Error near IL_0006: ldarg 1 (out-of-bounds)*/;
				/*Error near IL_0009: Invalid metadata token*/;
			}
		}
		set
		{
			//Discarded unreachable code: IL_0007, IL_0017, IL_0027
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			((int[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/] = (int)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public override Color Color_1
	{
		get
		{
			//Discarded unreachable code: IL_0005, IL_000c, IL_0011
			//IL_0007: Invalid comparison between Unknown and I4
			/*Error: Invalid metadata token*/;
		}
		set; }

	public override extern Color Color_2 { get; set; }

	public Color Color_0
	{
		get; set
		{
			//Discarded unreachable code: IL_0007
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public extern GControl12();

	protected override extern void vmethod_0(PaintEventArgs paintEventArgs_0);

	private extern void method_0(object sender, EventArgs e);

	private extern void method_1(object sender, EventArgs e);

	private extern void method_2(object sender, EventArgs e);

	private extern void method_3(object sender, EventArgs e);

	private extern void method_4(object sender, EventArgs e);

	private extern void method_5(object sender, EventArgs e);

	protected override extern void vmethod_1(EventArgs eventArgs_0);

	private extern void method_6(object sender, KeyEventArgs e);

	protected override extern void vmethod_2();

	protected override extern void vmethod_3(EventArgs eventArgs_0);
}
