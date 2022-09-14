using System;
using System.Runtime.InteropServices;

namespace XmVNSVPzUwATMS;

public sealed class STEMjHlNYc
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MuTcAgRDAnHNUxy
	{
		public uint LJvjOShXDc;

		public NFlPYUvImHQfFAuW ZEEMKpwTWEocWY;

		public NFlPYUvImHQfFAuW OTthsBPMSMdBco;

		public NFlPYUvImHQfFAuW LJBipOeKgXvlDv;

		public uint TJSBzPBjwVd;

		public uint fuRaSLvzCnDRh;

		public uint SmmvBkBnrVnX;

		public uint GkzDXGEihSmS;

		public uint QlJYMaQBKOSDX;

		public uint oFQGgccFOXLNn;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct NFlPYUvImHQfFAuW
	{
		public uint EUdLwbeAaMWB;

		public uint MznHbZJvSkdt;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct UnOsVnnGMoq
	{
		public ulong FmrwAfrudmqsPsZi;

		public long fLIUyBtpEfj;

		public long wizOtdLlaNgxi;

		public long kXXjzuvqsLV;

		public long elyEuqQdIby;

		public ulong EfphmoMNtVXuIm;

		public ulong njuDjKIolHjo;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct fNsNMpjOkyvc
	{
		public ulong SjGdCNZFzboXo;

		public long AnwLOtoSQmz;

		public long BABsYbTXPn;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct CizRIIOsoHSJrDb
	{
		public ulong EfphmoMNtVXuIm;

		public ulong njuDjKIolHjo;
	}

	public sealed class FYXPcsNiTYkqb
	{
		public uint LJvjOShXDc;

		public string toQbNbNaLAjJNt = string.Empty;

		public int RPhEgSHdlqvpWsY;

		public int cGgmhwPALjN;

		public ulong KRcxNYHUnXHOHo;

		public ulong hNewLeFEOnTF;

		public uint pAunGxMtfHH;

		public FYXPcsNiTYkqb(IntPtr intptr_0)
		{
			pAunGxMtfHH = (uint)Marshal.ReadInt32(intptr_0);
			KRcxNYHUnXHOHo = (ulong)Marshal.ReadInt64(intptr_0, 8);
			hNewLeFEOnTF = (ulong)Marshal.ReadInt64(intptr_0, 16);
			LJvjOShXDc = (uint)Marshal.ReadInt32(intptr_0, 52);
			RPhEgSHdlqvpWsY = Marshal.ReadInt16(intptr_0, 56);
			cGgmhwPALjN = Marshal.ReadInt16(intptr_0, 58);
			toQbNbNaLAjJNt = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + cGgmhwPALjN), RPhEgSHdlqvpWsY / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr HVLrEpOgTmoF, out MuTcAgRDAnHNUxy GeVsNNwFrmzfVbD);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr YzpUsQRhFpkc);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr afAsHJaYznElDMSb, uint BlurWNwrnPHzFa, IntPtr zHBpCMPsKBTxX, int KIDxFjguhoI, out UnOsVnnGMoq CdPbnMdOzLsIwS, int SUqGVeiiEgbJPx, out uint txBMOEDRoAzTbV, IntPtr qkVmBtVIFlMOO);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr gleiRtsoleg, uint rPsRMpKeShozz, IntPtr SAcqxPRApemXso, int bUrxmfsKpNPCJ, IntPtr kmMqIKoHhmI, int wpYJgvCjLSMdoQE, out uint FyacPFAfAWeL, IntPtr McDDJGWnJzHtMI);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
