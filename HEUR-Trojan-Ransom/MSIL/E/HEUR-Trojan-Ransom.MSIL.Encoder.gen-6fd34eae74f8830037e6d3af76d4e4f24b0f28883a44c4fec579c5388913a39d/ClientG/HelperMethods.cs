using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;

namespace ClientG;

[StandardModule]
public sealed class HelperMethods
{
	public enum MouseMode : byte
	{
		NormalMode,
		Hovered,
		Pushed
	}

	public static GraphicsPath GP;

	public static void DrawImageFromBase64(Graphics G, string Base64Image, Rectangle Rect)
	{
		Image val = null;
		Graphics val2 = G;
		using (MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(Base64Image)))
		{
			val = Image.FromStream((Stream)memoryStream);
			memoryStream.Close();
		}
		val2.DrawImage(val, Rect);
		val2 = null;
	}

	public static GraphicsPath RoundRec(Rectangle r, int Curve)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath((FillMode)1);
		val.AddArc(r.X, r.Y, Curve, Curve, 180f, 90f);
		checked
		{
			val.AddArc(r.Right - Curve, r.Y, Curve, Curve, 270f, 90f);
			val.AddArc(r.Right - Curve, r.Bottom - Curve, Curve, Curve, 0f, 90f);
			val.AddArc(r.X, r.Bottom - Curve, Curve, Curve, 90f, 90f);
			val.CloseFigure();
			return val;
		}
	}

	public static void FillRoundedPath(Graphics G, Color C, Rectangle Rect, int Curve)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		Graphics val = G;
		val.FillPath((Brush)new SolidBrush(C), RoundRec(Rect, Curve));
		val = null;
	}

	public static void FillRoundedPath(Graphics G, Brush B, Rectangle Rect, int Curve)
	{
		Graphics val = G;
		val.FillPath(B, RoundRec(Rect, Curve));
		val = null;
	}

	public static void DrawRoundedPath(Graphics G, Color C, float Size, Rectangle Rect, int Curve)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		Graphics val = G;
		val.DrawPath(new Pen(C, Size), RoundRec(Rect, Curve));
		val = null;
	}

	public static void DrawTriangle(Graphics G, Color C, int Size, Point P1_0, Point P1_1, Point P2_0, Point P2_1, Point P3_0, Point P3_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		Graphics val = G;
		val.DrawLine(new Pen(C, (float)Size), P1_0, P1_1);
		val.DrawLine(new Pen(C, (float)Size), P2_0, P2_1);
		val.DrawLine(new Pen(C, (float)Size), P3_0, P3_1);
		val = null;
	}

	public static Pen PenRGBColor(Graphics GR, int R, int G, int B, float Size)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		return new Pen(Color.FromArgb(R, G, B), Size);
	}

	public static Pen PenHTMlColor(string C_WithoutHash, float Size)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		return new Pen(GetHTMLColor(C_WithoutHash), Size);
	}

	public static SolidBrush SolidBrushRGBColor(int R, int G, int B)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		return new SolidBrush(Color.FromArgb(R, G, B));
	}

	public static SolidBrush SolidBrushHTMlColor(string C_WithoutHash)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new SolidBrush(GetHTMLColor(C_WithoutHash));
	}

	public static Color GetHTMLColor(string C_WithoutHash)
	{
		return ColorTranslator.FromHtml("#" + C_WithoutHash);
	}

	public static string ColorToHTML(Color C)
	{
		return ColorTranslator.ToHtml(C);
	}

	public static Color SetARGB(int A, int R, int G, int B)
	{
		return Color.FromArgb(A, R, G, B);
	}

	public static Color SetRGB(int R, int G, int B)
	{
		return Color.FromArgb(R, G, B);
	}

	public static void CentreString(Graphics G, string Text, Font font, Brush brush, Rectangle Rect)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		Rectangle rectangle = new Rectangle(0, checked((int)Math.Round((double)Rect.Y + (double)Rect.Height / 2.0 - (double)(G.MeasureString(Text, font).Height / 2f) + 0.0)), Rect.Width, Rect.Height);
		RectangleF rectangleF = rectangle;
		StringFormat val = new StringFormat();
		val.set_Alignment((StringAlignment)1);
		G.DrawString(Text, font, brush, rectangleF, val);
	}

	public static void LeftString(Graphics G, string Text, Font font, Brush brush, Rectangle Rect)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		Rectangle rectangle = new Rectangle(4, checked((int)Math.Round((double)Rect.Y + (double)Rect.Height / 2.0 - (double)(G.MeasureString(Text, font).Height / 2f) + 0.0)), Rect.Width, Rect.Height);
		RectangleF rectangleF = rectangle;
		StringFormat val = new StringFormat();
		val.set_Alignment((StringAlignment)0);
		G.DrawString(Text, font, brush, rectangleF, val);
	}

	public static void FillRect(Graphics G, Brush Br, Rectangle Rect)
	{
		G.FillRectangle(Br, Rect);
	}
}
