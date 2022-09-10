using System;
using System.Runtime.InteropServices;

namespace ns7;

internal abstract class Class21
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct Struct0
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public ushort ushort_2;

		public Struct0(ushort ushort_3)
		{
			ushort_0 = 0;
			ushort_1 = ushort_3;
			ushort_2 = 0;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct Struct1
	{
		public ushort ushort_0;

		public ushort ushort_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Struct2
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public uint uint_7;

		public uint uint_8;

		public uint uint_9;

		public uint uint_10;

		public uint uint_11;

		public uint uint_12;

		public static Struct2 smethod_0()
		{
			Struct2 result = default(Struct2);
			result.uint_0 = 4277077181u;
			result.uint_1 = 65536u;
			result.uint_6 = 63u;
			result.uint_8 = 4u;
			result.uint_10 = 0u;
			result.uint_9 = 2u;
			return result;
		}
	}

	public enum Enum5
	{
		const_0 = 1,
		const_1 = 2,
		const_2 = 3,
		const_3 = 4,
		const_4 = 5,
		const_5 = 6,
		const_6 = 7,
		const_7 = 8,
		const_8 = 9,
		const_9 = 10,
		const_10 = 11,
		const_11 = 12,
		const_12 = 14,
		const_13 = 16,
		const_14 = 17,
		const_15 = 19,
		const_16 = 20,
		const_17 = 21,
		const_18 = 22,
		const_19 = 23,
		const_20 = 24
	}

	internal delegate bool Delegate0(IntPtr hModule, IntPtr lpszType, IntPtr lParam);

	internal delegate bool Delegate1(IntPtr hModule, IntPtr lpszType, IntPtr lpszName, IntPtr lParam);

	internal delegate bool Delegate2(IntPtr hModule, IntPtr lpszType, IntPtr lpszName, ushort wIDLanguage, IntPtr lParam);
}
