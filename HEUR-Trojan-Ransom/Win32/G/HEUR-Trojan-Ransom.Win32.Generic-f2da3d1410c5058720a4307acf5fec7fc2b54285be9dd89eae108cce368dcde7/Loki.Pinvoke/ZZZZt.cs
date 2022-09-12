using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace Loki.Pinvoke;

internal class ZZZZt
{
	[Flags]
	internal enum ZZZZD
	{
		None = 0,
		ChainCalls = 1,
		InProgress = 2
	}

	internal struct ZZZZE
	{
		internal int ZZZZF;

		internal int ZZZZG;

		internal IntPtr ZZZZH;

		internal int ZZZZI;

		internal IntPtr ZZZZJ;

		internal int ZZZZK;

		internal IntPtr ZZZZL;

		internal int ZZZZM;

		internal IntPtr ZZZZN;

		internal int ZZZZO;

		internal int ZZZZP;

		internal long ZZZZQ;

		internal ZZZZD ZZZZR;
	}

	[DllImport("bcrypt.dll")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int BCryptCloseAlgorithmProvider(IntPtr intptr_0, int int_0);

	[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
	public static extern int BCryptOpenAlgorithmProvider(out IntPtr intptr_0, string string_0, string string_1, uint uint_0);

	[DllImport("bcrypt.dll")]
	public static extern int BCryptGenRandom(IntPtr intptr_0, IntPtr intptr_1, int int_0, uint uint_0);

	[DllImport("bcrypt.dll")]
	public static extern int BCryptEncrypt(IntPtr intptr_0, IntPtr intptr_1, int int_0, [In] ref ZZZZE zzzze_0, IntPtr intptr_2, int int_1, IntPtr intptr_3, int int_2, out int int_3, uint uint_0);

	[DllImport("bcrypt.dll")]
	public static extern int BCryptDecrypt(IntPtr intptr_0, IntPtr intptr_1, int int_0, [In] ref ZZZZE zzzze_0, IntPtr intptr_2, int int_1, IntPtr intptr_3, int int_2, out int int_3, uint uint_0);

	[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
	public static extern int BCryptSetProperty(IntPtr intptr_0, string string_0, [In][MarshalAs(UnmanagedType.LPArray)] byte[] byte_0, int int_0, uint uint_0);

	[DllImport("bcrypt.dll")]
	internal static extern int BCryptGenerateSymmetricKey(IntPtr intptr_0, out IntPtr intptr_1, IntPtr intptr_2, int int_0, IntPtr intptr_3, int int_1, int int_2);

	[SecuritySafeCritical]
	[SecurityCritical]
	internal static void ZZZZB(ref ZZZZE zzzze_0)
	{
		//Discarded unreachable code: IL_0002, IL_0007, IL_000e, IL_0010, IL_0015
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Invalid comparison between Unknown and I8
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Unknown opcode: 0xF8*/;
		}
	}

	[DllImport("bcrypt.dll")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int BCryptDestroyKey(IntPtr intptr_0);

	public extern ZZZZt();
}
