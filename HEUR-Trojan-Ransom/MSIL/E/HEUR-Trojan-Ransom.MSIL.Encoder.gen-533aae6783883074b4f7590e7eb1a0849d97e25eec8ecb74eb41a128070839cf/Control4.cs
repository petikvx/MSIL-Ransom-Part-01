using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

internal class Control4 : Control3
{
	private Color color_0;

	private Color color_1;

	private Color color_2;

	private object object_0;

	private SolidBrush solidBrush_2;

	private Pen pen_0;

	public Control4()
	{
		Class14.vPNVHkezq0oMI();
		base._002Ector();
		method_23("ButtonColor Top", 35, 35, 35);
		method_23("ButtonColor Bot", 20, 20, 20);
		method_22("Text", Color.Orange);
		method_23("InnerBorder", 40, 40, 40);
		method_22("Header", Color.FromArgb(40, 40, 40));
	}

	protected override void ColorHook()
	{
		color_0 = method_21("ButtonColor Top");
		color_1 = method_21("ButtonColor Bot");
		object_0 = method_20("Text");
		color_2 = method_21("InnerBorder");
		solidBrush_2 = method_20("Header");
		pen_0 = Pens.get_Black();
	}

	protected override void PaintHook()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		checked
		{
			switch (enum0_0)
			{
			case (Enum0)0:
			{
				Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				LinearGradientBrush val7 = new LinearGradientBrush(rectangle, color_0, color_1, 90f);
				Graphics obj11 = graphics_0;
				rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				obj11.FillRectangle((Brush)(object)val7, rectangle);
				HatchBrush val8 = new HatchBrush((HatchStyle)21, Color.FromArgb(30, Color.Black), Color.Transparent);
				Graphics obj12 = graphics_0;
				rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				obj12.FillRectangle((Brush)(object)val8, rectangle);
				method_54((Brush)new SolidBrush(Color.DarkOrange), (HorizontalAlignment)2, 0, 0);
				Graphics obj13 = graphics_0;
				Pen obj14 = pen_0;
				rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				obj13.DrawRectangle(obj14, rectangle);
				Graphics obj15 = graphics_0;
				Pen val9 = new Pen(color_2);
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
				obj15.DrawRectangle(val9, rectangle);
				break;
			}
			case (Enum0)1:
			{
				Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				LinearGradientBrush val4 = new LinearGradientBrush(rectangle, color_0, Color.FromArgb(20, 20, 20), 90f);
				Graphics obj6 = graphics_0;
				rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				obj6.FillRectangle((Brush)(object)val4, rectangle);
				HatchBrush val5 = new HatchBrush((HatchStyle)21, Color.FromArgb(30, Color.Black), Color.Transparent);
				Graphics obj7 = graphics_0;
				rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				obj7.FillRectangle((Brush)(object)val5, rectangle);
				method_54((Brush)object_0, (HorizontalAlignment)2, -1, -1);
				Graphics obj8 = graphics_0;
				Pen obj9 = pen_0;
				rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				obj8.DrawRectangle(obj9, rectangle);
				Graphics obj10 = graphics_0;
				Pen val6 = new Pen(Color.FromArgb(45, 45, 45));
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
				obj10.DrawRectangle(val6, rectangle);
				break;
			}
			case (Enum0)2:
			{
				Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				LinearGradientBrush val = new LinearGradientBrush(rectangle, Color.FromArgb(20, 20, 20), color_1, 90f);
				Graphics obj = graphics_0;
				rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				obj.FillRectangle((Brush)(object)val, rectangle);
				HatchBrush val2 = new HatchBrush((HatchStyle)21, Color.FromArgb(30, Color.Black), Color.Transparent);
				Graphics obj2 = graphics_0;
				rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				obj2.FillRectangle((Brush)(object)val2, rectangle);
				method_54((Brush)new SolidBrush(Color.DarkOrange), (HorizontalAlignment)2, 1, 1);
				Graphics obj3 = graphics_0;
				Pen obj4 = pen_0;
				rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				obj3.DrawRectangle(obj4, rectangle);
				Graphics obj5 = graphics_0;
				Pen val3 = new Pen(Color.FromArgb(32, 32, 32));
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
				obj5.DrawRectangle(val3, rectangle);
				break;
			}
			}
		}
	}
}
