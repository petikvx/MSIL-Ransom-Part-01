using System;
using System.Runtime.InteropServices;

namespace wFLFuclWzVArMo;

public sealed class quYsvTKKZTUsa
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct oHiWVpsXirkRsp
	{
		public uint ZpgLYwLqKYpEP;

		public WyfFHJoyMW XnTrWJmEWekonB;

		public WyfFHJoyMW GZzloNwSBnA;

		public WyfFHJoyMW UuEEvDxvPDp;

		public uint jbQnTxzFMGiDrqcIW;

		public uint qJLZMPLxFRwu;

		public uint GluSbSREujn;

		public uint wXNFBrhEQfpT;

		public uint qCJQJxqxpTZDXc;

		public uint PIwmZAvpIaS;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct WyfFHJoyMW
	{
		public uint MToHbXMWHKUVGc;

		public uint swvwaWifkcWMA;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct YJbfFOdhEoGT
	{
		public ulong DNVPMbtERdUXliJ;

		public long MEgSWqPOUHRJr;

		public long dcvSxsxSwcROJ;

		public long RjsPOEUcHPRDLeE;

		public long tSBbgzYwdvu;

		public ulong lGsBCspJpxA;

		public ulong iKJuFJcEvMAqZA;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ondIXVdddyVfAX
	{
		public ulong SXBaAZBWEgttD;

		public long jMuXapEZpIVnqU;

		public long IvZzDVcbBgsT;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct OrafonymHiIhydP
	{
		public ulong lGsBCspJpxA;

		public ulong iKJuFJcEvMAqZA;
	}

	public sealed class qaODESWiTbucuT
	{
		public uint ZpgLYwLqKYpEP;

		public string qsCDvptnkruEE = string.Empty;

		public int JtgARDDthxKJo;

		public int vGdgvYWznPF;

		public ulong ficBzHJzaQLfXz;

		public ulong mgzmyxuOuitL;

		public uint zwZoBRLfxYpnuC;

		public qaODESWiTbucuT(IntPtr intptr_0)
		{
			zwZoBRLfxYpnuC = (uint)Marshal.ReadInt32(intptr_0);
			ficBzHJzaQLfXz = (ulong)Marshal.ReadInt64(intptr_0, 8);
			mgzmyxuOuitL = (ulong)Marshal.ReadInt64(intptr_0, 16);
			ZpgLYwLqKYpEP = (uint)Marshal.ReadInt32(intptr_0, 52);
			JtgARDDthxKJo = Marshal.ReadInt16(intptr_0, 56);
			vGdgvYWznPF = Marshal.ReadInt16(intptr_0, 58);
			qsCDvptnkruEE = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + vGdgvYWznPF), JtgARDDthxKJo / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr vsmVXGItrYhia, out oHiWVpsXirkRsp JXIEtRWjhfis);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr VBiKmDarQdnygWN);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr KCnHrZmVibRDNLJK, uint qwviYNXySUzB, IntPtr RlOfqWbcmBw, int DyavtmshUHeF, out YJbfFOdhEoGT sZqxqKqZLyK, int aksVxQIdlzozPk, out uint IVYxvjbDrMzZN, IntPtr IlKwEBCxCiquA);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr veGjaQJttYSl, uint aLJxOMHkRa, IntPtr kFqpxnUixga, int thgoiSPlYsbo, IntPtr poVeaovtyWAl, int PNJlDHBfAby, out uint ikIFYvehrRKs, IntPtr fqCnUKxXzZNYy);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
