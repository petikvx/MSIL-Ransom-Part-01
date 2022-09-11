using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CustomControls.RJControls;

public class RJButton : Button
{
	private int borderSize = 0;

	private int borderRadius = 0;

	private Color borderColor = Color.PaleVioletRed;

	[Category("RJ Code Advance")]
	public int BorderSize
	{
		get
		{
			return borderSize;
		}
		set
		{
			borderSize = value;
			((Control)this).Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public int BorderRadius
	{
		get
		{
			return borderRadius;
		}
		set
		{
			borderRadius = value;
			((Control)this).Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public Color BorderColor
	{
		get
		{
			return borderColor;
		}
		set
		{
			borderColor = value;
			((Control)this).Invalidate();
		}
	}

	[Category("RJ Code Advance")]
	public Color BackgroundColor
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

	[Category("RJ Code Advance")]
	public Color TextColor
	{
		get
		{
			return ((Control)this).get_ForeColor();
		}
		set
		{
			((Control)this).set_ForeColor(value);
		}
	}

	public RJButton()
	{
		((ButtonBase)this).set_FlatStyle((FlatStyle)0);
		((ButtonBase)this).get_FlatAppearance().set_BorderSize(0);
		((Control)this).set_Size(new Size(150, 40));
		((Control)this).set_BackColor(Color.MediumSlateBlue);
		((Control)this).set_ForeColor(Color.White);
		((Control)this).add_Resize((EventHandler)Button_Resize);
	}

	private GraphicsPath GetFigurePath(Rectangle rect, int radius)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		float num = (float)radius * 2f;
		val.StartFigure();
		val.AddArc((float)rect.X, (float)rect.Y, num, num, 180f, 90f);
		val.AddArc((float)rect.Right - num, (float)rect.Y, num, num, 270f, 90f);
		val.AddArc((float)rect.Right - num, (float)rect.Bottom - num, num, num, 0f, 90f);
		val.AddArc((float)rect.X, (float)rect.Bottom - num, num, num, 90f, 90f);
		val.CloseFigure();
		return val;
	}

	protected override void OnPaint(PaintEventArgs pevent)
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_011d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		((ButtonBase)this).OnPaint(pevent);
		Rectangle clientRectangle = ((Control)this).get_ClientRectangle();
		Rectangle rect = Rectangle.Inflate(clientRectangle, -borderSize, -borderSize);
		int num = 2;
		if (borderSize > 0)
		{
			num = borderSize;
		}
		if (borderRadius > 2)
		{
			GraphicsPath figurePath = GetFigurePath(clientRectangle, borderRadius);
			try
			{
				GraphicsPath figurePath2 = GetFigurePath(rect, borderRadius - borderSize);
				try
				{
					Pen val = new Pen(((Control)this).get_Parent().get_BackColor(), (float)num);
					try
					{
						Pen val2 = new Pen(borderColor, (float)borderSize);
						try
						{
							pevent.get_Graphics().set_SmoothingMode((SmoothingMode)4);
							((Control)this).set_Region(new Region(figurePath));
							pevent.get_Graphics().DrawPath(val, figurePath);
							if (borderSize >= 1)
							{
								pevent.get_Graphics().DrawPath(val2, figurePath2);
							}
							return;
						}
						finally
						{
							((IDisposable)val2)?.Dispose();
						}
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)figurePath2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)figurePath)?.Dispose();
			}
		}
		pevent.get_Graphics().set_SmoothingMode((SmoothingMode)3);
		((Control)this).set_Region(new Region(clientRectangle));
		if (borderSize >= 1)
		{
			Pen val3 = new Pen(borderColor, (float)borderSize);
			try
			{
				val3.set_Alignment((PenAlignment)1);
				pevent.get_Graphics().DrawRectangle(val3, 0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		((Control)this).OnHandleCreated(e);
		((Control)this).get_Parent().add_BackColorChanged((EventHandler)Container_BackColorChanged);
	}

	private void Container_BackColorChanged(object sender, EventArgs e)
	{
		((Control)this).Invalidate();
	}

	private void Button_Resize(object sender, EventArgs e)
	{
		if (borderRadius > ((Control)this).get_Height())
		{
			borderRadius = ((Control)this).get_Height();
		}
	}
}
