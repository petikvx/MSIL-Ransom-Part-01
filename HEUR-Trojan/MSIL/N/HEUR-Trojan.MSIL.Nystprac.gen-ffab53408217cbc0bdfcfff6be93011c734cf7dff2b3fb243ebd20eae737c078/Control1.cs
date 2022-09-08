using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class Control1 : Control0
{
	private bool bool_16;

	protected override void ColorHook()
	{
	}

	[SpecialName]
	public bool method_108()
	{
		return bool_16;
	}

	[SpecialName]
	public void method_109(bool bool_17)
	{
		bool_16 = bool_17;
		((Control)this).Invalidate();
	}

	protected override void PaintHook()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0315: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_047b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected O, but got Unknown
		graphics_0.Clear(Color.DimGray);
		ColorBlend val = new ColorBlend(2);
		method_72(Pens.get_Gray(), 1);
		ref Color reference = ref val.get_Colors()[0];
		reference = Color.DimGray;
		ref Color reference2 = ref val.get_Colors()[1];
		reference2 = Color.FromArgb(60, 60, 60);
		val.get_Positions()[0] = 0f;
		val.get_Positions()[1] = 1f;
		Rectangle rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width(), 24);
		method_90(val, rectangle_);
		ref Color reference3 = ref val.get_Colors()[0];
		reference3 = Color.FromArgb(100, 100, 100);
		ref Color reference4 = ref val.get_Colors()[1];
		reference4 = Color.DimGray;
		rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width(), 12);
		method_90(val, rectangle_);
		HatchBrush val2 = new HatchBrush((HatchStyle)20, Color.FromArgb(15, Color.Black), Color.FromArgb(0, Color.Gray));
		ref Color reference5 = ref val.get_Colors()[0];
		reference5 = Color.FromArgb(120, Color.Black);
		ref Color reference6 = ref val.get_Colors()[1];
		reference6 = Color.FromArgb(0, Color.Black);
		rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width(), 30);
		method_90(val, rectangle_);
		graphics_0.FillRectangle((Brush)(object)val2, 0, 0, ((Control)this).get_Width(), 24);
		checked
		{
			graphics_0.DrawLine(Pens.get_Black(), 6, 24, ((Control)this).get_Width() - 7, 24);
			graphics_0.DrawLine(Pens.get_Black(), 6, 24, 6, ((Control)this).get_Height() - 7);
			graphics_0.DrawLine(Pens.get_Black(), 6, ((Control)this).get_Height() - 7, ((Control)this).get_Width() - 7, ((Control)this).get_Height() - 7);
			graphics_0.DrawLine(Pens.get_Black(), ((Control)this).get_Width() - 7, 24, ((Control)this).get_Width() - 7, ((Control)this).get_Height() - 7);
			Graphics obj = graphics_0;
			SolidBrush val3 = new SolidBrush(Color.FromArgb(60, 60, 60));
			rectangle_ = new Rectangle(1, 24, 5, ((Control)this).get_Height() - 6 - 24);
			obj.FillRectangle((Brush)val3, rectangle_);
			graphics_0.FillRectangle((Brush)(object)val2, 1, 24, 5, ((Control)this).get_Height() - 6 - 24);
			Graphics obj2 = graphics_0;
			SolidBrush val4 = new SolidBrush(Color.FromArgb(60, 60, 60));
			rectangle_ = new Rectangle(((Control)this).get_Width() - 6, 24, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 6 - 24);
			obj2.FillRectangle((Brush)val4, rectangle_);
			graphics_0.FillRectangle((Brush)(object)val2, ((Control)this).get_Width() - 6, 24, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 6 - 24);
			Graphics obj3 = graphics_0;
			SolidBrush val5 = new SolidBrush(Color.FromArgb(60, 60, 60));
			rectangle_ = new Rectangle(1, ((Control)this).get_Height() - 6, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 1);
			obj3.FillRectangle((Brush)val5, rectangle_);
			graphics_0.FillRectangle((Brush)(object)val2, 1, ((Control)this).get_Height() - 6, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 1);
			method_75(Pens.get_Black());
			val2 = new HatchBrush((HatchStyle)18, Color.DimGray);
			graphics_0.FillRectangle((Brush)(object)val2, 7, 25, ((Control)this).get_Width() - 14, ((Control)this).get_Height() - 24 - 8);
			graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(230, 20, 20, 20)), 7, 25, ((Control)this).get_Width() - 14, ((Control)this).get_Height() - 24 - 8);
			method_69(Color.Fuchsia);
			method_71(Color.Fuchsia, 0, 1, 1, 1);
			method_71(Color.Fuchsia, 1, 0, 1, 1);
			method_65(Color.Black, 1, 1);
			method_71(Color.Fuchsia, 0, ((Control)this).get_Height() - 2, 1, 1);
			method_71(Color.Fuchsia, 1, ((Control)this).get_Height() - 1, 1, 1);
			method_65(Color.Black, ((Control)this).get_Width() - 2, 1);
			method_71(Color.Fuchsia, ((Control)this).get_Width() - 1, 1, 1, 1);
			method_71(Color.Fuchsia, ((Control)this).get_Width() - 2, 0, 1, 1);
			method_65(Color.Black, 1, ((Control)this).get_Height() - 2);
			method_71(Color.Fuchsia, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2, 1, 1);
			method_71(Color.Fuchsia, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 1, 1, 1);
			method_65(Color.Black, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
			ColorBlend val6 = new ColorBlend(2);
			ref Color reference7 = ref val6.get_Colors()[0];
			reference7 = Color.FromArgb(35, Color.Black);
			ref Color reference8 = ref val6.get_Colors()[1];
			reference8 = Color.FromArgb(0, 0, 0, 0);
			val6.get_Positions()[0] = 0f;
			val6.get_Positions()[1] = 1f;
			method_89(val6, 7, 25, 15, ((Control)this).get_Height() - 6 - 24, 0f);
			ref Color reference9 = ref val6.get_Colors()[0];
			reference9 = Color.FromArgb(0, 0, 0, 0);
			ref Color reference10 = ref val6.get_Colors()[1];
			reference10 = Color.FromArgb(35, Color.Black);
			method_89(val6, ((Control)this).get_Width() - 24, 25, 17, ((Control)this).get_Height() - 6 - 24, 0f);
			ref Color reference11 = ref val6.get_Colors()[1];
			reference11 = Color.FromArgb(0, 0, 0, 0);
			ref Color reference12 = ref val6.get_Colors()[0];
			reference12 = Color.FromArgb(35, Color.Black);
			method_89(val6, 7, 25, ((Control)this).get_Width() - 14, 17, 90f);
			ref Color reference13 = ref val6.get_Colors()[0];
			reference13 = Color.FromArgb(0, 0, 0, 0);
			ref Color reference14 = ref val6.get_Colors()[1];
			reference14 = Color.FromArgb(35, Color.Black);
			method_89(val6, 8, ((Control)this).get_Height() - 24, ((Control)this).get_Width() - 14, 17, 90f);
			Point point;
			if (!bool_16)
			{
				Graphics obj4 = graphics_0;
				string text = Text;
				Font font = Font;
				Brush white = Brushes.get_White();
				point = new Point(6, 6);
				obj4.DrawString(text, font, white, (PointF)point);
				return;
			}
			Graphics obj5 = graphics_0;
			Icon icon = ((Control)this).FindForm().get_Icon();
			point = new Point(9, 5);
			Point location = point;
			Size size = new Size(16, 16);
			rectangle_ = new Rectangle(location, size);
			obj5.DrawIcon(icon, rectangle_);
			Graphics obj6 = graphics_0;
			string text2 = Text;
			Font font2 = Font;
			Brush white2 = Brushes.get_White();
			point = new Point(28, 6);
			obj6.DrawString(text2, font2, white2, (PointF)point);
		}
	}

	public Control1()
	{
		Class14.hYiyYvszsKHjE();
		base._002Ector();
		method_14(Color.Fuchsia);
	}
}
