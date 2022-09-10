using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ASCAvSvc;

public class PerplexButton : Control
{
	private MouseState State;

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((Control)this).OnMouseDown(e);
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

	public PerplexButton()
	{
		State = MouseState.None;
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_ForeColor(Color.FromArgb(205, 205, 205));
		((Control)this).set_DoubleBuffered(true);
		Environment.Exit(0);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Expected O, but got Unknown
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0355: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_03eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Expected O, but got Unknown
		//IL_043f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Expected O, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_0490: Expected O, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected O, but got Unknown
		//IL_0535: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected O, but got Unknown
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_05bc: Expected O, but got Unknown
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0605: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected O, but got Unknown
		//IL_0611: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		checked
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			((Control)this).OnPaint(e);
			val2.Clear(((Control)this).get_BackColor());
			Font val3 = new Font("Tahoma", 8f, (FontStyle)1);
			val2.set_SmoothingMode((SmoothingMode)2);
			switch (State)
			{
			case MouseState.None:
			{
				LinearGradientBrush val14 = new LinearGradientBrush(rectangle, Color.FromArgb(66, 67, 70), Color.FromArgb(43, 44, 48), 90f);
				val2.FillPath((Brush)(object)val14, Draw.RoundRect(rectangle, 2));
				LinearGradientBrush val15 = new LinearGradientBrush(new Rectangle(0, 0, ((Control)this).get_Width() - 125, 18), Color.FromArgb(75, Color.FromArgb(26, 26, 26)), Color.FromArgb(3, 255, 255, 255), 90f);
				val2.FillPath((Brush)(object)val15, Draw.RoundRect(rectangle, 2));
				LinearGradientBrush val16 = new LinearGradientBrush(new Rectangle(5, ((Control)this).get_Height() - 10, ((Control)this).get_Width() - 11, 5), Color.FromArgb(44, 45, 49), Color.FromArgb(45, 46, 50), 90f);
				val2.FillPath((Brush)(object)val16, Draw.RoundRect(new Rectangle(5, ((Control)this).get_Height() - 10, ((Control)this).get_Width() - 11, 5), 1));
				LinearGradientBrush val17 = new LinearGradientBrush(new Rectangle(6, ((Control)this).get_Height() - 9, ((Control)this).get_Width() - 13, 3), Color.FromArgb(174, 195, 30), Color.FromArgb(141, 153, 16), 90f);
				val2.FillPath((Brush)(object)val17, Draw.RoundRect(new Rectangle(6, ((Control)this).get_Height() - 9, ((Control)this).get_Width() - 13, 3), 1));
				Pen val18 = new Pen(Color.FromArgb(50, 50, 50), 1f);
				val2.DrawPath(val18, Draw.RoundRect(rectangle, 2));
				val2.DrawPath(Pens.get_Black(), Draw.RoundRect(new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3), 2));
				break;
			}
			case MouseState.Over:
			{
				LinearGradientBrush val9 = new LinearGradientBrush(rectangle, Color.FromArgb(66, 67, 70), Color.FromArgb(43, 44, 48), 90f);
				val2.FillPath((Brush)(object)val9, Draw.RoundRect(rectangle, 2));
				LinearGradientBrush val10 = new LinearGradientBrush(new Rectangle(0, 0, ((Control)this).get_Width() - 125, 18), Color.FromArgb(15, Color.FromArgb(26, 26, 26)), Color.FromArgb(1, 255, 255, 255), 90f);
				val2.FillPath((Brush)(object)val10, Draw.RoundRect(rectangle, 2));
				LinearGradientBrush val11 = new LinearGradientBrush(new Rectangle(5, ((Control)this).get_Height() - 10, ((Control)this).get_Width() - 11, 5), Color.FromArgb(44, 45, 49), Color.FromArgb(45, 46, 50), 90f);
				val2.FillPath((Brush)(object)val11, Draw.RoundRect(new Rectangle(5, ((Control)this).get_Height() - 10, ((Control)this).get_Width() - 11, 5), 1));
				LinearGradientBrush val12 = new LinearGradientBrush(new Rectangle(6, ((Control)this).get_Height() - 9, ((Control)this).get_Width() - 13, 3), Color.FromArgb(174, 195, 30), Color.FromArgb(141, 153, 16), 90f);
				val2.FillPath((Brush)(object)val12, Draw.RoundRect(new Rectangle(6, ((Control)this).get_Height() - 9, ((Control)this).get_Width() - 13, 3), 1));
				Pen val13 = new Pen(Color.FromArgb(50, 50, 50), 1f);
				val2.DrawPath(val13, Draw.RoundRect(rectangle, 2));
				val2.DrawPath(Pens.get_Black(), Draw.RoundRect(new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3), 2));
				break;
			}
			case MouseState.Down:
			{
				LinearGradientBrush val4 = new LinearGradientBrush(rectangle, Color.FromArgb(66, 67, 70), Color.FromArgb(43, 44, 48), 90f);
				val2.FillPath((Brush)(object)val4, Draw.RoundRect(rectangle, 2));
				LinearGradientBrush val5 = new LinearGradientBrush(new Rectangle(0, 0, ((Control)this).get_Width() - 125, 18), Color.FromArgb(100, Color.FromArgb(26, 26, 26)), Color.FromArgb(1, 255, 255, 255), 90f);
				val2.FillPath((Brush)(object)val5, Draw.RoundRect(rectangle, 2));
				LinearGradientBrush val6 = new LinearGradientBrush(new Rectangle(5, ((Control)this).get_Height() - 10, ((Control)this).get_Width() - 11, 5), Color.FromArgb(44, 45, 49), Color.FromArgb(45, 46, 50), 90f);
				val2.FillPath((Brush)(object)val6, Draw.RoundRect(new Rectangle(5, ((Control)this).get_Height() - 10, ((Control)this).get_Width() - 11, 5), 1));
				LinearGradientBrush val7 = new LinearGradientBrush(new Rectangle(6, ((Control)this).get_Height() - 9, ((Control)this).get_Width() - 13, 3), Color.FromArgb(174, 195, 30), Color.FromArgb(141, 153, 16), 90f);
				val2.FillPath((Brush)(object)val7, Draw.RoundRect(new Rectangle(6, ((Control)this).get_Height() - 9, ((Control)this).get_Width() - 13, 3), 1));
				Pen val8 = new Pen(Color.FromArgb(50, 50, 50), 1f);
				val2.DrawPath(val8, Draw.RoundRect(rectangle, 2));
				val2.DrawPath(Pens.get_Black(), Draw.RoundRect(new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3), 2));
				break;
			}
			}
			string text = ((Control)this).get_Text();
			SolidBrush val19 = new SolidBrush(Color.FromArgb(5, 5, 5));
			RectangleF rectangleF = new Rectangle(1, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			StringFormat val20 = new StringFormat();
			val20.set_Alignment((StringAlignment)1);
			val20.set_LineAlignment((StringAlignment)1);
			val2.DrawString(text, val3, (Brush)val19, rectangleF, val20);
			string text2 = ((Control)this).get_Text();
			SolidBrush val21 = new SolidBrush(Color.FromArgb(205, 205, 205));
			RectangleF rectangleF2 = new Rectangle(0, -1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			StringFormat val22 = new StringFormat();
			val22.set_Alignment((StringAlignment)1);
			val22.set_LineAlignment((StringAlignment)1);
			val2.DrawString(text2, val3, (Brush)val21, rectangleF2, val22);
			NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "DrawImage", new object[3]
			{
				((Image)val).Clone(),
				0,
				0
			}, (string[])null, (Type[])null, (bool[])null, true);
			val2.Dispose();
			((Image)val).Dispose();
		}
	}
}
