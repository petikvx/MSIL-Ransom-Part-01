using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace Spy_PC;

public class ScreenCapture
{
	private class GDI32
	{
		public const int SRCCOPY = 13369376;

		[DllImport("gdi32.dll")]
		public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hObjectSource, int nXSrc, int nYSrc, int dwRop);

		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth, int nHeight);

		[DllImport("gdi32.dll")]
		public static extern IntPtr CreateCompatibleDC(IntPtr hDC);

		[DllImport("gdi32.dll")]
		public static extern bool DeleteDC(IntPtr hDC);

		[DllImport("gdi32.dll")]
		public static extern bool DeleteObject(IntPtr hObject);

		[DllImport("gdi32.dll")]
		public static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);
	}

	private class User32
	{
		public struct RECT
		{
			public int left;

			public int top;

			public int right;

			public int bottom;
		}

		[DllImport("user32.dll")]
		public static extern IntPtr GetDesktopWindow();

		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowDC(IntPtr hWnd);

		[DllImport("user32.dll")]
		public static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

		[DllImport("user32.dll")]
		public static extern IntPtr GetWindowRect(IntPtr hWnd, ref RECT rect);
	}

	public Image CaptureScreen()
	{
		return CaptureWindow(User32.GetDesktopWindow());
	}

	public Image CaptureWindow(IntPtr handle)
	{
		IntPtr windowDC = User32.GetWindowDC(handle);
		User32.RECT rect = default(User32.RECT);
		User32.GetWindowRect(handle, ref rect);
		int nWidth = rect.right - rect.left;
		int nHeight = rect.bottom - rect.top;
		IntPtr intPtr = GDI32.CreateCompatibleDC(windowDC);
		IntPtr intPtr2 = GDI32.CreateCompatibleBitmap(windowDC, nWidth, nHeight);
		IntPtr hObject = GDI32.SelectObject(intPtr, intPtr2);
		GDI32.BitBlt(intPtr, 0, 0, nWidth, nHeight, windowDC, 0, 0, 13369376);
		GDI32.SelectObject(intPtr, hObject);
		GDI32.DeleteDC(intPtr);
		User32.ReleaseDC(handle, windowDC);
		Bitmap result = Image.FromHbitmap(intPtr2);
		GDI32.DeleteObject(intPtr2);
		return (Image)(object)result;
	}

	public void CaptureWindowToFile(IntPtr handle, string filename, ImageFormat format)
	{
		CaptureWindow(handle).Save(filename, format);
	}

	public void CaptureScreenToFile(string filename, ImageFormat format)
	{
		CaptureScreen().Save(filename, format);
	}
}
