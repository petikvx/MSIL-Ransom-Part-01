using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Drawing;

namespace MetroFramework.Controls;

[Designer("MetroFramework.Design.MetroProgressBarDesigner, MetroFramework.Design, Version=1.2.0.3, Culture=neutral, PublicKeyToken=5f91a84759bf584a")]
[ToolboxBitmap(typeof(ProgressBar))]
public class MetroProgressBar : MetroProgressBarBase
{
	private MetroProgressBarSize metroLabelSize = MetroProgressBarSize.Medium;

	private MetroProgressBarWeight metroLabelWeight;

	private ContentAlignment textAlign = (ContentAlignment)64;

	private bool hideProgressText = true;

	private ProgressBarStyle progressBarStyle = (ProgressBarStyle)1;

	private int marqueeX;

	private Timer marqueeTimer;

	private bool marqueeTimerEnabled;

	[Category("Metro Appearance")]
	[DefaultValue(MetroProgressBarSize.Medium)]
	public MetroProgressBarSize FontSize
	{
		get
		{
			return metroLabelSize;
		}
		set
		{
			metroLabelSize = value;
		}
	}

	[DefaultValue(MetroProgressBarWeight.Light)]
	[Category("Metro Appearance")]
	public MetroProgressBarWeight FontWeight
	{
		get
		{
			return metroLabelWeight;
		}
		set
		{
			metroLabelWeight = value;
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Category("Metro Appearance")]
	public ContentAlignment TextAlign
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return textAlign;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			textAlign = value;
		}
	}

	[DefaultValue(true)]
	[Category("Metro Appearance")]
	public bool HideProgressText
	{
		get
		{
			return hideProgressText;
		}
		set
		{
			hideProgressText = value;
		}
	}

	[DefaultValue(/*Could not decode attribute arguments.*/)]
	[Category("Metro Appearance")]
	public ProgressBarStyle ProgressBarStyle
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return progressBarStyle;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			progressBarStyle = value;
		}
	}

	public int Value
	{
		get
		{
			return ((ProgressBar)this).get_Value();
		}
		set
		{
			if (value <= ((ProgressBar)this).get_Maximum())
			{
				((ProgressBar)this).set_Value(value);
				((Control)this).Invalidate();
			}
		}
	}

	[Browsable(false)]
	public double ProgressTotalPercent => (1.0 - (double)(((ProgressBar)this).get_Maximum() - Value) / (double)((ProgressBar)this).get_Maximum()) * 100.0;

	[Browsable(false)]
	public double ProgressTotalValue => 1.0 - (double)(((ProgressBar)this).get_Maximum() - Value) / (double)((ProgressBar)this).get_Maximum();

	[Browsable(false)]
	public string ProgressPercentText => $"{Math.Round(ProgressTotalPercent)}%";

	private double ProgressBarWidth => (double)Value / (double)((ProgressBar)this).get_Maximum() * (double)((Control)this).get_ClientRectangle().Width;

	private int ProgressBarMarqueeWidth => ((Control)this).get_ClientRectangle().Width / 3;

	public MetroProgressBar()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetStyle((ControlStyles)139282, true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Invalid comparison between Unknown and I4
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		Color color = (((Control)this).get_Enabled() ? MetroPaint.BackColor.ProgressBar.Bar.Normal(base.Theme) : MetroPaint.BackColor.ProgressBar.Bar.Disabled(base.Theme));
		e.get_Graphics().Clear(color);
		if ((int)progressBarStyle == 1)
		{
			if (!((Component)(object)this).DesignMode)
			{
				StopTimer();
			}
			DrawProgressContinuous(e.get_Graphics());
		}
		else if ((int)progressBarStyle == 0)
		{
			if (!((Component)(object)this).DesignMode)
			{
				StopTimer();
			}
			DrawProgressContinuous(e.get_Graphics());
		}
		else if ((int)progressBarStyle == 2)
		{
			if (!((Component)(object)this).DesignMode && ((Control)this).get_Enabled())
			{
				StartTimer();
			}
			if (!((Control)this).get_Enabled())
			{
				StopTimer();
			}
			if (Value == ((ProgressBar)this).get_Maximum())
			{
				StopTimer();
				DrawProgressContinuous(e.get_Graphics());
			}
			else
			{
				DrawProgressMarquee(e.get_Graphics());
			}
		}
		DrawProgressText(e.get_Graphics());
		Pen val = new Pen(MetroPaint.BorderColor.ProgressBar.Normal(base.Theme));
		try
		{
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			e.get_Graphics().DrawRectangle(val, rectangle);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void DrawProgressContinuous(Graphics graphics)
	{
		graphics.FillRectangle((Brush)(object)MetroPaint.GetStyleBrush(base.Style), 0, 0, (int)ProgressBarWidth, ((Control)this).get_ClientRectangle().Height);
	}

	private void DrawProgressMarquee(Graphics graphics)
	{
		graphics.FillRectangle((Brush)(object)MetroPaint.GetStyleBrush(base.Style), marqueeX, 0, ProgressBarMarqueeWidth, ((Control)this).get_ClientRectangle().Height);
	}

	private void DrawProgressText(Graphics graphics)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		if (!HideProgressText)
		{
			Color transparent = Color.Transparent;
			Color color = ((!((Control)this).get_Enabled()) ? MetroPaint.ForeColor.ProgressBar.Disabled(base.Theme) : MetroPaint.ForeColor.ProgressBar.Normal(base.Theme));
			TextRenderer.DrawText((IDeviceContext)(object)graphics, ProgressPercentText, MetroFonts.ProgressBar(metroLabelSize, metroLabelWeight), ((Control)this).get_ClientRectangle(), color, transparent, MetroPaint.GetTextFormatFlags(TextAlign));
		}
	}

	public override Size GetPreferredSize(Size proposedSize)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).GetPreferredSize(proposedSize);
		Graphics val = ((Control)this).CreateGraphics();
		try
		{
			proposedSize = new Size(int.MaxValue, int.MaxValue);
			return TextRenderer.MeasureText((IDeviceContext)(object)val, ProgressPercentText, MetroFonts.ProgressBar(metroLabelSize, metroLabelWeight), proposedSize, MetroPaint.GetTextFormatFlags(TextAlign));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	private void StartTimer()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		if (!marqueeTimerEnabled)
		{
			if (marqueeTimer == null)
			{
				marqueeTimer = new Timer();
				marqueeTimer.set_Interval(10);
				marqueeTimer.add_Tick((EventHandler)marqueeTimer_Tick);
			}
			marqueeX = -ProgressBarMarqueeWidth;
			marqueeTimer.Stop();
			marqueeTimer.Start();
			marqueeTimerEnabled = true;
			((Control)this).Invalidate();
		}
	}

	private void StopTimer()
	{
		if (marqueeTimer != null)
		{
			marqueeTimer.Stop();
			((Control)this).Invalidate();
		}
	}

	private void marqueeTimer_Tick(object sender, EventArgs e)
	{
		marqueeX++;
		if (marqueeX > ((Control)this).get_ClientRectangle().Width)
		{
			marqueeX = -ProgressBarMarqueeWidth;
		}
		((Control)this).Invalidate();
	}
}
