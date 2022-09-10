using System;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;

namespace eRecoveryService;

public class WIN32
{
	public delegate int WIMMessageCallback(int msgId, IntPtr param1, IntPtr param2, IntPtr unused);

	public enum Bool
	{
		False,
		True
	}

	public enum SERVICE_TYPES
	{
		SERVICE_KERNEL_DRIVER = 1,
		SERVICE_FILE_SYSTEM_DRIVER = 2,
		SERVICE_WIN32_OWN_PROCESS = 0x10,
		SERVICE_WIN32_SHARE_PROCESS = 0x20,
		SERVICE_INTERACTIVE_PROCESS = 0x100
	}

	public enum SERVICE_STATE
	{
		SERVICE_STOPPED = 1,
		SERVICE_START_PENDING,
		SERVICE_STOP_PENDING,
		SERVICE_RUNNING,
		SERVICE_CONTINUE_PENDING,
		SERVICE_PAUSE_PENDING,
		SERVICE_PAUSED
	}

	public enum WIMMSGENUM
	{
		WIM_MSG = 38006,
		WIM_MSG_TEXT,
		WIM_MSG_PROGRESS,
		WIM_MSG_PROCESS,
		WIM_MSG_SCANNING,
		WIM_MSG_SETRANGE,
		WIM_MSG_SETPOS,
		WIM_MSG_STEPIT,
		WIM_MSG_COMPRESS,
		WIM_MSG_ERROR,
		WIM_MSG_ALIGNMENT,
		WIM_MSG_RETRY,
		WIM_MSG_SPLIT,
		WIM_MSG_FILEINFO,
		WIM_MSG_INFO,
		WIM_MSG_WARNING,
		WIM_MSG_CHK_PROCESS
	}

	public enum FILEOP_FLAGS_ENUM : ushort
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

	public enum FO_Func : uint
	{
		FO_MOVE = 1u,
		FO_COPY,
		FO_DELETE,
		FO_RENAME
	}

	public enum SECURITY_IMPERSONATION_LEVEL
	{
		SecurityAnonymous,
		SecurityIdentification,
		SecurityImpersonation,
		SecurityDelegation
	}

	public enum TOKEN_TYPE
	{
		TokenPrimary = 1,
		TokenImpersonation
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct SERVICE_STATUS
	{
		public SERVICE_TYPES ServiceType;

		public SERVICE_STATE CurrentState;

		public int ControlsAccepted;

		public int Win32ExitCode;

		public int ServicesSpecificExitCode;

		public int CheckPoint;

		public int WaitHint;
	}

	public struct GUID
	{
		public int a;

		public short b;

		public short c;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] d;
	}

