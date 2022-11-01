using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Media;
using Microsoft.Win32;
using NAudio.CoreAudioApi;
using Shell32;

namespace com.poweriwb.PowerDesk;

internal class CNativeWIN32
{
	public enum VolumeLevel
	{
		OFF = 0,
		LOW = 858993459,
		NORMAL = 1717986918,
		MEDIUM = -1717986919,
		HIGH = -858993460,
		VERY_HIGH = -1
	}

	public enum RecycleFlag : uint
	{
		SHERB_NOCONFIRMATION = 1u,
		SHERB_NOPROGRESSUI = 2u,
		SHERB_NOSOUND = 4u
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct SHQUERYRBINFO
	{
		public int cbSize;

		public long i64Size;

		public long i64NumItems;
	}

	public struct Rectangle32
	{
		public int Left { get; set; }

		public int Top { get; set; }

		public int Right { get; set; }

		public int Bottom { get; set; }
	}

	public struct COPYDATASTRUCT
	{
		public IntPtr dwData;

		public int cbData;

		[MarshalAs(UnmanagedType.LPStr)]
		public string lpData;
	}

	public enum SpecialWindowHandles
	{
		HWND_TOP = 0,
		HWND_BOTTOM = 1,
		HWND_TOPMOST = -1,
		HWND_NOTOPMOST = -2
	}

	public enum Keys
	{
		Backspace = 8,
		Tab = 9,
		Clear = 12,
		Enter = 13,
		Shift = 16,
		Control = 17,
		Alt = 18,
		Pause = 19,
		CapsLock = 20,
		Escape = 27,
		Space = 32,
		PageUp = 33,
		PageDown = 34,
		End = 35,
		Home = 36,
		Left = 37,
		Up = 38,
		Right = 39,
		Down = 40,
		Select = 41,
		Print = 42,
		Execute = 43,
		PrintScreen = 44,
		Insert = 45,
		Delete = 46,
		Help = 47,
		Zero = 48,
		One = 49,
		Two = 50,
		Three = 51,
		Four = 52,
		Five = 53,
		Six = 54,
		Seven = 55,
		Eight = 56,
		Nine = 57,
		A = 65,
		B = 66,
		C = 67,
		D = 68,
		E = 69,
		F = 70,
		G = 71,
		H = 72,
		I = 73,
		J = 74,
		K = 75,
		L = 76,
		M = 77,
		N = 78,
		O = 79,
		P = 80,
		Q = 81,
		R = 82,
		S = 83,
		T = 84,
		U = 85,
		V = 86,
		W = 87,
		X = 88,
		Y = 89,
		Z = 90,
		LeftWindowsKey = 91,
		RightWindowsKey = 92,
		ApplicationsKey = 93,
		Sleep = 95,
		NumPad0 = 96,
		NumPad1 = 97,
		NumPad2 = 98,
		NumPad3 = 99,
		NumPad4 = 100,
		NumPad5 = 101,
		NumPad6 = 102,
		NumPad7 = 103,
		NumPad8 = 104,
		NumPad9 = 105,
		Multiply = 106,
		Add = 107,
		Seperator = 108,
		Subtract = 109,
		Decimal = 110,
		Divide = 111,
		F1 = 112,
		F2 = 113,
		F3 = 114,
		F4 = 115,
		F5 = 116,
		F6 = 117,
		F7 = 118,
		F8 = 119,
		F9 = 120,
		F10 = 121,
		F11 = 122,
		F12 = 123,
		F13 = 124,
		F14 = 125,
		F15 = 126,
		F16 = 127,
		F17 = 128,
		F18 = 129,
		F19 = 130,
		F20 = 131,
		F21 = 132,
		F22 = 133,
		F23 = 134,
		F24 = 135,
		Numlock = 144,
		ScrollLock = 145,
		LeftShift = 160,
		RightShift = 161,
		LeftControl = 162,
		RightContol = 163,
		LeftMenu = 164,
		RightMenu = 165,
		BrowserBack = 166,
		BrowserForward = 167,
		BrowserRefresh = 168,
		BrowserStop = 169,
		BrowserSearch = 170,
		BrowserFavorites = 171,
		BrowserHome = 172,
		VolumeMute = 173,
		VolumeDown = 174,
		VolumeUp = 175,
		NextTrack = 176,
		PreviousTrack = 177,
		StopMedia = 178,
		PlayPause = 179,
		LaunchMail = 180,
		SelectMedia = 181,
		LaunchApp1 = 182,
		LaunchApp2 = 183,
		OEM1 = 186,
		OEMPlus = 184,
		OEMComma = 188,
		OEMMinus = 189,
		OEMPeriod = 190,
		OEM2 = 191,
		OEM3 = 192,
		OEM4 = 219,
		OEM5 = 220,
		OEM6 = 221,
		OEM7 = 222,
		OEM8 = 223,
		OEM102 = 226,
		Process = 229,
		Packet = 231,
		Attn = 246,
		CrSel = 247,
		ExSel = 248,
		EraseEOF = 249,
		Play = 250,
		Zoom = 251,
		PA1 = 253,
		OEMClear = 254
	}

