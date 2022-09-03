using System;
using System.Runtime.InteropServices;

namespace eZkFrthrrFwCL;

public sealed class IhRxDiuDyxSRte
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct azhXJjrFTTha
	{
		public uint ViATzxiPlJra;

		public XFuUClaLXNSZd kLnDTRlGVmKtjT;

		public XFuUClaLXNSZd NXMLOvheHV;

		public XFuUClaLXNSZd iAfzWFpWQnly;

		public uint EeWIobrYlVa;

		public uint QgnWUhFwvo;

		public uint tvZMpceXZpBEwo;

		public uint mepBqIFdfHGCzgO;

		public uint gMLktzYylXupVtz;

		public uint aELFWLpPvUUJVIa;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct XFuUClaLXNSZd
	{
		public uint mVnocVZIBjnfvU;

		public uint uphGsfqjcImmY;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct tXfLZQUTQZsqq
	{
		public ulong PFvXTtCDexWP;

		public long NLWOYSkWVBzxNJ;

		public long sLsELvxHgsksA;

		public long GbmmkDxyOCvDDl;

		public long WqaCNBCoTZWshp;

		public ulong kuFDpsORroo;

		public ulong nyCITIeGUJIeKK;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MraCNbopUXp
	{
		public ulong wYiqJmGIruxoF;

		public long tiziFbpnTLqJiCQg;

		public long JvRytqTEAqdPl;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct lzTPTysqIiu
	{
		public ulong kuFDpsORroo;

		public ulong nyCITIeGUJIeKK;
	}

	public sealed class AwzyqYXxoWt
	{
		public uint ViATzxiPlJra;

		public string FdEbcSDmJZeVZu = string.Empty;

		public int KfauAXuSsxvFz;

		public int RiptpaBDwopFXKv;

		public ulong QlRwoqyaKgMok;

		public ulong qRoovJRgXAUf;

		public uint ijVsedXHkZ;

		public AwzyqYXxoWt(IntPtr intptr_0)
		{
			ijVsedXHkZ = (uint)Marshal.ReadInt32(intptr_0);
			QlRwoqyaKgMok = (ulong)Marshal.ReadInt64(intptr_0, 8);
			qRoovJRgXAUf = (ulong)Marshal.ReadInt64(intptr_0, 16);
			ViATzxiPlJra = (uint)Marshal.ReadInt32(intptr_0, 52);
			KfauAXuSsxvFz = Marshal.ReadInt16(intptr_0, 56);
			RiptpaBDwopFXKv = Marshal.ReadInt16(intptr_0, 58);
			FdEbcSDmJZeVZu = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + RiptpaBDwopFXKv), KfauAXuSsxvFz / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr zzWqxVgWqKsd, out azhXJjrFTTha XtuKaTccPJbFz);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr DSlxklqvXEvQLeS);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr vlyedxJDOBNRmvkp, uint jUgldXTLwOcC, IntPtr pQNQOhxpXPsPF, int QWIOBbmaFDTrE, out tXfLZQUTQZsqq EmObRnDfDnj, int CqkWmHLVYzGXX, out uint jtffXMNusUFOix, IntPtr uGGBzYXiVTje);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr tSqGmhACUzEVMz, uint eIdIPHigLLRjnHpp, IntPtr dtkBodDaRyMo, int LsHMNUhdeV, IntPtr STYtngvCkiymb, int LBsldZePpkwpwJVq, out uint uaYPltplhdxWs, IntPtr kaUKPBhGIgAkmmRG);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
