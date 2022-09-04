using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace nO_bUILDER;

internal class Draw
{
	[DebuggerNonUserCode]
	public Draw()
	{
	}

	public GraphicsPath RoundRect(Rectangle Rectangle, int Curve)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		checked
		{
			int num = Curve * 2;
			Rectangle rectangle = new Rectangle(Rectangle.X, Rectangle.Y, num, num);
			val.AddArc(rectangle, -180f, 90f);
			rectangle = new Rectangle(Rectangle.Width - num + Rectangle.X, Rectangle.Y, num, num);
			val.AddArc(rectangle, -90f, 90f);
			rectangle = new Rectangle(Rectangle.Width - num + Rectangle.X, Rectangle.Height - num + Rectangle.Y, num, num);
			val.AddArc(rectangle, 0f, 90f);
			rectangle = new Rectangle(Rectangle.X, Rectangle.Height - num + Rectangle.Y, num, num);
			val.AddArc(rectangle, 90f, 90f);
			Point point = new Point(Rectangle.X, Rectangle.Height - num + Rectangle.Y);
			Point point2 = new Point(Rectangle.X, Curve + Rectangle.Y);
			val.AddLine(point, point2);
			return val;
		}
	}

	public GraphicsPath RoundRect(int X, int Y, int Width, int Height, int Curve)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		Rectangle rectangle = new Rectangle(X, Y, Width, Height);
		GraphicsPath val = new GraphicsPath();
		checked
		{
			int num = Curve * 2;
			Rectangle rectangle2 = new Rectangle(rectangle.X, rectangle.Y, num, num);
			val.AddArc(rectangle2, -180f, 90f);
			rectangle2 = new Rectangle(rectangle.Width - num + rectangle.X, rectangle.Y, num, num);
			val.AddArc(rectangle2, -90f, 90f);
			rectangle2 = new Rectangle(rectangle.Width - num + rectangle.X, rectangle.Height - num + rectangle.Y, num, num);
			val.AddArc(rectangle2, 0f, 90f);
			rectangle2 = new Rectangle(rectangle.X, rectangle.Height - num + rectangle.Y, num, num);
			val.AddArc(rectangle2, 90f, 90f);
			Point point = new Point(rectangle.X, rectangle.Height - num + rectangle.Y);
			Point point2 = new Point(rectangle.X, Curve + rectangle.Y);
			val.AddLine(point, point2);
			return val;
		}
	}
}
