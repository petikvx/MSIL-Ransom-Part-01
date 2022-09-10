using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

[ToolboxBitmap(typeof(Panel))]
public class GClass9 : Panel
{
	private Color color_0 = SystemColors.Window;

	private Color color_1 = SystemColors.Window;

	private GEnum1 genum1_0 = GEnum1.const_4;

	private BorderStyle borderStyle_0;

	private Color color_2 = SystemColors.WindowFrame;

	private int int_0 = 1;

	private int int_1;

	private GEnum2 genum2_0 = GEnum2.flag_15;

	[SpecialName]
	public Color method_0()
	{
		return color_0;
	}

	[SpecialName]
	public void method_1(Color color_3)
	{
		color_0 = color_3;
		if (((Component)this).DesignMode)
		{
			((Control)this).Invalidate();
		}
	}

	[SpecialName]
	public Color method_2()
	{
		return color_1;
	}

	[SpecialName]
	public void method_3(Color color_3)
	{
		color_1 = color_3;
		if (((Component)this).DesignMode)
		{
			((Control)this).Invalidate();
		}
	}

	[SpecialName]
	public GEnum1 method_4()
	{
		return genum1_0;
	}

	[SpecialName]
	public void method_5(GEnum1 genum1_1)
	{
		genum1_0 = genum1_1;
		if (((Component)this).DesignMode)
		{
			((Control)this).Invalidate();
		}
	}

