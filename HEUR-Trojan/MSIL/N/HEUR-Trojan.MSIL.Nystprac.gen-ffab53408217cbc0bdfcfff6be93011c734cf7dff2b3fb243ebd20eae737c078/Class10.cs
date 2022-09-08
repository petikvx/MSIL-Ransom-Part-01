using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;

internal class Class10
{
	[DebuggerNonUserCode]
	public Class10()
	{
		Class14.hYiyYvszsKHjE();
		base._002Ector();
	}

	public GraphicsPath method_0(Rectangle rectangle_0, int int_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		checked
		{
			int num = int_0 * 2;
			Rectangle rectangle = new Rectangle(rectangle_0.X, rectangle_0.Y, num, num);
			val.AddArc(rectangle, -180f, 90f);
			rectangle = new Rectangle(rectangle_0.Width - num + rectangle_0.X, rectangle_0.Y, num, num);
			val.AddArc(rectangle, -90f, 90f);
			rectangle = new Rectangle(rectangle_0.Width - num + rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y, num, num);
			val.AddArc(rectangle, 0f, 90f);
			rectangle = new Rectangle(rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y, num, num);
			val.AddArc(rectangle, 90f, 90f);
			Point point = new Point(rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y);
			Point point2 = new Point(rectangle_0.X, int_0 + rectangle_0.Y);
			val.AddLine(point, point2);
			return val;
		}
	}

	public GraphicsPath method_1(int int_0, int int_1, int int_2, int int_3, int int_4)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		Rectangle rectangle = new Rectangle(int_0, int_1, int_2, int_3);
		GraphicsPath val = new GraphicsPath();
		checked
		{
			int num = int_4 * 2;
			Rectangle rectangle2 = new Rectangle(rectangle.X, rectangle.Y, num, num);
			val.AddArc(rectangle2, -180f, 90f);
			rectangle2 = new Rectangle(rectangle.Width - num + rectangle.X, rectangle.Y, num, num);
			val.AddArc(rectangle2, -90f, 90f);
			rectangle2 = new Rectangle(rectangle.Width - num + rectangle.X, rectangle.Height - num + rectangle.Y, num, num);
			val.AddArc(rectangle2, 0f, 90f);
			rectangle2 = new Rectangle(rectangle.X, rectangle.Height - num + rectangle.Y, num, num);
			val.AddArc(rectangle2, 90f, 90f);
			Point point = new Point(rectangle.X, rectangle.Height - num + rectangle.Y);
			Point point2 = new Point(rectangle.X, int_4 + rectangle.Y);
			val.AddLine(point, point2);
			return val;
		}
	}
}