	[Flags]
	public enum SetWindowPosFlags : uint
	{
		SWP_ASYNCWINDOWPOS = 0x4000u,
		SWP_DEFERERASE = 0x2000u,
		SWP_DRAWFRAME = 0x20u,
		SWP_FRAMECHANGED = 0x20u,
		SWP_HIDEWINDOW = 0x80u,
		SWP_NOACTIVATE = 0x10u,
		SWP_NOCOPYBITS = 0x100u,
		SWP_NOMOVE = 2u,
		SWP_NOOWNERZORDER = 0x200u,
		SWP_NOREDRAW = 8u,
		SWP_NOREPOSITION = 0x200u,
		SWP_NOSENDCHANGING = 0x400u,
		SWP_NOSIZE = 1u,
		SWP_NOZORDER = 4u,
		SWP_SHOWWINDOW = 0x40u
	}

	[Flags]
	public enum MouseFlags : uint
	{
		MOUSEMOVE = 1u,
		LBUTTONDOWN = 2u,
		LBUTTONUP = 4u,
		ABSOLUTEMOVE = 0x8000u
	}

	private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

	public enum GetWindow_Cmd : uint
	{
		GW_HWNDFIRST,
		GW_HWNDLAST,
		GW_HWNDNEXT,
		GW_HWNDPREV,
		GW_OWNER,
		GW_CHILD,
		GW_ENABLEDPOPUP
	}

	public struct PROCESS_INFORMATION
	{
		public IntPtr hProcess { get; set; }

		public IntPtr hThread { get; set; }

		public uint dwProcessId { get; set; }

		public uint dwThreadId { get; set; }
	}

	public struct STARTUPINFO
	{
		public uint cb { get; set; }

		public string lpReserved { get; set; }

		public string lpDesktop { get; set; }

		public string lpTitle { get; set; }

		public uint dwX { get; set; }

		public uint dwY { get; set; }

		public uint dwXSize { get; set; }

		public uint dwYSize { get; set; }

		public uint dwXCountChars { get; set; }

		public uint dwYCountChars { get; set; }

		public uint dwFillAttribute { get; set; }

		public uint dwFlags { get; set; }

		public short wShowWindow { get; set; }

		public short cbReserved2 { get; set; }

		public IntPtr lpReserved2 { get; set; }

		public IntPtr hStdInput { get; set; }

		public IntPtr hStdOutput { get; set; }

		public IntPtr hStdError { get; set; }
	}

	public struct SECURITY_ATTRIBUTES
	{
		public int length { get; set; }

		public IntPtr lpSecurityDescriptor { get; set; }

		public bool bInheritHandle { get; set; }
	}

	[Flags]
	internal enum ProcessCreationFlags : uint
	{
		ZERO_FLAG = 0u,
		CREATE_BREAKAWAY_FROM_JOB = 0x1000000u,
		CREATE_DEFAULT_ERROR_MODE = 0x4000000u,
		CREATE_NEW_CONSOLE = 0x10u,
		CREATE_NEW_PROCESS_GROUP = 0x200u,
		CREATE_NO_WINDOW = 0x8000000u,
		CREATE_PROTECTED_PROCESS = 0x40000u,
		CREATE_PRESERVE_CODE_AUTHZ_LEVEL = 0x2000000u,
		CREATE_SEPARATE_WOW_VDM = 0x1000u,
		CREATE_SHARED_WOW_VDM = 0x1000u,
		CREATE_SUSPENDED = 4u,
		CREATE_UNICODE_ENVIRONMENT = 0x400u,
		DEBUG_ONLY_THIS_PROCESS = 2u,
		DEBUG_PROCESS = 1u,
		DETACHED_PROCESS = 8u,
		EXTENDED_STARTUPINFO_PRESENT = 0x80000u,
		INHERIT_PARENT_AFFINITY = 0x10000u
	}

	public struct IconInfo
	{
		public bool fIcon { get; set; }

		public int xHotspot { get; set; }

		public int yHotspot { get; set; }

		public IntPtr hbmMask { get; set; }

		public IntPtr hbmColor { get; set; }
	}

