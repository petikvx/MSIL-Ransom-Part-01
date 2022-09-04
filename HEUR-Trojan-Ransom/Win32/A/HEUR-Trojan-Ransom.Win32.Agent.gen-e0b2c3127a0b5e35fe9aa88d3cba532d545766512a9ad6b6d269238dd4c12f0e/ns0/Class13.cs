using System;
using System.Runtime.InteropServices;

namespace ns0;

internal class Class13
{
	internal enum Enum0
	{
		const_0 = 1,
		const_1 = 2,
		const_2 = 16,
		const_3 = 32,
		const_4 = 256,
		const_5 = -1
	}

	internal enum Enum1
	{
		const_0 = 0,
		const_1 = 1,
		const_2 = 2,
		const_3 = 3,
		const_4 = 4,
		const_5 = -1
	}

	internal enum Enum2
	{
		const_0 = 0,
		const_1 = 1,
		const_2 = 2,
		const_3 = 3,
		const_4 = 32768,
		const_5 = -1
	}

	internal enum Enum3
	{
		const_0 = 1,
		const_1,
		const_2
	}

	internal enum Enum4
	{
		const_0 = 1,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8,
		const_9,
		const_10,
		const_11,
		const_12,
		const_13
	}

	internal enum Enum5
	{
		const_0 = 1,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6
	}

	internal enum Enum6
	{
		const_0 = 1,
		const_1 = 2,
		const_2 = 4,
		const_3 = 8,
		const_4 = 0x10,
		const_5 = 0x20,
		const_6 = 0x40,
		const_7 = 0x80
	}

	internal enum Enum7
	{
		const_0 = 1,
		const_1 = 2,
		const_2 = 4,
		const_3 = 8,
		const_4 = 16,
		const_5 = 32,
		const_6 = 983103
	}

	internal enum Enum8
	{
		const_0 = 1,
		const_1 = 2,
		const_2 = 4,
		const_3 = 8,
		const_4 = 16,
		const_5 = 32,
		const_6 = 64,
		const_7 = 128,
		const_8 = 256,
		const_9 = 983551
	}

	internal struct Struct7
	{
		internal int int_0;

		internal string string_0;

		internal string string_1;

		internal int int_1;

		internal int int_2;
	}

	internal struct Struct8
	{
		internal int int_0;

		internal int int_1;

		internal int int_2;

		internal string string_0;

		internal string string_1;

		internal int int_3;

		internal string string_2;

		internal string string_3;

		internal string string_4;
	}

	internal enum Enum9
	{
		const_0,
		const_1,
		const_2,
		const_3
	}

	internal struct Struct9
	{
		internal Enum9 enum9_0;

		internal int int_0;
	}

	internal struct Struct10
	{
		internal string string_0;
	}

	internal struct Struct11
	{
		internal int int_0;

		internal int int_1;

		internal int int_2;

		internal int int_3;

		internal int int_4;

		internal int int_5;

		internal int int_6;
	}

	internal enum Enum10
	{
		const_0 = 1,
		const_1
	}

	internal const int int_0 = 983040;

	internal const int int_1 = int.MinValue;

	internal const int int_2 = 122;

	internal const int int_3 = -1;

	[DllImport("advapi32.dll")]
	internal static extern int LockServiceDatabase(int int_4);

	[DllImport("advapi32.dll")]
	internal static extern bool UnlockServiceDatabase(int int_4);

	[DllImport("kernel32.dll")]
	internal static extern void CopyMemory(IntPtr intptr_0, Struct9[] struct9_0, int int_4);

	[DllImport("advapi32.dll")]
	internal static extern bool ChangeServiceConfigA(int int_4, Enum0 enum0_0, int int_5, int int_6, string string_0, string string_1, int int_7, string string_2, string string_3, string string_4, string string_5);

	[DllImport("advapi32.dll")]
	internal static extern bool ChangeServiceConfig2A(int int_4, Enum10 enum10_0, [MarshalAs(UnmanagedType.Struct)] ref Struct10 struct10_0);

	[DllImport("advapi32.dll")]
	internal static extern bool ChangeServiceConfig2A(int int_4, Enum10 enum10_0, [MarshalAs(UnmanagedType.Struct)] ref Struct7 struct7_0);

	[DllImport("advapi32.dll")]
	internal static extern int OpenServiceA(int int_4, string string_0, Enum8 enum8_0);

	[DllImport("advapi32.dll")]
	internal static extern int OpenSCManagerA(string string_0, string string_1, Enum7 enum7_0);

	[DllImport("advapi32.dll")]
	internal static extern bool CloseServiceHandle(int int_4);

	[DllImport("advapi32.dll")]
	internal static extern bool QueryServiceConfigA(int int_4, [MarshalAs(UnmanagedType.Struct)] ref Struct8 struct8_0, int int_5, int int_6);
}
