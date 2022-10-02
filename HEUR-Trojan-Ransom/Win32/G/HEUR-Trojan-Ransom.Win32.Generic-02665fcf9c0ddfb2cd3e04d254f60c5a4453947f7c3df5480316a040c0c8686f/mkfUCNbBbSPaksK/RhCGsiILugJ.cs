using System;
using System.Runtime.InteropServices;

namespace mkfUCNbBbSPaksK;

public sealed class RhCGsiILugJ
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct dqQOtajJhhVHb
	{
		public uint OKsyrsGPHVLpJ;

		public rRLsCjTmOKw mYYNFwGDPDwF;

		public rRLsCjTmOKw WoxmgdIkuQN;

		public rRLsCjTmOKw uQrMatZtBvzB;

		public uint cXdjRaewFCEq;

		public uint REVETvygPDmuam;

		public uint HmpeDbcDprJo;

		public uint ryvuqSfgNOd;

		public uint zwcIGAwIjiP;

		public uint VGKmCajlrKAH;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct rRLsCjTmOKw
	{
		public uint klyFidqqdusXY;

		public uint LBVijqkxjr;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct SvuIWiMIJxzOOR
	{
		public ulong KnOeSlTdSyho;

		public long HKTEWnTtmSGE;

		public long TBdbHrXEwZA;

		public long wJbaKirHXfx;

		public long YpFOhDcqOKWod;

		public ulong MvICPDkjWOLMpH;

		public ulong fYCTyVaFoeXoKuK;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct UjaLxSAEEK
	{
		public ulong alRCWMsZEA;

		public long FNWPEqqVCFenaLg;

		public long iqnHubBQMHeF;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct qUOnIFKHROCqOs
	{
		public ulong MvICPDkjWOLMpH;

		public ulong fYCTyVaFoeXoKuK;
	}

	public sealed class uDxFXuAcDLUA
	{
		public uint OKsyrsGPHVLpJ;

		public string FjRvGFCImpb = string.Empty;

		public int VWZlcEdUBNGUF;

		public int ZKBUXfgEPBaf;

		public ulong nnVzioTTvoEr;

		public ulong BHfGaerfFBG;

		public uint zGyBWezunBimFHR;

		public uDxFXuAcDLUA(IntPtr intptr_0)
		{
			zGyBWezunBimFHR = (uint)Marshal.ReadInt32(intptr_0);
			nnVzioTTvoEr = (ulong)Marshal.ReadInt64(intptr_0, 8);
			BHfGaerfFBG = (ulong)Marshal.ReadInt64(intptr_0, 16);
			OKsyrsGPHVLpJ = (uint)Marshal.ReadInt32(intptr_0, 52);
			VWZlcEdUBNGUF = Marshal.ReadInt16(intptr_0, 56);
			ZKBUXfgEPBaf = Marshal.ReadInt16(intptr_0, 58);
			FjRvGFCImpb = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + ZKBUXfgEPBaf), VWZlcEdUBNGUF / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr lDuVsAHqBKRVQjc, out dqQOtajJhhVHb FPKWuHZoSBTbMN);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr WvQJeuoPlAlZoUl);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr SjTVsitupwZ, uint JOLWxhxnmIc, IntPtr cZCuQPYbYESnPrX, int IhLfjAmeVe, out SvuIWiMIJxzOOR ZQbzQdXSOttm, int NIuLJnOLxAnPT, out uint BFJRyzeyfm, IntPtr dPGElftmij);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr ZdVzLFCEQbldc, uint bsuBlqNKQF, IntPtr VlJsVRSfiVUlirEx, int QzdPotmXGCtD, IntPtr nszCQcGkdGes, int GntFqNwsWeSbRjHJ, out uint GKtmRiHOyOA, IntPtr CfxQBcaSRJsdOzg);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
