using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnimatedText;

public class eLearningSlidingLabel : Control
{
	private Timer timer = new Timer();

	private bool slide;

	private int a;

	private bool art = false;

	public int SlideTime
	{
		get
		{
			return timer.get_Interval();
		}
		set
		{
			timer.set_Interval(value);
			((Control)this).Invalidate();
		}
	}

	public bool Slide
	{
		get
		{
			return slide;
		}
		set
		{
			slide = true;
			timer.set_Enabled(slide);
			if (!slide)
			{
				a = 0;
				((Control)this).Invalidate();
			}
		}
	}

	public override string Text
	{
		get
		{
			return ((Control)this).get_Text();
		}
		set
		{
			((Control)this).set_Text(value);
			timer.Start();
		}
	}

	public eLearningSlidingLabel()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		((Control)this).SetStyle((ControlStyles)141330, true);
		((Control)this).set_AutoSize(false);
		((Control)this).set_Width(30);
		((Control)this).set_Height(15);
		a = 0;
		timer.add_Tick((EventHandler)timer_Tick);
		slide = false;
		timer.set_Enabled(false);
	}

	protected override void Dispose(bool disposing)
	{
		timer.Stop();
		((Control)this).Dispose(disposing);
	}

	protected override void OnBackColorChanged(EventArgs e)
	{
		((Control)this).Invalidate();
		((Control)this).OnBackColorChanged(e);
	}

	protected override void OnCreateControl()
	{
		((Control)this).OnCreateControl();
	}

	protected override void OnForeColorChanged(EventArgs e)
	{
		((Control)this).Invalidate();
		((Control)this).OnForeColorChanged(e);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		//IL_000f: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0065: Expected O, but got Unknown
		SolidBrush val = new SolidBrush(((Control)this).get_BackColor());
		Brush val2 = (Brush)val;
		Brush val3 = (Brush)val;
		try
		{
			e.get_Graphics().FillRectangle(val2, ((Control)this).get_ClientRectangle());
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
		Size size = TextRenderer.MeasureText(((Control)this).get_Text(), ((Control)this).get_Font());
		int num = ((Control)this).get_Height() / 2 - size.Height / 2;
		SolidBrush val4 = new SolidBrush(((Control)this).get_ForeColor());
		val2 = (Brush)val4;
		Brush val5 = (Brush)val4;
		try
		{
			e.get_Graphics().DrawString(((Control)this).get_Text(), ((Control)this).get_Font(), val2, (float)a, (float)num);
		}
		finally
		{
			((IDisposable)val5)?.Dispose();
		}
		((Control)this).OnPaint(e);
	}

	protected override void OnResize(EventArgs e)
	{
		timer.set_Enabled(true);
		((Control)this).OnResize(e);
	}

	private void timer_Tick(object sender, EventArgs e)
	{
		Size size = TextRenderer.MeasureText(((Control)this).get_Text(), ((Control)this).get_Font());
		if (size.Width <= ((Control)this).get_Width())
		{
			timer.Stop();
			a = 1;
			((Control)this).Invalidate();
			return;
		}
		int num = ((size.Width >= ((Control)this).get_Width()) ? (size.Width - ((Control)this).get_Width()) : 0);
		if (a >= 1)
		{
			art = false;
		}
		if (-a >= num + ((Control)this).get_Font().get_Height())
		{
			art = true;
		}
		a = (art ? (a + 1) : (a - 1));
		((Control)this).Invalidate();
	}
}
