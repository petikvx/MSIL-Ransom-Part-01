using System;
using System.Runtime.InteropServices;

namespace DxdMrHCZzlIaV;

public sealed class CDyryfTazGZaC
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct IqfHlqEzFiMi
	{
		public uint LBxzyLmtFRAu;

		public WsrfhnKVszWgw RIQpQFgyesLQv;

		public WsrfhnKVszWgw ORHMZbicJFcsmEUa;

		public WsrfhnKVszWgw rrHvqgSBByLaCX;

		public uint aQciwloswJzg;

		public uint kjwrujFMyPkuIF;

		public uint JIXELDyYpbFSlI;

		public uint KmTfldMBnUrYfEr;

		public uint vnKhDfxzwIl;

		public uint gESFTRgsASpI;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct WsrfhnKVszWgw
	{
		public uint ZWvVhIeJXWx;

		public uint HVIPSrYcucjKTX;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ssODQqFGZxhzHO
	{
		public ulong ySLzvfDBSDmauag;

		public long djBrQOklIOA;

		public long IpOWsEsjUbbSHkVg;

		public long TCYKnxooXaBJkXBU;

		public long VFsfscrUdR;

		public ulong iLvQwJfmVqIlI;

		public ulong fSeDxbzziNx;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ZYnYgEHjUGoHa
	{
		public ulong jEuZjjKgxb;

		public long nUgsOVOoJzv;

		public long rWLTVdWNXISu;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct EipIejSotHG
	{
		public ulong iLvQwJfmVqIlI;

		public ulong fSeDxbzziNx;
	}

	public sealed class oZVSGqUVmHJj
	{
		public uint LBxzyLmtFRAu;

		public string VkbUYDCBfOlrPES = string.Empty;

		public int QmIsDqAbUiuFv;

		public int nWobSBHSZahCUm;

		public ulong mYjkrZxxOIJz;

		public ulong uHzCnIDgDQuQfsDY;

		public uint ZWYdVmkZwrCsg;

		public oZVSGqUVmHJj(IntPtr intptr_0)
		{
			ZWYdVmkZwrCsg = (uint)Marshal.ReadInt32(intptr_0);
			mYjkrZxxOIJz = (ulong)Marshal.ReadInt64(intptr_0, 8);
			uHzCnIDgDQuQfsDY = (ulong)Marshal.ReadInt64(intptr_0, 16);
			LBxzyLmtFRAu = (uint)Marshal.ReadInt32(intptr_0, 52);
			QmIsDqAbUiuFv = Marshal.ReadInt16(intptr_0, 56);
			nWobSBHSZahCUm = Marshal.ReadInt16(intptr_0, 58);
			VkbUYDCBfOlrPES = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + nWobSBHSZahCUm), QmIsDqAbUiuFv / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr WtGKribWqEM, out IqfHlqEzFiMi WYxNyCwgjOu);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr LYnpNcGMtpCkw);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr oiRKgNBgxFWQM, uint QjMOajJldIXxLWGGmj, IntPtr sZuqvEpcOiT, int kJFSIdNigIAxv, out ssODQqFGZxhzHO KpzOpTWBldRBETld, int uZsJdniStUBh, out uint eUprZHbtyRoLZ, IntPtr YvTinhnoAOCFQI);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr WnKgcKkhAPv, uint jshyTdLQsUMgw, IntPtr dkpOLqsVDSj, int nJQfZgZQaVMLa, IntPtr EhsQFOJFDv, int sWxsbmYTIJzPw, out uint syFAslEYVAL, IntPtr tYOlsvpMbxHd);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
