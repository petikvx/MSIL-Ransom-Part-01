using System;
using System.Runtime.InteropServices;

namespace ns1;

internal abstract class Class38
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct Struct2
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public ushort ushort_2;

		public Struct2(ushort ushort_3)
		{
			ushort_0 = 0;
			ushort_1 = ushort_3;
			ushort_2 = 0;
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct Struct3
	{
		public ushort ushort_0;

		public ushort ushort_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Struct4
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

		public static Struct4 smethod_0()
		{
			Struct4 result = default(Struct4);
			result.uint_0 = 4277077181u;
			result.uint_1 = 65536u;
			result.uint_6 = 63u;
			result.uint_8 = 4u;
			result.uint_10 = 0u;
			result.uint_9 = 2u;
			return result;
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Struct5
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public ushort ushort_2;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Struct6
	{
		public byte byte_0;

		public byte byte_1;

		public byte byte_2;

		public byte byte_3;

		public ushort ushort_0;

		public ushort ushort_1;

		public uint uint_0;

		public ushort ushort_2;
	}

	public enum Enum6
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

	internal delegate bool Delegate2(IntPtr hModule, IntPtr lpszType, IntPtr lParam);

	internal delegate bool Delegate3(IntPtr hModule, IntPtr lpszType, IntPtr lpszName, IntPtr lParam);

	internal delegate bool Delegate4(IntPtr hModule, IntPtr lpszType, IntPtr lpszName, ushort wIDLanguage, IntPtr lParam);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern IntPtr LoadLibraryEx(string string_0, IntPtr intptr_0, uint uint_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern bool FreeLibrary(IntPtr intptr_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern bool EnumResourceTypesW(IntPtr intptr_0, Delegate2 delegate2_0, IntPtr intptr_1);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern bool EnumResourceNamesW(IntPtr intptr_0, IntPtr intptr_1, Delegate3 delegate3_0, IntPtr intptr_2);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern bool EnumResourceLanguagesW(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, Delegate4 delegate4_0, IntPtr intptr_3);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	internal static extern IntPtr FindResourceExW(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, ushort ushort_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern IntPtr LockResource(IntPtr intptr_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern IntPtr LoadResource(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern int SizeofResource(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern IntPtr BeginUpdateResourceW(string string_0, bool bool_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern bool UpdateResourceW(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, ushort ushort_0, byte[] byte_0, uint uint_0);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	internal static extern bool EndUpdateResourceW(IntPtr intptr_0, bool bool_0);
}
