using System;
using System.Runtime.InteropServices;

namespace kUSxsBmhKmv;

public sealed class fowDTntJmGa
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MwxJKPNSghjaz
	{
		public uint XzwTySWWZu;

		public umQJWnJNCLWW eowMWiyBGcBS;

		public umQJWnJNCLWW FSaqekwLVKjip;

		public umQJWnJNCLWW AvLZwaLkYoxz;

		public uint ZYjtCBmdSjfbzN;

		public uint gSglBipKvuTD;

		public uint JoBiHisQCyU;

		public uint UVLDcytIBeji;

		public uint YPUOLqlNqRFP;

		public uint iTSnQeSDAOMA;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct umQJWnJNCLWW
	{
		public uint jTolyFeTheMBI;

		public uint wHblqYrOhzt;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct yiUHJbxbUorDr
	{
		public ulong POkMnNGVTSIms;

		public long IgyWHkxudzhAB;

		public long ngVkVSzaQPTE;

		public long LzuvnytMIBd;

		public long ypgXbKTtPua;

		public ulong vPVYUJqBAtmhtz;

		public ulong ycIAFIhfPLuj;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct WJTnxMpwzsrxx
	{
		public ulong yEpBQSfsRYJ;

		public long ecQtHTEkTQOzSnmP;

		public long oUXHLtJyzDxW;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct iThKKoyFnhi
	{
		public ulong vPVYUJqBAtmhtz;

		public ulong ycIAFIhfPLuj;
	}

	public sealed class lLcyuHHXTcNO
	{
		public uint XzwTySWWZu;

		public string BRNPsBTqGfQj = string.Empty;

		public int TbqwXAMaaSvKEJ;

		public int bmFNOmNbMB;

		public ulong hTwsGlYBhKak;

		public ulong nzELpMuvziofyW;

		public uint YzSqECEghWmI;

		public lLcyuHHXTcNO(IntPtr intptr_0)
		{
			YzSqECEghWmI = (uint)Marshal.ReadInt32(intptr_0);
			hTwsGlYBhKak = (ulong)Marshal.ReadInt64(intptr_0, 8);
			nzELpMuvziofyW = (ulong)Marshal.ReadInt64(intptr_0, 16);
			XzwTySWWZu = (uint)Marshal.ReadInt32(intptr_0, 52);
			TbqwXAMaaSvKEJ = Marshal.ReadInt16(intptr_0, 56);
			bmFNOmNbMB = Marshal.ReadInt16(intptr_0, 58);
			BRNPsBTqGfQj = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + bmFNOmNbMB), TbqwXAMaaSvKEJ / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr FAujZkACieSPSG, out MwxJKPNSghjaz SlbFxihzWP);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr emQUfJXfNAxGn);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr hUqdHmWkAhBPmf, uint LWjlDTDzgteX, IntPtr tiarVkLzzonmR, int pnjiyiiLtClJZzZ, out yiUHJbxbUorDr UkiVmqGcpxfGnH, int tlxWIlwDbbSgZM, out uint cIbvvAaCds, IntPtr wlLMBWpzzMA);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr bBrqzyInzOfH, uint tnnZSLmrLJQafnju, IntPtr lulusGVhZmVd, int ZsfIetRByCeE, IntPtr vUAFSLiVHFPXgz, int FnVSSbwwJjjbNu, out uint JjyBKitWZnnL, IntPtr nrtANnVZAFGom);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
