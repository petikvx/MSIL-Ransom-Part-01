using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

internal static class Desktop
{
	public struct POINTAPI
	{
		public int x;

		public int y;
	}

	public struct RECTAPI
	{
		public int left;

		public int top;

		public int right;

		public int bottom;
	}

	private struct LVITEM
	{
		public int mask;

		public int iItem;

		public int iSubItem;

		public int state;

		public int stateMask;

		public IntPtr pszText;

		public int cchTextMax;

		public int iImage;

		public int lParam;

		public int iIndent;
	}

	public enum DesktopWindow
	{
		ProgMan,
		SHELLDLL_DefViewParent,
		SHELLDLL_DefView,
		SysListView32
	}

	public delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

	private const int STANDARD_RIGHTS_REQUIRED = 983040;

	private const int SECTION_QUERY = 1;

	private const int SECTION_MAP_WRITE = 2;

	private const int SECTION_MAP_READ = 4;

	private const int SECTION_MAP_EXECUTE = 8;

	private const int SECTION_EXTEND_SIZE = 16;

	private const int SECTION_ALL_ACCESS = 983071;

	private const int PROCESS_VM_OPERATION = 8;

	private const int PROCESS_VM_READ = 16;

	private const int PROCESS_VM_WRITE = 32;

	public const int MEM_COMMIT = 4096;

	private const int MEM_RESERVE = 8192;

	public const int MEM_RELEASE = 32768;

	public const int PAGE_READWRITE = 4;

	private const int GWL_STYLE = -16;

	private const int LVS_AUTOARRANGE = 256;

	private const int LVM_FIRST = 4096;

	private const int LVM_GETITEMCOUNT = 4100;

	private const int LVM_GETITEMRECT = 4110;

	public const int LVM_SETITEMPOSITION = 4111;

	private const int LVM_GETITEMPOSITION = 4112;

	private const int WM_COMMAND = 273;

	public const int LVM_GETEXTENDEDLISTVIEWSTYLE = 4151;

	public const int LVM_SETEXTENDEDLISTVIEWSTYLE = 4150;

	public const int LVS_EX_SNAPTOGRID = 524288;

	private const int IDM_TOGGLEAUTOARRANGE = 28737;

	public static RECTAPI[] m_OriginalPoint;

	public static POINTAPI[] m_OriginalPos;

	private static bool m_AutoArrange;

