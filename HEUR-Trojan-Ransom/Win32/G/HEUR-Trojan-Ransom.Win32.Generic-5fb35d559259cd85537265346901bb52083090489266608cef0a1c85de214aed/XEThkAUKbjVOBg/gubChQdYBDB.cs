using System;
using System.Runtime.InteropServices;

namespace XEThkAUKbjVOBg;

public sealed class gubChQdYBDB
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct oHdjhkOVwGCCM
	{
		public uint nHUOPrUXrEpmwBcGl;

		public PaxwNBYozXKtq gahAvNxhZpMM;

		public PaxwNBYozXKtq jROfPduYiP;

		public PaxwNBYozXKtq RuXoWxoBnHFC;

		public uint FTKhDByFdCZfzgl;

		public uint pROyoLsOqYE;

		public uint jIWfHXxUQnD;

		public uint wAgDhKkIWP;

		public uint jfzytndjZE;

		public uint YRgLBeSzbVgVN;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct PaxwNBYozXKtq
	{
		public uint kIiCOELJxjXzyvxa;

		public uint OGBMMDHxrVRxsWg;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct TpusGaAGVrxWe
	{
		public ulong QCSKWDsWEayIo;

		public long tzWAOZctkTFmW;

		public long CTqOhXgcvly;

		public long jTUOXUqYynfYO;

		public long roClnUlDFDHJ;

		public ulong UYagRyoCHvS;

		public ulong WKVendYxiSefVF;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct chuFpyNmfWA
	{
		public ulong xjucYlkJcXXuj;

		public long aDoTuHOXMgqOWUyj;

		public long aufmEwJxDU;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct iBoDdXKSIpod
	{
		public ulong UYagRyoCHvS;

		public ulong WKVendYxiSefVF;
	}

	public sealed class XgQhJUzYoH
	{
		public uint nHUOPrUXrEpmwBcGl;

		public string IpZCOYdfewCC = string.Empty;

		public int sALlnxtuzySX;

		public int UjBFFGTlSfRPDDl;

		public ulong QRDEQjwcfPYiOv;

		public ulong rWHQYsfdUEFeY;

		public uint RETyOirGiJLa;

		public XgQhJUzYoH(IntPtr intptr_0)
		{
			RETyOirGiJLa = (uint)Marshal.ReadInt32(intptr_0);
			QRDEQjwcfPYiOv = (ulong)Marshal.ReadInt64(intptr_0, 8);
			rWHQYsfdUEFeY = (ulong)Marshal.ReadInt64(intptr_0, 16);
			nHUOPrUXrEpmwBcGl = (uint)Marshal.ReadInt32(intptr_0, 52);
			sALlnxtuzySX = Marshal.ReadInt16(intptr_0, 56);
			UjBFFGTlSfRPDDl = Marshal.ReadInt16(intptr_0, 58);
			IpZCOYdfewCC = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + UjBFFGTlSfRPDDl), sALlnxtuzySX / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr bLTKuHnxooghMm, out oHdjhkOVwGCCM uECpPAnzrEwJI);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr jytJlIlbKH);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr gyuoIBneKYK, uint DAwpKzxUciG, IntPtr wDSsZgcQgI, int tOaaAsFrRzHz, out TpusGaAGVrxWe sXZiNWxwJD, int ObAfzeTyee, out uint GEplNUQIAknlQEDk, IntPtr CeUrXdQcKOaatz);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr YWCRxUOQOFQE, uint LyAWmGemxkOcr, IntPtr MqCWwDOqPSoM, int sFyvmtIDfAodWt, IntPtr hwOAXolROLyJ, int zQUsYHYpDEknFP, out uint ICxyPEsNKrBE, IntPtr itkASJkAKtY);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
