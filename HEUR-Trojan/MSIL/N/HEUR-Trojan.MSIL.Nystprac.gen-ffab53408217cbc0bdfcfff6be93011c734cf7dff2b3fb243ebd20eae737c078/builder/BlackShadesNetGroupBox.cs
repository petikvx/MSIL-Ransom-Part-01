using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace builder;

public class BlackShadesNetGroupBox : ContainerControl
{
	private static List<WeakReference> list_0;

	[DebuggerNonUserCode]
	static BlackShadesNetGroupBox()
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

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		((Control)this).Invalidate();
	}

	public BlackShadesNetGroupBox()
	{
		Class14.hYiyYvszsKHjE();
		((ContainerControl)this)._002Ector();
		smethod_0(this);
		((Control)this).set_BackColor(Color.FromArgb(33, 33, 33));
		Size size = new Size(200, 100);
		((Control)this).set_Size(size);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01d1: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.set_SmoothingMode((SmoothingMode)1);
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			((ContainerControl)this).get_ParentForm().get_TransparencyKey();
			Class10 @class = new Class10();
			((Control)this).OnPaint(e);
			val2.Clear(Color.FromArgb(42, 47, 49));
			Pen val3 = new Pen(Color.FromArgb(67, 75, 78));
			Rectangle rectangle_ = new Rectangle(2, 7, ((Control)this).get_Width() - 5, ((Control)this).get_Height() - 9);
			val2.DrawPath(val3, @class.method_0(rectangle_, 3));
			LinearGradientBrush val4 = new LinearGradientBrush(rectangle, Color.FromArgb(30, 32, 32), Color.Transparent, 90f);
			Pen val5 = new Pen((Brush)(object)val4);
			rectangle_ = new Rectangle(1, 6, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 9);
			val2.DrawPath(val5, @class.method_0(rectangle_, 3));
			rectangle_ = new Rectangle(3, 7, ((Control)this).get_Width() - 7, ((Control)this).get_Height() - 10);
			LinearGradientBrush val6 = new LinearGradientBrush(rectangle_, Color.Transparent, Color.FromArgb(30, 32, 32), 90f);
			Pen val7 = new Pen((Brush)(object)val6);
			rectangle_ = new Rectangle(3, 7, ((Control)this).get_Width() - 7, ((Control)this).get_Height() - 10);
			val2.DrawPath(val7, @class.method_0(rectangle_, 3));
			SolidBrush val8 = new SolidBrush(Color.FromArgb(42, 47, 49));
			rectangle_ = new Rectangle(8, 0, ((Control)this).get_Text().Length * 6, 11);
			val2.FillRectangle((Brush)val8, rectangle_);
			string text = ((Control)this).get_Text();
			Font font = ((Control)this).get_Font();
			SolidBrush val9 = new SolidBrush(((Control)this).get_ForeColor());
			rectangle_ = new Rectangle(8, 0, ((Control)this).get_Width() - 1, 11);
			RectangleF rectangleF = rectangle_;
			StringFormat val10 = new StringFormat();
			val10.set_LineAlignment((StringAlignment)1);
			val10.set_Alignment((StringAlignment)0);
			val2.DrawString(text, font, (Brush)val9, rectangleF, val10);
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
