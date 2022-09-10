using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

internal class Class11
{
	[Flags]
	public enum Enum1 : uint
	{
		Readonly = 1u,
		Hidden = 2u,
		System = 4u,
		Directory = 0x10u,
		Archive = 0x20u,
		Device = 0x40u,
		Normal = 0x80u,
		Temporary = 0x100u,
		SparseFile = 0x200u,
		ReparsePoint = 0x400u,
		Compressed = 0x800u,
		Offline = 0x1000u,
		NotContentIndexed = 0x2000u,
		Encrypted = 0x4000u,
		Write_Through = 0x80000000u,
		Overlapped = 0x40000000u,
		NoBuffering = 0x20000000u,
		RandomAccess = 0x10000000u,
		SequentialScan = 0x8000000u,
		DeleteOnClose = 0x4000000u,
		BackupSemantics = 0x2000000u,
		PosixSemantics = 0x1000000u,
		OpenReparsePoint = 0x200000u,
		OpenNoRecall = 0x100000u,
		FirstPipeInstance = 0x80000u
	}

	public struct Struct0
	{
		public uint uint_0;

		public Guid guid_0;

		public uint uint_1;

		public IntPtr intptr_0;
	}

	public struct Struct1
	{
		public int int_0;

		public Guid guid_0;

		public int int_1;

		public IntPtr intptr_0;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct2
	{
		public uint uint_0;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string string_0;
	}

	public struct Struct3
	{
		public int int_0;

		public short short_0;

		public short short_1;

		public short short_2;
	}

	public const int int_0 = 1;

	public const int int_1 = 2;

	public const int int_2 = 4;

	public const int int_3 = 8;

	public const int int_4 = 16;

	[DllImport("hid.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern void HidD_GetHidGuid(out Guid guid_0);

	[DllImport("hid.dll")]
	public static extern bool HidD_GetAttributes(IntPtr intptr_0, ref Struct3 struct3_0);

	[DllImport("hid.dll")]
	internal static extern bool HidD_SetOutputReport(IntPtr intptr_0, byte[] byte_0, uint uint_0);

	[DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr SetupDiGetClassDevs(ref Guid guid_0, [MarshalAs(UnmanagedType.LPTStr)] string string_0, IntPtr intptr_0, uint uint_0);

	[DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool SetupDiEnumDeviceInterfaces(IntPtr intptr_0, IntPtr intptr_1, ref Guid guid_0, int int_5, ref Struct1 struct1_0);

	[DllImport("setupapi.dll", SetLastError = true)]
	public static extern bool SetupDiGetDeviceInterfaceDetail(IntPtr intptr_0, ref Struct1 struct1_0, IntPtr intptr_1, uint uint_0, out uint uint_1, IntPtr intptr_2);

	[DllImport("setupapi.dll", EntryPoint = "SetupDiGetDeviceInterfaceDetail", SetLastError = true)]
	public static extern bool SetupDiGetDeviceInterfaceDetail_1(IntPtr intptr_0, ref Struct1 struct1_0, ref Struct2 struct2_0, uint uint_0, out uint uint_1, IntPtr intptr_1);

	[DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern ushort SetupDiDestroyDeviceInfoList(IntPtr intptr_0);

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern SafeFileHandle CreateFile(string string_0, [MarshalAs(UnmanagedType.U4)] FileAccess fileAccess_0, [MarshalAs(UnmanagedType.U4)] FileShare fileShare_0, IntPtr intptr_0, [MarshalAs(UnmanagedType.U4)] FileMode fileMode_0, [MarshalAs(UnmanagedType.U4)] Enum1 enum1_0, IntPtr intptr_1);

	[DllImport("Kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr intptr_0);
}
