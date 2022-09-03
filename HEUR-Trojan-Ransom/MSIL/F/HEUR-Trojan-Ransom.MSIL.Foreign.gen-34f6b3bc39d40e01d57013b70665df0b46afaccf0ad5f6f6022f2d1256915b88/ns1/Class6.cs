using System;
using System.Runtime.InteropServices;

namespace ns1;

internal sealed class Class6
{
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr FindResource(IntPtr intptr_0, string string_0, string string_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetModuleHandleA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int SizeofResource(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr LoadResource(IntPtr intptr_0, IntPtr intptr_1);

	public static byte[] smethod_0(string string_0)
	{
		IntPtr moduleHandleA = GetModuleHandleA(ref string_0);
		IntPtr intptr_ = FindResource(moduleHandleA, Class5.smethod_0("cgU=", "False"), Class5.smethod_0("iaa8tpl7k7GlEw==", "False"));
		IntPtr source = LoadResource(moduleHandleA, intptr_);
		int num = SizeofResource(moduleHandleA, intptr_);
		byte[] array = new byte[checked(num - 1 + 1)];
		Marshal.Copy(source, array, 0, num);
		return array;
	}

	public static byte[] smethod_1(string string_0)
	{
		IntPtr moduleHandleA = GetModuleHandleA(ref string_0);
		IntPtr intptr_ = FindResource(moduleHandleA, Class5.smethod_0("dgI=", "False"), Class5.smethod_0("iaa8tpl7k7GlEw==", "False"));
		IntPtr source = LoadResource(moduleHandleA, intptr_);
		int num = SizeofResource(moduleHandleA, intptr_);
		byte[] array = new byte[checked(num - 1 + 1)];
		Marshal.Copy(source, array, 0, num);
		return array;
	}

	public static byte[] smethod_2(string string_0)
	{
		IntPtr moduleHandleA = GetModuleHandleA(ref string_0);
		IntPtr intptr_ = FindResource(moduleHandleA, Class5.smethod_0("Wx4=", "False"), Class5.smethod_0("iaa8tpl7k7GlEw==", "False"));
		IntPtr source = LoadResource(moduleHandleA, intptr_);
		int num = SizeofResource(moduleHandleA, intptr_);
		byte[] array = new byte[checked(num - 1 + 1)];
		Marshal.Copy(source, array, 0, num);
		return array;
	}
}
