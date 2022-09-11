using System;
using System.Runtime.InteropServices;

namespace PAvKfaIFZl;

public sealed class WtlVoBgNqjipbDL
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct VgdhfvFbUVA
	{
		public uint LUfkbeziSd;

		public FVVIMZuvJemkyX lNunDULqJNwj;

		public FVVIMZuvJemkyX TDCkGQZVpDrT;

		public FVVIMZuvJemkyX XfyhFlnzXhlr;

		public uint LRgPSFWyVYiZu;

		public uint hPUSiXbuJax;

		public uint vbUzAUVrLvQ;

		public uint oqrVexiGyQxg;

		public uint DlNFpQpnggHM;

		public uint jMdIfgfXKZQn;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct FVVIMZuvJemkyX
	{
		public uint yqCmZwTVHMp;

		public uint zBypSxypQjvL;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct mWQXPMYfvQy
	{
		public ulong VSndDSKbfJHaRxI;

		public long rBclttwzcAR;

		public long sabncygssewn;

		public long pNBBYrldHOJ;

		public long amWwIBakKIo;

		public ulong LHdJkwsUPsaU;

		public ulong bKoYMdsnFoD;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct IlOhtamJSJc
	{
		public ulong sBBUxMLmPSJAGT;

		public long bzawjjpNMLbD;

		public long pwjiOKnlBFLEsuo;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ZrPxKPDFhjtBWSO
	{
		public ulong LHdJkwsUPsaU;

		public ulong bKoYMdsnFoD;
	}

	public sealed class bbsMQUynbhF
	{
		public uint LUfkbeziSd;

		public string rSrtuFDJaoZnp = string.Empty;

		public int mQcUKHedSh;

		public int tkcOjSybwGtdv;

		public ulong IFXYkcfMcKavWN;

		public ulong TgnGXIpbki;

		public uint KTzaBpjsSVBf;

		public bbsMQUynbhF(IntPtr intptr_0)
		{
			KTzaBpjsSVBf = (uint)Marshal.ReadInt32(intptr_0);
			IFXYkcfMcKavWN = (ulong)Marshal.ReadInt64(intptr_0, 8);
			TgnGXIpbki = (ulong)Marshal.ReadInt64(intptr_0, 16);
			LUfkbeziSd = (uint)Marshal.ReadInt32(intptr_0, 52);
			mQcUKHedSh = Marshal.ReadInt16(intptr_0, 56);
			tkcOjSybwGtdv = Marshal.ReadInt16(intptr_0, 58);
			rSrtuFDJaoZnp = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + tkcOjSybwGtdv), mQcUKHedSh / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr OQhYDtQttPgRVoY, out VgdhfvFbUVA xxgyGvYDqcjc);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr NfstQrfDfwI);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr PdrFjifMHa, uint WZFxFxMOoej, IntPtr hMVeHInPDEFA, int kUonmgxDDTR, out mWQXPMYfvQy mjFmsIGKeSGRCL, int yPasoZwwLgBpa, out uint SKAxKbgHnNlY, IntPtr RsAVrZSEBHz);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr ygkKyTyuJLb, uint PPhHFZeZwVCDSv, IntPtr BFHUhvqGXOZkR, int ngAVzPMEBiTyKyus, IntPtr kjuEwyKPtejQ, int EUPXPyADKT, out uint MvwpdIRJMMt, IntPtr TzhmCJKEGqqo);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
