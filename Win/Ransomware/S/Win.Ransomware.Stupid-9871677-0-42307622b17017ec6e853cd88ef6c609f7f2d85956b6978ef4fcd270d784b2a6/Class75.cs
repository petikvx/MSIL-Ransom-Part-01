using System;
using System.Runtime.InteropServices;
using System.Text;

internal static class Class75
{
	public enum Enum7 : uint
	{
		const_0 = 0x1000u,
		const_1 = 0x2000u
	}

	public enum Enum8 : uint
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

	public enum Enum9 : uint
	{
		const_0 = 1u,
		const_1 = 2u,
		const_2 = 4u,
		const_3 = 31u
	}

	public enum Enum10 : uint
	{
		const_0 = 0x20000000u,
		const_1 = 0x40000000u,
		const_2 = 0x80000000u
	}

	public enum Enum11
	{
		const_0 = 1,
		const_1 = 2,
		const_2 = 4,
		const_3 = 8,
		const_4 = 16,
		const_5 = 32,
		const_6 = 512,
		const_7 = 256,
		const_8 = 768,
		const_9 = 131097,
		const_10 = 131078,
		const_11 = 131097,
		const_12 = 983103
	}

	internal static class Class76
	{
		public static UIntPtr uintptr_0;

		public static UIntPtr uintptr_1;
	}

	public static class Class77
	{
		[DllImport("advapi32")]
		private static extern uint RegOpenKeyEx(UIntPtr uintptr_0, string string_0, uint uint_0, int int_0, out UIntPtr uintptr_1);

		[DllImport("advapi32")]
		private static extern uint RegCloseKey(UIntPtr uintptr_0);

		[DllImport("advapi32")]
		private static extern int RegQueryValueEx(UIntPtr uintptr_0, string string_0, int int_0, ref uint uint_0, StringBuilder stringBuilder_0, ref uint uint_1);

		[DllImport("advapi32")]
		private static extern uint RegQueryInfoKey(UIntPtr uintptr_0, StringBuilder stringBuilder_0, ref uint uint_0, IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, IntPtr intptr_5, IntPtr intptr_6, IntPtr intptr_7, out long long_0);

		public static extern string smethod_0(UIntPtr uintptr_0, string string_0, string string_1);

		public static extern bool smethod_1(UIntPtr uintptr_0, string string_0, ref DateTime dateTime_0);

		public static extern bool smethod_2(UIntPtr uintptr_0, string string_0, Enum11 enum11_0, ref DateTime dateTime_0);

		public static extern string smethod_3(UIntPtr uintptr_0, string string_0, Enum11 enum11_0, string string_1);
	}

	public const int int_0 = default(int);

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
	public static extern IntPtr CreateFileMapping(IntPtr intptr_3, IntPtr intptr_4, Enum8 enum8_0, int int_5, int int_6, string string_0);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool FlushViewOfFile(IntPtr intptr_3, int int_5);

	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr MapViewOfFile(IntPtr intptr_3, Enum9 enum9_0, int int_5, int int_6, IntPtr intptr_4);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr OpenFileMapping(int int_5, bool bool_0, string string_0);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool UnmapViewOfFile(IntPtr intptr_3);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr intptr_3);

	[DllImport("kernel32", SetLastError = true)]
	public static extern uint GetFileSize(IntPtr intptr_3, IntPtr intptr_4);

	[DllImport("kernel32", SetLastError = true)]
	public static extern IntPtr VirtualAlloc(IntPtr intptr_3, UIntPtr uintptr_0, Enum7 enum7_0, Enum8 enum8_0);

	[DllImport("kernel32")]
	public static extern bool VirtualFree(IntPtr intptr_3, uint uint_0, uint uint_1);

	[DllImport("kernel32", SetLastError = true)]
	public static extern bool VirtualProtect(IntPtr intptr_3, UIntPtr uintptr_0, Enum8 enum8_0, out Enum8 enum8_1);

	[DllImport("kernel32")]
	public static extern bool GetVolumeInformation(string string_0, StringBuilder stringBuilder_0, uint uint_0, ref uint uint_1, ref uint uint_2, ref uint uint_3, StringBuilder stringBuilder_1, uint uint_4);

	[DllImport("kernel32")]
	public static extern bool IsDebuggerPresent();

	[DllImport("kernel32")]
	public static extern bool CheckRemoteDebuggerPresent();

	[DllImport("ntdll")]
	public static extern int NtQueryInformationProcess(IntPtr intptr_3, int int_5, byte[] byte_0, uint uint_0, out uint uint_1);
}
