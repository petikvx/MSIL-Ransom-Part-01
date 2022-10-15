using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

internal class Control7 : Control3
{
	private ColorBlend colorBlend_0;

	private float float_0;

	private int int_2;

	private int int_3;

	private int int_4;

	public Control7()
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		Class14.vPNVHkezq0oMI();
		base._002Ector();
		float_0 = -1f;
		int_3 = 100;
		colorBlend_0 = new ColorBlend();
		colorBlend_0.set_Colors(new Color[4]
		{
			Color.FromArgb(153, 76, 0),
			Color.FromArgb(195, 97, 0),
			Color.FromArgb(195, 97, 0),
			Color.FromArgb(153, 76, 0)
		});
		colorBlend_0.set_Positions(new float[4] { 0f, 0.4f, 0.6f, 1f });
	}

	protected override void OnCreation()
	{
		if (!((Component)(object)this).DesignMode)
		{
			Thread thread = new Thread(method_77);
			thread.IsBackground = true;
			thread.Start();
		}
	}

	private void method_77()
	{
		while (true)
		{
			float_0 += 0.01f;
			if (float_0 >= 1f)
			{
				float_0 = -1f;
			}
			((Control)this).Invalidate();
			Thread.Sleep(25);
		}
	}

	[SpecialName]
	public int method_78()
	{
		return int_2;
	}

	[SpecialName]
	public void method_79(int int_5)
	{
		if (int_5 > int_3)
		{
			int_5 = int_3;
		}
		if (int_5 < 0)
		{
			int_5 = 0;
		}
		int_2 = int_5;
		((Control)this).Invalidate();
	}

	[SpecialName]
	public int method_80()
	{
		return int_3;
	}

	[SpecialName]
	public void method_81(int int_5)
	{
		if (int_5 < 1)
		{
			int_5 = 1;
		}
		if (int_2 > int_5)
		{
			int_2 = int_5;
		}
		int_3 = int_5;
		((Control)this).Invalidate();
	}

	public void method_82(int int_5)
	{
		method_79(checked(method_78() + int_5));
	}

	protected override void ColorHook()
	{
	}

	protected override void PaintHook()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		method_48(new Pen(Color.FromArgb(40, 40, 40)), 1);
		graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(40, 40, 40)), 0, 0, ((Control)this).get_Width(), 8);
		checked
		{
			method_63(Color.FromArgb(20, 20, 20), Color.FromArgb(20, 20, 20), 2, 2, ((Control)this).get_Width() - 4, ((Control)this).get_Height() - 4, 90f);
			int_4 = (int)Math.Round((double)int_2 / (double)int_3 * (double)((Control)this).get_Width());
			if (int_4 != 0)
			{
				Graphics obj = graphics_0;
				Rectangle clip = new Rectangle(3, 3, int_4 - 6, ((Control)this).get_Height() - 6);
				obj.SetClip(clip);
				graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(153, 76, 0)), 0, 0, int_4, ((Control)this).get_Height());
				HatchBrush val = new HatchBrush((HatchStyle)21, Color.FromArgb(30, Color.Black), Color.Transparent);
				method_59(colorBlend_0, (int)Math.Round(float_0 * (float)int_4), 0, int_4, ((Control)this).get_Height(), 0f);
				method_53(new Pen(Color.FromArgb(15, Color.White)), 3, 3, int_4 - 6, ((Control)this).get_Height() - 6);
				graphics_0.FillRectangle((Brush)(object)val, 0, 0, int_4, ((Control)this).get_Height());
				graphics_0.FillRectangle((Brush)new SolidBrush(Color.FromArgb(13, Color.White)), 3, 3, ((Control)this).get_Width() - 6, 5);
				graphics_0.ResetClip();
			}
			method_48(Pens.get_Black(), 2);
			method_51(Pens.get_Black());
		}
	}
}
