using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace ns9;

internal class Class51
{
	internal struct Struct15
	{
		public int int_0;

		public int int_1;

		public int int_2;

		public int int_3;

		public Struct15(Rectangle rectangle_0)
		{
			int num = 3;
			if (!n5dVHAGcdvQJ9VLmHvu())
			{
			}
			do
			{
				switch (num)
				{
				case 0:
				case 3:
					goto IL_000e;
				case 1:
					int_1 = rectangle_0.Top;
					int_3 = rectangle_0.Bottom;
					break;
				case 5:
					return;
				}
				break;
				IL_000e:
				int_0 = rectangle_0.Left;
				num = 1;
			}
			while (!n5dVHAGcdvQJ9VLmHvu());
			int_2 = rectangle_0.Right;
		}

		internal static bool irqBHAGn3Bv9Xyr5bWD()
		{
			return true;
		}

		internal static bool n5dVHAGcdvQJ9VLmHvu()
		{
			return false;
		}
	}

	internal struct Struct16
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

	public struct Struct17
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

	internal static Struct16 struct16_0;
}
