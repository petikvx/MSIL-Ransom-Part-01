using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;

internal class Class28
{
	public enum Enum6 : uint
	{
		const_0 = 1u
	}

	[Flags]
	internal enum Enum7
	{
		flag_0 = 1,
		flag_1 = 2,
		flag_2 = 8,
		flag_3 = 0x10,
		flag_4 = 0x20,
		flag_5 = 0x40,
		flag_6 = 0x80,
		flag_7 = 0x100,
		flag_8 = 0x200
	}

	internal enum Enum8
	{
		const_0 = 2035711
	}

	internal enum Enum9
	{
		const_0,
		const_1,
		const_2,
		const_3,
		const_4,
		const_5,
		const_6,
		const_7,
		const_8
	}

	internal enum Enum10
	{
		const_0 = 0,
		const_1 = 4
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern Enum6 MessageBox(IntPtr intptr_0, string string_0, string string_1, int int_0);

	[DllImport("iphlpapi.dll", SetLastError = true)]
	public static extern int GetExtendedTcpTable(byte[] byte_0, out int int_0, bool bool_0, int int_1, Enum9 enum9_0, int int_2);

	[DllImport("KERNEL32.DLL")]
	public static extern IntPtr GetCurrentProcess();

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr intptr_0, int int_0, [In] byte[] byte_0);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr intptr_0, int int_0, [Out] byte[] byte_0, uint uint_0, out uint uint_1);

	[DllImport("KERNEL32.DLL")]
	public static extern IntPtr OpenThread(Enum7 enum7_0, bool bool_0, uint uint_0);

	[DllImport("KERNEL32.DLL")]
	public static extern uint SuspendThread(IntPtr intptr_0);

	[DllImport("KERNEL32.DLL")]
	public static extern int ResumeThread(IntPtr intptr_0);

	[DllImport("KERNEL32.DLL", CharSet = CharSet.Unicode, SetLastError = true)]
	public static extern bool MoveFileEx(string string_0, string string_1, Enum10 enum10_0);

	public static bool smethod_0(string string_0)
	{
		if (!Delegate352.smethod_0(string_0, null, Enum10.const_1))
		{
			return false;
		}
		return true;
	}

	public static bool smethod_1(string string_0, string string_1)
	{
		if (!Delegate352.smethod_0(string_0, string_1, Enum10.const_0))
		{
			return false;
		}
		return true;
	}

	public static void smethod_2(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] byte_ = new byte[Delegate353.smethod_0(rawSecurityDescriptor_0)];
		Delegate354.smethod_0(rawSecurityDescriptor_0, byte_, 0);
		if (!Delegate355.smethod_0(intptr_0, 4, byte_))
		{
			throw Delegate273.smethod_0();
		}
	}

	public static RawSecurityDescriptor smethod_3(IntPtr intptr_0)
	{
		byte[] byte_ = new byte[0];
		Delegate356.smethod_0(intptr_0, 4, byte_, 0u, out var uint_);
		if ((long)uint_ > 32767L)
		{
			throw Delegate273.smethod_0();
		}
		if (!Delegate356.smethod_0(intptr_0, 4, byte_ = new byte[uint_], uint_, out uint_))
		{
			throw Delegate273.smethod_0();
		}
		return Delegate357.smethod_0(byte_, 0);
	}
}
