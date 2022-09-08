using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

internal class Control10 : Control2
{
	private int xKiesuOrHS;

	private Color color_0;

	private Color color_1;

	private Pen pen_0;

	protected override void ColorHook()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		color_0 = method_21("Background");
		color_1 = method_21("Edge color");
		pen_0 = new Pen(method_21("Button edge color"));
	}

	public Control10()
	{
		Class14.hYiyYvszsKHjE();
		base._002Ector();
		method_22("Background", Color.FromArgb(64, 64, 64));
		method_22("Edge color", Color.Black);
		method_22("Button edge color", Color.FromArgb(90, 90, 90));
		Size size = new Size(71, 19);
		((Control)this).set_Size(size);
		((Control)this).set_Anchor((AnchorStyles)9);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		xKiesuOrHS = e.get_X();
		((Control)this).Invalidate();
	}

	protected override void OnClick(EventArgs e)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Invalid comparison between Unknown and I4
		((Control)this).OnClick(e);
		if (xKiesuOrHS <= 22)
		{
			((Control)this).FindForm().set_WindowState((FormWindowState)1);
		}
		else if ((xKiesuOrHS > 22) & (xKiesuOrHS <= 44))
		{
			if ((int)((Control)this).FindForm().get_WindowState() != 2)
			{
				((Control)this).FindForm().set_WindowState((FormWindowState)2);
			}
			else
			{
				((Control)this).FindForm().set_WindowState((FormWindowState)0);
			}
		}
		else if (xKiesuOrHS > 44)
		{
			((Control)this).FindForm().Close();
		}
	}

	protected override void PaintHook()
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Invalid comparison between Unknown and I4
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_02d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Expected O, but got Unknown
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b3: Expected O, but got Unknown
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_0467: Expected O, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b6: Expected O, but got Unknown
		graphics_0.Clear(color_1);
		Point point = new Point(1, 1);
		Point location = point;
		checked
		{
			Size size = new Size(((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
			Rectangle rectangle = new Rectangle(location, size);
			LinearGradientBrush val = new LinearGradientBrush(rectangle, color_0, Color.FromArgb(30, 30, 30), 90f);
			Graphics obj = graphics_0;
			point = new Point(1, 1);
			Point location2 = point;
			size = new Size(((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
			rectangle = new Rectangle(location2, size);
			obj.FillRectangle((Brush)(object)val, rectangle);
			Graphics obj2 = graphics_0;
			Font val2 = new Font("Marlett", 8.25f);
			Brush white = Brushes.get_White();
			point = new Point(5, 5);
			obj2.DrawString("0", val2, white, (PointF)point);
			if (unchecked((int)((Control)this).FindForm().get_WindowState()) != 2)
			{
				Graphics obj3 = graphics_0;
				Font val3 = new Font("Marlett", 8.25f);
				Brush white2 = Brushes.get_White();
				point = new Point(27, 4);
				obj3.DrawString("1", val3, white2, (PointF)point);
			}
			else
			{
				Graphics obj4 = graphics_0;
				Font val4 = new Font("Marlett", 8.25f);
				Brush white3 = Brushes.get_White();
				point = new Point(27, 4);
				obj4.DrawString("2", val4, white3, (PointF)point);
			}
			Graphics obj5 = graphics_0;
			Font val5 = new Font("Marlett", 10f);
			Brush white4 = Brushes.get_White();
			point = new Point(49, 3);
			obj5.DrawString("r", val5, white4, (PointF)point);
			ColorBlend val6 = new ColorBlend(2);
			val6.set_Colors(new Color[2]
			{
				Color.FromArgb(100, Color.Black),
				Color.Transparent
			});
			val6.set_Positions(new float[2] { 0f, 1f });
			point = new Point(1, 8);
			Point location3 = point;
			size = new Size(68, 8);
			rectangle = new Rectangle(location3, size);
			method_65(val6, rectangle, 90f);
			Graphics obj6 = graphics_0;
			Pen obj7 = pen_0;
			point = new Point(1, 1);
			Point location4 = point;
			size = new Size(20, 16);
			rectangle = new Rectangle(location4, size);
			obj6.DrawRectangle(obj7, rectangle);
			Graphics obj8 = graphics_0;
			Pen obj9 = pen_0;
			point = new Point(23, 1);
			Point location5 = point;
			size = new Size(20, 16);
			rectangle = new Rectangle(location5, size);
			obj8.DrawRectangle(obj9, rectangle);
			Graphics obj10 = graphics_0;
			Pen obj11 = pen_0;
			point = new Point(45, 1);
			Point location6 = point;
			size = new Size(24, 16);
			rectangle = new Rectangle(location6, size);
			obj10.DrawRectangle(obj11, rectangle);
			switch (enum0_0)
			{
			case (Enum0)1:
				if (xKiesuOrHS <= 22)
				{
					Graphics obj15 = graphics_0;
					SolidBrush val10 = new SolidBrush(Color.FromArgb(20, Color.White));
					point = new Point(1, 1);
					Point location10 = point;
					size = new Size(21, ((Control)this).get_Height() - 2);
					rectangle = new Rectangle(location10, size);
					obj15.FillRectangle((Brush)val10, rectangle);
				}
				else if ((xKiesuOrHS > 22) & (xKiesuOrHS <= 44))
				{
					Graphics obj16 = graphics_0;
					SolidBrush val11 = new SolidBrush(Color.FromArgb(20, Color.White));
					point = new Point(23, 1);
					Point location11 = point;
					size = new Size(21, ((Control)this).get_Height() - 2);
					rectangle = new Rectangle(location11, size);
					obj16.FillRectangle((Brush)val11, rectangle);
				}
				else if (xKiesuOrHS > 44)
				{
					Graphics obj17 = graphics_0;
					SolidBrush val12 = new SolidBrush(Color.FromArgb(20, Color.White));
					point = new Point(45, 1);
					Point location12 = point;
					size = new Size(25, ((Control)this).get_Height() - 2);
					rectangle = new Rectangle(location12, size);
					obj17.FillRectangle((Brush)val12, rectangle);
				}
				break;
			case (Enum0)2:
				if (xKiesuOrHS <= 22)
				{
					Graphics obj12 = graphics_0;
					SolidBrush val7 = new SolidBrush(Color.FromArgb(20, Color.Black));
					point = new Point(1, 1);
					Point location7 = point;
					size = new Size(21, ((Control)this).get_Height() - 2);
					rectangle = new Rectangle(location7, size);
					obj12.FillRectangle((Brush)val7, rectangle);
				}
				else if ((xKiesuOrHS > 22) & (xKiesuOrHS <= 44))
				{
					Graphics obj13 = graphics_0;
					SolidBrush val8 = new SolidBrush(Color.FromArgb(20, Color.Black));
					point = new Point(23, 1);
					Point location8 = point;
					size = new Size(21, ((Control)this).get_Height() - 2);
					rectangle = new Rectangle(location8, size);
					obj13.FillRectangle((Brush)val8, rectangle);
				}
				else if (xKiesuOrHS > 44)
				{
					Graphics obj14 = graphics_0;
					SolidBrush val9 = new SolidBrush(Color.FromArgb(20, Color.Black));
					point = new Point(45, 1);
					Point location9 = point;
					size = new Size(25, ((Control)this).get_Height() - 2);
					rectangle = new Rectangle(location9, size);
					obj14.FillRectangle((Brush)val9, rectangle);
				}
				break;
			}
		}
	}
}
