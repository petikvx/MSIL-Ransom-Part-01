using System;
using System.Runtime.InteropServices;

namespace aHIHEJJDItp;

public class eEtYshyFmcfp
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct slJuhHvKEYjviQM
	{
		public uint FDRbPczgvUK;

		public gCLetJiFpzJXxJyseQ gHOTnUkaPdGeQ;

		public gCLetJiFpzJXxJyseQ KmTmMczpWAPQcA;

		public gCLetJiFpzJXxJyseQ NdyNKXzrYgPwuTEMpw;

		public uint pkNDuePSAbvb;

		public uint vwOptUxJqzke;

		public uint nRDHqSZSil;

		public uint hIvtZVxAWSGp;

		public uint iIpPrIyfENBg;

		public uint YIAetXVgTM;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct gCLetJiFpzJXxJyseQ
	{
		public uint cbdsIfveXgz;

		public uint lYAlhEaoIdULy;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct pZUlAqrFRJur
	{
		public ulong PSjMKJFWUzLCF;

		public long ccllpQGtJjo;

		public long sSjeALzWrYx;

		public long YGtbxrmrSmwIX;

		public long dRfVGEfEfd;

		public ulong qZCIMQvRTyQm;

		public ulong smxOESQFnn;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct sIrqiioVhQf
	{
		public ulong KMOujLrHpOWNu;

		public long keqMnLXHQMOi;

		public long JIyQrsfTgILhPN;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct bmPxVypUqukyhZp
	{
		public ulong qZCIMQvRTyQm;

		public ulong smxOESQFnn;
	}

	public class iXRCiPZJHeH
	{
		private const int GygXbloFBwzUB = 8;

		private const int VfpCcQISBMBipD = 16;

		private const int FHovSBEngPRaI = 52;

		private const int FbIXQwFUibajE = 56;

		private const int KchRPCYPACxv = 58;

		public uint FDRbPczgvUK;

		public string aasPwRXxYNSDAIy = string.Empty;

		public int IXxTAATZQDMK;

		public int BzCmoDIJnM;

		public ulong iKilXQDPLpGp;

		public ulong ZVQLyhJClFkR;

		public uint UHmsNYIBnUO;

		public iXRCiPZJHeH(IntPtr p)
		{
			UHmsNYIBnUO = (uint)Marshal.ReadInt32(p);
			iKilXQDPLpGp = (ulong)Marshal.ReadInt64(p, 8);
			ZVQLyhJClFkR = (ulong)Marshal.ReadInt64(p, 16);
			FDRbPczgvUK = (uint)Marshal.ReadInt32(p, 52);
			IXxTAATZQDMK = Marshal.ReadInt16(p, 56);
			BzCmoDIJnM = Marshal.ReadInt16(p, 58);
			aasPwRXxYNSDAIy = Marshal.PtrToStringUni(new IntPtr(p.ToInt32() + BzCmoDIJnM), IXxTAATZQDMK / 2);
		}
	}

	public const uint tJfOaLxUrQdWGs = 2147483648u;

	public const uint OUKCrPfwFT = 1073741824u;

	public const uint MLerfLjDiNzayHP = 1u;

	public const uint UjYOixOpwxrhq = 2u;

	public const uint EBJKeZbGZpMes = 16u;

	public const uint JqOFSgRTBouJGW = 3u;

	public const uint wlLdxRzUxAG = 33554432u;

	public const int egpJwmweHyVfd = -1;

	public const uint xJLEomvxBzPXeWn = 590068u;

	public const uint gGYyFUijNwLT = 590003u;

	public const uint kTcKeeolfu = 590055u;

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string gBkEFnyQKeGHWw, uint CEWLrXRiKlfR, uint OLXdOQIeScFOssf, IntPtr lMARmmrJoRo, uint lwFoJZOAITmjwQ, uint AJucHMrPQEBxst, IntPtr oOsjVMOlYYxfYHfn);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr fJMYeEYyXidv, out slJuhHvKEYjviQM PjPkYzpWPHZi);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr YviMfCdQwNeE);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr zfVlghfaGWUfDwG, uint zIiirURQbPh, IntPtr hCZeMaBtaGmpy, int RtsARBGWDbjAqY, out pZUlAqrFRJur WOsmLUgKzvljAa, int ZSwMYEDcgKfW, out uint VVBhjfFQBvXEKE, IntPtr kpsChCVCCHwZ);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr gOXBMOsWSUmzt, uint zWvbXvpDvgW, IntPtr KGvLgCLQABEZgYEG, int GdkpIKXUyDmEk, IntPtr MdJkFRGTuoKqs, int DijhiOrJOsHlb, out uint LXfyEQyTmw, IntPtr wlqjphToYdNd);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr YlGeYSuoXNRG, int XBtlzPejJoidOQ);
}
