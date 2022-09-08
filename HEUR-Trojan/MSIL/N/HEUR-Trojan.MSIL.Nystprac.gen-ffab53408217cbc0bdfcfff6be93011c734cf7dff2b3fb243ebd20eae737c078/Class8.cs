using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class Class8 : ListBox
{
	private static List<WeakReference> list_0;

	[DebuggerNonUserCode]
	static Class8()
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

	public Class8()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		Class14.hYiyYvszsKHjE();
		((ListBox)this)._002Ector();
		smethod_0(this);
		((Control)this).SetStyle((ControlStyles)65536, true);
		((ListBox)this).set_Font(new Font("Microsoft Sans Serif", 9f));
		((ListBox)this).set_BorderStyle((BorderStyle)0);
		((ListBox)this).set_DrawMode((DrawMode)1);
		((ListBox)this).set_ItemHeight(20);
		((ListBox)this).set_ForeColor(Color.DeepSkyBlue);
		((ListBox)this).set_BackColor(Color.FromArgb(7, 7, 7));
		((ListBox)this).set_IntegralHeight(false);
	}

	protected override void WndProc(ref Message m)
	{
		((ListBox)this).WndProc(ref m);
		if (((Message)(ref m)).get_Msg() == 15)
		{
			method_0();
		}
	}

	protected override void OnDrawItem(DrawItemEventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b0: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		checked
		{
			try
			{
				if (e.get_Index() >= 0)
				{
					e.DrawBackground();
					Point point = new Point(e.get_Bounds().Left, e.get_Bounds().Top + 2);
					Point location = point;
					Size size = new Size(((Control)this).get_Bounds().Width, 16);
					Rectangle rectangle = new Rectangle(location, size);
					e.DrawFocusRectangle();
					if (Strings.InStr(((Enum)e.get_State()).ToString(), "Selected,", (CompareMethod)0) > 0)
					{
						e.get_Graphics().FillRectangle(Brushes.get_Black(), e.get_Bounds());
						Point location2 = e.get_Bounds().Location;
						size = new Size(e.get_Bounds().Width - 1, e.get_Bounds().Height);
						Rectangle rectangle2 = new Rectangle(location2, size);
						Point location3 = rectangle2.Location;
						size = new Size(rectangle2.Width, (int)Math.Round((double)rectangle2.Height / 2.0));
						Rectangle rectangle3 = new Rectangle(location3, size);
						point = new Point(rectangle2.X, rectangle2.Y);
						Point point2 = point;
						Point point3 = new Point(rectangle2.X, rectangle2.Y + rectangle2.Height);
						LinearGradientBrush val = new LinearGradientBrush(point2, point3, Color.FromArgb(60, 60, 60), Color.FromArgb(50, 50, 50));
						HatchBrush val2 = new HatchBrush((HatchStyle)20, Color.FromArgb(15, Color.Black), Color.Transparent);
						e.get_Graphics().FillRectangle((Brush)(object)val, rectangle2);
						((Brush)val).Dispose();
						e.get_Graphics().FillRectangle((Brush)new SolidBrush(Color.FromArgb(25, Color.White)), rectangle3);
						e.get_Graphics().FillRectangle((Brush)(object)val2, rectangle2);
						((Brush)val).Dispose();
						e.get_Graphics().DrawString(" " + ((ListBox)this).get_Items().get_Item(e.get_Index()).ToString(), ((ListBox)this).get_Font(), Brushes.get_White(), (float)e.get_Bounds().X, (float)(e.get_Bounds().Y + 1));
					}
					else
					{
						e.get_Graphics().DrawString(" " + ((ListBox)this).get_Items().get_Item(e.get_Index()).ToString(), ((ListBox)this).get_Font(), Brushes.get_White(), (float)e.get_Bounds().X, (float)(e.get_Bounds().Y + 1));
					}
					Graphics graphics = e.get_Graphics();
					Pen val3 = new Pen(Color.FromArgb(0, 0, 0));
					Rectangle rectangle4 = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
					graphics.DrawRectangle(val3, rectangle4);
					Graphics graphics2 = e.get_Graphics();
					Pen val4 = new Pen(Color.FromArgb(90, 90, 90));
					rectangle4 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
					graphics2.DrawRectangle(val4, rectangle4);
					((ListBox)this).OnDrawItem(e);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void method_0()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		Graphics obj = ((Control)this).CreateGraphics();
		Pen val = new Pen(Color.FromArgb(0, 0, 0));
		checked
		{
			Rectangle rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
			obj.DrawRectangle(val, rectangle);
			Graphics obj2 = ((Control)this).CreateGraphics();
			Pen val2 = new Pen(Color.FromArgb(90, 90, 90));
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			obj2.DrawRectangle(val2, rectangle);
		}
	}
}
