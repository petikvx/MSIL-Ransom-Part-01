using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ClientG;

public class EtherealProgressBar : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private int _Maximum;

	private int _Value;

	private int _RoundRadius;

	public int Value
	{
		get
		{
			if (_Value < 0)
			{
				return 0;
			}
			return _Value;
		}
		set
		{
			if (value > Maximum)
			{
				value = Maximum;
			}
			_Value = value;
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
			if (value < _Value)
			{
				_Value = value;
			}
			_Maximum = value;
			((Control)this).Invalidate();
		}
	}

	public int RoundRadius
	{
		get
		{
			return _RoundRadius;
		}
		set
		{
			_RoundRadius = value;
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

	public EtherealProgressBar()
	{
		__ENCAddToList(this);
		_Maximum = 100;
		_Value = 0;
		_RoundRadius = 8;
		((Control)this).set_DoubleBuffered(true);
		((Control)this).SetStyle((ControlStyles)141330, true);
		((Control)this).set_BackColor(Color.Transparent);
		Size size = new Size(75, 23);
		((Control)this).set_Size(size);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		checked
		{
			try
			{
				Graphics val2 = Graphics.FromImage((Image)(object)val);
				try
				{
					val2.set_SmoothingMode((SmoothingMode)2);
					int num = (int)Math.Round((double)_Value / (double)_Maximum * (double)((Control)this).get_Width());
					Rectangle rect = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
					HelperMethods.FillRoundedPath(val2, HelperMethods.GetHTMLColor("f7f7f7"), rect, RoundRadius);
					HelperMethods.DrawRoundedPath(val2, HelperMethods.GetHTMLColor("ececec"), 1f, rect, RoundRadius);
					if (num != 0)
					{
						Color hTMLColor = HelperMethods.GetHTMLColor("4e3a62");
						Rectangle rect2 = new Rectangle(rect.X, rect.Y, num, rect.Height);
						HelperMethods.FillRoundedPath(val2, hTMLColor, rect2, RoundRadius);
					}
					e.get_Graphics().DrawImage((Image)(object)val, 0, 0);
					val2.Dispose();
					((Image)val).Dispose();
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
	}
}
