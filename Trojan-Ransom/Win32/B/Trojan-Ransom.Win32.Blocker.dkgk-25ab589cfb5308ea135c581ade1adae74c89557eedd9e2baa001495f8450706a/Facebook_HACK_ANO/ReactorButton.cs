using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Facebook_HACK_ANO;

public class ReactorButton : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private MouseState State;

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

	protected override void OnMouseEnter(EventArgs e)
	{
		((Control)this).OnMouseEnter(e);
		State = MouseState.Over;
		((Control)this).Invalidate();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((Control)this).OnMouseDown(e);
		State = MouseState.Down;
		((Control)this).Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		State = MouseState.None;
		((Control)this).Invalidate();
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		State = MouseState.Over;
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

	public ReactorButton()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		__ENCAddToList(this);
		State = MouseState.None;
		((Control)this).set_BackColor(Color.FromArgb(38, 38, 38));
		((Control)this).set_Font(new Font("Verdana", 6.75f));
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Expected O, but got Unknown
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0358: Expected O, but got Unknown
		//IL_0353: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b2: Expected O, but got Unknown
		//IL_03fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		Graphics graphics = e.get_Graphics();
		((Control)this).OnPaint(e);
		graphics.Clear(Color.FromArgb(36, 34, 30));
		checked
		{
			Rectangle rectangle;
			switch (State)
			{
			case MouseState.None:
			{
				graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(36, 34, 30))), 2, ((Control)this).get_Height() - 1, ((Control)this).get_Width() - 4, ((Control)this).get_Height() - 1);
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				LinearGradientBrush val5 = new LinearGradientBrush(rectangle, Color.FromArgb(10, 9, 8), Color.FromArgb(31, 29, 26), 90f);
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				graphics.FillRectangle((Brush)(object)val5, rectangle);
				Pen val6 = new Pen((Brush)new SolidBrush(Color.FromArgb(46, 45, 44)));
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 4);
				graphics.DrawRectangle(val6, rectangle);
				break;
			}
			case MouseState.Over:
			{
				graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(46, 44, 38))), 2, ((Control)this).get_Height() - 1, ((Control)this).get_Width() - 4, ((Control)this).get_Height() - 1);
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(219, 78, 0), Color.FromArgb(230, 95, 0), 90f);
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				graphics.FillRectangle((Brush)(object)val3, rectangle);
				Pen val4 = new Pen((Brush)new SolidBrush(Color.FromArgb(245, 120, 10)));
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 4);
				graphics.DrawRectangle(val4, rectangle);
				break;
			}
			case MouseState.Down:
			{
				graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(36, 34, 30))), 2, ((Control)this).get_Height() - 1, ((Control)this).get_Width() - 4, ((Control)this).get_Height() - 1);
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				LinearGradientBrush val = new LinearGradientBrush(rectangle, Color.FromArgb(209, 68, 0), Color.FromArgb(210, 75, 0), 270f);
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				graphics.FillRectangle((Brush)(object)val, rectangle);
				Pen val2 = new Pen((Brush)new SolidBrush(Color.FromArgb(225, 110, 30)));
				rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 4);
				graphics.DrawRectangle(val2, rectangle);
				break;
			}
			}
			rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 2.0));
			LinearGradientBrush val7 = new LinearGradientBrush(rectangle, Color.FromArgb(80, Color.White), Color.FromArgb(50, Color.White), 90f);
			rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 2, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 2.0));
			graphics.FillRectangle((Brush)(object)val7, rectangle);
			Pen val8 = new Pen((Brush)new SolidBrush(Color.FromArgb(21, 20, 18)));
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
			graphics.DrawRectangle(val8, rectangle);
			string text = ((Control)this).get_Text();
			Font font = ((Control)this).get_Font();
			Brush black = Brushes.get_Black();
			rectangle = new Rectangle(0, -2, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			RectangleF rectangleF = rectangle;
			StringFormat val9 = new StringFormat();
			val9.set_LineAlignment((StringAlignment)1);
			val9.set_Alignment((StringAlignment)1);
			graphics.DrawString(text, font, black, rectangleF, val9);
			string text2 = ((Control)this).get_Text();
			Font font2 = ((Control)this).get_Font();
			Brush white = Brushes.get_White();
			rectangle = new Rectangle(0, -1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			RectangleF rectangleF2 = rectangle;
			val9 = new StringFormat();
			val9.set_LineAlignment((StringAlignment)1);
			val9.set_Alignment((StringAlignment)1);
			graphics.DrawString(text2, font2, white, rectangleF2, val9);
		}
	}
}
