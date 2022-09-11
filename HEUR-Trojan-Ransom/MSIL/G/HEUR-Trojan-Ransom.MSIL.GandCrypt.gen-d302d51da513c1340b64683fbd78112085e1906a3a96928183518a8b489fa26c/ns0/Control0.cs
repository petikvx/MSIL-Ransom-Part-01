using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns0;

internal sealed class Control0 : Control
{
	private Graphics graphics_0;

	private bool bool_0;

	private float float_0;

	private float float_1;

	[CompilerGenerated]
	private Color color_0;

	internal float float_2;

	internal float float_3;

	internal string string_0;

	internal float float_4;

	internal bool bool_1;

	internal Color color_1;

	internal Color color_2;

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
			return float_0;
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
			float_0 = value;
			((Control)this).Invalidate();
		}
	}

	public float Single_1
	{
		get
		{
			return float_4;
		}
		set
		{
			if (value < float_0)
			{
				float_0 = value;
			}
			float num = (float_4 = value);
			((Control)this).Invalidate();
		}
	}

	public float Single_2
	{
		get
		{
			return float_1;
		}
		set
		{
			if (value > float_0)
			{
				float_0 = value;
			}
			float_1 = value;
			((Control)this).Invalidate();
		}
	}

	public Color Color_0
	{
		[CompilerGenerated]
		get
		{
			return color_1;
		}
		[CompilerGenerated]
		set
		{
			Color color = (color_1 = value);
		}
	}

	public Color Color_1
	{
		[CompilerGenerated]
		get
		{
			return color_2;
		}
		[CompilerGenerated]
		set
		{
			Color color = (color_2 = value);
		}
	}

	public Color Color_2
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

	public Control0()
	{
		float num = (float_4 = 100f);
		bool_1 = true;
		Color color = (color_1 = Color.LightGray);
		Color color2 = (color_2 = Color.Green);
		color_0 = Color.Red;
		((Control)this)._002Ector();
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
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_028f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		graphics_0 = paintEventArgs_0.get_Graphics();
		graphics_0.set_SmoothingMode((SmoothingMode)2);
		graphics_0.set_TextRenderingHint((TextRenderingHint)5);
		((Control)this).OnPaint(paintEventArgs_0);
		float num = (float_2 = 360f / Single_1 * Single_0);
		float num2 = (float_3 = 360f - float_2);
		Pen val = new Pen((Brush)new HatchBrush((HatchStyle)19, Color_1, Color_2), 4f);
		try
		{
			Pen val2 = new Pen(Color_0, 4f);
			try
			{
				graphics_0.DrawArc(val, new Rectangle(2, 2, ((Control)this).get_Width() - 5, ((Control)this).get_Height() - 5), -90f, float_2);
				graphics_0.DrawArc(val2, new Rectangle(2, 2, ((Control)this).get_Width() - 5, ((Control)this).get_Height() - 5), float_2 - 90f, float_3);
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
