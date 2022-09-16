using System;
using System.Runtime.InteropServices;

namespace wVRaLppLPGmaSaj;

public sealed class XABsKVQGCJIw
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct fkmAvYHEUKQsE
	{
		public uint DlHLpmlncWpHQ;

		public waFGLBYiVZJhBD kKVYFuwsoFX;

		public waFGLBYiVZJhBD LHuIBwIZnFeTVkOQ;

		public waFGLBYiVZJhBD OAtlpHEdEBj;

		public uint htnVrszcgTymz;

		public uint yEMcKjyMlTy;

		public uint PDbJGOFxkFzEU;

		public uint iHfQQmXhQcdr;

		public uint kEpWmUuLUMNE;

		public uint waHqjciqIlReMy;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct waFGLBYiVZJhBD
	{
		public uint BqjscQcngEZn;

		public uint LMCrinQoUSw;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct bipYmlhZYRXLRR
	{
		public ulong RAEWNwmAmSv;

		public long GzdFcyWrHFYzRD;

		public long hurbVWvDJgVIWh;

		public long UlNKLgkjfLhFJz;

		public long eImMAQxSHrnfO;

		public ulong ESDWKbEwDSG;

		public ulong qhMlmbhVgizDMPtm;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct umbWCrEpEGaS
	{
		public ulong bUDwcFXYRwo;

		public long iXyuYBgljxxv;

		public long tQbkwIqIcDXn;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ARHyCwzgZJJLi
	{
		public ulong ESDWKbEwDSG;

		public ulong qhMlmbhVgizDMPtm;
	}

	public sealed class GuyKfkLltIItOOl
	{
		public uint DlHLpmlncWpHQ;

		public string WIwScFYfupt = string.Empty;

		public int sEXeDdNGpSAsqso;

		public int PuPPWmZnNS;

		public ulong lMvSiAzItpi;

		public ulong akWdbZaqzlgXHvf;

		public uint YOUMkmEsSJQJ;

		public GuyKfkLltIItOOl(IntPtr intptr_0)
		{
			YOUMkmEsSJQJ = (uint)Marshal.ReadInt32(intptr_0);
			lMvSiAzItpi = (ulong)Marshal.ReadInt64(intptr_0, 8);
			akWdbZaqzlgXHvf = (ulong)Marshal.ReadInt64(intptr_0, 16);
			DlHLpmlncWpHQ = (uint)Marshal.ReadInt32(intptr_0, 52);
			sEXeDdNGpSAsqso = Marshal.ReadInt16(intptr_0, 56);
			PuPPWmZnNS = Marshal.ReadInt16(intptr_0, 58);
			WIwScFYfupt = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + PuPPWmZnNS), sEXeDdNGpSAsqso / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr wMeLoqOLExlYs, out fkmAvYHEUKQsE ebyvZmfVwyn);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr IyGivLCCRsJxH);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr RSmQxwjRDYXH, uint PQxLjotMkAtXRv, IntPtr VJkxbvodfUDL, int itZwmlwrmmafy, out bipYmlhZYRXLRR HskRlNeUYwXq, int lPpCiLqIEhhZdG, out uint XPPZNZqpxZFLD, IntPtr NMImMjqYWbRJeP);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr FSpULnlTMCjc, uint jGxSMEpsxGpNJR, IntPtr LIKhzcNMCzmnjX, int diSzJNxgMeZV, IntPtr ZtkMMHifinG, int akKMSapZctZyBlH, out uint UwFdlGjxlU, IntPtr AwiDuEirxmKx);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
