using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Drawing;

namespace MetroFramework.Controls;

[ToolboxBitmap(typeof(TrackBar))]
[DefaultEvent("Scroll")]
public class MetroTrackBar : MetroControlBase
{
	private int trackerValue = 50;

	private int barMinimum;

	private int barMaximum = 100;

	private int smallChange = 1;

	private int largeChange = 5;

	private int mouseWheelBarPartitions = 10;

	private bool useCustomBackground;

	private bool isHovered;

	private bool isPressed;

	private bool isFocused;

	[DefaultValue(50)]
	public int Value
	{
		get
		{
			return trackerValue;
		}
		set
		{
			if (!((value >= barMinimum) & (value <= barMaximum)))
			{
				throw new ArgumentOutOfRangeException("Value is outside appropriate range (min, max)");
			}
			trackerValue = value;
			OnValueChanged();
			((Control)this).Invalidate();
		}
	}

	[DefaultValue(0)]
	public int Minimum
	{
		get
		{
			return barMinimum;
		}
		set
		{
			if (value < barMaximum)
			{
				barMinimum = value;
				if (trackerValue < barMinimum)
				{
					trackerValue = barMinimum;
					if (this.ValueChanged != null)
					{
						this.ValueChanged(this, new EventArgs());
					}
				}
				((Control)this).Invalidate();
				return;
			}
			throw new ArgumentOutOfRangeException("Minimal value is greather than maximal one");
		}
	}

	[DefaultValue(100)]
	public int Maximum
	{
		get
		{
			return barMaximum;
		}
		set
		{
			if (value > barMinimum)
			{
				barMaximum = value;
				if (trackerValue > barMaximum)
				{
					trackerValue = barMaximum;
					if (this.ValueChanged != null)
					{
						this.ValueChanged(this, new EventArgs());
					}
				}
				((Control)this).Invalidate();
				return;
			}
			throw new ArgumentOutOfRangeException("Maximal value is lower than minimal one");
		}
	}

	[DefaultValue(1)]
	public int SmallChange
	{
		get
		{
			return smallChange;
		}
		set
		{
			smallChange = value;
		}
	}

	[DefaultValue(5)]
	public int LargeChange
	{
		get
		{
			return largeChange;
		}
		set
		{
			largeChange = value;
		}
	}

	[DefaultValue(10)]
	public int MouseWheelBarPartitions
	{
		get
		{
			return mouseWheelBarPartitions;
		}
		set
		{
			if (value <= 0)
			{
				throw new ArgumentOutOfRangeException("MouseWheelBarPartitions has to be greather than zero");
			}
			mouseWheelBarPartitions = value;
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

	public event EventHandler ValueChanged;

	public event ScrollEventHandler Scroll
	{
		add
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			ScrollEventHandler val = this.Scroll;
			ScrollEventHandler val2;
			do
			{
				val2 = val;
				ScrollEventHandler value2 = (ScrollEventHandler)Delegate.Combine((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.Scroll, value2, val2);
			}
			while (val != val2);
		}
		remove
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			ScrollEventHandler val = this.Scroll;
			ScrollEventHandler val2;
			do
			{
				val2 = val;
				ScrollEventHandler value2 = (ScrollEventHandler)Delegate.Remove((Delegate?)(object)val2, (Delegate?)(object)value);
				val = Interlocked.CompareExchange(ref this.Scroll, value2, val2);
			}
			while (val != val2);
		}
	}

	private void OnValueChanged()
	{
		if (this.ValueChanged != null)
		{
			this.ValueChanged(this, EventArgs.Empty);
		}
	}

	private void OnScroll(ScrollEventType scrollType, int newValue)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		if (this.Scroll != null)
		{
			this.Scroll.Invoke((object)this, new ScrollEventArgs(scrollType, newValue));
		}
	}

	public MetroTrackBar(int min, int max, int value)
	{
		((Control)this).SetStyle((ControlStyles)142866, true);
		((Control)this).set_BackColor(Color.Transparent);
		Minimum = min;
		Maximum = max;
		Value = value;
	}

	public MetroTrackBar()
		: this(0, 100, 50)
	{
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		Color color = ((!useCustomBackground) ? MetroPaint.BackColor.Form(base.Theme) : ((Control)this).get_BackColor());
		Color thumbColor;
		Color barColor;
		if (isHovered && !isPressed && ((Control)this).get_Enabled())
		{
			thumbColor = MetroPaint.BackColor.TrackBar.Thumb.Hover(base.Theme);
			barColor = MetroPaint.BackColor.TrackBar.Bar.Hover(base.Theme);
		}
		else if (isHovered && isPressed && ((Control)this).get_Enabled())
		{
			thumbColor = MetroPaint.BackColor.TrackBar.Thumb.Press(base.Theme);
			barColor = MetroPaint.BackColor.TrackBar.Bar.Press(base.Theme);
		}
		else if (!((Control)this).get_Enabled())
		{
			thumbColor = MetroPaint.BackColor.TrackBar.Thumb.Disabled(base.Theme);
			barColor = MetroPaint.BackColor.TrackBar.Bar.Disabled(base.Theme);
		}
		else
		{
			thumbColor = MetroPaint.BackColor.TrackBar.Thumb.Normal(base.Theme);
			barColor = MetroPaint.BackColor.TrackBar.Bar.Normal(base.Theme);
		}
		e.get_Graphics().Clear(color);
		DrawTrackBar(e.get_Graphics(), thumbColor, barColor);
	}

