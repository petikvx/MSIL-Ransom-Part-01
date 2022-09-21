using System;
using System.Runtime.InteropServices;
using System.Security;

[SuppressUnmanagedCodeSecurity]
public class GClass3
{
	[DllImport("kernel32")]
	public static extern IntPtr BeginUpdateResource(string HelloSkid, [MarshalAs(UnmanagedType.Bool)] bool HelloSkid);

	[DllImport("kernel32")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool UpdateResource(IntPtr HelloSkid, IntPtr HelloSkid, IntPtr HelloSkid, short HelloSkid, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 5)] byte[] HelloSkid, int HelloSkid);

	[DllImport("kernel32")]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool EndUpdateResource(IntPtr HelloSkid, [MarshalAs(UnmanagedType.Bool)] bool HelloSkid);

	public GClass3()
	{
		//Discarded unreachable code: IL_0007, IL_000c
		//IL_0000: Unsupported input type for neg.
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = (double)(0 - /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0002: Invalid metadata token*/;
	}
}
