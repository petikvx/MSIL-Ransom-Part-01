using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ns1;

public class EtherealSeperator : Control
{
	public enum Style
	{
		Horizental,
		Vertiacal
	}

	private Style style_0;

	public Style SepStyle
	{
		get
		{
			return style_0;
		}
		set
		{
			style_0 = value;
			if (value == Style.Horizental)
			{
				((Control)this).set_Height(4);
			}
			else
			{
				((Control)this).set_Width(4);
			}
			((Control)this).Invalidate();
		}
	}

	public EtherealSeperator()
	{
		((Control)this).SetStyle((ControlStyles)141330, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).UpdateStyles();
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).set_ForeColor(HelperMethods.smethod_11(" "));
	}

	protected override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		((Control)this).OnPaint(paintEventArgs_0);
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.set_SmoothingMode((SmoothingMode)4);
			ColorBlend val3 = new ColorBlend();
			val3.set_Positions(new float[4] { 0f, 0.15f, 0.85f, 1f });
			val3.set_Colors(new Color[4]
			{
				Color.Transparent,
				((Control)this).get_ForeColor(),
				((Control)this).get_ForeColor(),
				Color.Transparent
			});
			switch (SepStyle)
			{
			case Style.Vertiacal:
			{
				LinearGradientBrush val5 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.Empty, Color.Empty, 90f);
				try
				{
					val5.set_InterpolationColors(val3);
					val2.DrawLine(new Pen((Brush)(object)val5), Convert.ToInt32(0.7), 0, Convert.ToInt32(0.7), ((Control)this).get_Height());
				}
				finally
				{
					((IDisposable)val5)?.Dispose();
				}
				break;
			}
			case Style.Horizental:
			{
				LinearGradientBrush val4 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.Empty, Color.Empty, 0f);
				try
				{
					val4.set_InterpolationColors(val3);
					val2.DrawLine(new Pen((Brush)(object)val4), 0, Convert.ToInt32(0.7), ((Control)this).get_Width(), Convert.ToInt32(0.7));
				}
				finally
				{
					((IDisposable)val4)?.Dispose();
				}
				break;
			}
			}
			paintEventArgs_0.get_Graphics().DrawImage((Image)((Image)val).Clone(), 0, 0);
			val2.Dispose();
			((Image)val).Dispose();
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}
}
