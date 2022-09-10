using System;
using System.Runtime.InteropServices;

namespace Vestris.ResourceLib;

public abstract class User32
{
	internal struct ICONINFO
	{
		public bool IsIcon;

		public int xHotspot;

		public int yHotspot;

		public IntPtr MaskBitmap;

		public IntPtr ColorBitmap;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct DIALOGTEMPLATE
	{
		public uint style;

		public uint dwExtendedStyle;

		public ushort cdit;

		public short x;

		public short y;

		public short cx;

		public short cy;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct DIALOGITEMTEMPLATE
	{
		public uint style;

		public uint dwExtendedStyle;

		public short x;

		public short y;

		public short cx;

		public short cy;

		public short id;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct DIALOGEXTEMPLATE
	{
		public ushort dlgVer;

		public ushort signature;

		public uint helpID;

		public uint exStyle;

		public uint style;

		public ushort cDlgItems;

		public short x;

		public short y;

		public short cx;

		public short cy;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct DIALOGEXITEMTEMPLATE
	{
		public uint helpID;

		public uint exStyle;

		public uint style;

		public short x;

		public short y;

		public short cx;

		public short cy;

		public int id;
	}

	public enum WindowStyles : uint
	{
		WS_OVERLAPPED = 0u,
		WS_POPUP = 2147483648u,
		WS_CHILD = 1073741824u,
		WS_MINIMIZE = 536870912u,
		WS_VISIBLE = 268435456u,
		WS_DISABLED = 134217728u,
		WS_CLIPSIBLINGS = 67108864u,
		WS_CLIPCHILDREN = 33554432u,
		WS_MAXIMIZE = 16777216u,
		WS_CAPTION = 12582912u,
		WS_BORDER = 8388608u,
		WS_DLGFRAME = 4194304u,
		WS_VSCROLL = 2097152u,
		WS_HSCROLL = 1048576u,
		WS_SYSMENU = 524288u,
		WS_THICKFRAME = 262144u,
		WS_GROUP = 131072u,
		WS_TABSTOP = 65536u
	}

	public enum DialogStyles : uint
	{
		DS_ABSALIGN = 1u,
		DS_SYSMODAL = 2u,
		DS_LOCALEDIT = 32u,
		DS_SETFONT = 64u,
		DS_MODALFRAME = 128u,
		DS_NOIDLEMSG = 256u,
		DS_SETFOREGROUND = 512u,
		DS_3DLOOK = 4u,
		DS_FIXEDSYS = 8u,
		DS_NOFAILCREATE = 16u,
		DS_CONTROL = 1024u,
		DS_CENTER = 2048u,
		DS_CENTERMOUSE = 4096u,
		DS_CONTEXTHELP = 8192u,
		DS_SHELLFONT = 72u,
		DS_USEPIXELS = 32768u
	}

	public enum ExtendedDialogStyles : uint
	{
		WS_EX_DLGMODALFRAME = 1u,
		WS_EX_NOPARENTNOTIFY = 4u,
		WS_EX_TOPMOST = 8u,
		WS_EX_ACCEPTFILES = 16u,
		WS_EX_TRANSPARENT = 32u,
		WS_EX_MDICHILD = 64u,
		WS_EX_TOOLWINDOW = 128u,
		WS_EX_WINDOWEDGE = 256u,
		WS_EX_CLIENTEDGE = 512u,
		WS_EX_CONTEXTHELP = 1024u,
		WS_EX_RIGHT = 4096u,
		WS_EX_LEFT = 0u,
		WS_EX_RTLREADING = 8192u,
		WS_EX_LTRREADING = 0u,
		WS_EX_LEFTSCROLLBAR = 16384u,
		WS_EX_RIGHTSCROLLBAR = 0u,
		WS_EX_CONTROLPARENT = 65536u,
		WS_EX_STATICEDGE = 131072u,
		WS_EX_APPWINDOW = 262144u,
		WS_EX_OVERLAPPEDWINDOW = 768u,
		WS_EX_PALETTEWINDOW = 392u,
		WS_EX_LAYERED = 524288u,
		WS_EX_NOINHERITLAYOUT = 1048576u,
		WS_EX_LAYOUTRTL = 4194304u,
		WS_EX_COMPOSITED = 33554432u,
		WS_EX_NOACTIVATE = 134217728u
	}

	public enum DialogItemClass : uint
	{
		Button = 128u,
		Edit,
		Static,
		ListBox,
		ScrollBar,
		ComboBox
	}

	public enum StaticControlStyles : uint
	{
		SS_LEFT = 0u,
		SS_CENTER = 1u,
		SS_RIGHT = 2u,
		SS_ICON = 3u,
		SS_BLACKRECT = 4u,
		SS_GRAYRECT = 5u,
		SS_WHITERECT = 6u,
		SS_BLACKFRAME = 7u,
		SS_GRAYFRAME = 8u,
		SS_WHITEFRAME = 9u,
		SS_USERITEM = 10u,
		SS_SIMPLE = 11u,
		SS_LEFTNOWORDWRAP = 12u,
		SS_OWNERDRAW = 13u,
		SS_BITMAP = 14u,
		SS_ENHMETAFILE = 15u,
		SS_ETCHEDHORZ = 16u,
		SS_ETCHEDVERT = 17u,
		SS_ETCHEDFRAME = 18u,
		SS_TYPEMASK = 31u,
		SS_REALSIZECONTROL = 64u,
		SS_NOPREFIX = 128u,
		SS_NOTIFY = 256u,
		SS_CENTERIMAGE = 512u,
		SS_RIGHTJUST = 1024u,
		SS_REALSIZEIMAGE = 2048u,
		SS_SUNKEN = 4096u,
		SS_EDITCONTROL = 8192u,
		SS_ENDELLIPSIS = 16384u,
		SS_PATHELLIPSIS = 32768u,
		SS_WORDELLIPSIS = 49152u,
		SS_ELLIPSISMASK = 49152u
	}

	public enum ButtonControlStyles : uint
	{
		BS_PUSHBUTTON = 0u,
		BS_DEFPUSHBUTTON = 1u,
		BS_CHECKBOX = 2u,
		BS_AUTOCHECKBOX = 3u,
		BS_RADIOBUTTON = 4u,
		BS_3STATE = 5u,
		BS_AUTO3STATE = 6u,
		BS_GROUPBOX = 7u,
		BS_USERBUTTON = 8u,
		BS_AUTORADIOBUTTON = 9u,
		BS_PUSHBOX = 10u,
		BS_OWNERDRAW = 11u,
		BS_TYPEMASK = 15u,
		BS_LEFTTEXT = 32u,
		BS_TEXT = 0u,
		BS_ICON = 64u,
		BS_BITMAP = 128u,
		BS_LEFT = 256u,
		BS_RIGHT = 512u,
		BS_CENTER = 768u,
		BS_TOP = 1024u,
		BS_BOTTOM = 2048u,
		BS_VCENTER = 3072u,
		BS_PUSHLIKE = 4096u,
		BS_MULTILINE = 8192u,
		BS_NOTIFY = 16384u,
		BS_FLAT = 32768u,
		BS_DEFSPLITBUTTON = 13u,
		BS_COMMANDLINK = 14u,
		BS_DEFCOMMANDLINK = 15u
	}

	public enum EditControlStyles : uint
	{
		ES_LEFT = 0u,
		ES_CENTER = 1u,
		ES_RIGHT = 2u,
		ES_MULTILINE = 4u,
		ES_UPPERCASE = 8u,
		ES_LOWERCASE = 0x10u,
		ES_PASSWORD = 0x20u,
		ES_AUTOVSCROLL = 0x40u,
		ES_AUTOHSCROLL = 0x80u,
		ES_NOHIDESEL = 0x100u,
		ES_OEMCONVERT = 0x400u,
		ES_READONLY = 0x800u,
		ES_WANTRETURN = 0x1000u,
		ES_NUMBER = 0x2000u
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	internal struct MENUTEMPLATE
	{
		public ushort wVersion;

		public ushort wOffset;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct MENUITEMTEMPLATE
	{
		public ushort mtOption;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct MENUEXTEMPLATE
	{
		public ushort wVersion;

		public ushort wOffset;

		public uint dwHelpId;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct MENUEXITEMTEMPLATE
	{
		public uint dwType;

		public uint dwState;

		public uint dwMenuId;

		public ushort dwOptions;
	}

	public enum MenuFlags : uint
	{
		MF_INSERT = 0u,
		MF_CHANGE = 128u,
		MF_APPEND = 256u,
		MF_DELETE = 512u,
		MF_REMOVE = 4096u,
		MF_BYCOMMAND = 0u,
		MF_BYPOSITION = 1024u,
		MF_SEPARATOR = 2048u,
		MF_ENABLED = 0u,
		MF_GRAYED = 1u,
		MF_DISABLED = 2u,
		MF_UNCHECKED = 0u,
		MF_CHECKED = 8u,
		MF_USECHECKBITMAPS = 512u,
		MF_STRING = 0u,
		MF_BITMAP = 4u,
		MF_OWNERDRAW = 256u,
		MF_POPUP = 16u,
		MF_MENUBARBREAK = 32u,
		MF_MENUBREAK = 64u,
		MF_UNHILITE = 0u,
		MF_HILITE = 128u,
		MF_DEFAULT = 4096u,
		MF_SYSMENU = 8192u,
		MF_HELP = 16384u,
		MF_RIGHTJUSTIFY = 16384u,
		MF_MOUSESELECT = 32768u,
		MF_END = 128u,
		MFT_STRING = 0u,
		MFT_BITMAP = 4u,
		MFT_MENUBARBREAK = 32u,
		MFT_MENUBREAK = 64u,
		MFT_OWNERDRAW = 256u,
		MFT_RADIOCHECK = 512u,
		MFT_SEPARATOR = 2048u,
		MFT_RIGHTORDER = 8192u,
		MFT_RIGHTJUSTIFY = 16384u,
		MFS_GRAYED = 3u,
		MFS_DISABLED = 3u,
		MFS_CHECKED = 8u,
		MFS_HILITE = 128u,
		MFS_ENABLED = 0u,
		MFS_UNCHECKED = 0u,
		MFS_UNHILITE = 0u,
		MFS_DEFAULT = 4096u
	}

	public enum MenuResourceType
	{
		Last = 128,
		Sub = 1
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct ACCEL
	{
		public ushort fVirt;

		public ushort key;

		public uint cmd;
	}

	public enum AcceleratorVirtualKey : uint
	{
		VIRTKEY = 1u,
		NOINVERT = 2u,
		SHIFT = 4u,
		CONTROL = 8u,
		ALT = 0x10u
	}

	public enum VirtualKeys : uint
	{
		VK_LBUTTON = 1u,
		VK_RBUTTON = 2u,
		VK_CANCEL = 3u,
		VK_MBUTTON = 4u,
		VK_XBUTTON1 = 5u,
		VK_XBUTTON2 = 6u,
		VK_BACK = 8u,
		VK_TAB = 9u,
		VK_CLEAR = 12u,
		VK_RETURN = 13u,
		VK_SHIFT = 16u,
		VK_CONTROL = 17u,
		VK_MENU = 18u,
		VK_PAUSE = 19u,
		VK_CAPITAL = 20u,
		VK_KANA = 21u,
		VK_JUNJA = 23u,
		VK_FINAL = 24u,
		VK_KANJI = 25u,
		VK_ESCAPE = 27u,
		VK_CONVERT = 28u,
		VK_NONCONVERT = 29u,
		VK_ACCEPT = 30u,
		VK_MODECHANGE = 31u,
		VK_SPACE = 32u,
		VK_PRIOR = 33u,
		VK_NEXT = 34u,
		VK_END = 35u,
		VK_HOME = 36u,
		VK_LEFT = 37u,
		VK_UP = 38u,
		VK_RIGHT = 39u,
		VK_DOWN = 40u,
		VK_SELECT = 41u,
		VK_PRINT = 42u,
		VK_EXECUTE = 43u,
		VK_SNAPSHOT = 44u,
		VK_INSERT = 45u,
		VK_DELETE = 46u,
		VK_HELP = 47u,
		VK_LWIN = 91u,
		VK_RWIN = 92u,
		VK_APPS = 93u,
		VK_SLEEP = 95u,
		VK_NUMPAD0 = 96u,
		VK_NUMPAD1 = 97u,
		VK_NUMPAD2 = 98u,
		VK_NUMPAD3 = 99u,
		VK_NUMPAD4 = 100u,
		VK_NUMPAD5 = 101u,
		VK_NUMPAD6 = 102u,
		VK_NUMPAD7 = 103u,
		VK_NUMPAD8 = 104u,
		VK_NUMPAD9 = 105u,
		VK_MULTIPLY = 106u,
		VK_ADD = 107u,
		VK_SEPARATOR = 108u,
		VK_SUBTRACT = 109u,
		VK_DECIMAL = 110u,
		VK_DIVIDE = 111u,
		VK_F1 = 112u,
		VK_F2 = 113u,
		VK_F3 = 114u,
		VK_F4 = 115u,
		VK_F5 = 116u,
		VK_F6 = 117u,
		VK_F7 = 118u,
		VK_F8 = 119u,
		VK_F9 = 120u,
		VK_F10 = 121u,
		VK_F11 = 122u,
		VK_F12 = 123u,
		VK_F13 = 124u,
		VK_F14 = 125u,
		VK_F15 = 126u,
		VK_F16 = 127u,
		VK_F17 = 128u,
		VK_F18 = 129u,
		VK_F19 = 130u,
		VK_F20 = 131u,
		VK_F21 = 132u,
		VK_F22 = 133u,
		VK_F23 = 134u,
		VK_F24 = 135u,
		VK_NUMLOCK = 144u,
		VK_SCROLL = 145u,
		VK_OEM_NEC_EQUAL = 146u,
		VK_OEM_FJ_JISHO = 146u,
		VK_OEM_FJ_MASSHOU = 147u,
		VK_OEM_FJ_TOUROKU = 148u,
		VK_OEM_FJ_LOYA = 149u,
		VK_OEM_FJ_ROYA = 150u,
		VK_LSHIFT = 160u,
		VK_RSHIFT = 161u,
		VK_LCONTROL = 162u,
		VK_RCONTROL = 163u,
		VK_LMENU = 164u,
		VK_RMENU = 165u,
		VK_BROWSER_BACK = 166u,
		VK_BROWSER_FORWARD = 167u,
		VK_BROWSER_REFRESH = 168u,
		VK_BROWSER_STOP = 169u,
		VK_BROWSER_SEARCH = 170u,
		VK_BROWSER_FAVORITES = 171u,
		VK_BROWSER_HOME = 172u,
		VK_VOLUME_MUTE = 173u,
		VK_VOLUME_DOWN = 174u,
		VK_VOLUME_UP = 175u,
		VK_MEDIA_NEXT_TRACK = 176u,
		VK_MEDIA_PREV_TRACK = 177u,
		VK_MEDIA_STOP = 178u,
		VK_MEDIA_PLAY_PAUSE = 179u,
		VK_LAUNCH_MAIL = 180u,
		VK_LAUNCH_MEDIA_SELECT = 181u,
		VK_LAUNCH_APP1 = 182u,
		VK_LAUNCH_APP2 = 183u,
		VK_OEM_1 = 186u,
		VK_OEM_PLUS = 187u,
		VK_OEM_COMMA = 188u,
		VK_OEM_MINUS = 189u,
		VK_OEM_PERIOD = 190u,
		VK_OEM_2 = 191u,
		VK_OEM_3 = 192u,
		VK_OEM_4 = 219u,
		VK_OEM_5 = 220u,
		VK_OEM_6 = 221u,
		VK_OEM_7 = 222u,
		VK_OEM_8 = 223u,
		VK_OEM_AX = 225u,
		VK_OEM_102 = 226u,
		VK_ICO_HELP = 227u,
		VK_ICO_00 = 228u,
		VK_PROCESSKEY = 229u,
		VK_ICO_CLEAR = 230u,
		VK_PACKET = 231u,
		VK_OEM_RESET = 233u,
		VK_OEM_JUMP = 234u,
		VK_OEM_PA1 = 235u,
		VK_OEM_PA2 = 236u,
		VK_OEM_PA3 = 237u,
		VK_OEM_WSCTRL = 238u,
		VK_OEM_CUSEL = 239u,
		VK_OEM_ATTN = 240u,
		VK_OEM_FINISH = 241u,
		VK_OEM_COPY = 242u,
		VK_OEM_AUTO = 243u,
		VK_OEM_ENLW = 244u,
		VK_OEM_BACKTAB = 245u,
		VK_ATTN = 246u,
		VK_CRSEL = 247u,
		VK_EXSEL = 248u,
		VK_EREOF = 249u,
		VK_PLAY = 250u,
		VK_ZOOM = 251u,
		VK_NONAME = 252u,
		VK_PA1 = 253u,
		VK_OEM_CLEAR = 254u
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct FONTDIRENTRY
	{
		public ushort dfVersion;

		public uint dfSize;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 60)]
		public string dfCopyright;

		public ushort dfType;

		public ushort dfPoints;

		public ushort dfVertRes;

		public ushort dfHorizRes;

		public ushort dfAscent;

		public ushort dfInternalLeading;

		public ushort dfExternalLeading;

		public byte dfItalic;

		public byte dfUnderline;

		public byte dfStrikeOut;

		public ushort dfWeight;

		public byte dfCharSet;

		public ushort dfPixWidth;

		public ushort dfPixHeight;

		public byte dfPitchAndFamily;

		public ushort dfAvgWidth;

		public ushort dfMaxWidth;

		public byte dfFirstChar;

		public byte dfLastChar;

		public byte dfDefaultChar;

		public byte dfBreakChar;

		public ushort dfWidthBytes;

		public uint dfDevice;

		public uint dfFace;

		public uint dfReserved;
	}

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern IntPtr GetDC(IntPtr hWnd);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDC);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern int DestroyIcon(IntPtr hIcon);

	[DllImport("user32,dll", SetLastError = true)]
	internal static extern IntPtr CreateIconIndirect(ref ICONINFO piconInfo);
}
