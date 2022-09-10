using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace NoobCrypt2._0;

internal class NSProgressBar : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private int _Minimum;

	private int _Maximum;

	private int _Value;

	private GraphicsPath GP1;

	private GraphicsPath GP2;

	private GraphicsPath GP3;

	private Rectangle R1;

	private Rectangle R2;

	private Pen P1;

	private Pen P2;

	private SolidBrush B1;

	private LinearGradientBrush GB1;

	private LinearGradientBrush GB2;

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
			if ((value > _Maximum || value < _Minimum) ? true : false)
			{
				throw new Exception("Property value is not valid.");
			}
			_Value = value;
			((Control)this).Invalidate();
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

	private void Increment(int amount)
	{
		checked
		{
			Value += amount;
		}
	}

	public NSProgressBar()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		__ENCAddToList(this);
		_Maximum = 100;
		((Control)this).SetStyle((ControlStyles)139286, true);
		((Control)this).SetStyle((ControlStyles)512, false);
		P1 = new Pen(Color.FromArgb(35, 35, 35));
		P2 = new Pen(Color.FromArgb(55, 55, 55));
		B1 = new SolidBrush(Color.FromArgb(200, 160, 0));
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		ThemeModule.G = e.get_Graphics();
		ThemeModule.G.Clear(((Control)this).get_BackColor());
		ThemeModule.G.set_SmoothingMode((SmoothingMode)4);
		checked
		{
			GP1 = ThemeModule.CreateRound(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1, 7);
			GP2 = ThemeModule.CreateRound(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3, 7);
			ref Rectangle r = ref R1;
			r = new Rectangle(0, 2, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			GB1 = new LinearGradientBrush(R1, Color.FromArgb(45, 45, 45), Color.FromArgb(50, 50, 50), 90f);
			ThemeModule.G.SetClip(GP1);
			ThemeModule.G.FillRectangle((Brush)(object)GB1, R1);
			I1 = (int)Math.Round((double)(_Value - _Minimum) / (double)(_Maximum - _Minimum) * (double)(((Control)this).get_Width() - 3));
			if (I1 > 1)
			{
				GP3 = ThemeModule.CreateRound(1, 1, I1, ((Control)this).get_Height() - 3, 7);
				ref Rectangle r2 = ref R2;
				r2 = new Rectangle(1, 1, I1, ((Control)this).get_Height() - 3);
				GB2 = new LinearGradientBrush(R2, Color.FromArgb(205, 150, 0), Color.FromArgb(150, 110, 0), 90f);
				ThemeModule.G.FillPath((Brush)(object)GB2, GP3);
				ThemeModule.G.DrawPath(P1, GP3);
				ThemeModule.G.SetClip(GP3);
				ThemeModule.G.set_SmoothingMode((SmoothingMode)3);
				ThemeModule.G.FillRectangle((Brush)(object)B1, R2.X, R2.Y + 1, R2.Width, unchecked(R2.Height / 2));
				ThemeModule.G.set_SmoothingMode((SmoothingMode)4);
				ThemeModule.G.ResetClip();
			}
			ThemeModule.G.DrawPath(P2, GP1);
			ThemeModule.G.DrawPath(P1, GP2);
		}
	}
}
