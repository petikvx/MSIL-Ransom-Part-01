using System;
using System.Runtime.InteropServices;

namespace YfWvQVVobAAH;

public sealed class uHtYsLEINcMwGV
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MvwrRnclGz
	{
		public uint chkgsguaUgn;

		public imQZFNGAlhUjJ xUHTgJvbMXC;

		public imQZFNGAlhUjJ aZjiGxOtrT;

		public imQZFNGAlhUjJ jGphRTPioRa;

		public uint wGXKjkuvfXvUhRl;

		public uint QVBKjpaWHuhHs;

		public uint yphaYlDvmEUVo;

		public uint TmWTbGNQJdZDWS;

		public uint wGYIwASvlvK;

		public uint VJbUrzDJzJYd;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct imQZFNGAlhUjJ
	{
		public uint johQtsZVNDRDs;

		public uint qSYZYFkQuTAzXK;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HwejDoOaauYJL
	{
		public ulong LZKYbuwNZn;

		public long YUEVQJQJQzhBQR;

		public long qzTOPxgQcRjX;

		public long DqeWPwkmIsf;

		public long byqypukrcuvK;

		public ulong rPPZpqDgLpr;

		public ulong RHujjEhuoit;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct yoQFBEKLEwYF
	{
		public ulong PLROWbkMhTC;

		public long NDqVvQHckp;

		public long KGpKQGSLhZX;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct AaEqAdioueEaA
	{
		public ulong rPPZpqDgLpr;

		public ulong RHujjEhuoit;
	}

	public sealed class JIJTZBiNfxWSpnx
	{
		public uint chkgsguaUgn;

		public string dOUqlnNEGvD = string.Empty;

		public int VHzMhyiNDjzP;

		public int MKqNmmiUbiOPrO;

		public ulong xqIsxxXvkKHhpTe;

		public ulong feftdaZSFhtS;

		public uint oEHuNTEqygKHBDI;

		public JIJTZBiNfxWSpnx(IntPtr intptr_0)
		{
			oEHuNTEqygKHBDI = (uint)Marshal.ReadInt32(intptr_0);
			xqIsxxXvkKHhpTe = (ulong)Marshal.ReadInt64(intptr_0, 8);
			feftdaZSFhtS = (ulong)Marshal.ReadInt64(intptr_0, 16);
			chkgsguaUgn = (uint)Marshal.ReadInt32(intptr_0, 52);
			VHzMhyiNDjzP = Marshal.ReadInt16(intptr_0, 56);
			MKqNmmiUbiOPrO = Marshal.ReadInt16(intptr_0, 58);
			dOUqlnNEGvD = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + MKqNmmiUbiOPrO), VHzMhyiNDjzP / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr ACqDYKvmHNQrsfbW, out MvwrRnclGz ojgckAZbHAoVE);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr QMBeyyDSllz);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr EcUUWLmyqxUxX, uint FVTouGdvBsFn, IntPtr CcZDuieYNyz, int abPtfFCmDlCKbwY, out HwejDoOaauYJL gddCTAZTTAp, int iYvHRSCWKMt, out uint BLbXJDjZNSN, IntPtr PrZaVnVpqZf);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr EEWPWtvfJLQFPg, uint nVMXOJXmuRom, IntPtr AXPqzbQBXH, int UgEAZQLOPGoz, IntPtr YUfPtrlcWoki, int swIIVSfmSszLnM, out uint egxfKBxpsCyXP, IntPtr hGuyNDRojoCO);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
