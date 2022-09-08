using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace builder;

public class BlackShadesNetTopButton : Control
{
	private static List<WeakReference> list_0;

	private Enum0 enum0_0;

	[DebuggerNonUserCode]
	static BlackShadesNetTopButton()
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

	protected override void OnMouseEnter(EventArgs e)
	{
		((Control)this).OnMouseEnter(e);
		enum0_0 = (Enum0)1;
		((Control)this).Invalidate();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((Control)this).OnMouseDown(e);
		enum0_0 = (Enum0)2;
		((Control)this).Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		enum0_0 = (Enum0)0;
		((Control)this).Invalidate();
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		enum0_0 = (Enum0)1;
		((Control)this).Invalidate();
	}

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		((Control)this).Invalidate();
	}

	public BlackShadesNetTopButton()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		Class14.hYiyYvszsKHjE();
		((Control)this)._002Ector();
		smethod_0(this);
		enum0_0 = (Enum0)0;
		((Control)this).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)this).set_Font(new Font("Verdana", 8.25f));
		Size size = new Size(15, 11);
		((Control)this).set_Size(size);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).Focus();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d1: Expected O, but got Unknown
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_029d: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Class10 @class = new Class10();
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			Size size = new Size(15, 11);
			((Control)this).set_Size(size);
			val2.Clear(Color.FromArgb(49, 53, 55));
			switch (enum0_0)
			{
			case (Enum0)0:
			{
				LinearGradientBrush val10 = new LinearGradientBrush(rectangle, Color.FromArgb(200, 44, 47, 51), Color.FromArgb(80, 64, 69, 71), 90f);
				val2.FillPath((Brush)(object)val10, @class.method_0(rectangle, 1));
				Rectangle rectangle2 = new Rectangle(2, 2, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
				LinearGradientBrush val11 = new LinearGradientBrush(rectangle2, Color.FromArgb(90, 97, 101), Color.FromArgb(63, 69, 73), 90f);
				rectangle2 = new Rectangle(2, 2, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
				val2.FillPath((Brush)(object)val11, @class.method_0(rectangle2, 1));
				Pen val12 = new Pen(Color.FromArgb(30, 32, 35));
				rectangle2 = new Rectangle(2, 2, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
				val2.DrawPath(val12, @class.method_0(rectangle2, 1));
				break;
			}
			case (Enum0)1:
			{
				LinearGradientBrush val6 = new LinearGradientBrush(rectangle, Color.FromArgb(200, 44, 47, 51), Color.FromArgb(80, 64, 69, 71), 90f);
				val2.FillPath((Brush)(object)val6, @class.method_0(rectangle, 1));
				Rectangle rectangle2 = new Rectangle(2, 2, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
				LinearGradientBrush val7 = new LinearGradientBrush(rectangle2, Color.FromArgb(90, 97, 101), Color.FromArgb(63, 69, 73), 90f);
				rectangle2 = new Rectangle(2, 2, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
				val2.FillPath((Brush)(object)val7, @class.method_0(rectangle2, 1));
				Pen val8 = new Pen(Color.FromArgb(30, 32, 35));
				rectangle2 = new Rectangle(2, 2, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
				val2.DrawPath(val8, @class.method_0(rectangle2, 1));
				Pen val9 = new Pen(Color.FromArgb(200, 0, 186, 255));
				rectangle2 = new Rectangle(2, 2, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
				val2.DrawPath(val9, @class.method_0(rectangle2, 1));
				break;
			}
			case (Enum0)2:
			{
				LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(200, 44, 47, 51), Color.FromArgb(80, 64, 69, 71), 90f);
				val2.FillPath((Brush)(object)val3, @class.method_0(rectangle, 1));
				Rectangle rectangle2 = new Rectangle(2, 2, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
				LinearGradientBrush val4 = new LinearGradientBrush(rectangle2, Color.FromArgb(90, 97, 101), Color.FromArgb(63, 69, 73), 135f);
				rectangle2 = new Rectangle(2, 2, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
				val2.FillPath((Brush)(object)val4, @class.method_0(rectangle2, 1));
				Pen val5 = new Pen(Color.FromArgb(30, 32, 35));
				rectangle2 = new Rectangle(2, 2, ((Control)this).get_Width() - 6, ((Control)this).get_Height() - 6);
				val2.DrawPath(val5, @class.method_0(rectangle2, 1));
				break;
			}
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