	[SpecialName]
	public BorderStyle method_6()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return borderStyle_0;
	}

	[SpecialName]
	public void method_7(BorderStyle borderStyle_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		borderStyle_0 = borderStyle_1;
		if (((Component)this).DesignMode)
		{
			((Control)this).Invalidate();
		}
	}

	[SpecialName]
	public Color method_8()
	{
		return color_2;
	}

	[SpecialName]
	public void method_9(Color color_3)
	{
		color_2 = color_3;
		if (((Component)this).DesignMode)
		{
			((Control)this).Invalidate();
		}
	}

	[SpecialName]
	public int method_10()
	{
		return int_0;
	}

	[SpecialName]
	public void method_11(int int_2)
	{
		int_0 = int_2;
		if (((Component)this).DesignMode)
		{
			((Control)this).Invalidate();
		}
	}

	[SpecialName]
	public int method_12()
	{
		return int_1;
	}

	[SpecialName]
	public void method_13(int int_2)
	{
		int_1 = int_2;
		if (((Component)this).DesignMode)
		{
			((Control)this).Invalidate();
		}
	}

	[SpecialName]
	public GEnum2 method_14()
	{
		return genum2_0;
	}

	[SpecialName]
	public void method_15(GEnum2 genum2_1)
	{
		genum2_0 = genum2_1;
		if (((Component)this).DesignMode)
		{
			((Control)this).Invalidate();
		}
	}

	[SpecialName]
	private int method_16()
	{
		int num = 0;
		if (genum2_0 != 0)
		{
			num = ((int_1 <= ((Control)this).get_ClientRectangle().Width / 2) ? int_1 : smethod_1(((Control)this).get_ClientRectangle().Width / 2));
			if (num > ((Control)this).get_ClientRectangle().Height / 2)
			{
				num = smethod_1(((Control)this).get_ClientRectangle().Height / 2);
			}
		}
		return num;
	}

	public GClass9()
	{
		method_17();
		method_18();
	}

	private void method_17()
	{
		((Control)this).SetStyle((ControlStyles)65536, true);
		((Control)this).SetStyle((ControlStyles)8192, false);
		((Control)this).SetStyle((ControlStyles)16, true);
		((Control)this).SetStyle((ControlStyles)2, true);
		((Control)this).SetStyle((ControlStyles)2048, true);
	}

	private void method_18()
	{
		((Control)this).SuspendLayout();
		((Control)this).set_BackColor(Color.Transparent);
		method_7((BorderStyle)0);
		((Control)this).ResumeLayout(false);
	}

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Invalid comparison between Unknown and I4
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Invalid comparison between Unknown and I4
		((ScrollableControl)this).OnPaintBackground(pevent);
		pevent.get_Graphics().set_SmoothingMode((SmoothingMode)4);
		GraphicsPath val = method_19();
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		if (((Control)this).get_ClientRectangle().Width == 0)
		{
			clientRectangle.Width++;
		}
		if (((Control)this).get_ClientRectangle().Height == 0)
		{
			clientRectangle.Height++;
		}
		LinearGradientBrush val2 = ((genum1_0 != GEnum1.const_4) ? new LinearGradientBrush(clientRectangle, color_0, color_1, (LinearGradientMode)genum1_0) : new LinearGradientBrush(clientRectangle, color_0, color_0, (LinearGradientMode)1));
		pevent.get_Graphics().FillPath((Brush)(object)val2, val);
		((Brush)val2).Dispose();
		if ((int)borderStyle_0 == 1)
		{
			Pen val3 = new Pen(color_2, (float)int_0);
			pevent.get_Graphics().DrawPath(val3, val);
			val3.Dispose();
		}
		else if ((int)borderStyle_0 == 2)
		{
			smethod_0(pevent.get_Graphics(), ((Control)this).get_ClientRectangle());
		}
		((Brush)val2).Dispose();
		val.Dispose();
	}

	protected GraphicsPath method_19()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		GraphicsPath val = new GraphicsPath();
		if ((int)borderStyle_0 == 2)
		{
			val.AddRectangle(((Control)this).get_ClientRectangle());
			return val;
		}
		try
		{
			int num = 0;
			Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
			int num2 = 0;
			if ((int)borderStyle_0 == 1)
			{
				if (int_0 > 1)
				{
					num2 = smethod_1(method_10() / 2);
				}
				num = method_16();
			}
			else if ((int)borderStyle_0 != 2 && (int)borderStyle_0 == 0)
			{
				num = method_16();
			}
			if (num == 0)
			{
				val.AddRectangle(Rectangle.Inflate(clientRectangle, -num2, -num2));
				return val;
			}
			int num3 = clientRectangle.Width - 1 - num2;
			int num4 = clientRectangle.Height - 1 - num2;
			int num5 = 1;
			num5 = (((genum2_0 & GEnum2.flag_2) == 0) ? 1 : (num * 2));
			val.AddArc(num3 - num5, num2, num5, num5, 270f, 90f);
			num5 = (((genum2_0 & GEnum2.flag_8) == 0) ? 1 : (num * 2));
			val.AddArc(num3 - num5, num4 - num5, num5, num5, 0f, 90f);
			num5 = (((genum2_0 & GEnum2.flag_4) == 0) ? 1 : (num * 2));
			val.AddArc(num2, num4 - num5, num5, num5, 90f, 90f);
			num5 = (((genum2_0 & GEnum2.flag_1) == 0) ? 1 : (num * 2));
			val.AddArc(num2, num2, num5, num5, 180f, 90f);
			val.CloseFigure();
			return val;
		}
		catch (Exception)
		{
			val.AddRectangle(((Control)this).get_ClientRectangle());
			return val;
		}
	}

	public static void smethod_0(Graphics graphics_0, Rectangle rectangle_0)
	{
		graphics_0.set_SmoothingMode((SmoothingMode)0);
		graphics_0.DrawLine(SystemPens.get_ControlDark(), rectangle_0.X, rectangle_0.Y, rectangle_0.Width - 1, rectangle_0.Y);
		graphics_0.DrawLine(SystemPens.get_ControlDark(), rectangle_0.X, rectangle_0.Y, rectangle_0.X, rectangle_0.Height - 1);
		graphics_0.DrawLine(SystemPens.get_ControlDarkDark(), rectangle_0.X + 1, rectangle_0.Y + 1, rectangle_0.Width - 1, rectangle_0.Y + 1);
		graphics_0.DrawLine(SystemPens.get_ControlDarkDark(), rectangle_0.X + 1, rectangle_0.Y + 1, rectangle_0.X + 1, rectangle_0.Height - 1);
		graphics_0.DrawLine(SystemPens.get_ControlLight(), rectangle_0.X + 1, rectangle_0.Height - 2, rectangle_0.Width - 2, rectangle_0.Height - 2);
		graphics_0.DrawLine(SystemPens.get_ControlLight(), rectangle_0.Width - 2, rectangle_0.Y + 1, rectangle_0.Width - 2, rectangle_0.Height - 2);
		graphics_0.DrawLine(SystemPens.get_ControlLightLight(), rectangle_0.X, rectangle_0.Height - 1, rectangle_0.Width - 1, rectangle_0.Height - 1);
		graphics_0.DrawLine(SystemPens.get_ControlLightLight(), rectangle_0.Width - 1, rectangle_0.Y, rectangle_0.Width - 1, rectangle_0.Height - 1);
	}

	public static int smethod_1(double double_0)
	{
		return decimal.ToInt32(decimal.Floor(decimal.Parse(double_0.ToString())));
	}
}
