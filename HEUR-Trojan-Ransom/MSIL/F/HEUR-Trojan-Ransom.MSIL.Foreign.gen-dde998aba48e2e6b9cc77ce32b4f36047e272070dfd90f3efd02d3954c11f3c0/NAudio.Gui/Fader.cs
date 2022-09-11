using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NAudio.Gui;

public sealed class Fader : Control
{
	private int minimum;

	private int maximum;

	private float percent;

	private Orientation orientation;

	private Container components;

	private readonly int SliderHeight = 30;

	private readonly int SliderWidth = 15;

	private Rectangle sliderRectangle;

	private bool dragging;

	private int dragY;

	public int Minimum
	{
		get
		{
			return minimum;
		}
		set
		{
			minimum = value;
		}
	}

	public int Maximum
	{
		get
		{
			return maximum;
		}
		set
		{
			maximum = value;
		}
	}

	public int Value
	{
		get
		{
			return (int)(percent * (float)(maximum - minimum)) + minimum;
		}
		set
		{
			percent = (float)(value - minimum) / (float)(maximum - minimum);
		}
	}

	public Orientation Orientation
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return orientation;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			orientation = value;
		}
	}

	public Fader()
	{
		InitializeComponent();
		((Control)this).SetStyle((ControlStyles)73730, true);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Control)this).Dispose(disposing);
	}

	private void DrawSlider(Graphics g)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		Brush val = (Brush)new SolidBrush(Color.White);
		Pen val2 = new Pen(Color.Black);
		sliderRectangle.X = (((Control)this).get_Width() - SliderWidth) / 2;
		sliderRectangle.Width = SliderWidth;
		sliderRectangle.Y = (int)((float)(((Control)this).get_Height() - SliderHeight) * percent);
		sliderRectangle.Height = SliderHeight;
		g.FillRectangle(val, sliderRectangle);
		g.DrawLine(val2, sliderRectangle.Left, sliderRectangle.Top + sliderRectangle.Height / 2, sliderRectangle.Right, sliderRectangle.Top + sliderRectangle.Height / 2);
		val.Dispose();
		val2.Dispose();
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		Graphics graphics = e.get_Graphics();
		if ((int)Orientation == 1)
		{
			Brush val = (Brush)new SolidBrush(Color.Black);
			graphics.FillRectangle(val, ((Control)this).get_Width() / 2, SliderHeight / 2, 2, ((Control)this).get_Height() - SliderHeight);
			val.Dispose();
			DrawSlider(graphics);
		}
		((Control)this).OnPaint(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		if (sliderRectangle.Contains(e.get_X(), e.get_Y()))
		{
			dragging = true;
			dragY = e.get_Y() - sliderRectangle.Y;
		}
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		if (dragging)
		{
			int num = e.get_Y() - dragY;
			if (num < 0)
			{
				percent = 0f;
			}
			else if (num > ((Control)this).get_Height() - SliderHeight)
			{
				percent = 1f;
			}
			else
			{
				percent = (float)num / (float)(((Control)this).get_Height() - SliderHeight);
			}
			((Control)this).Invalidate();
		}
		((Control)this).OnMouseMove(e);
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		dragging = false;
		((Control)this).OnMouseUp(e);
	}

	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
	}
}
