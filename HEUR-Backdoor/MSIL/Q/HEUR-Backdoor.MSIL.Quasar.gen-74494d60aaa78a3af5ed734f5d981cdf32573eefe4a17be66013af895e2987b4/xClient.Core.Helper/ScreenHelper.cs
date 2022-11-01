using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using xClient.Core.Utilities;

namespace xClient.Core.Helper;

public static class ScreenHelper
{
	private const int SRCCOPY = 13369376;

	public static Bitmap CaptureScreen(int screenNumber)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		Rectangle bounds = GetBounds(screenNumber);
		Bitmap val = new Bitmap(bounds.Width, bounds.Height, (PixelFormat)925707);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		try
		{
			IntPtr hdc = val2.GetHdc();
			IntPtr intPtr = NativeMethods.CreateDC("DISPLAY", null, null, IntPtr.Zero);
			NativeMethods.BitBlt(hdc, 0, 0, bounds.Width, bounds.Height, intPtr, bounds.X, bounds.Y, 13369376);
			NativeMethods.DeleteDC(intPtr);
			val2.ReleaseHdc(hdc);
			return val;
		}
		finally
		{
			((IDisposable)val2)?.Dispose();
		}
	}

	public static Rectangle GetBounds(int screenNumber)
	{
		return Screen.get_AllScreens()[screenNumber].get_Bounds();
	}
}
