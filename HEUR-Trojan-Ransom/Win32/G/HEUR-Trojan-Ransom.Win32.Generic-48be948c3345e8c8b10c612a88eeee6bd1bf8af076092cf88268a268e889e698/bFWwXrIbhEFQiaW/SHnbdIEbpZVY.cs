using System;
using System.Runtime.InteropServices;

namespace bFWwXrIbhEFQiaW;

public sealed class SHnbdIEbpZVY
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct KqLbsJldtwrpU
	{
		public uint uzCIwIVLjuuPXJm;

		public TauSpdcjMjwWP sQpZlZLbqjj;

		public TauSpdcjMjwWP lEMOkRWzWyJDpGh;

		public TauSpdcjMjwWP nwOkkWUBYGEl;

		public uint nUjYekgeRyS;

		public uint dpQBDwCkJlpvBYb;

		public uint zoePHJTmbDzEU;

		public uint sGJrZkCKnwrY;

		public uint AnGFfhutTzBiK;

		public uint TGoaEIVjOWlkL;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct TauSpdcjMjwWP
	{
		public uint JJoHDAxXXQEpM;

		public uint IZCYdPcxoxvxE;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct KWjceTmPPWvJ
	{
		public ulong nPVNWppWJbh;

		public long wThfFoacYNAo;

		public long XTtmiHSMvd;

		public long jxLjlzHlsjK;

		public long YXMgCDASRwUNgT;

		public ulong CHdyXOnpJmbQg;

		public ulong cQwLKkxfJSNZM;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct jnIazHGnCORozK
	{
		public ulong gKNYMqNbuo;

		public long pARaykxKVQVgSWvNqt;

		public long TLelSwkujCZJP;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct RWEUSmHFxC
	{
		public ulong CHdyXOnpJmbQg;

		public ulong cQwLKkxfJSNZM;
	}

	public sealed class QoWeGPjHkVe
	{
		public uint uzCIwIVLjuuPXJm;

		public string BJxpRYxmovKECx = string.Empty;

		public int ZOpSRiVpma;

		public int ytXAGITDeHEl;

		public ulong CzcaGffkBlWLOa;

		public ulong cyPzvzJClXSHGR;

		public uint syLgGjAvrENOBJu;

		public QoWeGPjHkVe(IntPtr intptr_0)
		{
			syLgGjAvrENOBJu = (uint)Marshal.ReadInt32(intptr_0);
			CzcaGffkBlWLOa = (ulong)Marshal.ReadInt64(intptr_0, 8);
			cyPzvzJClXSHGR = (ulong)Marshal.ReadInt64(intptr_0, 16);
			uzCIwIVLjuuPXJm = (uint)Marshal.ReadInt32(intptr_0, 52);
			ZOpSRiVpma = Marshal.ReadInt16(intptr_0, 56);
			ytXAGITDeHEl = Marshal.ReadInt16(intptr_0, 58);
			BJxpRYxmovKECx = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + ytXAGITDeHEl), ZOpSRiVpma / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr CybzwPpTkWK, out KqLbsJldtwrpU SJtAZElmUTSBQhs);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr SDRfqhxwWlAsqNpR);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr lFpgLAfpPwL, uint FiSBOkxAAAJXYb, IntPtr YXPdYkFaREkj, int YguiIWuslFC, out KWjceTmPPWvJ AwXKlKESDeMnt, int MEvszSFGSIQU, out uint ZgnwYwBWzx, IntPtr gaDbqUUURmP);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr qBKPQYDdAqVZH, uint pQuEiRrbLRXsq, IntPtr mkQmmsvXsoXm, int sBdBUpCOlbH, IntPtr MMLmTaFakOuftzW, int bTQCbrQFwAl, out uint yWIMbVaTqpP, IntPtr FjlKwFORFpwVDnA);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
