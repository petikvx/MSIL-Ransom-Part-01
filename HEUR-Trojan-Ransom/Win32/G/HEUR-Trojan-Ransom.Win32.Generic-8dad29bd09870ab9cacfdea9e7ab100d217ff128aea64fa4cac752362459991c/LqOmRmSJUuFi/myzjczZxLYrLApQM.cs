using System;
using System.Runtime.InteropServices;

namespace LqOmRmSJUuFi;

public sealed class myzjczZxLYrLApQM
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct EwplMszDBayCw
	{
		public uint ntDcXfkeQsMll;

		public SbdlvZOrfuFE SrACgIImLbn;

		public SbdlvZOrfuFE QhoFJCIHuoUiKR;

		public SbdlvZOrfuFE CAgWKIDvbu;

		public uint khFbgxwQwfoOfwK;

		public uint bYOkXOydCWnHeG;

		public uint UXqJkHLpSf;

		public uint uhaOWIOkPjgtAQt;

		public uint QPNXlcwctD;

		public uint VCPgtVQfFohfG;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct SbdlvZOrfuFE
	{
		public uint gclKvBwsuTe;

		public uint kRokGMpgVEst;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct dtIkOZNTLU
	{
		public ulong rupWphqTSO;

		public long eLOmqxyjOyZYHMS;

		public long vEemOFEkTZ;

		public long EDqyZUXktBrv;

		public long ebxLwWNzGQIB;

		public ulong QCWusJSJryD;

		public ulong RgVpuIARDptS;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct WeICQDjJjbF
	{
		public ulong PTKUGrmORa;

		public long umlRutkYYd;

		public long VQfQWQAWvH;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct pgECCXDDmOk
	{
		public ulong QCWusJSJryD;

		public ulong RgVpuIARDptS;
	}

	public sealed class OFEooBQXViMg
	{
		public uint ntDcXfkeQsMll;

		public string gqiQWowOLNGWA = string.Empty;

		public int zFPBvwoKsEcbf;

		public int gbFqjwxEnJEnK;

		public ulong cBSdgPvEYwQMCs;

		public ulong BJaqDKcfEI;

		public uint ZHouubkKOEiZ;

		public OFEooBQXViMg(IntPtr intptr_0)
		{
			ZHouubkKOEiZ = (uint)Marshal.ReadInt32(intptr_0);
			cBSdgPvEYwQMCs = (ulong)Marshal.ReadInt64(intptr_0, 8);
			BJaqDKcfEI = (ulong)Marshal.ReadInt64(intptr_0, 16);
			ntDcXfkeQsMll = (uint)Marshal.ReadInt32(intptr_0, 52);
			zFPBvwoKsEcbf = Marshal.ReadInt16(intptr_0, 56);
			gbFqjwxEnJEnK = Marshal.ReadInt16(intptr_0, 58);
			gqiQWowOLNGWA = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + gbFqjwxEnJEnK), zFPBvwoKsEcbf / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr EpPOcQZytlwrNh, out EwplMszDBayCw TJEEidATSJtW);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr rRchpNudolTMfG);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr vksUnTZagk, uint EzHYqPwjJSe, IntPtr aNyXmoxTMXjYiQ, int YBjJOhhQCSJK, out dtIkOZNTLU UJMLfSvJTQl, int ydHEzHLAfO, out uint GnCdjhYigsMxxFU, IntPtr AzjuFbdyhVxhv);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr HkoFmcZjGQDQ, uint gNQGEpIbZebZQ, IntPtr DzieFZnQrUK, int ZnzKPamLQNp, IntPtr RVHXPJslWTLY, int suZvGHGRZlAx, out uint vTmjnEShUFdZ, IntPtr MdvAYTeYQb);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
