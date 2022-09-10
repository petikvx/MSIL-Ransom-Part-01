using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ASCAvSvc;

public class PerplexControlBox : Control
{
	private MouseState State;

	private Rectangle MinBtn;

	private Rectangle MaxBtn;

	private int X;

	protected override void OnMouseDown(MouseEventArgs e)
	{
		((Control)this).OnMouseDown(e);
		if (e.get_Location().X <= 0 || e.get_Location().X >= 20)
		{
			if (e.get_Location().X > 25 && e.get_Location().X < 45)
			{
				((Control)this).FindForm().Close();
			}
		}
		else
		{
			((Control)this).FindForm().set_WindowState((FormWindowState)1);
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

	public PerplexControlBox()
	{
		State = MouseState.None;
		MinBtn = new Rectangle(0, 0, 20, 20);
		MaxBtn = new Rectangle(25, 0, 20, 20);
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_ForeColor(Color.FromArgb(205, 205, 205));
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2: Expected O, but got Unknown
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ca: Expected O, but got Unknown
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_040f: Expected O, but got Unknown
		//IL_0419: Unknown result type (might be due to invalid IL or missing references)
		//IL_0420: Expected O, but got Unknown
		//IL_0431: Unknown result type (might be due to invalid IL or missing references)
		//IL_0438: Expected O, but got Unknown
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_049a: Expected O, but got Unknown
		//IL_04bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Expected O, but got Unknown
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e6: Expected O, but got Unknown
		//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fe: Expected O, but got Unknown
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_053f: Expected O, but got Unknown
		//IL_0564: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected O, but got Unknown
		//IL_0584: Unknown result type (might be due to invalid IL or missing references)
		//IL_058b: Expected O, but got Unknown
		//IL_059c: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a3: Expected O, but got Unknown
		//IL_05e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e9: Expected O, but got Unknown
		//IL_060e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0624: Expected O, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Expected O, but got Unknown
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Expected O, but got Unknown
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0692: Expected O, but got Unknown
		//IL_06b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cd: Expected O, but got Unknown
		//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_06de: Expected O, but got Unknown
		//IL_06ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f6: Expected O, but got Unknown
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_073c: Expected O, but got Unknown
		//IL_0761: Unknown result type (might be due to invalid IL or missing references)
		//IL_0777: Expected O, but got Unknown
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		//IL_0799: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected O, but got Unknown
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e1: Expected O, but got Unknown
		//IL_0806: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Expected O, but got Unknown
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_082d: Expected O, but got Unknown
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0845: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		((Control)this).OnPaint(e);
		val2.Clear(((Control)this).get_BackColor());
		val2.set_SmoothingMode((SmoothingMode)2);
		switch (State)
		{
		default:
		{
			LinearGradientBrush val33 = new LinearGradientBrush(MinBtn, Color.FromArgb(66, 67, 70), Color.FromArgb(43, 44, 48), 90f);
			val2.FillPath((Brush)(object)val33, Draw.RoundRect(MinBtn, 4));
			val2.DrawPath(new Pen(Color.FromArgb(21, 21, 21), 1f), Draw.RoundRect(MinBtn, 4));
			Font val34 = new Font("Marlett", 9f);
			SolidBrush val35 = new SolidBrush(Color.FromArgb(174, 195, 30));
			val2.DrawString("0", val34, (Brush)(object)val35, 4f, 4f);
			LinearGradientBrush val36 = new LinearGradientBrush(MaxBtn, Color.FromArgb(66, 67, 70), Color.FromArgb(43, 44, 48), 90f);
			val2.FillPath((Brush)(object)val36, Draw.RoundRect(MaxBtn, 4));
			val2.DrawPath(new Pen(Color.FromArgb(21, 21, 21), 1f), Draw.RoundRect(MaxBtn, 4));
			Font val37 = new Font("Marlett", 9f);
			SolidBrush val38 = new SolidBrush(Color.FromArgb(174, 195, 30));
			val2.DrawString("r", val37, (Brush)(object)val38, 28f, 4f);
			break;
		}
		case MouseState.None:
		{
			LinearGradientBrush val27 = new LinearGradientBrush(MinBtn, Color.FromArgb(66, 67, 70), Color.FromArgb(43, 44, 48), 90f);
			val2.FillPath((Brush)(object)val27, Draw.RoundRect(MinBtn, 4));
			val2.DrawPath(new Pen(Color.FromArgb(21, 21, 21), 1f), Draw.RoundRect(MinBtn, 4));
			Font val28 = new Font("Marlett", 9f);
			SolidBrush val29 = new SolidBrush(Color.FromArgb(174, 195, 30));
			val2.DrawString("0", val28, (Brush)(object)val29, 4f, 4f);
			LinearGradientBrush val30 = new LinearGradientBrush(MaxBtn, Color.FromArgb(66, 67, 70), Color.FromArgb(43, 44, 48), 90f);
			val2.FillPath((Brush)(object)val30, Draw.RoundRect(MaxBtn, 4));
			val2.DrawPath(new Pen(Color.FromArgb(21, 21, 21), 1f), Draw.RoundRect(MaxBtn, 4));
			Font val31 = new Font("Marlett", 9f);
			SolidBrush val32 = new SolidBrush(Color.FromArgb(174, 195, 30));
			val2.DrawString("r", val31, (Brush)(object)val32, 28f, 4f);
			break;
		}
		case MouseState.Over:
			if (X > 0 && X < 20)
			{
				LinearGradientBrush val9 = new LinearGradientBrush(MinBtn, Color.FromArgb(100, 66, 67, 70), Color.FromArgb(100, 43, 44, 48), 90f);
				val2.FillPath((Brush)(object)val9, Draw.RoundRect(MinBtn, 4));
				val2.DrawPath(new Pen(Color.FromArgb(21, 21, 21), 1f), Draw.RoundRect(MinBtn, 4));
				Font val10 = new Font("Marlett", 9f);
				SolidBrush val11 = new SolidBrush(Color.FromArgb(174, 195, 30));
				val2.DrawString("0", val10, (Brush)(object)val11, 4f, 4f);
				LinearGradientBrush val12 = new LinearGradientBrush(MaxBtn, Color.FromArgb(66, 67, 70), Color.FromArgb(43, 44, 48), 90f);
				val2.FillPath((Brush)(object)val12, Draw.RoundRect(MaxBtn, 4));
				val2.DrawPath(new Pen(Color.FromArgb(21, 21, 21), 1f), Draw.RoundRect(MaxBtn, 4));
				Font val13 = new Font("Marlett", 9f);
				SolidBrush val14 = new SolidBrush(Color.FromArgb(174, 195, 30));
				val2.DrawString("r", val13, (Brush)(object)val14, 28f, 4f);
			}
			else if (X <= 25 || X >= 45)
			{
				LinearGradientBrush val15 = new LinearGradientBrush(MinBtn, Color.FromArgb(66, 67, 70), Color.FromArgb(43, 44, 48), 90f);
				val2.FillPath((Brush)(object)val15, Draw.RoundRect(MinBtn, 4));
				val2.DrawPath(new Pen(Color.FromArgb(21, 21, 21), 1f), Draw.RoundRect(MinBtn, 4));
				Font val16 = new Font("Marlett", 9f);
				SolidBrush val17 = new SolidBrush(Color.FromArgb(174, 195, 30));
				val2.DrawString("0", val16, (Brush)(object)val17, 4f, 4f);
				LinearGradientBrush val18 = new LinearGradientBrush(MaxBtn, Color.FromArgb(66, 67, 70), Color.FromArgb(43, 44, 48), 90f);
				val2.FillPath((Brush)(object)val18, Draw.RoundRect(MaxBtn, 4));
				val2.DrawPath(new Pen(Color.FromArgb(21, 21, 21), 1f), Draw.RoundRect(MaxBtn, 4));
				Font val19 = new Font("Marlett", 9f);
				SolidBrush val20 = new SolidBrush(Color.FromArgb(174, 195, 30));
				val2.DrawString("r", val19, (Brush)(object)val20, 28f, 4f);
			}
			else
			{
				LinearGradientBrush val21 = new LinearGradientBrush(MinBtn, Color.FromArgb(66, 67, 70), Color.FromArgb(43, 44, 48), 90f);
				val2.FillPath((Brush)(object)val21, Draw.RoundRect(MinBtn, 4));
				val2.DrawPath(new Pen(Color.FromArgb(21, 21, 21), 1f), Draw.RoundRect(MinBtn, 4));
				Font val22 = new Font("Marlett", 9f);
				SolidBrush val23 = new SolidBrush(Color.FromArgb(174, 195, 30));
				val2.DrawString("0", val22, (Brush)(object)val23, 4f, 4f);
				LinearGradientBrush val24 = new LinearGradientBrush(MaxBtn, Color.FromArgb(100, 66, 67, 70), Color.FromArgb(100, 43, 44, 48), 90f);
				val2.FillPath((Brush)(object)val24, Draw.RoundRect(MaxBtn, 4));
				val2.DrawPath(new Pen(Color.FromArgb(21, 21, 21), 1f), Draw.RoundRect(MaxBtn, 4));
				Font val25 = new Font("Marlett", 9f);
				SolidBrush val26 = new SolidBrush(Color.FromArgb(174, 195, 30));
				val2.DrawString("r", val25, (Brush)(object)val26, 28f, 4f);
			}
			break;
		case MouseState.Down:
		{
			LinearGradientBrush val3 = new LinearGradientBrush(MinBtn, Color.FromArgb(66, 67, 70), Color.FromArgb(43, 44, 48), 90f);
			val2.FillPath((Brush)(object)val3, Draw.RoundRect(MinBtn, 4));
			val2.DrawPath(new Pen(Color.FromArgb(21, 21, 21), 1f), Draw.RoundRect(MinBtn, 4));
			Font val4 = new Font("Marlett", 9f);
			SolidBrush val5 = new SolidBrush(Color.FromArgb(174, 195, 30));
			val2.DrawString("0", val4, (Brush)(object)val5, 4f, 4f);
			LinearGradientBrush val6 = new LinearGradientBrush(MaxBtn, Color.FromArgb(66, 67, 70), Color.FromArgb(43, 44, 48), 90f);
			val2.FillPath((Brush)(object)val6, Draw.RoundRect(MaxBtn, 4));
			val2.DrawPath(new Pen(Color.FromArgb(21, 21, 21), 1f), Draw.RoundRect(MaxBtn, 4));
			Font val7 = new Font("Marlett", 9f);
			SolidBrush val8 = new SolidBrush(Color.FromArgb(174, 195, 30));
			val2.DrawString("r", val7, (Brush)(object)val8, 28f, 4f);
			break;
		}
		}
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
