using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns0;

internal sealed class Control0 : TabControl
{
	public GraphicsPath method_0(Rectangle rectangle_0, int int_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		int num = int_0 * 2;
		val.AddArc(new Rectangle(rectangle_0.X, rectangle_0.Y, num, num), -180f, 90f);
		val.AddArc(new Rectangle(rectangle_0.Width - num + rectangle_0.X, rectangle_0.Y, num, num), -90f, 90f);
		val.AddArc(new Rectangle(rectangle_0.Width - num + rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y, num, num), 0f, 90f);
		val.AddArc(new Rectangle(rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y, num, num), 90f, 90f);
		val.AddLine(new Point(rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y), new Point(rectangle_0.X, int_0 + rectangle_0.Y));
		return val;
	}

	public GraphicsPath method_1(int int_0, int int_1, int int_2, int int_3, int int_4)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		Rectangle rectangle = new Rectangle(int_0, int_1, int_2, int_3);
		GraphicsPath val = new GraphicsPath();
		int num = int_4 * 2;
		val.AddArc(new Rectangle(rectangle.X, rectangle.Y, num, num), -180f, 90f);
		val.AddArc(new Rectangle(rectangle.Width - num + rectangle.X, rectangle.Y, num, num), -90f, 90f);
		val.AddArc(new Rectangle(rectangle.Width - num + rectangle.X, rectangle.Height - num + rectangle.Y, num, num), 0f, 90f);
		val.AddArc(new Rectangle(rectangle.X, rectangle.Height - num + rectangle.Y, num, num), 90f, 90f);
		val.AddLine(new Point(rectangle.X, rectangle.Height - num + rectangle.Y), new Point(rectangle.X, int_4 + rectangle.Y));
		return val;
	}

	public Control0()
	{
		((Control)this).SetStyle((ControlStyles)73746, true);
		((Control)this).set_DoubleBuffered(true);
		((TabControl)this).set_SizeMode((TabSizeMode)2);
		((TabControl)this).set_ItemSize(new Size(35, 85));
	}

	protected override void vmethod_0()
	{
		((TabControl)this).CreateHandle();
		((TabControl)this).set_Alignment((TabAlignment)2);
	}

	public Pen method_2(Color color_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Pen(color_0);
	}

	public Brush method_3(Color color_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return (Brush)new SolidBrush(color_0);
	}

	protected override void vmethod_1(PaintEventArgs paintEventArgs_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_03cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3: Expected O, but got Unknown
		//IL_0429: Unknown result type (might be due to invalid IL or missing references)
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_0441: Expected O, but got Unknown
		//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Expected O, but got Unknown
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0551: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0569: Expected O, but got Unknown
		//IL_0569: Expected O, but got Unknown
		//IL_0597: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05dc: Expected O, but got Unknown
		//IL_05dc: Expected O, but got Unknown
		//IL_0606: Unknown result type (might be due to invalid IL or missing references)
		//IL_0633: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_064b: Expected O, but got Unknown
		//IL_064b: Expected O, but got Unknown
		//IL_0657: Unknown result type (might be due to invalid IL or missing references)
		//IL_067a: Expected O, but got Unknown
		//IL_074b: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a3: Expected O, but got Unknown
		//IL_07af: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f5: Expected O, but got Unknown
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_0810: Expected O, but got Unknown
		//IL_080b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected O, but got Unknown
		//IL_0840: Unknown result type (might be due to invalid IL or missing references)
		//IL_084a: Expected O, but got Unknown
		//IL_0845: Unknown result type (might be due to invalid IL or missing references)
		//IL_086e: Expected O, but got Unknown
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0886: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Font val3 = new Font(" ", 8f, (FontStyle)0);
		try
		{
			((Control)((TabControl)this).get_SelectedTab()).set_BackColor(Color.FromArgb(50, 50, 50));
		}
		catch
		{
		}
		val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(50, 50, 50)), new Rectangle(0, 0, ((TabControl)this).get_ItemSize().Height + 3, ((Control)this).get_Height() - 1));
		for (int i = 0; i <= ((TabControl)this).get_TabCount() - 1; i++)
		{
			if (i == ((TabControl)this).get_SelectedIndex())
			{
				Rectangle rectangle = new Rectangle(new Point(((TabControl)this).GetTabRect(i).Location.X - 2, ((TabControl)this).GetTabRect(i).Location.Y - 2), new Size(((TabControl)this).GetTabRect(i).Width + 3, ((TabControl)this).GetTabRect(i).Height - 1));
				ColorBlend val4 = new ColorBlend();
				val4.set_Positions(new float[3] { 0f, 0.5f, 1f });
				LinearGradientBrush val5 = new LinearGradientBrush(rectangle, Color.Black, Color.Black, 90f);
				val5.set_InterpolationColors(val4);
				val2.FillRectangle((Brush)(object)val5, rectangle);
				Rectangle rectangle_ = new Rectangle(((TabControl)this).GetTabRect(i).Location.X + 4, ((TabControl)this).GetTabRect(i).Location.Y + 2, ((TabControl)this).GetTabRect(i).Size.Width + 10, ((TabControl)this).GetTabRect(i).Size.Height - 11);
				val2.FillPath((Brush)new SolidBrush(Color.FromArgb(50, 50, 50)), method_0(rectangle_, 4));
				Color[] color_ = new Color[8]
				{
					Color.FromArgb(20, 20, 20),
					Color.FromArgb(40, 40, 40),
					Color.FromArgb(45, 45, 45),
					Color.FromArgb(46, 46, 46),
					Color.FromArgb(47, 47, 47),
					Color.FromArgb(48, 48, 48),
					Color.FromArgb(49, 49, 49),
					Color.FromArgb(50, 50, 50)
				};
				Class2.smethod_2(val2, new Rectangle(0, 0, ((TabControl)this).get_ItemSize().Height + 3, ((Control)this).get_Height() - 1), color_);
				Color[] color_2 = new Color[8]
				{
					Color.FromArgb(20, 20, 20),
					Color.FromArgb(40, 40, 40),
					Color.FromArgb(45, 45, 45),
					Color.FromArgb(46, 46, 46),
					Color.FromArgb(47, 47, 47),
					Color.FromArgb(48, 48, 48),
					Color.FromArgb(49, 49, 49),
					Color.FromArgb(50, 50, 50)
				};
				Class2.smethod_3(val2, rectangle_, 4, color_2);
				val2.set_SmoothingMode((SmoothingMode)2);
				if (((TabControl)this).get_ImageList() != null)
				{
					try
					{
						((TabControl)this).get_ImageList().get_Images().get_Item(((TabControl)this).get_TabPages().get_Item(i).get_ImageIndex());
					}
					catch (Exception)
					{
						string text = ((Control)((TabControl)this).get_TabPages().get_Item(i)).get_Text();
						Brush white = Brushes.get_White();
						RectangleF rectangleF = new Rectangle(rectangle.X, rectangle.Y - 1, rectangle.Width, rectangle.Height);
						StringFormat val6 = new StringFormat();
						val6.set_LineAlignment((StringAlignment)1);
						val6.set_Alignment((StringAlignment)1);
						val2.DrawString(text, val3, white, rectangleF, val6);
					}
				}
				else
				{
					string text2 = ((Control)((TabControl)this).get_TabPages().get_Item(i)).get_Text();
					Brush white2 = Brushes.get_White();
					RectangleF rectangleF2 = new Rectangle(rectangle.X, rectangle.Y - 1, rectangle.Width, rectangle.Height);
					StringFormat val7 = new StringFormat();
					val7.set_LineAlignment((StringAlignment)1);
					val7.set_Alignment((StringAlignment)1);
					val2.DrawString(text2, val3, white2, rectangleF2, val7);
				}
				val2.DrawLine(new Pen(Color.FromArgb(96, 110, 121)), new Point(rectangle.Location.X - 1, rectangle.Location.Y - 1), new Point(rectangle.Location.X, rectangle.Location.Y));
				val2.DrawLine(new Pen(Color.FromArgb(96, 110, 121)), new Point(rectangle.Location.X - 1, rectangle.Bottom - 1), new Point(rectangle.Location.X, rectangle.Bottom));
			}
			else
			{
				Rectangle rectangle2 = new Rectangle(new Point(((TabControl)this).GetTabRect(i).Location.X - 2, ((TabControl)this).GetTabRect(i).Location.Y - 2), new Size(((TabControl)this).GetTabRect(i).Width + 3, ((TabControl)this).GetTabRect(i).Height + 1));
				val2.DrawLine(new Pen(Color.FromArgb(96, 110, 121)), new Point(rectangle2.Right, rectangle2.Top), new Point(rectangle2.Right, rectangle2.Bottom));
				if (((TabControl)this).get_ImageList() != null)
				{
					try
					{
						string text3 = ((Control)((TabControl)this).get_TabPages().get_Item(i)).get_Text();
						SolidBrush val8 = new SolidBrush(Color.FromArgb(210, 220, 230));
						RectangleF rectangleF3 = new Rectangle(rectangle2.X, rectangle2.Y - 1, rectangle2.Width, rectangle2.Height);
						StringFormat val9 = new StringFormat();
						val9.set_LineAlignment((StringAlignment)1);
						val9.set_Alignment((StringAlignment)1);
						val2.DrawString(text3, val3, (Brush)val8, rectangleF3, val9);
					}
					catch (Exception)
					{
						string text4 = ((Control)((TabControl)this).get_TabPages().get_Item(i)).get_Text();
						SolidBrush val10 = new SolidBrush(Color.FromArgb(210, 220, 230));
						RectangleF rectangleF4 = new Rectangle(rectangle2.X, rectangle2.Y - 1, rectangle2.Width, rectangle2.Height);
						StringFormat val11 = new StringFormat();
						val11.set_LineAlignment((StringAlignment)1);
						val11.set_Alignment((StringAlignment)1);
						val2.DrawString(text4, val3, (Brush)val10, rectangleF4, val11);
					}
				}
				else
				{
					string text5 = ((Control)((TabControl)this).get_TabPages().get_Item(i)).get_Text();
					SolidBrush val12 = new SolidBrush(Color.FromArgb(210, 220, 230));
					RectangleF rectangleF5 = new Rectangle(rectangle2.X, rectangle2.Y - 1, rectangle2.Width, rectangle2.Height);
					StringFormat val13 = new StringFormat();
					val13.set_LineAlignment((StringAlignment)1);
					val13.set_Alignment((StringAlignment)1);
					val2.DrawString(text5, val3, (Brush)val12, rectangleF5, val13);
				}
			}
			val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(50, 50, 50)), new Rectangle(86, -1, ((Control)this).get_Width() - 86, ((Control)this).get_Height() + 1));
			Color[] color_3 = new Color[8]
			{
				Color.FromArgb(20, 20, 20),
				Color.FromArgb(40, 40, 40),
				Color.FromArgb(45, 45, 45),
				Color.FromArgb(46, 46, 46),
				Color.FromArgb(47, 47, 47),
				Color.FromArgb(48, 48, 48),
				Color.FromArgb(49, 49, 49),
				Color.FromArgb(50, 50, 50)
			};
			Class2.smethod_3(val2, new Rectangle(86, 0, ((Control)this).get_Width() - 87, ((Control)this).get_Height() - 1), 3, color_3);
		}
		val2.DrawRectangle(new Pen((Brush)new SolidBrush(Color.FromArgb(50, 50, 50))), new Rectangle(0, 0, ((TabControl)this).get_ItemSize().Height + 4, ((Control)this).get_Height() - 1));
		val2.DrawRectangle(new Pen((Brush)new SolidBrush(Color.FromArgb(20, 20, 20))), new Rectangle(1, 0, ((TabControl)this).get_ItemSize().Height + 3, ((Control)this).get_Height() - 2));
		paintEventArgs_0.get_Graphics().DrawImage((Image)((Image)val).Clone(), 0, 0);
		val2.Dispose();
		((Image)val).Dispose();
	}
}
