using System;
using System.Runtime.InteropServices;

namespace ns0;

internal class Class9
{
	[Flags]
	public enum Enum0
	{
		flag_0 = 1,
		flag_1 = 2
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct Struct0
	{
		public int int_0;

		public Enum0 enum0_0;

		public IntPtr intptr_0;

		public string string_0;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct Struct1
	{
		public int int_0;

		public IntPtr intptr_0;
	}

	public static string string_0;
}
