using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

public class GClass6 : ComboBox
{
	private int int_0;

	private Color color_0;

	private Color color_1;

	public int Int32_0
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			try
			{
				((ComboBox)this).set_SelectedIndex(value);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				for (int num = 0; num == 0; num = 1)
				{
					ProjectData.ClearProjectError();
				}
			}
			((Control)this).Invalidate();
		}
	}

	public GClass6()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		if (1 == 0)
		{
		}
		((ComboBox)this)._002Ector();
		((ComboBox)this).add_DrawItem(new DrawItemEventHandler(GClass6_DrawItem));
		int_0 = 0;
		color_0 = Color.FromArgb(37, 37, 37);
		color_1 = Color.FromArgb(60, 60, 60);
		((Control)this).SetStyle((ControlStyles)73746, true);
		((ComboBox)this).set_DrawMode((DrawMode)1);
		((ComboBox)this).set_BackColor(Color.FromArgb(45, 45, 45));
		((ComboBox)this).set_ForeColor(Color.White);
		((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		int num = 0;
		checked
		{
			LinearGradientBrush val = default(LinearGradientBrush);
			Graphics graphics = default(Graphics);
			Rectangle rectangle = default(Rectangle);
			while (true)
			{
				switch (num)
				{
				case 2:
					val = new LinearGradientBrush(rectangle, Color.FromArgb(62, Color.White), Color.FromArgb(30, Color.White), 90f);
					num = 3;
					continue;
				case 1:
					rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), 10);
					num = 2;
					continue;
				case 0:
					graphics = e.get_Graphics();
					num = 1;
					continue;
				}
				new SolidBrush(Color.FromArgb(37, 37, 37));
				try
				{
					Graphics val2 = graphics;
					int num2 = 0;
					while (true)
					{
						switch (num2)
						{
						case 11:
							val2 = null;
							num2 = 12;
							break;
						case 10:
						{
							Color white2 = Color.White;
							Point point = new Point(((Control)this).get_Width() - 15, 8);
							Point point_ = point;
							Point point_2 = new Point(((Control)this).get_Width() - 7, 8);
							Point point_3 = new Point(((Control)this).get_Width() - 11, 13);
							method_0(white2, point_, point_2, point_3, graphics);
							num2 = 11;
							break;
						}
						case 9:
							val2.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(70, 70, 70))), 0, ((Control)this).get_Height() - 1, ((Control)this).get_Width(), ((Control)this).get_Height() - 1);
							num2 = 10;
							break;
						case 8:
							val2.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), ((Control)this).get_Width() - 1, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height());
							num2 = 9;
							break;
						case 7:
							val2.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, 0, ((Control)this).get_Height());
							num2 = 8;
							break;
						case 6:
							val2.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, ((Control)this).get_Width(), 0);
							num2 = 7;
							break;
						case 5:
						{
							Graphics obj4 = val2;
							Pen val3 = new Pen((Brush)new SolidBrush(Color.FromArgb(0, 0, 0)));
							rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
							obj4.DrawRectangle(val3, rectangle);
							num2 = 6;
							break;
						}
						case 4:
							val2.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(37, 37, 37))), 0, 0, 0, 0);
							num2 = 5;
							break;
						case 3:
						{
							Graphics obj3 = val2;
							string? text = ((ComboBox)this).get_Items().get_Item(((ComboBox)this).get_SelectedIndex()).ToString();
							Font font = ((Control)this).get_Font();
							Brush white = Brushes.get_White();
							Point point = new Point(3, 3);
							obj3.DrawString(text, font, white, (PointF)point);
							num2 = 4;
							break;
						}
						case 2:
						{
							Graphics obj = val2;
							LinearGradientBrush obj2 = val;
							rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), 9);
							obj.FillRectangle((Brush)(object)obj2, rectangle);
							num2 = 3;
							break;
						}
						case 1:
							val2.Clear(Color.FromArgb(37, 37, 37));
							num2 = 2;
							break;
						case 0:
							graphics.set_SmoothingMode((SmoothingMode)2);
							num2 = 1;
							break;
						default:
							return;
						}
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					for (int num3 = 0; num3 == 0; num3 = 1)
					{
						ProjectData.ClearProjectError();
					}
					return;
				}
			}
		}
	}

	public void GClass6_DrawItem(object sender, DrawItemEventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		e.DrawBackground();
		try
		{
			if ((e.get_State() & 1) == 1)
			{
				e.get_Graphics().FillRectangle((Brush)new SolidBrush(Color.FromArgb(37, 37, 37)), e.get_Bounds());
			}
			SolidBrush val = new SolidBrush(e.get_ForeColor());
			try
			{
				e.get_Graphics().DrawString(((ListControl)this).GetItemText(RuntimeHelpers.GetObjectValue(((ComboBox)this).get_Items().get_Item(e.get_Index()))), e.get_Font(), (Brush)(object)val, (RectangleF)e.get_Bounds());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			for (int num = 0; num == 0; num = 1)
			{
				ProjectData.ClearProjectError();
			}
		}
		e.DrawFocusRectangle();
	}

	protected void method_0(Color color_2, Point point_0, Point point_1, Point point_2, Graphics graphics_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		List<Point> list = new List<Point>();
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 3:
				graphics_0.FillPolygon((Brush)new SolidBrush(color_2), list.ToArray());
				num = 4;
				break;
			case 2:
				list.Add(point_2);
				num = 3;
				break;
			case 1:
				list.Add(point_1);
				num = 2;
				break;
			case 0:
				list.Add(point_0);
				num = 1;
				break;
			default:
				return;
			}
		}
	}
}