	public enum WM_Message
	{
		WM_NULL = 0,
		WM_CREATE = 1,
		WM_DESTROY = 2,
		WM_MOVE = 3,
		WM_SIZE = 5,
		WM_ACTIVATE = 6,
		WM_SETFOCUS = 7,
		WM_KILLFOCUS = 8,
		WM_ENABLE = 10,
		WM_SETREDRAW = 11,
		WM_SETTEXT = 12,
		WM_GETTEXT = 13,
		WM_GETTEXTLENGTH = 14,
		WM_PAINT = 15,
		WM_CLOSE = 16,
		WM_QUERYENDSESSION = 17,
		WM_QUERYOPEN = 19,
		WM_ENDSESSION = 22,
		WM_QUIT = 18,
		WM_ERASEBKGND = 20,
		WM_SYSCOLORCHANGE = 21,
		WM_SHOWWINDOW = 24,
		WM_WININICHANGE = 26,
		WM_DEVMODECHANGE = 27,
		WM_ACTIVATEAPP = 28,
		WM_FONTCHANGE = 29,
		WM_TIMECHANGE = 30,
		WM_CANCELMODE = 31,
		WM_SETCURSOR = 32,
		WM_MOUSEACTIVATE = 33,
		WM_CHILDACTIVATE = 34,
		WM_QUEUESYNC = 35,
		WM_GETMINMAXINFO = 36,
		WM_PAINTICON = 38,
		WM_ICONERASEBKGND = 39,
		WM_NEXTDLGCTL = 40,
		WM_SPOOLERSTATUS = 42,
		WM_DRAWITEM = 43,
		WM_MEASUREITEM = 44,
		WM_DELETEITEM = 45,
		WM_VKEYTOITEM = 46,
		WM_CHARTOITEM = 47,
		WM_SETFONT = 48,
		WM_GETFONT = 49,
		WM_SETHOTKEY = 50,
		WM_GETHOTKEY = 51,
		WM_QUERYDRAGICON = 55,
		WM_COMPAREITEM = 57,
		WM_GETOBJECT = 61,
		WM_COMPACTING = 65,
		WM_COMMNOTIFY = 68,
		WM_WINDOWPOSCHANGING = 70,
		WM_WINDOWPOSCHANGED = 71,
		WM_POWER = 72,
		WM_COPYDATA = 74,
		WM_CANCELJOURNAL = 75,
		WM_NOTIFY = 78,
		WM_INPUTLANGCHANGEREQUEST = 80,
		WM_INPUTLANGCHANGE = 81,
		WM_TCARD = 82,
		WM_HELP = 83,
		WM_USERCHANGED = 84,
		WM_NOTIFYFORMAT = 85,
		WM_CONTEXTMENU = 123,
		WM_STYLECHANGING = 124,
		WM_STYLECHANGED = 125,
		WM_DISPLAYCHANGE = 126,
		WM_GETICON = 127,
		WM_SETICON = 128,
		WM_NCCREATE = 129,
		WM_NCDESTROY = 130,
		WM_NCCALCSIZE = 131,
		WM_NCHITTEST = 132,
		WM_NCPAINT = 133,
		WM_NCACTIVATE = 134,
		WM_GETDLGCODE = 135,
		WM_SYNCPAINT = 136,
		WM_NCMOUSEMOVE = 160,
		WM_NCLBUTTONDOWN = 161,
		WM_NCLBUTTONUP = 162,
		WM_NCLBUTTONDBLCLK = 163,
		WM_NCRBUTTONDOWN = 164,
		WM_NCRBUTTONUP = 165,
		WM_NCRBUTTONDBLCLK = 166,
		WM_NCMBUTTONDOWN = 167,
		WM_NCMBUTTONUP = 168,
		WM_NCMBUTTONDBLCLK = 169,
		WM_NCXBUTTONDOWN = 171,
		WM_NCXBUTTONUP = 172,
		WM_NCXBUTTONDBLCLK = 173,
		WM_INPUT = 255,
		WM_KEYFIRST = 256,
		WM_KEYDOWN = 256,
		WM_KEYUP = 257,
		WM_CHAR = 258,
		WM_DEADCHAR = 259,
		WM_SYSKEYDOWN = 260,
		WM_SYSKEYUP = 261,
		WM_SYSCHAR = 262,
		WM_SYSDEADCHAR = 263,
		WM_UNICHAR = 265,
		WM_KEYLAST = 265,
		WM_KEYLASTBefore0x0501 = 264,
		WM_IME_STARTCOMPOSITION = 269,
		WM_IME_ENDCOMPOSITION = 270,
		WM_IME_COMPOSITION = 271,
		WM_IME_KEYLAST = 271,
		WM_INITDIALOG = 272,
		WM_COMMAND = 273,
		WM_SYSCOMMAND = 274,
		WM_TIMER = 275,
		WM_HSCROLL = 276,
		WM_VSCROLL = 277,
		WM_INITMENU = 278,
		WM_INITMENUPOPUP = 279,
		WM_MENUSELECT = 287,
		WM_MENUCHAR = 288,
		WM_ENTERIDLE = 289,
		WM_MENURBUTTONUP = 290,
		WM_MENUDRAG = 291,
		WM_MENUGETOBJECT = 292,
		WM_UNINITMENUPOPUP = 293,
		WM_MENUCOMMAND = 294,
		WM_CHANGEUISTATE = 295,
		WM_UPDATEUISTATE = 296,
		WM_QUERYUISTATE = 297,
		WM_CTLCOLORMSGBOX = 306,
		WM_CTLCOLOREDIT = 307,
		WM_CTLCOLORLISTBOX = 308,
		WM_CTLCOLORBTN = 309,
		WM_CTLCOLORDLG = 310,
		WM_CTLCOLORSCROLLBAR = 311,
		WM_CTLCOLORSTATIC = 312,
		WM_MOUSEFIRST = 512,
		WM_MOUSEMOVE = 512,
		WM_LBUTTONDOWN = 513,
		WM_LBUTTONUP = 514,
		WM_LBUTTONDBLCLK = 515,
		WM_RBUTTONDOWN = 516,
		WM_RBUTTONUP = 517,
		WM_RBUTTONDBLCLK = 518,
		WM_MBUTTONDOWN = 519,
		WM_MBUTTONUP = 520,
		WM_MBUTTONDBLCLK = 521,
		WM_MOUSEWHEEL = 522,
		WM_XBUTTONDOWN = 523,
		WM_XBUTTONUP = 524,
		WM_XBUTTONDBLCLK = 525,
		WM_MOUSELAST = 525,
		WM_MOUSELASTBefore0x0500 = 522,
		WM_MOUSELASTBefore0x0400 = 521,
		WM_PARENTNOTIFY = 528,
		WM_ENTERMENULOOP = 529,
		WM_EXITMENULOOP = 530,
		WM_NEXTMENU = 531,
		WM_SIZING = 532,
		WM_CAPTURECHANGED = 533,
		WM_MOVING = 534,
		WM_POWERBROADCAST = 536,
		WM_DEVICECHANGE = 537,
		WM_MDICREATE = 544,
		WM_MDIDESTROY = 545,
		WM_MDIACTIVATE = 546,
		WM_MDIRESTORE = 547,
		WM_MDINEXT = 548,
		WM_MDIMAXIMIZE = 549,
		WM_MDITILE = 550,
		WM_MDICASCADE = 551,
		WM_MDIICONARRANGE = 552,
		WM_MDIGETACTIVE = 553,
		WM_MDISETMENU = 560,
		WM_ENTERSIZEMOVE = 561,
		WM_EXITSIZEMOVE = 562,
		WM_DROPFILES = 563,
		WM_MDIREFRESHMENU = 564,
		WM_IME_SETCONTEXT = 641,
		WM_IME_NOTIFY = 642,
		WM_IME_CONTROL = 643,
		WM_IME_COMPOSITIONFULL = 644,
		WM_IME_SELECT = 645,
		WM_IME_CHAR = 646,
		WM_IME_REQUEST = 648,
		WM_IME_KEYDOWN = 656,
		WM_IME_KEYUP = 657,
		WM_MOUSEHOVER = 673,
		WM_MOUSELEAVE = 675,
		WM_NCMOUSEHOVER = 672,
		WM_NCMOUSELEAVE = 674,
		WM_WTSSESSION_CHANGE = 689,
		WM_TABLET_FIRST = 704,
		WM_TABLET_LAST = 735,
		WM_CUT = 768,
		WM_COPY = 769,
		WM_PASTE = 770,
		WM_CLEAR = 771,
		WM_UNDO = 772,
		WM_RENDERFORMAT = 773,
		WM_RENDERALLFORMATS = 774,
		WM_DESTROYCLIPBOARD = 775,
		WM_DRAWCLIPBOARD = 776,
		WM_PAINTCLIPBOARD = 777,
		WM_VSCROLLCLIPBOARD = 778,
		WM_SIZECLIPBOARD = 779,
		WM_ASKCBFORMATNAME = 780,
		WM_CHANGECBCHAIN = 781,
		WM_HSCROLLCLIPBOARD = 782,
		WM_QUERYNEWPALETTE = 783,
		WM_PALETTEISCHANGING = 784,
		WM_PALETTECHANGED = 785,
		WM_HOTKEY = 786,
		WM_PRINT = 791,
		WM_PRINTCLIENT = 792,
		WM_APPCOMMAND = 793,
		WM_THEMECHANGED = 794,
		WM_HANDHELDFIRST = 856,
		WM_HANDHELDLAST = 863,
		WM_AFXFIRST = 864,
		WM_AFXLAST = 895,
		WM_PENWINFIRST = 896,
		WM_PENWINLAST = 911,
		WM_APP = 32768,
		WM_USER = 1024,
		WM_HELP_Before0x0400 = 12
	}