	private void DrawTrackBar(Graphics g, Color thumbColor, Color barColor)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		int num = (trackerValue - barMinimum) * (((Control)this).get_Width() - 6) / (barMaximum - barMinimum);
		SolidBrush val = new SolidBrush(thumbColor);
		try
		{
			Rectangle rectangle = new Rectangle(0, ((Control)this).get_Height() / 2 - 2, num, 4);
			g.FillRectangle((Brush)(object)val, rectangle);
			Rectangle rectangle2 = new Rectangle(num, ((Control)this).get_Height() / 2 - 8, 6, 16);
			g.FillRectangle((Brush)(object)val, rectangle2);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		SolidBrush val2 = new SolidBrush(barColor);
		try
		{
			Rectangle rectangle3 = new Rectangle(num + 7, ((Control)this).get_Height() / 2 - 2, ((Control)this).get_Width() - num + 7, 4);
			g.FillRectangle((Brush)(object)val2, rectangle3);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	protected override void OnGotFocus(EventArgs e)
	{
		isFocused = true;
		((Control)this).Invalidate();
		((Control)this).OnGotFocus(e);
	}

	protected override void OnLostFocus(EventArgs e)
	{
		isFocused = false;
		isHovered = false;
		isPressed = false;
		((Control)this).Invalidate();
		((Control)this).OnLostFocus(e);
	}

	protected override void OnEnter(EventArgs e)
	{
		isFocused = true;
		((Control)this).Invalidate();
		((Control)this).OnEnter(e);
	}

	protected override void OnLeave(EventArgs e)
	{
		isFocused = false;
		isHovered = false;
		isPressed = false;
		((Control)this).Invalidate();
		((Control)this).OnLeave(e);
	}

	protected override void OnKeyDown(KeyEventArgs e)
	{
		isHovered = true;
		isPressed = true;
		((Control)this).Invalidate();
		((Control)this).OnKeyDown(e);
	}

	protected override void OnKeyUp(KeyEventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected I4, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		isHovered = false;
		isPressed = false;
		((Control)this).Invalidate();
		((Control)this).OnKeyUp(e);
		Keys keyCode = e.get_KeyCode();
		switch (keyCode - 33)
		{
		case 0:
			SetProperValue(Value + largeChange);
			OnScroll((ScrollEventType)3, Value);
			break;
		case 1:
			SetProperValue(Value - largeChange);
			OnScroll((ScrollEventType)2, Value);
			break;
		case 2:
			Value = barMaximum;
			break;
		case 3:
			Value = barMinimum;
			break;
		case 5:
		case 6:
			SetProperValue(Value + smallChange);
			OnScroll((ScrollEventType)1, Value);
			break;
		case 4:
		case 7:
			SetProperValue(Value - smallChange);
			OnScroll((ScrollEventType)0, Value);
			break;
		}
		if (Value == barMinimum)
		{
			OnScroll((ScrollEventType)6, Value);
		}
		if (Value == barMaximum)
		{
			OnScroll((ScrollEventType)7, Value);
		}
		Point point = ((Control)this).PointToClient(Cursor.get_Position());
		((Control)this).OnMouseMove(new MouseEventArgs((MouseButtons)0, 0, point.X, point.Y, 0));
	}

	protected override bool ProcessDialogKey(Keys keyData)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		if (((int)keyData == 9) | ((int)Control.get_ModifierKeys() == 65536))
		{
			return ((Control)this).ProcessDialogKey(keyData);
		}
		((Control)this).OnKeyDown(new KeyEventArgs(keyData));
		return true;
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		isHovered = true;
		((Control)this).Invalidate();
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			isPressed = true;
			((Control)this).Invalidate();
		}
		((Control)this).OnMouseDown(e);
		if ((int)e.get_Button() == 1048576)
		{
			((Control)this).set_Capture(true);
			OnScroll((ScrollEventType)5, trackerValue);
			OnValueChanged();
			((Control)this).OnMouseMove(e);
		}
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).OnMouseMove(e);
		if (((Control)this).get_Capture() & ((int)e.get_Button() == 1048576))
		{
			ScrollEventType scrollType = (ScrollEventType)4;
			int x = e.get_Location().X;
			float num = (float)(barMaximum - barMinimum) / (float)(((Control)this).get_ClientSize().Width - 3);
			trackerValue = (int)((float)x * num + (float)barMinimum);
			if (trackerValue <= barMinimum)
			{
				trackerValue = barMinimum;
				scrollType = (ScrollEventType)6;
			}
			else if (trackerValue >= barMaximum)
			{
				trackerValue = barMaximum;
				scrollType = (ScrollEventType)7;
			}
			OnScroll(scrollType, trackerValue);
			OnValueChanged();
			((Control)this).Invalidate();
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		isPressed = false;
		((Control)this).Invalidate();
		((Control)this).OnMouseUp(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		isHovered = false;
		((Control)this).Invalidate();
		((Control)this).OnMouseLeave(e);
	}

	protected override void OnMouseWheel(MouseEventArgs e)
	{
		((Control)this).OnMouseWheel(e);
		int num = e.get_Delta() / 120 * (barMaximum - barMinimum) / mouseWheelBarPartitions;
		SetProperValue(Value + num);
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		((Control)this).OnEnabledChanged(e);
		((Control)this).Invalidate();
	}

	private void SetProperValue(int val)
	{
		if (val < barMinimum)
		{
			Value = barMinimum;
		}
		else if (val > barMaximum)
		{
			Value = barMaximum;
		}
		else
		{
			Value = val;
		}
	}
}
