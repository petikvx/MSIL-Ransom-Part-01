using System;
using System.Runtime.InteropServices;

public class GClass16
{
	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
	public unsafe static extern int memcmp(byte* pByte_0, byte* pByte_1, uint uint_0);

	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "memcmp")]
	public static extern int memcmp_1(IntPtr intptr_0, IntPtr intptr_1, uint uint_0);

	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern int memcpy(IntPtr intptr_0, IntPtr intptr_1, uint uint_0);

	[DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "memcpy")]
	public unsafe static extern int memcpy_1(void* pVoid_0, void* pVoid_1, uint uint_0);

	public extern GClass16();
}
