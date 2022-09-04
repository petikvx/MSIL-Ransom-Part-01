using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace nO_bUILDER;

public class InfluenceButton : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private MouseState State;

	private StringAlignment _align;

	public StringAlignment TextAlignment
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return _align;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_align = value;
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

	public InfluenceButton()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		__ENCAddToList(this);
		State = MouseState.None;
		_align = (StringAlignment)0;
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_Font(new Font("Verdana", 8.25f));
		((Control)this).set_DoubleBuffered(true);
		Size size = new Size(115, 30);
		((Control)this).set_Size(size);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_0110: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_026f: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0395: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0433: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected O, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_0559: Expected O, but got Unknown
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0596: Expected O, but got Unknown
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected O, but got Unknown
		//IL_05fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0604: Expected O, but got Unknown
		//IL_060f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0659: Expected O, but got Unknown
		//IL_0664: Unknown result type (might be due to invalid IL or missing references)
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			Draw draw = new Draw();
			val2.set_SmoothingMode((SmoothingMode)2);
			val2.Clear(((Control)this).get_BackColor());
			Rectangle rectangle2;
			switch (State)
			{
			case MouseState.None:
			{
				SolidBrush val13 = new SolidBrush(Color.FromArgb(20, 20, 20));
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				val2.FillPath((Brush)val13, draw.RoundRect(rectangle2, 2));
				LinearGradientBrush val14 = new LinearGradientBrush(rectangle, Color.FromArgb(125, 78, 75, 73), Color.FromArgb(125, 61, 59, 55), 90f);
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				val2.FillPath((Brush)(object)val14, draw.RoundRect(rectangle2, 2));
				HatchBrush val15 = new HatchBrush((HatchStyle)21, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				val2.FillPath((Brush)(object)val15, draw.RoundRect(rectangle2, 2));
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0));
				LinearGradientBrush val16 = new LinearGradientBrush(rectangle2, Color.FromArgb(35, Color.White), Color.FromArgb(0, Color.White), 90f);
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 1.0));
				val2.FillPath((Brush)(object)val16, draw.RoundRect(rectangle2, 2));
				Pen val17 = new Pen(Color.FromArgb(150, 97, 94, 90));
				rectangle2 = new Rectangle(0, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 3);
				val2.DrawPath(val17, draw.RoundRect(rectangle2, 2));
				Pen val18 = new Pen(Color.FromArgb(0, 0, 0));
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				val2.DrawPath(val18, draw.RoundRect(rectangle2, 2));
				break;
			}
			case MouseState.Over:
			{
				LinearGradientBrush val8 = new LinearGradientBrush(rectangle, Color.FromArgb(125, 78, 75, 73), Color.FromArgb(125, 61, 59, 55), 90f);
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				val2.FillPath((Brush)(object)val8, draw.RoundRect(rectangle2, 2));
				HatchBrush val9 = new HatchBrush((HatchStyle)21, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				val2.FillPath((Brush)(object)val9, draw.RoundRect(rectangle2, 2));
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0));
				LinearGradientBrush val10 = new LinearGradientBrush(rectangle2, Color.FromArgb(35, Color.White), Color.FromArgb(0, Color.White), 90f);
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 1.0));
				val2.FillPath((Brush)(object)val10, draw.RoundRect(rectangle2, 2));
				val2.FillPath((Brush)new SolidBrush(Color.FromArgb(15, Color.White)), draw.RoundRect(rectangle, 2));
				Pen val11 = new Pen(Color.FromArgb(150, 97, 94, 90));
				rectangle2 = new Rectangle(0, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 3);
				val2.DrawPath(val11, draw.RoundRect(rectangle2, 2));
				Pen val12 = new Pen(Color.FromArgb(0, 0, 0));
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				val2.DrawPath(val12, draw.RoundRect(rectangle2, 2));
				break;
			}
			case MouseState.Down:
			{
				LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(125, 78, 75, 73), Color.FromArgb(125, 61, 59, 55), 90f);
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				val2.FillPath((Brush)(object)val3, draw.RoundRect(rectangle2, 2));
				HatchBrush val4 = new HatchBrush((HatchStyle)21, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 2);
				val2.FillPath((Brush)(object)val4, draw.RoundRect(rectangle2, 2));
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0));
				LinearGradientBrush val5 = new LinearGradientBrush(rectangle2, Color.FromArgb(35, Color.White), Color.FromArgb(0, Color.White), 90f);
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 1.0));
				val2.FillPath((Brush)(object)val5, draw.RoundRect(rectangle2, 2));
				val2.FillPath((Brush)new SolidBrush(Color.FromArgb(15, Color.Black)), draw.RoundRect(rectangle, 2));
				Pen val6 = new Pen(Color.FromArgb(150, 97, 94, 90));
				rectangle2 = new Rectangle(0, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 3);
				val2.DrawPath(val6, draw.RoundRect(rectangle2, 2));
				Pen val7 = new Pen(Color.FromArgb(0, 0, 0));
				rectangle2 = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				val2.DrawPath(val7, draw.RoundRect(rectangle2, 2));
				break;
			}
			}
			string text = ((Control)this).get_Text();
			Font font = ((Control)this).get_Font();
			Brush black = Brushes.get_Black();
			rectangle2 = new Rectangle(5, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			RectangleF rectangleF = rectangle2;
			StringFormat val19 = new StringFormat();
			val19.set_LineAlignment((StringAlignment)1);
			val19.set_Alignment(_align);
			val2.DrawString(text, font, black, rectangleF, val19);
			string text2 = ((Control)this).get_Text();
			Font font2 = ((Control)this).get_Font();
			Brush white = Brushes.get_White();
			rectangle2 = new Rectangle(5, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			RectangleF rectangleF2 = rectangle2;
			val19 = new StringFormat();
			val19.set_LineAlignment((StringAlignment)1);
			val19.set_Alignment(_align);
			val2.DrawString(text2, font2, white, rectangleF2, val19);
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
