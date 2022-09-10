using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace ASCAvSvc;

public class PerplexProgressBar : Control
{
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

	public PerplexProgressBar()
	{
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
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Expected O, but got Unknown
		//IL_022d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		val2.set_SmoothingMode((SmoothingMode)2);
		checked
		{
			int num = (int)Math.Round((double)_Value / (double)_Maximum * (double)((Control)this).get_Width());
			val2.Clear(((Control)this).get_BackColor());
			LinearGradientBrush val3 = new LinearGradientBrush(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1), Color.FromArgb(26, 26, 26), Color.FromArgb(30, 30, 30), 90f);
			val2.FillPath((Brush)(object)val3, Draw.RoundRect(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1), 1));
			LinearGradientBrush val4 = new LinearGradientBrush(new Rectangle(2, 2, num - 1, ((Control)this).get_Height() - 2), Color.FromArgb(174, 195, 30), Color.FromArgb(141, 153, 16), 90f);
			val2.FillPath((Brush)(object)val4, Draw.RoundRect(new Rectangle(0, 0, num - 1, ((Control)this).get_Height() - 2), 1));
			HatchBrush val5 = new HatchBrush((HatchStyle)21, Color.FromArgb(50, 174, 195, 30), Color.FromArgb(25, 141, 153, 16));
			val2.FillPath((Brush)(object)val5, Draw.RoundRect(new Rectangle(0, 0, num - 1, ((Control)this).get_Height() - 2), 1));
			val2.DrawPath(new Pen(Color.FromArgb(0, 0, 0)), Draw.RoundRect(new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1), 2));
			val2.DrawPath(new Pen(Color.FromArgb(150, 97, 94, 90)), Draw.RoundRect(new Rectangle(0, 0, num - 1, ((Control)this).get_Height() - 1), 2));
			val2.DrawPath(new Pen(Color.FromArgb(0, 0, 0)), Draw.RoundRect(new Rectangle(0, 0, num - 1, ((Control)this).get_Height() - 1), 2));
			if (_ShowPercentage)
			{
				string? text = Convert.ToString(Value + "%");
				Font font = ((Control)this).get_Font();
				Brush white = Brushes.get_White();
				RectangleF rectangleF = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
				StringFormat val6 = new StringFormat();
				val6.set_Alignment((StringAlignment)1);
				val6.set_LineAlignment((StringAlignment)1);
				val2.DrawString(text, font, white, rectangleF, val6);
			}
			NewLateBinding.LateCall((object)e.get_Graphics(), (Type)null, "DrawImage", new object[3]
			{
				((Image)val).Clone(),
				0,
				0
			}, (string[])null, (Type[])null, (bool[])null, true);
			val2.Dispose();
			((Image)val).Dispose();
		}
	}
}
