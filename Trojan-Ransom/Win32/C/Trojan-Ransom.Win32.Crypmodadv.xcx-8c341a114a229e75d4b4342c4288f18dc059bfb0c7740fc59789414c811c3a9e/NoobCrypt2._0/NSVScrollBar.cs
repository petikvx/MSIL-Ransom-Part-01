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
internal class NSVScrollBar : Control
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

	private Rectangle TSA;

	private Rectangle BSA;

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
			if (value < 1)
			{
				value = 1;
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

	public double _Percent
	{
		[DebuggerNonUserCode]
		get;
		[DebuggerNonUserCode]
		set;
	}

	public double Percent
	{
		get
		{
			if (!ShowThumb)
			{
				return 0.0;
			}
			return GetProgress();
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

	public NSVScrollBar()
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
		((Control)this).set_Width(18);
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
		GP1 = DrawArrow(4, 6, flip: false);
		GP2 = DrawArrow(5, 7, flip: false);
		ThemeModule.G.FillPath((Brush)(object)B1, GP2);
		ThemeModule.G.FillPath((Brush)(object)B2, GP1);
		checked
		{
			GP3 = DrawArrow(4, ((Control)this).get_Height() - 11, flip: true);
			GP4 = DrawArrow(5, ((Control)this).get_Height() - 10, flip: true);
			ThemeModule.G.FillPath((Brush)(object)B1, GP4);
			ThemeModule.G.FillPath((Brush)(object)B2, GP3);
			if (ShowThumb)
			{
				ThemeModule.G.FillRectangle((Brush)(object)B1, Thumb);
				ThemeModule.G.DrawRectangle(P1, Thumb);
				ThemeModule.G.DrawRectangle(P2, Thumb.X + 1, Thumb.Y + 1, Thumb.Width - 2, Thumb.Height - 2);
				int num = Thumb.Y + unchecked(Thumb.Height / 2) - 3;
				int num2 = 0;
				do
				{
					int num3 = num + num2 * 3;
					ThemeModule.G.DrawLine(P1, Thumb.X + 5, num3, Thumb.Right - 5, num3);
					ThemeModule.G.DrawLine(P2, Thumb.X + 5, num3 + 1, Thumb.Right - 5, num3 + 1);
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
		int num = 9;
		int num2 = 5;
		checked
		{
			if (flip)
			{
				val.AddLine(x + 1, y, x + num + 1, y);
				val.AddLine(x + num, y, x + num2, y + num2 - 1);
			}
			else
			{
				val.AddLine(x, y + num2, x + num, y + num2);
				val.AddLine(x + num, y + num2, x + num2, y);
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
		ref Rectangle tSA = ref TSA;
		tSA = new Rectangle(0, 0, ((Control)this).get_Width(), ButtonSize);
		ref Rectangle bSA = ref BSA;
		checked
		{
			bSA = new Rectangle(0, ((Control)this).get_Height() - ButtonSize, ((Control)this).get_Width(), ButtonSize);
			ref Rectangle shaft = ref Shaft;
			shaft = new Rectangle(0, TSA.Bottom + 1, ((Control)this).get_Width(), ((Control)this).get_Height() - ButtonSize * 2 - 1);
			ShowThumb = _Maximum - _Minimum > Shaft.Height;
			if (ShowThumb)
			{
				ref Rectangle thumb = ref Thumb;
				thumb = new Rectangle(1, 0, ((Control)this).get_Width() - 3, ThumbSize);
			}
			ScrollEvent?.Invoke(this);
			InvalidatePosition();
		}
	}

	private void InvalidatePosition()
	{
		Thumb.Y = checked((int)Math.Round(GetProgress() * (double)(Shaft.Height - ThumbSize)) + TSA.Height);
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
				if (TSA.Contains(e.get_Location()))
				{
					I1 = _Value - _SmallChange;
				}
				else if (BSA.Contains(e.get_Location()))
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
					if (e.get_Y() < Thumb.Y)
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
				int num = e.get_Y() - TSA.Height - unchecked(ThumbSize / 2);
				int num2 = Shaft.Height - ThumbSize;
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
