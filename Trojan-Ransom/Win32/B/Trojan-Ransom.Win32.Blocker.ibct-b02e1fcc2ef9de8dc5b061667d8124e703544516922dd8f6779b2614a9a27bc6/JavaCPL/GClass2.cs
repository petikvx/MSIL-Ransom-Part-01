using System;
using System.Drawing;
using System.Threading;

namespace JavaCPL;

public static class GClass2
{
	public struct RECT
	{
		public int left;

		public int top;

		public int right;

		public int bottom;
	}

	public static int int_0;

	public static int int_1;

	public static RECT[] rect_0 = new RECT[10];

	public static int[] int_2 = new int[10];

	public static Point point_0;

	public static Bitmap bitmap_0;

	public static Point point_1;

	public static bool bool_0 = false;

	public static void smethod_0()
	{
		while (true)
		{
			Thread.Sleep(200);
			if (bool_0)
			{
				continue;
			}
			if (GClass4.smethod_7())
			{
				Point point = (point_1 = GClass1.smethod_6());
				if (point.X != 0)
				{
					smethod_3();
					_ = Environment.TickCount;
					bitmap_0 = GClass4.smethod_10(out point_0);
					smethod_1();
					((Image)bitmap_0).Dispose();
				}
			}
			GC.Collect();
		}
	}

	public static void smethod_1()
	{
		int num = 0;
		int num2 = -1;
		bool flag = false;
		int num3 = 0;
		for (int i = 0; i < 10; i++)
		{
			try
			{
				RECT rECT = rect_0[i];
				GClass5 gClass = new GClass5(bitmap_0);
				GClass3 gclass3_ = gClass.method_0(rECT.left, rECT.top, rECT.right, rECT.bottom);
				num3 = smethod_7(gclass3_);
				gClass.method_7();
			}
			catch (Exception)
			{
				num3 = -1;
			}
			if (num3 > -1)
			{
				int_2[i] = num3;
				num += num3;
			}
			else
			{
				flag = true;
				num2 = i;
			}
		}
		if (flag)
		{
			int_2[num2] = 45 - num;
		}
	}

	public static RECT smethod_2(int int_3, int int_4, int int_5, int int_6)
	{
		RECT result = default(RECT);
		result.left = int_3;
		result.top = int_4;
		result.right = int_5;
		result.bottom = int_6;
		return result;
	}

	public static void smethod_3()
	{
		Point point = GClass1.smethod_6();
		int_0 = point.X + 4;
		int_1 = point.Y + 4;
		int num = 0;
		int num2;
		for (int i = 0; i < 3; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				num2 = int_0 + i * 90;
				int num3 = int_1 + j * 72;
				ref RECT reference = ref rect_0[num];
				reference = smethod_2(num2, num3, num2 + 56, num3 + 56);
				num++;
			}
		}
		num2 = int_0 + 270;
		ref RECT reference2 = ref rect_0[9];
		reference2 = smethod_2(num2, int_1, num2 + 56, int_1 + 56);
	}

	public static bool smethod_4(int int_3, int int_4, int int_5)
	{
		return Math.Abs(int_3 - int_4) <= int_5;
	}

	public static bool smethod_5(Color color_0, Color color_1, int int_3, int int_4, int int_5)
	{
		if (smethod_4(color_0.R, color_1.R, int_3) && smethod_4(color_0.G, color_1.G, int_4) && smethod_4(color_0.B, color_1.B, int_5))
		{
			return true;
		}
		return false;
	}

	public static int smethod_6()
	{
		try
		{
			if (GClass1.smethod_6().X < 1)
			{
				return -1;
			}
			int int_ = 70;
			int int_2 = 25;
			int int_3 = 30;
			int num = int_0 + 397 - 4;
			int num2 = int_1 - 62 - 4;
			int num3 = 0;
			for (int i = 0; i < 4; i++)
			{
				Color pixel = bitmap_0.GetPixel(num + i * 16, num2);
				if (smethod_5(pixel, Color.DarkOrange, int_, int_2, int_3))
				{
					num3++;
				}
			}
			switch (num3)
			{
			case 4:
				return 1;
			case 3:
				return 2;
			case 2:
				return 3;
			case 1:
				return 4;
			}
		}
		catch (ArgumentException)
		{
			return -1;
		}
		return -1;
	}

	public static int smethod_7(GClass3 gclass3_0)
	{
		double num = gclass3_0.method_2();
		if (num == 0.0)
		{
			return -1;
		}
		int num2 = (int)Math.Floor(num * 1000.0);
		int result = -1;
		switch (num2)
		{
		case 98:
			result = 4;
			break;
		case 74:
			result = 5;
			break;
		case 61:
			result = 7;
			break;
		case 125:
			result = 8;
			break;
		case 119:
			result = 1;
			break;
		case 112:
			result = 0;
			break;
		}
		if (num2 == 103)
		{
			int num3 = gclass3_0.method_4(bool_0: false);
			int num4 = gclass3_0.method_4(bool_0: true);
			result = ((num3 >= num4) ? 6 : 9);
		}
		if (num2 == 90)
		{
			int num5 = gclass3_0.method_4(bool_0: false);
			if (num5 == 4)
			{
				result = 3;
			}
			if (num5 == 5)
			{
				result = 2;
			}
		}
		return result;
	}
}
