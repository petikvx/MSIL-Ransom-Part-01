using System;
using System.Runtime.InteropServices;
using System.Security;

internal sealed class Class6
{
	public struct Struct6
	{
		internal int int_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		internal string string_0;
	}

	[DllImport("Netapi32", CharSet = CharSet.Auto, SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int NetServerEnum(string string_0, int int_0, ref IntPtr intptr_0, int int_1, out int int_2, out int int_3, int int_4, string string_1, out int int_5);

	[DllImport("Netapi32", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int NetApiBufferFree(IntPtr intptr_0);

	public extern Class6();
}
