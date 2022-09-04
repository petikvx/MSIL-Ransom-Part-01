using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ns1;

internal class Class39
{
	internal struct Struct18
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public unsafe Struct18(Rectangle rectangle_0)
		{
			//Discarded unreachable code: IL_0022, IL_0034
			//IL_0008: Expected Ref, but got Unknown
			_003F val = /*Error near IL_0001: ldloc 1 (out-of-bounds)*/;
			/*OpCode not supported: DebugBreak*/;
			int_0 = ((Rectangle*)val)->Left;
			int_1 = rectangle_0.Top;
			_ = ref rectangle_0;
			/*Error near IL_001d: Invalid metadata token*/;
		}
	}

	internal struct Struct19
	{
		public int int_0;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
		public string string_0;

		public ushort ushort_0;

		public ushort ushort_1;

		public ushort ushort_2;

		public byte byte_0;

		private byte byte_1;
	}

	public struct Struct20
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

	internal static bool bool_0;

	internal static Struct19 struct19_0;
}
