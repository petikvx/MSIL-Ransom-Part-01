using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using ConversionBack;

namespace ManualMapInjection.Injection.Win32;

[SuppressUnmanagedCodeSecurity]
internal static class Imports
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

	[Flags]
	public enum FreeType
	{
		Decommit = 0x4000,
		Release = 0x8000
	}

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr VirtualAllocEx(IntPtr hProcess, UIntPtr lpAddress, IntPtr dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr VirtualAlloc(IntPtr lpAddress, UIntPtr dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);

	[DllImport("kernel32.dll", SetLastError = true)]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr hObject);

	[DllImport("Dbghelp.dll")]
	public static extern IntPtr ImageRvaToVa(IntPtr NtHeaders, IntPtr Base, UIntPtr Rva, [Optional] IntPtr LastRvaSection);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr GetProcessHeap();

	[DllImport("kernel32.dll")]
	public static extern IntPtr HeapAlloc(IntPtr hHeap, uint dwFlags, UIntPtr dwBytes);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool HeapFree(IntPtr hHeap, uint dwFlags, IntPtr lpMem);

	[DllImport("NTDLL.DLL", SetLastError = true)]
	public static extern int NtQueryInformationProcess(IntPtr hProcess, int pic, IntPtr pbi, uint cb, out uint pSize);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, int dwSize, out UIntPtr lpNumberOfBytesRead);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out UIntPtr lpNumberOfBytesWritten);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, IntPtr nSize, out UIntPtr lpNumberOfBytesWritten);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	public static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("kernel32.dll")]
	public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, FreeType dwFreeType);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool VirtualFree(IntPtr lpAddress, int dwSize, FreeType dwFreeType);

	[DllImport("kernel32.dll")]
	public static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

	[DllImport("kernel32.dll")]
	public static extern void GetSystemTimeAsFileTime(out FILETIME lpSystemTimeAsFileTime);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

	public static bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, out UIntPtr lpNumberOfBytesRead)
	{
		//IL_007f: Expected O, but got I
		UIntPtr uIntPtr = default(UIntPtr);
		object[] array = new object[4] { hProcess, lpBaseAddress, lpBuffer, uIntPtr };
		bool result = (bool)ConvertBack.Runner(19840, 176, 27, array);
		System.Runtime.CompilerServices.Unsafe.As<UIntPtr, object>(ref lpNumberOfBytesRead) = (nuint)(UIntPtr)array[3];
		return result;
	}

	public static bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, out uint lpBuffer, out UIntPtr lpNumberOfBytesRead)
	{
		//IL_007c: Expected O, but got I4
		//IL_0090: Expected O, but got I
		UIntPtr uIntPtr = default(UIntPtr);
		object[] array = new object[4] { hProcess, lpBaseAddress, 0u, uIntPtr };
		bool result = (bool)ConvertBack.Runner(20016, 160, 28, array);
		System.Runtime.CompilerServices.Unsafe.As<uint, object>(ref lpBuffer) = (uint)array[2];
		System.Runtime.CompilerServices.Unsafe.As<UIntPtr, object>(ref lpNumberOfBytesRead) = (nuint)(UIntPtr)array[3];
		return result;
	}

	public static bool ReadProcessMemory<T>(IntPtr hProcess, IntPtr lpBaseAddress, out T lpBuffer, out UIntPtr lpNumberOfBytesRead) where T : struct
	{
		byte[] array = new byte[Marshal.SizeOf(typeof(T))];
		bool result = ReadProcessMemory(hProcess, lpBaseAddress, array, out lpNumberOfBytesRead);
		GCHandle gCHandle = GCHandle.Alloc(array, GCHandleType.Pinned);
		lpBuffer = Marshal.PtrToStructure<T>(gCHandle.AddrOfPinnedObject());
		gCHandle.Free();
		return result;
	}

	public static IntPtr OpenProcess(Process proc, ProcessAccessFlags flags)
	{
		object[] array = new object[2] { proc, flags };
		return (IntPtr)ConvertBack.Runner(20176, 80, 29, array);
	}
}
