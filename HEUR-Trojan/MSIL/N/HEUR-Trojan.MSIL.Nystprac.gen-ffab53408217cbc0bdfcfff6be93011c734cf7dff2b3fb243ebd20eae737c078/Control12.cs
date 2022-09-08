using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

internal class Control12 : TabControl
{
	private static List<WeakReference> list_0;

	private Color color_0;

	[DebuggerNonUserCode]
	static Control12()
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

	[SpecialName]
	public Color method_0()
	{
		return color_0;
	}

	[SpecialName]
	public void method_1(Color color_1)
	{
		color_0 = color_1;
	}

	public Control12()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		Class14.hYiyYvszsKHjE();
		((TabControl)this)._002Ector();
		smethod_0(this);
		color_0 = Color.White;
		((Control)this).SetStyle((ControlStyles)73746, true);
		((TabControl)this).set_DoubleBuffered(true);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((TabControl)this).get_TabPages().GetEnumerator();
			while (enumerator.MoveNext())
			{
				TabPage val = (TabPage)enumerator.Current;
				try
				{
					val.set_BackColor(Color.Black);
					val.set_BackColor(Color.Transparent);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	protected override void CreateHandle()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		((TabControl)this).CreateHandle();
		((TabControl)this).set_Alignment((TabAlignment)0);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = ((TabControl)this).get_TabPages().GetEnumerator();
			while (enumerator.MoveNext())
			{
				TabPage val = (TabPage)enumerator.Current;
				try
				{
					val.set_BackColor(Color.Black);
					val.set_BackColor(Color.Transparent);
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Expected O, but got Unknown
		//IL_039d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Expected O, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_052b: Expected O, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected O, but got Unknown
		//IL_05b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Expected O, but got Unknown
		//IL_05db: Expected O, but got Unknown
		//IL_0650: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0663: Expected O, but got Unknown
		//IL_067a: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.Clear(Color.FromArgb(60, 60, 60));
		HatchBrush val3 = new HatchBrush((HatchStyle)20, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray));
		SolidBrush val4 = new SolidBrush(Color.FromArgb(60, 60, 60));
		Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		val2.FillRectangle((Brush)val4, rectangle);
		val3 = new HatchBrush((HatchStyle)18, Color.DimGray);
		val2.FillRectangle((Brush)(object)val3, 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		val2.FillRectangle((Brush)new SolidBrush(Color.FromArgb(230, 20, 20, 20)), 0, 0, ((Control)this).get_Width(), ((Control)this).get_Height());
		Brush black = Brushes.get_Black();
		Point point = new Point(0, 4);
		Point location = point;
		checked
		{
			Size size = new Size(((Control)this).get_Width() - 2, 20);
			rectangle = new Rectangle(location, size);
			val2.FillRectangle(black, rectangle);
			Pen black2 = Pens.get_Black();
			point = new Point(0, 3);
			Point location2 = point;
			size = new Size(((Control)this).get_Width() - 1, ((Control)this).get_Height() - 4);
			rectangle = new Rectangle(location2, size);
			val2.DrawRectangle(black2, rectangle);
			Pen val5 = new Pen(Color.FromArgb(90, 90, 90));
			point = new Point(1, 4);
			Point location3 = point;
			size = new Size(((Control)this).get_Width() - 3, ((Control)this).get_Height() - 6);
			rectangle = new Rectangle(location3, size);
			val2.DrawRectangle(val5, rectangle);
			int num = ((TabControl)this).get_TabCount() - 1;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				if (num2 == ((TabControl)this).get_SelectedIndex())
				{
					int x = ((TabControl)this).GetTabRect(num2).X;
					rectangle = ((TabControl)this).GetTabRect(num2);
					Rectangle rectangle2 = new Rectangle(x, rectangle.Y + 2, ((TabControl)this).GetTabRect(num2).Width + 2, ((TabControl)this).GetTabRect(num2).Height - 1);
					val3 = new HatchBrush((HatchStyle)20, Color.FromArgb(35, Color.Black), Color.FromArgb(0, Color.Gray));
					SolidBrush val6 = new SolidBrush(Color.FromArgb(60, 60, 60));
					rectangle = new Rectangle(((TabControl)this).GetTabRect(num2).X, ((TabControl)this).GetTabRect(num2).Y + 3, ((TabControl)this).GetTabRect(num2).Width + 1, ((TabControl)this).GetTabRect(num2).Height - 2);
					val2.FillRectangle((Brush)val6, rectangle);
					val3 = new HatchBrush((HatchStyle)18, Color.DimGray);
					HatchBrush obj = val3;
					rectangle = new Rectangle(((TabControl)this).GetTabRect(num2).X, ((TabControl)this).GetTabRect(num2).Y + 3, ((TabControl)this).GetTabRect(num2).Width + 1, ((TabControl)this).GetTabRect(num2).Height - 2);
					val2.FillRectangle((Brush)(object)obj, rectangle);
					SolidBrush val7 = new SolidBrush(Color.FromArgb(230, 20, 20, 20));
					rectangle = new Rectangle(((TabControl)this).GetTabRect(num2).X, ((TabControl)this).GetTabRect(num2).Y + 3, ((TabControl)this).GetTabRect(num2).Width + 1, ((TabControl)this).GetTabRect(num2).Height - 2);
					val2.FillRectangle((Brush)val7, rectangle);
					rectangle = new Rectangle(((TabControl)this).GetTabRect(num2).X, ((TabControl)this).GetTabRect(num2).Y + 2, ((TabControl)this).GetTabRect(num2).Width + 2, ((TabControl)this).GetTabRect(num2).Height - 1);
					LinearGradientBrush val8 = new LinearGradientBrush(rectangle, Color.FromArgb(15, Color.White), Color.Transparent, 90f);
					rectangle = new Rectangle(((TabControl)this).GetTabRect(num2).X, ((TabControl)this).GetTabRect(num2).Y + 2, ((TabControl)this).GetTabRect(num2).Width + 2, ((TabControl)this).GetTabRect(num2).Height - 1);
					val2.FillRectangle((Brush)(object)val8, rectangle);
					Pen val9 = new Pen(Color.FromArgb(90, 90, 90));
					point = new Point(((TabControl)this).GetTabRect(num2).Right, 4);
					Point point2 = point;
					Point point3 = new Point(((TabControl)this).GetTabRect(num2).Right, ((TabControl)this).GetTabRect(num2).Height + 3);
					val2.DrawLine(val9, point2, point3);
					if (((TabControl)this).get_SelectedIndex() != 0)
					{
						Pen val10 = new Pen(Color.FromArgb(90, 90, 90));
						point3 = new Point(((TabControl)this).GetTabRect(num2).X, 4);
						Point point4 = point3;
						point = new Point(((TabControl)this).GetTabRect(num2).X, ((TabControl)this).GetTabRect(num2).Height + 3);
						val2.DrawLine(val10, point4, point);
						Pen val11 = new Pen(Color.FromArgb(90, 90, 90));
						point3 = new Point(1, ((TabControl)this).GetTabRect(num2).Height + 3);
						Point point5 = point3;
						point = new Point(((TabControl)this).GetTabRect(num2).X, ((TabControl)this).GetTabRect(num2).Height + 3);
						val2.DrawLine(val11, point5, point);
					}
					Pen val12 = new Pen(Color.FromArgb(90, 90, 90));
					point3 = new Point(((TabControl)this).GetTabRect(num2).Right, ((TabControl)this).GetTabRect(num2).Height + 3);
					Point point6 = point3;
					point = new Point(((Control)this).get_Width() - 2, ((TabControl)this).GetTabRect(num2).Height + 3);
					val2.DrawLine(val12, point6, point);
					string text = ((TabControl)this).get_TabPages().get_Item(num2).get_Text();
					Font font = ((Control)this).get_Font();
					SolidBrush val13 = new SolidBrush(color_0);
					RectangleF rectangleF = rectangle2;
					StringFormat val14 = new StringFormat();
					val14.set_LineAlignment((StringAlignment)1);
					val14.set_Alignment((StringAlignment)1);
					val2.DrawString(text, font, (Brush)val13, rectangleF, val14);
				}
				else
				{
					Rectangle rectangle3 = new Rectangle(((TabControl)this).GetTabRect(num2).X, ((TabControl)this).GetTabRect(num2).Y + 2, ((TabControl)this).GetTabRect(num2).Width + 2, ((TabControl)this).GetTabRect(num2).Height - 1);
					string text2 = ((TabControl)this).get_TabPages().get_Item(num2).get_Text();
					Font font2 = ((Control)this).get_Font();
					SolidBrush val15 = new SolidBrush(color_0);
					RectangleF rectangleF2 = rectangle3;
					StringFormat val14 = new StringFormat();
					val14.set_LineAlignment((StringAlignment)1);
					val14.set_Alignment((StringAlignment)1);
					val2.DrawString(text2, font2, (Brush)val15, rectangleF2, val14);
				}
				num2++;
			}
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
}
