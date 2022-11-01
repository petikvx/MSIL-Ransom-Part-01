using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace Loki.Pinvoke;

internal class ZZZZZZZZl
{
	[Flags]
	internal enum ZZZZZZZZv
	{
		None = 0,
		ChainCalls = 1,
		InProgress = 2
	}

	internal struct ZZZZZZZZw
	{
		internal int ZZZZZZZZx;

		internal int ZZZZZZZZy;

		internal IntPtr ZZZZZZZZz;

		internal int ZZZZZZZZA;

		internal IntPtr ZZZZZZZZB;

		internal int ZZZZZZZZC;

		internal IntPtr ZZZZZZZZD;

		internal int ZZZZZZZZE;

		internal IntPtr ZZZZZZZZF;

		internal int ZZZZZZZZG;

		internal int ZZZZZZZZH;

		internal long ZZZZZZZZI;

		internal ZZZZZZZZv ZZZZZZZZJ;
	}

	[DllImport("bcrypt.dll")]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static extern int BCryptCloseAlgorithmProvider(IntPtr intptr_0, int int_0);

	[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
	public static extern int BCryptOpenAlgorithmProvider(out IntPtr intptr_0, string string_0, string string_1, uint uint_0);

	[DllImport("bcrypt.dll")]
	public static extern int BCryptGenRandom(IntPtr intptr_0, IntPtr intptr_1, int int_0, uint uint_0);

	[DllImport("bcrypt.dll")]
	public static extern int BCryptEncrypt(IntPtr intptr_0, IntPtr intptr_1, int int_0, [In] ref ZZZZZZZZw zzzzzzzzw_0, IntPtr intptr_2, int int_1, IntPtr intptr_3, int int_2, out int int_3, uint uint_0);

	[DllImport("bcrypt.dll")]
	public static extern int BCryptDecrypt(IntPtr intptr_0, IntPtr intptr_1, int int_0, [In] ref ZZZZZZZZw zzzzzzzzw_0, IntPtr intptr_2, int int_1, IntPtr intptr_3, int int_2, out int int_3, uint uint_0);

	[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
	public static extern int BCryptSetProperty(IntPtr intptr_0, string string_0, [In][MarshalAs(UnmanagedType.LPArray)] byte[] byte_0, int int_0, uint uint_0);

	[DllImport("bcrypt.dll")]
	internal static extern int BCryptGenerateSymmetricKey(IntPtr intptr_0, out IntPtr intptr_1, IntPtr intptr_2, int int_0, IntPtr intptr_3, int int_1, int int_2);

	[SecuritySafeCritical]
	[SecurityCritical]
	internal static extern void ZZZZZZZZt(ref ZZZZZZZZw zzzzzzzzw_0);

	[DllImport("bcrypt.dll")]
	[SuppressUnmanagedCodeSecurity]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public static extern int BCryptDestroyKey(IntPtr intptr_0);

	public extern ZZZZZZZZl();
}
