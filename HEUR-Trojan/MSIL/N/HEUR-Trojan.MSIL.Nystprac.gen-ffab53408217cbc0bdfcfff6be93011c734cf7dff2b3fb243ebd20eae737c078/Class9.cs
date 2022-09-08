using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

internal class Class9 : ComboBox
{
	private static List<WeakReference> list_0;

	private int int_0;

	[DebuggerNonUserCode]
	static Class9()
	{
		Class14.hYiyYvszsKHjE();
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

	public Class9()
	{
		Class14.hYiyYvszsKHjE();
		((ComboBox)this)._002Ector();
		((ComboBox)this).add_DropDownClosed((EventHandler)Class9_DropDownClosed);
		((Control)this).add_TextChanged((EventHandler)Class9_TextChanged);
		smethod_0(this);
		((Control)this).SetStyle((ControlStyles)73746, true);
		((ComboBox)this).set_DrawMode((DrawMode)1);
		((ComboBox)this).set_ItemHeight(20);
		((ComboBox)this).set_BackColor(Color.FromArgb(30, 30, 30));
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
		//IL_0027: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Expected O, but got Unknown
		//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ff: Invalid comparison between Unknown and I4
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Invalid comparison between Unknown and I4
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0310: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Expected O, but got Unknown
		if ((int)((ComboBox)this).get_DropDownStyle() != 2)
		{
			((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
		}
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.Clear(Color.FromArgb(50, 50, 50));
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), (int)Math.Round((double)((Control)this).get_Height() / 5.0 * 2.0));
			LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(20, 0, 0, 0), Color.FromArgb(15, Color.White), 90f);
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), (int)Math.Round((double)((Control)this).get_Height() / 5.0 * 2.0));
			val2.FillRectangle((Brush)(object)val3, rectangle);
			HatchBrush val4 = new HatchBrush((HatchStyle)20, Color.FromArgb(20, Color.Black), Color.FromArgb(0, Color.Gray));
			val2.FillRectangle((Brush)(object)val4, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
			int num = (int)Math.Round(val2.MeasureString("...", ((Control)this).get_Font()).Height);
			if (((ComboBox)this).get_SelectedIndex() != -1)
			{
				val2.DrawString(Conversions.ToString(((ComboBox)this).get_Items().get_Item(((ComboBox)this).get_SelectedIndex())), ((Control)this).get_Font(), (Brush)new SolidBrush(Color.White), 4f, (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(num / 2)));
			}
			else if ((((ComboBox)this).get_Items() != null) & (((ComboBox)this).get_Items().get_Count() > 0))
			{
				val2.DrawString(Conversions.ToString(((ComboBox)this).get_Items().get_Item(0)), ((Control)this).get_Font(), (Brush)new SolidBrush(Color.White), 4f, (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(num / 2)));
			}
			else
			{
				val2.DrawString("...", ((Control)this).get_Font(), (Brush)new SolidBrush(Color.White), 4f, (float)(unchecked(((Control)this).get_Height() / 2) - unchecked(num / 2)));
			}
			if ((unchecked((int)Control.get_MouseButtons()) == 0) & (int_0 > ((Control)this).get_Width() - 25))
			{
				val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(7, Color.White)), ((Control)this).get_Width() - 25, 1, ((Control)this).get_Width() - 25, ((Control)this).get_Height() - 3);
			}
			else if ((unchecked((int)Control.get_MouseButtons()) == 0) & (int_0 < ((Control)this).get_Width() - 25) & (int_0 >= 0))
			{
				val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(7, Color.White)), 2, 1, ((Control)this).get_Width() - 27, ((Control)this).get_Height() - 3);
			}
			val2.DrawRectangle(Pens.get_Black(), 0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			val2.DrawRectangle(new Pen(Color.FromArgb(90, 90, 90)), 1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
			val2.DrawLine(new Pen(Color.FromArgb(90, 90, 90)), ((Control)this).get_Width() - 25, 1, ((Control)this).get_Width() - 25, ((Control)this).get_Height() - 3);
			val2.DrawLine(Pens.get_Black(), ((Control)this).get_Width() - 24, 0, ((Control)this).get_Width() - 24, ((Control)this).get_Height());
			val2.DrawLine(new Pen(Color.FromArgb(90, 90, 90)), ((Control)this).get_Width() - 23, 1, ((Control)this).get_Width() - 23, ((Control)this).get_Height() - 3);
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
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
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
					e.get_Graphics().FillRectangle(Brushes.get_Black(), e.get_Bounds());
					Point location = e.get_Bounds().Location;
					Size size = new Size(e.get_Bounds().Width - 1, e.get_Bounds().Height);
					Rectangle rectangle2 = new Rectangle(location, size);
					Point location2 = rectangle2.Location;
					size = new Size(rectangle2.Width, (int)Math.Round((double)rectangle2.Height / 2.0 - 1.0));
					Rectangle rectangle3 = new Rectangle(location2, size);
					Point point = new Point(rectangle2.X, rectangle2.Y);
					Point point2 = new Point(rectangle2.X, rectangle2.Y + rectangle2.Height);
					LinearGradientBrush val = new LinearGradientBrush(point, point2, Color.FromArgb(60, 60, 60), Color.FromArgb(50, 50, 50));
					HatchBrush val2 = new HatchBrush((HatchStyle)20, Color.FromArgb(15, Color.Black), Color.Transparent);
					e.get_Graphics().FillRectangle((Brush)(object)val, rectangle2);
					((Brush)val).Dispose();
					e.get_Graphics().FillRectangle((Brush)new SolidBrush(Color.FromArgb(25, Color.White)), rectangle3);
					e.get_Graphics().FillRectangle((Brush)(object)val2, rectangle2);
					((Brush)val).Dispose();
					e.get_Graphics().DrawString(" " + ((ComboBox)this).get_Items().get_Item(e.get_Index()).ToString(), ((Control)this).get_Font(), Brushes.get_White(), (float)e.get_Bounds().X, (float)(e.get_Bounds().Y + 2));
				}
				else
				{
					e.get_Graphics().FillRectangle((Brush)new SolidBrush(((ComboBox)this).get_BackColor()), e.get_Bounds());
					e.get_Graphics().DrawString(" " + ((ComboBox)this).get_Items().get_Item(e.get_Index()).ToString(), ((Control)this).get_Font(), Brushes.get_White(), (float)e.get_Bounds().X, (float)(e.get_Bounds().Y + 2));
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

	private void Class9_DropDownClosed(object sender, EventArgs e)
	{
		((ComboBox)this).set_DropDownStyle((ComboBoxStyle)0);
		Application.DoEvents();
		((ComboBox)this).set_DropDownStyle((ComboBoxStyle)2);
	}

	private void Class9_TextChanged(object sender, EventArgs e)
	{
		((Control)this).Invalidate();
	}
}
