using System;
using System.Runtime.InteropServices;

namespace NS002;

public sealed class fowDTntJmGa
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MwxJKPNSghjaz
	{
		public uint XzwTySWWZu;

		public struct025 eowMWiyBGcBS;

		public struct025 FSaqekwLVKjip;

		public struct025 AvLZwaLkYoxz;

		public uint ZYjtCBmdSjfbzN;

		public uint gSglBipKvuTD;

		public uint JoBiHisQCyU;

		public uint UVLDcytIBeji;

		public uint f00005e;

		public uint f00005f;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct struct025
	{
		public uint jTolyFeTheMBI;

		public uint wHblqYrOhzt;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct yiUHJbxbUorDr
	{
		public ulong f000060;

		public long IgyWHkxudzhAB;

		public long f000061;

		public long LzuvnytMIBd;

		public long ypgXbKTtPua;

		public ulong f000062;

		public ulong ycIAFIhfPLuj;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct WJTnxMpwzsrxx
	{
		public ulong f000063;

		public long f000064;

		public long f000065;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct iThKKoyFnhi
	{
		public ulong f000062;

		public ulong ycIAFIhfPLuj;
	}

	public sealed class c000029
	{
		public uint XzwTySWWZu;

		public string BRNPsBTqGfQj = string.Empty;

		public int f000066;

		public int bmFNOmNbMB;

		public ulong hTwsGlYBhKak;

		public ulong nzELpMuvziofyW;

		public uint YzSqECEghWmI;

		public c000029(IntPtr p0)
		{
			YzSqECEghWmI = (uint)Marshal.ReadInt32(p0);
			hTwsGlYBhKak = (ulong)Marshal.ReadInt64(p0, 8);
			nzELpMuvziofyW = (ulong)Marshal.ReadInt64(p0, 16);
			XzwTySWWZu = (uint)Marshal.ReadInt32(p0, 52);
			f000066 = Marshal.ReadInt16(p0, 56);
			bmFNOmNbMB = Marshal.ReadInt16(p0, 58);
			BRNPsBTqGfQj = Marshal.PtrToStringUni(new IntPtr(p0.ToInt32() + bmFNOmNbMB), f000066 / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string p0, uint p1, uint p2, IntPtr p3, uint p4, uint p5, IntPtr p6);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr p0, out MwxJKPNSghjaz SlbFxihzWP);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr p0);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr hUqdHmWkAhBPmf, uint LWjlDTDzgteX, IntPtr tiarVkLzzonmR, int p3, out yiUHJbxbUorDr p4, int tlxWIlwDbbSgZM, out uint cIbvvAaCds, IntPtr p7);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr bBrqzyInzOfH, uint tnnZSLmrLJQafnju, IntPtr p2, int ZsfIetRByCeE, IntPtr p4, int p5, out uint JjyBKitWZnnL, IntPtr p7);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr p0, int p1);
}
