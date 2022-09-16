using System;
using System.Runtime.InteropServices;

namespace wNYxiQoDKrRkKV;

public sealed class aAbUMGekNx
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct igFyARwBRx
	{
		public uint dAayYfXpYrj;

		public JWDPZdLKmIAvfGn UCEERkWQqfdTpY;

		public JWDPZdLKmIAvfGn dvrRcDQXaL;

		public JWDPZdLKmIAvfGn rebuPXqLcbvUiiFMj;

		public uint ZjgAOCzIainWSvAid;

		public uint EKQLPsOakXWYU;

		public uint wAfePdizmZDyU;

		public uint bmEXsuEwvRy;

		public uint yFuOnHzcyGZEoMS;

		public uint jDRghywqjxQM;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct JWDPZdLKmIAvfGn
	{
		public uint KrEolhJCnYAR;

		public uint OjrhIllEdgwpI;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct AiLBqivitZ
	{
		public ulong xeLzlJnMyYS;

		public long nhqbBojvhZulA;

		public long teumvnAMftTe;

		public long KAQDKZuRwVY;

		public long uyYFCFmQrvW;

		public ulong iWEyEEWqEBoF;

		public ulong QZoFRaRDhYaQ;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct FkUTcsbdyfIXF
	{
		public ulong ZRHWHTjzRnrZ;

		public long LiKREmZiUoTK;

		public long IeQVNOlmxtTaose;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct uAYGvyZVYkHmoWuG
	{
		public ulong iWEyEEWqEBoF;

		public ulong QZoFRaRDhYaQ;
	}

	public sealed class RIrpYXSpeIedSNrY
	{
		public uint dAayYfXpYrj;

		public string sUGtKrgxbHAJ = string.Empty;

		public int kfCcvmsHmkv;

		public int bwtwsqYrwraU;

		public ulong MsncOsaXhky;

		public ulong cjlIOfhjUyqek;

		public uint ChdkHQiftsRQUf;

		public RIrpYXSpeIedSNrY(IntPtr intptr_0)
		{
			ChdkHQiftsRQUf = (uint)Marshal.ReadInt32(intptr_0);
			MsncOsaXhky = (ulong)Marshal.ReadInt64(intptr_0, 8);
			cjlIOfhjUyqek = (ulong)Marshal.ReadInt64(intptr_0, 16);
			dAayYfXpYrj = (uint)Marshal.ReadInt32(intptr_0, 52);
			kfCcvmsHmkv = Marshal.ReadInt16(intptr_0, 56);
			bwtwsqYrwraU = Marshal.ReadInt16(intptr_0, 58);
			sUGtKrgxbHAJ = Marshal.PtrToStringUni(new IntPtr(intptr_0.ToInt32() + bwtwsqYrwraU), kfCcvmsHmkv / 2);
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr CreateFile(string string_0, uint uint_0, uint uint_1, IntPtr intptr_0, uint uint_2, uint uint_3, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool GetFileInformationByHandle(IntPtr heqhYgArNPIBqBpLx, out igFyARwBRx kgPQMuMEIsF);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool CloseHandle(IntPtr iEUVQbEmoBKEjXg);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl(IntPtr PyUAyJYuwmBNV, uint WTbglxCzGULkz, IntPtr iFrhTeciHbKs, int jovMZFDLVSRoNuUR, out AiLBqivitZ qzlPtpigVHn, int SJSIReTmUOOkmjKW, out uint UPfMvIhykvED, IntPtr xDhsFKetezS);

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, EntryPoint = "DeviceIoControl", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool DeviceIoControl_1(IntPtr YJpVoOSkfakH, uint AuuETUccxfUKN, IntPtr nYxlMDErYaeekvM, int JOHCZNrwDRrp, IntPtr bZtQvVeimH, int MhAvhVxjlvWS, out uint AcRzhzrvqX, IntPtr IJizKRNXlYD);

	[DllImport("kernel32.dll")]
	public static extern void ZeroMemory(IntPtr intptr_0, int int_0);
}
