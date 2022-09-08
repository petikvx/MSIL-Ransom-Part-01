using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using Orcus.Native;

namespace Orcus.Extensions;

internal static class ImageExtensions
{
	public static Bitmap ResizeImage(this Image image, int width, int height)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		Rectangle rectangle = new Rectangle(0, 0, width, height);
		Bitmap val = new Bitmap(width, height);
		val.SetResolution(image.get_HorizontalResolution(), image.get_VerticalResolution());
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			val2.set_CompositingMode((CompositingMode)1);
			val2.set_CompositingQuality((CompositingQuality)2);
			val2.set_InterpolationMode((InterpolationMode)7);
			val2.set_SmoothingMode((SmoothingMode)2);
			val2.set_PixelOffsetMode((PixelOffsetMode)2);
			ImageAttributes val3 = new ImageAttributes();
			try
			{
				val3.SetWrapMode((WrapMode)3);
				val2.DrawImage(image, rectangle, 0, 0, image.get_Width(), image.get_Height(), (GraphicsUnit)2, val3);
				return val;
			}
			finally
			{
				((IDisposable)val3)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	public static bool CompareMemCmp(Bitmap b1, Bitmap b2)
	{
		if (b1 == null != (b2 == null))
		{
			return false;
		}
		if (((Image)b1).get_Size() != ((Image)b2).get_Size())
		{
			return false;
		}
		BitmapData val = b1.LockBits(new Rectangle(new Point(0, 0), ((Image)b1).get_Size()), (ImageLockMode)1, (PixelFormat)2498570);
		BitmapData val2 = b2.LockBits(new Rectangle(new Point(0, 0), ((Image)b2).get_Size()), (ImageLockMode)1, (PixelFormat)2498570);
		try
		{
			IntPtr scan = val.get_Scan0();
			IntPtr scan2 = val2.get_Scan0();
			int num = val.get_Stride() * ((Image)b1).get_Height();
			return NativeMethods.memcmp(scan, scan2, num) == 0;
		}
		finally
		{
			b1.UnlockBits(val);
			b2.UnlockBits(val2);
		}
	}
}
