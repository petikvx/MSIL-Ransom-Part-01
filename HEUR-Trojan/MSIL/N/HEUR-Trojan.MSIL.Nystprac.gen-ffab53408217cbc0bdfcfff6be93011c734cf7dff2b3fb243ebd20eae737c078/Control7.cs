using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

internal class Control7 : Control2
{
	private static List<WeakReference> list_0;

	[AccessedThroughProperty("LBox")]
	private ListBox listBox_0;

	private string[] string_1;

	[DebuggerNonUserCode]
	static Control7()
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
	[DebuggerNonUserCode]
	public virtual ListBox HFXQDCONOB()
	{
		return listBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	public virtual void vmethod_0(ListBox listBox_1)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		DrawItemEventHandler val = new DrawItemEventHandler(method_85);
		if (listBox_0 != null)
		{
			listBox_0.remove_DrawItem(val);
		}
		listBox_0 = listBox_1;
		if (listBox_0 != null)
		{
			listBox_0.add_DrawItem(val);
		}
	}

	[SpecialName]
	public string[] method_82()
	{
		return string_1;
	}

	[SpecialName]
	public void method_83(string[] string_2)
	{
		string_1 = string_2;
		HFXQDCONOB().get_Items().Clear();
		((Control)this).Invalidate();
		HFXQDCONOB().get_Items().AddRange((object[])string_2);
		((Control)this).Invalidate();
	}

	[SpecialName]
	public string method_84()
	{
		return Conversions.ToString(HFXQDCONOB().get_SelectedItem());
	}

	public Control7()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		Class14.hYiyYvszsKHjE();
		base._002Ector();
		smethod_0(this);
		vmethod_0(new ListBox());
		string_1 = new string[1] { "" };
		((Control)this).get_Controls().Add((Control)(object)HFXQDCONOB());
		Size size = new Size(131, 101);
		((Control)this).set_Size(size);
		HFXQDCONOB().set_BackColor(Color.FromArgb(0, 0, 0));
		HFXQDCONOB().set_BorderStyle((BorderStyle)0);
		HFXQDCONOB().set_DrawMode((DrawMode)2);
		ListBox obj = HFXQDCONOB();
		Point location = new Point(3, 3);
		((Control)obj).set_Location(location);
		HFXQDCONOB().set_ForeColor(Color.White);
		HFXQDCONOB().set_ItemHeight(20);
		HFXQDCONOB().get_Items().Clear();
		HFXQDCONOB().set_IntegralHeight(false);
		((Control)this).Invalidate();
	}

	protected override void ColorHook()
	{
	}

	protected override void OnResize(EventArgs eventargs)
	{
		((Control)this).OnResize(eventargs);
		checked
		{
			((Control)HFXQDCONOB()).set_Width(((Control)this).get_Width() - 4);
			((Control)HFXQDCONOB()).set_Height(((Control)this).get_Height() - 4);
		}
	}

	protected override void PaintHook()
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		graphics_0.Clear(Color.Black);
		checked
		{
			graphics_0.DrawRectangle(Pens.get_Black(), 0, 0, ((Control)this).get_Width() - 2, ((Control)this).get_Height() - 2);
			graphics_0.DrawRectangle(new Pen(Color.FromArgb(90, 90, 90)), 1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
			ListBox obj = HFXQDCONOB();
			Size size = new Size(((Control)this).get_Width() - 5, ((Control)this).get_Height() - 5);
			((Control)obj).set_Size(size);
		}
	}

	public void method_85(object sender, DrawItemEventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		checked
		{
			if (e.get_Index() >= 0)
			{
				e.DrawBackground();
				e.DrawFocusRectangle();
				if (Strings.InStr(((Enum)e.get_State()).ToString(), "Selected,", (CompareMethod)0) > 0)
				{
					e.get_Graphics().FillRectangle(Brushes.get_Black(), e.get_Bounds());
					Point location = e.get_Bounds().Location;
					Size size = new Size(e.get_Bounds().Width - 1, e.get_Bounds().Height);
					Rectangle rectangle = new Rectangle(location, size);
					Point location2 = rectangle.Location;
					size = new Size(rectangle.Width, (int)Math.Round((double)rectangle.Height / 2.0 - 2.0));
					Rectangle rectangle2 = new Rectangle(location2, size);
					Point point = new Point(rectangle.X, rectangle.Y);
					Point point2 = new Point(rectangle.X, rectangle.Y + rectangle.Height);
					LinearGradientBrush val = new LinearGradientBrush(point, point2, Color.FromArgb(60, 60, 60), Color.FromArgb(50, 50, 50));
					HatchBrush val2 = new HatchBrush((HatchStyle)20, Color.FromArgb(15, Color.Black), Color.Transparent);
					e.get_Graphics().FillRectangle((Brush)(object)val, rectangle);
					((Brush)val).Dispose();
					e.get_Graphics().FillRectangle((Brush)new SolidBrush(Color.FromArgb(25, Color.White)), rectangle2);
					e.get_Graphics().FillRectangle((Brush)(object)val2, rectangle);
					((Brush)val).Dispose();
					e.get_Graphics().DrawString(" " + HFXQDCONOB().get_Items().get_Item(e.get_Index()).ToString(), Font, Brushes.get_White(), (float)e.get_Bounds().X, (float)(e.get_Bounds().Y + 2));
				}
				else
				{
					e.get_Graphics().DrawString(" " + HFXQDCONOB().get_Items().get_Item(e.get_Index()).ToString(), Font, Brushes.get_White(), (float)e.get_Bounds().X, (float)(e.get_Bounds().Y + 2));
				}
			}
		}
	}

	public void method_86(object[] object_0)
	{
		HFXQDCONOB().get_Items().Remove((object)"");
		HFXQDCONOB().get_Items().AddRange(object_0);
		((Control)this).Invalidate();
	}

	public void method_87(object object_0)
	{
		HFXQDCONOB().get_Items().Remove((object)"");
		HFXQDCONOB().get_Items().Add(RuntimeHelpers.GetObjectValue(object_0));
		((Control)this).Invalidate();
	}
}
