using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class Control3 : Control2
{
	private bool bool_6;

	private Color color_0;

	private int int_2;

	protected override void ColorHook()
	{
	}

	protected override void OnAnimation()
	{
		base.OnAnimation();
		checked
		{
			switch (enum0_0)
			{
			case (Enum0)0:
				if (int_2 > 0)
				{
					int_2 -= 5;
					if (int_2 < 0)
					{
						int_2 = 0;
					}
					((Control)this).Invalidate();
					Application.DoEvents();
				}
				break;
			case (Enum0)1:
				if (int_2 < 20)
				{
					int_2 += 5;
					((Control)this).Invalidate();
					Application.DoEvents();
				}
				break;
			}
		}
	}

	[SpecialName]
	public bool method_82()
	{
		return bool_6;
	}

	[SpecialName]
	public void method_83(bool bool_7)
	{
		bool_6 = bool_7;
	}

	[SpecialName]
	public Color method_84()
	{
		return color_0;
	}

	[SpecialName]
	public void method_85(Color color_1)
	{
		color_0 = color_1;
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		Graphics val = ((Control)this).CreateGraphics();
		((Control)this).CreateGraphics().MeasureString(Text, Font);
		string text = Text;
		Font font = Font;
		Brush white = Brushes.get_White();
		RectangleF rectangleF = new RectangleF(0f, 0f, ((Control)this).get_Width(), ((Control)this).get_Height());
		val.DrawString(text, font, white, rectangleF);
	}

	protected override void PaintHook()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_041c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Expected O, but got Unknown
		graphics_0.Clear(color_0);
		checked
		{
			if (enum0_0 == (Enum0)1)
			{
				ColorBlend val = new ColorBlend(2);
				ref Color reference = ref val.get_Colors()[0];
				reference = Color.FromArgb(200, 50, 50, 50);
				ref Color reference2 = ref val.get_Colors()[1];
				reference2 = Color.FromArgb(200, 70, 70, 70);
				val.get_Positions()[0] = 0f;
				val.get_Positions()[1] = 1f;
				Rectangle rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				method_64(val, rectangle_);
				ref Color reference3 = ref val.get_Colors()[0];
				reference3 = Color.FromArgb(0, 0, 0, 0);
				ref Color reference4 = ref val.get_Colors()[1];
				reference4 = Color.FromArgb(40, Color.White);
				if (bool_6)
				{
					rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width(), (int)Math.Round((double)((Control)this).get_Height() / 5.0 * 2.0));
					method_64(val, rectangle_);
				}
			}
			else if (enum0_0 == (Enum0)0)
			{
				ColorBlend val2 = new ColorBlend(2);
				ref Color reference5 = ref val2.get_Colors()[0];
				reference5 = Color.FromArgb(200, 50, 50, 50);
				ref Color reference6 = ref val2.get_Colors()[1];
				reference6 = Color.FromArgb(200, 70, 70, 70);
				val2.get_Positions()[0] = 0f;
				val2.get_Positions()[1] = 1f;
				Rectangle rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				method_64(val2, rectangle_);
				ref Color reference7 = ref val2.get_Colors()[0];
				reference7 = Color.FromArgb(0, 0, 0, 0);
				ref Color reference8 = ref val2.get_Colors()[1];
				reference8 = Color.FromArgb(40, Color.White);
				if (bool_6)
				{
					rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width(), (int)Math.Round((double)((Control)this).get_Height() / 5.0 * 2.0));
					method_64(val2, rectangle_);
				}
			}
			else
			{
				ColorBlend val3 = new ColorBlend(2);
				ref Color reference9 = ref val3.get_Colors()[0];
				reference9 = Color.FromArgb(200, 30, 30, 30);
				ref Color reference10 = ref val3.get_Colors()[1];
				reference10 = Color.FromArgb(200, 50, 50, 50);
				val3.get_Positions()[0] = 0f;
				val3.get_Positions()[1] = 1f;
				Rectangle rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
				method_64(val3, rectangle_);
				ref Color reference11 = ref val3.get_Colors()[0];
				reference11 = Color.FromArgb(0, 0, 0, 0);
				ref Color reference12 = ref val3.get_Colors()[1];
				reference12 = Color.FromArgb(40, Color.White);
				if (bool_6)
				{
					rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width(), (int)Math.Round((double)((Control)this).get_Height() / 5.0 * 2.0));
					method_64(val3, rectangle_);
				}
			}
			graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(int_2, Color.White)), 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
			HatchBrush val4 = new HatchBrush((HatchStyle)20, Color.FromArgb(25, Color.Black), Color.FromArgb(0, Color.Gray));
			graphics_0.FillRectangle((Brush)(object)val4, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
			((Control)this).CreateGraphics().MeasureString(Text, Font, ((Control)this).get_Width() - 4);
			StringFormat val5 = new StringFormat();
			val5.set_LineAlignment((StringAlignment)1);
			val5.set_Alignment((StringAlignment)1);
			Graphics obj = graphics_0;
			string text = Text;
			Font font = Font;
			Brush white = Brushes.get_White();
			RectangleF rectangleF = new RectangleF(2f, 2f, ((Control)this).get_Width() - 5, ((Control)this).get_Height() - 4);
			obj.DrawString(text, font, white, rectangleF, val5);
			method_50(Pens.get_Black());
			method_47(new Pen(Color.FromArgb(90, 90, 90)), 1);
		}
	}

	public Control3()
	{
		Class14.hYiyYvszsKHjE();
		base._002Ector();
		bool_6 = true;
		int_2 = 0;
		method_17(bool_6: true);
	}
}
