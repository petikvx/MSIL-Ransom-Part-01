using System;
using System.Runtime.InteropServices;
using System.Text;

internal static class Class39
{
	[Flags]
	public enum Enum1 : uint
	{
		flag_0 = 0x1000u,
		flag_1 = 0x2000u
	}

	[Flags]
	public enum Enum2 : uint
	{
		flag_0 = 1u,
		flag_1 = 2u,
		flag_2 = 4u,
		flag_3 = 8u,
		flag_4 = 0x10u,
		flag_5 = 0x20u,
		flag_6 = 0x40u,
		flag_7 = 0x100u
	}

	[Flags]
	public enum Enum3 : uint
	{
		flag_0 = 1u,
		flag_1 = 2u,
		flag_2 = 4u,
		flag_3 = 0x1Fu
	}

	[Flags]
	public enum Enum4 : uint
	{
		flag_0 = 0x20000000u,
		flag_1 = 0x40000000u,
		flag_2 = 0x80000000u
	}

	public const int int_0 = int.MinValue;

	public const int int_1 = 3;

	public const int int_2 = 128;

	public const int int_3 = 1;

	public const int int_4 = 2;

	public static readonly IntPtr intptr_0 = new IntPtr(-1);

	public static readonly IntPtr intptr_1 = IntPtr.Zero;

	public static readonly IntPtr intptr_2 = new IntPtr(-1);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, int int_5, int int_6, IntPtr intptr_3, int int_7, int int_8, IntPtr intptr_4);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CreateFileMapping(IntPtr intptr_3, IntPtr intptr_4, Enum2 enum2_0, int int_5, int int_6, string string_0);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool FlushViewOfFile(IntPtr intptr_3, int int_5);

	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr MapViewOfFile(IntPtr intptr_3, Enum3 enum3_0, int int_5, int int_6, IntPtr intptr_4);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr OpenFileMapping(int int_5, bool bool_0, string string_0);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool UnmapViewOfFile(IntPtr intptr_3);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr intptr_3);

	[DllImport("kernel32", SetLastError = true)]
	public static extern uint GetFileSize(IntPtr intptr_3, IntPtr intptr_4);

	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr VirtualAlloc(IntPtr intptr_3, UIntPtr uintptr_0, Enum1 enum1_0, Enum2 enum2_0);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool VirtualFree(IntPtr intptr_3, uint uint_0, uint uint_1);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool VirtualProtect(IntPtr intptr_3, UIntPtr uintptr_0, Enum2 enum2_0, out Enum2 enum2_1);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool GetVolumeInformation(string string_0, StringBuilder stringBuilder_0, uint uint_0, ref uint uint_1, ref uint uint_2, ref uint uint_3, StringBuilder stringBuilder_1, uint uint_4);

	[DllImport("kernel32")]
	public static extern bool IsDebuggerPresent();

	[DllImport("kernel32")]
	public static extern bool CheckRemoteDebuggerPresent();

	[DllImport("kernel32", SetLastError = true)]
	public static extern uint EnumSystemFirmwareTables(uint uint_0, IntPtr intptr_3, uint uint_1);

	[DllImport("kernel32", SetLastError = true)]
	public static extern uint GetSystemFirmwareTable(uint uint_0, uint uint_1, IntPtr intptr_3, uint uint_2);

	[DllImport("ntdll")]
	public static extern int NtQueryInformationProcess(IntPtr intptr_3, int int_5, IntPtr intptr_4, uint uint_0, out uint uint_1);
}
