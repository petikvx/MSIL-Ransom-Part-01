using System;
using System.Runtime.InteropServices;

namespace pLpOiMPKFBqsYEtBP;

public sealed class idAtkyEmuMh
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct aCCyXrIDNIIA
	{
		public uint WcoObavgWpzA;

		public levXmzJazS EVicHLqPiuDMB;

		public levXmzJazS RaXYSwBweXPS;

		public levXmzJazS TeQgeeuPurH;

		public uint SVeXqeoqHWNrb;

		public uint RIxwjzVFYIK;

		public uint ggosuSELXdUQD;

		public uint bHgFDuTRcKPccc;

		public uint ZEGoiZNEfT;

		public uint yCfvgeWvXkCGvUN;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct levXmzJazS
	{
		public uint JOjNrgDofpKI;

		public uint TEtrFWyBgPz;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct tciTSHdqCSk
	{
		public ulong gzHtvCPMoDUT;

		public long sRNnJfHkOnzQ;

		public long QIQPFlEFaigCkW;

		public long YVSanUmAuYD;

		public long zqWDydUswUEik;

		public ulong aVdWFhTFwZ;

		public ulong CTyZxJKAuSZiZ;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct zivfMtfkAVIeL
	{
		public ulong HybLTfNPnza;

		public long CiPuhbXPpdLZn;

		public long OmHIjiLmeRru;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct nMYQqzFSUhco
	{
		public ulong aVdWFhTFwZ;

		public ulong CTyZxJKAuSZiZ;
	}

	public sealed class xbHcFvskYjo
	{
		public uint WcoObavgWpzA;

		public string MzTuIXetSeOX = string.Empty;

		public int yCoLoQdazW;

		public int uzeLaWapYG;

		public ulong ZTnLhzRlRY;

		public ulong NMeqFFAvHc;

		public uint CoUKeocLqXUlCDDW;

		public xbHcFvskYjo(IntPtr intptr_0)
		{
			CoUKeocLqXUlCDDW = (uint)Marshal.ReadInt32(intptr_0);
			ZTnLhzRlRY = (ulong)Marshal.ReadInt64(intptr_0, 8);
			NMeqFFAvHc = (ulong)Marshal.ReadInt64(intptr_0, 16);
			WcoObavgWpzA = (uint)Marshal.ReadInt32(intptr_0, 52);
			yCoLoQdazW = Marshal.ReadInt16(intptr_0, 56);
			uzeLaWapYG = Marshal.ReadInt16(intptr_0, 58);
			MzTuIXetSeOX = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + uzeLaWapYG), yCoLoQdazW / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr OMafYZRPzmfjFZ, out aCCyXrIDNIIA zTubMuNrkYnh);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr rtIQkKSRVKro);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr tuyUCUjOFBJ, uint tGzmZUPrZnq, IntPtr IGJjynxIUTexng, int kHQMnmEALFdSkV, out tciTSHdqCSk DPUteoODapDwKm, int IaGEhDRGTSk, out uint DryxggKKxgYt, IntPtr dfFeujIOiSxUA);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr myWwdjqRYtsVT, uint pdeKrjKRCCW, IntPtr oLJjUsgrSCPL, int OqPKYrvenXTeR, IntPtr UZZuhsYPCroF, int NpWBCOsYLbDsY, out uint QmDdVGubpBHMt, IntPtr ZvGjTvrgkNBR);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
