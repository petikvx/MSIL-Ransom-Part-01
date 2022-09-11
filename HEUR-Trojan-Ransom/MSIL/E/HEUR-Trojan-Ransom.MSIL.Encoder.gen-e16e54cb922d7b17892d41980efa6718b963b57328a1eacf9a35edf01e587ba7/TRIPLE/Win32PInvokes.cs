using System;
using System.Runtime.InteropServices;

namespace TRIPLE;

public class Win32PInvokes
{
	public enum AllocationType : uint
	{
		COMMIT = 4096u,
		RESERVE = 8192u,
		RESET = 524288u,
		LARGE_PAGES = 536870912u,
		PHYSICAL = 4194304u,
		TOP_DOWN = 1048576u,
		WRITE_WATCH = 2097152u
	}

	public enum MemoryProtection : uint
	{
		EXECUTE = 16u,
		EXECUTE_READ = 32u,
		EXECUTE_READWRITE = 64u,
		EXECUTE_WRITECOPY = 128u,
		NOACCESS = 1u,
		READONLY = 2u,
		READWRITE = 4u,
		WRITECOPY = 8u,
		GUARD_Modifierflag = 256u,
		NOCACHE_Modifierflag = 512u,
		WRITECOMBINE_Modifierflag = 1024u
	}

	public enum CONTEXT_FLAGS : uint
	{
		CONTEXT_i386 = 65536u,
		CONTEXT_i486 = 65536u,
		CONTEXT_CONTROL = 65537u,
		CONTEXT_INTEGER = 65538u,
		CONTEXT_SEGMENTS = 65540u,
		CONTEXT_FLOATING_POINT = 65544u,
		CONTEXT_DEBUG_REGISTERS = 65552u,
		CONTEXT_EXTENDED_REGISTERS = 65568u,
		CONTEXT_FULL = 65543u,
		CONTEXT_ALL = 65599u
	}

	public struct FLOATING_SAVE_AREA
	{
		public uint ControlWord;

		public uint StatusWord;

		public uint TagWord;

		public uint ErrorOffset;

		public uint ErrorSelector;

		public uint DataOffset;

		public uint DataSelector;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
		public byte[] RegisterArea;

		public uint Cr0NpxState;
	}

	public struct CONTEXT
	{
		public uint ContextFlags;

		public uint Dr0;

		public uint Dr1;

		public uint Dr2;

		public uint Dr3;

		public uint Dr6;

		public uint Dr7;

		public FLOATING_SAVE_AREA FloatSave;

		public uint SegGs;

		public uint SegFs;

		public uint SegEs;

		public uint SegDs;

		public uint Edi;

		public uint Esi;

		public uint Ebx;

		public uint Edx;

		public uint Ecx;

		public uint Eax;

		public uint Ebp;

		public uint Eip;

		public uint SegCs;

		public uint EFlags;

		public uint Esp;

		public uint SegSs;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] ExtendedRegisters;
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandleA(string lpModuleName);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

	[DllImport("kernel32.dll")]
	public static extern bool VirtualProtect(IntPtr lpAddress, uint dwSize, uint flNewProtect, out uint lpflOldProtect);

	[DllImport("kernel32.dll")]
	public static extern IntPtr VirtualAlloc(IntPtr lpAddress, uint dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

	[DllImport("kernel32.dll")]
	public static extern bool VirtualFree(IntPtr lpAddress, uint dwSize, uint dwFreeType);

	[DllImport("kernel32.dll")]
	public static extern bool FlushInstructionCache(IntPtr hProcess, IntPtr lpBaseAddress, uint dwSize);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll")]
	public static extern int SuspendThread(IntPtr hThread);

	[DllImport("kernel32.dll")]
	public static extern uint ResumeThread(IntPtr hThread);

	[DllImport("kernel32.dll")]
	public static extern bool GetThreadContext(IntPtr hThread, ref CONTEXT lpContext);

	[DllImport("kernel32.dll")]
	public static extern uint GetCurrentThreadId();

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenThread(uint dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

	[DllImport("kernel32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr hObject);

	[DllImport("kernel32.dll")]
	public static extern void Sleep(uint dwMilliseconds);

	[DllImport("kernel32.dll")]
	public static extern void OutputDebugString(string lpOutputString);

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(uint dwDesiredAccess, [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle, int dwProcessId);

	[DllImport("kernel32.dll")]
	public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, AllocationType flAllocationType, MemoryProtection flProtect);

	[DllImport("kernel32.dll")]
	public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, uint dwFreeType);

	[DllImport("kernel32.dll")]
	public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out uint lpThreadId);

	[DllImport("kernel32.dll")]
	public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int nSize, out uint lpNumberOfBytesWritten);

	[DllImport("kernel32.dll")]
	public static extern bool AllocConsole();
}