	public enum SW
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
		SW_MAX = 10,
		SW_FORCEMINIMIZE = 11
	}

	public delegate bool EnumWindowProc(IntPtr hWnd, IntPtr parameter);

	public enum AppBarMessages
	{
		New,
		Remove,
		QueryPos,
		SetPos,
		GetState,
		GetTaskBarPos,
		Activate,
		GetAutoHideBar,
		SetAutoHideBar,
		WindowPosChanged,
		SetState
	}

	public struct APPBARDATA
	{
		public uint cbSize;

		public IntPtr hWnd;

		public uint uCallbackMessage;

		public uint uEdge;

		public Rectangle32 rc;

		public int lParam;
	}

	public enum AppBarStates
	{
		AutoHide = 1,
		AlwaysOnTop
	}

	private struct GESTURECONFIG
	{
		public int dwID;

		public int dwWant;

		public int dwBlock;

		public GESTURECONFIG(int dwID, int dwWant, int dwBlock)
		{
			this.dwID = dwID;
			this.dwWant = dwWant;
			this.dwBlock = dwBlock;
		}
	}

	[Flags]
	public enum FILEOP_FLAGS : ushort
	{
		FOF_MULTIDESTFILES = 1,
		FOF_CONFIRMMOUSE = 2,
		FOF_SILENT = 4,
		FOF_RENAMEONCOLLISION = 8,
		FOF_NOCONFIRMATION = 0x10,
		FOF_WANTMAPPINGHANDLE = 0x20,
		FOF_ALLOWUNDO = 0x40,
		FOF_FILESONLY = 0x80,
		FOF_SIMPLEPROGRESS = 0x100,
		FOF_NOCONFIRMMKDIR = 0x200,
		FOF_NOERRORUI = 0x400,
		FOF_NOCOPYSECURITYATTRIBS = 0x800,
		FOF_NORECURSION = 0x1000,
		FOF_NO_CONNECTED_ELEMENTS = 0x2000,
		FOF_WANTNUKEWARNING = 0x4000,
		FOF_NORECURSEREPARSE = 0x8000
	}

	public const int APPCOMMAND_VOLUME_MUTE = 524288;

	public const int APPCOMMAND_VOLUME_UP = 655360;

	public const int APPCOMMAND_VOLUME_DOWN = 589824;

	public const int WM_APPCOMMAND = 793;

	public const int INFINITE = 65535;

	public const int WM_USER = 1024;

	public const int WM_COPYDATA = 74;

	public const int WM_CLOSE = 16;

	public const int WM_SYSCOMMAND = 274;

	public const int SC_CLOSE = 61536;

	private const int GW_CHILD = 5;

	private const int GW_HWNDNEXT = 2;

	private const uint DWM_EC_DISABLECOMPOSITION = 0u;

	private const uint DWM_EC_ENABLECOMPOSITION = 1u;

	private const int WM_SETREDRAW = 11;

