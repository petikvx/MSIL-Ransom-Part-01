using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Gui;

public sealed class Pot : UserControl
{
	private double minimum;

	private double maximum = 1.0;

	private double value = 0.5;

	private int beginDragY;

	private double beginDragValue;

	private bool dragging;

	private IContainer components;

	[NonSerialized]
	internal static GetString _009D;

	public double Minimum
	{
		get
		{
			return minimum;
		}
		set
		{
			if (value >= maximum)
			{
				throw new ArgumentOutOfRangeException(_009D(107395397));
			}
			minimum = value;
			if (Value < minimum)
			{
				Value = minimum;
			}
		}
	}

	public double Maximum
	{
		get
		{
			return maximum;
		}
		set
		{
			if (value <= minimum)
			{
				throw new ArgumentOutOfRangeException(_009D(107395384));
			}
			maximum = value;
			if (Value > maximum)
			{
				Value = maximum;
			}
		}
	}

	public double Value
	{
		get
		{
			return value;
		}
		set
		{
			SetValue(value, raiseEvents: false);
		}
	}

	public event EventHandler ValueChanged;

	public Pot()
	{
		((Control)this).SetStyle((ControlStyles)73730, true);
		InitializeComponent();
	}

	private void SetValue(double newValue, bool raiseEvents)
	{
		if (value != newValue)
		{
			value = newValue;
			if (raiseEvents && this.ValueChanged != null)
			{
				this.ValueChanged(this, EventArgs.Empty);
			}
			((Control)this).Invalidate();
		}
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		int num = Math.Min(((Control)this).get_Width() - 4, ((Control)this).get_Height() - 4);
		Pen val = new Pen(((Control)this).get_ForeColor(), 3f);
		val.set_LineJoin((LineJoin)2);
		GraphicsState val2 = e.get_Graphics().Save();
		e.get_Graphics().TranslateTransform((float)(((Control)this).get_Width() / 2), (float)(((Control)this).get_Height() / 2));
		e.get_Graphics().set_SmoothingMode((SmoothingMode)4);
		e.get_Graphics().DrawArc(val, new Rectangle(num / -2, num / -2, num, num), 135f, 270f);
		double num2 = (value - minimum) / (maximum - minimum);
		double num3 = 135.0 + num2 * 270.0;
		double num4 = (double)num / 2.0 * Math.Cos(Math.PI * num3 / 180.0);
		double num5 = (double)num / 2.0 * Math.Sin(Math.PI * num3 / 180.0);
		e.get_Graphics().DrawLine(val, 0f, 0f, (float)num4, (float)num5);
		e.get_Graphics().Restore(val2);
		((Control)this).OnPaint(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		dragging = true;
		beginDragY = e.get_Y();
		beginDragValue = value;
		((UserControl)this).OnMouseDown(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		dragging = false;
		((Control)this).OnMouseUp(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (dragging)
		{
			int num = beginDragY - e.get_Y();
			double num2 = (maximum - minimum) * ((double)num / 150.0);
			double num3 = beginDragValue + num2;
			if (num3 < minimum)
			{
				num3 = minimum;
			}
			if (num3 > maximum)
			{
				num3 = maximum;
			}
			SetValue(num3, raiseEvents: true);
		}
		((Control)this).OnMouseMove(e);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_Name(_009D(107394791));
		((Control)this).set_Size(new Size(32, 32));
		((Control)this).ResumeLayout(false);
	}

	static Pot()
	{
		Strings.CreateGetStringDelegate(typeof(Pot));
	}
}
