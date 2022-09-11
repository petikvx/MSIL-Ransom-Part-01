using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ns0;

[DefaultEvent("ValueChanged")]
public class MonoFlat_TrackBar : Control
{
	public enum ValueDivisor
	{
		By1 = 1,
		By10 = 10,
		By100 = 100,
		By1000 = 1000
	}

	public delegate void ValueChangedEventHandler();

	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 136)]
	private struct Struct4
	{
	}

	private Rectangle rectangle_0;

	private bool bool_0;

	private Rectangle rectangle_1;

	private int int_0;

	private int int_1;

	private bool bool_1;

	private ValueDivisor valueDivisor_0;

	private ValueChangedEventHandler valueChangedEventHandler_0;

	private static readonly Array array_0;

	private static readonly Array array_1 = new char[68];

	private static readonly Array array_2;

	internal static byte byte_0/* Not supported: data(00) */;

	internal Rectangle rectangle_2;

	internal Rectangle rectangle_3;

	internal int int_2;

	internal Size size_0;

	internal int int_3;

	public int Minimum
	{
		get
		{
			return int_0;
		}
		set
		{
			if (value >= int_3)
			{
				value = int_3 - 10;
			}
			if (int_1 < value)
			{
				int_1 = value;
			}
			int_0 = value;
			((Control)this).Invalidate();
		}
	}

	public int Maximum
	{
		get
		{
			return int_3;
		}
		set
		{
			if (value <= int_0)
			{
				value = int_0 + 10;
			}
			if (int_1 > value)
			{
				int_1 = value;
			}
			int num = (int_3 = value);
			((Control)this).Invalidate();
		}
	}

	public int Value
	{
		get
		{
			return int_1;
		}
		set
		{
			if (int_1 != value)
			{
				if (value < int_0)
				{
					int_1 = int_0;
				}
				else if (value > int_3)
				{
					int_1 = int_3;
				}
				else
				{
					int_1 = value;
				}
				((Control)this).Invalidate();
				if (valueChangedEventHandler_0 != null)
				{
					valueChangedEventHandler_0();
				}
			}
		}
	}

	public ValueDivisor ValueDivison
	{
		get
		{
			return valueDivisor_0;
		}
		set
		{
			valueDivisor_0 = value;
			((Control)this).Invalidate();
		}
	}

	[Browsable(false)]
	public float ValueToSet
	{
		get
		{
			return int_1 / (int)valueDivisor_0;
		}
		set
		{
			Value = (int)(value * (float)valueDivisor_0);
		}
	}

	public bool JumpToMouse
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
			((Control)this).Invalidate();
		}
	}

	public event ValueChangedEventHandler ValueChanged
	{
		add
		{
			valueChangedEventHandler_0 = (ValueChangedEventHandler)Delegate.Combine(valueChangedEventHandler_0, value);
		}
		remove
		{
			valueChangedEventHandler_0 = (ValueChangedEventHandler)Delegate.Remove(valueChangedEventHandler_0, value);
		}
	}

	protected override void vmethod_0(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseMove(mouseEventArgs_0);
		checked
		{
			if (bool_0 && mouseEventArgs_0.get_X() > -1 && mouseEventArgs_0.get_X() < ((Control)this).get_Width() + 1)
			{
				Value = int_0 + (int)Math.Round((double)(int_3 - int_0) * ((double)mouseEventArgs_0.get_X() / (double)((Control)this).get_Width()));
			}
		}
	}

	protected override void vmethod_1(MouseEventArgs mouseEventArgs_0)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Unknown and I4
		((Control)this).OnMouseDown(mouseEventArgs_0);
		if ((int)mouseEventArgs_0.get_Button() == 1048576)
		{
			int num = (int_2 = (int)Math.Round((double)(int_1 - int_0) / (double)(int_3 - int_0) * (double)(((Control)this).get_Width() - 11)));
			Rectangle rectangle = (rectangle_3 = new Rectangle(int_2, 0, 25, 25));
			bool_0 = rectangle_3.Contains(mouseEventArgs_0.get_Location());
			((Control)this).Focus();
			if (bool_1)
			{
				Value = int_0 + (int)Math.Round((double)(int_3 - int_0) * ((double)mouseEventArgs_0.get_X() / (double)((Control)this).get_Width()));
			}
		}
	}

	protected override void vmethod_2(MouseEventArgs mouseEventArgs_0)
	{
		((Control)this).OnMouseUp(mouseEventArgs_0);
		bool_0 = false;
	}

	public MonoFlat_TrackBar()
	{
		Size size = (size_0 = new Size(14, 14));
		int_3 = 10;
		valueDivisor_0 = ValueDivisor.By1;
		((Control)this)._002Ector();
		((Control)this).SetStyle((ControlStyles)73746, true);
		((Control)this).set_Size(new Size(80, 22));
		((Control)this).set_MinimumSize(new Size(47, 22));
	}

	protected override void vmethod_3(EventArgs eventArgs_0)
	{
		((Control)this).OnResize(eventArgs_0);
		((Control)this).set_Height(22);
	}

	protected override void vmethod_4(PaintEventArgs paintEventArgs_0)
	{
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		((Control)this).OnPaint(paintEventArgs_0);
		Graphics graphics = paintEventArgs_0.get_Graphics();
		graphics.Clear(((Control)this).get_Parent().get_BackColor());
		graphics.set_SmoothingMode((SmoothingMode)4);
		rectangle_1 = new Rectangle(7, 10, ((Control)this).get_Width() - 16, 2);
		rectangle_0 = new Rectangle(1, 10, ((Control)this).get_Width() - 3, 2);
		try
		{
			int num = (int_2 = (int)Math.Round((double)(int_1 - int_0) / (double)(int_3 - int_0) * (double)((Control)this).get_Width()));
		}
		catch (Exception)
		{
		}
		Rectangle rectangle = (rectangle_3 = new Rectangle(int_2, 0, 3, 20));
		graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(124, 131, 137)), rectangle_0);
		Rectangle rectangle2 = (rectangle_2 = new Rectangle(0, 10, rectangle_3.X + rectangle_3.Width - 4, 3));
		graphics.ResetClip();
		graphics.set_SmoothingMode((SmoothingMode)0);
		graphics.DrawRectangle(new Pen(Color.FromArgb(124, 131, 137)), rectangle_0);
		graphics.FillRectangle((Brush)new SolidBrush(Color.FromArgb(181, 41, 42)), rectangle_2);
		graphics.ResetClip();
		graphics.set_SmoothingMode((SmoothingMode)2);
		graphics.FillEllipse((Brush)new SolidBrush(Color.FromArgb(181, 41, 42)), rectangle_1.X + (int)Math.Round((double)rectangle_1.Width * ((double)Value / (double)Maximum)) - (int)Math.Round((double)size_0.Width / 2.0), rectangle_1.Y + (int)Math.Round((double)rectangle_1.Height / 2.0) - (int)Math.Round((double)size_0.Height / 2.0), size_0.Width, size_0.Height);
		graphics.DrawEllipse(new Pen(Color.FromArgb(181, 41, 42)), rectangle_1.X + (int)Math.Round((double)rectangle_1.Width * ((double)Value / (double)Maximum)) - (int)Math.Round((double)size_0.Width / 2.0), rectangle_1.Y + (int)Math.Round((double)rectangle_1.Height / 2.0) - (int)Math.Round((double)size_0.Height / 2.0), size_0.Width, size_0.Height);
	}

	static MonoFlat_TrackBar()
	{
		char[] array = new char[8];
		array[3] = 'ᗧ';
		array[1] = '⒱';
		array[6] = '࿂';
		array[7] = '㜃';
		array[4] = 'ʊ';
		array[5] = 'ο';
		array[0] = '\u1dea';
		array[2] = '⻜';
		array_2 = new string[12];
		array_0 = array;
	}
}
