using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace White.Core.WindowsAPI;

public class DisplayedItem
{
	private struct Rect
	{
		public readonly int left;

		public readonly int top;

		public int right;

		public int bottom;
	}

	private const int srccopy = 13369376;

	private readonly IntPtr windowHandle;

	[DllImport("GDI32.dll")]
	private static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hObjectSource, int nXSrc, int nYSrc, int dwRop);

	[DllImport("GDI32.dll")]
	private static extern IntPtr CreateCompatibleBitmap(IntPtr hDC, int nWidth, int nHeight);

	[DllImport("GDI32.dll")]
	private static extern IntPtr CreateCompatibleDC(IntPtr hDC);

	[DllImport("GDI32.dll")]
	private static extern bool DeleteDC(IntPtr hDC);

	[DllImport("GDI32.dll")]
	private static extern bool DeleteObject(IntPtr hObject);

	[DllImport("GDI32.dll")]
	private static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

	[DllImport("User32.dll")]
	private static extern IntPtr GetWindowDC(IntPtr hWnd);

	[DllImport("User32.dll")]
	private static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

	[DllImport("User32.dll")]
	private static extern IntPtr GetWindowRect(IntPtr hWnd, ref Rect rect);

	public DisplayedItem(IntPtr windowHandle)
	{
		this.windowHandle = windowHandle;
	}

	public virtual Bitmap GetVisibleImage()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr intPtr3 = IntPtr.Zero;
		Image val;
		try
		{
			intPtr2 = GetWindowDC(windowHandle);
			Rect rect = default(Rect);
			GetWindowRect(windowHandle, ref rect);
			int nWidth = rect.right - rect.left;
			int nHeight = rect.bottom - rect.top;
			intPtr = CreateCompatibleDC(intPtr2);
			intPtr3 = CreateCompatibleBitmap(intPtr2, nWidth, nHeight);
			IntPtr hObject = SelectObject(intPtr, intPtr3);
			BitBlt(intPtr, 0, 0, nWidth, nHeight, intPtr2, 0, 0, 13369376);
			SelectObject(intPtr, hObject);
		}
		finally
		{
			DeleteDC(intPtr);
			ReleaseDC(windowHandle, intPtr2);
			val = (Image)(object)Image.FromHbitmap(intPtr3);
			DeleteObject(intPtr3);
		}
		return new Bitmap(val);
	}
}
