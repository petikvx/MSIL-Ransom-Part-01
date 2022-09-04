using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace nO_bUILDER;

public class InfluenceGroupBox : ContainerControl
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		((Control)this).Invalidate();
	}

	public InfluenceGroupBox()
	{
		__ENCAddToList(this);
		Size size = new Size(200, 100);
		((Control)this).set_Size(size);
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.set_SmoothingMode((SmoothingMode)1);
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			((ContainerControl)this).get_ParentForm().get_TransparencyKey();
			Draw draw = new Draw();
			((Control)this).OnPaint(e);
			val2.Clear(((Control)this).get_BackColor());
			val2.FillPath((Brush)new SolidBrush(Color.FromArgb(20, 20, 20)), draw.RoundRect(rectangle, 2));
			HatchBrush val3 = new HatchBrush((HatchStyle)21, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
			Rectangle rectangle2 = new Rectangle(0, 2, ((Control)this).get_Width() - 1, 25);
			LinearGradientBrush val4 = new LinearGradientBrush(rectangle2, Color.FromArgb(40, 40, 40), Color.FromArgb(29, 29, 29), 90f);
			rectangle2 = new Rectangle(0, 2, ((Control)this).get_Width() - 1, 25);
			val2.FillPath((Brush)(object)val4, draw.RoundRect(rectangle2, 2));
			rectangle2 = new Rectangle(0, 2, ((Control)this).get_Width() - 1, 25);
			val2.FillPath((Brush)(object)val3, draw.RoundRect(rectangle2, 2));
			LinearGradientBrush val5 = new LinearGradientBrush(val4.get_Rectangle(), Color.FromArgb(15, Color.White), Color.FromArgb(0, Color.White), 90f);
			rectangle2 = new Rectangle(1, 1, ((Control)this).get_Width() - 1, 13);
			val2.FillRectangle((Brush)(object)val5, rectangle2);
			val2.DrawLine(new Pen(Color.FromArgb(75, Color.White)), 1, 1, ((Control)this).get_Width() - 1, 1);
			val2.DrawLine(new Pen(Color.FromArgb(18, 18, 18)), 1, 26, ((Control)this).get_Width() - 1, 26);
			Pen val6 = new Pen(Color.FromArgb(37, 37, 37));
			rectangle2 = new Rectangle(1, 27, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 29);
			val2.DrawRectangle(val6, rectangle2);
			val2.DrawPath(Pens.get_Black(), draw.RoundRect(rectangle, 2));
			string text = ((Control)this).get_Text();
			Font font = ((Control)this).get_Font();
			Brush black = Brushes.get_Black();
			rectangle2 = new Rectangle(8, 8, ((Control)this).get_Width() - 1, 10);
			RectangleF rectangleF = rectangle2;
			StringFormat val7 = new StringFormat();
			val7.set_LineAlignment((StringAlignment)1);
			val7.set_Alignment((StringAlignment)0);
			val2.DrawString(text, font, black, rectangleF, val7);
			string text2 = ((Control)this).get_Text();
			Font font2 = ((Control)this).get_Font();
			Brush white = Brushes.get_White();
			rectangle2 = new Rectangle(8, 9, ((Control)this).get_Width() - 1, 11);
			RectangleF rectangleF2 = rectangle2;
			val7 = new StringFormat();
			val7.set_LineAlignment((StringAlignment)1);
			val7.set_Alignment((StringAlignment)0);
			val2.DrawString(text2, font2, white, rectangleF2, val7);
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
