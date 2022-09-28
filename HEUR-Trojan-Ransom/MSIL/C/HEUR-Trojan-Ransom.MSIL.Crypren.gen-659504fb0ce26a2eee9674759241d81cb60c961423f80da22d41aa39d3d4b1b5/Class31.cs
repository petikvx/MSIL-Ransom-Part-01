using System;
using System.Runtime.InteropServices;

internal static class Class31
{
	public enum Enum0 : uint
	{
		const_0 = 1u,
		const_1 = 2u,
		const_2 = 4u,
		const_3 = 8u,
		const_4 = 0x10u,
		const_5 = 0x20u,
		const_6 = 0x40u,
		const_7 = 0x100u
	}

	public enum Enum1 : uint
	{
		const_0 = 1u,
		const_1 = 2u,
		const_2 = 4u,
		const_3 = 31u
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
	public static extern IntPtr CreateFileMapping(IntPtr intptr_3, IntPtr intptr_4, Enum0 enum0_0, int int_5, int int_6, string string_0);

	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr MapViewOfFile(IntPtr intptr_3, Enum1 enum1_0, int int_5, int int_6, IntPtr intptr_4);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool UnmapViewOfFile(IntPtr intptr_3);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr intptr_3);

	[DllImport("kernel32", SetLastError = true)]
	public static extern uint GetFileSize(IntPtr intptr_3, IntPtr intptr_4);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool VirtualProtect(IntPtr intptr_3, UIntPtr uintptr_0, Enum0 enum0_0, out Enum0 enum0_1);

	[DllImport("kernel32")]
	public static extern bool IsDebuggerPresent();

	[DllImport("kernel32")]
	public static extern bool CheckRemoteDebuggerPresent();

	[DllImport("ntdll")]
	public static extern int NtQueryInformationProcess(IntPtr intptr_3, int int_5, byte[] byte_0, uint uint_0, out uint uint_1);
}
