using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using ns0;

namespace ns1;

public class LXProgressBar : Control
{
	private int int_0 = 50;

	private int int_1 = 100;

	private int int_2;

	internal int int_3;

	internal bool bool_0;

	public int Value
	{
		get
		{
			if (int_2 == 0)
			{
				return 0;
			}
			return int_2;
		}
		set
		{
			((Control)this).Invalidate();
		}
	}

	public bool ShowPercentage
	{
		get
		{
			return bool_0;
		}
		set
		{
			((Control)this).Invalidate();
		}
	}

	protected override void vmethod_0()
	{
		((Control)this).CreateHandle();
	}

	public void method_0()
	{
		while (true)
		{
			if (int_3 <= ((Control)this).get_Width())
			{
				int_3++;
			}
			else
			{
				int_3 = 0;
			}
			((Control)this).Invalidate();
			Thread.Sleep(int_0);
		}
	}

	public LXProgressBar()
	{
		((Control)this).set_DoubleBuffered(true);
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
	}

	protected override void vmethod_1(PaintEventArgs paintEventArgs_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Expected O, but got Unknown
		//IL_021f: Expected O, but got Unknown
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.set_SmoothingMode((SmoothingMode)2);
		int num = Convert.ToInt32((double)int_2 / (double)int_1 * (double)((Control)this).get_Width());
		val2.Clear(((Control)this).get_BackColor());
		SolidBrush val3 = new SolidBrush(Color.White);
		Color[] color_ = new Color[8]
		{
			Color.FromArgb(20, 20, 20),
			Color.FromArgb(40, 40, 40),
			Color.FromArgb(45, 45, 45),
			Color.FromArgb(46, 46, 46),
			Color.FromArgb(47, 47, 47),
			Color.FromArgb(48, 48, 48),
			Color.FromArgb(49, 49, 49),
			Color.FromArgb(50, 50, 50)
		};
		val2.FillPath((Brush)new SolidBrush(Color.FromArgb(50, 50, 50)), Class1.smethod_0(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1), 3));
		Class1.smethod_3(val2, ((Control)this).get_ClientRectangle(), 3, color_);
		if (num == 0)
		{
			val2.FillPath((Brush)new LinearGradientBrush(new Rectangle(1, 1, num, ((Control)this).get_Height() - 3), Color.FromArgb(30, 30, 30), Color.FromArgb(35, 35, 35), 90f), Class1.smethod_0(new Rectangle(1, 1, num, ((Control)this).get_Height() - 3), 2));
			val2.DrawPath(new Pen(Color.FromArgb(45, 45, 45)), Class1.smethod_0(new Rectangle(1, 1, num, ((Control)this).get_Height() - 3), 2));
			val3 = new SolidBrush(Color.White);
		}
		if (bool_0)
		{
			string? text = Convert.ToString(Value + "  ");
			Font val4 = new Font(" ", 9f, (FontStyle)1);
			SolidBrush obj = val3;
			RectangleF rectangleF = new Rectangle(0, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			StringFormat val5 = new StringFormat();
			val5.set_Alignment((StringAlignment)1);
			val5.set_LineAlignment((StringAlignment)1);
			val2.DrawString(text, val4, (Brush)(object)obj, rectangleF, val5);
		}
		paintEventArgs_0.get_Graphics().DrawImage((Image)((Image)val).Clone(), 0, 0);
		val2.Dispose();
		((Image)val).Dispose();
	}
}
