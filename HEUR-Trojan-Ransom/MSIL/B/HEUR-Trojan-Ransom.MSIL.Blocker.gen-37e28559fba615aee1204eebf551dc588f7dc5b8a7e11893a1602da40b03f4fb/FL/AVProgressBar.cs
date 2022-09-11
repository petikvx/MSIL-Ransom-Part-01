using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace FL;

public class AVProgressBar : Control
{
	private int int_0;

	private int int_1;

	private int int_2;

	private string string_0;

	public int Angle
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
			((Control)this).Invalidate();
		}
	}

	public string Symbol
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
			((Control)this).Invalidate();
		}
	}

	public int Thickness
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
			((Control)this).Invalidate();
		}
	}

	public AVProgressBar()
	{
		Class8.t3hvLuccnmfIO();
		Class8.t3hvLuccnmfIO();
		((Control)this)._002Ector();
		int_0 = 50;
		int_1 = 5;
		int_2 = 0;
		string_0 = "%";
		((Control)this).set_Size(new Size(65, 65));
		((Control)this).Invalidate();
	}

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_0389: Expected O, but got Unknown
		((Control)this).OnPaint(e);
		((Control)this).set_Width(((Control)this).get_Height());
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		checked
		{
			try
			{
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				try
				{
					val2.set_SmoothingMode((SmoothingMode)4);
					val2.Clear(((Control)this).get_BackColor());
					LinearGradientBrush val3 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(217, 217, 217), Color.FromArgb(217, 217, 217), (LinearGradientMode)1);
					try
					{
						Pen val4 = new Pen((Brush)(object)val3, (float)(Thickness + 3));
						try
						{
							val2.DrawArc(val4, (int)Math.Round((double)Thickness / 2.0) + 2, (int)Math.Round((double)Thickness / 2.0) + 2, ((Control)this).get_Width() - Thickness - 4, ((Control)this).get_Height() - Thickness - 4, -90, 360);
						}
						finally
						{
							((IDisposable)val4)?.Dispose();
						}
					}
					finally
					{
						((IDisposable)val3)?.Dispose();
					}
					LinearGradientBrush val5 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(0, 166, 208), Color.FromArgb(0, 166, 208), (LinearGradientMode)1);
					try
					{
						Pen val6 = new Pen((Brush)(object)val5, (float)(Thickness + 3));
						try
						{
							val2.DrawArc(val6, (int)Math.Round((double)Thickness / 2.0) + 9, (int)Math.Round((double)Thickness / 2.0) + 9, ((Control)this).get_Width() - Thickness - 18, ((Control)this).get_Height() - Thickness - 18, -90, 360);
						}
						finally
						{
							((IDisposable)val6)?.Dispose();
						}
					}
					finally
					{
						((IDisposable)val5)?.Dispose();
					}
					LinearGradientBrush val7 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(255, 255, 255), Color.FromArgb(255, 255, 255), (LinearGradientMode)1);
					try
					{
						Pen val8 = new Pen((Brush)(object)val7, (float)(Thickness - 2));
						try
						{
							int num = (int)Math.Round(3.6 * (double)int_0);
							val2.DrawArc(val8, (int)Math.Round((double)Thickness / 2.0) + 9, (int)Math.Round((double)Thickness / 2.0) + 9, ((Control)this).get_Width() - Thickness - 18, ((Control)this).get_Height() - Thickness - 18, -90, num);
						}
						finally
						{
							((IDisposable)val8)?.Dispose();
						}
					}
					finally
					{
						((IDisposable)val7)?.Dispose();
					}
					val2.DrawString(Conversions.ToString(int_0) + string_0, new Font("Arial", 13f), Brushes.get_Black(), (PointF)new Point((int)Math.Round((double)((Control)this).get_Width() / 2.0 - (double)(val2.MeasureString(Conversions.ToString(int_0) + string_0, new Font("Arial", 13f)).Width / 2f) + 1.0), (int)Math.Round((double)((Control)this).get_Height() / 2.0 - (double)(val2.MeasureString(Conversions.ToString(int_0) + "%", new Font("Arial", 13f)).Height / 2f) + 1.0)));
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
				e.get_Graphics().DrawImage((Image)(object)val, 0, 0);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
	}
}
