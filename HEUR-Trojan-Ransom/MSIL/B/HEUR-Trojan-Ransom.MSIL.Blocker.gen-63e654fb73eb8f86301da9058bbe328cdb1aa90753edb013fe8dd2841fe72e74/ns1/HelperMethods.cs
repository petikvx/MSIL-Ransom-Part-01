using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace ns1;

public class HelperMethods
{
	public enum MouseMode
	{
		NormalMode,
		Hovered,
		Pushed
	}

	public static GraphicsPath graphicsPath_0;

	public static void smethod_0(Graphics graphics_0, string string_0, Rectangle rectangle_0)
	{
		Image val = null;
		using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(string_0)))
		{
			val = Image.FromStream((Stream)memoryStream);
		}
		graphics_0.DrawImage(val, rectangle_0);
	}

	public static GraphicsPath smethod_1(Rectangle rectangle_0, int int_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath((FillMode)1);
		val.AddArc(rectangle_0.X, rectangle_0.Y, int_0, int_0, 180f, 90f);
		val.AddArc(rectangle_0.Right - int_0, rectangle_0.Y, int_0, int_0, 270f, 90f);
		val.AddArc(rectangle_0.Right - int_0, rectangle_0.Bottom - int_0, int_0, int_0, 0f, 90f);
		val.AddArc(rectangle_0.X, rectangle_0.Bottom - int_0, int_0, int_0, 90f, 90f);
		val.CloseFigure();
		return val;
	}

	public static void smethod_2(Graphics graphics_0, Color color_0, Rectangle rectangle_0, int int_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		graphics_0.FillPath((Brush)new SolidBrush(color_0), smethod_1(rectangle_0, int_0));
	}

	public static void smethod_3(Graphics graphics_0, Brush brush_0, Rectangle rectangle_0, int int_0)
	{
		graphics_0.FillPath(brush_0, smethod_1(rectangle_0, int_0));
	}

	public static void smethod_4(Graphics graphics_0, Color color_0, float float_0, Rectangle rectangle_0, int int_0)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		graphics_0.DrawPath(new Pen(color_0, float_0), smethod_1(rectangle_0, int_0));
	}

	public static void smethod_5(Graphics graphics_0, Color color_0, float float_0, Point point_0, Point point_1, Point point_2, Point point_3, Point point_4, Point point_5)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		graphics_0.DrawLine(new Pen(color_0, float_0), point_0, point_1);
		graphics_0.DrawLine(new Pen(color_0, float_0), point_2, point_3);
		graphics_0.DrawLine(new Pen(color_0, float_0), point_4, point_5);
	}

	public static Pen smethod_6(int int_0, int int_1, int int_2, float float_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		return new Pen(Color.FromArgb(int_0, int_1, int_2), float_0);
	}

	public static Pen smethod_7(string string_0, float float_0)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		return new Pen(smethod_10(string_0), float_0);
	}

	public static SolidBrush smethod_8(int int_0, int int_1, int int_2, int int_3 = 0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		return new SolidBrush(Color.FromArgb(int_3, int_0, int_1, int_2));
	}

	public static SolidBrush smethod_9(string string_0)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new SolidBrush(smethod_10(string_0));
	}

	public static Color smethod_10(string string_0)
	{
		return ColorTranslator.FromHtml(" " + string_0);
	}

	public static string smethod_11(Color color_0)
	{
		return ColorTranslator.ToHtml(color_0);
	}

	public static Color smethod_12(int int_0, int int_1, int int_2, int int_3)
	{
		return Color.FromArgb(int_0, int_1, int_2, int_3);
	}

	public static Color smethod_13(int int_0, int int_1, int int_2)
	{
		return Color.FromArgb(int_0, int_1, int_2);
	}

	public static Font smethod_14(string string_0, float float_0, FontStyle fontStyle_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0);
	}

	public static void smethod_15(Graphics graphics_0, string string_0, Font font_0, Brush brush_0, Rectangle rectangle_0)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		RectangleF rectangleF = new Rectangle(0, rectangle_0.Y + Convert.ToInt32(rectangle_0.Height / 2) - Convert.ToInt32(graphics_0.MeasureString(string_0, font_0).Height / 2f), rectangle_0.Width, rectangle_0.Height);
		StringFormat val = new StringFormat();
		val.set_Alignment((StringAlignment)1);
		graphics_0.DrawString(string_0, font_0, brush_0, rectangleF, val);
	}

	public static void smethod_16(Graphics graphics_0, string string_0, Font font_0, Brush brush_0, Rectangle rectangle_0)
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		RectangleF rectangleF = new Rectangle(4, rectangle_0.Y + Convert.ToInt32(rectangle_0.Height / 2) - Convert.ToInt32(graphics_0.MeasureString(string_0, font_0).Height / 2f), rectangle_0.Width, rectangle_0.Height);
		StringFormat val = new StringFormat();
		val.set_Alignment((StringAlignment)0);
		graphics_0.DrawString(string_0, font_0, brush_0, rectangleF, val);
	}

	public static void smethod_17(Graphics graphics_0, Brush brush_0, Rectangle rectangle_0)
	{
		graphics_0.FillRectangle(brush_0, rectangle_0);
	}
}
