using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace nO_bUILDER;

public class ExcisionControlBox : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private MouseState State;

	private int X;

	private Rectangle MinBtn;

	private Rectangle CloseBtn;

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

	public ExcisionControlBox()
	{
		__ENCAddToList(this);
		State = MouseState.None;
		ref Rectangle minBtn = ref MinBtn;
		minBtn = new Rectangle(0, 0, 32, 25);
		ref Rectangle closeBtn = ref CloseBtn;
		closeBtn = new Rectangle(33, 0, 65, 25);
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_ForeColor(Color.FromArgb(205, 205, 205));
		Size size = new Size(65, 26);
		((Control)this).set_Size(size);
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((Control)this).OnMouseDown(e);
		if ((X > MinBtn.X) & (X < checked(MinBtn.X + 32)))
		{
			((Control)this).FindForm().set_WindowState((FormWindowState)1);
		}
		else
		{
			((Control)this).FindForm().Close();
		}
		State = MouseState.Down;
		((Control)this).Invalidate();
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		((Control)this).OnMouseUp(e);
		State = MouseState.Over;
		((Control)this).Invalidate();
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		((Control)this).OnMouseEnter(e);
		State = MouseState.Over;
		((Control)this).Invalidate();
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		((Control)this).OnMouseLeave(e);
		State = MouseState.None;
		((Control)this).Invalidate();
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		((Control)this).OnMouseMove(e);
		X = e.get_Location().X;
		((Control)this).Invalidate();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00dd: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_013b: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01cd: Expected O, but got Unknown
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_0223: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_0282: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02e6: Expected O, but got Unknown
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_031f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_033d: Expected O, but got Unknown
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Expected O, but got Unknown
		//IL_039b: Expected O, but got Unknown
		//IL_03bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected O, but got Unknown
		//IL_03ff: Expected O, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_045d: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		Rectangle rectangle = new Rectangle(0, 0, 64, 25);
		Rectangle rectangle2 = new Rectangle(1, 1, 62, 23);
		((Control)this).OnPaint(e);
		val2.Clear(((Control)this).get_BackColor());
		Font val3 = new Font("Marlett", 10f, (FontStyle)1);
		val2.set_SmoothingMode((SmoothingMode)2);
		checked
		{
			switch (State)
			{
			case MouseState.None:
			{
				SolidBrush val13 = new SolidBrush(Color.FromArgb(178, 178, 178));
				Rectangle rectangle3 = new Rectangle(17, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				RectangleF rectangleF9 = rectangle3;
				StringFormat val5 = new StringFormat();
				val5.set_Alignment((StringAlignment)1);
				val5.set_LineAlignment((StringAlignment)1);
				val2.DrawString("r", val3, (Brush)val13, rectangleF9, val5);
				SolidBrush val14 = new SolidBrush(Color.FromArgb(178, 178, 178));
				rectangle3 = new Rectangle(8, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				RectangleF rectangleF10 = rectangle3;
				val5 = new StringFormat();
				val5.set_Alignment((StringAlignment)0);
				val5.set_LineAlignment((StringAlignment)1);
				val2.DrawString("0", val3, (Brush)val14, rectangleF10, val5);
				break;
			}
			case MouseState.Over:
				if ((X > MinBtn.X) & (X < MinBtn.X + 32))
				{
					SolidBrush val7 = new SolidBrush(Color.FromArgb(178, 178, 178));
					Rectangle rectangle3 = new Rectangle(8, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
					RectangleF rectangleF3 = rectangle3;
					StringFormat val5 = new StringFormat();
					val5.set_Alignment((StringAlignment)0);
					val5.set_LineAlignment((StringAlignment)1);
					val2.DrawString("0", val3, (Brush)val7, rectangleF3, val5);
					SolidBrush val8 = new SolidBrush(Color.FromArgb(95, Color.Green));
					rectangle3 = new Rectangle(8, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
					RectangleF rectangleF4 = rectangle3;
					val5 = new StringFormat();
					val5.set_Alignment((StringAlignment)0);
					val5.set_LineAlignment((StringAlignment)1);
					val2.DrawString("0", val3, (Brush)val8, rectangleF4, val5);
					SolidBrush val9 = new SolidBrush(Color.FromArgb(178, 178, 178));
					rectangle3 = new Rectangle(17, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
					RectangleF rectangleF5 = rectangle3;
					val5 = new StringFormat();
					val5.set_Alignment((StringAlignment)1);
					val5.set_LineAlignment((StringAlignment)1);
					val2.DrawString("r", val3, (Brush)val9, rectangleF5, val5);
				}
				else
				{
					SolidBrush val10 = new SolidBrush(Color.FromArgb(178, 178, 178));
					Rectangle rectangle3 = new Rectangle(17, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
					RectangleF rectangleF6 = rectangle3;
					StringFormat val5 = new StringFormat();
					val5.set_Alignment((StringAlignment)1);
					val5.set_LineAlignment((StringAlignment)1);
					val2.DrawString("r", val3, (Brush)val10, rectangleF6, val5);
					SolidBrush val11 = new SolidBrush(Color.FromArgb(95, Color.Red));
					rectangle3 = new Rectangle(17, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
					RectangleF rectangleF7 = rectangle3;
					val5 = new StringFormat();
					val5.set_Alignment((StringAlignment)1);
					val5.set_LineAlignment((StringAlignment)1);
					val2.DrawString("r", val3, (Brush)val11, rectangleF7, val5);
					SolidBrush val12 = new SolidBrush(Color.FromArgb(178, 178, 178));
					rectangle3 = new Rectangle(8, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
					RectangleF rectangleF8 = rectangle3;
					val5 = new StringFormat();
					val5.set_Alignment((StringAlignment)0);
					val5.set_LineAlignment((StringAlignment)1);
					val2.DrawString("0", val3, (Brush)val12, rectangleF8, val5);
				}
				break;
			case MouseState.Down:
			{
				SolidBrush val4 = new SolidBrush(Color.FromArgb(178, 178, 178));
				Rectangle rectangle3 = new Rectangle(17, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				RectangleF rectangleF = rectangle3;
				StringFormat val5 = new StringFormat();
				val5.set_Alignment((StringAlignment)1);
				val5.set_LineAlignment((StringAlignment)1);
				val2.DrawString("r", val3, (Brush)val4, rectangleF, val5);
				SolidBrush val6 = new SolidBrush(Color.FromArgb(178, 178, 178));
				rectangle3 = new Rectangle(8, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				RectangleF rectangleF2 = rectangle3;
				val5 = new StringFormat();
				val5.set_Alignment((StringAlignment)0);
				val5.set_LineAlignment((StringAlignment)1);
				val2.DrawString("0", val3, (Brush)val6, rectangleF2, val5);
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
