using System.Drawing;
using System.Drawing.Drawing2D;

namespace ns0;

internal static class Class2
{
	public static GraphicsPath smethod_0(Rectangle rectangle_0, int int_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		int num = int_0 * 2;
		val.AddArc(new Rectangle(rectangle_0.X, rectangle_0.Y, num, num), -180f, 90f);
		val.AddArc(new Rectangle(rectangle_0.Width - num + rectangle_0.X, rectangle_0.Y, num, num), -90f, 90f);
		val.AddArc(new Rectangle(rectangle_0.Width - num + rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y, num, num), 0f, 90f);
		val.AddArc(new Rectangle(rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y, num, num), 90f, 90f);
		val.AddLine(new Point(rectangle_0.X, rectangle_0.Height - num + rectangle_0.Y), new Point(rectangle_0.X, int_0 + rectangle_0.Y));
		return val;
	}

	public static GraphicsPath smethod_1(int int_0, int int_1, int int_2, int int_3, int int_4)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		Rectangle rectangle = new Rectangle(int_0, int_1, int_2, int_3);
		GraphicsPath val = new GraphicsPath();
		int num = int_4 * 2;
		val.AddArc(new Rectangle(rectangle.X, rectangle.Y, num, num), -180f, 90f);
		val.AddArc(new Rectangle(rectangle.Width - num + rectangle.X, rectangle.Y, num, num), -90f, 90f);
		val.AddArc(new Rectangle(rectangle.Width - num + rectangle.X, rectangle.Height - num + rectangle.Y, num, num), 0f, 90f);
		val.AddArc(new Rectangle(rectangle.X, rectangle.Height - num + rectangle.Y, num, num), 90f, 90f);
		val.AddLine(new Point(rectangle.X, rectangle.Height - num + rectangle.Y), new Point(rectangle.X, int_4 + rectangle.Y));
		return val;
	}

	public static void smethod_2(Graphics graphics_0, Rectangle rectangle_0, Color[] color_0)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		int num = 1;
		int num2 = 0;
		for (int i = 0; i < color_0.Length; i++)
		{
			Color color = color_0[i];
			graphics_0.DrawRectangle(new Pen((Brush)new SolidBrush(Color.FromArgb(color.R, color.B, color.G))), rectangle_0.X + num2, rectangle_0.Y + num2, rectangle_0.Width - num, rectangle_0.Height - num);
			num += 2;
			num2++;
		}
	}

	public static void smethod_3(Graphics graphics_0, Rectangle rectangle_0, int int_0, Color[] color_0)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		int num = 1;
		int num2 = 0;
		for (int i = 0; i < color_0.Length; i++)
		{
			Color color = color_0[i];
			graphics_0.DrawPath(new Pen((Brush)new SolidBrush(Color.FromArgb(color.R, color.B, color.G))), smethod_1(rectangle_0.X + num2, rectangle_0.Y + num2, rectangle_0.Width - num, rectangle_0.Height - num, int_0));
			num += 2;
			num2++;
		}
	}
}