	public static bool m_Message;

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr OpenProcess(int dwDesiredAccess, int bInheritHandle, int dwProcessId);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr VirtualAllocEx(IntPtr hProcess, int lpAddress, int dwSize, int flAllocationType, int flProtect);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, int dwFreeType);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int CloseHandle(IntPtr hObject);

	public static IntPtr GetMemSharedNT(int pid, int memSize, ref IntPtr hProcess)
	{
		hProcess = OpenProcess(56, 0, pid);
		return VirtualAllocEx(hProcess, 0, memSize, 12288, 4);
	}

	public static void FreeMemSharedNT(IntPtr hProcess, IntPtr MemAddress, int memSize)
	{
		VirtualFreeEx(hProcess, MemAddress, memSize, 32768);
		CloseHandle(hProcess);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr FindWindowA(string lpClassName, string lpWindowName);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr FindWindowExA(IntPtr hWndParent, int hWndChildAfter, string lpClassName, string lpWindowName);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, ref int lpdwProcessId);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowLongA(IntPtr hWnd, int nIndex);

	[DllImport("Shell32.dll")]
	public static extern int SHChangeNotify(int eventId, int flags, IntPtr item1, IntPtr item2);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, ref RECTAPI lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, ref RECTAPI lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, ref POINTAPI lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, ref POINTAPI lpBuffer, int nSize, ref int lpNumberOfBytesWritten);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetParent(IntPtr hWnd);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int SendMessageA(IntPtr hWnd, int wMsg, int wParam, int lParam);

	[DllImport("user32", CharSet = CharSet.Ansi, EntryPoint = "SendMessageA", ExactSpelling = true, SetLastError = true)]
	public static extern int SendMessageA_1(IntPtr hWnd, int wMsg, int wParam, IntPtr lParam);

	public static bool SaveDesktop()
	{
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		int lpdwProcessId = 0;
		IntPtr hProcess = default(IntPtr);
		IntPtr intPtr = default(IntPtr);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		int lpNumberOfBytesWritten = 0;
		int lpNumberOfBytesWritten2 = 0;
		IntPtr intPtr2 = default(IntPtr);
		intPtr2 = GetSysLVHwnd();
		if (intPtr2.Equals((object?)(nint)IntPtr.Zero))
		{
			return false;
		}
		if ((GetWindowLongA(intPtr2, -16) & 0x100) == 256)
		{
			m_AutoArrange = true;
			SendMessageA(GetParent(intPtr2), 273, 28737, 0);
		}
		num3 = SendMessageA(intPtr2, 4100, 0, 0);
		if (num3 == 0)
		{
			return false;
		}
		m_OriginalPoint = new RECTAPI[num3];
		m_OriginalPos = new POINTAPI[num3];
		num = Marshal.SizeOf((object)m_OriginalPoint[0]);
		num2 = Marshal.SizeOf((object)m_OriginalPos[0]);
		GetWindowThreadProcessId(intPtr2, ref lpdwProcessId);
		intPtr = GetMemSharedNT(lpdwProcessId, num, ref hProcess);
		WriteProcessMemory(hProcess, intPtr, ref m_OriginalPoint[0], num, ref lpNumberOfBytesWritten);
		string text = "";
		for (int i = 0; i < num3; i++)
		{
			m_OriginalPoint[i].left = 0;
			SendMessageA_1(intPtr2, 4110, i, intPtr);
			ReadProcessMemory(hProcess, intPtr, ref m_OriginalPoint[i], num, ref lpNumberOfBytesWritten2);
			text = text + i + ": " + m_OriginalPoint[i].left + "~" + m_OriginalPoint[i].right + " , " + m_OriginalPoint[i].top + "~" + m_OriginalPoint[i].bottom + "\n";
		}
		FreeMemSharedNT(hProcess, intPtr, num);
		intPtr = GetMemSharedNT(lpdwProcessId, num2, ref hProcess);
		WriteProcessMemory(hProcess, intPtr, ref m_OriginalPos[0], num2, ref lpNumberOfBytesWritten);
		for (int j = 0; j < num3; j++)
		{
			SendMessageA_1(intPtr2, 4112, j, intPtr);
			ReadProcessMemory(hProcess, intPtr, ref m_OriginalPos[j], num2, ref lpNumberOfBytesWritten2);
		}
		FreeMemSharedNT(hProcess, intPtr, num2);
		if (m_Message)
		{
			MessageBox.Show(text);
		}
		return true;
	}

	[DllImport("user32.dll")]
	private static extern IntPtr GetShellWindow();

	[DllImport("user32.dll")]
	public static extern bool EnumWindows(EnumWindowsProc enumProc, IntPtr lParam);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

	public static IntPtr GetDesktopWindow(DesktopWindow desktopWindow)
	{
		IntPtr _SHELLDLL_DefViewParent;
		IntPtr intPtr = (_SHELLDLL_DefViewParent = GetShellWindow());
		IntPtr _SHELLDLL_DefView = FindWindowExA(intPtr, 0, "SHELLDLL_DefView", null);
		IntPtr _SysListView32 = FindWindowExA(_SHELLDLL_DefView, 0, "SysListView32", "FolderView");
		if (_SHELLDLL_DefView == IntPtr.Zero)
		{
			EnumWindows(delegate(IntPtr hwnd, IntPtr lParam)
			{
				StringBuilder stringBuilder = new StringBuilder(256);
				if (GetClassName(hwnd, stringBuilder, 256) > 0)
				{
					string text = stringBuilder.ToString();
					if (text == "Progman" || text == "WorkerW")
					{
						IntPtr intPtr2 = FindWindowExA(hwnd, 0, "SHELLDLL_DefView", null);
						if (intPtr2 != IntPtr.Zero)
						{
							_SHELLDLL_DefViewParent = hwnd;
							_SHELLDLL_DefView = intPtr2;
							_SysListView32 = FindWindowExA(intPtr2, 0, "SysListView32", "FolderView");
							return false;
						}
					}
				}
				return true;
			}, IntPtr.Zero);
		}
		return desktopWindow switch
		{
			DesktopWindow.ProgMan => intPtr, 
			DesktopWindow.SHELLDLL_DefViewParent => _SHELLDLL_DefViewParent, 
			DesktopWindow.SHELLDLL_DefView => _SHELLDLL_DefView, 
			DesktopWindow.SysListView32 => _SysListView32, 
			_ => IntPtr.Zero, 
		};
	}

	public static IntPtr GetSysLVHwnd()
	{
		return GetDesktopWindow(DesktopWindow.SysListView32);
	}
}
