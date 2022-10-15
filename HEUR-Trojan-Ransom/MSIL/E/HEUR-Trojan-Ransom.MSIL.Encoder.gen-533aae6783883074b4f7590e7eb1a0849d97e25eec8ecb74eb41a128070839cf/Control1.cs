using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

internal class Control1 : Control0
{
	private Color color_1;

	private Color color_2;

	private Color color_3;

	private Color color_4;

	private Color color_5;

	private Pen pen_0;

	private object object_0;

	private SolidBrush solidBrush_2;

	public Control1()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		Class14.vPNVHkezq0oMI();
		base._002Ector();
		method_14(Color.Fuchsia);
		BackColor = Color.FromArgb(20, 20, 20);
		Font = new Font("Segoe UI", 9f);
		method_43("ForeColor", Color.Orange);
		method_43("Border", Color.Black);
		method_43("InnerBorder", Color.FromArgb(40, 40, 40));
		method_43("BackGroundColor", Color.FromArgb(20, 20, 20));
		method_43("Header", Color.FromArgb(22, 22, 22));
		method_44("G1", 14, 14, 14);
		method_44("G2", 20, 20, 20);
	}

	protected override void ColorHook()
	{
		color_2 = method_42("ForeColor");
		color_1 = method_42("Border");
		color_5 = method_42("InnerBorder");
		pen_0 = Pens.get_Black();
		object_0 = method_41("BackGroundColor");
		solidBrush_2 = method_41("Header");
		color_3 = method_42("G1");
		color_4 = method_42("G2");
	}

	protected override void PaintHook()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		graphics_0.Clear(color_3);
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			LinearGradientBrush val = new LinearGradientBrush(rectangle, color_3, color_4, -90f);
			Graphics obj = graphics_0;
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			obj.FillRectangle((Brush)(object)val, rectangle);
			HatchBrush val2 = new HatchBrush((HatchStyle)21, Color.FromArgb(75, Color.Black), Color.Transparent);
			Graphics obj2 = graphics_0;
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			obj2.FillRectangle((Brush)(object)val2, rectangle);
			Graphics obj3 = graphics_0;
			object obj4 = object_0;
			rectangle = new Rectangle(8, 28, ((Control)this).get_Width() - 17, ((Control)this).get_Height() - 36);
			obj3.FillRectangle((Brush)obj4, rectangle);
			graphics_0.DrawRectangle(new Pen(color_5), 9, 29, ((Control)this).get_Width() - 19, ((Control)this).get_Height() - 38);
			Graphics obj5 = graphics_0;
			Pen obj6 = pen_0;
			rectangle = new Rectangle(8, 28, ((Control)this).get_Width() - 17, ((Control)this).get_Height() - 36);
			obj5.DrawRectangle(obj6, rectangle);
			Graphics obj7 = graphics_0;
			Pen obj8 = pen_0;
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			obj7.DrawRectangle(obj8, rectangle);
			Graphics obj9 = graphics_0;
			Pen val3 = new Pen(color_5);
			rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
			obj9.DrawRectangle(val3, rectangle);
			Graphics obj10 = graphics_0;
			string text = ((Control)this).FindForm().get_Text();
			Font font = Font;
			SolidBrush val4 = new SolidBrush(color_2);
			Point point = new Point(35, 7);
			obj10.DrawString(text, font, (Brush)val4, (PointF)point);
			Graphics obj11 = graphics_0;
			Icon icon = ((Control)this).FindForm().get_Icon();
			rectangle = new Rectangle(10, 4, 22, 22);
			obj11.DrawIcon(icon, rectangle);
		}
	}
}
