using System.Collections;
using System.Drawing;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace IoSuaiAb;

internal class U0nDFthS
{
	internal static void EeCKkDfY(Graphics graphics_0, string string_0, Font font_0, Brush brush_0, float float_0, float float_1, int int_0)
	{
		switch (int_0 ^ 0x1847)
		{
		}
		graphics_0.DrawString(string_0, font_0, brush_0, float_0, float_1);
	}

	internal static IEnumerator asPgdGWu(ArrayList arrayList_0, int int_0)
	{
		return (int_0 ^ 0x4352) switch
		{
			_ => arrayList_0.GetEnumerator(), 
		};
	}

	internal static object GUtqfq8v(IEnumerator ienumerator_0, int int_0)
	{
		return (int_0 ^ 0x9DD8) switch
		{
			_ => ienumerator_0.Current, 
		};
	}

	internal static bool PLVhCXAS(IEnumerator ienumerator_0, int int_0)
	{
		return (int_0 ^ 0xFCD) switch
		{
			_ => ienumerator_0.MoveNext(), 
		};
	}

	internal static int cEC971DY(ArrayList arrayList_0, object object_0, int int_0)
	{
		return (int_0 ^ 0x7E6F) switch
		{
			_ => arrayList_0.Add(object_0), 
		};
	}

	internal static Rectangle gwkkMhir(Rectangle rectangle_0, Rectangle rectangle_1, int int_0)
	{
		return (int_0 ^ 0x21B7) switch
		{
			_ => Rectangle.Union(rectangle_0, rectangle_1), 
		};
	}

	internal static object vs7aiRoe(ArrayList arrayList_0, int int_0, int int_1)
	{
		return (int_1 ^ 0x36F) switch
		{
			_ => arrayList_0[int_0], 
		};
	}

	internal static void smethod_0(ArrayList arrayList_0, int int_0, int int_1)
	{
		switch (int_1 ^ 0x39DC)
		{
		}
		arrayList_0.RemoveAt(int_0);
	}

	internal static char SW3y4MmE(string string_0, int int_0)
	{
		return (int_0 ^ 0xF98F) switch
		{
			_ => Conversions.ToChar(string_0), 
		};
	}

	internal static string gu9J6OJy(char char_0, int int_0)
	{
		return (int_0 ^ 0xBE3C) switch
		{
			_ => Conversions.ToString(char_0), 
		};
	}

	internal static bool suM9Ppzl(string string_0, string string_1, CompareMethod compareMethod_0, int int_0)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		return (int_0 ^ 0xEC21) switch
		{
			_ => LikeOperator.LikeString(string_0, string_1, compareMethod_0), 
		};
	}

	internal static string gn4174gi(string string_0, int int_0, int int_1, int int_2)
	{
		return (int_2 ^ 0x323B) switch
		{
			1 => string_0.Substring(int_0, int_1), 
			_ => string_0.Remove(int_0, int_1), 
		};
	}

	internal static int a7rPdJnI(string string_0, string string_1, int int_0)
	{
		return (int_0 ^ 0xD6C) switch
		{
			_ => string_0.IndexOf(string_1), 
		};
	}

	internal static string smethod_1(string string_0, int int_0, int int_1)
	{
		return (int_1 ^ 0x2D1E) switch
		{
			_ => string_0.Substring(int_0), 
		};
	}

	internal static int nm6dbcmt(Image image_0, int int_0)
	{
		return (int_0 ^ 0x16C1) switch
		{
			1 => image_0.get_Width(), 
			_ => image_0.get_Height(), 
		};
	}

	internal static Color mIiGIlxc(int int_0, int int_1, int int_2, int int_3, int int_4)
	{
		return (int_4 ^ 0xEC86) switch
		{
			_ => Color.FromArgb(int_0, int_1, int_2, int_3), 
		};
	}

	internal static bool dQyYmTkI(Color color_0, Color color_1, int int_0)
	{
		return (int_0 ^ 0x23C3) switch
		{
			_ => color_0 != color_1, 
		};
	}

	internal static Color smethod_2(Bitmap bitmap_0, int int_0, int int_1, int int_2)
	{
		return (int_2 ^ 0x42A) switch
		{
			_ => bitmap_0.GetPixel(int_0, int_1), 
		};
	}

	internal static Encoding fMEKY27X(int int_0)
	{
		return (int_0 ^ 0x46BB) switch
		{
			1 => Encoding.ASCII, 
			2 => Encoding.UTF8, 
			_ => Encoding.Default, 
		};
	}

	internal static string KYtvrGZK(Encoding encoding_0, byte[] byte_0, int int_0)
	{
		return (int_0 ^ 0x4F41) switch
		{
			_ => encoding_0.GetString(byte_0), 
		};
	}
}
