using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal class Class8
{
	private uint uint_0 = (uint)Marshal.SizeOf(typeof(Class8));

	private IntPtr intptr_0;

	private IntPtr intptr_1 = IntPtr.Zero;

	private IntPtr intptr_2 = IntPtr.Zero;

	public Class8(string string_0)
	{
		intptr_0 = Marshal.StringToCoTaskMemAuto(string_0);
	}

	~Class8()
	{
		Class28.smethod_0(4832948, this, null);
	}
}
