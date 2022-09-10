using System;
using System.Runtime.InteropServices;

namespace HxobVrDuhJbMYt;

public sealed class WOUSvMaKfSyhnht
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct WAANxQkDJvO
	{
		public uint uiDngBrIucD;

		public YcpNETjUaVT mTDyejguvpcUM;

		public YcpNETjUaVT jSIhrxdFRzl;

		public YcpNETjUaVT MESSYCTcPb;

		public uint eBIrYRFHNczyz;

		public uint oACLovVDLmYTc;

		public uint dPkSBclHmmOH;

		public uint XMQVsPBYFtP;

		public uint HtVebOulCGg;

		public uint EXXShcTKkwwObl;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct YcpNETjUaVT
	{
		public uint CIGAfDIORq;

		public uint bdiHJQJGnXN;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct HTaMExqdETGNm
	{
		public ulong hxMXkWeKhUOpMV;

		public long umVzhUKnVzpdU;

		public long hBLAirbZyQeW;

		public long EGAFZaSyBfUo;

		public long iywwVzPZRxOsP;

		public ulong fEgBJqmvnsXT;

		public ulong GCyLaDAbZISQ;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct dSJwACSETVbtC
	{
		public ulong FnQYdLJBXxxIR;

		public long VOyoeiCCTO;

		public long PJuaqdWNUllGYR;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct xGupZZOPoPxAnTg
	{
		public ulong fEgBJqmvnsXT;

		public ulong GCyLaDAbZISQ;
	}

	public sealed class SsEvFJslIcFio
	{
		public uint uiDngBrIucD;

		public string YEBKuKykjSz = string.Empty;

		public int NVZMGTnFbxZ;

		public int IJCKZWgzZf;

		public ulong WLRgNPtunaMZKU;

		public ulong QYESlNsOGSZe;

		public uint VsygIJSpySlH;

		public SsEvFJslIcFio(IntPtr intptr_0)
		{
			VsygIJSpySlH = (uint)Marshal.ReadInt32(intptr_0);
			WLRgNPtunaMZKU = (ulong)Marshal.ReadInt64(intptr_0, 8);
			QYESlNsOGSZe = (ulong)Marshal.ReadInt64(intptr_0, 16);
			uiDngBrIucD = (uint)Marshal.ReadInt32(intptr_0, 52);
			NVZMGTnFbxZ = Marshal.ReadInt16(intptr_0, 56);
			IJCKZWgzZf = Marshal.ReadInt16(intptr_0, 58);
			YEBKuKykjSz = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + IJCKZWgzZf), NVZMGTnFbxZ / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr fCMnXSnjomebZqL, out WAANxQkDJvO BgxSmxnZQJSZRnq);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr CaUimcvylQRWG);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr AfwqcswkvNjYQ, uint WWxzwZIdzbDHzW, IntPtr wuMkeotnwk, int semQAUGHWwWzFo, out HTaMExqdETGNm kayLyvqcvkJPoX, int MZGFipOitMFkI, out uint BXCkPINuODrA, IntPtr XMmEQWykkeh);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr HdkpuMlvDdMzJi, uint kgAoOJHSyljwx, IntPtr yfzUFpUtzzEZKlQ, int sxHmjjgfIFx, IntPtr YQDEgdysOM, int sYTAFtUYKLl, out uint wovtcCSHQaz, IntPtr mYJuOwGTUyscz);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
