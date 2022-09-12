using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MetroFramework.Drawing;

namespace MetroFramework.Controls;

[Designer("MetroFramework.Design.MetroProgressSpinnerDesigner, MetroFramework.Design, Version=1.2.0.3, Culture=neutral, PublicKeyToken=5f91a84759bf584a")]
[ToolboxBitmap(typeof(ProgressBar))]
public class MetroProgressSpinner : MetroControlBase
{
	private Timer timer;

	private int progress;

	private float angle = 270f;

	private int minimum;

	private int maximum = 100;

	private bool ensureVisible = true;

	private float speed;

	private bool backwards;

	private bool useCustomBackground;

	[Category("Metro Behavior")]
	[DefaultValue(true)]
	public bool Spinning
	{
		get
		{
			return timer.get_Enabled();
		}
		set
		{
			timer.set_Enabled(value);
		}
	}

	[Category("Metro Appearance")]
	[DefaultValue(0)]
	public int Value
	{
		get
		{
			return progress;
		}
		set
		{
			if (value != -1 && (value < minimum || value > maximum))
			{
				throw new ArgumentOutOfRangeException("Progress value must be -1 or between Minimum and Maximum.", (Exception?)null);
			}
			progress = value;
			((Control)this).Refresh();
		}
	}

	[DefaultValue(0)]
	[Category("Metro Appearance")]
	public int Minimum
	{
		get
		{
			return minimum;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentOutOfRangeException("Minimum value must be >= 0.", (Exception?)null);
			}
			if (value >= maximum)
			{
				throw new ArgumentOutOfRangeException("Minimum value must be < Maximum.", (Exception?)null);
			}
			minimum = value;
			if (progress != -1 && progress < minimum)
			{
				progress = minimum;
			}
			((Control)this).Refresh();
		}
	}

	[Category("Metro Appearance")]
	[DefaultValue(0)]
	public int Maximum
	{
		get
		{
			return maximum;
		}
		set
		{
			if (value <= minimum)
			{
				throw new ArgumentOutOfRangeException("Maximum value must be > Minimum.", (Exception?)null);
			}
			maximum = value;
			if (progress > maximum)
			{
				progress = maximum;
			}
			((Control)this).Refresh();
		}
	}

	[Category("Metro Appearance")]
	[DefaultValue(true)]
	public bool EnsureVisible
	{
		get
		{
			return ensureVisible;
		}
		set
		{
			ensureVisible = value;
			((Control)this).Refresh();
		}
	}

	[Category("Metro Behavior")]
	[DefaultValue(1f)]
	public float Speed
	{
		get
		{
			return speed;
		}
		set
		{
			if (value <= 0f || value > 10f)
			{
				throw new ArgumentOutOfRangeException("Speed value must be > 0 and <= 10.", (Exception?)null);
			}
			speed = value;
		}
	}

	[DefaultValue(false)]
	[Category("Metro Behavior")]
	public bool Backwards
	{
		get
		{
			return backwards;
		}
		set
		{
			backwards = value;
			((Control)this).Refresh();
		}
	}

	[Category("Metro Appearance")]
	[DefaultValue(false)]
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

	public MetroProgressSpinner()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		timer = new Timer();
		timer.set_Interval(20);
		timer.add_Tick((EventHandler)timer_Tick);
		timer.set_Enabled(true);
		((Control)this).set_Width(16);
		((Control)this).set_Height(16);
		speed = 1f;
		((Control)this).set_DoubleBuffered(true);
	}

	public void Reset()
	{
		progress = minimum;
		angle = 270f;
		((Control)this).Refresh();
	}

	private void timer_Tick(object sender, EventArgs e)
	{
		if (!((Component)(object)this).DesignMode)
		{
			angle += 6f * speed * (float)((!backwards) ? 1 : (-1));
			((Control)this).Refresh();
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		Color color;
		Color color2;
		if (useCustomBackground)
		{
			color = ((Control)this).get_BackColor();
			color2 = MetroPaint.GetStyleColor(base.Style);
		}
		else if (((Control)this).get_Parent() is MetroTile)
		{
			color = MetroPaint.GetStyleColor(base.Style);
			color2 = MetroPaint.ForeColor.Tile.Normal(base.Theme);
		}
		else
		{
			color = MetroPaint.BackColor.Form(base.Theme);
			color2 = MetroPaint.GetStyleColor(base.Style);
		}
		e.get_Graphics().Clear(color);
		Pen val = new Pen(color2, (float)((Control)this).get_Width() / 5f);
		try
		{
			int num = (int)Math.Ceiling((float)((Control)this).get_Width() / 10f);
			e.get_Graphics().set_SmoothingMode((SmoothingMode)2);
			if (progress != -1)
			{
				float num2 = (float)(progress - minimum) / (float)(maximum - minimum);
				float num3 = ((!ensureVisible) ? (360f * num2) : (30f + 300f * num2));
				if (backwards)
				{
					num3 = 0f - num3;
				}
				e.get_Graphics().DrawArc(val, (float)num, (float)num, (float)(((Control)this).get_Width() - 2 * num - 1), (float)(((Control)this).get_Height() - 2 * num - 1), angle, num3);
				return;
			}
			for (int i = 0; i <= 180; i += 15)
			{
				int num4 = 290 - i * 290 / 180;
				if (num4 > 255)
				{
					num4 = 255;
				}
				if (num4 < 0)
				{
					num4 = 0;
				}
				Color color3 = Color.FromArgb(num4, val.get_Color());
				Pen val2 = new Pen(color3, val.get_Width());
				try
				{
					float num5 = angle + (float)((i - (ensureVisible ? 30 : 0)) * (backwards ? 1 : (-1)));
					float num6 = 15 * (backwards ? 1 : (-1));
					e.get_Graphics().DrawArc(val2, (float)num, (float)num, (float)(((Control)this).get_Width() - 2 * num - 1), (float)(((Control)this).get_Height() - 2 * num - 1), num5, num6);
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
