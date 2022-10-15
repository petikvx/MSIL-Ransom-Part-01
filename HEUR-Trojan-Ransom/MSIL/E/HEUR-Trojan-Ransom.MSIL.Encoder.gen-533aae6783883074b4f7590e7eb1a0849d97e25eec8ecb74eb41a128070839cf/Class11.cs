using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

internal class Class11 : ComboBox
{
	private static List<WeakReference> list_0;

	private int int_0;

	[DebuggerNonUserCode]
	static Class11()
	{
		Class14.vPNVHkezq0oMI();
		list_0 = new List<WeakReference>();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_0)
	{
		checked
		{
			lock (list_0)
			{
				if (list_0.Count == list_0.Capacity)
				{
					int num = 0;
					int num2 = list_0.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = list_0[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								list_0[num] = list_0[num3];
							}
							num++;
						}
						num3++;
					}
					list_0.RemoveRange(num, list_0.Count - num);
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_0)));
			}
		}
	}

	public Class11()
	{
		Class14.vPNVHkezq0oMI();
		((ComboBox)this)._002Ector();
		((Control)this).add_TextChanged((EventHandler)Class11_TextChanged);
		((ComboBox)this).add_DropDownClosed((EventHandler)Class11_DropDownClosed);
		smethod_0(this);
		((Control)this).SetStyle((ControlStyles)73746, true);
		((ComboBox)this).set_DrawMode((DrawMode)1);
		((ComboBox)this).set_ItemHeight(18);
		((ComboBox)this).set_BackColor(Color.FromArgb(20, 20, 20));
		((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		int_0 = e.get_X();
		((Control)this).Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((ComboBox)this).OnMouseLeave(e);
		int_0 = -1;
		((Control)this).Invalidate();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0173: Expected O, but got Unknown
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Invalid comparison between Unknown and I4
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_0241: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Expected O, but got Unknown
		if ((int)((ComboBox)this).get_DropDownStyle() != 2)
		{
			((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
		}
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.Clear(Color.FromArgb(20, 20, 20));
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), (int)Math.Round((double)((Control)this).get_Height() / 5.0 * 2.0));
			LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(20, 0, 0, 0), Color.FromArgb(15, Color.White), 90f);
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), (int)Math.Round((double)((Control)this).get_Height() / 5.0 * 2.0));
			val2.FillRectangle((Brush)(object)val3, rectangle);
			HatchBrush val4 = new HatchBrush((HatchStyle)21, Color.FromArgb(20, Color.Black), Color.FromArgb(0, Color.Gray));
			val2.FillRectangle((Brush)(object)val4, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
			int num = (int)Math.Round(val2.MeasureString("OrainsComboBox", ((Control)this).get_Font()).Height);
			if (((ComboBox)this).get_SelectedIndex() != -1)
			{
				val2.DrawString(Conversions.ToString(((ComboBox)this).get_Items().get_Item(((ComboBox)this).get_SelectedIndex())), ((Control)this).get_Font(), (Brush)new SolidBrush(Color.Orange), 4f, (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(num / 2)));
			}
			else if ((((ComboBox)this).get_Items() != null) & (((ComboBox)this).get_Items().get_Count() > 0))
			{
				val2.DrawString(Conversions.ToString(((ComboBox)this).get_Items().get_Item(0)), ((Control)this).get_Font(), (Brush)new SolidBrush(Color.Orange), 4f, (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(num / 2)));
			}
			else
			{
				val2.DrawString("OrainsComboBox", ((Control)this).get_Font(), (Brush)new SolidBrush(Color.Orange), 4f, (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(num / 2)));
			}
			if ((unchecked((int)Control.get_MouseButtons()) == 0) & (int_0 > ((Control)this).get_Width() - 25))
			{
				val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(7, Color.White)), 2, 1, ((Control)this).get_Width() - 5, ((Control)this).get_Height() - 3);
			}
			val2.DrawRectangle(Pens.get_Black(), 0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			val2.DrawRectangle(new Pen(Color.FromArgb(40, 40, 40)), 1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
			Brush black = Brushes.get_Black();
			Point point = new Point(((Control)this).get_Width() - 14, unchecked(((Control)this).get_Height() / 2));
			Point point_ = point;
			Size size_ = new Size(5, 3);
			val2.FillPolygon(black, method_0(point_, size_));
			Brush white = Brushes.get_White();
			point = new Point(((Control)this).get_Width() - 15, unchecked(((Control)this).get_Height() / 2) - 1);
			Point point_2 = point;
			size_ = new Size(5, 3);
			val2.FillPolygon(white, method_0(point_2, size_));
			NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "DrawImage", new object[3]
			{
				RuntimeHelpers.GetObjectValue(((Image)val).Clone()),
				0,
				0
			}, (string[])null, (Type[])null, (bool[])null, true);
			val2.Dispose();
			((Image)val).Dispose();
		}
	}

	protected override void OnDrawItem(DrawItemEventArgs e)
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Invalid comparison between Unknown and I4
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Invalid comparison between Unknown and I4
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019f: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d2: Expected O, but got Unknown
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		checked
		{
			if (e.get_Index() >= 0)
			{
				Rectangle rectangle = default(Rectangle);
				rectangle.X = e.get_Bounds().X;
				rectangle.Y = e.get_Bounds().Y;
				rectangle.Width = e.get_Bounds().Width - 1;
				rectangle.Height = e.get_Bounds().Height - 1;
				e.DrawBackground();
				if (unchecked(((int)e.get_State() == 785) | ((int)e.get_State() == 17)))
				{
					e.get_Graphics().FillRectangle((Brush)new SolidBrush(((ComboBox)this).get_BackColor()), e.get_Bounds());
					Point location = e.get_Bounds().Location;
					Size size = new Size(e.get_Bounds().Width + 2, e.get_Bounds().Height);
					Rectangle rectangle2 = new Rectangle(location, size);
					Point location2 = rectangle2.Location;
					size = new Size(rectangle2.Width, (int)Math.Round((double)rectangle2.Height / 2.0 - 1.0));
					Rectangle rectangle3 = new Rectangle(location2, size);
					Point point = new Point(rectangle2.X, rectangle2.Y);
					Point point2 = new Point(rectangle2.X, rectangle2.Y + rectangle2.Height);
					LinearGradientBrush val = new LinearGradientBrush(point, point2, Color.FromArgb(255, 128, 0), Color.FromArgb(153, 76, 0));
					HatchBrush val2 = new HatchBrush((HatchStyle)21, Color.FromArgb(15, Color.Black), Color.Transparent);
					e.get_Graphics().FillRectangle((Brush)(object)val, rectangle2);
					((Brush)val).Dispose();
					e.get_Graphics().FillRectangle((Brush)new SolidBrush(Color.FromArgb(25, Color.White)), rectangle3);
					e.get_Graphics().FillRectangle((Brush)(object)val2, rectangle2);
					((Brush)val).Dispose();
					e.get_Graphics().DrawString(" " + ((ComboBox)this).get_Items().get_Item(e.get_Index()).ToString(), ((Control)this).get_Font(), Brushes.get_Black(), (float)e.get_Bounds().X, (float)(e.get_Bounds().Y + 1));
				}
				else
				{
					e.get_Graphics().FillRectangle((Brush)new SolidBrush(((ComboBox)this).get_BackColor()), e.get_Bounds());
					e.get_Graphics().DrawString(" " + ((ComboBox)this).get_Items().get_Item(e.get_Index()).ToString(), ((Control)this).get_Font(), Brushes.get_Orange(), (float)e.get_Bounds().X, (float)(e.get_Bounds().Y + 1));
				}
				((ComboBox)this).OnDrawItem(e);
			}
		}
	}

	public Point[] method_0(Point point_0, Size size_0)
	{
		checked
		{
			return new Point[4]
			{
				point_0,
				new Point(point_0.X + size_0.Width, point_0.Y),
				new Point(point_0.X + unchecked(size_0.Width / 2), point_0.Y + size_0.Height),
				point_0
			};
		}
	}

	private void Class11_DropDownClosed(object sender, EventArgs e)
	{
		((ComboBox)this).set_DropDownStyle((ComboBoxStyle)0);
		Application.DoEvents();
		((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
	}

	private void Class11_TextChanged(object sender, EventArgs e)
	{
		((Control)this).Invalidate();
	}
}
