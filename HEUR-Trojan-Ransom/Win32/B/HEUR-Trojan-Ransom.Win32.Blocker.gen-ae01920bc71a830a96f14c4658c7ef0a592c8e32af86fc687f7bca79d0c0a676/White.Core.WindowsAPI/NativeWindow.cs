using System;
using System.Runtime.InteropServices;
using System.Windows;

namespace White.Core.WindowsAPI;

public class NativeWindow
{
	private readonly IntPtr handle;

	public virtual COLORREF BackgroundColor => GetBkColor(GetDC(handle));

	public virtual COLORREF TextColor => GetTextColor(GetDC(handle));

	[DllImport("user32.dll")]
	private static extern IntPtr WindowFromPoint(POINT point);

	[DllImport("user32.dll")]
	private static extern IntPtr GetDC(IntPtr hWnd);

	[DllImport("gdi32.dll")]
	private static extern COLORREF GetBkColor(IntPtr hdc);

	[DllImport("gdi32.dll")]
	private static extern COLORREF GetTextColor(IntPtr hdc);

	public NativeWindow(Point point)
	{
		handle = WindowFromPoint(new POINT((int)((Point)(ref point)).get_X(), (int)((Point)(ref point)).get_Y()));
	}

	public NativeWindow(IntPtr handle)
	{
		this.handle = handle;
	}
}
