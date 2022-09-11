using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns1;

internal sealed class Control0 : Control
{
	private Graphics graphics_0;

	private float float_0;

	private bool bool_0;

	private float float_1 = 100f;

	[CompilerGenerated]
	private Color color_0 = Color.LightGray;

	[CompilerGenerated]
	private Color color_1 = Color.Green;

	[CompilerGenerated]
	private Color color_2 = Color.Red;

	internal float float_2;

	internal string string_0;

	internal float float_3;

	internal float float_4;

	internal bool bool_1 = true;

	public bool Boolean_0
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool flag = (bool_1 = value);
		}
	}

	public float Single_0
	{
		get
		{
			return float_3;
		}
		set
		{
			if (value > Single_1)
			{
				value = Single_1;
				string text = (string_0 = "+");
				bool_0 = true;
				((Control)this).Invalidate();
			}
			else if (value < Single_2)
			{
				value = Single_2;
				string text2 = (string_0 = "-");
				bool_0 = true;
				((Control)this).Invalidate();
			}
			float num = (float_3 = value);
			((Control)this).Invalidate();
		}
	}

	public float Single_1
	{
		get
		{
			return float_1;
		}
		set
		{
			if (value < float_3)
			{
				float num = (float_3 = value);
			}
			float_1 = value;
			((Control)this).Invalidate();
		}
	}

	public float Single_2
	{
		get
		{
			return float_4;
		}
		set
		{
			if (value > float_3)
			{
				float num = (float_3 = value);
			}
			float num2 = (float_4 = value);
			((Control)this).Invalidate();
		}
	}

	public Color Color_0
	{
		[CompilerGenerated]
		get
		{
			return color_0;
		}
		[CompilerGenerated]
		set
		{
			color_0 = value;
		}
	}

	public Color Color_1
	{
		[CompilerGenerated]
		get
		{
			return color_1;
		}
		[CompilerGenerated]
		set
		{
			color_1 = value;
		}
	}

	public Color Color_2
	{
		[CompilerGenerated]
		get
		{
			return color_2;
		}
		[CompilerGenerated]
		set
		{
			color_2 = value;
		}
	}

	public Control0()
	{
		((Control)this).set_DoubleBuffered(true);
	}

	public static void smethod_0(Graphics graphics_1, string string_1, Font font_0, Color color_3, Rectangle rectangle_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		SizeF sizeF = graphics_1.MeasureString(string_1, font_0);
		SolidBrush val = new SolidBrush(color_3);
		try
		{
			graphics_1.DrawString(string_1, font_0, (Brush)(object)val, (PointF)new Point(rectangle_0.Width / 2 - (int)(sizeF.Width / 2f), rectangle_0.Height / 2 - (int)(sizeF.Height / 2f)));
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}

	protected override void vmethod_0(PaintEventArgs paintEventArgs_0)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		graphics_0 = paintEventArgs_0.get_Graphics();
		graphics_0.set_SmoothingMode((SmoothingMode)2);
		graphics_0.set_TextRenderingHint((TextRenderingHint)5);
		((Control)this).OnPaint(paintEventArgs_0);
		float num = (float_2 = 360f / Single_1 * Single_0);
		float_0 = 360f - float_2;
		Pen val = new Pen((Brush)new HatchBrush((HatchStyle)19, Color_1, Color_2), 4f);
		try
		{
			Pen val2 = new Pen(Color_0, 4f);
			try
			{
				graphics_0.DrawArc(val, new Rectangle(2, 2, ((Control)this).get_Width() - 5, ((Control)this).get_Height() - 5), -90f, float_2);
				graphics_0.DrawArc(val2, new Rectangle(2, 2, ((Control)this).get_Width() - 5, ((Control)this).get_Height() - 5), float_2 - 90f, float_0);
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
		if (Boolean_0)
		{
			Font val3 = new Font("Segoe UI", 9f, (FontStyle)1);
			try
			{
				if (bool_0)
				{
					smethod_0(graphics_0, Single_0 + "%" + string_0, val3, Color.FromArgb(100, 100, 100), new Rectangle(1, 1, ((Control)this).get_Width(), ((Control)this).get_Height() + 1));
				}
				else
				{
					smethod_0(graphics_0, Single_0 + "%", val3, Color.FromArgb(100, 100, 100), new Rectangle(1, 1, ((Control)this).get_Width(), ((Control)this).get_Height() + 1));
				}
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		else if (bool_0)
		{
			smethod_0(graphics_0, Single_0 + string_0, new Font("Segoe UI", 9f, (FontStyle)1), Color.FromArgb(100, 100, 100), new Rectangle(1, 1, ((Control)this).get_Width(), ((Control)this).get_Height() + 1));
		}
		else
		{
			smethod_0(graphics_0, Single_0.ToString(), new Font("Segoe UI", 9f, (FontStyle)1), Color.FromArgb(100, 100, 100), new Rectangle(1, 1, ((Control)this).get_Width(), ((Control)this).get_Height() + 1));
		}
		bool_0 = false;
		smethod_0(graphics_0, ((Control)this).get_Text().ToUpper(), new Font("Segoe UI", 6f, (FontStyle)1), Color.FromArgb(170, 170, 170), new Rectangle(2, 2, ((Control)this).get_Width(), ((Control)this).get_Height() + 27));
	}
}
