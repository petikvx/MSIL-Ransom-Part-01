using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

public static class GClass48
{
	private const int int_0 = 13369376;

	public static Bitmap smethod_0(int screenNumber)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		Rectangle rectangle = smethod_1(screenNumber);
		Bitmap val = new Bitmap(rectangle.Width, rectangle.Height, (PixelFormat)925707);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			IntPtr hdc = val2.GetHdc();
			IntPtr intPtr = GClass8.CreateDC("DISPLAY", null, null, IntPtr.Zero);
			GClass8.BitBlt(hdc, 0, 0, rectangle.Width, rectangle.Height, intPtr, rectangle.X, rectangle.Y, 13369376);
			GClass8.DeleteDC(intPtr);
			val2.ReleaseHdc(hdc);
			return val;
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	public static Rectangle smethod_1(int screenNumber)
	{
		return Screen.get_AllScreens()[screenNumber].get_Bounds();
	}
}
