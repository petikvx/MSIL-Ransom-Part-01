using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

public static class ImageUtil
{
	private const int bytesPerPixel = 4;

	public static Image Opacity(Image originalImage, double opacity)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		if ((ImageUtil.smethod_0(originalImage) & 0x10000) != 65536)
		{
			Bitmap val = (Bitmap)ImageUtil.smethod_1(originalImage);
			Rectangle rectangle_ = new Rectangle(0, 0, ImageUtil.smethod_2((Image)(object)val), ImageUtil.smethod_3((Image)(object)val));
			BitmapData bitmapData_ = ImageUtil.smethod_4(val, rectangle_, (ImageLockMode)3, (PixelFormat)2498570);
			IntPtr intptr_ = ImageUtil.smethod_5(bitmapData_);
			int num = ImageUtil.smethod_2((Image)(object)val) * ImageUtil.smethod_3((Image)(object)val) * 4;
			byte[] array = new byte[num];
			ImageUtil.smethod_6(intptr_, array, 0, num);
			for (int i = 0; i < array.Length; i += 4)
			{
				if (array[i + 4 - 1] != 0)
				{
					array[i + 3] = (byte)((double)(int)array[i + 3] * opacity);
				}
			}
			ImageUtil.smethod_7(array, 0, intptr_, num);
			ImageUtil.smethod_8(val, bitmapData_);
			return (Image)(object)val;
		}
		return originalImage;
	}

	static PixelFormat smethod_0(Image image_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return image_0.get_PixelFormat();
	}

	static object smethod_1(Image image_0)
	{
		return image_0.Clone();
	}

	static int smethod_2(Image image_0)
	{
		return image_0.get_Width();
	}

	static int smethod_3(Image image_0)
	{
		return image_0.get_Height();
	}

	static BitmapData smethod_4(Bitmap bitmap_0, Rectangle rectangle_0, ImageLockMode imageLockMode_0, PixelFormat pixelFormat_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return bitmap_0.LockBits(rectangle_0, imageLockMode_0, pixelFormat_0);
	}

	static IntPtr smethod_5(BitmapData bitmapData_0)
	{
		return bitmapData_0.get_Scan0();
	}

	static void smethod_6(IntPtr intptr_0, byte[] byte_0, int int_0, int int_1)
	{
		Marshal.Copy(intptr_0, byte_0, int_0, int_1);
	}

	static void smethod_7(byte[] byte_0, int int_0, IntPtr intptr_0, int int_1)
	{
		Marshal.Copy(byte_0, int_0, intptr_0, int_1);
	}

	static void smethod_8(Bitmap bitmap_0, BitmapData bitmapData_0)
	{
		bitmap_0.UnlockBits(bitmapData_0);
	}
}
