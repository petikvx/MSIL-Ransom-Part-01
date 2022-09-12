using System;
using System.Runtime.InteropServices;

namespace EbNNdTmxNaUt;

public sealed class AmnWAzTthqCkpC
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct XVIrYtVRfertl
	{
		public uint qqsZWujGubBR;

		public dEQsnbqrRoYVhcc SKsZtCSolPO;

		public dEQsnbqrRoYVhcc nKTlZHFVSpYZH;

		public dEQsnbqrRoYVhcc YZNfgRyeDfZJzX;

		public uint JTPDUCOCBQH;

		public uint EbdqAFNNBetX;

		public uint XvzHVvTylQopUdM;

		public uint McrrjGVaJQuhBbJ;

		public uint AKMieZBVbpJP;

		public uint BxuWXmtpCvps;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct dEQsnbqrRoYVhcc
	{
		public uint qUdLKzTqjjiaFq;

		public uint cTeCKLlpCRZgR;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct jydZyqQbYyh
	{
		public ulong ofsCczHnxHu;

		public long KvBlJmfkwJwGkxbb;

		public long bFHZtDlXKkd;

		public long HnodlTiKQAM;

		public long NmYyCiyxTWkxm;

		public ulong KEhskOMFWYC;

		public ulong ybuJkQJtaJ;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct DVWIjMggjb
	{
		public ulong VWTZZTpyukVwMh;

		public long cyiXmrMkWVq;

		public long mupoJYbAfVREZR;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct TcLJhgmKaZbNP
	{
		public ulong KEhskOMFWYC;

		public ulong ybuJkQJtaJ;
	}

	public sealed class kHLXLNBhhMWm
	{
		public uint qqsZWujGubBR;

		public string jWQZGcHzfCPq = string.Empty;

		public int afmFQhgjjALajn;

		public int gmOJOUUYHkFcvSC;

		public ulong KatpPmNNpfL;

		public ulong WdeRAUzrgltAdokFP;

		public uint jYzUggJtCmf;

		public kHLXLNBhhMWm(IntPtr intptr_0)
		{
			jYzUggJtCmf = (uint)Marshal.ReadInt32(intptr_0);
			KatpPmNNpfL = (ulong)Marshal.ReadInt64(intptr_0, 8);
			WdeRAUzrgltAdokFP = (ulong)Marshal.ReadInt64(intptr_0, 16);
			qqsZWujGubBR = (uint)Marshal.ReadInt32(intptr_0, 52);
			afmFQhgjjALajn = Marshal.ReadInt16(intptr_0, 56);
			gmOJOUUYHkFcvSC = Marshal.ReadInt16(intptr_0, 58);
			jWQZGcHzfCPq = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + gmOJOUUYHkFcvSC), afmFQhgjjALajn / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr EAQdpsQVioN, out XVIrYtVRfertl ymeHoyFmYPgBojS);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr NfmfhCZiqcNfkGW);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr bGoHAmcNklIs, uint PrIgkNgXqgikyd, IntPtr URsoLHyxQIZRZ, int AHazHUxHKa, out jydZyqQbYyh BYTGvUigkBlTq, int rDPrJXSSHMgtX, out uint CeJJQiVALNudX, IntPtr bxRHvmgZPe);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr kAPZyJmVBW, uint atJhrrRkxP, IntPtr xbepuzlumxs, int DVYEKpezQxVf, IntPtr aXhEqkWtqsl, int yZKDGQMEYv, out uint eMjVwOZDNgOz, IntPtr tbUCebVAXSf);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
