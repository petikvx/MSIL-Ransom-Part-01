using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
internal class Class9
{
	private uint uint_0 = (uint)Marshal.SizeOf(typeof(Class9));

	private IntPtr intptr_0 = IntPtr.Zero;

	private IntPtr intptr_1 = IntPtr.Zero;

	private Enum1 enum1_0 = Enum1.const_1;

	private Enum2 enum2_0;

	private Enum3 enum3_0 = Enum3.const_0;

	private IntPtr intptr_2;

	private Enum4 enum4_0;

	private IntPtr intptr_3 = IntPtr.Zero;

	private string string_0;

	private Enum5 enum5_0 = Enum5.flag_3;

	private Enum6 enum6_0;

	public Class9(string string_1)
	{
		Class8 structure = Delegate66.smethod_0(string_1);
		intptr_2 = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(Class8)));
		Marshal.StructureToPtr((object)structure, intptr_2, fDeleteOld: false);
	}

	~Class9()
	{
		Class28.smethod_0(4833018, this, null);
	}
}
