using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NoobCrypt2._0;

[DefaultEvent("Scroll")]
internal class NSHScrollBar : Control
{
	public delegate void ScrollEventHandler(object sender);

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private ScrollEventHandler ScrollEvent;

	private int _Minimum;

	private int _Maximum;

	private int _Value;

	private int _SmallChange;

	private int _LargeChange;

	private int ButtonSize;

	private int ThumbSize;

	private Rectangle LSA;

	private Rectangle RSA;

	private Rectangle Shaft;

	private Rectangle Thumb;

	private bool ShowThumb;

	private bool ThumbDown;

	private GraphicsPath GP1;

	private GraphicsPath GP2;

	private GraphicsPath GP3;

	private GraphicsPath GP4;

	private Pen P1;

	private Pen P2;

	private Pen P3;

	private Pen P4;

	private SolidBrush B1;

	private SolidBrush B2;

	private int I1;

	public int Minimum
	{
		get
		{
			return _Minimum;
		}
		set
		{
			if (value < 0)
			{
				throw new Exception("Property value is not valid.");
			}
			_Minimum = value;
			if (value > _Value)
			{
				_Value = value;
			}
			if (value > _Maximum)
			{
				_Maximum = value;
			}
			InvalidateLayout();
		}
	}

	public int Maximum
	{
		get
		{
			return _Maximum;
		}
		set
		{
			if (value < 0)
			{
				throw new Exception("Property value is not valid.");
			}
			_Maximum = value;
			if (value < _Value)
			{
				_Value = value;
			}
			if (value < _Minimum)
			{
				_Minimum = value;
			}
			InvalidateLayout();
		}
	}

	public int Value
	{
		get
		{
			if (!ShowThumb)
			{
				return _Minimum;
			}
			return _Value;
		}
		set
		{
			if (value != _Value)
			{
				if ((value > _Maximum || value < _Minimum) ? true : false)
				{
					throw new Exception("Property value is not valid.");
				}
				_Value = value;
				InvalidatePosition();
				ScrollEvent?.Invoke(this);
			}
		}
	}

	public int SmallChange
	{
		get
		{
			return _SmallChange;
		}
		set
		{
			if (value < 1)
			{
				throw new Exception("Property value is not valid.");
			}
			_SmallChange = value;
		}
	}

	public int LargeChange
	{
		get
		{
			return _LargeChange;
		}
		set
		{
			if (value < 1)
			{
				throw new Exception("Property value is not valid.");
			}
			_LargeChange = value;
		}
	}

