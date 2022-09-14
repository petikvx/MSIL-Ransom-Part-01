using System;
using System.Runtime.InteropServices;

namespace KpMfljJgmqhysH;

public sealed class BnrERhqprMVch
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct KeTiEAWdMUijBMgm
	{
		public uint qtwVndlfoEIkP;

		public YIlVrfnSWO pcKgZeaMXkwnIU;

		public YIlVrfnSWO ZHPMazsNlvlAtB;

		public YIlVrfnSWO KqmSYdvLdLff;

		public uint KcEGqpqzXKUDzN;

		public uint HBbRFYckTrdWqCR;

		public uint BSKRtBPDQoUUv;

		public uint JDDzGavOOdpDhh;

		public uint eGArBbTECGVk;

		public uint lDRlYTPfItWj;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct YIlVrfnSWO
	{
		public uint xWuFOsMZqdXMl;

		public uint fUsfIpIKxfhOY;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct thVEFZPcYNv
	{
		public ulong aAFJiTHsgQu;

		public long YyNFihqHOkMeC;

		public long xyuBRpvCLAfcFl;

		public long cStcIXLGMh;

		public long psShDHhqNqckidzL;

		public ulong nPMbGJhtqRRMcjON;

		public ulong UVBMxhSKLFFW;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct emgFKmDVYgfSt
	{
		public ulong tebVlDvwShyZmW;

		public long NhfSFDppwhA;

		public long dBxhziYbsOdhkx;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct VAStWlVtfzfdk
	{
		public ulong nPMbGJhtqRRMcjON;

		public ulong UVBMxhSKLFFW;
	}

	public sealed class IbWpNGWtNtj
	{
		public uint qtwVndlfoEIkP;

		public string mZNcxjrbcyAxy = string.Empty;

		public int BAWlQGmyTjmhfNA;

		public int yhfmGWKYHJdBYyX;

		public ulong wJMVfKQxBwsvhZP;

		public ulong XpONcGAfnyor;

		public uint Lljivqnbejkl;

		public IbWpNGWtNtj(IntPtr intptr_0)
		{
			Lljivqnbejkl = (uint)Marshal.ReadInt32(intptr_0);
			wJMVfKQxBwsvhZP = (ulong)Marshal.ReadInt64(intptr_0, 8);
			XpONcGAfnyor = (ulong)Marshal.ReadInt64(intptr_0, 16);
			qtwVndlfoEIkP = (uint)Marshal.ReadInt32(intptr_0, 52);
			BAWlQGmyTjmhfNA = Marshal.ReadInt16(intptr_0, 56);
			yhfmGWKYHJdBYyX = Marshal.ReadInt16(intptr_0, 58);
			mZNcxjrbcyAxy = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + yhfmGWKYHJdBYyX), BAWlQGmyTjmhfNA / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr JmfVqdLhVwcH, out KeTiEAWdMUijBMgm jmelHprRfyAsk);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr qaNkqioNHGVeMwfT);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr zVDNQVrrOttTV, uint WMYLVfIPqj, IntPtr QLEQDjWGWCg, int xbxRUFMMWWEx, out thVEFZPcYNv CnxGQYFBpdvxf, int FOgHRlxUONdqd, out uint IajMvwFUrmGho, IntPtr YVsMzpsBIeHsQhKnw);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr QkjSnvDQfZFtMt, uint DhpxmneCcjyzH, IntPtr IzvUFHSGbVk, int RFxPKYiWgLCvE, IntPtr CLdcXScmEzOzgw, int hyPzEghlatIm, out uint MXpbLWojMFZf, IntPtr rVjIkFGYlrB);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
