using System;
using System.ComponentModel;
using System.Drawing;
using System.Security;
using System.Threading;
using System.Windows.Forms;
using MetroFramework.Drawing;
using MetroFramework.Interfaces;
using MetroFramework.Native;

namespace MetroFramework.Controls;

[Designer("MetroFramework.Design.MetroScrollBarDesigner, MetroFramework.Design, Version=1.2.0.3, Culture=neutral, PublicKeyToken=5f91a84759bf584a")]
[DefaultProperty("Value")]
[DefaultEvent("Scroll")]
public class MetroScrollBar : MetroControlBase, IDisposable, IMetroControl, IMetroComponent
{
	internal const int SCROLLBAR_DEFAULT_SIZE = 10;

	private bool isFirstScrollEventVertical = true;

	private bool isFirstScrollEventHorizontal = true;

	private bool inUpdate;

	private Rectangle clickedBarRectangle;

	private Rectangle thumbRectangle;

	private bool topBarClicked;

	private bool bottomBarClicked;

	private bool thumbClicked;

	private int thumbWidth = 6;

	private int thumbHeight;

	private int thumbBottomLimitBottom;

	private int thumbBottomLimitTop;

	private int thumbTopLimit;

	private int thumbPosition;

	private int trackPosition;

	private readonly Timer progressTimer = new Timer();

	private int mouseWheelBarPartitions = 10;

	private bool isHovered;

	private bool isPressed;

	private bool useBarColor;

	private bool highlightOnWheel;

	private MetroScrollOrientation metroOrientation = MetroScrollOrientation.Vertical;

	private ScrollOrientation scrollOrientation = (ScrollOrientation)1;

	private int minimum;

	private int maximum = 100;

	private int smallChange = 1;

	private int largeChange = 10;

	private bool dontUpdateColor;

	private int curValue;

