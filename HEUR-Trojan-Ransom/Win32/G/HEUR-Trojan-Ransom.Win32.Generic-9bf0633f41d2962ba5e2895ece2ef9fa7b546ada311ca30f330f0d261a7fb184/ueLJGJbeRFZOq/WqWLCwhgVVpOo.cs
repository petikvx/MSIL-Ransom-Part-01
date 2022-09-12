using System;
using System.Runtime.InteropServices;

namespace ueLJGJbeRFZOq;

public sealed class WqWLCwhgVVpOo
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct PjOUVNuODLfT
	{
		public uint pRJwNEEsxxBQp;

		public pbIRNxiitTUiip iARHTUQlFZydA;

		public pbIRNxiitTUiip zrwabpBVJtMqk;

		public pbIRNxiitTUiip eZtZMqOQbvu;

		public uint cYOnbjQjOjyiRApx;

		public uint fBNIsXojnKs;

		public uint LGryjgiYLcftb;

		public uint SEIKjwUqdFFtii;

		public uint yDnvSwgntGPEaK;

		public uint dtmLXAGsXRi;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct pbIRNxiitTUiip
	{
		public uint lCHnEsHHtEU;

		public uint XjjfcJcBdlawH;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct VNSaMNqrqNH
	{
		public ulong mTxcVyUBhsa;

		public long jgnhinvhvE;

		public long uDdDTmcuzAYC;

		public long QMGOqneRbWc;

		public long prLNzlHXhdyTS;

		public ulong izyvdzDqNmJF;

		public ulong obShgGzdVtwl;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct qwEkaoxqNF
	{
		public ulong UsgUrLfqrdyc;

		public long ZPtgqrlsLkzi;

		public long NuvdBPJfIxMn;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct UUriaFpDXmsjyJp
	{
		public ulong izyvdzDqNmJF;

		public ulong obShgGzdVtwl;
	}

	public sealed class eNboiyhhmS
	{
		public uint pRJwNEEsxxBQp;

		public string cVvbQKOMBtmy = string.Empty;

		public int DcUVzryGjC;

		public int sERYrEoGvEYxci;

		public ulong paGJyJHPss;

		public ulong ZlLAPbqaSopJRqx;

		public uint CGEMYdjwcpW;

		public eNboiyhhmS(IntPtr intptr_0)
		{
			CGEMYdjwcpW = (uint)Marshal.ReadInt32(intptr_0);
			paGJyJHPss = (ulong)Marshal.ReadInt64(intptr_0, 8);
			ZlLAPbqaSopJRqx = (ulong)Marshal.ReadInt64(intptr_0, 16);
			pRJwNEEsxxBQp = (uint)Marshal.ReadInt32(intptr_0, 52);
			DcUVzryGjC = Marshal.ReadInt16(intptr_0, 56);
			sERYrEoGvEYxci = Marshal.ReadInt16(intptr_0, 58);
			cVvbQKOMBtmy = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + sERYrEoGvEYxci), DcUVzryGjC / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr lGRwJuaegNEv, out PjOUVNuODLfT mesiyiZTHaRy);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr GvCbPnxbpLE);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr BUDabEGlhSl, uint KBudxkoXUCPEo, IntPtr RuxiExbRAqTz, int bspgOFkFJShY, out VNSaMNqrqNH KookIWvWyEXm, int FIaPrMqQsqtM, out uint pexGFuoBKwN, IntPtr ePnyeSkFLdyS);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr lrQJpzhskuXJN, uint QTSvgkNBOjyH, IntPtr KqFkFKBUret, int ViIGJIWfFrg, IntPtr SAeFQGkTsQ, int htHgwRCnsq, out uint iFVpKFREszgD, IntPtr cuqQgWtmAASMk);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
