using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace builder;

public class BlackShadesNetButton : Control
{
	private static List<WeakReference> list_0;

	private Enum0 hgXefinri2;

	private StringAlignment stringAlignment_0;

	public StringAlignment TextAlignment
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return stringAlignment_0;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			stringAlignment_0 = value;
			((Control)this).Invalidate();
		}
	}

	[DebuggerNonUserCode]
	static BlackShadesNetButton()
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
		hgXefinri2 = (Enum0)1;
		((Control)this).Invalidate();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((Control)this).OnMouseDown(e);
		hgXefinri2 = (Enum0)2;
		((Control)this).Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		hgXefinri2 = (Enum0)0;
		((Control)this).Invalidate();
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		hgXefinri2 = (Enum0)1;
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

	public BlackShadesNetButton()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		Class14.hYiyYvszsKHjE();
		((Control)this)._002Ector();
		smethod_0(this);
		hgXefinri2 = (Enum0)0;
		stringAlignment_0 = (StringAlignment)1;
		((Control)this).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)this).set_Font(new Font("Trebuchet MS", 8.25f, (FontStyle)1));
		((Control)this).set_ForeColor(Color.White);
		((Control)this).set_DoubleBuffered(true);
		Size size = new Size(75, 23);
		((Control)this).set_Size(size);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Expected O, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cb: Expected O, but got Unknown
		//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0445: Expected O, but got Unknown
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected O, but got Unknown
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0534: Expected O, but got Unknown
		//IL_05a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f6: Expected O, but got Unknown
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0619: Expected O, but got Unknown
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648: Expected O, but got Unknown
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected O, but got Unknown
		//IL_0693: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bf: Expected O, but got Unknown
		//IL_06d6: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			Class10 @class = new Class10();
			val2.set_SmoothingMode((SmoothingMode)2);
			val2.Clear(Color.FromArgb(42, 47, 49));
			Rectangle rectangle_;
			switch (hgXefinri2)
			{
			case (Enum0)0:
			{
				SolidBrush val17 = new SolidBrush(Color.FromArgb(32, 36, 38));
				rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				val2.FillPath((Brush)val17, @class.method_0(rectangle_, 3));
				rectangle_ = new Rectangle(1, 1, ((Control)this).get_Width() - 5, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 3.0));
				LinearGradientBrush val18 = new LinearGradientBrush(rectangle_, Color.FromArgb(70, Color.White), Color.Transparent, 90f);
				rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 3.0));
				val2.FillPath((Brush)(object)val18, @class.method_0(rectangle_, 3));
				LinearGradientBrush val19 = new LinearGradientBrush(rectangle, Color.FromArgb(36, 31, 43), Color.FromArgb(61, 65, 68), 90f);
				Pen val20 = new Pen(Color.FromArgb(99, 103, 105));
				rectangle_ = new Rectangle(0, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 3);
				val2.DrawPath(val20, @class.method_0(rectangle_, 3));
				Pen val21 = new Pen((Brush)(object)val19);
				rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				val2.DrawPath(val21, @class.method_0(rectangle_, 3));
				Pen val22 = new Pen(Color.FromArgb(27, 31, 33));
				rectangle_ = new Rectangle(1, 0, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
				val2.DrawPath(val22, @class.method_0(rectangle_, 3));
				break;
			}
			case (Enum0)1:
			{
				SolidBrush val9 = new SolidBrush(Color.FromArgb(32, 36, 38));
				rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				val2.FillPath((Brush)val9, @class.method_0(rectangle_, 3));
				rectangle_ = new Rectangle(1, 1, ((Control)this).get_Width() - 5, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 3.0));
				LinearGradientBrush val10 = new LinearGradientBrush(rectangle_, Color.FromArgb(70, Color.White), Color.Transparent, 90f);
				rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 3.0));
				val2.FillPath((Brush)(object)val10, @class.method_0(rectangle_, 3));
				LinearGradientBrush val11 = new LinearGradientBrush(rectangle, Color.FromArgb(36, 31, 43), Color.FromArgb(61, 65, 68), 90f);
				Pen val12 = new Pen(Color.FromArgb(99, 103, 105));
				rectangle_ = new Rectangle(0, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 3);
				val2.DrawPath(val12, @class.method_0(rectangle_, 3));
				Pen val13 = new Pen(Color.FromArgb(100, 99, 103, 105));
				rectangle_ = new Rectangle(2, 2, ((Control)this).get_Width() - 5, ((Control)this).get_Height() - 6);
				val2.DrawPath(val13, @class.method_0(rectangle_, 3));
				Pen val14 = new Pen((Brush)(object)val11);
				rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				val2.DrawPath(val14, @class.method_0(rectangle_, 3));
				Pen val15 = new Pen(Color.FromArgb(27, 31, 33));
				rectangle_ = new Rectangle(1, 0, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
				val2.DrawPath(val15, @class.method_0(rectangle_, 3));
				Pen val16 = new Pen(Color.FromArgb(0, 186, 255));
				rectangle_ = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 4);
				val2.DrawPath(val16, @class.method_0(rectangle_, 3));
				break;
			}
			case (Enum0)2:
			{
				SolidBrush val3 = new SolidBrush(Color.FromArgb(32, 36, 38));
				rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				val2.FillPath((Brush)val3, @class.method_0(rectangle_, 3));
				rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 1.0));
				LinearGradientBrush val4 = new LinearGradientBrush(rectangle_, Color.FromArgb(32, 36, 38), Color.FromArgb(57, 57, 57), 90f);
				rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0 + 1.0));
				val2.FillPath((Brush)(object)val4, @class.method_0(rectangle_, 3));
				rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 1.0));
				LinearGradientBrush val5 = new LinearGradientBrush(rectangle_, Color.FromArgb(57, 57, 57), Color.FromArgb(32, 36, 38), 90f);
				rectangle_ = new Rectangle(0, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 1.0), ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0 + 2.0));
				val2.FillPath((Brush)(object)val5, @class.method_0(rectangle_, 3));
				val2.DrawLine(new Pen(Color.FromArgb(57, 57, 57)), 0, Convert.ToInt32((double)((Control)this).get_Height() / 2.0 - 1.0), ((Control)this).get_Width() - 1, Convert.ToInt32((double)((Control)this).get_Height() / 2.0 - 1.0));
				LinearGradientBrush val6 = new LinearGradientBrush(rectangle, Color.FromArgb(36, 31, 43), Color.FromArgb(61, 65, 68), 90f);
				Pen val7 = new Pen((Brush)(object)val6);
				rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				val2.DrawPath(val7, @class.method_0(rectangle_, 3));
				Pen val8 = new Pen(Color.FromArgb(27, 31, 33));
				rectangle_ = new Rectangle(1, 0, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
				val2.DrawPath(val8, @class.method_0(rectangle_, 3));
				break;
			}
			}
			string text = ((Control)this).get_Text();
			Font font = ((Control)this).get_Font();
			SolidBrush val23 = new SolidBrush(((Control)this).get_ForeColor());
			rectangle_ = new Rectangle(-1, -1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			RectangleF rectangleF = rectangle_;
			StringFormat val24 = new StringFormat();
			val24.set_LineAlignment((StringAlignment)1);
			val24.set_Alignment((StringAlignment)1);
			val2.DrawString(text, font, (Brush)val23, rectangleF, val24);
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
