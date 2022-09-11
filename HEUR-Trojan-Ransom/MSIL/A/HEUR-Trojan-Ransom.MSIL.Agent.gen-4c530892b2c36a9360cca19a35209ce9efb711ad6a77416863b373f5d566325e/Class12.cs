using System.Drawing;

internal class Class12 : Class11
{
	private int int_0;

	public Class12(int int_1, int int_2, int int_3, int int_4, int int_5 = 5)
	{
		base.Rectangle_0 = new Rectangle(int_1, int_2, int_3, int_4);
		int_0 = int_5;
	}

	public void method_5(Graphics graphics_0)
	{
		Class12.smethod_1(graphics_0, Class12.smethod_0(Color.Black, (float)int_0), base.Rectangle_0);
	}

	static Pen smethod_0(Color color_0, float float_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Expected O, but got Unknown
		return new Pen(color_0, float_0);
	}

	static void smethod_1(Graphics graphics_0, Pen pen_0, Rectangle rectangle_1)
	{
		graphics_0.DrawRectangle(pen_0, rectangle_1);
	}
}
