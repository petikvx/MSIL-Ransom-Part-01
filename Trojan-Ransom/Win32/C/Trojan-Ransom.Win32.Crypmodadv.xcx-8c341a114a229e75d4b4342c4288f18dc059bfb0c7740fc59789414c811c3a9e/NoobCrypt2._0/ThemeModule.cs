using System.Drawing;
using System.Drawing.Drawing2D;
using Microsoft.VisualBasic.CompilerServices;

namespace NoobCrypt2._0;

[StandardModule]
internal sealed class ThemeModule
{
	internal static Graphics G;

	private static Bitmap TextBitmap;

	private static Graphics TextGraphics;

	private static GraphicsPath CreateRoundPath;

	private static Rectangle CreateRoundRectangle;

	static ThemeModule()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		TextBitmap = new Bitmap(1, 1);
		TextGraphics = Graphics.FromImage((Image)(object)TextBitmap);
	}

	internal static SizeF MeasureString(string text, Font font)
	{
		return TextGraphics.MeasureString(text, font);
	}

	internal static SizeF MeasureString(string text, Font font, int width)
	{
		return TextGraphics.MeasureString(text, font, width, StringFormat.get_GenericTypographic());
	}

	internal static GraphicsPath CreateRound(int x, int y, int width, int height, int slope)
	{
		CreateRoundRectangle = new Rectangle(x, y, width, height);
		return CreateRound(CreateRoundRectangle, slope);
	}

	internal static GraphicsPath CreateRound(Rectangle r, int slope)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		CreateRoundPath = new GraphicsPath((FillMode)1);
		CreateRoundPath.AddArc(r.X, r.Y, slope, slope, 180f, 90f);
		checked
		{
			CreateRoundPath.AddArc(r.Right - slope, r.Y, slope, slope, 270f, 90f);
			CreateRoundPath.AddArc(r.Right - slope, r.Bottom - slope, slope, slope, 0f, 90f);
			CreateRoundPath.AddArc(r.X, r.Bottom - slope, slope, slope, 90f, 90f);
			CreateRoundPath.CloseFigure();
			return CreateRoundPath;
		}
	}
}
