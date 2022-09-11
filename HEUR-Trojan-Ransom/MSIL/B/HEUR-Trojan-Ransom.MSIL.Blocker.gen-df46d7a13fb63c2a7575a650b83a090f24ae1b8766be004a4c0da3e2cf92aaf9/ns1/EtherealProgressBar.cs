using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace ns1;

public class EtherealProgressBar : Control
{
	public delegate void ValueChangedEventHandler(object sender);

	private int int_0 = 8;

	private Color color_0;

	private Color color_1;

	[CompilerGenerated]
	private ValueChangedEventHandler valueChangedEventHandler_0;

	internal int int_1 = 100;

	internal int int_2;

	internal int int_3;

	internal Color color_2;

	public int Value
	{
		get
		{
			if (int_2 < 0)
			{
				return 0;
			}
			return int_2;
		}
		set
		{
			if (value > Maximum)
			{
				int num = (int_2 = Maximum);
			}
			int num2 = (int_2 = value);
			method_0();
			((Control)this).Invalidate();
			if (valueChangedEventHandler_0 != null)
			{
				valueChangedEventHandler_0(this);
			}
			((Control)this).Invalidate();
		}
	}

	public int Maximum
	{
		get
		{
			return int_1;
		}
		set
		{
			if (int_1 < value)
			{
				int num = (int_2 = value);
			}
			int num2 = (int_1 = value);
			((Control)this).Invalidate();
		}
	}

	public int RoundRadius
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			((Control)this).Invalidate();
		}
	}

	public Color ProgressColor
	{
		get
		{
			return color_2;
		}
		set
		{
			Color color = (color_2 = value);
			((Control)this).Invalidate();
		}
	}

	public Color BaseColor
	{
		get
		{
			return color_0;
		}
		set
		{
			color_0 = value;
			((Control)this).Invalidate();
		}
	}

	public Color BorderColor
	{
		get
		{
			return color_1;
		}
		set
		{
			color_1 = value;
			((Control)this).Invalidate();
		}
	}

	public event ValueChangedEventHandler ValueChanged
	{
		[CompilerGenerated]
		add
		{
			ValueChangedEventHandler valueChangedEventHandler = valueChangedEventHandler_0;
			ValueChangedEventHandler valueChangedEventHandler2;
			do
			{
				valueChangedEventHandler2 = valueChangedEventHandler;
				ValueChangedEventHandler value2 = (ValueChangedEventHandler)Delegate.Combine(valueChangedEventHandler2, value);
				valueChangedEventHandler = Interlocked.CompareExchange(ref valueChangedEventHandler_0, value2, valueChangedEventHandler2);
			}
			while ((object)valueChangedEventHandler != valueChangedEventHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ValueChangedEventHandler valueChangedEventHandler = valueChangedEventHandler_0;
			ValueChangedEventHandler valueChangedEventHandler2;
			do
			{
				valueChangedEventHandler2 = valueChangedEventHandler;
				ValueChangedEventHandler value2 = (ValueChangedEventHandler)Delegate.Remove(valueChangedEventHandler2, value);
				valueChangedEventHandler = Interlocked.CompareExchange(ref valueChangedEventHandler_0, value2, valueChangedEventHandler2);
			}
			while ((object)valueChangedEventHandler != valueChangedEventHandler2);
		}
	}

	protected override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		Bitmap val = new Bitmap(((Control)this).get_Width(), ((Control)this).get_Height());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.set_SmoothingMode((SmoothingMode)2);
			Rectangle rectangle_ = new Rectangle(0, 0, ((Control)this).get_Width() - 1, ((Control)this).get_Height() - 1);
			HelperMethods.smethod_4(val2, (Brush)new SolidBrush(BaseColor), rectangle_, RoundRadius);
			HelperMethods.smethod_5(val2, BorderColor, 1f, rectangle_, RoundRadius);
			if (int_3 != 0)
			{
				HelperMethods.smethod_3(val2, ProgressColor, new Rectangle(rectangle_.X, rectangle_.Y, int_3, rectangle_.Height), RoundRadius);
			}
			paintEventArgs_0.get_Graphics().DrawImage((Image)(object)val, 0, 0);
			val2.Dispose();
			((Image)val).Dispose();
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	public EtherealProgressBar()
	{
		Color color = (color_2 = HelperMethods.smethod_11(" "));
		color_0 = HelperMethods.smethod_11(" ");
		color_1 = HelperMethods.smethod_11(" ");
		((Control)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)141330, true);
		((Control)this).set_DoubleBuffered(true);
		((Control)this).set_BackColor(Color.Transparent);
		((Control)this).UpdateStyles();
		int num = (int_3 = Convert.ToInt32(int_2 / int_1 * ((Control)this).get_Width()));
	}

	public void method_0()
	{
		int num = (int_3 = (int)Math.Round((double)Value / (double)Maximum * (double)((Control)this).get_Width()));
	}
}
