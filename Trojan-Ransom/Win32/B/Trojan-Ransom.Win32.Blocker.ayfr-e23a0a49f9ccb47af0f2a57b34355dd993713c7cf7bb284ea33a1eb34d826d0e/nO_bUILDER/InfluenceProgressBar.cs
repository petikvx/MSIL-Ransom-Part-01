using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace nO_bUILDER;

public class InfluenceProgressBar : Control
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private int OFS;

	private int Speed;

	private int _Maximum;

	private int _Value;

	private bool _ShowPercentage;

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
				return 0;
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

	public bool ShowPercentage
	{
		get
		{
			return _ShowPercentage;
		}
		set
		{
			_ShowPercentage = value;
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

	protected override void CreateHandle()
	{
		((Control)this).CreateHandle();
		Thread thread = new Thread(Animate);
		thread.IsBackground = true;
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

	public InfluenceProgressBar()
	{
		__ENCAddToList(this);
		OFS = 0;
		Speed = 50;
		_Maximum = 100;
		_Value = 0;
		_ShowPercentage = false;
		((Control)this).set_DoubleBuffered(true);
		((Control)this).SetStyle((ControlStyles)2050, true);
		((Control)this).set_BackColor(Color.Transparent);
	}

	protected override void OnPaint(PaintEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0228: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.set_SmoothingMode((SmoothingMode)2);
		Draw draw = new Draw();
		checked
		{
			int num = (int)Math.Round((double)_Value / (double)_Maximum * (double)((Control)this).get_Width());
			val2.Clear(((Control)this).get_BackColor());
			Rectangle rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			LinearGradientBrush val3 = new LinearGradientBrush(rectangle, Color.FromArgb(16, 16, 16), Color.FromArgb(22, 22, 22), 90f);
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			val2.FillPath((Brush)(object)val3, draw.RoundRect(rectangle, 2));
			rectangle = new Rectangle(0, 0, num - 1, ((Control)this).get_Height() - 2);
			LinearGradientBrush val4 = new LinearGradientBrush(rectangle, Color.FromArgb(125, 78, 75, 73), Color.FromArgb(125, 61, 59, 55), 90f);
			rectangle = new Rectangle(0, 0, num - 1, ((Control)this).get_Height() - 2);
			val2.FillPath((Brush)(object)val4, draw.RoundRect(rectangle, 2));
			HatchBrush val5 = new HatchBrush((HatchStyle)21, Color.FromArgb(100, 31, 31, 31), Color.FromArgb(100, 36, 36, 36));
			rectangle = new Rectangle(0, 0, num - 1, ((Control)this).get_Height() - 2);
			val2.FillPath((Brush)(object)val5, draw.RoundRect(rectangle, 2));
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0));
			LinearGradientBrush val6 = new LinearGradientBrush(rectangle, Color.FromArgb(35, Color.White), Color.FromArgb(0, Color.White), 90f);
			rectangle = new Rectangle(0, 0, num - 1, (int)Math.Round((double)((Control)this).get_Height() / 2.0 - 1.0));
			val2.FillPath((Brush)(object)val6, draw.RoundRect(rectangle, 2));
			Pen val7 = new Pen(Color.FromArgb(125, 97, 94, 90));
			rectangle = new Rectangle(0, 1, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 3);
			val2.DrawPath(val7, draw.RoundRect(rectangle, 2));
			Pen val8 = new Pen(Color.FromArgb(0, 0, 0));
			rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			val2.DrawPath(val8, draw.RoundRect(rectangle, 2));
			Pen val9 = new Pen(Color.FromArgb(150, 97, 94, 90));
			rectangle = new Rectangle(0, 0, num - 1, ((Control)this).get_Height() - 1);
			val2.DrawPath(val9, draw.RoundRect(rectangle, 2));
			Pen val10 = new Pen(Color.FromArgb(0, 0, 0));
			rectangle = new Rectangle(0, 0, num - 1, ((Control)this).get_Height() - 1);
			val2.DrawPath(val10, draw.RoundRect(rectangle, 2));
			if (_ShowPercentage)
			{
				string? text = Convert.ToString(Value + "%");
				Font font = ((Control)this).get_Font();
				Brush white = Brushes.get_White();
				rectangle = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				RectangleF rectangleF = rectangle;
				StringFormat val11 = new StringFormat();
				val11.set_Alignment((StringAlignment)1);
				val11.set_LineAlignment((StringAlignment)1);
				val2.DrawString(text, font, white, rectangleF, val11);
			}
			NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "DrawImage", new object[3]
			{
				RuntimeHelpers.GetObjectValue(((Image)val).Clone()),
				0,
				0
			}, (string[])null, (Type[])null, (bool[])null, true);
			val2.Dispose();
			((Image)val).Dispose();
		}
	}
}
