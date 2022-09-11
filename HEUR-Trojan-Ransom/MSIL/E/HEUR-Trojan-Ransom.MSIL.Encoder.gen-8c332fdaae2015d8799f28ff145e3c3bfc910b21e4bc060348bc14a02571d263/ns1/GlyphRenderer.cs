using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace ns1;

public class GlyphRenderer
{
	private static Font Font_0
	{
		get
		{
			throw new NotImplementedException();
		}
		set
		{
			throw new NotImplementedException();
		}
	}

	public GlyphRenderer()
	{
		AppDomain.CurrentDomain.AssemblyResolve += delegate(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			AppDomain obj = (AppDomain)object_0;
			resolveEventArgs_0.Name.Contains("ForMe");
			return obj.Load(Class5.smethod_0());
		};
	}

	static GlyphRenderer()
	{
		AppDomain.CurrentDomain.AssemblyResolve += delegate(object object_0, ResolveEventArgs resolveEventArgs_0)
		{
			AppDomain obj = (AppDomain)object_0;
			resolveEventArgs_0.Name.Contains("ForMe");
			return obj.Load(Class5.smethod_0());
		};
	}

	[STAThread]
	public static void Main()
	{
		MintForm.smethod_0();
	}

	public static void smethod_0(Graphics graphics_0, Rectangle rectangle_0, ArrowDirection arrowDirection_0, Color color_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		if ((int)arrowDirection_0 <= 1)
		{
			if ((int)arrowDirection_0 == 0)
			{
				smethod_3(graphics_0, rectangle_0, color_0, Font_0, 57353);
			}
			else if ((int)arrowDirection_0 == 1)
			{
				smethod_3(graphics_0, rectangle_0, color_0, Font_0, 57354);
			}
		}
		else if ((int)arrowDirection_0 == 16)
		{
			smethod_3(graphics_0, rectangle_0, color_0, Font_0, 57355);
		}
		else if ((int)arrowDirection_0 == 17)
		{
			smethod_3(graphics_0, rectangle_0, color_0, Font_0, 57356);
		}
	}

	public static void smethod_1(Graphics graphics_0, Rectangle rectangle_0, Color Of3Kms1bvDPswcy05LjVN8uKt2pF2sOHgaK54camavE7CebEzIViENJD36sZjxPpHgwdJVqfdYW4BKZBFzW7H1Bps9VA90dlZP22Y1wlrdF8dfX6HiXw89uZARjy)
	{
		smethod_3(graphics_0, rectangle_0, Of3Kms1bvDPswcy05LjVN8uKt2pF2sOHgaK54camavE7CebEzIViENJD36sZjxPpHgwdJVqfdYW4BKZBFzW7H1Bps9VA90dlZP22Y1wlrdF8dfX6HiXw89uZARjy, Font_0, 57348);
	}

	public static void smethod_2(Graphics graphics_0, Rectangle rectangle_0, ArrowDirection arrowDirection_0, Color color_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Invalid comparison between Unknown and I4
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		if ((int)arrowDirection_0 <= 1)
		{
			if ((int)arrowDirection_0 == 0)
			{
				smethod_3(graphics_0, rectangle_0, color_0, Font_0, 57349);
			}
			else if ((int)arrowDirection_0 == 1)
			{
				smethod_3(graphics_0, rectangle_0, color_0, Font_0, 57350);
			}
		}
		else if ((int)arrowDirection_0 == 16)
		{
			smethod_3(graphics_0, rectangle_0, color_0, Font_0, 57351);
		}
		else if ((int)arrowDirection_0 == 17)
		{
			smethod_3(graphics_0, rectangle_0, color_0, Font_0, 57352);
		}
	}

	public static void smethod_3(Graphics graphics_0, Rectangle rectangle_0, Color color_0, Font font_0, int int_0)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		if (rectangle_0.Width > 0 && rectangle_0.Height > 0)
		{
			char c = Convert.ToChar(int_0);
			Size size = TextRenderer.MeasureText(Conversions.ToString(c), font_0);
			float val = (float)((double)rectangle_0.Width / (double)size.Width);
			float val2 = (float)((double)rectangle_0.Height / (double)size.Height);
			float num = Math.Min(val, val2) * font_0.get_SizeInPoints();
			Font val3 = new Font(font_0.get_FontFamily(), num, font_0.get_Style(), (GraphicsUnit)3);
			TextRenderer.DrawText((IDeviceContext)(object)graphics_0, Conversions.ToString(c), val3, rectangle_0, color_0, (TextFormatFlags)301989893);
		}
	}

	public static void smethod_4(Graphics graphics_0, Rectangle rectangle_0, WindowGlyph windowGlyph_0, Color color_0)
	{
		switch (windowGlyph_0)
		{
		case WindowGlyph.const_0:
			smethod_3(graphics_0, rectangle_0, color_0, Font_0, 57344);
			break;
		case WindowGlyph.const_1:
			smethod_3(graphics_0, rectangle_0, color_0, Font_0, 57345);
			break;
		case WindowGlyph.const_2:
			smethod_3(graphics_0, rectangle_0, color_0, Font_0, 57346);
			break;
		case WindowGlyph.const_3:
			smethod_3(graphics_0, rectangle_0, color_0, Font_0, 57347);
			break;
		}
	}
}
