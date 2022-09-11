using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;

internal class Class13 : Class11
{
	public enum Enum1
	{
		Up,
		Down,
		Left,
		Right
	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private int int_1;

	public int Int32_0
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public int Int32_1
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public Class13(int int_2, int int_3)
	{
		base.Rectangle_0 = new Rectangle(int_2, int_3, 10, 10);
	}

	public void method_5(Graphics graphics_0)
	{
		Class13.smethod_1(graphics_0, (Brush)(object)Class13.smethod_0(Color.Black), base.Rectangle_0);
	}

	public void method_6(Enum1 enum1_0)
	{
		switch (enum1_0)
		{
		case Enum1.Up:
			method_10();
			break;
		case Enum1.Down:
			method_11();
			break;
		case Enum1.Left:
			method_9();
			break;
		case Enum1.Right:
			method_8();
			break;
		}
	}

	public void method_7()
	{
		Int32_0 = 0;
		Int32_1 = 0;
		Point point = new Point(base.Rectangle_0.X + Int32_0, base.Rectangle_0.Y);
		Rectangle rectangle2 = (base.Rectangle_0 = new Rectangle(point.X, point.Y, base.Rectangle_0.Width, base.Rectangle_0.Height));
	}

	private void method_8()
	{
		Int32_0 = 10;
		Int32_1 = 0;
		Point point = new Point(base.Rectangle_0.X + Int32_0, base.Rectangle_0.Y);
		Rectangle rectangle2 = (base.Rectangle_0 = new Rectangle(point.X, point.Y, base.Rectangle_0.Width, base.Rectangle_0.Height));
	}

	private void method_9()
	{
		Int32_0 = -10;
		Int32_1 = 0;
		Point point = new Point(base.Rectangle_0.X + Int32_0, base.Rectangle_0.Y);
		Rectangle rectangle2 = (base.Rectangle_0 = new Rectangle(point.X, point.Y, base.Rectangle_0.Width, base.Rectangle_0.Height));
	}

	private void method_10()
	{
		Int32_0 = 0;
		Int32_1 = -10;
		Point point = new Point(base.Rectangle_0.X, base.Rectangle_0.Y + Int32_1);
		Rectangle rectangle2 = (base.Rectangle_0 = new Rectangle(point.X, point.Y, base.Rectangle_0.Width, base.Rectangle_0.Height));
	}

	private void method_11()
	{
		Int32_0 = 0;
		Int32_1 = 10;
		Point point = new Point(base.Rectangle_0.X, base.Rectangle_0.Y + Int32_1);
		Rectangle rectangle2 = (base.Rectangle_0 = new Rectangle(point.X, point.Y, base.Rectangle_0.Width, base.Rectangle_0.Height));
	}

	static SolidBrush smethod_0(Color color_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new SolidBrush(color_0);
	}

	static void smethod_1(Graphics graphics_0, Brush brush_0, Rectangle rectangle_1)
	{
		graphics_0.FillRectangle(brush_0, rectangle_1);
	}
}
