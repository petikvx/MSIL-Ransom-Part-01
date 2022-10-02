using System;
using System.Runtime.InteropServices;

namespace ODusMbbiJwu;

public sealed class SBCZoIlGDmz
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct CubwzvkWIPTB
	{
		public uint FZLzkpXzMrH;

		public AbLFjSmkVobgugY FZWgIuLPKSZEAHa;

		public AbLFjSmkVobgugY nTnLuNkLRQq;

		public AbLFjSmkVobgugY EDSMagtdVmxw;

		public uint LsAAqBPoON;

		public uint FkRWdiWlKSd;

		public uint gfkDeItnYBxa;

		public uint HKdXwUzMmxGZz;

		public uint hKfUyCUcKJNfSf;

		public uint nZulTsOYgus;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct AbLFjSmkVobgugY
	{
		public uint ExeDKwvPoZmbtk;

		public uint igNadfXYdEgjG;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct hBVPuLfOjuOcV
	{
		public ulong bdTvraSGDcsOnKpV;

		public long lUCWPCSywDcYxH;

		public long WJQDCBijJNf;

		public long pWiYLGsmblDn;

		public long gRJcyfDVJJz;

		public ulong kWCbJvQLkGnsFHSCp;

		public ulong YzkfDFgeMNyJQ;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct rTHjiaLYyD
	{
		public ulong IkOHDZnFxMNas;

		public long unMijPBSQiVLRANx;

		public long TMokUrCezJ;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct nBmbQJHmOecY
	{
		public ulong kWCbJvQLkGnsFHSCp;

		public ulong YzkfDFgeMNyJQ;
	}

	public sealed class fejpCzYdChS
	{
		public uint FZLzkpXzMrH;

		public string DgsZHjXXnspHU = string.Empty;

		public int joaowdNrBCsByF;

		public int hrJvKYurvhlfZcF;

		public ulong nKpamWBceobrnl;

		public ulong oZYFurtQScYLm;

		public uint CfJrBviJMbIqxK;

		public fejpCzYdChS(IntPtr intptr_0)
		{
			CfJrBviJMbIqxK = (uint)Marshal.ReadInt32(intptr_0);
			nKpamWBceobrnl = (ulong)Marshal.ReadInt64(intptr_0, 8);
			oZYFurtQScYLm = (ulong)Marshal.ReadInt64(intptr_0, 16);
			FZLzkpXzMrH = (uint)Marshal.ReadInt32(intptr_0, 52);
			joaowdNrBCsByF = Marshal.ReadInt16(intptr_0, 56);
			hrJvKYurvhlfZcF = Marshal.ReadInt16(intptr_0, 58);
			DgsZHjXXnspHU = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + hrJvKYurvhlfZcF), joaowdNrBCsByF / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr clnxMEBdxXvVx, out CubwzvkWIPTB doebuiQkCADHtY);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr htNJxqBQkNaXc);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr hIUZGVnzoi, uint zkKKlczxQKkDap, IntPtr vrunnojRdGTvGUL, int XAEASALdkNTlG, out hBVPuLfOjuOcV kjbIEmiLrUIX, int XEuiTecVxxicl, out uint iyjAAGUWpOUl, IntPtr mPMiiqRzAtgnf);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr pJPNatBNpEOM, uint fMOnMieOMggWllh, IntPtr UNWxmOezJdMx, int suQTZvuTXpFAPK, IntPtr FsXWPZcheDr, int sFFpCHYhJjGQgeJ, out uint SqaRiwEtSnTZ, IntPtr rntiivsyjAjD);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
