using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace nO_bUILDER;

public class InfluenceTopButton : Control
{
	public enum ButtonType : byte
	{
		Blank,
		Close,
		Minim
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private MouseState State;

	private ButtonType _type;

	public ButtonType ButtonIcon
	{
		get
		{
			return _type;
		}
		set
		{
			_type = value;
			((Control)this).Invalidate();
		}
	}

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

	protected override void OnTextChanged(EventArgs e)
	{
		((Control)this).OnTextChanged(e);
		((Control)this).Invalidate();
	}

	public InfluenceTopButton()
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		__ENCAddToList(this);
		State = MouseState.None;
		_type = ButtonType.Blank;
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_Font(new Font("Verdana", 8.25f));
		Size size = new Size(43, 21);
		((Control)this).set_Size(size);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).Focus();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_028a: Expected O, but got Unknown
		//IL_029b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_0348: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Expected O, but got Unknown
		//IL_03a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Expected O, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0422: Expected O, but got Unknown
		//IL_042e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Expected O, but got Unknown
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d4: Expected O, but got Unknown
		//IL_04eb: Expected O, but got Unknown
		//IL_04eb: Expected O, but got Unknown
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected O, but got Unknown
		//IL_0567: Expected O, but got Unknown
		//IL_0567: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		new Draw();
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			val2.Clear(((Control)this).get_BackColor());
			switch (State)
			{
			case MouseState.None:
			{
				LinearGradientBrush val15 = new LinearGradientBrush(rectangle, Color.FromArgb(125, 78, 75, 73), Color.FromArgb(125, 61, 59, 55), 90f);
				val2.FillRectangle((Brush)(object)val15, val15.get_Rectangle());
				HatchBrush val16 = new HatchBrush((HatchStyle)21, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
				val2.FillRectangle((Brush)(object)val16, val15.get_Rectangle());
				Rectangle rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0));
				LinearGradientBrush val17 = new LinearGradientBrush(rectangle2, Color.FromArgb(35, Color.White), Color.FromArgb(0, Color.White), 90f);
				val2.FillRectangle((Brush)(object)val17, val17.get_Rectangle());
				Pen val18 = new Pen(Color.FromArgb(150, 97, 94, 90));
				rectangle2 = new Rectangle(0, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 3);
				val2.DrawRectangle(val18, rectangle2);
				Pen val19 = new Pen(Color.FromArgb(20, 20, 20));
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				val2.DrawRectangle(val19, rectangle2);
				break;
			}
			case MouseState.Over:
			{
				LinearGradientBrush val9 = new LinearGradientBrush(rectangle, Color.FromArgb(125, 78, 75, 73), Color.FromArgb(125, 61, 59, 55), 90f);
				val2.FillRectangle((Brush)(object)val9, val9.get_Rectangle());
				HatchBrush val10 = new HatchBrush((HatchStyle)21, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
				val2.FillRectangle((Brush)(object)val10, val9.get_Rectangle());
				Rectangle rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0));
				LinearGradientBrush val11 = new LinearGradientBrush(rectangle2, Color.FromArgb(35, Color.White), Color.FromArgb(0, Color.White), 90f);
				val2.FillRectangle((Brush)(object)val11, val11.get_Rectangle());
				SolidBrush val12 = new SolidBrush(Color.FromArgb(15, Color.White));
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				val2.FillRectangle((Brush)val12, rectangle2);
				Pen val13 = new Pen(Color.FromArgb(150, 97, 94, 90));
				rectangle2 = new Rectangle(0, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 3);
				val2.DrawRectangle(val13, rectangle2);
				Pen val14 = new Pen(Color.FromArgb(20, 20, 20));
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				val2.DrawRectangle(val14, rectangle2);
				break;
			}
			case MouseState.Down:
			{
				LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(125, 78, 75, 73), Color.FromArgb(125, 61, 59, 55), 90f);
				val2.FillRectangle((Brush)(object)val3, val3.get_Rectangle());
				HatchBrush val4 = new HatchBrush((HatchStyle)21, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
				val2.FillRectangle((Brush)(object)val4, val3.get_Rectangle());
				Rectangle rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0));
				LinearGradientBrush val5 = new LinearGradientBrush(rectangle2, Color.FromArgb(35, Color.White), Color.FromArgb(0, Color.White), 90f);
				val2.FillRectangle((Brush)(object)val5, val5.get_Rectangle());
				SolidBrush val6 = new SolidBrush(Color.FromArgb(15, Color.Black));
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				val2.FillRectangle((Brush)val6, rectangle2);
				Pen val7 = new Pen(Color.FromArgb(150, 97, 94, 90));
				rectangle2 = new Rectangle(0, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 3);
				val2.DrawRectangle(val7, rectangle2);
				Pen val8 = new Pen(Color.FromArgb(20, 20, 20));
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				val2.DrawRectangle(val8, rectangle2);
				break;
			}
			}
			switch (_type)
			{
			case ButtonType.Close:
			{
				Size size = new Size(43, 21);
				((Control)this).set_Size(size);
				Font val23 = new Font("Marlett", 8.75f);
				SolidBrush val24 = new SolidBrush(Color.FromArgb(220, Color.White));
				Rectangle rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				RectangleF rectangleF2 = rectangle2;
				StringFormat val22 = new StringFormat();
				val22.set_Alignment((StringAlignment)1);
				val22.set_LineAlignment((StringAlignment)1);
				val2.DrawString("r", val23, (Brush)val24, rectangleF2, val22);
				break;
			}
			case ButtonType.Minim:
			{
				Size size = new Size(30, 21);
				((Control)this).set_Size(size);
				Font val20 = new Font("Marlett", 8.75f);
				SolidBrush val21 = new SolidBrush(Color.FromArgb(220, Color.White));
				Rectangle rectangle2 = new Rectangle(2, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				RectangleF rectangleF = rectangle2;
				StringFormat val22 = new StringFormat();
				val22.set_Alignment((StringAlignment)1);
				val22.set_LineAlignment((StringAlignment)1);
				val2.DrawString("0", val20, (Brush)val21, rectangleF, val22);
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
