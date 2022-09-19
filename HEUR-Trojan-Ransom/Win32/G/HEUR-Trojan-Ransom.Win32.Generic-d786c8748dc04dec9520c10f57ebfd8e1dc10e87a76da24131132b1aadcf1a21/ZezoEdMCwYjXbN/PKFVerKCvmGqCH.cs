using System;
using System.Runtime.InteropServices;

namespace ZezoEdMCwYjXbN;

public sealed class PKFVerKCvmGqCH
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct jSBnqBCSUPjzi
	{
		public uint nJzAxuynohj;

		public UfTrARuEwh TpqkdWptbsej;

		public UfTrARuEwh KMfVBoRgohRg;

		public UfTrARuEwh KtVCcsuuJkARXO;

		public uint aqycrpaQPCNeiB;

		public uint lzzUbEFsPF;

		public uint sDUQFnPNlVKqb;

		public uint KnagpwDizv;

		public uint dkKwLcnhOaTir;

		public uint AUqBxgVifkvcH;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct UfTrARuEwh
	{
		public uint bsUzbrgriCobSC;

		public uint uQbiiSXuaDBkNw;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct sYWKcPdDlyg
	{
		public ulong gDmjUeSDSDAP;

		public long XTHbLDmlUsbgP;

		public long gIstmVZGisLW;

		public long bQRBSnycJrDyz;

		public long nziGrVDfcI;

		public ulong HwbdxgxRgIFLC;

		public ulong nPDualsIFmmH;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct eRGkKkkUCKGwSUg
	{
		public ulong qANUUCvkKqUH;

		public long yvdxcxapTGNu;

		public long OGlCHViMiJKia;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct DIXYIxfbthYD
	{
		public ulong HwbdxgxRgIFLC;

		public ulong nPDualsIFmmH;
	}

	public sealed class kdQRtaytpsrM
	{
		public uint nJzAxuynohj;

		public string vWNTzKXgKiWE = string.Empty;

		public int ccMHZdpGVlLeUf;

		public int yfWpBwMEQPpr;

		public ulong AZYIfuTbrxnNA;

		public ulong TvQWyQLDsrMF;

		public uint OfnNFahXLhUBuepl;

		public kdQRtaytpsrM(IntPtr intptr_0)
		{
			OfnNFahXLhUBuepl = (uint)Marshal.ReadInt32(intptr_0);
			AZYIfuTbrxnNA = (ulong)Marshal.ReadInt64(intptr_0, 8);
			TvQWyQLDsrMF = (ulong)Marshal.ReadInt64(intptr_0, 16);
			nJzAxuynohj = (uint)Marshal.ReadInt32(intptr_0, 52);
			ccMHZdpGVlLeUf = Marshal.ReadInt16(intptr_0, 56);
			yfWpBwMEQPpr = Marshal.ReadInt16(intptr_0, 58);
			vWNTzKXgKiWE = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + yfWpBwMEQPpr), ccMHZdpGVlLeUf / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr JHuKHfhrvwI, out jSBnqBCSUPjzi KVwuFpwOztpq);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr LCmxxPtJkmiI);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr rxuStEPauv, uint flnjhJSwZIFJE, IntPtr CvvRcDoYjEK, int dGiRwBmxNAQ, out sYWKcPdDlyg mimMSigsGcaM, int VTiLTYTPxPP, out uint DCylEWYgoylv, IntPtr SJjsUwJOqV);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr jQNEYDKbPAWQ, uint GFxELUmfVufDt, IntPtr xkOYzBsTBzNON, int gXFyZRKscPbLWL, IntPtr WmJdzLqbZhRU, int rtZmsHPRxGHBxpP, out uint yGSxocljQGsmUPsB, IntPtr tXfJQvIFbJa);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