	private Timer autoHoverTimer;

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
				throw new ArgumentOutOfRangeException("value", "MouseWheelBarPartitions has to be greather than zero");
			}
			mouseWheelBarPartitions = value;
		}
	}

	[DefaultValue(false)]
	[Category("Metro Appearance")]
	public bool UseBarColor
	{
		get
		{
			return useBarColor;
		}
		set
		{
			useBarColor = value;
		}
	}

	[DefaultValue(10)]
	[Category("Metro Appearance")]
	public int ScrollbarSize
	{
		get
		{
			if (Orientation != MetroScrollOrientation.Vertical)
			{
				return ((Control)this).get_Height();
			}
			return ((Control)this).get_Width();
		}
		set
		{
			if (Orientation == MetroScrollOrientation.Vertical)
			{
				((Control)this).set_Width(value);
			}
			else
			{
				((Control)this).set_Height(value);
			}
		}
	}

	[DefaultValue(false)]
	[Category("Metro Appearance")]
	public bool HighlightOnWheel
	{
		get
		{
			return highlightOnWheel;
		}
		set
		{
			highlightOnWheel = value;
		}
	}

	public MetroScrollOrientation Orientation
	{
		get
		{
			return metroOrientation;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			if (value != metroOrientation)
			{
				metroOrientation = value;
				if (value == MetroScrollOrientation.Vertical)
				{
					scrollOrientation = (ScrollOrientation)1;
				}
				else
				{
					scrollOrientation = (ScrollOrientation)0;
				}
				((Control)this).set_Size(new Size(((Control)this).get_Height(), ((Control)this).get_Width()));
				SetupScrollBar();
			}
		}
	}

	[DefaultValue(0)]
	public int Minimum
	{
		get
		{
			return minimum;
		}
		set
		{
			if (minimum != value && value >= 0 && value < maximum)
			{
				minimum = value;
				if (curValue < value)
				{
					curValue = value;
				}
				if (largeChange > maximum - minimum)
				{
					largeChange = maximum - minimum;
				}
				SetupScrollBar();
				if (curValue < value)
				{
					dontUpdateColor = true;
					Value = value;
				}
				else
				{
					ChangeThumbPosition(GetThumbPosition());
					((Control)this).Refresh();
				}
			}
		}
	}

	[DefaultValue(100)]
	public int Maximum
	{
		get
		{
			return maximum;
		}
		set
		{
			if (value != maximum && value >= 1 && value > minimum)
			{
				maximum = value;
				if (largeChange > maximum - minimum)
				{
					largeChange = maximum - minimum;
				}
				SetupScrollBar();
				if (curValue > value)
				{
					dontUpdateColor = true;
					Value = maximum;
				}
				else
				{
					ChangeThumbPosition(GetThumbPosition());
					((Control)this).Refresh();
				}
			}
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
			if (value != smallChange && value >= 1 && value < largeChange)
			{
				smallChange = value;
				SetupScrollBar();
			}
		}
	}

	[DefaultValue(10)]
	public int LargeChange
	{
		get
		{
			return largeChange;
		}
		set
		{
			if (value != largeChange && value >= smallChange && value >= 2)
			{
				if (value > maximum - minimum)
				{
					largeChange = maximum - minimum;
				}
				else
				{
					largeChange = value;
				}
				SetupScrollBar();
			}
		}
	}

	[Browsable(false)]
	[DefaultValue(0)]
	public int Value
	{
		get
		{
			return curValue;
		}
		set
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Expected O, but got Unknown
			if (curValue == value || value < minimum || value > maximum)
			{
				return;
			}
			curValue = value;
			ChangeThumbPosition(GetThumbPosition());
			OnScroll((ScrollEventType)4, -1, value, scrollOrientation);
			if (!dontUpdateColor && highlightOnWheel)
			{
				if (!isHovered)
				{
					isHovered = true;
				}
				if (autoHoverTimer == null)
				{
					autoHoverTimer = new Timer();
					autoHoverTimer.set_Interval(1000);
					autoHoverTimer.add_Tick((EventHandler)autoHoverTimer_Tick);
					autoHoverTimer.Start();
				}
				else
				{
					autoHoverTimer.Stop();
					autoHoverTimer.Start();
				}
			}
			else
			{
				dontUpdateColor = false;
			}
			((Control)this).Refresh();
		}
	}

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

	private void OnScroll(ScrollEventType type, int oldValue, int newValue, ScrollOrientation orientation)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Invalid comparison between Unknown and I4
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Invalid comparison between Unknown and I4
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Invalid comparison between Unknown and I4
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Expected O, but got Unknown
		if (this.Scroll == null)
		{
			return;
		}
		if ((int)orientation == 0)
		{
			if ((int)type != 8 && isFirstScrollEventHorizontal)
			{
				type = (ScrollEventType)6;
			}
			else if (!isFirstScrollEventHorizontal && (int)type == 8)
			{
				isFirstScrollEventHorizontal = true;
			}
		}
		else if ((int)type != 8 && isFirstScrollEventVertical)
		{
			type = (ScrollEventType)6;
		}
		else if (!isFirstScrollEventHorizontal && (int)type == 8)
		{
			isFirstScrollEventVertical = true;
		}
		this.Scroll.Invoke((object)this, new ScrollEventArgs(type, oldValue, newValue, orientation));
	}

	private void autoHoverTimer_Tick(object sender, EventArgs e)
	{
		isHovered = false;
		((Control)this).Invalidate();
		autoHoverTimer.Stop();
	}

	public MetroScrollBar()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetStyle((ControlStyles)139794, true);
		((Control)this).set_Width(10);
		((Control)this).set_Height(200);
		SetupScrollBar();
		progressTimer.set_Interval(20);
		progressTimer.add_Tick((EventHandler)ProgressTimerTick);
	}

	public MetroScrollBar(MetroScrollOrientation orientation)
		: this()
	{
		Orientation = orientation;
	}

	public MetroScrollBar(MetroScrollOrientation orientation, int width)
		: this(orientation)
	{
		((Control)this).set_Width(width);
	}

	public bool HitTest(Point point)
	{
		return thumbRectangle.Contains(point);
	}

	[SecuritySafeCritical]
	public void BeginUpdate()
	{
		WinApi.SendMessage(((Control)this).get_Handle(), 11, param: false, 0);
		inUpdate = true;
	}

	[SecuritySafeCritical]
	public void EndUpdate()
	{
		WinApi.SendMessage(((Control)this).get_Handle(), 11, param: true, 0);
		inUpdate = false;
		SetupScrollBar();
		((Control)this).Refresh();
	}

	protected override void OnPaintBackground(PaintEventArgs e)
	{
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		Color color = ((((Control)this).get_Parent() == null) ? MetroPaint.BackColor.Form(base.Theme) : ((!(((Control)this).get_Parent() is IMetroControl)) ? ((Control)this).get_Parent().get_BackColor() : MetroPaint.BackColor.Form(base.Theme)));
		Color thumbColor;
		Color barColor;
		if (isHovered && !isPressed && ((Control)this).get_Enabled())
		{
			thumbColor = MetroPaint.BackColor.ScrollBar.Thumb.Hover(base.Theme);
			barColor = MetroPaint.BackColor.ScrollBar.Bar.Hover(base.Theme);
		}
		else if (isHovered && isPressed && ((Control)this).get_Enabled())
		{
			thumbColor = MetroPaint.BackColor.ScrollBar.Thumb.Press(base.Theme);
			barColor = MetroPaint.BackColor.ScrollBar.Bar.Press(base.Theme);
		}
		else if (!((Control)this).get_Enabled())
		{
			thumbColor = MetroPaint.BackColor.ScrollBar.Thumb.Disabled(base.Theme);
			barColor = MetroPaint.BackColor.ScrollBar.Bar.Disabled(base.Theme);
		}
		else
		{
			thumbColor = MetroPaint.BackColor.ScrollBar.Thumb.Normal(base.Theme);
			barColor = MetroPaint.BackColor.ScrollBar.Bar.Normal(base.Theme);
		}
		e.get_Graphics().Clear(color);
		DrawScrollBar(e.get_Graphics(), color, thumbColor, barColor);
	}

	private void DrawScrollBar(Graphics g, Color backColor, Color thumbColor, Color barColor)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		if (useBarColor)
		{
			SolidBrush val = new SolidBrush(barColor);
			try
			{
				g.FillRectangle((Brush)(object)val, ((Control)this).get_ClientRectangle());
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		SolidBrush val2 = new SolidBrush(backColor);
		try
		{
			Rectangle rectangle = new Rectangle(thumbRectangle.X - 1, thumbRectangle.Y - 1, thumbRectangle.Width + 2, thumbRectangle.Height + 2);
			g.FillRectangle((Brush)(object)val2, rectangle);
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
		SolidBrush val3 = new SolidBrush(thumbColor);
		try
		{
			g.FillRectangle((Brush)(object)val3, thumbRectangle);
		}
		finally
		{
			((IDisposable)val3)?.Dispose();
		}
	}

	protected override void OnGotFocus(EventArgs e)
	{
		((Control)this).Invalidate();
		((Control)this).OnGotFocus(e);
	}

	protected override void OnLostFocus(EventArgs e)
	{
		isHovered = false;
		isPressed = false;
		((Control)this).Invalidate();
		((Control)this).OnLostFocus(e);
	}

	protected override void OnEnter(EventArgs e)
	{
		((Control)this).Invalidate();
		((Control)this).OnEnter(e);
	}

	protected override void OnLeave(EventArgs e)
	{
		isHovered = false;
		isPressed = false;
		((Control)this).Invalidate();
		((Control)this).OnLeave(e);
	}

	protected override void OnMouseWheel(MouseEventArgs e)
	{
		((Control)this).OnMouseWheel(e);
		int num = e.get_Delta() / 120 * (maximum - minimum) / mouseWheelBarPartitions;
		if (Orientation == MetroScrollOrientation.Vertical)
		{
			Value -= num;
		}
		else
		{
			Value += num;
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			isPressed = true;
			((Control)this).Invalidate();
		}
		((Control)this).OnMouseDown(e);
		((Control)this).Focus();
		if ((int)e.get_Button() == 1048576)
		{
			Point location = e.get_Location();
			if (thumbRectangle.Contains(location))
			{
				thumbClicked = true;
				thumbPosition = ((metroOrientation == MetroScrollOrientation.Vertical) ? (location.Y - thumbRectangle.Y) : (location.X - thumbRectangle.X));
				((Control)this).Invalidate(thumbRectangle);
				return;
			}
			trackPosition = ((metroOrientation == MetroScrollOrientation.Vertical) ? location.Y : location.X);
			if (trackPosition < ((metroOrientation == MetroScrollOrientation.Vertical) ? thumbRectangle.Y : thumbRectangle.X))
			{
				topBarClicked = true;
			}
			else
			{
				bottomBarClicked = true;
			}
			ProgressThumb(enableTimer: true);
		}
		else if ((int)e.get_Button() == 2097152)
		{
			trackPosition = ((metroOrientation == MetroScrollOrientation.Vertical) ? e.get_Y() : e.get_X());
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		isPressed = false;
		((Control)this).OnMouseUp(e);
		if ((int)e.get_Button() == 1048576)
		{
			if (thumbClicked)
			{
				thumbClicked = false;
				OnScroll((ScrollEventType)8, -1, curValue, scrollOrientation);
			}
			else if (topBarClicked)
			{
				topBarClicked = false;
				StopTimer();
			}
			else if (bottomBarClicked)
			{
				bottomBarClicked = false;
				StopTimer();
			}
			((Control)this).Invalidate();
		}
	}

	protected override void OnMouseEnter(EventArgs e)
	{
		isHovered = true;
		((Control)this).Invalidate();
		((Control)this).OnMouseEnter(e);
	}

	protected override void OnMouseLeave(EventArgs e)
	{
		isHovered = false;
		((Control)this).Invalidate();
		((Control)this).OnMouseLeave(e);
		ResetScrollStatus();
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).OnMouseMove(e);
		if ((int)e.get_Button() == 1048576)
		{
			if (!thumbClicked)
			{
				return;
			}
			int num = curValue;
			int num2 = ((metroOrientation == MetroScrollOrientation.Vertical) ? e.get_Location().Y : e.get_Location().X);
			int num3 = ((metroOrientation == MetroScrollOrientation.Vertical) ? (num2 / ((Control)this).get_Height() / thumbHeight) : (num2 / ((Control)this).get_Width() / thumbWidth));
			if (num2 <= thumbTopLimit + thumbPosition)
			{
				ChangeThumbPosition(thumbTopLimit);
				curValue = minimum;
				((Control)this).Invalidate();
			}
			else if (num2 >= thumbBottomLimitTop + thumbPosition)
			{
				ChangeThumbPosition(thumbBottomLimitTop);
				curValue = maximum;
				((Control)this).Invalidate();
			}
			else
			{
				ChangeThumbPosition(num2 - thumbPosition);
				int num4;
				int num5;
				if (Orientation == MetroScrollOrientation.Vertical)
				{
					num4 = ((Control)this).get_Height() - num3;
					num5 = thumbRectangle.Y;
				}
				else
				{
					num4 = ((Control)this).get_Width() - num3;
					num5 = thumbRectangle.X;
				}
				float num6 = 0f;
				if (num4 != 0)
				{
					num6 = (float)num5 / (float)num4;
				}
				curValue = Convert.ToInt32(num6 * (float)(maximum - minimum) + (float)minimum);
			}
			if (num != curValue)
			{
				OnScroll((ScrollEventType)5, num, curValue, scrollOrientation);
				((Control)this).Refresh();
			}
		}
		else if (!((Control)this).get_ClientRectangle().Contains(e.get_Location()))
		{
			ResetScrollStatus();
		}
		else if ((int)e.get_Button() == 0)
		{
			if (thumbRectangle.Contains(e.get_Location()))
			{
				((Control)this).Invalidate(thumbRectangle);
			}
			else if (((Control)this).get_ClientRectangle().Contains(e.get_Location()))
			{
				((Control)this).Invalidate();
			}
		}
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
		isHovered = false;
		isPressed = false;
		((Control)this).Invalidate();
		((Control)this).OnKeyUp(e);
	}

	protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).SetBoundsCore(x, y, width, height, specified);
		if (((Component)(object)this).DesignMode)
		{
			SetupScrollBar();
		}
	}

	protected override void OnSizeChanged(EventArgs e)
	{
		((Control)this).OnSizeChanged(e);
		SetupScrollBar();
	}

	protected override bool ProcessDialogKey(Keys keyData)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Invalid comparison between Unknown and I4
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between Unknown and I4
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Invalid comparison between Unknown and I4
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Invalid comparison between Unknown and I4
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		Keys val = (Keys)38;
		Keys val2 = (Keys)40;
		if (Orientation == MetroScrollOrientation.Horizontal)
		{
			val = (Keys)37;
			val2 = (Keys)39;
		}
		if (keyData == val)
		{
			Value -= smallChange;
			return true;
		}
		if (keyData == val2)
		{
			Value += smallChange;
			return true;
		}
		if ((int)keyData == 33)
		{
			Value = GetValue(smallIncrement: false, up: true);
			return true;
		}
		if ((int)keyData == 34)
		{
			if (curValue + largeChange > maximum)
			{
				Value = maximum;
			}
			else
			{
				Value += largeChange;
			}
			return true;
		}
		if ((int)keyData == 36)
		{
			Value = minimum;
			return true;
		}
		if ((int)keyData == 35)
		{
			Value = maximum;
			return true;
		}
		return ((Control)this).ProcessDialogKey(keyData);
	}

	protected override void OnEnabledChanged(EventArgs e)
	{
		((Control)this).OnEnabledChanged(e);
		((Control)this).Invalidate();
	}

	private void SetupScrollBar()
	{
		if (!inUpdate)
		{
			if (Orientation == MetroScrollOrientation.Vertical)
			{
				thumbWidth = ((((Control)this).get_Width() > 0) ? ((Control)this).get_Width() : 10);
				thumbHeight = GetThumbSize();
				clickedBarRectangle = ((Control)this).get_ClientRectangle();
				clickedBarRectangle.Inflate(-1, -1);
				thumbRectangle = new Rectangle(((Control)this).get_ClientRectangle().X, ((Control)this).get_ClientRectangle().Y, thumbWidth, thumbHeight);
				thumbPosition = thumbRectangle.Height / 2;
				thumbBottomLimitBottom = ((Control)this).get_ClientRectangle().Bottom;
				thumbBottomLimitTop = thumbBottomLimitBottom - thumbRectangle.Height;
				thumbTopLimit = ((Control)this).get_ClientRectangle().Y;
			}
			else
			{
				thumbHeight = ((((Control)this).get_Height() > 0) ? ((Control)this).get_Height() : 10);
				thumbWidth = GetThumbSize();
				clickedBarRectangle = ((Control)this).get_ClientRectangle();
				clickedBarRectangle.Inflate(-1, -1);
				thumbRectangle = new Rectangle(((Control)this).get_ClientRectangle().X, ((Control)this).get_ClientRectangle().Y, thumbWidth, thumbHeight);
				thumbPosition = thumbRectangle.Width / 2;
				thumbBottomLimitBottom = ((Control)this).get_ClientRectangle().Right;
				thumbBottomLimitTop = thumbBottomLimitBottom - thumbRectangle.Width;
				thumbTopLimit = ((Control)this).get_ClientRectangle().X;
			}
			ChangeThumbPosition(GetThumbPosition());
			((Control)this).Refresh();
		}
	}

	private void ResetScrollStatus()
	{
		topBarClicked = false;
		bottomBarClicked = false;
		StopTimer();
		((Control)this).Refresh();
	}

	private void ProgressTimerTick(object sender, EventArgs e)
	{
		ProgressThumb(enableTimer: true);
	}

	private int GetValue(bool smallIncrement, bool up)
	{
		int num;
		if (up)
		{
			num = curValue - (smallIncrement ? smallChange : largeChange);
			if (num < minimum)
			{
				num = minimum;
			}
		}
		else
		{
			num = curValue + (smallIncrement ? smallChange : largeChange);
			if (num > maximum)
			{
				num = maximum;
			}
		}
		return num;
	}

	private int GetThumbPosition()
	{
		if (thumbHeight != 0 && thumbWidth != 0)
		{
			int num = ((metroOrientation == MetroScrollOrientation.Vertical) ? (thumbPosition / ((Control)this).get_Height() / thumbHeight) : (thumbPosition / ((Control)this).get_Width() / thumbWidth));
			int num2 = ((Orientation != MetroScrollOrientation.Vertical) ? (((Control)this).get_Width() - num) : (((Control)this).get_Height() - num));
			int num3 = maximum - minimum;
			float num4 = 0f;
			if (num3 != 0)
			{
				num4 = ((float)curValue - (float)minimum) / (float)num3;
			}
			return Math.Max(thumbTopLimit, Math.Min(thumbBottomLimitTop, Convert.ToInt32(num4 * (float)num2)));
		}
		return 0;
	}

	private int GetThumbSize()
	{
		int num = ((metroOrientation == MetroScrollOrientation.Vertical) ? ((Control)this).get_Height() : ((Control)this).get_Width());
		if (maximum != 0 && largeChange != 0)
		{
			float val = (float)largeChange * (float)num / (float)maximum;
			return Convert.ToInt32(Math.Min(num, Math.Max(val, 10f)));
		}
		return num;
	}

	private void EnableTimer()
	{
		if (!progressTimer.get_Enabled())
		{
			progressTimer.set_Interval(600);
			progressTimer.Start();
		}
		else
		{
			progressTimer.set_Interval(10);
		}
	}

	private void StopTimer()
	{
		progressTimer.Stop();
	}

	private void ChangeThumbPosition(int position)
	{
		if (Orientation == MetroScrollOrientation.Vertical)
		{
			thumbRectangle.Y = position;
		}
		else
		{
			thumbRectangle.X = position;
		}
	}

	private void ProgressThumb(bool enableTimer)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		int num = curValue;
		ScrollEventType type = (ScrollEventType)6;
		int num2;
		int num3;
		if (Orientation == MetroScrollOrientation.Vertical)
		{
			num2 = thumbRectangle.Y;
			num3 = thumbRectangle.Height;
		}
		else
		{
			num2 = thumbRectangle.X;
			num3 = thumbRectangle.Width;
		}
		if (bottomBarClicked && num2 + num3 < trackPosition)
		{
			type = (ScrollEventType)3;
			curValue = GetValue(smallIncrement: false, up: false);
			if (curValue == maximum)
			{
				ChangeThumbPosition(thumbBottomLimitTop);
				type = (ScrollEventType)7;
			}
			else
			{
				ChangeThumbPosition(Math.Min(thumbBottomLimitTop, GetThumbPosition()));
			}
		}
		else if (topBarClicked && num2 > trackPosition)
		{
			type = (ScrollEventType)2;
			curValue = GetValue(smallIncrement: false, up: true);
			if (curValue == minimum)
			{
				ChangeThumbPosition(thumbTopLimit);
				type = (ScrollEventType)6;
			}
			else
			{
				ChangeThumbPosition(Math.Max(thumbTopLimit, GetThumbPosition()));
			}
		}
		if (num != curValue)
		{
			OnScroll(type, num, curValue, scrollOrientation);
			((Control)this).Invalidate();
			if (enableTimer)
			{
				EnableTimer();
			}
		}
	}
}
