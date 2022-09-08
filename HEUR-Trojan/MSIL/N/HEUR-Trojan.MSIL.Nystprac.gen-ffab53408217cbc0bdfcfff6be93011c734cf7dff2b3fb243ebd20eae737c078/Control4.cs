using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class Control4 : Control2
{
	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	protected override void ColorHook()
	{
	}

	[SpecialName]
	public int method_82()
	{
		return int_2;
	}

	[SpecialName]
	public void method_83(int int_6)
	{
		if (int_6 < 1)
		{
			int_6 = 1;
		}
		if (int_6 < int_3)
		{
			int_3 = int_6;
		}
		int_2 = int_6;
		((Control)this).Invalidate();
	}

	[SpecialName]
	public int method_84()
	{
		return int_3;
	}

	[SpecialName]
	public void method_85(int int_6)
	{
		if (int_6 > int_2)
		{
			int_6 = method_82();
		}
		int_3 = int_6;
		((Control)this).Invalidate();
	}

	[SpecialName]
	public bool method_86()
	{
		return method_16();
	}

	[SpecialName]
	public void method_87(bool bool_6)
	{
		method_17(bool_6);
		((Control)this).Invalidate();
	}

	protected override void OnAnimation()
	{
		checked
		{
			int_4--;
			if (int_4 == 7)
			{
				int_4 = 0;
			}
		}
	}

	protected override void PaintHook()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_0385: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected O, but got Unknown
		HatchBrush val = new HatchBrush((HatchStyle)20, Color.FromArgb(60, Color.Black));
		graphics_0.Clear(Color.FromArgb(0, 30, 30, 30));
		ColorBlend val2 = new ColorBlend(2);
		ref Color reference = ref val2.get_Colors()[0];
		reference = Color.FromArgb(50, 50, 50);
		ref Color reference2 = ref val2.get_Colors()[1];
		reference2 = Color.FromArgb(70, 70, 70);
		val2.get_Positions()[0] = 0f;
		val2.get_Positions()[1] = 1f;
		checked
		{
			Rectangle rectangle_ = new Rectangle(0, 0, (int)Math.Round((double)((Control)this).get_Width() / (double)int_2 * (double)int_3 - 2.0), ((Control)this).get_Height() - 2);
			method_64(val2, rectangle_);
			ref Color reference3 = ref val2.get_Colors()[1];
			reference3 = Color.FromArgb(80, 80, 80);
			rectangle_ = new Rectangle(0, 0, (int)Math.Round((double)((Control)this).get_Width() / (double)int_2 * (double)int_3 - 2.0), (int)Math.Round((double)((Control)this).get_Height() / 5.0 * 2.0));
			method_64(val2, rectangle_);
			Graphics obj = graphics_0;
			Point renderingOrigin = new Point(int_4, 0);
			obj.set_RenderingOrigin(renderingOrigin);
			val = new HatchBrush((HatchStyle)2, Color.FromArgb(40, Color.Black), Color.FromArgb(0, Color.Gray));
			graphics_0.FillRectangle((Brush)(object)val, 0, 0, (int)Math.Round((double)((Control)this).get_Width() / (double)int_2 * (double)int_3 - 2.0), ((Control)this).get_Height() - 2);
			method_50(Pens.get_Black());
			method_47(new Pen(Color.FromArgb(90, 90, 90)), 1);
			method_44(Color.Black);
			graphics_0.DrawLine(new Pen(Color.FromArgb(200, 90, 90, 90)), (int)Math.Round((double)((Control)this).get_Width() / (double)int_2 * (double)int_3 - 2.0), 1, (int)Math.Round((double)((Control)this).get_Width() / (double)int_2 * (double)int_3 - 2.0), ((Control)this).get_Height() - 2);
			graphics_0.DrawLine(Pens.get_Black(), (int)Math.Round((double)((Control)this).get_Width() / (double)int_2 * (double)int_3 - 2.0) + 1, 2, (int)Math.Round((double)((Control)this).get_Width() / (double)int_2 * (double)int_3 - 2.0) + 1, ((Control)this).get_Height() - 3);
			int_5 = (int)Math.Round((double)((Control)this).get_Width() / (double)int_2 * (double)int_3);
			ColorBlend val3 = new ColorBlend(3);
			ref Color reference4 = ref val3.get_Colors()[0];
			reference4 = Color.FromArgb(0, Color.Gray);
			ref Color reference5 = ref val3.get_Colors()[1];
			reference5 = Color.FromArgb(80, Color.DimGray);
			ref Color reference6 = ref val3.get_Colors()[2];
			reference6 = Color.FromArgb(0, Color.Gray);
			val3.set_Positions(new float[3] { 0f, 0.5f, 1f });
			if (method_84() > 0)
			{
				graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(5, 5, 5)), (int)Math.Round((double)((Control)this).get_Width() / (double)int_2 * (double)int_3) - 1, 2, ((Control)this).get_Width() - (int)Math.Round((double)((Control)this).get_Width() / (double)int_2 * (double)int_3) - 1, ((Control)this).get_Height() - 4);
			}
		}
	}

	public Control4()
	{
		Class14.hYiyYvszsKHjE();
		base._002Ector();
		int_2 = 100;
		int_4 = 0;
		int_2 = 100;
		method_17(bool_6: true);
	}
}
