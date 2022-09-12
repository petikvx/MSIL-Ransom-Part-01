using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Drawing;

namespace MetroFramework.Controls;

public class MetroUserControl : MetroUserControlBase
{
	private bool useCustomBackground;

	private MetroBorderStyle _borderStyle;

	[DefaultValue(false)]
	[Category("Metro Appearance")]
	public bool CustomBackground
	{
		get
		{
			return useCustomBackground;
		}
		set
		{
			useCustomBackground = value;
		}
	}

	[Browsable(true)]
	[Category("Metro Appearance")]
	[DefaultValue(MetroBorderStyle.None)]
	public MetroBorderStyle BorderStyle
	{
		get
		{
			return _borderStyle;
		}
		set
		{
			_borderStyle = value;
		}
	}

	public MetroUserControl()
	{
		((Control)this).SetStyle((ControlStyles)133122, true);
		((UserControl)this).set_BorderStyle((BorderStyle)0);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		Color color = MetroPaint.BackColor.Form(base.Theme);
		if (useCustomBackground)
		{
			color = ((Control)this).get_BackColor();
		}
		e.get_Graphics().Clear(color);
		if (BorderStyle != 0)
		{
			Color color2 = MetroPaint.BorderColor.Form(base.Theme);
			Pen val = new Pen(color2);
			try
			{
				e.get_Graphics().DrawLines(val, new Point[5]
				{
					new Point(0, 0),
					new Point(0, ((Control)this).get_Height() - 1),
					new Point(((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1),
					new Point(((Control)this).get_Width() - 1, 0),
					new Point(0, 0)
				});
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		((Control)this).OnEnabledChanged(e);
		((Control)this).Invalidate();
	}
}
