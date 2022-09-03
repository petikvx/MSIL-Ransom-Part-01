using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace JavaCPL;

public class GClass5
{
	public Bitmap bitmap_0;

	private int int_0;

	private int int_1;

	private BitmapData bitmapData_0;

	private unsafe byte* pByte_0 = null;

	private Point Point_0
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			GraphicsUnit val = (GraphicsUnit)2;
			RectangleF bounds = ((Image)bitmap_0).GetBounds(ref val);
			return new Point((int)bounds.Width, (int)bounds.Height);
		}
	}

	public GClass3 method_0(int int_2, int int_3, int int_4, int int_5)
	{
		method_8();
		List<Point> list = new List<Point>();
		for (int i = int_2; i < int_4; i++)
		{
			for (int j = int_3; j < int_5; j++)
			{
				GStruct0 gStruct = method_10(i, j);
				if (gStruct.byte_2 == byte.MaxValue && gStruct.byte_1 == 152 && gStruct.byte_0 == 31)
				{
					list.Add(new Point(i, j));
				}
			}
		}
		method_12();
		return new GClass3(list.ToArray());
	}

	public Point method_1(Color color_0, bool bool_0)
	{
		return new Point(method_5(300, bool_0: true, color_0), method_6(300, bool_0: true, color_0, bool_0));
	}

	public Point method_2(Color color_0, bool bool_0)
	{
		return new Point(method_5(300, bool_0: false, color_0), method_6(300, bool_0: false, color_0, bool_0));
	}

	public bool method_3(Color color_0)
	{
		if (color_0.R == color_0.G && color_0.G == color_0.B && color_0.R == color_0.B)
		{
			return true;
		}
		return false;
	}

	public bool method_4()
	{
		if (int_0 > 800)
		{
			return int_1 > 600;
		}
		return false;
	}

	public int method_5(int int_2, bool bool_0, Color color_0)
	{
		int result = 0;
		method_8();
		int width = ((Image)bitmap_0).get_Width();
		if (bool_0)
		{
			for (int i = 1; i < 500; i++)
			{
				GStruct0 gStruct = method_10(i, int_2);
				bool flag = false;
				if (!((color_0.R != 0) ? (gStruct.byte_2 == color_0.R && gStruct.byte_1 == color_0.G && (gStruct.byte_0 == color_0.B || gStruct.byte_0 == 1)) : (!method_3(Color.FromArgb(gStruct.byte_2, gStruct.byte_1, gStruct.byte_0)))))
				{
					continue;
				}
				result = i;
				gStruct = method_10(i + 2, int_2);
				if (gStruct.byte_2 != 0 || gStruct.byte_1 != 0 || (gStruct.byte_0 != 0 && gStruct.byte_0 != 1))
				{
					break;
				}
				for (int j = i + 2; j < 500; j++)
				{
					gStruct = method_10(j, int_2);
					if (gStruct.byte_2 != 0 || gStruct.byte_1 != 0 || (gStruct.byte_0 != 0 && gStruct.byte_0 != 1))
					{
						result = j;
						break;
					}
				}
				break;
			}
		}
		else
		{
			int num = width - 2;
			while (num > 500)
			{
				GStruct0 gStruct2 = method_10(num, int_2);
				if (color_0.R == 50)
				{
					color_0 = Color.FromArgb(58, 58, 58);
				}
				bool flag2 = false;
				if (!((color_0.R != 0) ? (gStruct2.byte_2 == color_0.R && gStruct2.byte_1 == color_0.G && (gStruct2.byte_0 == color_0.B || gStruct2.byte_0 == 1)) : (!method_3(Color.FromArgb(gStruct2.byte_2, gStruct2.byte_1, gStruct2.byte_0)))))
				{
					num--;
					continue;
				}
				result = num;
				gStruct2 = method_10(num - 2, int_2);
				if (gStruct2.byte_2 != 0 || gStruct2.byte_1 != 0 || (gStruct2.byte_0 != 0 && gStruct2.byte_0 != 1))
				{
					break;
				}
				int num2 = num - 2;
				while (num2 > 500)
				{
					gStruct2 = method_10(num2, int_2);
					if (gStruct2.byte_2 == 0 && gStruct2.byte_1 == 0 && (gStruct2.byte_0 == 0 || gStruct2.byte_0 == 1))
					{
						num2--;
						continue;
					}
					result = num2;
					break;
				}
				break;
			}
		}
		method_12();
		return result;
	}

	public int method_6(int int_2, bool bool_0, Color color_0, bool bool_1)
	{
		int result = 0;
		method_8();
		int height = ((Image)bitmap_0).get_Height();
		if (bool_0)
		{
			for (int i = 2; i < 100; i++)
			{
				GStruct0 gStruct = method_10(int_2, i);
				bool flag = false;
				if (!((color_0.R != 0) ? (gStruct.byte_2 == color_0.R && gStruct.byte_1 == color_0.G && (gStruct.byte_0 == color_0.B || gStruct.byte_0 == 1)) : (!method_3(Color.FromArgb(gStruct.byte_2, gStruct.byte_1, gStruct.byte_0)))))
				{
					continue;
				}
				result = i;
				gStruct = method_10(int_2, i + 2);
				if (gStruct.byte_2 != 0 || gStruct.byte_1 != 0 || (gStruct.byte_0 != 0 && gStruct.byte_0 != 1))
				{
					break;
				}
				for (int j = i + 2; j < 500; j++)
				{
					gStruct = method_10(int_2, j);
					if (gStruct.byte_2 != 0 || gStruct.byte_1 != 0 || (gStruct.byte_0 != 0 && gStruct.byte_0 != 1))
					{
						result = j;
						break;
					}
				}
				break;
			}
		}
		else
		{
			if (color_0.R == 50)
			{
				color_0 = Color.FromArgb(58, 58, 58);
			}
			int num = 0;
			for (int num2 = height - 10; num2 > 400; num2--)
			{
				GStruct0 gStruct2 = method_10(int_2, num2);
				bool flag2 = false;
				if ((color_0.R != 0) ? (gStruct2.byte_2 == color_0.R && gStruct2.byte_1 == color_0.G && (gStruct2.byte_0 == color_0.B || gStruct2.byte_0 == 1)) : (!method_3(Color.FromArgb(gStruct2.byte_2, gStruct2.byte_1, gStruct2.byte_0))))
				{
					if (bool_1)
					{
						num += 2;
					}
					num++;
					if (num > 2)
					{
						result = num2;
						gStruct2 = method_10(int_2, num2 - 2);
						if (gStruct2.byte_2 != 0 || gStruct2.byte_1 != 0 || (gStruct2.byte_0 != 0 && gStruct2.byte_0 != 1))
						{
							break;
						}
						int num3 = num2 - 10;
						while (num3 > 400)
						{
							gStruct2 = method_10(int_2, num3);
							if (gStruct2.byte_2 == 0 && gStruct2.byte_1 == 0 && (gStruct2.byte_0 == 0 || gStruct2.byte_0 == 1))
							{
								num3--;
								continue;
							}
							result = num3;
							break;
						}
						break;
					}
				}
			}
		}
		method_12();
		return result;
	}

	public unsafe GClass5(Bitmap bitmap_1)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		bitmap_0 = new Bitmap((Image)(object)bitmap_1);
	}

	public unsafe GClass5(int int_2, int int_3)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		bitmap_0 = new Bitmap(int_2, int_3, (PixelFormat)137224);
	}

	public void method_7()
	{
		((Image)bitmap_0).Dispose();
	}

	public unsafe void method_8()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		GraphicsUnit val = (GraphicsUnit)2;
		RectangleF bounds = ((Image)bitmap_0).GetBounds(ref val);
		Rectangle rectangle = new Rectangle((int)bounds.X, (int)bounds.Y, (int)bounds.Width, (int)bounds.Height);
		int_0 = (int)bounds.Width * sizeof(GStruct0);
		if (int_0 % 4 != 0)
		{
			int_0 = 4 * (int_0 / 4 + 1);
		}
		int_1 = ((Image)bitmap_0).get_Height();
		bitmapData_0 = bitmap_0.LockBits(rectangle, (ImageLockMode)3, (PixelFormat)137224);
		pByte_0 = (byte*)bitmapData_0.get_Scan0().ToPointer();
	}

	public unsafe GStruct0* method_9(int int_2, int int_3)
	{
		return (GStruct0*)(pByte_0 + (nint)int_3 * (nint)int_0 + (nint)int_2 * (nint)sizeof(GStruct0));
	}

	public unsafe GStruct0 method_10(int int_2, int int_3)
	{
		return *method_9(int_2, int_3);
	}

	public unsafe void method_11(int int_2, int int_3, GStruct0 gstruct0_0)
	{
		GStruct0* ptr = method_9(int_2, int_3);
		*ptr = gstruct0_0;
	}

	public unsafe void method_12()
	{
		bitmap_0.UnlockBits(bitmapData_0);
		bitmapData_0 = null;
		pByte_0 = null;
	}
}
