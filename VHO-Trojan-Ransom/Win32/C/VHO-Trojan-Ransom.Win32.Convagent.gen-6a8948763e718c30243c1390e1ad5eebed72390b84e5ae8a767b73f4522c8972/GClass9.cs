using System;
using System.Runtime.InteropServices;

public class GClass9
{
	public struct GStruct0
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;
	}

	public struct GStruct1
	{
		public ushort ushort_0;

		private ushort ushort_1;

		public uint uint_0;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public ushort ushort_2;

		public ushort ushort_3;
	}

	[DllImport("kernel32.dll")]
	public static extern int VirtualQueryEx(IntPtr intptr_0, IntPtr intptr_1, out GStruct0 gstruct0_0, uint uint_0);

	[DllImport("kernel32.dll")]
	public static extern void GetSystemInfo(out GStruct1 gstruct1_0);

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(uint uint_0, bool bool_0, int int_0);

	[DllImport("kernel32.dll")]
	public static extern bool ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, [Out] byte[] byte_0, uint uint_0, out IntPtr intptr_2);
}