	public const int TABLET_DISABLE_PRESSANDHOLD = 1;

	public const int TABLET_DISABLE_PENTAPFEEDBACK = 8;

	public const int TABLET_DISABLE_PENBARRELFEEDBACK = 16;

	public const int TABLET_DISABLE_TOUCHUIFORCEON = 256;

	public const int TABLET_DISABLE_TOUCHUIFORCEOFF = 512;

	public const int TABLET_DISABLE_TOUCHSWITCH = 32768;

	public const int TABLET_DISABLE_FLICKS = 65536;

	public const int TABLET_ENABLE_FLICKSONCONTEXT = 131072;

	public const int TABLET_ENABLE_FLICKLEARNINGMODE = 262144;

	public const int TABLET_DISABLE_SMOOTHSCROLLING = 524288;

	public const int TABLET_DISABLE_FLICKFALLBACKKEYS = 1048576;

	public const int TABLET_ENABLE_MULTITOUCHDATA = 16777216;

	public const int dwHwndTabletProperty = 17891353;

	public const int dwHwndTabletProperty8 = 17235977;

	private static MMDeviceEnumerator _deviceEnumerator = null;

	private static MMDevice _playbackDevice = null;

	private static int mFakeVolumeDeviceVolume = 50;

	public static Process LastestProcess = null;

	public static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

