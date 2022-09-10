using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace Sage.Peachtree.OnlineUpdate;

public class Win32
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct WindowMessages
	{
		public const int WM_COMMAND = 273;

		public const int WM_SYSKEYDOWN = 260;

		public const int WM_ERASEBKGND = 20;

		public const int WM_ACTIVATE = 6;

		public const int WM_SHOWWINDOW = 24;

		public const int WM_NCACTIVATE = 134;

		public const int WM_ACTIVATEAPP = 28;

		public const int WM_KEYDOWN = 256;

		public const int WM_HSCROLL = 276;

		public const int WM_VSCROLL = 277;

		public const int WM_WHEELMOUSE = 522;

		public const int WM_MOUSEACTIVATE = 33;

		public const int WM_USER = 1024;

		public const int WM_DRAWCLIPBOARD = 776;

		public const int WM_CHANGECBCHAIN = 781;

		public const int WM_LBUTTONDOWN = 513;

		public const int IDCANCEL = 2;
	}

	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct ControlMessages
	{
		public const int EC_LEFTMARGIN = 1;

		public const int EC_RIGHTMARGIN = 2;

		public const int EM_SETMARGINS = 211;
	}

	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct MessageBoxIcons
	{
		public static int Asterisk = 4;

		public static int Error = 3;

		public static int Exclamation = 1;

		public static int Hand = 3;

		public static int Information = 4;

		public static int Question = 2;

		public static int Stop = 3;

		public static int Warning = 1;
	}

	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct DeviceCapabilities
	{
		public static int PHYSICALOFFSETX = 112;

		public static int PHYSICALOFFSETY = 113;

		public static int HORZRES = 8;

		public static int VERTRES = 10;
	}

	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct SystemParametersActions
	{
		public const int SPI_GETNONCLIENTMETRICS = 41;
	}

	public enum WindowLongAttribute
	{
		GWL_USERDATA = -21,
		GWL_EXSTYLE = -20,
		GWL_STYLE = -16,
		GWL_ID = -12,
		GWL_HWNDPARENT = -8,
		GWL_HINSTANCE = -6,
		GWL_WNDPROC = -4,
		DWL_MSGRESULT = 0,
		DWL_DLGPROC = 4,
		DWL_USER = 8
	}

	public struct WINDOWPLACEMENT
	{
		private uint length;

		public uint flags;

		public ShowCommand showCmd;

		public POINT ptMinPosition;

		public POINT ptMaxPosition;

		public RECT rcNormalPosition;

		public WINDOWPLACEMENT(ShowCommand initialShow)
		{
			length = 0u;
			flags = 0u;
			showCmd = initialShow;
			ptMinPosition.x = 0;
			ptMinPosition.y = 0;
			ptMaxPosition.x = 0;
			ptMaxPosition.y = 0;
			rcNormalPosition.left = 0;
			rcNormalPosition.top = 0;
			rcNormalPosition.right = 0;
			rcNormalPosition.bottom = 0;
			length = (uint)Marshal.SizeOf((object)this);
		}
	}

	public struct WINDOWPOS
	{
		public IntPtr hwnd;

		public IntPtr hwndInsertAfter;

		public int x;

		public int y;

		public int cx;

		public int cy;

		public uint flags;
	}

	public enum SetWindowsPosFlags : uint
	{
		SWP_NOSIZE = 1u,
		SWP_NOMOVE = 2u,
		SWP_NOZORDER = 4u,
		SWP_NOREDRAW = 8u,
		SWP_NOACTIVATE = 16u,
		SWP_FRAMECHANGED = 32u,
		SWP_DRAWFRAME = 32u,
		SWP_SHOWWINDOW = 64u,
		SWP_HIDEWINDOW = 128u,
		SWP_NOCOPYBITS = 256u,
		SWP_NOOWNERZORDER = 512u,
		SWP_NOREPOSITION = 512u,
		SWP_NOSENDCHANGING = 1024u,
		SWP_DEFERERASE = 8192u,
		SWP_ASYNCWINDOWPOS = 16384u
	}

	public enum WindowStyle
	{
		WS_OVERLAPPED = 0,
		WS_POPUP = int.MinValue,
		WS_CHILD = 1073741824,
		WS_MINIMIZE = 536870912,
		WS_VISIBLE = 268435456,
		WS_DISABLED = 134217728,
		WS_CLIPSIBLINGS = 67108864,
		WS_CLIPCHILDREN = 33554432,
		WS_MAXIMIZE = 16777216,
		WS_CAPTION = 12582912,
		WS_BORDER = 8388608,
		WS_DLGFRAME = 4194304,
		WS_VSCROLL = 2097152,
		WS_HSCROLL = 1048576,
		WS_SYSMENU = 524288,
		WS_THICKFRAME = 262144,
		WS_GROUP = 131072,
		WS_TABSTOP = 65536,
		WS_MINIMIZEBOX = 131072,
		WS_MAXIMIZEBOX = 65536,
		WS_TILED = 0,
		WS_ICONIC = 536870912,
		WS_SIZEBOX = 262144,
		WS_TILEDWINDOW = 13565952,
		WS_OVERLAPPEDWINDOW = 13565952,
		WS_POPUPWINDOW = -2138570752,
		WS_CHILDWINDOW = 1073741824
	}

	public enum ExtendedWindowStyle
	{
		WS_EX_DLGMODALFRAME = 1,
		WS_EX_NOPARENTNOTIFY = 4,
		WS_EX_TOPMOST = 8,
		WS_EX_ACCEPTFILES = 16,
		WS_EX_TRANSPARENT = 32,
		WS_EX_MDICHILD = 64,
		WS_EX_TOOLWINDOW = 128,
		WS_EX_WINDOWEDGE = 256,
		WS_EX_CLIENTEDGE = 512,
		WS_EX_CONTEXTHELP = 1024,
		WS_EX_RIGHT = 4096,
		WS_EX_LEFT = 0,
		WS_EX_RTLREADING = 8192,
		WS_EX_LTRREADING = 0,
		WS_EX_LEFTSCROLLBAR = 16384,
		WS_EX_RIGHTSCROLLBAR = 0,
		WS_EX_CONTROLPARENT = 65536,
		WS_EX_STATICEDGE = 131072,
		WS_EX_APPWINDOW = 262144,
		WS_EX_OVERLAPPEDWINDOW = 768,
		WS_EX_PALETTEWINDOW = 392,
		WS_EX_LAYERED = 524288,
		WS_EX_NOINHERITLAYOUT = 1048576,
		WS_EX_LAYOUTRTL = 4194304,
		WS_EX_COMPOSITED = 33554432,
		WS_EX_NOACTIVATE = 134217728
	}

	public enum MouseActivateReturnCode
	{
		MA_ACTIVATE = 1,
		MA_ACTIVATEANDEAT,
		MA_NOACTIVATE,
		MA_NOACTIVATEANDEAT
	}

	public enum ShowCommand
	{
		SW_HIDE = 0,
		SW_SHOWNORMAL = 1,
		SW_NORMAL = 1,
		SW_SHOWMINIMIZED = 2,
		SW_SHOWMAXIMIZED = 3,
		SW_MAXIMIZE = 3,
		SW_SHOWNOACTIVATE = 4,
		SW_SHOW = 5,
		SW_MINIMIZE = 6,
		SW_SHOWMINNOACTIVE = 7,
		SW_SHOWNA = 8,
		SW_RESTORE = 9,
		SW_SHOWDEFAULT = 10,
		SW_FORCEMINIMIZE = 11,
		SW_MAX = 11
	}

	public enum ShowWindowLParam
	{
		SW_PARENTCLOSING = 1,
		SW_OTHERZOOM,
		SW_PARENTOPENING,
		SW_OTHERUNZOOM
	}

	public enum DrawThemeBackgroundState
	{
		CBXS_NORMAL = 1,
		CBXS_HOT,
		CBXS_PRESSED
	}

	public struct POINT
	{
		public int x;

		public int y;
	}

	public struct RECT
	{
		public int left;

		public int top;

		public int right;

		public int bottom;

		public int Width => right - left;

		public int Height => bottom - top;

		public RECT(int left_, int top_, int right_, int bottom_)
		{
			left = left_;
			top = top_;
			right = right_;
			bottom = bottom_;
		}

		public static implicit operator Rectangle(RECT source)
		{
			return new Rectangle(source.left, source.top, source.Width, source.Height);
		}

		public static RECT FromRectangle(Rectangle rectangle)
		{
			return new RECT(rectangle.Left, rectangle.Top, rectangle.Right, rectangle.Bottom);
		}
	}

	public struct HELPINFO
	{
		public uint cbSize;

		public int iContextType;

		public int iCtrlId;

		public IntPtr hItemHandle;

		public int dwContextId;

		public POINT MousePos;

		public static HELPINFO UnmarshalFrom(IntPtr lParam)
		{
			return (HELPINFO)Marshal.PtrToStructure(lParam, typeof(HELPINFO));
		}
	}

	public delegate void MsgBoxCallback(IntPtr lpHelpInfo);

	public struct MSGBOXPARAMS
	{
		public uint cbSize;

		public IntPtr hwndOwner;

		public IntPtr hInstance;

		public string lpszText;

		public string lpszCaption;

		public uint dwStyle;

		public IntPtr lpszIcon;

		public IntPtr dwContextHelpId;

		public MsgBoxCallback lpfnMsgBoxCallback;

		public uint dwLanguageId;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public struct LOGFONT
	{
		private const int LF_FACESIZE = 32;

		public int lfHeight;

		public int lfWidth;

		public int lfEscapement;

		public int lfOrientation;

		public int lfWeight;

		public byte lfItalic;

		public byte lfUnderline;

		public byte lfStrikeOut;

		public byte lfCharSet;

		public byte lfOutPrecision;

		public byte lfClipPrecision;

		public byte lfQuality;

		public byte lfPitchAndFamily;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string lfFaceName;

		public LOGFONT(string faceName)
		{
			lfFaceName = faceName;
			lfWeight = 0;
			lfOrientation = 0;
			lfEscapement = 0;
			lfWidth = 0;
			lfHeight = 0;
			lfOutPrecision = 0;
			lfCharSet = 0;
			lfStrikeOut = 0;
			lfUnderline = 0;
			lfItalic = 0;
			lfPitchAndFamily = 0;
			lfQuality = 0;
			lfClipPrecision = 0;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public struct NONCLIENTMETRICS
	{
		public int cbSize;

		public int iBorderWidth;

		public int iScrollWidth;

		public int iScrollHeight;

		public int iCaptionWidth;

		public int iCaptionHeight;

		public LOGFONT lfCaptionFont;

		public int iSMCaptionWidth;

		public int iSMCaptionHeight;

		public LOGFONT lfSMCaptionFont;

		public int iMenuWidth;

		public int iMenuHeight;

		public LOGFONT lfMenuFont;

		public LOGFONT lfStatusFont;

		public LOGFONT lfMessageFont;

		public NONCLIENTMETRICS(LOGFONT logFont)
		{
			iCaptionHeight = 0;
			iCaptionWidth = 0;
			iScrollHeight = 0;
			iScrollWidth = 0;
			iBorderWidth = 0;
			cbSize = 0;
			iMenuHeight = 0;
			iMenuWidth = 0;
			iSMCaptionHeight = 0;
			iSMCaptionWidth = 0;
			lfCaptionFont = (lfSMCaptionFont = (lfMenuFont = (lfStatusFont = (lfMessageFont = logFont))));
		}
	}

	private const string SHELL32_DLL = "shell32.dll";

	private const string GDI32_DLL = "gdi32.dll";

	private const string USER32_DLL = "user32.dll";

	private const string KERNEL32_DLL = "kernel32.dll";

	private const string UXTHEME_DLL = "uxtheme.dll";

	private const string MPR_DLL = "mpr.dll";

	public static string User32DLLPath => Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\user32.dll";

	public static string SystemWindowsDirectory
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260);
			GetSystemWindowsDirectory(stringBuilder, 260);
			if (!stringBuilder.ToString().EndsWith("\\"))
			{
				stringBuilder.Append("\\");
			}
			return stringBuilder.ToString();
		}
	}

	private Win32()
	{
	}

	[DllImport("user32.dll")]
	public static extern int LockWindowUpdate(int hWnd);

	[DllImport("user32.dll")]
	public static extern IntPtr GetActiveWindow();

	[DllImport("user32.dll")]
	public static extern bool WinHelp(IntPtr hWndMain, string lpszHelp, uint uCommand, uint dwData);

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

	[DllImport("user32.dll")]
	public static extern int PostMessage(IntPtr handle, int msg, int wParam, int lParam);

	[DllImport("user32.dll")]
	public static extern uint RegisterWindowMessage(string lpString);

	[DllImport("gdi32.dll")]
	public static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

	[DllImport("shell32.dll")]
	public static extern IntPtr ExtractAssociatedIconEx(IntPtr hInst, string lpIconPath, ref IntPtr lpiIconIndex, out IntPtr lpiIconId);

	[DllImport("user32", CharSet = CharSet.Auto)]
	public static extern int SystemParametersInfo(int uiAction, int uiParam, ref NONCLIENTMETRICS pvParam, int fWinIni);

	[DllImport("user32.dll")]
	public static extern int MessageBoxIndirect(ref MSGBOXPARAMS msgboxParams);

	[DllImport("KERNEL32.DLL", CharSet = CharSet.Ansi)]
	public static extern int GetPrivateProfileSectionNamesA(byte[] lpszReturnBuffer, int nSize, string lpFileName);

	public static string[] GetPrivateProfileSectionNames(string lpFileName)
	{
		try
		{
			byte[] array = new byte[32768];
			GetPrivateProfileSectionNamesA(array, 32768, lpFileName);
			string @string = Encoding.ASCII.GetString(array);
			char[] trimChars = new char[1];
			string text = @string.Trim(trimChars);
			char[] separator = new char[1];
			return text.Split(separator);
		}
		catch
		{
		}
		return null;
	}

	[DllImport("kernel32.dll")]
	public static extern int GetPrivateProfileStringA(string lpApplicationName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);

	[DllImport("kernel32.dll")]
	public static extern int WritePrivateProfileStringA(string lpApplicationName, string lpKeyName, string lpString, string lpFileName);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, ExactSpelling = true)]
	public static extern int SetWindowLongA(IntPtr hWnd, WindowLongAttribute nIndex, int nNewValue);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, ExactSpelling = true)]
	public static extern int GetWindowLongA(IntPtr hWnd, WindowLongAttribute nIndex);

	[DllImport("user32.dll")]
	public static extern int GetWindowRect(IntPtr hWnd, ref RECT lpRect);

	[DllImport("user32.dll")]
	public static extern int GetWindowPlacement(IntPtr hWnd, ref WINDOWPLACEMENT lpWindowPlacement);

	[DllImport("user32.dll")]
	public static extern bool IsIconic(IntPtr handle);

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr hWnd, ShowCommand nCmdShow);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern int ChangeClipboardChain(IntPtr handle, IntPtr hClipboardViewerNext);

	public static short GetLowWord(int Value)
	{
		byte[] bytes = BitConverter.GetBytes(Value);
		if (BitConverter.IsLittleEndian)
		{
			return BitConverter.ToInt16(bytes, 0);
		}
		if (bytes.Length <= 2)
		{
			return 0;
		}
		return BitConverter.ToInt16(bytes, 2);
	}

	public static short GetHighWord(int Value)
	{
		byte[] bytes = BitConverter.GetBytes(Value);
		if (BitConverter.IsLittleEndian)
		{
			if (bytes.Length <= 2)
			{
				return 0;
			}
			return BitConverter.ToInt16(bytes, 2);
		}
		return BitConverter.ToInt16(bytes, 0);
	}

	[DllImport("mpr.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int WNetGetConnection([MarshalAs(UnmanagedType.LPTStr)] string localName, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder remoteName, ref int length);

	public static string GetUniversalNameFromDriveLetter(char driveletter)
	{
		int length = 260;
		StringBuilder stringBuilder = new StringBuilder(260);
		string localName = "" + driveletter + ':';
		if (WNetGetConnection(localName, stringBuilder, ref length) == 0)
		{
			return stringBuilder.ToString();
		}
		return string.Empty;
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern uint GetLongPathName(string lpszShortPath, [Out] StringBuilder lpszLongPath, uint cchBuffer);

	public static string GetLongPathName(string shortName)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		uint capacity = (uint)stringBuilder.Capacity;
		GetLongPathName(shortName, stringBuilder, capacity);
		return stringBuilder.ToString();
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	private static extern int GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string lpszLongPath, [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszShortPath, uint cchBuffer);

	public static string GetShortPathName(string longName)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		uint capacity = (uint)stringBuilder.Capacity;
		GetShortPathName(longName, stringBuilder, capacity);
		return stringBuilder.ToString();
	}

	[DllImport("uxtheme.dll", ExactSpelling = true)]
	public static extern int DrawThemeBackground(IntPtr hTheme, IntPtr hdc, int iPartId, int iStateId, ref RECT pRect, IntPtr pClipRect);

	[DllImport("uxtheme.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
	public static extern IntPtr OpenThemeData(IntPtr hWnd, string classList);

	[DllImport("user32.dll")]
	private static extern IntPtr GetWindowDC(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern IntPtr LoadBitmap(IntPtr hInstance, int resourceID);

	[DllImport("gdi32.dll")]
	public static extern bool DeleteObject(IntPtr hObject);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern int GetSystemWindowsDirectory(StringBuilder sb, int length);
}
