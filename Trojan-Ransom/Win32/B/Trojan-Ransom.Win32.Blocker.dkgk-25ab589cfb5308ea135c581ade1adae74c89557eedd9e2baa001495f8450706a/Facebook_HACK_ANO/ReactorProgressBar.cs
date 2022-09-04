using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace Facebook_HACK_ANO;

public class ReactorProgressBar : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private int OFS;

	private int Speed;

	private int _Maximum;

	private int _Value;

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

	public int Value
	{
		get
		{
			if (_Value == 0)
			{
				return 1;
			}
			return _Value;
		}
		set
		{
			int num = value;
			if (num > _Maximum)
			{
				value = _Maximum;
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

	protected override void OnPaintBackground(PaintEventArgs pevent)
	{
	}

	protected override void CreateHandle()
	{
		((Control)this).CreateHandle();
		Thread thread = new Thread(Animate);
		thread.IsBackground = true;
		thread.Start();
	}

	public void Animate()
	{
		checked
		{
			while (true)
			{
				if (OFS > ((Control)this).get_Width())
				{
					OFS = 0;
				}
				else
				{
					OFS++;
				}
				((Control)this).Invalidate();
				Thread.Sleep(Speed);
			}
		}
	}

	public ReactorProgressBar()
	{
		__ENCAddToList(this);
		OFS = 0;
		Speed = 50;
		_Maximum = 100;
		_Value = 0;
		((Control)this).set_DoubleBuffered(true);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_0253: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		Graphics graphics = e.get_Graphics();
		((Control)this).OnPaint(e);
		checked
		{
			int num = (int)Math.Round((double)_Value / (double)_Maximum * (double)((Control)this).get_Width());
			graphics.Clear(Color.FromArgb(38, 38, 38));
			Rectangle rectangle = new Rectangle(1, 1, num - 1, ((Control)this).get_Height() - 2);
			LinearGradientBrush val = new LinearGradientBrush(rectangle, Color.FromArgb(10, 9, 8), Color.FromArgb(31, 29, 26), 90f);
			rectangle = new Rectangle(1, 1, num - 1, ((Control)this).get_Height() - 2);
			graphics.FillRectangle((Brush)(object)val, rectangle);
			HatchBrush val2 = new HatchBrush((HatchStyle)23, Color.FromArgb(175, 219, 78, 0), Color.FromArgb(175, 229, 98, 0));
			Point renderingOrigin = new Point(OFS, 0);
			graphics.set_RenderingOrigin(renderingOrigin);
			rectangle = new Rectangle(1, 1, num - 2, ((Control)this).get_Height() - 2);
			graphics.FillRectangle((Brush)(object)val2, rectangle);
			rectangle = new Rectangle(1, 1, num - 2, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 1.0));
			LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(80, Color.White), Color.FromArgb(50, Color.White), 90f);
			rectangle = new Rectangle(1, 1, num - 2, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 1.0));
			graphics.FillRectangle((Brush)(object)val3, rectangle);
			Pen val4 = new Pen((Brush)new SolidBrush(Color.FromArgb(10, 10, 10)));
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			graphics.DrawRectangle(val4, rectangle);
			Pen val5 = new Pen((Brush)new SolidBrush(Color.Black));
			rectangle = new Rectangle(1, 1, ((Control)this).get_Width() - 3, ((Control)this).get_Height() - 3);
			graphics.DrawRectangle(val5, rectangle);
			Pen val6 = new Pen((Brush)new SolidBrush(Color.FromArgb(70, 70, 70)));
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			graphics.DrawRectangle(val6, rectangle);
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, ((Control)this).get_Width(), 0);
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), 0, 0, 0, ((Control)this).get_Height());
			graphics.DrawLine(new Pen((Brush)new SolidBrush(Color.FromArgb(45, 45, 45))), ((Control)this).get_Width() - 1, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height());
		}
	}
}
