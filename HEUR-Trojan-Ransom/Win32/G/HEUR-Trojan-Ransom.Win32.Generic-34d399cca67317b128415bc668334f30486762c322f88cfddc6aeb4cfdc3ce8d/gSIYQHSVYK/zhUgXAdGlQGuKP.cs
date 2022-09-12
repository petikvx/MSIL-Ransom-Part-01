using System;
using System.Runtime.InteropServices;

namespace gSIYQHSVYK;

public sealed class zhUgXAdGlQGuKP
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct azUFzPjEvMM
	{
		public uint YhqkbTzGTT;

		public QgieFZdTXkZ VvKFGtbQTwa;

		public QgieFZdTXkZ IsdLPPTHNKRUF;

		public QgieFZdTXkZ MEZCLVxeAkrp;

		public uint lsMydFlFrE;

		public uint vWCvSGDROjW;

		public uint hlTMUHYwiYIOh;

		public uint cdEPKpuznTqH;

		public uint VcYPdFGInQLH;

		public uint pAMgyICKviFPev;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct QgieFZdTXkZ
	{
		public uint gKnwpHjIIBbTO;

		public uint qplLoiJWIiw;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct zKCPTVkFkYocEK
	{
		public ulong xmFZnVdHmKpy;

		public long VBWnHnlNIeJfCB;

		public long FZHALDwsEzpJ;

		public long wCxAcXWflDvK;

		public long lTzryaJrpvD;

		public ulong uKtHHTkBHDG;

		public ulong EPfcGBSnuQCcV;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct IJAxwiMoErj
	{
		public ulong UMHicvypAUmKy;

		public long EClRaDcfTGqxl;

		public long tOmxBbmTeaPg;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct flDuZgMccjpL
	{
		public ulong uKtHHTkBHDG;

		public ulong EPfcGBSnuQCcV;
	}

	public sealed class dMFtAlMFtmk
	{
		public uint YhqkbTzGTT;

		public string MwFgUebNSEAa = string.Empty;

		public int ygIGwolzMusdJb;

		public int PSRzrmXSgJeA;

		public ulong RHrPkagKOOtWFzd;

		public ulong BemdrLekRoH;

		public uint DUMWozJHcCJGMEO;

		public dMFtAlMFtmk(IntPtr intptr_0)
		{
			DUMWozJHcCJGMEO = (uint)Marshal.ReadInt32(intptr_0);
			RHrPkagKOOtWFzd = (ulong)Marshal.ReadInt64(intptr_0, 8);
			BemdrLekRoH = (ulong)Marshal.ReadInt64(intptr_0, 16);
			YhqkbTzGTT = (uint)Marshal.ReadInt32(intptr_0, 52);
			ygIGwolzMusdJb = Marshal.ReadInt16(intptr_0, 56);
			PSRzrmXSgJeA = Marshal.ReadInt16(intptr_0, 58);
			MwFgUebNSEAa = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + PSRzrmXSgJeA), ygIGwolzMusdJb / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr dcpTYuijcjPWnFE, out azUFzPjEvMM TZAySlcErtjN);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr XjTVBGhcWzOpK);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr MCyafRBhIvu, uint kLahrMBLCgFmTs, IntPtr oFOqaUZCzKEpA, int iWeBGrNcmxZV, out zKCPTVkFkYocEK xHpdYjdHYFeV, int PhyMOKghGM, out uint dYfpecJSfjkVG, IntPtr bgVFykycuQtXLGO);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr tKMdqIDqNAlvV, uint GgYjGtDTGvzXRbU, IntPtr VZlidMufBrRj, int rEQpjeaOgvdVODl, IntPtr QpgtYnSuEqhS, int WhrxSyBwnYNyD, out uint lieMzSiLPDere, IntPtr kugQLXCUvgA);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
