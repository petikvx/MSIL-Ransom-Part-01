using System;
using System.Runtime.InteropServices;

public static class Superfast
{
	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern IntPtr memset(IntPtr dest, int c, int count);

	public static extern byte[] InitByteArray(byte fillWith, int size);
}
