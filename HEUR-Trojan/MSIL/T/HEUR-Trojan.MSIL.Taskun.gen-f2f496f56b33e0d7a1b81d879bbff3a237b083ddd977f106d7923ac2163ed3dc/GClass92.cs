using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public sealed class GClass92 : Label
{
	private Color color_0;

	private Color color_1;

	[Browsable(false)]
	public override Color BackColor
	{
		get
		{
			return ((Control)this).get_BackColor();
		}
		set
		{
			((Control)this).set_BackColor(value);
		}
	}

	public Color method_0()
	{
		return color_0;
	}

	public void method_1(Color color_2)
	{
		color_0 = color_2;
	}

	public Color method_2()
	{
		return color_1;
	}

	public void method_3(Color color_2)
	{
		color_1 = color_2;
	}

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		((Control)this).OnPaintBackground(pevent);
		LinearGradientBrush val = new LinearGradientBrush(((Control)this).get_ClientRectangle(), method_0(), method_2(), (LinearGradientMode)0);
		try
		{
			pevent.get_Graphics().FillRectangle((Brush)(object)val, ((Control)this).get_ClientRectangle());
		}
		finally
		{
			((IDisposable)val).Dispose();
		}
	}
}
