using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Gecko.Windows;

namespace Gecko.Utils;

public static class WindowsImageCreator
{
	private static byte[] SaveBmpAsPng(Bitmap bmp)
	{
		byte[] result = null;
		using (MemoryStream memoryStream = new MemoryStream(500))
		{
			((Image)bmp).Save((Stream)memoryStream, ImageFormat.get_Png());
			result = memoryStream.ToArray();
		}
		return result;
	}

	private static byte[] HbitmapToPng(IntPtr hBitmap)
	{
		byte[] result = null;
		try
		{
			Bitmap val = Image.FromHbitmap(hBitmap);
			try
			{
				result = SaveBmpAsPng(val);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch (Exception)
		{
		}
		return result;
	}

	public static byte[] WindowsCapturePng(IntPtr handle)
	{
		IntPtr windowDC = User32.GetWindowDC(handle);
		User32.RECT rect = default(User32.RECT);
		User32.GetWindowRect(handle, ref rect);
		int nWidth = rect.right - rect.left;
		int nHeight = rect.bottom - rect.top;
		IntPtr intPtr = Gdi32.CreateCompatibleDC(windowDC);
		IntPtr intPtr2 = Gdi32.CreateCompatibleBitmap(windowDC, nWidth, nHeight);
		IntPtr hObject = Gdi32.SelectObject(intPtr, intPtr2);
		Gdi32.BitBlt(intPtr, 0, 0, nWidth, nHeight, windowDC, 0, 0, 13369376);
		Gdi32.SelectObject(intPtr, hObject);
		Gdi32.DeleteDC(intPtr);
		User32.ReleaseDC(handle, windowDC);
		byte[] result = HbitmapToPng(intPtr2);
		Gdi32.DeleteObject(intPtr2);
		return result;
	}

	public static byte[] CapturePng(this GeckoWebBrowser browser)
	{
		return WindowsCapturePng(((Control)browser).get_Handle());
	}

	public static Bitmap GetBitmap(this GeckoWebBrowser browser, uint width, uint height)
	{
		return browser.GetBitmap(0u, 0u, width, height);
	}

	public static Bitmap GetBitmap(this GeckoWebBrowser browser, uint xOffset, uint yOffset, uint width, uint height)
	{
		return new ImageCreator(browser).CanvasGetBitmap(xOffset, yOffset, width, height);
	}
}
