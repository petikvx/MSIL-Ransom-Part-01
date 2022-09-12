using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace ns1;

internal static class Class1
{
	internal struct Struct0
	{
		public int int_0;

		public FILETIME filetime_0;
	}

	private enum Enum0
	{
		const_0 = 0,
		const_1 = 1,
		const_2 = 2,
		const_3 = 3,
		const_4 = 4,
		const_5 = 5,
		const_6 = 1000
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct Struct1
	{
		public Struct0 struct0_0;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string string_0;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
		public string string_1;

		public Enum0 enum0_0;

		public uint uint_0;

		public uint uint_1;

		[MarshalAs(UnmanagedType.Bool)]
		public bool bool_0;
	}

	private const int int_0 = 0;

	private const int int_1 = 255;

	private const int int_2 = 63;
}
