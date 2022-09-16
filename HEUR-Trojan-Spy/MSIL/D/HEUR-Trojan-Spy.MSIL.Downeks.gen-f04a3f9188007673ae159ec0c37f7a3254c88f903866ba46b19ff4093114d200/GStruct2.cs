using System;
using System.Runtime.InteropServices;

public struct GStruct2
{
	public IntPtr intptr_0;

	public IntPtr intptr_1;

	public uint uint_0;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
	public string string_0;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
	public string string_1;
}
