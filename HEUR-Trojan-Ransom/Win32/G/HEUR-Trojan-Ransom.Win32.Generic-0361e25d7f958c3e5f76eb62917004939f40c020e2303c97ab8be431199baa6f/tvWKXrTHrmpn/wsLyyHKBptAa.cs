using System;
using System.Runtime.InteropServices;

namespace tvWKXrTHrmpn;

public sealed class wsLyyHKBptAa
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ogaUVwaWXtVXrxP
	{
		public uint LBybEumoYQx;

		public gIrOiwTHmQ ZFKeWyXNFIPChof;

		public gIrOiwTHmQ lubudtYPxPCxk;

		public gIrOiwTHmQ qHgRQCPwdVpkzIY;

		public uint DpxvnOWyuljwzwA;

		public uint uRvmVJgbgTAok;

		public uint FvttMhmfkBbtc;

		public uint fwKhuebMLY;

		public uint vJzFckwIfgX;

		public uint hmbsJtrjyCKDz;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct gIrOiwTHmQ
	{
		public uint TkNCTSlCBqFq;

		public uint MreaNfyQORsQpn;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct izBonXKVXPSlc
	{
		public ulong SQfXVHsEeJx;

		public long vcCxYhMjukaZ;

		public long NiOxbzRPgPiXMZ;

		public long qCdZjNYPwIpE;

		public long wxBMfcceggeq;

		public ulong NdpykEKNEymdKB;

		public ulong wzUKVlSykYDpV;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct gXobEdGdEmXupLs
	{
		public ulong XTudShzdgNW;

		public long mlDhdItHmFk;

		public long dmCNKEJKHP;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct fTeRlUjkDfDR
	{
		public ulong NdpykEKNEymdKB;

		public ulong wzUKVlSykYDpV;
	}

	public sealed class yqzCFnTyclbNB
	{
		public uint LBybEumoYQx;

		public string WySkYESogcz = string.Empty;

		public int HrnLOBCNkpwrIj;

		public int UsQvCfPgGuE;

		public ulong azCjJrojbPrPvil;

		public ulong QgEJQqVKqKGOh;

		public uint eMmtmDgwJnSO;

		public yqzCFnTyclbNB(IntPtr intptr_0)
		{
			eMmtmDgwJnSO = (uint)Marshal.ReadInt32(intptr_0);
			azCjJrojbPrPvil = (ulong)Marshal.ReadInt64(intptr_0, 8);
			QgEJQqVKqKGOh = (ulong)Marshal.ReadInt64(intptr_0, 16);
			LBybEumoYQx = (uint)Marshal.ReadInt32(intptr_0, 52);
			HrnLOBCNkpwrIj = Marshal.ReadInt16(intptr_0, 56);
			UsQvCfPgGuE = Marshal.ReadInt16(intptr_0, 58);
			WySkYESogcz = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + UsQvCfPgGuE), HrnLOBCNkpwrIj / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr uNaMCopqCHsWa, out ogaUVwaWXtVXrxP vJZUjHFluE);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr iasaapSMdMQpv);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr WIHpwQzQUR, uint ZcRkPXVcDZg, IntPtr CBqgYVXcEdQWL, int XAOPiHRnlwrlA, out izBonXKVXPSlc SskneHVSYWB, int oJqYFCsycqlD, out uint lDpLVrkHWI, IntPtr mmyVMAdEHg);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr ciJvytIGepGG, uint wVVZXHeHyZB, IntPtr KnVRXeEJZQiHO, int OXMDDoXeolOFlxLn, IntPtr mRbCcShcrMixX, int ndNzvVBbag, out uint MGncmtQRwTpU, IntPtr ePpUPJNxRTnMy);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
