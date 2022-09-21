using System;
using System.Runtime.InteropServices;

namespace oCAeNBwRVx;

public sealed class EQpynYbwcSokms
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct IHmqieGAINJa
	{
		public uint HYkdBcHspvlbdO;

		public mHRmegAwwaQBUb alJxSlZsrZs;

		public mHRmegAwwaQBUb ZnCWPqWwKdB;

		public mHRmegAwwaQBUb nsoHuVZZkizzV;

		public uint eNBFTGtWERIlhz;

		public uint pnBHPPlGHJqyXt;

		public uint dvxofuSUeOkFlz;

		public uint sPrKRXfCuBnmQD;

		public uint awpNqvOlBBZhBzf;

		public uint AziXQfIAzUPW;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct mHRmegAwwaQBUb
	{
		public uint QFOpkhyCMXyX;

		public uint MIUBxfWUhHWVQlxKm;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct vKclxHctoLQi
	{
		public ulong HiJCRVTElZDC;

		public long ENHUpWYeErdkeUcs;

		public long GMpyUnIuAsRF;

		public long mVcYoPORglKSHDF;

		public long QJnhotVGKCri;

		public ulong TaQiFrOFcqXr;

		public ulong CLqLYFmfGfa;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct GNposVSuwKN
	{
		public ulong iOupzefTrj;

		public long qCDuHnHLXMtCtI;

		public long aZhxASoKKRx;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ZnYCVHFDMzu
	{
		public ulong TaQiFrOFcqXr;

		public ulong CLqLYFmfGfa;
	}

	public sealed class vSnhFSRWKNUOh
	{
		public uint HYkdBcHspvlbdO;

		public string yJrsHbiUVDkBv = string.Empty;

		public int vJobUKFjclFBXH;

		public int bnPlXymYCP;

		public ulong WtmPgfqEqMtp;

		public ulong gkNuhULpXIQL;

		public uint CAHPeHntBfN;

		public vSnhFSRWKNUOh(IntPtr intptr_0)
		{
			CAHPeHntBfN = (uint)Marshal.ReadInt32(intptr_0);
			WtmPgfqEqMtp = (ulong)Marshal.ReadInt64(intptr_0, 8);
			gkNuhULpXIQL = (ulong)Marshal.ReadInt64(intptr_0, 16);
			HYkdBcHspvlbdO = (uint)Marshal.ReadInt32(intptr_0, 52);
			vJobUKFjclFBXH = Marshal.ReadInt16(intptr_0, 56);
			bnPlXymYCP = Marshal.ReadInt16(intptr_0, 58);
			yJrsHbiUVDkBv = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + bnPlXymYCP), vJobUKFjclFBXH / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr IUrUHMoaSNmkQxO, out IHmqieGAINJa qHKbidvqgUWfVf);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr FVHBmQQQmg);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr NaVUcRRJvfBBh, uint TdAzmOoyXYbzc, IntPtr JdecfhcSMWZB, int AdUxTBcBSfs, out vKclxHctoLQi DzZHIejwccOtoz, int PhCDehRrfRaAlM, out uint EGMALOzxwb, IntPtr XHGGiQnaikUfxm);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr dWatfnZoqx, uint iaDiwlxRVrV, IntPtr BKTCAEQFMOw, int mTrjNbgLquUV, IntPtr ptfvaXqsQt, int muIXyrHawi, out uint rBqCyLWUiFz, IntPtr KaqmBIqKZa);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
