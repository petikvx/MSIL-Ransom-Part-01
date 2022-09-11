using System.Drawing;

internal class Class6
{
	private Pen pen_0;

	private RectangleF rectangleF_0;

	public bool bool_0;

	public Pen Pen_0
	{
		get
		{
			return pen_0;
		}
		set
		{
			pen_0 = value;
		}
	}

	public RectangleF RectangleF_0
	{
		get
		{
			return rectangleF_0;
		}
		set
		{
			rectangleF_0 = value;
		}
	}

	public Class6(Pen pen_1, RectangleF rectangleF_1, bool bool_1)
	{
		bool_0 = bool_1;
		Pen_0 = pen_1;
		RectangleF_0 = rectangleF_1;
	}

	public void method_0(Graphics graphics_0)
	{
		if (!bool_0)
		{
			Class6.smethod_2(graphics_0, pen_0, RectangleF_0.X, RectangleF_0.Y, RectangleF_0.Width, RectangleF_0.Height);
		}
		else
		{
			Class6.smethod_1(graphics_0, Class6.smethod_0(pen_0), RectangleF_0.X, RectangleF_0.Y, RectangleF_0.Width, RectangleF_0.Height);
		}
	}

	static Brush smethod_0(Pen pen_1)
	{
		return pen_1.get_Brush();
	}

	static void smethod_1(Graphics graphics_0, Brush brush_0, float float_0, float float_1, float float_2, float float_3)
	{
		graphics_0.FillRectangle(brush_0, float_0, float_1, float_2, float_3);
	}

	static void smethod_2(Graphics graphics_0, Pen pen_1, float float_0, float float_1, float float_2, float float_3)
	{
		graphics_0.DrawRectangle(pen_1, float_0, float_1, float_2, float_3);
	}
}
