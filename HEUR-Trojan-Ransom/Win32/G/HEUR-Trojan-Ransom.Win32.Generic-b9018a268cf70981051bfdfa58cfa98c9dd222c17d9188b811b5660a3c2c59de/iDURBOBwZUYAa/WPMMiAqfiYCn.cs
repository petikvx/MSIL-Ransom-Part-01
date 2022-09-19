using System;
using System.Runtime.InteropServices;

namespace iDURBOBwZUYAa;

public sealed class WPMMiAqfiYCn
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MUvPxLJUEpDxlSChz
	{
		public uint jZBOCZRnxyFp;

		public ZhZGoJpBKpmen eiqpwZBoUOnJ;

		public ZhZGoJpBKpmen JpEETxnHYmWCN;

		public ZhZGoJpBKpmen QxgVkpnZMsOve;

		public uint WoYZAvOSPe;

		public uint OVFfYciHFej;

		public uint EEVDqbhybzO;

		public uint QVVqVCnzstIEBDMr;

		public uint QbiYXlLIgdYJv;

		public uint tcbKojrcou;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ZhZGoJpBKpmen
	{
		public uint ySJCsTEYWB;

		public uint nBpaOhdLdQBtdVgh;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct aUwHlTGbKfOUN
	{
		public ulong lxPHfbYRGgtE;

		public long LpbyikVNszbarl;

		public long qtEMjEovhSSe;

		public long GbkOzfySyZhooIS;

		public long TBYHLgjMnjB;

		public ulong yeIhkMjYvC;

		public ulong qLppcpThZcJvQeXh;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct mitzhZbEFSV
	{
		public ulong zMrMvBfjEim;

		public long rtWDygDlPvMQ;

		public long DkoIqPNGcPWq;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct aatuXRKJvlSDi
	{
		public ulong yeIhkMjYvC;

		public ulong qLppcpThZcJvQeXh;
	}

	public sealed class ZdDpizzlBtxF
	{
		public uint jZBOCZRnxyFp;

		public string MLFJzzTLoFSlh = string.Empty;

		public int wGwWpwswQGx;

		public int RbReLqUsdAw;

		public ulong WPLQuTzteXoAv;

		public ulong WPesGcRbXzG;

		public uint IuoSKnNcFIrVJjl;

		public ZdDpizzlBtxF(IntPtr intptr_0)
		{
			IuoSKnNcFIrVJjl = (uint)Marshal.ReadInt32(intptr_0);
			WPLQuTzteXoAv = (ulong)Marshal.ReadInt64(intptr_0, 8);
			WPesGcRbXzG = (ulong)Marshal.ReadInt64(intptr_0, 16);
			jZBOCZRnxyFp = (uint)Marshal.ReadInt32(intptr_0, 52);
			wGwWpwswQGx = Marshal.ReadInt16(intptr_0, 56);
			RbReLqUsdAw = Marshal.ReadInt16(intptr_0, 58);
			MLFJzzTLoFSlh = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + RbReLqUsdAw), wGwWpwswQGx / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr xOrMFwZzeQOnZ, out MUvPxLJUEpDxlSChz pAOZYKrBmBIP);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr lnkrTTQWrf);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr qGdgfvabRqQHx, uint ysPcBMUDoRQj, IntPtr UNZPafyabhejlsxPte, int VyUgCHHVRdasLQ, out aUwHlTGbKfOUN VAlcdNhTmUPjo, int ZnXVJjEKuBCzfDcXyW, out uint IfbkispEkdyq, IntPtr RalMEaELaJwAOg);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr MuttAOWgpEHd, uint YMrfFZIFrsN, IntPtr YoSHFxWlrlbhVeA, int TtCUATTDFwcga, IntPtr giVKVSSLHhg, int hOJgpgUCzvH, out uint jRnXkxeXLsFt, IntPtr XVLDFyMspfAxSpQ);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
