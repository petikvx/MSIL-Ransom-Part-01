using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

internal class Control2 : Control0
{
	private Pen pen_0;

	private SolidBrush solidBrush_2;

	private object object_0;

	private Color color_1;

	private Color color_2;

	public Control2()
	{
		Class14.vPNVHkezq0oMI();
		base._002Ector();
		method_36(bool_15: true);
		method_43("Border", Color.Black);
		method_44("Header", 32, 32, 32);
		method_43("Text", Color.Orange);
		method_44("R1", 14, 14, 14);
		method_44("R2", 41, 41, 41);
	}

	protected override void ColorHook()
	{
		pen_0 = method_39("Border");
		solidBrush_2 = method_41("Header");
		object_0 = method_41("Text");
		color_1 = method_42("R1");
		color_2 = method_42("R2");
	}

	protected override void PaintHook()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d7: Expected O, but got Unknown
		graphics_0.Clear(Color.FromArgb(14, 14, 14));
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			LinearGradientBrush val = new LinearGradientBrush(rectangle, color_1, color_2, 90f);
			Graphics obj = graphics_0;
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 25);
			obj.FillRectangle((Brush)(object)val, rectangle);
			HatchBrush val2 = new HatchBrush((HatchStyle)26, Color.FromArgb(15, Color.White), Color.Transparent);
			Graphics obj2 = graphics_0;
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			obj2.FillRectangle((Brush)(object)val2, rectangle);
			Graphics obj3 = graphics_0;
			Pen obj4 = pen_0;
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, 25);
			obj3.DrawRectangle(obj4, rectangle);
			Graphics obj5 = graphics_0;
			Pen obj6 = pen_0;
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			obj5.DrawRectangle(obj6, rectangle);
			Graphics obj7 = graphics_0;
			string text = Text;
			Font font = Font;
			object obj8 = object_0;
			Point point = new Point(7, 6);
			obj7.DrawString(text, font, (Brush)obj8, (PointF)point);
			Graphics obj9 = graphics_0;
			SolidBrush val3 = new SolidBrush(Color.FromArgb(20, 20, 20));
			rectangle = new Rectangle(1, 26, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 27);
			obj9.FillRectangle((Brush)val3, rectangle);
			Graphics obj10 = graphics_0;
			Pen val4 = new Pen((Brush)new SolidBrush(Color.FromArgb(40, 40, 40)));
			rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() + 25);
			obj10.DrawRectangle(val4, rectangle);
			Graphics obj11 = graphics_0;
			Pen val5 = new Pen((Brush)new SolidBrush(Color.FromArgb(40, 40, 40)));
			rectangle = new Rectangle(1, 26, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 28);
			obj11.DrawRectangle(val5, rectangle);
		}
	}
}
