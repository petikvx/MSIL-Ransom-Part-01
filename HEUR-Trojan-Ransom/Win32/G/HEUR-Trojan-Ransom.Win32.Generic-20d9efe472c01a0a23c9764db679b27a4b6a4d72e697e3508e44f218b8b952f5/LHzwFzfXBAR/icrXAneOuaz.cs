using System;
using System.Runtime.InteropServices;

namespace LHzwFzfXBAR;

public sealed class icrXAneOuaz
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct aRrBQITLOyzGkD
	{
		public uint VNSQNSdbZH;

		public mSufnmUFEnlQa qXPZNDFsJWpTi;

		public mSufnmUFEnlQa GmXPiiQPIRio;

		public mSufnmUFEnlQa gCAYupnyrdc;

		public uint mBRfTGJcWOEE;

		public uint ntVHmroRWwajUoI;

		public uint VdxxtzlAmQ;

		public uint QVyWaYcNCANANjkO;

		public uint ugVDxCdabCXRy;

		public uint yCxPSUXdrew;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct mSufnmUFEnlQa
	{
		public uint ZDQKaihkhIwT;

		public uint Imruzbprafjrfo;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct NSYgDUVmlYH
	{
		public ulong pQcLnfUnZcTxgP;

		public long FjzNVgRhSwLUH;

		public long IvaTJgSBll;

		public long yRIXPBLFCUwrv;

		public long CfvfLNCkzCp;

		public ulong bDefbRCBjGYWgku;

		public ulong VMENVFsSAHghQel;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HfktFvXfDB
	{
		public ulong MZdUKzgvlghV;

		public long vhILeRSmMdR;

		public long tAtfqyHxoarMtE;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct VWLiYYudnwMnjv
	{
		public ulong bDefbRCBjGYWgku;

		public ulong VMENVFsSAHghQel;
	}

	public sealed class ZKtlOAFYlK
	{
		public uint VNSQNSdbZH;

		public string PLCSRoQaWtE = string.Empty;

		public int ALcUUMCnohaVELp;

		public int TcFxXQeNnrdxd;

		public ulong BFcFxbpPACasV;

		public ulong YdCVvjlyJloKt;

		public uint VOAOrKwjfRY;

		public ZKtlOAFYlK(IntPtr intptr_0)
		{
			VOAOrKwjfRY = (uint)Marshal.ReadInt32(intptr_0);
			BFcFxbpPACasV = (ulong)Marshal.ReadInt64(intptr_0, 8);
			YdCVvjlyJloKt = (ulong)Marshal.ReadInt64(intptr_0, 16);
			VNSQNSdbZH = (uint)Marshal.ReadInt32(intptr_0, 52);
			ALcUUMCnohaVELp = Marshal.ReadInt16(intptr_0, 56);
			TcFxXQeNnrdxd = Marshal.ReadInt16(intptr_0, 58);
			PLCSRoQaWtE = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + TcFxXQeNnrdxd), ALcUUMCnohaVELp / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr RJbnmoBRufZpvm, out aRrBQITLOyzGkD xMsDWEIdpSJ);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr CoEBiVhADOAiZ);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr akzIVDmwREjYC, uint QqgmzOqZkEFMSlW, IntPtr ElgQXhqxJTZmf, int lIZXfwocWTAVlBabf, out NSYgDUVmlYH OhQGZLvAbewtB, int VajOzwLpGmsZ, out uint supnCSYJASR, IntPtr LhnNWBHNgHtx);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr iaPVEWwDJZDam, uint KzVHgdyUuIPv, IntPtr xTzQmixrxhxr, int rLyVBgcwbzoJq, IntPtr uBzNhPiwewWKpYk, int ZWbVSUtahhGjLq, out uint ZBzTxbXREonI, IntPtr mQBNdsZBUEUOM);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
