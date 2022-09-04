using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class7
{
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr intptr_0, string string_0, string string_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SizeofResource(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr intptr_0, IntPtr intptr_1);

	public unsafe static byte[] smethod_0(object object_0)
	{
		IntPtr moduleHandleA = GetModuleHandleA(ref *(string*)(&object_0));
		IntPtr intptr_ = FindResource(moduleHandleA, "12", "Simon");
		IntPtr source = LoadResource(moduleHandleA, intptr_);
		int num = SizeofResource(moduleHandleA, intptr_);
		byte[] array = new byte[checked(num - 1 + 1)];
		Marshal.Copy(source, array, 0, num);
		return array;
	}
}
