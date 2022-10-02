using System;
using System.Runtime.InteropServices;

namespace XucgddUxXfI;

public sealed class bmquIkEwEpEOL
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct xoIvabctPqd
	{
		public uint ofPDrxfWpjLbGLGz;

		public rYAmEdHtfic xxBbpWekZWp;

		public rYAmEdHtfic QhjihusOpfKAgjVS;

		public rYAmEdHtfic MSwFwtYaQGQ;

		public uint DUHbjUdTDYPHc;

		public uint cBShrkJHVZga;

		public uint CCGxWBKjBFEdKAi;

		public uint hDOLbgWxrwcIu;

		public uint gfWEnyEsbmwDN;

		public uint tgPlztpawXs;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct rYAmEdHtfic
	{
		public uint pUMpXMGsqWuQDWP;

		public uint XDdlDTkWSEgk;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct TrMxKjIHnLj
	{
		public ulong yRhVFEylKOp;

		public long sHuzRfSaSlyxK;

		public long vPIsFRIZhLZzXT;

		public long qrNkfpvCKpM;

		public long MkQTkyjLbt;

		public ulong ObbecfcxooJgPOwPr;

		public ulong vRMAbLveSlJuK;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct hYDtRlkGXWAJfUa
	{
		public ulong rtLSDFiCmAWbNuTw;

		public long bgnwmPFjMALt;

		public long xDzTgbmKQPMmUi;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct iSLVPaewudDGJ
	{
		public ulong ObbecfcxooJgPOwPr;

		public ulong vRMAbLveSlJuK;
	}

	public sealed class uBVCUKyWIDiNNY
	{
		public uint ofPDrxfWpjLbGLGz;

		public string hYqWYCJHXZctLnp = string.Empty;

		public int KDmvaCCWvc;

		public int VLyLhwaBDfreu;

		public ulong keGvbwZGujwwZ;

		public ulong OdUiyOTopCZFYvGl;

		public uint VIWvrIUBrNGzjHQsp;

		public uBVCUKyWIDiNNY(IntPtr intptr_0)
		{
			VIWvrIUBrNGzjHQsp = (uint)Marshal.ReadInt32(intptr_0);
			keGvbwZGujwwZ = (ulong)Marshal.ReadInt64(intptr_0, 8);
			OdUiyOTopCZFYvGl = (ulong)Marshal.ReadInt64(intptr_0, 16);
			ofPDrxfWpjLbGLGz = (uint)Marshal.ReadInt32(intptr_0, 52);
			KDmvaCCWvc = Marshal.ReadInt16(intptr_0, 56);
			VLyLhwaBDfreu = Marshal.ReadInt16(intptr_0, 58);
			hYqWYCJHXZctLnp = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + VLyLhwaBDfreu), KDmvaCCWvc / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr DtlGTLCiNUmoK, out xoIvabctPqd TGrLpLRFSbNw);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr bzRGbSUXytAn);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr FFIYKmrhNju, uint yOLnwhrBXeHP, IntPtr YOVqpfSNmFgt, int vtqKuYwHMaN, out TrMxKjIHnLj thVmiBRJxTQRzn, int XPMqZVZiTzSgT, out uint fqqekfCnmNCxD, IntPtr YwIhZBvaJOxgSbK);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr lYNUaHftrTy, uint rDviSHPqBcRTC, IntPtr ciDQvZbprrp, int UAYshNagyIl, IntPtr NxQLQAcKhdrhmxd, int vDSWSdztwfl, out uint RzdXIZVhAWiMbV, IntPtr MurdHMQQspoTT);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
