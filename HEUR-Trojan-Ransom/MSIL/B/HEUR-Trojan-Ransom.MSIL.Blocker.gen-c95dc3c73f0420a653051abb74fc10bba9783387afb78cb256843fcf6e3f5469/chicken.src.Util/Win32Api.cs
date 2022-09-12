using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace chicken.src.Util;

public class Win32Api
{
	[Flags]
	public enum AllocationType
	{
		Commit = 0x1000,
		Reserve = 0x2000,
		Decommit = 0x4000,
		Release = 0x8000,
		Reset = 0x80000,
		Physical = 0x400000,
		TopDown = 0x100000,
		WriteWatch = 0x200000,
		LargePages = 0x20000000
	}

	[Flags]
	public enum MemoryProtection
	{
		Execute = 0x10,
		ExecuteRead = 0x20,
		ExecuteReadWrite = 0x40,
		ExecuteWriteCopy = 0x80,
		NoAccess = 1,
		ReadOnly = 2,
		ReadWrite = 4,
		WriteCopy = 8,
		GuardModifierflag = 0x100,
		NoCacheModifierflag = 0x200,
		WriteCombineModifierflag = 0x400
	}

	[Flags]
	public enum ProcessAccessFlags : uint
	{
		All = 0x1F0FFFu,
		Terminate = 1u,
		CreateThread = 2u,
		VirtualMemoryOperation = 8u,
		VirtualMemoryRead = 0x10u,
		VirtualMemoryWrite = 0x20u,
		DuplicateHandle = 0x40u,
		CreateProcess = 0x80u,
		SetQuota = 0x100u,
		SetInformation = 0x200u,
		QueryInformation = 0x400u,
		QueryLimitedInformation = 0x1000u,
		Synchronize = 0x100000u
	}

	public struct Startupinfo
	{
		public uint Cb;

		public string LpReserved;

		public string LpDesktop;

		public string LpTitle;

		public uint DwX;

		public uint DwY;

		public uint DwXSize;

		public uint DwYSize;

		public uint DwXCountChars;

		public uint DwYCountChars;

		public uint DwFillAttribute;

		public uint DwFlags;

		public short WShowWindow;

		public short CbReserved2;

		public IntPtr LpReserved2;

		public IntPtr HStdInput;

		public IntPtr HStdOutput;

		public IntPtr HStdError;
	}

	public struct ProcessInformation
	{
		public IntPtr HProcess;

		public IntPtr HThread;

		public uint DwProcessId;

		public uint DwThreadId;
	}

	[Flags]
	public enum ProcessCreationFlags : uint
	{
		CreateDefaultErrorMode = 0x4000000u,
		CreateSuspended = 4u,
		CREATE_SHARED_WOW_VDM = 0x1000u,
		CREATE_SEPARATE_WOW_VDM = 0x800u,
		CREATE_SECURE_PROCESS = 0x400000u,
		CREATE_PRESERVE_CODE_AUTHZ_LEVEL = 0x2000000u
	}

	public struct DevMode
	{
		private const int lhjrinXmoxVCSpfXdoyTiLuktFyt = 32;

		private const int UDiiAeJxUUmOKgvRqNQagnzIzhid = 32;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string dmDeviceName;

		public short dmSpecVersion;

		public short dmDriverVersion;

		public short dmSize;

		public short dmDriverExtra;

		public int dmFields;

		public int dmPositionX;

		public int dmPositionY;

		public ScreenOrientation dmDisplayOrientation;

		public int dmDisplayFixedOutput;

		public short dmColor;

		public short dmDuplex;

		public short dmYResolution;

		public short dmTTOption;

		public short dmCollate;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string dmFormName;

		public short dmLogPixels;

		public int dmBitsPerPel;

		public int dmPelsWidth;

		public int dmPelsHeight;

		public int dmDisplayFlags;

		public int dmDisplayFrequency;

		public int dmICMMethod;

		public int dmICMIntent;

		public int dmMediaType;

		public int dmDitherType;

		public int dmReserved1;

		public int dmReserved2;

		public int dmPanningWidth;

		public int dmPanningHeight;
	}

	[Flags]
	public enum WindowLongFlags
	{
		WsClipsiblings = 0x4000000,
		WsClipchildren = 0x2000000,
		WsVisible = 0x10000000,
		WsDisabled = 0x8000000,
		WsMinimize = 0x20000000,
		WsMaximize = 0x1000000,
		WsCaption = 0xC00000,
		WsBorder = 0x800000,
		WsDlgframe = 0x400000,
		WsVscroll = 0x200000,
		WsHscroll = 0x100000,
		WsSysmenu = 0x80000,
		WsThickframe = 0x40000,
		WsMinimizebox = 0x20000,
		WsMaximizebox = 0x10000,
		GwlStyle = -16
	}

	[Flags]
	public enum MenuFlags
	{
		MfRemove = 0x1000,
		MfByposition = 0x400
	}

