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
internal class NSTrackBar : Control
{
	public delegate void ScrollEventHandler(object sender);

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private ScrollEventHandler ScrollEvent;

	private int _Minimum;

	private int _Maximum;

	private int _Value;

	private GraphicsPath GP1;

	private GraphicsPath GP2;

	private GraphicsPath GP3;

	private GraphicsPath GP4;

	private Rectangle R1;

	private Rectangle R2;

	private Rectangle R3;

	private int I1;

	private Pen P1;

	private Pen P2;

	private Pen P3;

	private Pen P4;

	private LinearGradientBrush GB1;

	private LinearGradientBrush GB2;

	private LinearGradientBrush GB3;

	private bool TrackDown;

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
			((Control)this).Invalidate();
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
			((Control)this).Invalidate();
		}
	}

	public int Value
	{
		get
		{
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
				((Control)this).Invalidate();
				ScrollEvent?.Invoke(this);
			}
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

	public NSTrackBar()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		__ENCAddToList(this);
		_Maximum = 10;
		((Control)this).SetStyle((ControlStyles)139286, true);
		((Control)this).SetStyle((ControlStyles)512, false);
		((Control)this).set_Height(17);
		P1 = new Pen(Color.FromArgb(150, 110, 0), 2f);
		P2 = new Pen(Color.FromArgb(55, 55, 55));
		P3 = new Pen(Color.FromArgb(35, 35, 35));
		P4 = new Pen(Color.FromArgb(65, 65, 65));
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		ThemeModule.G = e.get_Graphics();
		ThemeModule.G.Clear(((Control)this).get_BackColor());
		ThemeModule.G.set_SmoothingMode((SmoothingMode)4);
		checked
		{
			GP1 = ThemeModule.CreateRound(0, 5, ((Control)this).get_Width() - 1, 10, 5);
			GP2 = ThemeModule.CreateRound(1, 6, ((Control)this).get_Width() - 3, 8, 5);
			ref Rectangle r = ref R1;
			r = new Rectangle(0, 7, ((Control)this).get_Width() - 1, 5);
			GB1 = new LinearGradientBrush(R1, Color.FromArgb(45, 45, 45), Color.FromArgb(50, 50, 50), 90f);
			I1 = (int)Math.Round((double)(_Value - _Minimum) / (double)(_Maximum - _Minimum) * (double)(((Control)this).get_Width() - 11));
			ref Rectangle r2 = ref R2;
			r2 = new Rectangle(I1, 0, 10, 20);
			ThemeModule.G.SetClip(GP2);
			ThemeModule.G.FillRectangle((Brush)(object)GB1, R1);
			ref Rectangle r3 = ref R3;
			r3 = new Rectangle(1, 7, R2.X + R2.Width - 2, 8);
			GB2 = new LinearGradientBrush(R3, Color.FromArgb(205, 150, 0), Color.FromArgb(150, 110, 0), 90f);
			ThemeModule.G.set_SmoothingMode((SmoothingMode)3);
			ThemeModule.G.FillRectangle((Brush)(object)GB2, R3);
			ThemeModule.G.set_SmoothingMode((SmoothingMode)4);
			int num = R3.Width - 15;
			int num2 = 0;
			while (true)
			{
				int num3 = num2;
				int num4 = num;
				if (num3 > num4)
				{
					break;
				}
				ThemeModule.G.DrawLine(P1, num2, 0, num2 + 15, ((Control)this).get_Height());
				num2 += 5;
			}
			ThemeModule.G.ResetClip();
			ThemeModule.G.DrawPath(P2, GP1);
			ThemeModule.G.DrawPath(P3, GP2);
			GP3 = ThemeModule.CreateRound(R2, 5);
			GP4 = ThemeModule.CreateRound(R2.X + 1, R2.Y + 1, R2.Width - 2, R2.Height - 2, 5);
			GB3 = new LinearGradientBrush(((Control)this).get_ClientRectangle(), Color.FromArgb(60, 60, 60), Color.FromArgb(55, 55, 55), 90f);
			ThemeModule.G.FillPath((Brush)(object)GB3, GP3);
			ThemeModule.G.DrawPath(P3, GP3);
			ThemeModule.G.DrawPath(P4, GP4);
		}
	}

	protected override void OnMouseDown(MouseEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Invalid comparison between Unknown and I4
		if ((int)e.get_Button() == 1048576)
		{
			I1 = checked((int)Math.Round((double)(_Value - _Minimum) / (double)(_Maximum - _Minimum) * (double)(((Control)this).get_Width() - 11)));
			ref Rectangle r = ref R2;
			r = new Rectangle(I1, 0, 10, 20);
			TrackDown = R2.Contains(e.get_Location());
		}
		((Control)this).OnMouseDown(e);
	}

	protected override void OnMouseMove(MouseEventArgs e)
	{
		checked
		{
			if ((TrackDown && e.get_X() > -1 && e.get_X() < ((Control)this).get_Width() + 1) ? true : false)
			{
				Value = _Minimum + (int)Math.Round((double)(_Maximum - _Minimum) * ((double)e.get_X() / (double)((Control)this).get_Width()));
			}
			((Control)this).OnMouseMove(e);
		}
	}

	protected override void OnMouseUp(MouseEventArgs e)
	{
		TrackDown = false;
		((Control)this).OnMouseUp(e);
	}
}
