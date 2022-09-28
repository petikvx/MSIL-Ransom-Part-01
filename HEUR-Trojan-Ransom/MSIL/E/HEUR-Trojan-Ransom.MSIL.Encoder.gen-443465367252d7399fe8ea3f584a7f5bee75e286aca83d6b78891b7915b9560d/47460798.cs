using System;
using System.Runtime.InteropServices;
using System.Text;

internal static class _47460798
{
	[Flags]
	public enum _77F7415E : uint
	{
		_23EA5A98 = 0x1000u,
		_6CBA3C00 = 0x2000u
	}

	[Flags]
	public enum _049E7128 : uint
	{
		_2B2B004E = 1u,
		_55AF4D63 = 2u,
		_5C2D75CD = 4u,
		_1FE621E3 = 8u,
		_2B806E9E = 0x10u,
		_19564124 = 0x20u,
		_05472BE6 = 0x40u,
		_2DE51987 = 0x100u
	}

	[Flags]
	public enum _48335426 : uint
	{
		_550254B1 = 1u,
		_00107FD8 = 2u,
		_37457764 = 4u,
		_23C338A7 = 0x1Fu
	}

	[Flags]
	public enum _4B670091 : uint
	{
		_05EB693C = 0x20000000u,
		_015E20E5 = 0x40000000u,
		_3FF5098A = 0x80000000u
	}

	public const int _2F752E03 = int.MinValue;

	public const int _30B35446 = 3;

	public const int _329618BB = 128;

	public const int _0E7F7248 = 1;

	public const int _7E9E5DBB = 2;

	public static readonly IntPtr _727D2299 = new IntPtr(-1);

	public static readonly IntPtr _79096B9C = IntPtr.Zero;

	public static readonly IntPtr _73AE37C8 = new IntPtr(-1);

	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "CreateFile", SetLastError = true)]
	public static extern IntPtr _1F647A67(string _4B1C2C22, int _05E11DDC, int _5338346F, IntPtr _615A2B95, int _51DC2850, int _008C7EB9, IntPtr _62840363);

	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "CreateFileMapping", SetLastError = true)]
	public static extern IntPtr _3C1C10F0(IntPtr _46762CDA, IntPtr _48C22E01, _049E7128 _20D53852, int _5AE04D5B, int _67EA00EC, string _7FC659C8);

	[DllImport("kernel32", EntryPoint = "FlushViewOfFile", SetLastError = true)]
	public static extern bool _4E0A07AC(IntPtr _6B7D2CE0, int _441F6F5D);

	[DllImport("kernel32", EntryPoint = "MapViewOfFile", SetLastError = true)]
	public static extern IntPtr _5CE5180F(IntPtr _51221E05, _48335426 _4AB80CBF, int _27BB4742, int _1C283435, IntPtr _543E7645);

	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "OpenFileMapping", SetLastError = true)]
	public static extern IntPtr _32824A01(int _19B62301, bool _3BB96578, string _177712F1);

	[DllImport("kernel32", EntryPoint = "UnmapViewOfFile", SetLastError = true)]
	public static extern bool _2EF01E13(IntPtr _4E932A31);

	[DllImport("kernel32", EntryPoint = "CloseHandle", SetLastError = true)]
	public static extern bool _56453E89(IntPtr _61B73A31);

	[DllImport("kernel32", EntryPoint = "GetFileSize", SetLastError = true)]
	public static extern uint _2E201565(IntPtr _5914532A, IntPtr _319A7D63);

	[DllImport("kernel32", EntryPoint = "VirtualAlloc", SetLastError = true)]
	public static extern IntPtr _6FE85818(IntPtr _3D274B30, UIntPtr _550307F1, _77F7415E _795F541F, _049E7128 _0DB53EA2);

	[DllImport("kernel32", EntryPoint = "VirtualFree", SetLastError = true)]
	public static extern bool _7E4D5D8E(IntPtr _21392E0D, uint _6BB9406C, uint _2AA13EC6);

	[DllImport("kernel32", EntryPoint = "VirtualProtect", SetLastError = true)]
	public static extern bool _3F9E79A4(IntPtr _26FF698A, UIntPtr _34B74D79, _049E7128 _3C480CCE, out _049E7128 _2BD226B0);

	[DllImport("kernel32", EntryPoint = "GetVolumeInformation", SetLastError = true)]
	public static extern bool _4BE7314D(string _51425737, StringBuilder _6EC53C85, uint _23F511C6, ref uint _59621713, ref uint _095F358E, ref uint _583D292C, StringBuilder _3F5B060B, uint _69B35D4A);

	[DllImport("kernel32", EntryPoint = "IsDebuggerPresent")]
	public static extern bool _14FD74F6();

	[DllImport("kernel32", EntryPoint = "CheckRemoteDebuggerPresent")]
	public static extern bool _1FDC3AE6();

	[DllImport("kernel32", EntryPoint = "EnumSystemFirmwareTables", SetLastError = true)]
	public static extern uint _620561A5(uint _15C825B4, IntPtr _302A6EC7, uint _32E658D3);

	[DllImport("kernel32", EntryPoint = "GetSystemFirmwareTable", SetLastError = true)]
	public static extern uint _2ABC42BC(uint _79996350, uint _77036A95, IntPtr _604C3897, uint _4358685D);

	[DllImport("ntdll", EntryPoint = "NtQueryInformationProcess")]
	public static extern int _7F5E6045(IntPtr _68E11A48, int _282E275E, IntPtr _4197343F, uint _3E454869, out uint _06C874F8);
}