	[Flags]
	public enum RedrawWindowFlags : uint
	{
		Invalidate = 1u,
		InternalPaint = 2u,
		Erase = 4u,
		Validate = 8u,
		NoInternalPaint = 0x10u,
		NoErase = 0x20u,
		NoChildren = 0x40u,
		AllChildren = 0x80u,
		UpdateNow = 0x100u,
		EraseNow = 0x200u,
		Frame = 0x400u,
		NoFrame = 0x800u
	}

	public const int HSHELL_WINDOWCREATED = 1;

	public static byte[] DefaultKey2 = new byte[32]
	{
		97, 98, 99, 100, 101, 102, 103, 104, 102, 98,
		99, 101, 101, 103, 103, 97, 103, 98, 99, 103,
		101, 104, 103, 98, 104, 98, 99, 104, 101, 105,
		103, 99
	};

	public static byte[] DefaultIV2 = new byte[16]
	{
		48, 49, 50, 51, 52, 53, 54, 55, 53, 52,
		50, 51, 52, 50, 54, 49
	};

	public static byte[] DefaultKey = new byte[32]
	{
		97, 98, 99, 100, 101, 102, 103, 104, 97, 98,
		99, 100, 101, 102, 103, 104, 97, 98, 99, 100,
		101, 102, 103, 104, 97, 98, 99, 100, 101, 102,
		103, 104
	};

	public static byte[] DefaultIV = new byte[16]
	{
		48, 49, 50, 51, 52, 53, 54, 55, 48, 49,
		50, 51, 52, 53, 54, 55
	};

	public static byte[] key = new byte[32]
	{
		97, 98, 99, 100, 101, 102, 103, 104, 97, 98,
		99, 100, 101, 102, 103, 104, 97, 98, 99, 100,
		101, 102, 103, 104, 97, 98, 99, 100, 101, 102,
		103, 104
	};

	public static byte[] iv2 = new byte[16];

	public static byte[] key2 = new byte[16];

	public static byte[] iv = new byte[16];

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int CloseHandle(IntPtr hObject);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	[DllImport("kernel32.dll")]
	public static extern bool WriteProcessMemory(IntPtr hProcess, int lpBaseAddress, byte[] lpBuffer, int nSize, int lpNumberOfBytesWritten);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesWritten);

	[DllImport("kernel32.dll")]
	public static extern bool WriteProcessMemory(IntPtr hProcess, int lpBaseAddress, ref byte lpBuffer, int nSize, int lpNumberOfBytesWritten);

	[DllImport("kernel32.dll")]
	public static extern bool WriteProcessMemory(IntPtr hProcess, int lpBaseAddress, ref short lpBuffer, int nSize, int lpNumberOfBytesWritten);

	[DllImport("kernel32.dll")]
	public static extern bool WriteProcessMemory(IntPtr hProcess, int lpBaseAddress, ref int lpBuffer, int nSize, int lpNumberOfBytesWritten);

	[DllImport("kernel32.dll")]
	public static extern bool WriteProcessMemory(IntPtr hProcess, int lpBaseAddress, ref long lpBuffer, int nSize, int lpNumberOfBytesWritten);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

	[DllImport("kernel32.dll")]
	public static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, ProcessCreationFlags dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref Startupinfo lpStartupInfo, out ProcessInformation lpProcessInformation);

	[DllImport("kernel32.dll")]
	public static extern uint ResumeThread(IntPtr hThread);

	[DllImport("kernel32.dll")]
	public static extern uint SuspendThread(IntPtr hThread);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, int lpNumberOfBytesRead);

	[DllImport("user32.dll")]
	public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

	[DllImport("user32.dll")]
	public static extern int GetWindowLong(IntPtr hWnd, int nIndex);

	[DllImport("user32.dll")]
	public static extern IntPtr GetMenu(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern int GetMenuItemCount(IntPtr hMenu);

	[DllImport("user32.dll")]
	public static extern bool DrawMenuBar(IntPtr hWnd);

	[DllImport("user32.dll")]
	public static extern bool RemoveMenu(IntPtr hMenu, uint uPosition, uint uFlags);

	[DllImport("user32.dll")]
	public static extern bool EnumDisplaySettings(string lpszDeviceName, int iModeNum, ref DevMode lpDevMode);

	[DllImport("user32.dll")]
	public static extern int ChangeDisplaySettings([In][Out] ref DevMode lpDevMode, [MarshalAs(UnmanagedType.U4)] uint dwflags);

	[DllImport("user32.dll")]
	public static extern bool RedrawWindow(IntPtr hWnd, IntPtr lprcUpdate, IntPtr hrgnUpdate, RedrawWindowFlags flags);

	[DllImport("user32.dll")]
	public static extern bool InvalidateRect(IntPtr hWnd, IntPtr lpRect, bool bErase);

	[DllImport("user32.dll")]
	public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	[DllImport("Gdi32.dll")]
	public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
}
