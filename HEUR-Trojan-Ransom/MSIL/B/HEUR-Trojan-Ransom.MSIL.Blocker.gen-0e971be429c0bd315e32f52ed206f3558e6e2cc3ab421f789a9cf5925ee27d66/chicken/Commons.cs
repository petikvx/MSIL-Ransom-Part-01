using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace chicken;

public class Commons
{
	public static readonly int COLOR_LIMIT_R = 1;

	public static readonly int COLOR_LIMIT_G = 1;

	public static readonly int COLOR_LIMIT_B = 1;

	public static readonly int COLOR_LIMIT_A = 1;

	private static bool dsqffjSlUIAtsxdqINEUkxbihSDd(Color c1, Color c2)
	{
		short value = (short)((c1.R - c2.R) & 0xFF);
		byte value2 = (byte)((uint)(c1.G - c2.G) & 0xFFu);
		byte value3 = (byte)((uint)(c1.B - c2.B) & 0xFFu);
		byte value4 = (byte)((uint)(c1.A - c2.A) & 0xFFu);
		return Math.Abs(value) < COLOR_LIMIT_R && Math.Abs(value2) < COLOR_LIMIT_G && Math.Abs(value3) < COLOR_LIMIT_B && Math.Abs(value4) < COLOR_LIMIT_A;
	}

	public static GraphicsPath calcGraphicsPath(Bitmap bitmap)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		GraphicsPath val = new GraphicsPath();
		GraphicsUnit val2 = (GraphicsUnit)2;
		Color pixel = bitmap.GetPixel(0, 0);
		RectangleF bounds = ((Image)bitmap).GetBounds(ref val2);
		int num = (int)bounds.Height;
		int num2 = (int)bounds.Width;
		Queue<Rectangle> queue = new Queue<Rectangle>(255);
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num2; j++)
			{
				if (!dsqffjSlUIAtsxdqINEUkxbihSDd(bitmap.GetPixel(j, i), pixel))
				{
					int num3 = j;
					int k;
					for (k = num3; k < num2 && !dsqffjSlUIAtsxdqINEUkxbihSDd(bitmap.GetPixel(k, i), pixel); k++)
					{
					}
					queue.Enqueue(new Rectangle(num3, i, k - num3, 1));
					j = k;
				}
			}
		}
		val.AddRectangles(queue.ToArray());
		return val;
	}

	public static GraphicsPath CalculateControlGraphicsPath(Bitmap bitmap)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		GraphicsPath val = new GraphicsPath();
		Color pixel = bitmap.GetPixel(0, 0);
		for (int i = 0; i < ((Image)bitmap).get_Height(); i++)
		{
			for (int j = 0; j < ((Image)bitmap).get_Width(); j++)
			{
				if (!dsqffjSlUIAtsxdqINEUkxbihSDd(bitmap.GetPixel(j, i), pixel))
				{
					int num = j;
					int k;
					for (k = num; k < ((Image)bitmap).get_Width() && !dsqffjSlUIAtsxdqINEUkxbihSDd(bitmap.GetPixel(k, i), pixel); k++)
					{
					}
					val.AddRectangle(new Rectangle(num, i, k - num, 1));
					j = k;
				}
			}
		}
		return val;
	}
}
