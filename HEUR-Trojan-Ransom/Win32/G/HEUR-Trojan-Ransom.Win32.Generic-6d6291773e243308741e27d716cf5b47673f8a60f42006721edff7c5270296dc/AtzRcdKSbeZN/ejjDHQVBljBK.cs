using System;
using System.Runtime.InteropServices;

namespace AtzRcdKSbeZN;

public class ejjDHQVBljBK
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct vNGputBbgLPFU
	{
		public uint sVfFLLaUXvGt;

		public nEZeSykTwL ySBZRbQxGTSK;

		public nEZeSykTwL pqjoqzqCsCew;

		public nEZeSykTwL MmHAWlERME;

		public uint FPmVDMsOgOQutz;

		public uint rmDObbnMCCUhlguH;

		public uint iXByLXZPpzvlUKOU;

		public uint auLKXZILLOp;

		public uint hXIkacAeaImopkFr;

		public uint bFPOYqHeYXYJ;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct nEZeSykTwL
	{
		public uint uJckUDlkNHDK;

		public uint iobqrEwvbCWCEm;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct JJIlQqSChVrq
	{
		public ulong pKWDOoONiAnaMZY;

		public long TUJjCQqTNFAUCCr;

		public long RlDctbAmpYIi;

		public long lNHvQOiJGRwRzu;

		public long QNHVCedqWRloLvEt;

		public ulong rscnuxdDYPP;

		public ulong RxVXarpyAZqeBqe;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct WtDFfGXNoQvgAQp
	{
		public ulong fzjhQLuUDDnZH;

		public long tzNhdirWqRvi;

		public long hUrLfkhcxFARbb;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ydVHVteKNsEr
	{
		public ulong rscnuxdDYPP;

		public ulong RxVXarpyAZqeBqe;
	}

	public class kMOyTtyccLuRjMc
	{
		private const int krmlkwKssfr = 8;

		private const int xDZqjEbqso = 16;

		private const int SZlsplGnwqNI = 52;

		private const int FseXDkFCwYOTe = 56;

		private const int odPMKdVgqZN = 58;

		public uint sVfFLLaUXvGt;

		public string VwakZWfOhV = string.Empty;

		public int HOzToYavmmjhS;

		public int lTeDTlnhCI;

		public ulong sJbnPwtZvtog;

		public ulong qqxtkQWcSunmizY;

		public uint SwKGHxuHNaB;

		public kMOyTtyccLuRjMc(IntPtr p)
		{
			SwKGHxuHNaB = (uint)Marshal.ReadInt32(p);
			sJbnPwtZvtog = (ulong)Marshal.ReadInt64(p, 8);
			qqxtkQWcSunmizY = (ulong)Marshal.ReadInt64(p, 16);
			sVfFLLaUXvGt = (uint)Marshal.ReadInt32(p, 52);
			HOzToYavmmjhS = Marshal.ReadInt16(p, 56);
			lTeDTlnhCI = Marshal.ReadInt16(p, 58);
			VwakZWfOhV = Marshal.PtrToStringUni(new IntPtr(p.ToInt32() + lTeDTlnhCI), HOzToYavmmjhS / 2);
		}
	}

	public const uint qYPckfnSQsgumd = 2147483648u;

	public const uint jyoBrTheTME = 1073741824u;

	public const uint QSCRNOlxXzOHa = 1u;

	public const uint XftpwCpqPfHh = 2u;

	public const uint pTJjCHOHEZD = 16u;

	public const uint OyBTKDTSPsHX = 3u;

	public const uint ndcrPZccqRORp = 33554432u;

	public const int WpugXLeVOmsVf = -1;

	public const uint xVISemUXMWdhMC = 590068u;

	public const uint qpNaBsucyofIHOw = 590003u;

	public const uint hHuVdRVaLDKKtv = 590055u;

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string NRHtIlLHOMxLn, uint OXYHVijvPeCYRzbSWc, uint rLZzpPlDcjqi, IntPtr WEVOvlGmlJJ, uint MyyDUrXdsORsfiE, uint ppJLWnlPxiO, IntPtr sskUYWCfvbs);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr aTatjLmwJdF, out vNGputBbgLPFU tXNyLxDChNgQ);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr myCYrmMrSHJ);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr jtZJFrRImjVQ, uint TTsQslQNEzfEszNVJh, IntPtr MPsJvxXjcVabqmn, int WpWhjtGokDjn, out JJIlQqSChVrq tWKJcPKvRtKRE, int SfppEnvDylJhS, out uint WRwxtPRjliK, IntPtr natObartGosqKvO);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr NevSSkgdQUpWe, uint kwPIeHWFGPM, IntPtr oRfvCagBDTpV, int cDlqCVYQISYHsQ, IntPtr kMvBaErKEd, int EadNGzWxUWCl, out uint EBOfdODCJuTHrBQu, IntPtr TJtYdGoMRMqqQDRE);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr AQlEDWSWzAdgJV, int MMoRxHBCWvknrB);
}