	[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Auto, Size = 560)]
	public struct WIM_INFO
	{
		[FieldOffset(0)]
		public string WimPath;

		[FieldOffset(520)]
		public GUID Guid;

		[FieldOffset(536)]
		public int ImageCount;

		[FieldOffset(540)]
		public int CompressionType;

		[FieldOffset(544)]
		public byte PartNumber;

		[FieldOffset(546)]
		public byte TotalParts;

		[FieldOffset(548)]
		public int BootIndex;

		[FieldOffset(552)]
		public int WimAttributes;

		[FieldOffset(556)]
		public int WimFlagsAndAttr;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct SHFILEOPSTRUCT
	{
		public IntPtr hwnd;

		public FO_Func wFunc;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string pFrom;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string pTo;

		public ushort fFlags;

		public bool fAnyOperationsAborted;

		public IntPtr hNameMappings;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string lpszProgressTitle;
	}

	public struct PROCESS_INFORMATION
	{
		public IntPtr hProcess;

		public IntPtr hThread;

		public uint dwProcessId;

		public uint dwThreadId;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct STARTUPINFO
	{
		public int cb;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string lpReserved;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string lpDesktop;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string lpTitle;

		public int dwX;

		public int dwY;

		public int dwXSize;

		public int dwYSize;

		public int dwXCountChars;

		public int dwYCountChars;

		public int dwFillAttribute;

		public int dwFlags;

		public short wShowWindow;

		public short cbReserved2;

		public IntPtr lpReserved2;

		public IntPtr hStdInput;

		public IntPtr hStdOutput;

		public IntPtr hStdError;
	}

	public struct WTSProcessInfo
	{
		internal uint SessionId;

		internal uint ProcessId;

		[MarshalAs(UnmanagedType.LPTStr)]
		internal string pProcessName;

		internal IntPtr pUserSid;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	public struct WIN32_FIND_DATA
	{
		public uint dwFileAttributes;

		public FILETIME ftCreationTime;

		public FILETIME ftLastAccessTime;

		public FILETIME ftLastWriteTime;

		public uint nFileSizeHigh;

		public uint nFileSizeLow;

		public uint dwReserved0;

		public uint dwReserved1;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string cFileName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
		public string cAlternateFileName;
	}

	public struct SECURITY_ATTRIBUTES
	{
		public int nLength;

		public IntPtr lpSecurityDescriptor;

		public int bInheritHandle;
	}

	public const int NO_ERROR = 0;

	public const string g_szC_AutorunIni = "C:\\Acer\\Empowering Technology\\eRecovery\\Autorun.ini";

	public const string g_szC_AutorunFolder = "C:\\Acer\\Empowering Technology\\eRecovery\\Autorun";

	public const string HIDDEN_PATH = "\\Device\\Harddisk0\\Partition1";

	public const string g_szH_AutorunExe = "\\imagex.exe\" /apply";

	public const string g_sz_CompressFileSrc = "\\autorun\\swcd.wim";

	public const string g_sz_ExtractDestFolder = "C:\\Acer\\Empowering Technology\\eRecovery";

	public const int ERROR_NO_MORE_ITEMS = 259;

	public const uint TOKEN_DUPLICATE = 2u;

	public const uint TOKEN_QUERY = 8u;

	public const uint TOKEN_ASSIGN_PRIMARY = 1u;

	public const uint CREATE_NEW_CONSOLE = 16u;

	public const uint BELOW_NORMAL_PRIORITY_CLASS = 16384u;

	public const uint NORMAL_PRIORITY_CLASS = 32u;

	public const uint FILE_ATTRIBUTE_DIRECTORY = 16u;

	public static readonly IntPtr WTC_CURRENT_SERVER_HANDLE = IntPtr.Zero;

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool SetServiceStatus(IntPtr hServiceStatus, ref SERVICE_STATUS lpServiceStatus);

	[DllImport("wimgapi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern uint WIMRegisterMessageCallback(IntPtr hwim, WIMMessageCallback fpMessageProc, IntPtr lpvUserData);

	[DllImport("wimgapi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr WIMCreateFile(string lpszWimPath, uint dwDesiredAccess, int dwCreationDisposition, int dwFlagsAndAttributes, int dwCompressionType, int lpdwCreationResult);

	[DllImport("wimgapi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool WIMGetAttributes(IntPtr hWim, ref WIM_INFO lpWimInfo, int cbWimInfo);

	[DllImport("wimgapi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool WIMSetTemporaryPath(IntPtr hWim, string lpszPath);

	[DllImport("wimgapi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr WIMLoadImage(IntPtr hwim, int dwImageIndex);

	[DllImport("wimgapi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool WIMApplyImage(IntPtr hImage, string lpszPath, int dwApplyFlags);

	[DllImport("wimgapi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool WIMCloseHandle(IntPtr hObject);

	[DllImport("wimgapi.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	public static extern bool WIMUnregisterMessageCallback(IntPtr hwim, WIMMessageCallback fpMessageProc);

	[DllImport("kernel32.dll")]
	public static extern void SetLastError(uint dwErrCode);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern bool FindNextFile(IntPtr hFindFile, out WIN32_FIND_DATA lpFindFileData);

	[DllImport("kernel32.dll")]
	public static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes, ref SECURITY_ATTRIBUTES lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, [In] ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

	[DllImport("shell32.dll", CharSet = CharSet.Unicode)]
	public static extern int SHFileOperation([In] ref SHFILEOPSTRUCT lpFileOp);

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool CreateProcessAsUser(IntPtr hToken, string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool ImpersonateLoggedOnUser(IntPtr hToken);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool DuplicateTokenEx(IntPtr hExistingToken, uint dwDesiredAccess, IntPtr lpTokenAttributes, SECURITY_IMPERSONATION_LEVEL ImpersonationLevel, TOKEN_TYPE TokenType, out IntPtr phNewToken);

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);

	[DllImport("wtsapi32", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern void WTSFreeMemory(IntPtr pMemory);

	[DllImport("wtsapi32", CharSet = CharSet.Auto, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern bool WTSEnumerateProcesses(IntPtr ProcessHandle, int Reserved, uint Version, ref IntPtr ppProcessInfo, ref uint pCount);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr hSnapshot);

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool RevertToSelf();

	[DllImport("kernel32.dll")]
	public static extern uint WTSGetActiveConsoleSessionId();

	[DllImport("advapi32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool LookupAccountSid(string lpSystemName, IntPtr pSid, StringBuilder Account, ref int cbName, StringBuilder DomainName, ref int cbDomainName, ref int peUse);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr FindFirstFile(string lpFileName, out WIN32_FIND_DATA lpFindFileData);

	[DllImport("kernel32.dll")]
	public static extern bool FindClose(IntPtr hFindFile);

	[DllImport("kernel32.dll")]
	public static extern int GetPrivateProfileSectionNamesA(byte[] lpszReturnBuffer, int nSize, string lpFileName);

	[DllImport("kernel32.dll")]
	public static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, uint nSize, string lpFileName);

	[DllImport("kernel32.dll")]
	public static extern bool WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);

	[DllImport("SysHook.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern void InstallLaunchEv();

	[DllImport("SysHook.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern void UninstallLaunchEv();

	[DllImport("kernel32.dll")]
	public static extern uint GetLogicalDrives();

	[DllImport("kernel32.dll")]
	public static extern bool DefineDosDevice(uint dwFlags, string lpDeviceName, string lpTargetPath);

	[DllImport("kernel32.dll")]
	public static extern void GetStartupInfoW(out STARTUPINFO lpStartupInfo);
}
