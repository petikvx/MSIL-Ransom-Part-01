using System;
using System.Runtime.InteropServices;

public class GClass6
{
	public struct GStruct1
	{
		public int int_0;

		public uint uint_0;

		public IntPtr intptr_0;

		[MarshalAs(UnmanagedType.LPStr)]
		public string string_0;

		[MarshalAs(UnmanagedType.LPStr)]
		public string string_1;

		[MarshalAs(UnmanagedType.LPStr)]
		public string string_2;

		[MarshalAs(UnmanagedType.LPStr)]
		public string string_3;

		public int int_1;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		[MarshalAs(UnmanagedType.LPStr)]
		public string string_4;

		public IntPtr intptr_3;

		public uint uint_1;

		public IntPtr intptr_4;

		public IntPtr intptr_5;
	}

	public static uint uint_0;

	public static uint uint_1;

	public static uint uint_2;

	public static int int_0;

	[DllImport("shell32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool ShellExecuteEx(ref GStruct1 gstruct1_0);

	public static void smethod_0(string string_0)
	{
		Class29.smethod_0(7532784, null, string_0);
	}

	static GClass6()
	{
		Class29.smethod_0(7536100, null, null);
	}
}