	public static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);

	private static EnumWindowsProc EnumProcessWindowsProc = delegate(IntPtr hwnd, IntPtr lParam)
	{
		if (!IsWindowVisible(hwnd))
		{
			return true;
		}
		GetWindowThreadProcessId(hwnd, out var lpdwProcessId);
		if (lpdwProcessId == (uint)(int)lParam)
		{
			SelectedProcessWindowHandle = hwnd;
			return false;
		}
		return true;
	};

	private static IntPtr SelectedProcessWindowHandle;

	private static long level = 0L;

	private static bool? m_isWindows7 = null;

	private static bool? m_isWindows8 = null;

	private static bool? m_isWindows10 = null;

	private static bool? m_isWindows7over = null;

	private static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

	private static bool onSleepWorking = false;

	public static double getWorkingLineHeight
	{
		get
		{
			IntPtr intPtr = FindWindow("Shell_TrayWnd", "");
			if (intPtr != IntPtr.Zero)
			{
				Rectangle32 rect = default(Rectangle32);
				GetWindowRect(intPtr, ref rect);
				if (rect.Top == 0)
				{
					return 0.0;
				}
				return rect.Bottom - rect.Top - 2;
			}
			return 40.0;
		}
	}

	public static bool isWindows10
	{
		get
		{
			if (!m_isWindows10.HasValue)
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", RegistryKeyPermissionCheck.ReadSubTree);
				string text = (string)registryKey.GetValue("ProductName");
				if (text.StartsWith("Windows 10") || text.StartsWith("Windows Server 2016"))
				{
					m_isWindows10 = true;
				}
				else
				{
					m_isWindows10 = false;
				}
			}
			return m_isWindows10.Value;
		}
	}

	public bool isWindows7over => IsWindows7OverFunction();

	public string Description { get; internal set; }

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern short GetKeyState(int keyCode);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr DefWindowProc(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

	[DllImport("kernel32.dll")]
	public static extern long GetTickCount64();

	public static void SystemVolumeConfigurator()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		if (_deviceEnumerator == null)
		{
			_deviceEnumerator = new MMDeviceEnumerator();
		}
		if (_playbackDevice == null)
		{
			try
			{
				_playbackDevice = _deviceEnumerator.GetDefaultAudioEndpoint((DataFlow)0, (Role)1);
			}
			catch (Exception)
			{
			}
		}
	}

	public static int GetVolume()
	{
		SystemVolumeConfigurator();
		float num = -2f;
		num = ((_playbackDevice == null) ? ((float)mFakeVolumeDeviceVolume) : (_playbackDevice.get_AudioEndpointVolume().get_MasterVolumeLevelScalar() * 100f));
		return Convert.ToInt32(Math.Round(num));
	}

	public static void SetVolume(int volumeLevel)
	{
		SystemVolumeConfigurator();
		if (volumeLevel < 0)
		{
			volumeLevel = 0;
		}
		else if (100 < volumeLevel)
		{
			volumeLevel = 100;
		}
		if (_playbackDevice != null)
		{
			_playbackDevice.get_AudioEndpointVolume().set_MasterVolumeLevelScalar((float)volumeLevel / 100f);
		}
		else
		{
			mFakeVolumeDeviceVolume = volumeLevel;
		}
	}

	public static void SetMute(bool bMute)
	{
		try
		{
			if (_playbackDevice == null)
			{
				SystemVolumeConfigurator();
			}
			if (_playbackDevice.get_AudioEndpointVolume().get_Mute() != bMute)
			{
				_playbackDevice.get_AudioEndpointVolume().set_Mute(bMute);
			}
		}
		catch (Exception)
		{
		}
	}

	public static bool? IsMute()
	{
		bool? result = null;
		try
		{
			if (_playbackDevice == null)
			{
				SystemVolumeConfigurator();
			}
			result = _playbackDevice.get_AudioEndpointVolume().get_Mute();
			return result;
		}
		catch (Exception)
		{
		}
		return result;
	}

	[DllImport("user32.dll")]
	public static extern IntPtr SendMessageW(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("Kernel32", CharSet = CharSet.Auto)]
	public static extern bool GetComputerName(StringBuilder buffer, ref uint size);

	public static string GetComputerName()
	{
		StringBuilder stringBuilder = new StringBuilder(512);
		uint size = (uint)(stringBuilder.Capacity + 1);
		GetComputerName(stringBuilder, ref size);
		return stringBuilder.ToString().Replace("\0", string.Empty);
	}

	[DllImport("Shell32.dll")]
	public static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, uint dwFlags);

	[DllImport("shell32.dll")]
	public static extern int SHQueryRecycleBin(string pszRootPath, ref SHQUERYRBINFO pSHQueryRBInfo);

	[DllImport("user32.dll")]
	public static extern bool LockWindowUpdate(IntPtr hWndLock);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

	[DllImport("user32.dll")]
	public static extern bool GetWindowRect(IntPtr hWnd, ref Rectangle32 rect);

	[DllImport("user32.dll")]
	public static extern bool SetProp(IntPtr hWnd, string lpString, IntPtr hData);

	[DllImport("user32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern IntPtr RemoveProp(IntPtr hWnd, string lpString);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern ushort GlobalAddAtom(string lpString);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern ushort GlobalFindAtom(string lpString);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern ushort GlobalDeleteAtom(ushort atom);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool Wow64DisableWow64FsRedirection(ref IntPtr ptr);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool Wow64RevertWow64FsRedirection(IntPtr ptr);

	[DllImport("user32.dll")]
	private static extern short GetAsyncKeyState(Keys vKey);

	[DllImport("User32.dll")]
	private static extern short GetAsyncKeyState(int vKey);

	public static bool IsKeyPushedDown(Keys vKey)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected I4, but got Unknown
		return 0 != (GetAsyncKeyState((int)vKey) & 0x8000);
	}

	public static bool IsKeyPushedDown(int vKey)
	{
		return 0 != (GetAsyncKeyState(vKey) & 0x8000);
	}

	public static bool IsKeyHitDown(Keys vKey)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected I4, but got Unknown
		return 0 != GetAsyncKeyState((int)vKey);
	}

	public static bool IsKeyHitDown(int vKey)
	{
		return 0 != GetAsyncKeyState(vKey);
	}

	[DllImport("shell32.dll")]
	public static extern int ShellExecute(int hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowcmd);

	[DllImport("user32.dll")]
	public static extern int SendMessage(int hWnd, uint Msg, int wParam, int lParam);

	[DllImport("user32.dll")]
	public static extern int SendMessage(IntPtr hWnd, int wMsg, bool wParam, int lParam);

	[DllImport("User32.dll")]
	public static extern int SendMessage(int hWnd, int Msg, int wParam, ref COPYDATASTRUCT lParam);

	[DllImport("User32.dll")]
	public static extern int SendMessage(IntPtr hWnd, WM_Message wM_Message, int wParam, IntPtr lParam);

	[DllImport("user32.dll")]
	public static extern int PostMessage(int hWnd, int Msg, int wParam, int lParam);

	[DllImport("user32.dll")]
	public static extern int PostMessage(IntPtr hWnd, WM_Message wM_Message, int wParam, IntPtr lParam);

	[DllImport("User32.dll")]
	public static extern int SetParent(IntPtr hwndChild, IntPtr hwndParent);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr FindWindow(string strClassName, string strWindowName);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr hWndParent, IntPtr hWndChildAfter, string lpClassName, string lpWindowName);

	[DllImport("user32")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool RegisterTouchWindow(IntPtr hWnd, uint ulFlags);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool SetWindowText(IntPtr hwnd, string lpString);

	[DllImport("dwmapi.dll")]
	private static extern uint DwmEnableComposition(uint compositionAction);

	public static void SuspendDrawing(IntPtr hWnd)
	{
		SendMessage(hWnd, 11, wParam: false, 0);
	}

	public static void ResumeDrawing(IntPtr hWnd)
	{
		SendMessage(hWnd, 11, wParam: true, 0);
	}

	public static bool EnableComposition(bool enable)
	{
		try
		{
			if (enable)
			{
				DwmEnableComposition(1u);
			}
			else
			{
				DwmEnableComposition(0u);
			}
			return true;
		}
		catch
		{
			return false;
		}
	}

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

	public static IntPtr FindWindowByTitle(string strFirst, string strHint)
	{
		IntPtr result = IntPtr.Zero;
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		for (int i = 0; i < array.Length; i++)
		{
			string mainWindowTitle = (LastestProcess = array[i]).MainWindowTitle;
			if (strFirst == null)
			{
				if (mainWindowTitle.IndexOf(strHint) > -1)
				{
					result = FindWindow(null, mainWindowTitle);
					break;
				}
			}
			else if (mainWindowTitle.StartsWith(strFirst) && mainWindowTitle.IndexOf(strHint) > -1)
			{
				result = FindWindow(null, mainWindowTitle);
				break;
			}
		}
		return result;
	}

	public static Process FindProcess(string strProcessName)
	{
		Process result = null;
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		int num = 0;
		if (0 < array.Length)
		{
			Process process = array[num];
			result = process;
		}
		return result;
	}

	public static bool EnabledAlwaysOnTop(IntPtr hwnd)
	{
		return SetWindowPos(hwnd, HWND_TOPMOST, 0, 0, 0, 0, SetWindowPosFlags.SWP_NOMOVE | SetWindowPosFlags.SWP_NOSIZE);
	}

	public static bool DisabledAlwaysOnTop(IntPtr hwnd)
	{
		return SetWindowPos(hwnd, HWND_NOTOPMOST, 0, 0, 0, 0, SetWindowPosFlags.SWP_NOMOVE | SetWindowPosFlags.SWP_NOSIZE);
	}

	[DllImport("user32.dll")]
	public static extern void mouse_event(MouseFlags dwFlags, uint dx, uint dy, uint dwData, int dwExtraInfo);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool IsWindowVisible(IntPtr hWnd);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

	[DllImport("user32.dll")]
	public static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

	public static IntPtr WindowHandleByProcessID(IntPtr pid)
	{
		SelectedProcessWindowHandle = IntPtr.Zero;
		EnumWindows(EnumProcessWindowsProc, pid);
		if (SelectedProcessWindowHandle != IntPtr.Zero)
		{
			return SelectedProcessWindowHandle;
		}
		return SelectedProcessWindowHandle;
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetWindowTextLength(IntPtr hWnd);

	public static uint ProcIDFromWnd(IntPtr hwnd)
	{
		uint lpdwProcessId = 0u;
		GetWindowThreadProcessId(hwnd, out lpdwProcessId);
		return lpdwProcessId;
	}

	[DllImport("user32.dll")]
	public static extern int LoadCursor(int hInstance, int lpCursorName);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern IntPtr GetParent(IntPtr hWnd);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr GetWindow(IntPtr hWnd, GetWindow_Cmd uCmd);

	public static IntPtr GetWinHandle(uint pid)
	{
		return WindowHandleByProcessID((IntPtr)pid);
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	internal static extern int WaitForSingleObject(IntPtr hHandle, int dwMilliseconds);

	[DllImport("user32.dll")]
	public static extern IntPtr CreateIconIndirect(ref IconInfo icon);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);

	[DllImport("kernel32.dll")]
	public static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, ProcessCreationFlags dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr hWnd, SW nCmdShow);

	[DllImport("user32.dll")]
	public static extern void BringWindowToTop(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern void SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern IntPtr GetDesktopWindow();

	private static bool EnumWindow(IntPtr handle, IntPtr pointer)
	{
		if (!(GCHandle.FromIntPtr(pointer).Target is List<IntPtr> list))
		{
			throw new InvalidCastException("GCHandle Target could not be cast as List<IntPtr>");
		}
		list.Add(handle);
		return true;
	}

	[DllImport("user32")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool EnumChildWindows(IntPtr window, EnumWindowProc callback, IntPtr i);

	public static List<IntPtr> GetChildWindows(IntPtr parent)
	{
		List<IntPtr> list = new List<IntPtr>();
		GCHandle value = GCHandle.Alloc(list);
		try
		{
			EnumWindowProc callback = EnumWindow;
			EnumChildWindows(parent, callback, GCHandle.ToIntPtr(value));
		}
		finally
		{
			if (value.IsAllocated)
			{
				value.Free();
			}
		}
		return list;
	}

	public static IntPtr GetSystemTrayHandle()
	{
		IntPtr intPtr = FindWindow("Shell_TrayWnd", null);
		if (intPtr != IntPtr.Zero)
		{
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, "TrayNotifyWnd", null);
			if (intPtr != IntPtr.Zero)
			{
				intPtr = FindWindowEx(intPtr, IntPtr.Zero, "SysPager", null);
				if (intPtr != IntPtr.Zero)
				{
					return FindWindowEx(intPtr, IntPtr.Zero, "ToolbarWindow32", null);
				}
			}
		}
		return IntPtr.Zero;
	}

	[DllImport("shell32.dll")]
	public static extern uint SHAppBarMessage(uint dwMessage, ref APPBARDATA pData);

	public static void SetTaskbarState(AppBarStates option)
	{
		APPBARDATA pData = default(APPBARDATA);
		pData.cbSize = (uint)Marshal.SizeOf((object)pData);
		pData.hWnd = FindWindow("System_TrayWnd", null);
		pData.lParam = (int)option;
		SHAppBarMessage(10u, ref pData);
	}

	public static AppBarStates GetTaskbarState()
	{
		APPBARDATA pData = default(APPBARDATA);
		pData.cbSize = (uint)Marshal.SizeOf((object)pData);
		pData.hWnd = FindWindow("System_TrayWnd", null);
		return (AppBarStates)SHAppBarMessage(4u, ref pData);
	}

	public static IntPtr GetHwndByVisualObject(Visual obj)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return ((HwndSource)PresentationSource.FromVisual(obj)).get_Handle();
	}

	public static IntPtr FindWindowLike(long[] hWndArray, IntPtr hWndStart, string WindowText, string Classname)
	{
		int num = 0;
		if (level == 0L && hWndStart == IntPtr.Zero)
		{
			hWndStart = GetDesktopWindow();
		}
		level++;
		IntPtr window = GetWindow(hWndStart, GetWindow_Cmd.GW_CHILD);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < 255; i++)
		{
			stringBuilder.Append(" ");
		}
		while (true)
		{
			if (window != IntPtr.Zero)
			{
				FindWindowLike(hWndArray, window, WindowText, Classname);
				StringBuilder stringBuilder2 = new StringBuilder(stringBuilder.ToString());
				num = GetWindowText(window, stringBuilder2, 255);
				stringBuilder2 = new StringBuilder(stringBuilder2.ToString().Substring(0, num));
				StringBuilder stringBuilder3 = new StringBuilder(stringBuilder.ToString());
				num = GetClassName(window, stringBuilder3, 255);
				stringBuilder3 = new StringBuilder(stringBuilder3.ToString().Substring(0, num));
				if (stringBuilder2.ToString() == WindowText)
				{
					break;
				}
				window = GetWindow(window, GetWindow_Cmd.GW_HWNDNEXT);
				continue;
			}
			level--;
			return window;
		}
		level = 0L;
		return window;
	}

	public static IntPtr MakeLParam(int LoWord, int HiWord)
	{
		return (IntPtr)((HiWord << 16) | (LoWord & 0xFFFF));
	}

	public static bool IsWindows8()
	{
		if (!m_isWindows8.HasValue)
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", RegistryKeyPermissionCheck.ReadSubTree);
			string text = (string)registryKey.GetValue("ProductName");
			if (text.StartsWith("Windows 8") || text.StartsWith("Windows Server 2012"))
			{
				m_isWindows8 = true;
			}
			else
			{
				m_isWindows8 = false;
			}
		}
		return m_isWindows8.Value;
	}

	public static bool IsWindows7()
	{
		bool result = false;
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", RegistryKeyPermissionCheck.ReadSubTree);
		string text = (string)registryKey.GetValue("ProductName");
		if (text.StartsWith("Windows 7") || text.StartsWith("Windows Server (R) 2008"))
		{
			result = true;
		}
		return result;
	}

	public static bool IsWindows7OverFunction()
	{
		if (!m_isWindows7over.HasValue)
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
			string text = (string)registryKey.GetValue("ProductName");
			if (text.StartsWith("Windows 10") || text.StartsWith("Windows Server 2016"))
			{
				m_isWindows7over = true;
				m_isWindows10 = true;
			}
			else if (text.StartsWith("Windows 8") || text.StartsWith("Windows Server 2012"))
			{
				m_isWindows7over = true;
				m_isWindows10 = false;
				m_isWindows8 = true;
			}
			else if (text.StartsWith("Windows 7") || text.StartsWith("Windows Server (R) 2008"))
			{
				m_isWindows7over = false;
				m_isWindows10 = false;
				m_isWindows8 = false;
				m_isWindows7 = true;
			}
			if (!m_isWindows7over.HasValue)
			{
				OperatingSystem oSVersion = Environment.OSVersion;
				try
				{
					Version version = oSVersion.Version;
					bool flag = false;
					flag = version.Major >= 6 && version.Minor >= 1;
					m_isWindows7over = flag;
				}
				catch (Exception)
				{
					m_isWindows7over = true;
				}
			}
		}
		if (!m_isWindows7over.HasValue)
		{
			return true;
		}
		return m_isWindows7over.Value;
	}

	public static long CurrentTimeMillis()
	{
		return (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
	}

	[DllImport("user32")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetGestureConfig(IntPtr hWnd, int dwReserved, uint cIDs, [In][Out] GESTURECONFIG[] pGestureConfig, uint cbSize);

	[DllImport("winmm.dll")]
	public static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);

	public static void doZip(string dir, string zipfilename_with_fullpath)
	{
		Shell shell = (Shell)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("13709620-C279-11CE-A49E-444553540000")));
		Folder folder = shell.NameSpace(dir);
		Folder folder2 = shell.NameSpace(zipfilename_with_fullpath);
		folder2.CopyHere(folder.Items(), FILEOP_FLAGS.FOF_SILENT);
	}

	public static void UnZip(string dir, string zipfile_with_fullpath)
	{
		Shell shell = (Shell)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("13709620-C279-11CE-A49E-444553540000")));
		Folder folder = shell.NameSpace(zipfile_with_fullpath);
		Folder folder2 = shell.NameSpace(dir);
		Directory.CreateDirectory(dir);
		folder2.CopyHere(folder.Items(), FILEOP_FLAGS.FOF_SILENT);
	}

	[DllImport("user32.dll")]
	public static extern int LoadCursorFromFile(string lpFileName);

	[DllImport("user32.dll")]
	private static extern int EnableWindow(int hwnd, bool fEnable);

	[DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
	public static extern bool ClipCursor(ref Rectangle32 rcClip);

	public static void AddSiteToZoneTrust(string url)
	{
		InternetExplorerClass internetExplorerClass = new InternetExplorerClass();
		internetExplorerClass.AddSiteToZone(2u, url);
	}

	public static string FileCheckSum(string filename)
	{
		using MD5 mD = MD5.Create();
		using FileStream inputStream = File.OpenRead(filename);
		return BitConverter.ToString(mD.ComputeHash(inputStream)).Replace("-", "").ToLower();
	}

	internal static void Sleep(int miliSec)
	{
		if (onSleepWorking)
		{
			return;
		}
		try
		{
			onSleepWorking = true;
			long num = CurrentTimeMillis() + miliSec;
			do
			{
				Application.DoEvents();
				Thread.Sleep(100);
			}
			while (num > CurrentTimeMillis());
		}
		finally
		{
			onSleepWorking = false;
		}
	}

	public static void StopServiceAndDisable(string serviceName, int timeoutMilliseconds)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		ServiceController val = new ServiceController(serviceName);
		try
		{
			TimeSpan timeSpan = TimeSpan.FromMilliseconds(timeoutMilliseconds);
			val.Stop();
			val.WaitForStatus((ServiceControllerStatus)1, timeSpan);
			Registry.LocalMachine.OpenSubKey("SYSTEM\\CurrentControlSet\\Services\\" + serviceName, RegistryKeyPermissionCheck.ReadWriteSubTree)?.SetValue("Start", 4);
		}
		catch
		{
		}
	}
}