	public event ScrollEventHandler Scroll
	{
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		add
		{
			ScrollEvent = (ScrollEventHandler)Delegate.Combine(ScrollEvent, value);
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		remove
		{
			ScrollEvent = (ScrollEventHandler)Delegate.Remove(ScrollEvent, value);
		}
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	public NSHScrollBar()
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		__ENCAddToList(this);
		_Maximum = 100;
		_SmallChange = 1;
		_LargeChange = 10;
		ButtonSize = 16;
		ThumbSize = 24;
		((Control)this).SetStyle((ControlStyles)139286, true);
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).set_Height(18);
		B1 = new SolidBrush(Color.FromArgb(55, 55, 55));
		B2 = new SolidBrush(Color.FromArgb(35, 35, 35));
		P1 = new Pen(Color.FromArgb(35, 35, 35));
		P2 = new Pen(Color.FromArgb(65, 65, 65));
		P3 = new Pen(Color.FromArgb(55, 55, 55));
		P4 = new Pen(Color.FromArgb(40, 40, 40));
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		ThemeModule.G = e.get_Graphics();
		ThemeModule.G.Clear(((Control)this).get_BackColor());
		GP1 = DrawArrow(6, 4, flip: false);
		GP2 = DrawArrow(7, 5, flip: false);
		ThemeModule.G.FillPath((Brush)(object)B1, GP2);
		ThemeModule.G.FillPath((Brush)(object)B2, GP1);
		checked
		{
			GP3 = DrawArrow(((Control)this).get_Width() - 11, 4, flip: true);
			GP4 = DrawArrow(((Control)this).get_Width() - 10, 5, flip: true);
			ThemeModule.G.FillPath((Brush)(object)B1, GP4);
			ThemeModule.G.FillPath((Brush)(object)B2, GP3);
			if (ShowThumb)
			{
				ThemeModule.G.FillRectangle((Brush)(object)B1, Thumb);
				ThemeModule.G.DrawRectangle(P1, Thumb);
				ThemeModule.G.DrawRectangle(P2, Thumb.X + 1, Thumb.Y + 1, Thumb.Width - 2, Thumb.Height - 2);
				int num = Thumb.X + unchecked(Thumb.Width / 2) - 3;
				int num2 = 0;
				do
				{
					int num3 = num + num2 * 3;
					ThemeModule.G.DrawLine(P1, num3, Thumb.Y + 5, num3, Thumb.Bottom - 5);
					ThemeModule.G.DrawLine(P2, num3 + 1, Thumb.Y + 5, num3 + 1, Thumb.Bottom - 5);
					num2++;
				}
				while (num2 <= 2);
			}
			ThemeModule.G.DrawRectangle(P3, 0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			ThemeModule.G.DrawRectangle(P4, 1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
		}
	}

	private GraphicsPath DrawArrow(int x, int y, bool flip)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		int num = 5;
		int num2 = 9;
		checked
		{
			if (flip)
			{
				val.AddLine(x, y + 1, x, y + num2 + 1);
				val.AddLine(x, y + num2, x + num - 1, y + num);
			}
			else
			{
				val.AddLine(x + num, y, x + num, y + num2);
				val.AddLine(x + num, y + num2, x + 1, y + num);
			}
			val.CloseFigure();
			return val;
		}
	}

	protected override void OnSizeChanged(EventArgs e)
	{
		InvalidateLayout();
	}

	private void InvalidateLayout()
	{
		ref Rectangle lSA = ref LSA;
		lSA = new Rectangle(0, 0, ButtonSize, ((Control)this).get_Height());
		ref Rectangle rSA = ref RSA;
		checked
		{
			rSA = new Rectangle(((Control)this).get_Width() - ButtonSize, 0, ButtonSize, ((Control)this).get_Height());
			ref Rectangle shaft = ref Shaft;
			shaft = new Rectangle(LSA.Right + 1, 0, ((Control)this).get_Width() - ButtonSize * 2 - 1, ((Control)this).get_Height());
			ShowThumb = _Maximum - _Minimum > Shaft.Width;
			if (ShowThumb)
			{
				ref Rectangle thumb = ref Thumb;
				thumb = new Rectangle(0, 1, ThumbSize, ((Control)this).get_Height() - 3);
			}
			ScrollEvent?.Invoke(this);
			InvalidatePosition();
		}
	}

	private void InvalidatePosition()
	{
		Thumb.X = checked((int)Math.Round(GetProgress() * (double)(Shaft.Width - ThumbSize)) + LSA.Width);
		((Control)this).Invalidate();
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if (((int)e.get_Button() == 1048576 && ShowThumb) ? true : false)
		{
			checked
			{
				if (LSA.Contains(e.get_Location()))
				{
					I1 = _Value - _SmallChange;
				}
				else if (RSA.Contains(e.get_Location()))
				{
					I1 = _Value + _SmallChange;
				}
				else
				{
					if (Thumb.Contains(e.get_Location()))
					{
						ThumbDown = true;
						((Control)this).OnMouseDown(e);
						return;
					}
					if (e.get_X() < Thumb.X)
					{
						I1 = _Value - _LargeChange;
					}
					else
					{
						I1 = _Value + _LargeChange;
					}
				}
				Value = Math.Min(Math.Max(I1, _Minimum), _Maximum);
				InvalidatePosition();
			}
		}
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		checked
		{
			if ((ThumbDown && ShowThumb) ? true : false)
			{
				int num = e.get_X() - LSA.Width - unchecked(ThumbSize / 2);
				int num2 = Shaft.Width - ThumbSize;
				I1 = (int)Math.Round((double)num / (double)num2 * (double)(_Maximum - _Minimum)) + _Minimum;
				Value = Math.Min(Math.Max(I1, _Minimum), _Maximum);
				InvalidatePosition();
			}
			((Control)this).OnMouseMove(e);
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		ThumbDown = false;
		((Control)this).OnMouseUp(e);
	}

	private double GetProgress()
	{
		return checked((double)(_Value - _Minimum) / (double)(_Maximum - _Minimum));
	}
}
