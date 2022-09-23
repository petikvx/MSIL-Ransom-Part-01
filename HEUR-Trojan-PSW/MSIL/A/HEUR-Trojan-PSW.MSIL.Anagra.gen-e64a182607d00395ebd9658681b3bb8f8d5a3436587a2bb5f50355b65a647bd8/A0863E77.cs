using System;
using System.Runtime.InteropServices;

public class A0863E77
{
	public struct GStruct0
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string HelloSkid;

		public int HelloSkid;

		public extern GStruct0(string HelloSkid, int HelloSkid);
	}

	public struct GStruct1 : IDisposable
	{
		public int HelloSkid;

		public int HelloSkid;

		public IntPtr HelloSkid;

		public int HelloSkid;

		public IntPtr HelloSkid;

		public int HelloSkid;

		public IntPtr HelloSkid;

		public int HelloSkid;

		public IntPtr HelloSkid;

		public int HelloSkid;

		public int HelloSkid;

		public long HelloSkid;

		public int HelloSkid;

		public GStruct1(byte[] HelloSkid, byte[] HelloSkid, byte[] HelloSkid)
		{
			//Discarded unreachable code: IL_0005, IL_000c
			//IL_0007: Invalid comparison between Unknown and I4
			while (true)
			{
			}
		}

		public extern void Dispose();
	}

	public struct DD7BFFB0
	{
		public int HelloSkid;

		public int HelloSkid;

		public int HelloSkid;
	}

	public struct GStruct2
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string HelloSkid;

		public IntPtr HelloSkid;

		public int HelloSkid;

		public extern GStruct2(string HelloSkid);
	}

	public const uint HelloSkid = 0u;

	public const uint HelloSkid = 8u;

	public const uint HelloSkid = 4u;

	public static readonly byte[] HelloSkid;

	public static readonly string HelloSkid;

	public static readonly string HelloSkid;

	public static readonly string HelloSkid;

	public static readonly string HelloSkid;

	public static readonly string HelloSkid;

	public static readonly string HelloSkid;

	public static readonly string HelloSkid;

	public static readonly int HelloSkid;

	public static readonly int HelloSkid;

	public static readonly uint HelloSkid;

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptOpenAlgorithmProvider(out IntPtr HelloSkid, [MarshalAs(UnmanagedType.LPWStr)] string HelloSkid, [MarshalAs(UnmanagedType.LPWStr)] string HelloSkid, uint HelloSkid);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptCloseAlgorithmProvider(IntPtr HelloSkid, uint HelloSkid);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptGetProperty(IntPtr HelloSkid, [MarshalAs(UnmanagedType.LPWStr)] string HelloSkid, byte[] HelloSkid, int HelloSkid, ref int HelloSkid, uint HelloSkid);

	[DllImport("bcrypt.dll")]
	internal static extern uint BCryptSetProperty(IntPtr HelloSkid, [MarshalAs(UnmanagedType.LPWStr)] string HelloSkid, byte[] HelloSkid, int HelloSkid, int HelloSkid);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptImportKey(IntPtr HelloSkid, IntPtr HelloSkid, [MarshalAs(UnmanagedType.LPWStr)] string HelloSkid, out IntPtr HelloSkid, IntPtr HelloSkid, int HelloSkid, byte[] HelloSkid, int HelloSkid, uint HelloSkid);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptDestroyKey(IntPtr HelloSkid);

	[DllImport("bcrypt.dll")]
	public static extern uint BCryptEncrypt(IntPtr HelloSkid, byte[] HelloSkid, int HelloSkid, ref GStruct1 HelloSkid, byte[] HelloSkid, int HelloSkid, byte[] HelloSkid, int HelloSkid, ref int HelloSkid, uint HelloSkid);

	[DllImport("bcrypt.dll")]
	internal static extern uint BCryptDecrypt(IntPtr HelloSkid, byte[] HelloSkid, int HelloSkid, ref GStruct1 HelloSkid, byte[] HelloSkid, int HelloSkid, byte[] HelloSkid, int HelloSkid, ref int HelloSkid, int HelloSkid);

	public extern A0863E77();
}
