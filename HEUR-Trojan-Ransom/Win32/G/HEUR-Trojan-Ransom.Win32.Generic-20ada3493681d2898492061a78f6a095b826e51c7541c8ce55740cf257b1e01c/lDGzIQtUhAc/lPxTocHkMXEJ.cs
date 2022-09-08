using System;
using System.Runtime.InteropServices;

namespace lDGzIQtUhAc;

public class lPxTocHkMXEJ
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct IuzzDrMiMGNEdWSG
	{
		public uint VgIEHeNizxNv;

		public jPToEJgFkINlgKm PVTEirVJqwMJFG;

		public jPToEJgFkINlgKm opoMJfvPYHFliX;

		public jPToEJgFkINlgKm pslGugXjcBI;

		public uint NeArtckzLaPDF;

		public uint DVEUgFtrjWS;

		public uint yvTyniHaUH;

		public uint yuYvsVvyzGuxD;

		public uint yCCAzsiGYUk;

		public uint dwInPgGGDHH;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct jPToEJgFkINlgKm
	{
		public uint UlGuPLIraiYl;

		public uint KZWBRzFnnhI;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct AgReCDYgLAq
	{
		public ulong OYOnouWsIR;

		public long AbPiegrqEm;

		public long sIVfItPLTUm;

		public long KbattHKmPKyUd;

		public long NZpSmgaxrm;

		public ulong yVIiUGbgdzMfLKa;

		public ulong FcthxoxNvGd;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct CwHEXXYqDEFhu
	{
		public ulong zMYLvRBfgyEuCZ;

		public long cgaFxQiJnSCX;

		public long zMUiLjxMydvt;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MHGsrIhBcUNEtxP
	{
		public ulong yVIiUGbgdzMfLKa;

		public ulong FcthxoxNvGd;
	}

	public class PTCLRIOwzzeki
	{
		private const int viOKmQBNySW = 8;

		private const int DHISbuXpyoXF = 16;

		private const int gjzmWYhYZrY = 52;

		private const int CUzcXWhKXJYkhi = 56;

		private const int AmXeGaosJl = 58;

		public uint VgIEHeNizxNv;

		public string oGFFSqKhoMj = string.Empty;

		public int YvynHvimtV;

		public int pkCIlOOnnGEbI;

		public ulong OCzfQkhzAQW;

		public ulong UoSgXcYFBFs;

		public uint npFuHbZgbobLNmtr;

		public PTCLRIOwzzeki(IntPtr p)
		{
			npFuHbZgbobLNmtr = (uint)Marshal.ReadInt32(p);
			OCzfQkhzAQW = (ulong)Marshal.ReadInt64(p, 8);
			UoSgXcYFBFs = (ulong)Marshal.ReadInt64(p, 16);
			VgIEHeNizxNv = (uint)Marshal.ReadInt32(p, 52);
			YvynHvimtV = Marshal.ReadInt16(p, 56);
			pkCIlOOnnGEbI = Marshal.ReadInt16(p, 58);
			oGFFSqKhoMj = Marshal.PtrToStringUni(new IntPtr(p.ToInt32() + pkCIlOOnnGEbI), YvynHvimtV / 2);
		}
	}

	public const uint KllnqJaYBQM = 2147483648u;

	public const uint nfglkMMCSDLf = 1073741824u;

	public const uint XBwAwgZizySZ = 1u;

	public const uint GdMQyyhXdXCnIV = 2u;

	public const uint ZwBnuKBJfaVOxBU = 16u;

	public const uint uptmeJVLrRxB = 3u;

	public const uint UWhKQcENSHzVwj = 33554432u;

	public const int ucKqcCrkpCUY = -1;

	public const uint quVplkTfHxihtl = 590068u;

	public const uint rGgENkawvJIz = 590003u;

	public const uint FYCrjNFZrJ = 590055u;

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string DGhOyGZhOHgHe, uint jawhfxCMtWXjxR, uint TshDHQIKyMyyyl, IntPtr hHWIFsOHzVAMZZ, uint iMUYbkrhwxQpEq, uint dJnDRJhohVJWD, IntPtr PinQWTSWxyH);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr rGXhqvjzWBOoqPb, out IuzzDrMiMGNEdWSG IEgkWwWbVZIAp);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr FrHciXvBeztsz);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr YXjLaRGgJYMz, uint XwkuPpXgQxYVFRK, IntPtr uytSjpfPHbSXCc, int kCgTEqhFZW, out AgReCDYgLAq GzqCQcbfIw, int dvciwXxESVn, out uint YLmsmXQwaVcp, IntPtr SVtOjkJdkfw);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr rreugQdZPsOP, uint qgYCLEnIerl, IntPtr BUwUTmlVIAvA, int TUYriNZOTYCh, IntPtr cOurASCuiQAA, int LtfZcHoARbdNRti, out uint sTdponHqpeTtoYm, IntPtr zWHFVDuoiGM);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr nStiUVOLjOXkmM, int qQEcAKJBGEwYu);
}
